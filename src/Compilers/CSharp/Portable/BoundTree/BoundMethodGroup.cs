// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class BoundMethodGroup : BoundMethodOrPropertyGroup
    {
        public BoundMethodGroup(
                    SyntaxNode syntax,
                    ImmutableArray<TypeWithAnnotations> typeArgumentsOpt,
                    BoundExpression receiverOpt,
                    string name,
                    ImmutableArray<MethodSymbol> methods,
                    LookupResult lookupResult,
                    BoundMethodGroupFlags flags,
                    bool hasErrors = false)
        : this(f_10560_896_902_C(syntax), typeArgumentsOpt, name, methods, f_10560_937_971(lookupResult), f_10560_973_991(lookupResult), flags, receiverOpt, f_10560_1013_1030(lookupResult), hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10560, 514, 1064);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10560, 514, 1064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10560, 514, 1064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10560, 514, 1064);
            }
        }

        public MemberAccessExpressionSyntax? MemberAccessExpressionSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10560, 1166, 1268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10560, 1202, 1253);

                    return this.Syntax as MemberAccessExpressionSyntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10560, 1166, 1268);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10560, 1076, 1279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10560, 1076, 1279);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxNode NameSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10560, 1344, 1677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10560, 1380, 1433);

                    var
                    memberAccess = f_10560_1399_1432(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10560, 1451, 1662) || true) && (memberAccess != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10560, 1451, 1662);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10560, 1517, 1542);

                        return f_10560_1524_1541(memberAccess);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10560, 1451, 1662);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10560, 1451, 1662);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10560, 1624, 1643);

                        return this.Syntax;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10560, 1451, 1662);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10560, 1344, 1677);

                    Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax?
                    f_10560_1399_1432(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                    this_param)
                    {
                        var return_v = this_param.MemberAccessExpressionSyntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 1399, 1432);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    f_10560_1524_1541(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 1524, 1541);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10560, 1291, 1688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10560, 1291, 1688);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public BoundExpression? InstanceOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10560, 1760, 2071);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10560, 1796, 2056) || true) && (f_10560_1800_1816(this) == null || (DynAbs.Tracing.TraceSender.Expression_False(10560, 1800, 1877) || f_10560_1828_1849(f_10560_1828_1844(this)) == BoundKind.TypeExpression))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10560, 1796, 2056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10560, 1919, 1931);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10560, 1796, 2056);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10560, 1796, 2056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10560, 2013, 2037);

                        return f_10560_2020_2036(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10560, 1796, 2056);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10560, 1760, 2071);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10560_1800_1816(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                    this_param)
                    {
                        var return_v = this_param.ReceiverOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 1800, 1816);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10560_1828_1844(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                    this_param)
                    {
                        var return_v = this_param.ReceiverOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 1828, 1844);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10560_1828_1849(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 1828, 1849);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10560_2020_2036(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                    this_param)
                    {
                        var return_v = this_param.ReceiverOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 2020, 2036);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10560, 1700, 2082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10560, 1700, 2082);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool SearchExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10560, 2153, 2276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10560, 2189, 2261);

                    return (f_10560_2197_2207(this) & BoundMethodGroupFlags.SearchExtensionMethods) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10560, 2153, 2276);

                    Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags?
                    f_10560_2197_2207(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                    this_param)
                    {
                        var return_v = this_param.Flags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 2197, 2207);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10560, 2094, 2287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10560, 2094, 2287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundMethodGroup()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10560, 422, 2294);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10560, 422, 2294);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10560, 422, 2294);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10560, 422, 2294);

        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10560_937_971(Microsoft.CodeAnalysis.CSharp.LookupResult
        this_param)
        {
            var return_v = this_param.SingleSymbolOrDefault;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 937, 971);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticInfo
        f_10560_973_991(Microsoft.CodeAnalysis.CSharp.LookupResult
        this_param)
        {
            var return_v = this_param.Error;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 973, 991);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.LookupResultKind
        f_10560_1013_1030(Microsoft.CodeAnalysis.CSharp.LookupResult
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10560, 1013, 1030);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10560_896_902_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10560, 514, 1064);
            return return_v;
        }

    }
}
