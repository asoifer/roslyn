// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

using System.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class OverloadResolutionResult<TMember> where TMember : Symbol
    {
        private MemberResolutionResult<TMember> _bestResult;

        private ThreeState _bestResultState;

        internal readonly ArrayBuilder<MemberResolutionResult<TMember>> ResultsBuilder;

        internal OverloadResolutionResult()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10875, 1281, 1426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 1092, 1108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 1183, 1197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 1341, 1415);

                this.ResultsBuilder = f_10875_1363_1414();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10875, 1281, 1426);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 1281, 1426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 1281, 1426);
            }
        }

        internal void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 1438, 1644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 1484, 1539);

                _bestResult = default(MemberResolutionResult<TMember>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 1553, 1591);

                _bestResultState = ThreeState.Unknown;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 1605, 1633);

                f_10875_1605_1632(this.ResultsBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 1438, 1644);

                int
                f_10875_1605_1632(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 1605, 1632);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 1438, 1644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 1438, 1644);
            }
        }

        public bool Succeeded
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 1834, 2003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 1870, 1895);

                    f_10875_1870_1894(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 1915, 1988);

                    return _bestResultState == ThreeState.True && (DynAbs.Tracing.TraceSender.Expression_True(10875, 1922, 1987) && _bestResult.Result.IsValid);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 1834, 2003);

                    int
                    f_10875_1870_1894(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                    this_param)
                    {
                        this_param.EnsureBestResultLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 1870, 1894);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 1788, 2014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 1788, 2014);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MemberResolutionResult<TMember> ValidResult
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 2304, 2517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 2340, 2365);

                    f_10875_2340_2364(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 2385, 2465);

                    f_10875_2385_2464(_bestResultState == ThreeState.True && (DynAbs.Tracing.TraceSender.Expression_True(10875, 2398, 2463) && _bestResult.Result.IsValid));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 2483, 2502);

                    return _bestResult;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 2304, 2517);

                    int
                    f_10875_2340_2364(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                    this_param)
                    {
                        this_param.EnsureBestResultLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 2340, 2364);
                        return 0;
                    }


                    int
                    f_10875_2385_2464(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 2385, 2464);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 2229, 2528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 2229, 2528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void EnsureBestResultLoaded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 2540, 2768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 2602, 2757) || true) && (!f_10875_2607_2634(_bestResultState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 2602, 2757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 2668, 2742);

                    _bestResultState = f_10875_2687_2741(this.ResultsBuilder, out _bestResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 2602, 2757);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 2540, 2768);

                bool
                f_10875_2607_2634(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.HasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 2607, 2634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10875_2687_2741(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                allResults, out Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                best)
                {
                    var return_v = TryGetBestResult(allResults, out best);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 2687, 2741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 2540, 2768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 2540, 2768);
            }
        }

        public MemberResolutionResult<TMember> BestResult
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 3241, 3424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 3277, 3302);

                    f_10875_3277_3301(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 3322, 3372);

                    f_10875_3322_3371(_bestResultState == ThreeState.True);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 3390, 3409);

                    return _bestResult;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 3241, 3424);

                    int
                    f_10875_3277_3301(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                    this_param)
                    {
                        this_param.EnsureBestResultLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 3277, 3301);
                        return 0;
                    }


                    int
                    f_10875_3322_3371(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 3322, 3371);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 3167, 3435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 3167, 3435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<MemberResolutionResult<TMember>> Results
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 3759, 3851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 3795, 3836);

                    return f_10875_3802_3835(this.ResultsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 3759, 3851);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                    f_10875_3802_3835(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 3802, 3835);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 3672, 3862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 3672, 3862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasAnyApplicableMember
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 4249, 4545);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 4285, 4497);
                        foreach (var res in f_10875_4305_4324_I(this.ResultsBuilder))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 4285, 4497);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 4366, 4478) || true) && (res.Result.IsApplicable)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 4366, 4478);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 4443, 4455);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 4366, 4478);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 4285, 4497);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 213);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 213);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 4517, 4530);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 4249, 4545);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                    f_10875_4305_4324_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 4305, 4324);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 4188, 4556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 4188, 4556);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<TMember> GetAllApplicableMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 4720, 5127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 4803, 4852);

                var
                result = f_10875_4816_4851()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 4866, 5065);
                    foreach (var res in f_10875_4886_4905_I(this.ResultsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 4866, 5065);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 4939, 5050) || true) && (res.Result.IsApplicable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 4939, 5050);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5008, 5031);

                            f_10875_5008_5030(result, res.Member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 4939, 5050);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 4866, 5065);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 200);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5081, 5116);

                return f_10875_5088_5115(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 4720, 5127);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                f_10875_4816_4851()
                {
                    var return_v = ArrayBuilder<TMember>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 4816, 4851);
                    return return_v;
                }


                int
                f_10875_5008_5030(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param, TMember
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 5008, 5030);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10875_4886_4905_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 4886, 4905);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TMember>
                f_10875_5088_5115(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 5088, 5115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 4720, 5127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 4720, 5127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ThreeState TryGetBestResult(ArrayBuilder<MemberResolutionResult<TMember>> allResults, out MemberResolutionResult<TMember> best)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 5139, 6273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5306, 5354);

                best = default(MemberResolutionResult<TMember>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5368, 5407);

                ThreeState
                haveBest = ThreeState.False
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5423, 6042);
                    foreach (var pair in f_10875_5444_5454_I(allResults))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 5423, 6042);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5488, 6027) || true) && (pair.Result.IsValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 5488, 6027);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5553, 5923) || true) && (haveBest == ThreeState.True)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 5553, 5923);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5634, 5776);

                                f_10875_5634_5775(false, "How did we manage to get two methods in the overload resolution results that were both better than every other method?");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5802, 5850);

                                best = default(MemberResolutionResult<TMember>);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5876, 5900);

                                return ThreeState.False;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 5553, 5923);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5947, 5974);

                            haveBest = ThreeState.True;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 5996, 6008);

                            best = pair;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 5488, 6027);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 5423, 6042);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 620);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 6246, 6262);

                return haveBest;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 5139, 6273);

                int
                f_10875_5634_5775(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 5634, 5775);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10875_5444_5454_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 5444, 5454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 5139, 6273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 5139, 6273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ReportDiagnostics<T>(
                    Binder binder,
                    Location location,
                    SyntaxNode nodeOpt,
                    DiagnosticBag diagnostics,
                    string name,
                    BoundExpression receiver,
                    SyntaxNode invokedExpression,
                    AnalyzedArguments arguments,
                    ImmutableArray<T> memberGroup, // the T is just a convenience for the caller
                    NamedTypeSymbol typeContainingConstructor,
                    NamedTypeSymbol delegateTypeBeingInvoked,
                    CSharpSyntaxNode queryClause = null,
                    bool isMethodGroupConversion = false,
                    RefKind? returnRefKind = null,
                    TypeSymbol delegateOrFunctionPointerType = null) where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 7140, 27640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 7908, 8015);

                f_10875_7908_8014<T>(f_10875_7921_7936_M(!this.Succeeded), "Don't ask for diagnostic info on a successful overload resolution result.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 8124, 8186);

                f_10875_8124_8185<T>(f_10875_8137_8184<T>(arguments.Arguments, a => a.Display != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 8346, 8384);

                f_10875_8346_8383<T>(this, MemberResolutionKind.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 8400, 8451);

                var
                symbols = f_10875_8414_8450<T>(memberGroup)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 8789, 8904) || true) && (f_10875_8793_8848<T>(this, diagnostics, symbols, location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 8789, 8904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 8882, 8889);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 8789, 8904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 9162, 9218);

                f_10875_9162_9217<T>(this, MemberResolutionKind.ApplicableInNormalForm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 9232, 9290);

                f_10875_9232_9289<T>(this, MemberResolutionKind.ApplicableInExpandedForm);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 10349, 10502) || true) && (f_10875_10353_10446<T>(this, diagnostics, symbols, location, queryClause != null, receiver, name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 10349, 10502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 10480, 10487);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 10349, 10502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 10700, 10739);

                f_10875_10700_10738<T>(this, MemberResolutionKind.Worse);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 10993, 11038);

                f_10875_10993_11037<T>(this, MemberResolutionKind.LessDerived);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 11666, 11774) || true) && (f_10875_11670_11718<T>(diagnostics, arguments))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 11666, 11774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 11752, 11759);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 11666, 11774);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 12091, 12302) || true) && (f_10875_12095_12246<T>(this, diagnostics, symbols, f_10875_12143_12175_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(invokedExpression, 10875, 12143, 12175)?.GetLocation()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10875, 12143, 12187) ?? location), binder, receiver, nodeOpt, delegateOrFunctionPointerType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 12091, 12302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 12280, 12287);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 12091, 12302);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 12800, 13035) || true) && (isMethodGroupConversion && (DynAbs.Tracing.TraceSender.Expression_True(10875, 12804, 12852) && returnRefKind != null) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 12804, 12979) && f_10875_12873_12979<T>(this, location, diagnostics, f_10875_12914_12947<T>(returnRefKind), delegateOrFunctionPointerType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 12800, 13035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 13013, 13020);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 12800, 13035);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 13294, 13397) || true) && (f_10875_13298_13341<T>(this, location, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 13294, 13397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 13375, 13382);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 13294, 13397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 13455, 13506);

                f_10875_13455_13505<T>(this, MemberResolutionKind.ConstraintFailure);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 13707, 13878) || true) && (f_10875_13711_13822<T>(this, diagnostics, binder, name, arguments, symbols, location, binder.Flags, isMethodGroupConversion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 13707, 13878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 13856, 13863);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 13707, 13878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 13936, 13991);

                f_10875_13936_13990<T>(this, MemberResolutionKind.BadArgumentConversion);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 14243, 14410) || true) && (f_10875_14247_14354<T>(this, f_10875_14292_14310<T>(binder), f_10875_14312_14330<T>(binder), diagnostics, location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 14243, 14410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 14388, 14395);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 14243, 14410);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 14468, 14543);

                f_10875_14468_14542<T>(this, MemberResolutionKind.ConstructedParameterFailedConstraintCheck);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 14754, 14870) || true) && (f_10875_14758_14814<T>(this, diagnostics, symbols, location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 14754, 14870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 14848, 14855);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 14754, 14870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 14928, 14986);

                f_10875_14928_14985<T>(this, MemberResolutionKind.InaccessibleTypeArgument);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 15154, 15307) || true) && (f_10875_15158_15251<T>(this, binder, diagnostics, symbols, receiver, arguments, location, queryClause))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 15154, 15307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 15285, 15292);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 15154, 15307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 15365, 15418);

                f_10875_15365_15417<T>(this, MemberResolutionKind.TypeInferenceFailed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 15432, 15504);

                f_10875_15432_15503<T>(this, MemberResolutionKind.TypeInferenceExtensionInstanceArgument);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 15876, 15950) || true) && (f_10875_15880_15894<T>(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 15876, 15950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 15928, 15935);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 15876, 15950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 16008, 16054);

                f_10875_16008_16053<T>(this, MemberResolutionKind.UseSiteError);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 16517, 16573);

                bool
                supportedRequiredParameterMissingConflicts = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 16587, 16677);

                MemberResolutionResult<TMember>
                firstSupported = default(MemberResolutionResult<TMember>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 16691, 16783);

                MemberResolutionResult<TMember>
                firstUnsupported = default(MemberResolutionResult<TMember>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 16799, 16869);

                var
                supportedInPriorityOrder = new MemberResolutionResult<TMember>[7]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 16918, 16963);

                const int
                duplicateNamedArgumentPriority = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 16977, 17024);

                const int
                requiredParameterMissingPriority = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17038, 17082);

                const int
                nameUsedForPositionalPriority = 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17096, 17148);

                const int
                noCorrespondingNamedParameterPriority = 3
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17162, 17209);

                const int
                noCorrespondingParameterPriority = 4
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17223, 17273);

                const int
                badNonTrailingNamedArgumentPriority = 5
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17287, 17332);

                const int
                wrongCallingConventionPriority = 6
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17348, 21645);
                    foreach (MemberResolutionResult<TMember> result in f_10875_17399_17418_I(this.ResultsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17348, 21645);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17452, 21630);

                        switch (result.Result.Kind)
                        {

                            case MemberResolutionKind.UnsupportedMetadata:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17452, 21630);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17592, 17728) || true) && (firstSupported.IsNull)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17592, 17728);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17675, 17701);

                                    firstUnsupported = result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17592, 17728);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10875, 17754, 17760);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17452, 21630);

                            case MemberResolutionKind.NoCorrespondingNamedParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17452, 21630);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 17864, 18253) || true) && (supportedInPriorityOrder[noCorrespondingNamedParameterPriority].IsNull || (DynAbs.Tracing.TraceSender.Expression_False(10875, 17868, 18095) || result.Result.BadArgumentsOpt[0] > supportedInPriorityOrder[noCorrespondingNamedParameterPriority].Result.BadArgumentsOpt[0]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17864, 18253);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 18153, 18226);

                                    supportedInPriorityOrder[noCorrespondingNamedParameterPriority] = result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17864, 18253);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10875, 18279, 18285);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17452, 21630);

                            case MemberResolutionKind.NoCorrespondingParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17452, 21630);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 18384, 18606) || true) && (supportedInPriorityOrder[noCorrespondingParameterPriority].IsNull)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 18384, 18606);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 18511, 18579);

                                    supportedInPriorityOrder[noCorrespondingParameterPriority] = result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 18384, 18606);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10875, 18632, 18638);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17452, 21630);

                            case MemberResolutionKind.RequiredParameterMissing:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17452, 21630);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 18737, 19211) || true) && (supportedInPriorityOrder[requiredParameterMissingPriority].IsNull)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 18737, 19211);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 18864, 18922);

                                    f_10875_18864_18921<T>(!supportedRequiredParameterMissingConflicts);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 18952, 19020);

                                    supportedInPriorityOrder[requiredParameterMissingPriority] = result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 18737, 19211);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 18737, 19211);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 19134, 19184);

                                    supportedRequiredParameterMissingConflicts = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 18737, 19211);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10875, 19237, 19243);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17452, 21630);

                            case MemberResolutionKind.NameUsedForPositional:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17452, 21630);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 19339, 19704) || true) && (supportedInPriorityOrder[nameUsedForPositionalPriority].IsNull || (DynAbs.Tracing.TraceSender.Expression_False(10875, 19343, 19554) || result.Result.BadArgumentsOpt[0] > supportedInPriorityOrder[nameUsedForPositionalPriority].Result.BadArgumentsOpt[0]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 19339, 19704);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 19612, 19677);

                                    supportedInPriorityOrder[nameUsedForPositionalPriority] = result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 19339, 19704);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10875, 19730, 19736);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17452, 21630);

                            case MemberResolutionKind.BadNonTrailingNamedArgument:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17452, 21630);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 19838, 20221) || true) && (supportedInPriorityOrder[badNonTrailingNamedArgumentPriority].IsNull || (DynAbs.Tracing.TraceSender.Expression_False(10875, 19842, 20065) || result.Result.BadArgumentsOpt[0] > supportedInPriorityOrder[badNonTrailingNamedArgumentPriority].Result.BadArgumentsOpt[0]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 19838, 20221);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 20123, 20194);

                                    supportedInPriorityOrder[badNonTrailingNamedArgumentPriority] = result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 19838, 20221);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10875, 20247, 20253);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17452, 21630);

                            case MemberResolutionKind.DuplicateNamedArgument:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17452, 21630);
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 20381, 20761) || true) && (supportedInPriorityOrder[duplicateNamedArgumentPriority].IsNull || (DynAbs.Tracing.TraceSender.Expression_False(10875, 20385, 20598) || result.Result.BadArgumentsOpt[0] > supportedInPriorityOrder[duplicateNamedArgumentPriority].Result.BadArgumentsOpt[0]))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 20381, 20761);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 20664, 20730);

                                        supportedInPriorityOrder[duplicateNamedArgumentPriority] = result;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 20381, 20761);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10875, 20814, 20820);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17452, 21630);

                            case MemberResolutionKind.WrongCallingConvention:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17452, 21630);
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 20948, 21178) || true) && (supportedInPriorityOrder[wrongCallingConventionPriority].IsNull)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 20948, 21178);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 21081, 21147);

                                        supportedInPriorityOrder[wrongCallingConventionPriority] = result;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 20948, 21178);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10875, 21231, 21237);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17452, 21630);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 17452, 21630);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 21550, 21611);

                                throw f_10875_21556_21610<T>(result.Result.Kind);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17452, 21630);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 17348, 21645);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 4298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 4298);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 21661, 21899);
                    foreach (var supported in f_10875_21687_21711_I(supportedInPriorityOrder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 21661, 21899);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 21745, 21884) || true) && (supported.IsNotNull)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 21745, 21884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 21810, 21837);

                            firstSupported = supported;
                            DynAbs.Tracing.TraceSender.TraceBreak(10875, 21859, 21865);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 21745, 21884);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 21661, 21899);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 239);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 22014, 26809) || true) && (firstSupported.IsNotNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 22014, 26809);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 22076, 26079) || true) && (firstSupported.Member is FunctionPointerMethodSymbol
                    && (DynAbs.Tracing.TraceSender.Expression_True(10875, 22080, 22237) && firstSupported.Result.Kind == MemberResolutionKind.NoCorrespondingNamedParameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 22076, 26079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 22279, 22333);

                        int
                        badArg = firstSupported.Result.BadArgumentsOpt[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 22355, 22410);

                        IdentifierNameSyntax
                        badName = f_10875_22386_22409<T>(arguments.Names, badArg)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 22432, 22530);

                        f_10875_22432_22529<T>(diagnostics, ErrorCode.ERR_FunctionPointersCannotBeCalledWithNamedArguments, f_10875_22512_22528<T>(badName));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 22552, 22559);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 22076, 26079);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 22076, 26079);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 22776, 26079) || true) && (!(firstSupported.Result.Kind == MemberResolutionKind.RequiredParameterMissing && (DynAbs.Tracing.TraceSender.Expression_True(10875, 22782, 22903) && supportedRequiredParameterMissingConflicts))
                        && (DynAbs.Tracing.TraceSender.Expression_True(10875, 22780, 22953) && !isMethodGroupConversion
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 22780, 23230) && (firstSupported.Member is not FunctionPointerMethodSymbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 22776, 26079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 23272, 25723);

                            switch (firstSupported.Result.Kind)
                            {

                                case MemberResolutionKind.NameUsedForPositional:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 23272, 25723);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 23656, 23733);

                                    f_10875_23656_23732<T>(firstSupported, diagnostics, arguments, symbols);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 23763, 23770);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 23272, 25723);

                                case MemberResolutionKind.NoCorrespondingNamedParameter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 23272, 25723);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 24089, 24206);

                                    f_10875_24089_24205<T>(firstSupported, name, diagnostics, arguments, delegateTypeBeingInvoked, symbols);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 24236, 24243);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 23272, 25723);

                                case MemberResolutionKind.RequiredParameterMissing:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 23272, 25723);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 24714, 24819);

                                    f_10875_24714_24818<T>(firstSupported, diagnostics, delegateTypeBeingInvoked, symbols, location);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 24849, 24856);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 23272, 25723);

                                case MemberResolutionKind.NoCorrespondingParameter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 23272, 25723);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10875, 25068, 25074);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 23272, 25723);

                                case MemberResolutionKind.BadNonTrailingNamedArgument:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 23272, 25723);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 25367, 25450);

                                    f_10875_25367_25449<T>(firstSupported, diagnostics, arguments, symbols);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 25480, 25487);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 23272, 25723);

                                case MemberResolutionKind.DuplicateNamedArgument:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 23272, 25723);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 25594, 25663);

                                    f_10875_25594_25662<T>(this, firstSupported, diagnostics, arguments);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 25693, 25700);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 23272, 25723);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 22776, 26079);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 22776, 26079);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 25765, 26079) || true) && (firstSupported.Result.Kind == MemberResolutionKind.WrongCallingConvention)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 25765, 26079);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 25884, 26031);

                                f_10875_25884_26030<T>(location, diagnostics, symbols, firstSupported, f_10875_25961_26029<T>(((FunctionPointerTypeSymbol)delegateOrFunctionPointerType)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 26053, 26060);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 25765, 26079);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 22776, 26079);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 22076, 26079);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 22014, 26809);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 22014, 26809);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 26113, 26809) || true) && (firstUnsupported.IsNotNull)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 26113, 26809);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 26693, 26769);

                        f_10875_26693_26768<T>(location, diagnostics, symbols, firstUnsupported);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 26787, 26794);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 26113, 26809);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 22014, 26809);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 27426, 27629) || true) && (!isMethodGroupConversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 27426, 27629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 27488, 27614);

                    f_10875_27488_27613<T>(diagnostics, name, arguments, symbols, location, typeContainingConstructor, delegateTypeBeingInvoked);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 27426, 27629);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 7140, 27640);

                bool
                f_10875_7921_7936_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 7921, 7936);
                    return return_v;
                }


                int
                f_10875_7908_8014<T>(bool
                condition, string
                message) where T : Symbol

                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 7908, 8014);
                    return 0;
                }


                bool
                f_10875_8137_8184<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.BoundExpression, bool>
                predicate) where T : Symbol

                {
                    var return_v = builder.All<Microsoft.CodeAnalysis.CSharp.BoundExpression>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 8137, 8184);
                    return return_v;
                }


                int
                f_10875_8124_8185<T>(bool
                condition) where T : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 8124, 8185);
                    return 0;
                }


                int
                f_10875_8346_8383<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 8346, 8383);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10875_8414_8450<T>(System.Collections.Immutable.ImmutableArray<T>
                from) where T : Symbol

                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 8414, 8450);
                    return return_v;
                }


                bool
                f_10875_8793_8848<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.Location
                location) where T : Symbol

                {
                    var return_v = this_param.HadAmbiguousBestMethods(diagnostics, symbols, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 8793, 8848);
                    return return_v;
                }


                int
                f_10875_9162_9217<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 9162, 9217);
                    return 0;
                }


                int
                f_10875_9232_9289<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 9232, 9289);
                    return 0;
                }


                bool
                f_10875_10353_10446<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.Location
                location, bool
                isQuery, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                name) where T : Symbol

                {
                    var return_v = this_param.HadAmbiguousWorseMethods(diagnostics, symbols, location, isQuery, receiver, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 10353, 10446);
                    return return_v;
                }


                int
                f_10875_10700_10738<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 10700, 10738);
                    return 0;
                }


                int
                f_10875_10993_11037<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 10993, 11037);
                    return 0;
                }


                bool
                f_10875_11670_11718<T>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments) where T : Symbol

                {
                    var return_v = HadLambdaConversionError(diagnostics, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 11670, 11718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location?
                f_10875_12143_12175_I(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 12143, 12175);
                    return return_v;
                }


                bool
                f_10875_12095_12246<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.SyntaxNode
                nodeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                delegateOrFunctionPointerType) where T : Symbol

                {
                    var return_v = this_param.HadStaticInstanceMismatch(diagnostics, symbols, location, binder, receiverOpt, nodeOpt, delegateOrFunctionPointerType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 12095, 12246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10875_12914_12947<T>(Microsoft.CodeAnalysis.RefKind?
                this_param) where T : Symbol

                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 12914, 12947);
                    return return_v;
                }


                bool
                f_10875_12873_12979<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                delegateOrFunctionPointerType) where T : Symbol

                {
                    var return_v = this_param.HadReturnMismatch(location, diagnostics, refKind, delegateOrFunctionPointerType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 12873, 12979);
                    return return_v;
                }


                bool
                f_10875_13298_13341<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics) where T : Symbol

                {
                    var return_v = this_param.HadConstraintFailure(location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 13298, 13341);
                    return return_v;
                }


                int
                f_10875_13455_13505<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 13455, 13505);
                    return 0;
                }


                bool
                f_10875_13711_13822<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder
                binder, string
                name, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, bool
                isMethodGroupConversion) where T : Symbol

                {
                    var return_v = this_param.HadBadArguments(diagnostics, binder, name, arguments, symbols, location, flags, isMethodGroupConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 13711, 13822);
                    return return_v;
                }


                int
                f_10875_13936_13990<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 13936, 13990);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10875_14292_14310<T>(Microsoft.CodeAnalysis.CSharp.Binder
                this_param) where T : Symbol

                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 14292, 14310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10875_14312_14330<T>(Microsoft.CodeAnalysis.CSharp.Binder
                this_param) where T : Symbol

                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 14312, 14330);
                    return return_v;
                }


                bool
                f_10875_14247_14354<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location) where T : Symbol

                {
                    var return_v = this_param.HadConstructedParameterFailedConstraintCheck((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, compilation, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 14247, 14354);
                    return return_v;
                }


                int
                f_10875_14468_14542<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 14468, 14542);
                    return 0;
                }


                bool
                f_10875_14758_14814<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.Location
                location) where T : Symbol

                {
                    var return_v = this_param.InaccessibleTypeArgument(diagnostics, symbols, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 14758, 14814);
                    return return_v;
                }


                int
                f_10875_14928_14985<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 14928, 14985);
                    return 0;
                }


                bool
                f_10875_15158_15251<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause) where T : Symbol

                {
                    var return_v = this_param.TypeInferenceFailed(binder, diagnostics, symbols, receiver, arguments, location, queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 15158, 15251);
                    return return_v;
                }


                int
                f_10875_15365_15417<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 15365, 15417);
                    return 0;
                }


                int
                f_10875_15432_15503<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 15432, 15503);
                    return 0;
                }


                bool
                f_10875_15880_15894<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param) where T : Symbol

                {
                    var return_v = this_param.UseSiteError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 15880, 15894);
                    return return_v;
                }


                int
                f_10875_16008_16053<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind) where T : Symbol

                {
                    this_param.AssertNone(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 16008, 16053);
                    return 0;
                }


                int
                f_10875_18864_18921<T>(bool
                condition) where T : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 18864, 18921);
                    return 0;
                }


                System.Exception
                f_10875_21556_21610<T>(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                o) where T : Symbol

                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 21556, 21610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10875_17399_17418_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 17399, 17418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>[]
                f_10875_21687_21711_I(Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 21687, 21711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10875_22386_22409<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, int
                i0) where T : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 22386, 22409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10875_22512_22528<T>(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param) where T : Symbol

                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 22512, 22528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_22432_22529<T>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location) where T : Symbol

                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 22432, 22529);
                    return return_v;
                }


                int
                f_10875_23656_23732<T>(Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                bad, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols) where T : Symbol

                {
                    ReportNameUsedForPositional(bad, diagnostics, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 23656, 23732);
                    return 0;
                }


                int
                f_10875_24089_24205<T>(Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                bad, string
                methodName, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeBeingInvoked, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols) where T : Symbol

                {
                    ReportNoCorrespondingNamedParameter(bad, methodName, diagnostics, arguments, delegateTypeBeingInvoked, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 24089, 24205);
                    return 0;
                }


                int
                f_10875_24714_24818<T>(Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                bad, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeBeingInvoked, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.Location
                location) where T : Symbol

                {
                    ReportMissingRequiredParameter(bad, diagnostics, delegateTypeBeingInvoked, symbols, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 24714, 24818);
                    return 0;
                }


                int
                f_10875_25367_25449<T>(Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                bad, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols) where T : Symbol

                {
                    ReportBadNonTrailingNamedArgument(bad, diagnostics, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 25367, 25449);
                    return 0;
                }


                int
                f_10875_25594_25662<T>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                result, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments) where T : Symbol

                {
                    this_param.ReportDuplicateNamedArgument(result, diagnostics, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 25594, 25662);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10875_25961_26029<T>(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol?
                this_param) where T : Symbol

                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 25961, 26029);
                    return return_v;
                }


                int
                f_10875_25884_26030<T>(Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                firstSupported, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                target) where T : Symbol

                {
                    ReportWrongCallingConvention(location, diagnostics, symbols, firstSupported, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 25884, 26030);
                    return 0;
                }


                int
                f_10875_26693_26768<T>(Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                firstUnsupported) where T : Symbol

                {
                    ReportUnsupportedMetadata(location, diagnostics, symbols, firstUnsupported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 26693, 26768);
                    return 0;
                }


                int
                f_10875_27488_27613<T>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, string
                name, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeContainingConstructor, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeBeingInvoked) where T : Symbol

                {
                    ReportBadParameterCount(diagnostics, name, arguments, symbols, location, typeContainingConstructor, delegateTypeBeingInvoked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 27488, 27613);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 7140, 27640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 7140, 27640);
            }
        }

        private static void ReportUnsupportedMetadata(Location location, DiagnosticBag diagnostics, ImmutableArray<Symbol> symbols, MemberResolutionResult<TMember> firstUnsupported)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 27652, 28352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 27850, 27923);

                DiagnosticInfo
                diagInfo = f_10875_27876_27922(firstUnsupported.Member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 27937, 27968);

                f_10875_27937_27967(diagInfo != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 27982, 28042);

                f_10875_27982_28041(f_10875_27995_28012(diagInfo) == DiagnosticSeverity.Error);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 28113, 28261);

                diagInfo = f_10875_28124_28260(f_10875_28183_28196(diagInfo), f_10875_28215_28233(diagInfo), symbols);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 28277, 28341);

                f_10875_28277_28340(diagInfo, diagnostics, location);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 27652, 28352);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10875_27876_27922(TMember
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 27876, 27922);
                    return return_v;
                }


                int
                f_10875_27937_27967(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 27937, 27967);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10875_27995_28012(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 27995, 28012);
                    return return_v;
                }


                int
                f_10875_27982_28041(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 27982, 28041);
                    return 0;
                }


                int
                f_10875_28183_28196(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 28183, 28196);
                    return return_v;
                }


                object[]
                f_10875_28215_28233(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 28215, 28233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_28124_28260(int
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols((Microsoft.CodeAnalysis.CSharp.ErrorCode)errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 28124, 28260);
                    return return_v;
                }


                bool
                f_10875_28277_28340(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 28277, 28340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 27652, 28352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 27652, 28352);
            }
        }

        private static void ReportWrongCallingConvention(Location location, DiagnosticBag diagnostics, ImmutableArray<Symbol> symbols, MemberResolutionResult<TMember> firstSupported, MethodSymbol target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 28364, 28926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 28584, 28672);

                f_10875_28584_28671(firstSupported.Result.Kind == MemberResolutionKind.WrongCallingConvention);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 28686, 28915);

                f_10875_28686_28914(diagnostics, f_10875_28702_28903(ErrorCode.ERR_WrongFuncPtrCallingConvention, new object[] { firstSupported.Member, f_10875_28850_28874(target) }, symbols), location);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 28364, 28926);

                int
                f_10875_28584_28671(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 28584, 28671);
                    return 0;
                }


                Microsoft.Cci.CallingConvention
                f_10875_28850_28874(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 28850, 28874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_28702_28903(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 28702, 28903);
                    return return_v;
                }


                int
                f_10875_28686_28914(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 28686, 28914);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 28364, 28926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 28364, 28926);
            }
        }

        private bool UseSiteError()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 28938, 29528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 28990, 29054);

                var
                bad = f_10875_29000_29053(this, MemberResolutionKind.UseSiteError)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 29068, 29144) || true) && (bad.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 29068, 29144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 29116, 29129);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 29068, 29144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 29160, 29350);

                f_10875_29160_29349(f_10875_29173_29215(f_10875_29173_29206(bad.Member)) == DiagnosticSeverity.Error, "Why did we use MemberResolutionKind.UseSiteError if we didn't have a use site error?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 29505, 29517);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 28938, 29528);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_29000_29053(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 29000, 29053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10875_29173_29206(TMember
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 29173, 29206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10875_29173_29215(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 29173, 29215);
                    return return_v;
                }


                int
                f_10875_29160_29349(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 29160, 29349);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 28938, 29528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 28938, 29528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool InaccessibleTypeArgument(
                    DiagnosticBag diagnostics,
                    ImmutableArray<Symbol> symbols,
                    Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 29540, 30225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 29720, 29805);

                var
                inaccessible = f_10875_29739_29804(this, MemberResolutionKind.InaccessibleTypeArgument)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 29819, 29904) || true) && (inaccessible.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 29819, 29904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 29876, 29889);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 29819, 29904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 30007, 30188);

                f_10875_30007_30187(
                            // error CS0122: 'M<X>(I<X>)' is inaccessible due to its protection level
                            diagnostics, f_10875_30023_30176(ErrorCode.ERR_BadAccess, new object[] { inaccessible.Member }, symbols), location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 30202, 30214);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 29540, 30225);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_29739_29804(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 29739, 29804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_30023_30176(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 30023, 30176);
                    return return_v;
                }


                int
                f_10875_30007_30187(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 30007, 30187);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 29540, 30225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 29540, 30225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HadStaticInstanceMismatch(
                    DiagnosticBag diagnostics,
                    ImmutableArray<Symbol> symbols,
                    Location location,
                    Binder binder,
                    BoundExpression receiverOpt,
                    SyntaxNode nodeOpt,
                    TypeSymbol delegateOrFunctionPointerType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 30237, 32900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 30576, 30669);

                var
                staticInstanceMismatch = f_10875_30605_30668(this, MemberResolutionKind.StaticInstanceMismatch)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 30683, 30778) || true) && (staticInstanceMismatch.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 30683, 30778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 30750, 30763);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 30683, 30778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 30794, 30840);

                Symbol
                symbol = staticInstanceMismatch.Member
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 30939, 32861) || true) && (f_10875_30943_30960_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(receiverOpt, 10875, 30943, 30960)?.Kind) == BoundKind.QueryClause)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 30939, 32861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 31134, 31222);

                    f_10875_31134_31221(                // Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.
                                    diagnostics, ErrorCode.ERR_QueryNoProvider, location, f_10875_31191_31207(receiverOpt), f_10875_31209_31220(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 30939, 32861);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 30939, 32861);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 31256, 32861) || true) && (f_10875_31260_31325(binder.Flags, BinderFlags.CollectionInitializerAddMethod))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 31256, 32861);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 31359, 31440);

                        f_10875_31359_31439(diagnostics, ErrorCode.ERR_InitializerAddHasWrongSignature, location, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 31256, 32861);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 31256, 32861);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 31497, 32861) || true) && (nodeOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10875, 31501, 31564) && f_10875_31520_31534(nodeOpt) == SyntaxKind.AwaitExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 31501, 31614) && f_10875_31568_31579(symbol) == WellKnownMemberNames.GetAwaiter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 31497, 32861);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 31648, 31719);

                            f_10875_31648_31718(diagnostics, ErrorCode.ERR_BadAwaitArg, location, f_10875_31701_31717(receiverOpt));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 31497, 32861);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 31497, 32861);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 31753, 32861) || true) && (delegateOrFunctionPointerType is FunctionPointerTypeSymbol)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 31753, 32861);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 31849, 31922);

                                f_10875_31849_31921(diagnostics, ErrorCode.ERR_FuncPtrMethMustBeStatic, location, symbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 31753, 32861);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 31753, 32861);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 31988, 32367);

                                ErrorCode
                                errorCode =
                                (DynAbs.Tracing.TraceSender.Conditional_F1(10875, 32031, 32064) || ((f_10875_32031_32064(symbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10875, 32088, 32312)) || DynAbs.Tracing.TraceSender.Conditional_F3(10875, 32336, 32366))) ? (DynAbs.Tracing.TraceSender.Conditional_F1(10875, 32088, 32193) || ((f_10875_32088_32127(receiverOpt) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 32088, 32156) && f_10875_32131_32156(binder)) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 32088, 32193) && f_10875_32160_32193_M(!binder.BindingTopLevelScriptCode)) && DynAbs.Tracing.TraceSender.Conditional_F2(10875, 32221, 32256)) || DynAbs.Tracing.TraceSender.Conditional_F3(10875, 32284, 32312))) ? ErrorCode.ERR_FieldInitRefNonstatic
                                : ErrorCode.ERR_ObjectRequired
                                : ErrorCode.ERR_ObjectProhibited
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 32680, 32846);

                                f_10875_32680_32845(                // error CS0176: Member 'Program.M(B)' cannot be accessed with an instance reference; qualify it with a type name instead
                                                                    //     -or-
                                                                    // error CS0120: An object reference is required for the non-static field, method, or property 'Program.M(B)'
                                                diagnostics, f_10875_32696_32834(errorCode, new object[] { symbol }, symbols), location);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 31753, 32861);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 31497, 32861);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 31256, 32861);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 30939, 32861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 32877, 32889);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 30237, 32900);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_30605_30668(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 30605, 30668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind?
                f_10875_30943_30960_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 30943, 30960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10875_31191_31207(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 31191, 31207);
                    return return_v;
                }


                string
                f_10875_31209_31220(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 31209, 31220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_31134_31221(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 31134, 31221);
                    return return_v;
                }


                bool
                f_10875_31260_31325(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 31260, 31325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_31359_31439(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 31359, 31439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10875_31520_31534(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 31520, 31534);
                    return return_v;
                }


                string
                f_10875_31568_31579(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 31568, 31579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10875_31701_31717(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 31701, 31717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_31648_31718(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 31648, 31718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_31849_31921(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 31849, 31921);
                    return return_v;
                }


                bool
                f_10875_32031_32064(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.RequiresInstanceReceiver();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 32031, 32064);
                    return return_v;
                }


                bool
                f_10875_32088_32127(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    var return_v = Binder.WasImplicitReceiver(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 32088, 32127);
                    return return_v;
                }


                bool
                f_10875_32131_32156(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.InFieldInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 32131, 32156);
                    return return_v;
                }


                bool
                f_10875_32160_32193_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 32160, 32193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_32696_32834(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 32696, 32834);
                    return return_v;
                }


                int
                f_10875_32680_32845(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 32680, 32845);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 30237, 32900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 30237, 32900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HadReturnMismatch(Location location, DiagnosticBag diagnostics, RefKind refKind, TypeSymbol delegateOrFunctionPointerType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 32912, 33856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33072, 33141);

                var
                mismatch = f_10875_33087_33140(this, MemberResolutionKind.WrongRefKind)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33155, 33471) || true) && (f_10875_33159_33175_M(!mismatch.IsNull))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 33155, 33471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33209, 33426);

                    f_10875_33209_33425(diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10875, 33225, 33274) || ((f_10875_33225_33274(delegateOrFunctionPointerType) && DynAbs.Tracing.TraceSender.Conditional_F2(10875, 33277, 33309)) || DynAbs.Tracing.TraceSender.Conditional_F3(10875, 33312, 33345))) ? ErrorCode.ERR_FuncPtrRefMismatch : ErrorCode.ERR_DelegateRefMismatch, location, mismatch.Member, delegateOrFunctionPointerType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33444, 33456);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 33155, 33471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33487, 33555);

                mismatch = f_10875_33498_33554(this, MemberResolutionKind.WrongReturnType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33569, 33816) || true) && (f_10875_33573_33589_M(!mismatch.IsNull))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 33569, 33816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33623, 33674);

                    var
                    method = (MethodSymbol)(Symbol)mismatch.Member
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33692, 33771);

                    f_10875_33692_33770(diagnostics, ErrorCode.ERR_BadRetType, location, method, f_10875_33752_33769(method));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33789, 33801);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 33569, 33816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33832, 33845);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 32912, 33856);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_33087_33140(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 33087, 33140);
                    return return_v;
                }


                bool
                f_10875_33159_33175_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 33159, 33175);
                    return return_v;
                }


                bool
                f_10875_33225_33274(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 33225, 33274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_33209_33425(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 33209, 33425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_33498_33554(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 33498, 33554);
                    return return_v;
                }


                bool
                f_10875_33573_33589_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 33573, 33589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10875_33752_33769(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 33752, 33769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_33692_33770(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 33692, 33770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 32912, 33856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 32912, 33856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HadConstraintFailure(Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 33868, 34402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 33972, 34055);

                var
                constraintFailure = f_10875_33996_34054(this, MemberResolutionKind.ConstraintFailure)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 34069, 34159) || true) && (constraintFailure.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 34069, 34159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 34131, 34144);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 34069, 34159);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 34175, 34363);
                    foreach (var pair in f_10875_34196_34249_I(constraintFailure.Result.ConstraintFailureDiagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 34175, 34363);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 34283, 34348);

                        f_10875_34283_34347(diagnostics, f_10875_34299_34346(pair.DiagnosticInfo, location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 34175, 34363);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 34379, 34391);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 33868, 34402);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_33996_34054(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 33996, 34054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10875_34299_34346(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 34299, 34346);
                    return return_v;
                }


                int
                f_10875_34283_34347(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 34283, 34347);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10875_34196_34249_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 34196, 34249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 33868, 34402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 33868, 34402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TypeInferenceFailed(
                    Binder binder,
                    DiagnosticBag diagnostics,
                    ImmutableArray<Symbol> symbols,
                    BoundExpression receiver,
                    AnalyzedArguments arguments,
                    Location location,
                    CSharpSyntaxNode queryClause = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 34414, 36576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 34748, 34831);

                var
                inferenceFailed = f_10875_34770_34830(this, MemberResolutionKind.TypeInferenceFailed)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 34845, 35643) || true) && (inferenceFailed.IsNotNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 34845, 35643);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 34908, 35596) || true) && (queryClause != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 34908, 35596);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 34973, 35092);

                        f_10875_34973_35091(queryClause, f_10875_35020_35047(inferenceFailed.Member), receiver, arguments, symbols, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 34908, 35596);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 34908, 35596);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 35357, 35577);

                        f_10875_35357_35576(                    // error CS0411: The type arguments for method 'M<T>(T)' cannot be inferred
                                                                // from the usage. Try specifying the type arguments explicitly.
                                            diagnostics, f_10875_35373_35565(ErrorCode.ERR_CantInferMethTypeArgs, new object[] { inferenceFailed.Member }, symbols), location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 34908, 35596);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 35616, 35628);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 34845, 35643);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 35659, 35757);

                inferenceFailed = f_10875_35677_35756(this, MemberResolutionKind.TypeInferenceExtensionInstanceArgument);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 35771, 36536) || true) && (inferenceFailed.IsNotNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 35771, 36536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 35834, 35878);

                    f_10875_35834_35877(f_10875_35847_35872(arguments.Arguments) > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 35896, 35942);

                    var
                    instanceArgument = f_10875_35919_35941(arguments.Arguments, 0)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 35960, 36489) || true) && (queryClause != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 35960, 36489);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 36025, 36138);

                        f_10875_36025_36137(binder, queryClause, instanceArgument, f_10875_36087_36114(inferenceFailed.Member), symbols, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 35960, 36489);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 35960, 36489);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 36220, 36470);

                        f_10875_36220_36469(diagnostics, f_10875_36236_36458(ErrorCode.ERR_NoSuchMemberOrExtension, new object[] { f_10875_36371_36392(instanceArgument), f_10875_36394_36421(inferenceFailed.Member) }, symbols), location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 35960, 36489);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 36509, 36521);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 35771, 36536);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 36552, 36565);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 34414, 36576);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_34770_34830(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 34770, 34830);
                    return return_v;
                }


                string
                f_10875_35020_35047(TMember
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 35020, 35047);
                    return return_v;
                }


                int
                f_10875_34973_35091(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause, string
                methodName, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    Binder.ReportQueryInferenceFailed(queryClause, methodName, receiver, arguments, symbols, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 34973, 35091);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_35373_35565(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 35373, 35565);
                    return return_v;
                }


                int
                f_10875_35357_35576(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 35357, 35576);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_35677_35756(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 35677, 35756);
                    return return_v;
                }


                int
                f_10875_35847_35872(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 35847, 35872);
                    return return_v;
                }


                int
                f_10875_35834_35877(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 35834, 35877);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10875_35919_35941(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 35919, 35941);
                    return return_v;
                }


                string
                f_10875_36087_36114(TMember
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 36087, 36114);
                    return return_v;
                }


                int
                f_10875_36025_36137(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause, Microsoft.CodeAnalysis.CSharp.BoundExpression
                instanceArgument, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportQueryLookupFailed((Microsoft.CodeAnalysis.SyntaxNode)queryClause, instanceArgument, name, symbols, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 36025, 36137);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10875_36371_36392(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 36371, 36392);
                    return return_v;
                }


                string
                f_10875_36394_36421(TMember
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 36394, 36421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_36236_36458(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 36236, 36458);
                    return return_v;
                }


                int
                f_10875_36220_36469(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 36220, 36469);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 34414, 36576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 34414, 36576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportNameUsedForPositional(
                    MemberResolutionResult<TMember> bad,
                    DiagnosticBag diagnostics,
                    AnalyzedArguments arguments,
                    ImmutableArray<Symbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 36588, 37555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 36838, 36881);

                int
                badArg = bad.Result.BadArgumentsOpt[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 36984, 37029);

                f_10875_36984_37028(f_10875_36997_37018(arguments.Names) > badArg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 37043, 37098);

                IdentifierNameSyntax
                badName = f_10875_37074_37097(arguments.Names, badArg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 37112, 37142);

                f_10875_37112_37141(badName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 37270, 37318);

                Location
                location = f_10875_37290_37317(badName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 37334, 37544);

                f_10875_37334_37543(
                            diagnostics, f_10875_37350_37532(ErrorCode.ERR_NamedArgumentUsedInPositional, new object[] { badName.Identifier.ValueText }, symbols), location);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 36588, 37555);

                int
                f_10875_36997_37018(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 36997, 37018);
                    return return_v;
                }


                int
                f_10875_36984_37028(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 36984, 37028);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10875_37074_37097(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 37074, 37097);
                    return return_v;
                }


                int
                f_10875_37112_37141(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 37112, 37141);
                    return 0;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10875_37290_37317(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 37290, 37317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_37350_37532(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 37350, 37532);
                    return return_v;
                }


                int
                f_10875_37334_37543(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 37334, 37543);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 36588, 37555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 36588, 37555);
            }
        }

        private static void ReportBadNonTrailingNamedArgument(
                    MemberResolutionResult<TMember> bad,
                    DiagnosticBag diagnostics,
                    AnalyzedArguments arguments,
                    ImmutableArray<Symbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 37567, 38525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 37823, 37866);

                int
                badArg = bad.Result.BadArgumentsOpt[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 37969, 38014);

                f_10875_37969_38013(f_10875_37982_38003(arguments.Names) > badArg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 38028, 38083);

                IdentifierNameSyntax
                badName = f_10875_38059_38082(arguments.Names, badArg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 38097, 38127);

                f_10875_38097_38126(badName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 38242, 38290);

                Location
                location = f_10875_38262_38289(badName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 38306, 38514);

                f_10875_38306_38513(
                            diagnostics, f_10875_38322_38502(ErrorCode.ERR_BadNonTrailingNamedArgument, new object[] { badName.Identifier.ValueText }, symbols), location);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 37567, 38525);

                int
                f_10875_37982_38003(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 37982, 38003);
                    return return_v;
                }


                int
                f_10875_37969_38013(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 37969, 38013);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10875_38059_38082(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 38059, 38082);
                    return return_v;
                }


                int
                f_10875_38097_38126(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 38097, 38126);
                    return 0;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10875_38262_38289(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 38262, 38289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_38322_38502(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 38322, 38502);
                    return return_v;
                }


                int
                f_10875_38306_38513(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 38306, 38513);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 37567, 38525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 37567, 38525);
            }
        }

        private void ReportDuplicateNamedArgument(MemberResolutionResult<TMember> result, DiagnosticBag diagnostics, AnalyzedArguments arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 38537, 39104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 38699, 38755);

                f_10875_38699_38754(result.Result.BadArgumentsOpt.Length == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 38769, 38847);

                IdentifierNameSyntax
                name = f_10875_38797_38846(arguments.Names, result.Result.BadArgumentsOpt[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 38861, 38888);

                f_10875_38861_38887(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 38980, 39093);

                f_10875_38980_39092(
                            // CS: Named argument '{0}' cannot be specified multiple times
                            diagnostics, f_10875_38996_39076(ErrorCode.ERR_DuplicateNamedArgument, name.Identifier.Text), f_10875_39078_39091(name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 38537, 39104);

                int
                f_10875_38699_38754(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 38699, 38754);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10875_38797_38846(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 38797, 38846);
                    return return_v;
                }


                int
                f_10875_38861_38887(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 38861, 38887);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_38996_39076(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 38996, 39076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10875_39078_39091(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 39078, 39091);
                    return return_v;
                }


                int
                f_10875_38980_39092(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 38980, 39092);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 38537, 39104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 38537, 39104);
            }
        }

        private static void ReportNoCorrespondingNamedParameter(
                    MemberResolutionResult<TMember> bad,
                    string methodName,
                    DiagnosticBag diagnostics,
                    AnalyzedArguments arguments,
                    NamedTypeSymbol delegateTypeBeingInvoked,
                    ImmutableArray<Symbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 39116, 40959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 39944, 39987);

                int
                badArg = bad.Result.BadArgumentsOpt[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 40090, 40135);

                f_10875_40090_40134(f_10875_40103_40124(arguments.Names) > badArg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 40149, 40204);

                IdentifierNameSyntax
                badName = f_10875_40180_40203(arguments.Names, badArg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 40218, 40248);

                f_10875_40218_40247(badName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 40441, 40489);

                Location
                location = f_10875_40461_40488(badName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 40505, 40680);

                ErrorCode
                code = (DynAbs.Tracing.TraceSender.Conditional_F1(10875, 40522, 40562) || (((object)delegateTypeBeingInvoked != null && DynAbs.Tracing.TraceSender.Conditional_F2(10875, 40582, 40629)) || DynAbs.Tracing.TraceSender.Conditional_F3(10875, 40649, 40679))) ? ErrorCode.ERR_BadNamedArgumentForDelegateInvoke : ErrorCode.ERR_BadNamedArgument
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 40696, 40756);

                object
                obj = (object)delegateTypeBeingInvoked ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(10875, 40709, 40755) ?? methodName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 40772, 40948);

                f_10875_40772_40947(
                            diagnostics, f_10875_40788_40936(code, new object[] { obj, badName.Identifier.ValueText }, symbols), location);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 39116, 40959);

                int
                f_10875_40103_40124(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 40103, 40124);
                    return return_v;
                }


                int
                f_10875_40090_40134(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 40090, 40134);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10875_40180_40203(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 40180, 40203);
                    return return_v;
                }


                int
                f_10875_40218_40247(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 40218, 40247);
                    return 0;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10875_40461_40488(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 40461, 40488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_40788_40936(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 40788, 40936);
                    return return_v;
                }


                int
                f_10875_40772_40947(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 40772, 40947);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 39116, 40959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 39116, 40959);
            }
        }

        private static void ReportMissingRequiredParameter(
                    MemberResolutionResult<TMember> bad,
                    DiagnosticBag diagnostics,
                    NamedTypeSymbol delegateTypeBeingInvoked,
                    ImmutableArray<Symbol> symbols,
                    Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 40971, 43221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42190, 42221);

                TMember
                badMember = bad.Member
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42235, 42306);

                ImmutableArray<ParameterSymbol>
                parameters = f_10875_42280_42305(badMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42320, 42364);

                int
                badParamIndex = bad.Result.BadParameter
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42378, 42398);

                string
                badParamName
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42412, 42816) || true) && (badParamIndex == parameters.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 42412, 42816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42484, 42534);

                    f_10875_42484_42533(f_10875_42497_42511(badMember) == SymbolKind.Method);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42552, 42609);

                    f_10875_42552_42608(f_10875_42565_42607(((MethodSymbol)(object)badMember)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42627, 42689);

                    badParamName = f_10875_42642_42688(SyntaxKind.ArgListKeyword);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 42412, 42816);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 42412, 42816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42755, 42801);

                    badParamName = f_10875_42770_42800(parameters[badParamIndex]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 42412, 42816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 42942, 43001);

                object
                obj = (object)delegateTypeBeingInvoked ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(10875, 42955, 43000) ?? badMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 43017, 43210);

                f_10875_43017_43209(
                            diagnostics, f_10875_43033_43198(ErrorCode.ERR_NoCorrespondingArgument, new object[] { badParamName, obj }, symbols), location);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 40971, 43221);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10875_42280_42305(TMember
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 42280, 42305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10875_42497_42511(TMember
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 42497, 42511);
                    return return_v;
                }


                int
                f_10875_42484_42533(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 42484, 42533);
                    return 0;
                }


                bool
                f_10875_42565_42607(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 42565, 42607);
                    return return_v;
                }


                int
                f_10875_42552_42608(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 42552, 42608);
                    return 0;
                }


                string
                f_10875_42642_42688(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 42642, 42688);
                    return return_v;
                }


                string
                f_10875_42770_42800(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 42770, 42800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_43033_43198(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 43033, 43198);
                    return return_v;
                }


                int
                f_10875_43017_43209(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 43017, 43209);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 40971, 43221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 40971, 43221);
            }
        }

        private static void ReportBadParameterCount(
                    DiagnosticBag diagnostics,
                    string name,
                    AnalyzedArguments arguments,
                    ImmutableArray<Symbol> symbols,
                    Location location,
                    NamedTypeSymbol typeContainingConstructor,
                    NamedTypeSymbol delegateTypeBeingInvoked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 43233, 44937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 43909, 44099);

                FunctionPointerMethodSymbol
                functionPointerMethodBeingInvoked = (DynAbs.Tracing.TraceSender.Conditional_F1(10875, 43973, 44013) || ((symbols.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10875, 43973, 44013) || symbols.Length != 1
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(10875, 44033, 44037)) || DynAbs.Tracing.TraceSender.Conditional_F3(10875, 44057, 44098))) ? null
                : symbols[0] as FunctionPointerMethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44115, 44556);

                (ErrorCode code, object target) = (typeContainingConstructor, delegateTypeBeingInvoked, functionPointerMethodBeingInvoked) switch
                {
                    (object t, _, _) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44277, 44331) && DynAbs.Tracing.TraceSender.Expression_True(10875, 44277, 44331))
    => (ErrorCode.ERR_BadCtorArgCount, t),
                    (_, object t, _) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44350, 44403) && DynAbs.Tracing.TraceSender.Expression_True(10875, 44350, 44403))
    => (ErrorCode.ERR_BadDelArgCount, t),
                    (_, _, object t) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44422, 44483) && DynAbs.Tracing.TraceSender.Expression_True(10875, 44422, 44483))
    => (ErrorCode.ERR_BadFuncPointerArgCount, t),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44502, 44540) && DynAbs.Tracing.TraceSender.Expression_True(10875, 44502, 44540))
    => (ErrorCode.ERR_BadArgCount, name)
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44572, 44613);

                int
                argCount = f_10875_44587_44612(arguments.Arguments)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44627, 44728) || true) && (arguments.IsExtensionMethodInvocation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 44627, 44728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44702, 44713);

                    argCount--;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 44627, 44728);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44744, 44903);

                f_10875_44744_44902(
                            diagnostics, f_10875_44760_44891(code, new object[] { target, argCount }, symbols), location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 44919, 44926);

                return;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 43233, 44937);

                int
                f_10875_44587_44612(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 44587, 44612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_44760_44891(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 44760, 44891);
                    return return_v;
                }


                int
                f_10875_44744_44902(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 44744, 44902);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 43233, 44937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 43233, 44937);
            }
        }

        private bool HadConstructedParameterFailedConstraintCheck(
                    ConversionsBase conversions,
                    CSharpCompilation compilation,
                    DiagnosticBag diagnostics,
                    Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 44949, 51017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 49563, 49659);

                var
                result = f_10875_49576_49658(this, MemberResolutionKind.ConstructedParameterFailedConstraintCheck)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 49673, 49752) || true) && (result.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 49673, 49752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 49724, 49737);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 49673, 49752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 50146, 50204);

                MethodSymbol
                method = (MethodSymbol)(Symbol)result.Member
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 50218, 50432) || true) && (!f_10875_50223_50295(method, conversions, location, compilation, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 50218, 50432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 50405, 50417);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 50218, 50432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 50700, 50785);

                TypeSymbol
                formalParameterType = f_10875_50733_50784(method, result.Result.BadParameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 50799, 50978);

                formalParameterType.CheckAllConstraints(f_10875_50839_50976((CSharpCompilation)compilation, conversions, includeNullability: false, location, diagnostics));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 50994, 51006);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 44949, 51017);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_49576_49658(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 49576, 49658);
                    return return_v;
                }


                bool
                f_10875_50223_50295(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = method.CheckConstraints(conversions, location, currentCompilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 50223, 50295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10875_50733_50784(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 50733, 50784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs
                f_10875_50839_50976(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, bool
                includeNullability, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs(currentCompilation, conversions, includeNullability: includeNullability, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 50839, 50976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 44949, 51017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 44949, 51017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HadLambdaConversionError(DiagnosticBag diagnostics, AnalyzedArguments arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 51029, 51504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 51154, 51176);

                bool
                hadError = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 51190, 51461);
                    foreach (var argument in f_10875_51215_51234_I(arguments.Arguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 51190, 51461);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 51268, 51446) || true) && (f_10875_51272_51285(argument) == BoundKind.UnboundLambda)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 51268, 51446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 51354, 51427);

                            hadError |= f_10875_51366_51426(((UnboundLambda)argument), diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 51268, 51446);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 51190, 51461);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 51477, 51493);

                return hadError;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 51029, 51504);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_51272_51285(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 51272, 51285);
                    return return_v;
                }


                bool
                f_10875_51366_51426(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateSummaryErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 51366, 51426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10875_51215_51234_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 51215, 51234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 51029, 51504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 51029, 51504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HadBadArguments(
                    DiagnosticBag diagnostics,
                    Binder binder,
                    string name,
                    AnalyzedArguments arguments,
                    ImmutableArray<Symbol> symbols,
                    Location location,
                    BinderFlags flags,
                    bool isMethodGroupConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 51516, 54007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 51858, 51934);

                var
                badArg = f_10875_51871_51933(this, MemberResolutionKind.BadArgumentConversion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 51948, 52027) || true) && (badArg.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 51948, 52027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 51999, 52012);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 51948, 52027);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 52043, 52131) || true) && (isMethodGroupConversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 52043, 52131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 52104, 52116);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 52043, 52131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 52147, 52174);

                var
                method = badArg.Member
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 52592, 53753) || true) && (f_10875_52596_52654(flags, BinderFlags.CollectionInitializerAddMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 52592, 53753);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 52974, 53516);
                        foreach (var parameter in f_10875_53000_53022_I(f_10875_53000_53022(method)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 52974, 53516);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 53064, 53497) || true) && (f_10875_53068_53085(parameter) != RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 53064, 53497);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 53346, 53436);

                                f_10875_53346_53435(                        //  The best overloaded method match '{0}' for the collection initializer element cannot be used. Collection initializer 'Add' methods cannot have ref or out parameters.
                                                        diagnostics, ErrorCode.ERR_InitializerAddHasParamModifiers, location, symbols, method);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 53462, 53474);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 53064, 53497);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 52974, 53516);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 543);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 543);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 53652, 53738);

                    f_10875_53652_53737(
                                    //  The best overloaded Add method '{0}' for the collection initializer has some invalid arguments
                                    diagnostics, ErrorCode.ERR_BadArgTypesForCollectionAdd, location, symbols, method);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 52592, 53753);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 53769, 53968);
                    foreach (var arg in f_10875_53789_53818_I(badArg.Result.BadArgumentsOpt))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 53769, 53968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 53852, 53953);

                        f_10875_53852_53952(this, diagnostics, binder, name, arguments, symbols, location, badArg, method, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 53769, 53968);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 200);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 53984, 53996);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 51516, 54007);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10875_51871_51933(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = this_param.GetFirstMemberKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 51871, 51933);
                    return return_v;
                }


                bool
                f_10875_52596_52654(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 52596, 52654);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10875_53000_53022(TMember
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 53000, 53022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10875_53068_53085(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 53068, 53085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_53346_53435(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, symbols, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 53346, 53435);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10875_53000_53022_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 53000, 53022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_53652_53737(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, symbols, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 53652, 53737);
                    return return_v;
                }


                int
                f_10875_53852_53952(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder
                binder, string
                name, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                badArg, TMember
                method, int
                arg)
                {
                    this_param.ReportBadArgumentError(diagnostics, binder, name, arguments, symbols, location, badArg, method, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 53852, 53952);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10875_53789_53818_I(System.Collections.Immutable.ImmutableArray<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 53789, 53818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 51516, 54007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 51516, 54007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReportBadArgumentError(
                    DiagnosticBag diagnostics,
                    Binder binder,
                    string name,
                    AnalyzedArguments arguments,
                    ImmutableArray<Symbol> symbols,
                    Location location,
                    MemberResolutionResult<TMember> badArg,
                    TMember method,
                    int arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 54019, 63587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 54397, 54448);

                BoundExpression
                argument = f_10875_54424_54447(arguments, arg)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 54462, 54689) || true) && (f_10875_54466_54487(argument))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 54462, 54689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 54667, 54674);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 54462, 54689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 54705, 54757);

                int
                parm = badArg.Result.ParameterFromArgument(arg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 54771, 54839);

                SourceLocation
                sourceLocation = f_10875_54803_54838(argument.Syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 54955, 55506) || true) && (f_10875_54959_54979(method) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 54959, 55017) && parm == f_10875_54991_55017(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 54955, 55506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 55232, 55466);

                    f_10875_55232_55465(                // NOTE: No SymbolDistinguisher required, since one of the arguments is "__arglist".

                                    // CS1503: Argument {0}: cannot convert from '{1}' to '{2}'
                                    diagnostics, ErrorCode.ERR_BadArgType, sourceLocation, symbols, arg + 1, f_10875_55414_55430(argument), "__arglist");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 55484, 55491);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 54955, 55506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 55522, 55579);

                ParameterSymbol
                parameter = f_10875_55550_55572(method)[parm]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 55593, 55655);

                bool
                isLastParameter = f_10875_55616_55642(method) == parm + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 55744, 55784);

                RefKind
                refArg = f_10875_55761_55783(arguments, arg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 55798, 55839);

                RefKind
                refParameter = f_10875_55821_55838(parameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 55855, 56457) || true) && (f_10875_55859_55903(arguments, arg))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 55855, 56457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 55937, 55974);

                    f_10875_55937_55973(refArg == RefKind.None);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 55992, 56442) || true) && (refParameter == RefKind.Ref || (DynAbs.Tracing.TraceSender.Expression_False(10875, 55996, 56053) || refParameter == RefKind.In))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 55992, 56442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 56401, 56423);

                        refArg = refParameter;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 55992, 56442);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 55855, 56457);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 56751, 63576) || true) && (!f_10875_56756_56784(argument) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 56755, 56865) && f_10875_56805_56818(argument) != BoundKind.OutDeconstructVarPendingInference) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 56755, 56940) && f_10875_56886_56899(argument) != BoundKind.OutVariablePendingInference) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 56755, 57005) && f_10875_56961_56974(argument) != BoundKind.DiscardExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 56751, 63576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 57066, 57125);

                    var
                    temp = f_10875_57077_57124(parameter, isLastParameter)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 57143, 57225);

                    TypeSymbol
                    parameterType = (DynAbs.Tracing.TraceSender.Conditional_F1(10875, 57170, 57188) || ((temp is TypeSymbol && DynAbs.Tracing.TraceSender.Conditional_F2(10875, 57191, 57207)) || DynAbs.Tracing.TraceSender.Conditional_F3(10875, 57210, 57224))) ? (TypeSymbol)temp : f_10875_57210_57224(parameter)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 57455, 59352) || true) && (f_10875_57459_57472(argument) == BoundKind.UnboundLambda && (DynAbs.Tracing.TraceSender.Expression_True(10875, 57459, 57525) && refArg == refParameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 57455, 59352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 57567, 57662);

                        f_10875_57567_57661(((UnboundLambda)argument), diagnostics, parameterType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 57455, 59352);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 57455, 59352);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 57704, 59352) || true) && (f_10875_57708_57721(argument) == BoundKind.MethodGroup && (DynAbs.Tracing.TraceSender.Expression_True(10875, 57708, 57793) && f_10875_57750_57772(parameterType) == TypeKind.Delegate) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 57708, 57951) && f_10875_57822_57951(binder, argument, parameterType, diagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 57704, 59352);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 57704, 59352);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 57704, 59352);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 58125, 59352) || true) && (f_10875_58129_58142(argument) == BoundKind.MethodGroup && (DynAbs.Tracing.TraceSender.Expression_True(10875, 58129, 58221) && f_10875_58171_58193(parameterType) == TypeKind.FunctionPointer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 58125, 59352);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 58263, 58327);

                                f_10875_58263_58326(diagnostics, ErrorCode.ERR_MissingAddressOf, sourceLocation);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 58125, 59352);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 58125, 59352);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 58369, 59352) || true) && (f_10875_58373_58386(argument) == BoundKind.UnconvertedAddressOfOperator && (DynAbs.Tracing.TraceSender.Expression_True(10875, 58373, 58613) && f_10875_58457_58613(binder, f_10875_58531_58584(((BoundUnconvertedAddressOfOperator)argument)), parameterType, diagnostics)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 58369, 59352);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 58369, 59352);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 58369, 59352);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 59007, 59333);

                                    f_10875_59007_59332(                    // There's no symbol for the argument, so we don't need a SymbolDistinguisher.

                                                        // Argument 1: cannot convert from '<null>' to 'ref int'
                                                        diagnostics, ErrorCode.ERR_BadArgType, sourceLocation, symbols, arg + 1, f_10875_59209_59225(argument), f_10875_59284_59331(parameter, isLastParameter));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 58369, 59352);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 58125, 59352);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 57704, 59352);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 57455, 59352);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 56751, 63576);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 56751, 63576);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 59386, 63576) || true) && (refArg != refParameter && (DynAbs.Tracing.TraceSender.Expression_True(10875, 59390, 59471) && !(refArg == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10875, 59418, 59470) && refParameter == RefKind.In))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 59386, 63576);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 59505, 60348) || true) && (refParameter == RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10875, 59509, 59567) || refParameter == RefKind.In))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 59505, 60348);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 59689, 59929);

                            f_10875_59689_59928(                    //  Argument {0} should not be passed with the {1} keyword
                                                diagnostics, ErrorCode.ERR_BadArgExtraRef, sourceLocation, symbols, arg + 1, f_10875_59895_59927(refArg));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 59505, 60348);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 59505, 60348);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 60087, 60329);

                            f_10875_60087_60328(                    //  Argument {0} must be passed with the '{1}' keyword
                                                diagnostics, ErrorCode.ERR_BadArgRef, sourceLocation, symbols, arg + 1, f_10875_60288_60327(refParameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 59505, 60348);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 59386, 63576);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 59386, 63576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 60414, 60489);

                        f_10875_60414_60488(f_10875_60427_60440(argument) != BoundKind.OutDeconstructVarPendingInference);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 60507, 60576);

                        f_10875_60507_60575(f_10875_60520_60533(argument) != BoundKind.OutVariablePendingInference);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 60594, 60685);

                        f_10875_60594_60684(f_10875_60607_60620(argument) != BoundKind.DiscardExpression || (DynAbs.Tracing.TraceSender.Expression_False(10875, 60607, 60683) || f_10875_60655_60683(argument)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 60703, 60742);

                        f_10875_60703_60741(f_10875_60716_60732(argument) != null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 60762, 63561) || true) && (f_10875_60766_60810(arguments, arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 60762, 63561);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 60852, 60894);

                            f_10875_60852_60893((arg == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 60865, 60892) && (parm == arg)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 60916, 60979);

                            f_10875_60916_60978(f_10875_60929_60977_M(!badArg.Result.ConversionForArg(parm).IsImplicit));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 61160, 61454);

                            f_10875_61160_61453(
                                                // CS1929: '{0}' does not contain a definition for '{1}' and the best extension method overload '{2}' requires a receiver of type '{3}'
                                                diagnostics, ErrorCode.ERR_BadInstanceArgType, sourceLocation, symbols, f_10875_61336_61352(argument), name, method, parameter);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 61476, 61638);

                            f_10875_61476_61637((object)parameter == f_10875_61510_61557(parameter, isLastParameter), "If they ever differ, just call the method when constructing the diagnostic.");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 60762, 63561);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 60762, 63561);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 62134, 63542) || true) && (f_10875_62138_62154(argument) is TypeSymbol argType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 62134, 63542);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 62226, 62527);

                                SignatureOnlyParameterSymbol
                                displayArg = f_10875_62268_62526(TypeWithAnnotations.Create(argType), ImmutableArray<CustomModifier>.Empty, isParams: false, refKind: refArg)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 62555, 62696);

                                SymbolDistinguisher
                                distinguisher = f_10875_62591_62695(f_10875_62615_62633(binder), displayArg, f_10875_62647_62694(parameter, isLastParameter))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 62809, 63103);

                                f_10875_62809_63102(
                                                        // CS1503: Argument {0}: cannot convert from '{1}' to '{2}'
                                                        diagnostics, ErrorCode.ERR_BadArgType, sourceLocation, symbols, arg + 1, f_10875_63031_63050(distinguisher), f_10875_63081_63101(distinguisher));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 62134, 63542);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 62134, 63542);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 63201, 63519);

                                f_10875_63201_63518(diagnostics, ErrorCode.ERR_BadArgType, sourceLocation, symbols, arg + 1, f_10875_63423_63439(argument), f_10875_63470_63517(parameter, isLastParameter));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 62134, 63542);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 60762, 63561);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 59386, 63576);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 56751, 63576);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 54019, 63587);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10875_54424_54447(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Argument(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 54424, 54447);
                    return return_v;
                }


                bool
                f_10875_54466_54487(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 54466, 54487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10875_54803_54838(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 54803, 54838);
                    return return_v;
                }


                bool
                f_10875_54959_54979(TMember
                member)
                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 54959, 54979);
                    return return_v;
                }


                int
                f_10875_54991_55017(TMember
                member)
                {
                    var return_v = member.GetParameterCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 54991, 55017);
                    return return_v;
                }


                object
                f_10875_55414_55430(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 55414, 55430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_55232_55465(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, symbols, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 55232, 55465);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10875_55550_55572(TMember
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 55550, 55572);
                    return return_v;
                }


                int
                f_10875_55616_55642(TMember
                member)
                {
                    var return_v = member.GetParameterCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 55616, 55642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10875_55761_55783(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.RefKind(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 55761, 55783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10875_55821_55838(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 55821, 55838);
                    return return_v;
                }


                bool
                f_10875_55859_55903(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.IsExtensionMethodThisArgument(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 55859, 55903);
                    return return_v;
                }


                int
                f_10875_55937_55973(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 55937, 55973);
                    return 0;
                }


                bool
                f_10875_56756_56784(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasExpressionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 56756, 56784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_56805_56818(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 56805, 56818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_56886_56899(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 56886, 56899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_56961_56974(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 56961, 56974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10875_57077_57124(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, bool
                isLastParameter)
                {
                    var return_v = UnwrapIfParamsArray(parameter, isLastParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 57077, 57124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10875_57210_57224(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 57210, 57224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_57459_57472(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 57459, 57472);
                    return return_v;
                }


                int
                f_10875_57567_57661(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType)
                {
                    this_param.GenerateAnonymousFunctionConversionError(diagnostics, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 57567, 57661);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_57708_57721(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 57708, 57721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10875_57750_57772(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 57750, 57772);
                    return return_v;
                }


                bool
                f_10875_57822_57951(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Conversions.ReportDelegateOrFunctionPointerMethodGroupDiagnostics(binder, (Microsoft.CodeAnalysis.CSharp.BoundMethodGroup)expr, targetType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 57822, 57951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_58129_58142(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 58129, 58142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10875_58171_58193(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 58171, 58193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_58263_58326(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 58263, 58326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_58373_58386(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 58373, 58386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10875_58531_58584(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 58531, 58584);
                    return return_v;
                }


                bool
                f_10875_58457_58613(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Conversions.ReportDelegateOrFunctionPointerMethodGroupDiagnostics(binder, expr, targetType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 58457, 58613);
                    return return_v;
                }


                object
                f_10875_59209_59225(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 59209, 59225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10875_59284_59331(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, bool
                isLastParameter)
                {
                    var return_v = UnwrapIfParamsArray(parameter, isLastParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 59284, 59331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_59007_59332(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, symbols, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 59007, 59332);
                    return return_v;
                }


                string
                f_10875_59895_59927(Microsoft.CodeAnalysis.RefKind
                kind)
                {
                    var return_v = kind.ToArgumentDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 59895, 59927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_59689_59928(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, symbols, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 59689, 59928);
                    return return_v;
                }


                string
                f_10875_60288_60327(Microsoft.CodeAnalysis.RefKind
                kind)
                {
                    var return_v = kind.ToParameterDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60288, 60327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_60087_60328(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, symbols, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60087, 60328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_60427_60440(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 60427, 60440);
                    return return_v;
                }


                int
                f_10875_60414_60488(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60414, 60488);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_60520_60533(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 60520, 60533);
                    return return_v;
                }


                int
                f_10875_60507_60575(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60507, 60575);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10875_60607_60620(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 60607, 60620);
                    return return_v;
                }


                bool
                f_10875_60655_60683(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasExpressionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60655, 60683);
                    return return_v;
                }


                int
                f_10875_60594_60684(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60594, 60684);
                    return 0;
                }


                object
                f_10875_60716_60732(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 60716, 60732);
                    return return_v;
                }


                int
                f_10875_60703_60741(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60703, 60741);
                    return 0;
                }


                bool
                f_10875_60766_60810(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.IsExtensionMethodThisArgument(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60766, 60810);
                    return return_v;
                }


                int
                f_10875_60852_60893(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60852, 60893);
                    return 0;
                }


                bool
                f_10875_60929_60977_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 60929, 60977);
                    return return_v;
                }


                int
                f_10875_60916_60978(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 60916, 60978);
                    return 0;
                }


                object
                f_10875_61336_61352(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 61336, 61352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_61160_61453(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, symbols, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 61160, 61453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10875_61510_61557(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, bool
                isLastParameter)
                {
                    var return_v = UnwrapIfParamsArray(parameter, isLastParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 61510, 61557);
                    return return_v;
                }


                int
                f_10875_61476_61637(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 61476, 61637);
                    return 0;
                }


                object
                f_10875_62138_62154(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 62138, 62154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol
                f_10875_62268_62526(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, bool
                isParams, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol(type, refCustomModifiers, isParams: isParams, refKind: refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 62268, 62526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10875_62615_62633(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 62615, 62633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10875_62647_62694(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, bool
                isLastParameter)
                {
                    var return_v = UnwrapIfParamsArray(parameter, isLastParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 62647, 62694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                f_10875_62591_62695(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol
                symbol0, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol1)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol0, symbol1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 62591, 62695);
                    return return_v;
                }


                System.IFormattable
                f_10875_63031_63050(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                this_param)
                {
                    var return_v = this_param.First;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 63031, 63050);
                    return return_v;
                }


                System.IFormattable
                f_10875_63081_63101(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                this_param)
                {
                    var return_v = this_param.Second;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 63081, 63101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_62809_63102(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, symbols, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 62809, 63102);
                    return return_v;
                }


                object
                f_10875_63423_63439(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 63423, 63439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10875_63470_63517(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, bool
                isLastParameter)
                {
                    var return_v = UnwrapIfParamsArray(parameter, isLastParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 63470, 63517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_63201_63518(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, symbols, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 63201, 63518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 54019, 63587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 54019, 63587);
            }
        }

        private static Symbol UnwrapIfParamsArray(ParameterSymbol parameter, bool isLastParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 63895, 64472);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 64118, 64430) || true) && (f_10875_64122_64140(parameter) && (DynAbs.Tracing.TraceSender.Expression_True(10875, 64122, 64159) && isLastParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 64118, 64430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 64193, 64255);

                    ArrayTypeSymbol
                    arrayType = f_10875_64221_64235(parameter) as ArrayTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 64273, 64415) || true) && ((object)arrayType != null && (DynAbs.Tracing.TraceSender.Expression_True(10875, 64277, 64325) && f_10875_64306_64325(arrayType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 64273, 64415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 64367, 64396);

                        return f_10875_64374_64395(arrayType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 64273, 64415);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 64118, 64430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 64444, 64461);

                return parameter;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 63895, 64472);

                bool
                f_10875_64122_64140(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 64122, 64140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10875_64221_64235(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 64221, 64235);
                    return return_v;
                }


                bool
                f_10875_64306_64325(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 64306, 64325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10875_64374_64395(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 64374, 64395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 63895, 64472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 63895, 64472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HadAmbiguousWorseMethods(DiagnosticBag diagnostics, ImmutableArray<Symbol> symbols, Location location, bool isQuery, BoundExpression receiver, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 64484, 66247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 64677, 64722);

                MemberResolutionResult<TMember>
                worseResult1
                = default(MemberResolutionResult<TMember>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 64736, 64781);

                MemberResolutionResult<TMember>
                worseResult2
                = default(MemberResolutionResult<TMember>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 65078, 65154);

                int
                nWorse = f_10875_65091_65153(this, out worseResult1, out worseResult2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 65168, 65433) || true) && (nWorse <= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 65168, 65433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 65217, 65387);

                    f_10875_65217_65386(nWorse == 0, "How is it that there is exactly one applicable but worse method, and exactly zero applicable best methods?  What was better than this thing?");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 65405, 65418);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 65168, 65433);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 65449, 66208) || true) && (isQuery)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 65449, 66208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 65620, 65705);

                    f_10875_65620_65704(                // Multiple implementations of the query pattern were found for source type '{0}'.  Ambiguous call to '{1}'.
                                    diagnostics, ErrorCode.ERR_QueryMultipleProviders, location, f_10875_65684_65697(receiver), name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 65449, 66208);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 65449, 66208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 65894, 66193);

                    f_10875_65894_66192(                // error CS0121: The call is ambiguous between the following methods or properties: 'P.W(A)' and 'P.W(B)'
                                    diagnostics, f_10875_65932_66160(f_10875_65992_66045(worseResult1.LeastOverriddenMember), f_10875_66072_66125(worseResult2.LeastOverriddenMember), symbols), location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 65449, 66208);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66224, 66236);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 64484, 66247);

                int
                f_10875_65091_65153(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, out Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                first, out Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                second)
                {
                    var return_v = this_param.TryGetFirstTwoWorseResults(out first, out second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 65091, 65153);
                    return return_v;
                }


                int
                f_10875_65217_65386(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 65217, 65386);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10875_65684_65697(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 65684, 65697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10875_65620_65704(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 65620, 65704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10875_65992_66045(TMember
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 65992, 66045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10875_66072_66125(TMember
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 66072, 66125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_65932_66160(Microsoft.CodeAnalysis.CSharp.Symbol
                first, Microsoft.CodeAnalysis.CSharp.Symbol
                second, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = CreateAmbiguousCallDiagnosticInfo(first, second, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 65932, 66160);
                    return return_v;
                }


                int
                f_10875_65894_66192(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 65894, 66192);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 64484, 66247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 64484, 66247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int TryGetFirstTwoWorseResults(out MemberResolutionResult<TMember> first, out MemberResolutionResult<TMember> second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 66259, 67229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66409, 66423);

                int
                count = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66437, 66461);

                bool
                foundFirst = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66475, 66500);

                bool
                foundSecond = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66514, 66563);

                first = default(MemberResolutionResult<TMember>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66577, 66627);

                second = default(MemberResolutionResult<TMember>);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66643, 67189);
                    foreach (var res in f_10875_66663_66682_I(this.ResultsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 66643, 67189);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66716, 67174) || true) && (res.Result.Kind == MemberResolutionKind.Worse)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 66716, 67174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66807, 66815);

                            count++;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66837, 67155) || true) && (!foundFirst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 66837, 67155);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66902, 66914);

                                first = res;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 66940, 66958);

                                foundFirst = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 66837, 67155);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 66837, 67155);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67008, 67155) || true) && (!foundSecond)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 67008, 67155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67074, 67087);

                                    second = res;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67113, 67132);

                                    foundSecond = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 67008, 67155);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 66837, 67155);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 66716, 67174);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 66643, 67189);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 547);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 547);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67205, 67218);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 66259, 67229);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10875_66663_66682_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 66663, 66682);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 66259, 67229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 66259, 67229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HadAmbiguousBestMethods(DiagnosticBag diagnostics, ImmutableArray<Symbol> symbols, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 67241, 68317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67380, 67425);

                MemberResolutionResult<TMember>
                validResult1
                = default(MemberResolutionResult<TMember>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67439, 67484);

                MemberResolutionResult<TMember>
                validResult2
                = default(MemberResolutionResult<TMember>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67498, 67574);

                var
                nValid = f_10875_67511_67573(this, out validResult1, out validResult2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67588, 67806) || true) && (nValid <= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 67588, 67806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67637, 67760);

                    f_10875_67637_67759(nValid == 0, "Why are we doing error reporting on an overload resolution problem that had one valid result?");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67778, 67791);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 67588, 67806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 67999, 68278);

                f_10875_67999_68277(
                            // error CS0121: The call is ambiguous between the following methods or properties:
                            // 'P.Ambiguous(object, string)' and 'P.Ambiguous(string, object)'
                            diagnostics, f_10875_68033_68249(f_10875_68089_68142(validResult1.LeastOverriddenMember), f_10875_68165_68218(validResult2.LeastOverriddenMember), symbols), location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68294, 68306);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 67241, 68317);

                int
                f_10875_67511_67573(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param, out Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                first, out Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                second)
                {
                    var return_v = this_param.TryGetFirstTwoValidResults(out first, out second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 67511, 67573);
                    return return_v;
                }


                int
                f_10875_67637_67759(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 67637, 67759);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10875_68089_68142(TMember
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 68089, 68142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10875_68165_68218(TMember
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 68165, 68218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_68033_68249(Microsoft.CodeAnalysis.CSharp.Symbol
                first, Microsoft.CodeAnalysis.CSharp.Symbol
                second, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = CreateAmbiguousCallDiagnosticInfo(first, second, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 68033, 68249);
                    return return_v;
                }


                int
                f_10875_67999_68277(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 67999, 68277);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 67241, 68317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 67241, 68317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int TryGetFirstTwoValidResults(out MemberResolutionResult<TMember> first, out MemberResolutionResult<TMember> second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 68329, 69272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68479, 68493);

                int
                count = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68507, 68531);

                bool
                foundFirst = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68545, 68570);

                bool
                foundSecond = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68584, 68633);

                first = default(MemberResolutionResult<TMember>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68647, 68697);

                second = default(MemberResolutionResult<TMember>);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68713, 69232);
                    foreach (var res in f_10875_68733_68752_I(this.ResultsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 68713, 69232);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68786, 69217) || true) && (res.Result.IsValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 68786, 69217);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68850, 68858);

                            count++;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68880, 69198) || true) && (!foundFirst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 68880, 69198);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68945, 68957);

                                first = res;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 68983, 69001);

                                foundFirst = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 68880, 69198);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 68880, 69198);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 69051, 69198) || true) && (!foundSecond)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 69051, 69198);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 69117, 69130);

                                    second = res;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 69156, 69175);

                                    foundSecond = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 69051, 69198);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 68880, 69198);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 68786, 69217);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 68713, 69232);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 69248, 69261);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 68329, 69272);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10875_68733_68752_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 68733, 68752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 68329, 69272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 68329, 69272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DiagnosticInfoWithSymbols CreateAmbiguousCallDiagnosticInfo(Symbol first, Symbol second, ImmutableArray<Symbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 69284, 70059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 69444, 69952);

                var
                arguments = (DynAbs.Tracing.TraceSender.Conditional_F1(10875, 69460, 69517) || (((f_10875_69461_69486(first) != f_10875_69490_69516(second)) && DynAbs.Tracing.TraceSender.Conditional_F2(10875, 69537, 69801)) || DynAbs.Tracing.TraceSender.Conditional_F3(10875, 69821, 69951))) ? new object[]
                                    {
f_10875_69602_69674(first, f_10875_69629_69673()),
f_10875_69705_69778(second, f_10875_69733_69777())                    } : new object[]
                                    {
                            first,
                            second
                                    }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 69966, 70048);

                return f_10875_69973_70047(ErrorCode.ERR_AmbigCall, arguments, symbols);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 69284, 70059);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10875_69461_69486(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 69461, 69486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10875_69490_69516(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 69490, 69516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10875_69629_69673()
                {
                    var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 69629, 69673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FormattedSymbol
                f_10875_69602_69674(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                symbolDisplayFormat)
                {
                    var return_v = new Microsoft.CodeAnalysis.FormattedSymbol((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)symbol, symbolDisplayFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 69602, 69674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10875_69733_69777()
                {
                    var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 69733, 69777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FormattedSymbol
                f_10875_69705_69778(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                symbolDisplayFormat)
                {
                    var return_v = new Microsoft.CodeAnalysis.FormattedSymbol((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)symbol, symbolDisplayFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 69705, 69778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10875_69973_70047(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 69973, 70047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 69284, 70059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 69284, 70059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        private void AssertNone(MemberResolutionKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 70071, 70418);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 70178, 70407);
                    foreach (var result in f_10875_70201_70220_I(this.ResultsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 70178, 70407);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 70254, 70392) || true) && (result.Result.Kind == kind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 70254, 70392);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 70326, 70373);

                            throw f_10875_70332_70372(kind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 70254, 70392);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 70178, 70407);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 230);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 70071, 70418);

                System.Exception
                f_10875_70332_70372(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 70332, 70372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10875_70201_70220_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 70201, 70220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 70071, 70418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 70071, 70418);
            }
        }

        private MemberResolutionResult<TMember> GetFirstMemberKind(MemberResolutionKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 70430, 70811);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 70540, 70736);
                    foreach (var result in f_10875_70563_70582_I(this.ResultsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 70540, 70736);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 70616, 70721) || true) && (result.Result.Kind == kind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 70616, 70721);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 70688, 70702);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 70616, 70721);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 70540, 70736);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 70752, 70800);

                return default(MemberResolutionResult<TMember>);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 70430, 70811);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10875_70563_70582_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 70563, 70582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 70430, 70811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 70430, 70811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 70834, 72161);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 70881, 71031) || true) && (f_10875_70885_70905(ResultsBuilder) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 70881, 71031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 70944, 71016);

                    return "Overload resolution failed because the method group was empty.";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 70881, 71031);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71047, 71076);

                var
                sb = f_10875_71056_71075()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71090, 71860) || true) && (f_10875_71094_71108(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 71090, 71860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71142, 71237);

                    f_10875_71142_71236(sb, "Overload resolution succeeded and chose " + f_10875_71201_71235(this.ValidResult.Member));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 71090, 71860);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 71090, 71860);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71271, 71860) || true) && (f_10875_71275_71342(ResultsBuilder, x => x.Result.IsValid) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 71271, 71860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71380, 71468);

                        f_10875_71380_71467(sb, "Overload resolution failed because of ambiguous possible best methods.");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 71271, 71860);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 71271, 71860);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71502, 71860) || true) && (f_10875_71506_71696(ResultsBuilder, x => (x.Result.Kind == MemberResolutionKind.TypeInferenceFailed) || (x.Result.Kind == MemberResolutionKind.TypeInferenceExtensionInstanceArgument)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 71502, 71860);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71730, 71845);

                            f_10875_71730_71844(sb, "Overload resolution failed (possibly) because type inference was unable to infer type parameters.");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 71502, 71860);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 71271, 71860);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 71090, 71860);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71876, 71911);

                f_10875_71876_71910(
                            sb, "Detailed results:");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71925, 72113);
                    foreach (var result in f_10875_71948_71962_I(ResultsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10875, 71925, 72113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 71996, 72098);

                        f_10875_71996_72097(sb, "method: {0} reason: {1}\n", f_10875_72041_72065(result.Member), f_10875_72067_72096(result.Result.Kind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10875, 71925, 72113);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10875, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10875, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 72129, 72150);

                return f_10875_72136_72149(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 70834, 72161);

                int
                f_10875_70885_70905(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 70885, 70905);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10875_71056_71075()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71056, 71075);
                    return return_v;
                }


                bool
                f_10875_71094_71108(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param)
                {
                    var return_v = this_param.Succeeded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10875, 71094, 71108);
                    return return_v;
                }


                string
                f_10875_71201_71235(TMember
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71201, 71235);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10875_71142_71236(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71142, 71236);
                    return return_v;
                }


                int
                f_10875_71275_71342(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>, bool>
                predicate)
                {
                    var return_v = System.Linq.Enumerable.Count(source, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71275, 71342);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10875_71380_71467(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71380, 71467);
                    return return_v;
                }


                bool
                f_10875_71506_71696(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71506, 71696);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10875_71730_71844(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71730, 71844);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10875_71876_71910(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71876, 71910);
                    return return_v;
                }


                string
                f_10875_72041_72065(TMember
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 72041, 72065);
                    return return_v;
                }


                string
                f_10875_72067_72096(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 72067, 72096);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10875_71996_72097(System.Text.StringBuilder
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71996, 72097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10875_71948_71962_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 71948, 71962);
                    return return_v;
                }


                string
                f_10875_72136_72149(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 72136, 72149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 70834, 72161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 70834, 72161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static OverloadResolutionResult<TMember> GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 72211, 72335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 72299, 72324);

                return f_10875_72306_72323(s_pool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 72211, 72335);

                Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                f_10875_72306_72323(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 72306, 72323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 72211, 72335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 72211, 72335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10875, 72347, 72448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 72392, 72405);

                f_10875_72392_72404(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 72419, 72437);

                f_10875_72419_72436(s_pool, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10875, 72347, 72448);

                int
                f_10875_72392_72404(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 72392, 72404);
                    return 0;
                }


                int
                f_10875_72419_72436(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>>
                this_param, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 72419, 72436);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 72347, 72448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 72347, 72448);
            }
        }

        private static readonly ObjectPool<OverloadResolutionResult<TMember>> s_pool;

        private static ObjectPool<OverloadResolutionResult<TMember>> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10875, 72733, 73048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 72831, 72889);

                ObjectPool<OverloadResolutionResult<TMember>>
                pool = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 72903, 73011);

                pool = f_10875_72910_73010(() => new OverloadResolutionResult<TMember>(), 10);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 73025, 73037);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10875, 72733, 73048);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>>
                f_10875_72910_73010(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 72910, 73010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10875, 72733, 73048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 72733, 73048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OverloadResolutionResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10875, 923, 73077);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10875, 72699, 72720);
            s_pool = f_10875_72708_72720(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10875, 923, 73077);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10875, 923, 73077);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10875, 923, 73077);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
        f_10875_1363_1414()
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 1363, 1414);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>>
        f_10875_72708_72720()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10875, 72708, 72720);
            return return_v;
        }

    }
}
