// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class AbstractRegionDataFlowPass : DefiniteAssignmentPass
    {
        internal AbstractRegionDataFlowPass(
                    CSharpCompilation compilation,
                    Symbol member,
                    BoundNode node,
                    BoundNode firstInRegion,
                    BoundNode lastInRegion,
                    HashSet<Symbol> initiallyAssignedVariables = null,
                    HashSet<PrefixUnaryExpressionSyntax> unassignedVariableAddressOfSyntaxes = null,
                    bool trackUnassignments = false)
        : base(f_10882_971_982_C(compilation), member, node, firstInRegion, lastInRegion, initiallyAssignedVariables, unassignedVariableAddressOfSyntaxes, trackUnassignments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10882, 534, 1133);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10882, 534, 1133);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10882, 534, 1133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10882, 534, 1133);
            }
        }

        protected override ImmutableArray<PendingBranch> Scan(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10882, 1267, 1576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 1365, 1393);

                f_10882_1365_1392(this, f_10882_1375_1391());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 1407, 1485) || true) && ((object)f_10882_1419_1438() != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10882, 1407, 1485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 1448, 1485);

                    f_10882_1448_1484(this, f_10882_1464_1483());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10882, 1407, 1485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 1499, 1537);

                // LAFHIS
                //var
                //result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Scan(ref badRegion), 10882, 1512, 1536)
                //;
                var result = base.Scan(ref badRegion);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10882, 1512, 1536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 1551, 1565);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10882, 1267, 1576);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10882_1375_1391()
                {
                    var return_v = MethodParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10882, 1375, 1391);
                    return return_v;
                }


                int
                f_10882_1365_1392(Microsoft.CodeAnalysis.CSharp.AbstractRegionDataFlowPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.MakeSlots(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10882, 1365, 1392);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10882_1419_1438()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10882, 1419, 1438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10882_1464_1483()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10882, 1464, 1483);
                    return return_v;
                }


                int
                f_10882_1448_1484(Microsoft.CodeAnalysis.CSharp.AbstractRegionDataFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10882, 1448, 1484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10882, 1267, 1576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10882, 1267, 1576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10882, 1588, 1757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 1668, 1702);

                f_10882_1668_1701(this, f_10882_1678_1700(f_10882_1678_1689(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 1716, 1746);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLambda(node), 10882, 1723, 1745);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10882, 1588, 1757);

                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10882_1678_1689(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10882, 1678, 1689);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10882_1678_1700(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10882, 1678, 1700);
                    return return_v;
                }


                int
                f_10882_1668_1701(Microsoft.CodeAnalysis.CSharp.AbstractRegionDataFlowPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.MakeSlots(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10882, 1668, 1701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10882, 1588, 1757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10882, 1588, 1757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10882, 1769, 1986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 1881, 1915);

                f_10882_1881_1914(this, f_10882_1891_1913(f_10882_1891_1902(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 1929, 1975);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalFunctionStatement(node), 10882, 1936, 1974);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10882, 1769, 1986);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10882_1891_1902(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10882, 1891, 1902);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10882_1891_1913(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10882, 1891, 1913);
                    return return_v;
                }


                int
                f_10882_1881_1914(Microsoft.CodeAnalysis.CSharp.AbstractRegionDataFlowPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.MakeSlots(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10882, 1881, 1914);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10882, 1769, 1986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10882, 1769, 1986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MakeSlots(ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10882, 1998, 2259);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 2136, 2248);
                    foreach (var parameter in f_10882_2162_2172_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10882, 2136, 2248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10882, 2206, 2233);

                        f_10882_2206_2232(this, parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10882, 2136, 2248);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10882, 1, 113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10882, 1, 113);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10882, 1998, 2259);

                int
                f_10882_2206_2232(Microsoft.CodeAnalysis.CSharp.AbstractRegionDataFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10882, 2206, 2232);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10882_2162_2172_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10882, 2162, 2172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10882, 1998, 2259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10882, 1998, 2259);
            }
        }

        static AbstractRegionDataFlowPass()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10882, 442, 2266);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10882, 442, 2266);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10882, 442, 2266);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10882, 442, 2266);

        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10882_971_982_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10882, 534, 1133);
            return return_v;
        }

    }
}
