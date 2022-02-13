// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class CapturedSymbolReplacement
    {
        public readonly bool IsReusable;

        public CapturedSymbolReplacement(bool isReusable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10538, 487, 601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 464, 474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 561, 590);

                this.IsReusable = isReusable;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10538, 487, 601);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10538, 487, 601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 487, 601);
            }
        }

        public abstract BoundExpression Replacement(SyntaxNode node, Func<NamedTypeSymbol, BoundExpression> makeFrame);

        static CapturedSymbolReplacement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10538, 377, 936);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10538, 377, 936);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 377, 936);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10538, 377, 936);
    }
    internal sealed class CapturedToFrameSymbolReplacement : CapturedSymbolReplacement
    {
        public readonly LambdaCapturedVariable HoistedField;

        public CapturedToFrameSymbolReplacement(LambdaCapturedVariable hoistedField, bool isReusable)
        : base(f_10538_1221_1231_C(isReusable))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10538, 1107, 1301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 1082, 1094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 1257, 1290);

                this.HoistedField = hoistedField;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10538, 1107, 1301);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10538, 1107, 1301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 1107, 1301);
            }
        }

        public override BoundExpression Replacement(SyntaxNode node, Func<NamedTypeSymbol, BoundExpression> makeFrame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10538, 1313, 1683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 1448, 1504);

                var
                frame = f_10538_1460_1503(makeFrame, f_10538_1470_1502(this.HoistedField))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 1518, 1586);

                var
                field = f_10538_1530_1585(this.HoistedField, f_10538_1574_1584(frame))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 1600, 1672);

                return f_10538_1607_1671(node, frame, field, constantValueOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10538, 1313, 1683);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10538_1470_1502(Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10538, 1470, 1502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10538_1460_1503(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10538, 1460, 1503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10538_1574_1584(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10538, 1574, 1584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10538_1530_1585(Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10538, 1530, 1585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10538_1607_1671(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess(syntax, receiver, fieldSymbol, constantValueOpt: constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10538, 1607, 1671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10538, 1313, 1683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 1313, 1683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CapturedToFrameSymbolReplacement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10538, 944, 1690);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10538, 944, 1690);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 944, 1690);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10538, 944, 1690);

        static bool
        f_10538_1221_1231_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10538, 1107, 1301);
            return return_v;
        }

    }
    internal sealed class CapturedToStateMachineFieldReplacement : CapturedSymbolReplacement
    {
        public readonly StateMachineFieldSymbol HoistedField;

        public CapturedToStateMachineFieldReplacement(StateMachineFieldSymbol hoistedField, bool isReusable)
        : base(f_10538_1989_1999_C(isReusable))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10538, 1868, 2069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 1843, 1855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 2025, 2058);

                this.HoistedField = hoistedField;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10538, 1868, 2069);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10538, 1868, 2069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 1868, 2069);
            }
        }

        public override BoundExpression Replacement(SyntaxNode node, Func<NamedTypeSymbol, BoundExpression> makeFrame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10538, 2081, 2451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 2216, 2272);

                var
                frame = f_10538_2228_2271(makeFrame, f_10538_2238_2270(this.HoistedField))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 2286, 2354);

                var
                field = f_10538_2298_2353(this.HoistedField, f_10538_2342_2352(frame))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 2368, 2440);

                return f_10538_2375_2439(node, frame, field, constantValueOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10538, 2081, 2451);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10538_2238_2270(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10538, 2238, 2270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10538_2228_2271(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10538, 2228, 2271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10538_2342_2352(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10538, 2342, 2352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10538_2298_2353(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10538, 2298, 2353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10538_2375_2439(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess(syntax, receiver, fieldSymbol, constantValueOpt: constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10538, 2375, 2439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10538, 2081, 2451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 2081, 2451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CapturedToStateMachineFieldReplacement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10538, 1698, 2458);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10538, 1698, 2458);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 1698, 2458);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10538, 1698, 2458);

        static bool
        f_10538_1989_1999_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10538, 1868, 2069);
            return return_v;
        }

    }
    internal sealed class CapturedToExpressionSymbolReplacement : CapturedSymbolReplacement
    {
        private readonly BoundExpression _replacement;

        public readonly ImmutableArray<StateMachineFieldSymbol> HoistedFields;

        public CapturedToExpressionSymbolReplacement(BoundExpression replacement, ImmutableArray<StateMachineFieldSymbol> hoistedFields, bool isReusable)
        : base(f_10538_2874_2884_C(isReusable))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10538, 2708, 2997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 2603, 2615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 2910, 2937);

                _replacement = replacement;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 2951, 2986);

                this.HoistedFields = hoistedFields;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10538, 2708, 2997);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10538, 2708, 2997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 2708, 2997);
            }
        }

        public override BoundExpression Replacement(SyntaxNode node, Func<NamedTypeSymbol, BoundExpression> makeFrame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10538, 3009, 3412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10538, 3381, 3401);

                return _replacement;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10538, 3009, 3412);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10538, 3009, 3412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 3009, 3412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CapturedToExpressionSymbolReplacement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10538, 2466, 3419);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10538, 2466, 3419);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10538, 2466, 3419);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10538, 2466, 3419);

        static bool
        f_10538_2874_2884_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10538, 2708, 2997);
            return return_v;
        }

    }
}
