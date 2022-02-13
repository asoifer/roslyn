// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class DiagnosticsPass
    {
        private readonly DiagnosticBag _diagnostics;

        private readonly CSharpCompilation _compilation;

        private bool _inExpressionLambda;

        private bool _reportedUnsafe;

        private readonly MethodSymbol _containingSymbol;

        private SourceMethodSymbol _staticLocalOrAnonymousFunction;

        public static void IssueDiagnostics(CSharpCompilation compilation, BoundNode node, DiagnosticBag diagnostics, MethodSymbol containingSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10432, 1260, 1955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 1425, 1452);

                f_10432_1425_1451(node != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 1466, 1513);

                f_10432_1466_1512((object)containingSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 1529, 1617);

                f_10432_1529_1616(compilation, containingSymbol, diagnostics);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 1669, 1754);

                    var
                    diagnosticPass = f_10432_1690_1753(compilation, diagnostics, containingSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 1772, 1799);

                    f_10432_1772_1798(diagnosticPass, node);
                }
                catch (CancelledByStackGuardException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10432, 1828, 1944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 1902, 1929);

                    f_10432_1902_1928(ex, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10432, 1828, 1944);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10432, 1260, 1955);

                int
                f_10432_1425_1451(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 1425, 1451);
                    return 0;
                }


                int
                f_10432_1466_1512(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 1466, 1512);
                    return 0;
                }


                int
                f_10432_1529_1616(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                iterator, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ExecutableCodeBinder.ValidateIteratorMethod(compilation, iterator, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 1529, 1616);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                f_10432_1690_1753(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticsPass(compilation, diagnostics, containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 1690, 1753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10432_1772_1798(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 1772, 1798);
                    return return_v;
                }


                int
                f_10432_1902_1928(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddAnError(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 1902, 1928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 1260, 1955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 1260, 1955);
            }
        }

        private DiagnosticsPass(CSharpCompilation compilation, DiagnosticBag diagnostics, MethodSymbol containingSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10432, 1967, 2345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 875, 887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 933, 945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 969, 988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 1012, 1027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 1068, 1085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 1216, 1247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2104, 2138);

                f_10432_2104_2137(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2152, 2199);

                f_10432_2152_2198((object)containingSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2215, 2242);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2256, 2283);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2297, 2334);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10432, 1967, 2345);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 1967, 2345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 1967, 2345);
            }
        }

        private void Error(ErrorCode code, BoundNode node, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 2357, 2516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2454, 2505);

                f_10432_2454_2504(_diagnostics, code, f_10432_2477_2497(node.Syntax), args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 2357, 2516);

                Microsoft.CodeAnalysis.Location
                f_10432_2477_2497(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 2477, 2497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10432_2454_2504(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 2454, 2504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 2357, 2516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 2357, 2516);
            }
        }

        private void CheckUnsafeType(BoundExpression e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 2528, 2705);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2600, 2694) || true) && (e != null && (DynAbs.Tracing.TraceSender.Expression_True(10432, 2604, 2639) && (object)f_10432_2625_2631(e) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10432, 2604, 2678) && f_10432_2643_2678(f_10432_2643_2649(e))))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 2600, 2694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2680, 2694);

                    f_10432_2680_2693(this, e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 2600, 2694);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 2528, 2705);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10432_2625_2631(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 2625, 2631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10432_2643_2649(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 2643, 2649);
                    return return_v;
                }


                bool
                f_10432_2643_2678(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 2643, 2678);
                    return return_v;
                }


                int
                f_10432_2680_2693(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.NoteUnsafe((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 2680, 2693);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 2528, 2705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 2528, 2705);
            }
        }

        private void NoteUnsafe(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 2717, 2984);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2781, 2973) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 2785, 2824) && !_reportedUnsafe))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 2781, 2973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2858, 2917);

                    f_10432_2858_2916(this, ErrorCode.ERR_ExpressionTreeContainsPointerOp, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 2935, 2958);

                    _reportedUnsafe = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 2781, 2973);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 2717, 2984);

                int
                f_10432_2858_2916(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 2858, 2916);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 2717, 2984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 2717, 2984);
            }
        }

        public override BoundNode VisitArrayCreation(BoundArrayCreation node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 2996, 3420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 3090, 3133);

                var
                arrayType = (ArrayTypeSymbol)f_10432_3123_3132(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 3147, 3356) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 3151, 3201) && f_10432_3174_3193(node) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10432, 3151, 3225) && f_10432_3205_3225_M(!arrayType.IsSZArray)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 3147, 3356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 3259, 3341);

                    f_10432_3259_3340(this, ErrorCode.ERR_ExpressionTreeContainsMultiDimensionalArrayInitializer, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 3147, 3356);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 3372, 3409);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitArrayCreation(node), 10432, 3379, 3408);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 2996, 3420);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10432_3123_3132(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 3123, 3132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10432_3174_3193(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 3174, 3193);
                    return return_v;
                }


                bool
                f_10432_3205_3225_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 3205, 3225);
                    return return_v;
                }


                int
                f_10432_3259_3340(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 3259, 3340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 2996, 3420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 2996, 3420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayAccess(BoundArrayAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 3432, 3851);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 3522, 3789) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 3526, 3590) && node.Indices.Length == 1) && (DynAbs.Tracing.TraceSender.Expression_True(10432, 3526, 3664) && f_10432_3611_3644(f_10432_3611_3623(node)[0].Type!) == SpecialType.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 3522, 3789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 3698, 3774);

                    f_10432_3698_3773(this, ErrorCode.ERR_ExpressionTreeContainsPatternIndexOrRangeIndexer, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 3522, 3789);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 3805, 3840);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitArrayAccess(node), 10432, 3812, 3839);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 3432, 3851);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10432_3611_3623(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 3611, 3623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10432_3611_3644(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 3611, 3644);
                    return return_v;
                }


                int
                f_10432_3698_3773(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 3698, 3773);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 3432, 3851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 3432, 3851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIndexOrRangePatternIndexerAccess(BoundIndexOrRangePatternIndexerAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 3863, 4226);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 3995, 4143) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 3995, 4143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 4052, 4128);

                    f_10432_4052_4127(this, ErrorCode.ERR_ExpressionTreeContainsPatternIndexOrRangeIndexer, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 3995, 4143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 4159, 4215);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitIndexOrRangePatternIndexerAccess(node), 10432, 4166, 4214);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 3863, 4226);

                int
                f_10432_4052_4127(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 4052, 4127);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 3863, 4226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 3863, 4226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFromEndIndexExpression(BoundFromEndIndexExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 4238, 4567);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 4350, 4494) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 4350, 4494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 4407, 4479);

                    f_10432_4407_4478(this, ErrorCode.ERR_ExpressionTreeContainsFromEndIndexExpression, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 4350, 4494);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 4510, 4556);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFromEndIndexExpression(node), 10432, 4517, 4555);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 4238, 4567);

                int
                f_10432_4407_4478(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 4407, 4478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 4238, 4567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 4238, 4567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRangeExpression(BoundRangeExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 4579, 4880);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 4677, 4814) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 4677, 4814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 4734, 4799);

                    f_10432_4734_4798(this, ErrorCode.ERR_ExpressionTreeContainsRangeExpression, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 4677, 4814);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 4830, 4869);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitRangeExpression(node), 10432, 4837, 4868);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 4579, 4880);

                int
                f_10432_4734_4798(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 4734, 4798);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 4579, 4880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 4579, 4880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSizeOfOperator(BoundSizeOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 4892, 5214);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 4988, 5149) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 4992, 5041) && f_10432_5015_5033(node) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 4988, 5149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5075, 5134);

                    f_10432_5075_5133(this, ErrorCode.ERR_ExpressionTreeContainsPointerOp, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 4988, 5149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5165, 5203);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSizeOfOperator(node), 10432, 5172, 5202);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 4892, 5214);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10432_5015_5033(Microsoft.CodeAnalysis.CSharp.BoundSizeOfOperator
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 5015, 5033);
                    return return_v;
                }


                int
                f_10432_5075_5133(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundSizeOfOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 5075, 5133);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 4892, 5214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 4892, 5214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 5226, 5801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5338, 5423);

                f_10432_5338_5422(_compilation, f_10432_5396_5407(node), _diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5439, 5496);

                var
                outerLocalFunction = _staticLocalOrAnonymousFunction
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5510, 5629) || true) && (f_10432_5514_5534(f_10432_5514_5525(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 5510, 5629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5568, 5614);

                    _staticLocalOrAnonymousFunction = f_10432_5602_5613(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 5510, 5629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5643, 5695);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalFunctionStatement(node), 10432, 5656, 5694)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5709, 5762);

                _staticLocalOrAnonymousFunction = outerLocalFunction;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5776, 5790);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 5226, 5801);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10432_5396_5407(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 5396, 5407);
                    return return_v;
                }


                int
                f_10432_5338_5422(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                iterator, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ExecutableCodeBinder.ValidateIteratorMethod(compilation, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)iterator, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 5338, 5422);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10432_5514_5525(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 5514, 5525);
                    return return_v;
                }


                bool
                f_10432_5514_5534(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 5514, 5534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10432_5602_5613(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 5602, 5613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 5226, 5801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 5226, 5801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThisReference(BoundThisReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 5813, 6002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5907, 5940);

                f_10432_5907_5939(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 5954, 5991);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitThisReference(node), 10432, 5961, 5990);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 5813, 6002);

                int
                f_10432_5907_5939(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                node)
                {
                    this_param.CheckReferenceToThisOrBase((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 5907, 5939);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 5813, 6002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 5813, 6002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBaseReference(BoundBaseReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 6014, 6349);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6108, 6240) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 6108, 6240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6165, 6225);

                    f_10432_6165_6224(this, ErrorCode.ERR_ExpressionTreeContainsBaseAccess, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 6108, 6240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6254, 6287);

                f_10432_6254_6286(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6301, 6338);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBaseReference(node), 10432, 6308, 6337);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 6014, 6349);

                int
                f_10432_6165_6224(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 6165, 6224);
                    return 0;
                }


                int
                f_10432_6254_6286(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                node)
                {
                    this_param.CheckReferenceToThisOrBase((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 6254, 6286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 6014, 6349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 6014, 6349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocal(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 6361, 6542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6439, 6488);

                f_10432_6439_6487(this, node, f_10432_6470_6486(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6502, 6531);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10432, 6509, 6530);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 6361, 6542);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10432_6470_6486(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 6470, 6486);
                    return return_v;
                }


                int
                f_10432_6439_6487(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    this_param.CheckReferenceToVariable((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 6439, 6487);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 6361, 6542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 6361, 6542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 6554, 6751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6640, 6693);

                f_10432_6640_6692(this, node, f_10432_6671_6691(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6707, 6740);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitParameter(node), 10432, 6714, 6739);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 6554, 6751);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10432_6671_6691(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 6671, 6691);
                    return return_v;
                }


                int
                f_10432_6640_6692(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                node, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    this_param.CheckReferenceToVariable((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 6640, 6692);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 6554, 6751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 6554, 6751);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckReferenceToThisOrBase(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 6763, 7238);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6849, 7227) || true) && (_staticLocalOrAnonymousFunction is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 6849, 7227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 6928, 7168);

                    var
                    diagnostic = (DynAbs.Tracing.TraceSender.Conditional_F1(10432, 6945, 7015) || ((f_10432_6945_6987(_staticLocalOrAnonymousFunction) == MethodKind.LocalFunction
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10432, 7039, 7089)) || DynAbs.Tracing.TraceSender.Conditional_F3(10432, 7113, 7167))) ? ErrorCode.ERR_StaticLocalFunctionCannotCaptureThis
                    : ErrorCode.ERR_StaticAnonymousFunctionCannotCaptureThis
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 7188, 7212);

                    f_10432_7188_7211(this, diagnostic, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 6849, 7227);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 6763, 7238);

                Microsoft.CodeAnalysis.MethodKind
                f_10432_6945_6987(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 6945, 6987);
                    return return_v;
                }


                int
                f_10432_7188_7211(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 7188, 7211);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 6763, 7238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 6763, 7238);
            }
        }

        private void CheckReferenceToVariable(BoundExpression node, Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 7250, 8004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 7349, 7467);

                f_10432_7349_7466(f_10432_7362_7373(symbol) == SymbolKind.Local || (DynAbs.Tracing.TraceSender.Expression_False(10432, 7362, 7432) || f_10432_7397_7408(symbol) == SymbolKind.Parameter) || (DynAbs.Tracing.TraceSender.Expression_False(10432, 7362, 7465) || symbol is LocalFunctionSymbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 7483, 7993) || true) && (_staticLocalOrAnonymousFunction is object && (DynAbs.Tracing.TraceSender.Expression_True(10432, 7487, 7590) && f_10432_7532_7590(symbol, _staticLocalOrAnonymousFunction)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 7483, 7993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 7624, 7872);

                    var
                    diagnostic = (DynAbs.Tracing.TraceSender.Conditional_F1(10432, 7641, 7711) || ((f_10432_7641_7683(_staticLocalOrAnonymousFunction) == MethodKind.LocalFunction
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10432, 7735, 7789)) || DynAbs.Tracing.TraceSender.Conditional_F3(10432, 7813, 7871))) ? ErrorCode.ERR_StaticLocalFunctionCannotCaptureVariable
                    : ErrorCode.ERR_StaticAnonymousFunctionCannotCaptureVariable
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 7892, 7978);

                    f_10432_7892_7977(this, diagnostic, node, f_10432_7916_7976(symbol, SymbolDisplayFormat.ShortFormat));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 7483, 7993);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 7250, 8004);

                Microsoft.CodeAnalysis.SymbolKind
                f_10432_7362_7373(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 7362, 7373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10432_7397_7408(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 7397, 7408);
                    return return_v;
                }


                int
                f_10432_7349_7466(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 7349, 7466);
                    return 0;
                }


                bool
                f_10432_7532_7590(Microsoft.CodeAnalysis.CSharp.Symbol
                variable, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
                containingSymbol)
                {
                    var return_v = Symbol.IsCaptured(variable, containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 7532, 7590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10432_7641_7683(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 7641, 7683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FormattedSymbol
                f_10432_7916_7976(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                symbolDisplayFormat)
                {
                    var return_v = new Microsoft.CodeAnalysis.FormattedSymbol((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)symbol, symbolDisplayFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 7916, 7976);
                    return return_v;
                }


                int
                f_10432_7892_7977(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 7892, 7977);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 7250, 8004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 7250, 8004);
            }
        }

        private void CheckReferenceToMethodIfLocalFunction(BoundExpression node, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 8016, 8307);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 8134, 8296) || true) && (f_10432_8138_8164_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(method, 10432, 8138, 8164)?.OriginalDefinition) is LocalFunctionSymbol localFunction)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 8134, 8296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 8235, 8281);

                    f_10432_8235_8280(this, node, localFunction);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 8134, 8296);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 8016, 8307);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10432_8138_8164_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 8138, 8164);
                    return return_v;
                }


                int
                f_10432_8235_8280(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol)
                {
                    this_param.CheckReferenceToVariable(node, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 8235, 8280);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 8016, 8307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 8016, 8307);
            }
        }

        public override BoundNode VisitConvertedSwitchExpression(BoundConvertedSwitchExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 8319, 8651);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 8437, 8575) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 8437, 8575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 8494, 8560);

                    f_10432_8494_8559(this, ErrorCode.ERR_ExpressionTreeContainsSwitchExpression, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 8437, 8575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 8591, 8640);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConvertedSwitchExpression(node), 10432, 8598, 8639);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 8319, 8651);

                int
                f_10432_8494_8559(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 8494, 8559);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 8319, 8651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 8319, 8651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDeconstructionAssignmentOperator(BoundDeconstructionAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 8663, 9033);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 8795, 8950) || true) && (f_10432_8799_8817_M(!node.HasAnyErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 8795, 8950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 8851, 8935);

                    f_10432_8851_8934(this, f_10432_8912_8921(node), f_10432_8923_8933(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 8795, 8950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 8966, 9022);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDeconstructionAssignmentOperator(node), 10432, 8973, 9021);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 8663, 9033);

                bool
                f_10432_8799_8817_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 8799, 8817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                f_10432_8912_8921(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 8912, 8921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10432_8923_8933(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 8923, 8933);
                    return return_v;
                }


                int
                f_10432_8851_8934(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                leftTuple, Microsoft.CodeAnalysis.CSharp.BoundConversion
                right)
                {
                    this_param.CheckForDeconstructionAssignmentToSelf(leftTuple, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 8851, 8934);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 8663, 9033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 8663, 9033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 9045, 9514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 9149, 9180);

                f_10432_9149_9179(this, node);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 9196, 9445) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 9200, 9274) && f_10432_9223_9237(f_10432_9223_9232(node)) != BoundKind.ObjectInitializerMember) && (DynAbs.Tracing.TraceSender.Expression_True(10432, 9200, 9336) && f_10432_9278_9292(f_10432_9278_9287(node)) != BoundKind.DynamicObjectInitializerMember))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 9196, 9445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 9370, 9430);

                    f_10432_9370_9429(this, ErrorCode.ERR_ExpressionTreeContainsAssignment, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 9196, 9445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 9461, 9503);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10432, 9468, 9502);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 9045, 9514);

                bool
                f_10432_9149_9179(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                node)
                {
                    var return_v = this_param.CheckForAssignmentToSelf(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 9149, 9179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_9223_9232(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 9223, 9232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10432_9223_9237(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 9223, 9237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_9278_9287(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 9278, 9287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10432_9278_9292(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 9278, 9292);
                    return return_v;
                }


                int
                f_10432_9370_9429(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 9370, 9429);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 9045, 9514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 9045, 9514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicObjectInitializerMember(BoundDynamicObjectInitializerMember node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 9526, 9873);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 9654, 9792) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 9654, 9792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 9711, 9777);

                    f_10432_9711_9776(this, ErrorCode.ERR_ExpressionTreeContainsDynamicOperation, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 9654, 9792);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 9808, 9862);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDynamicObjectInitializerMember(node), 10432, 9815, 9861);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 9526, 9873);

                int
                f_10432_9711_9776(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectInitializerMember
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 9711, 9776);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 9526, 9873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 9526, 9873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitEventAccess(BoundEventAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 9885, 10639);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 10151, 10526) || true) && (f_10432_10155_10175(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 10151, 10526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 10209, 10309);

                    bool
                    hasBaseReceiver = f_10432_10232_10248(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10432, 10232, 10308) && f_10432_10260_10281(f_10432_10260_10276(node)) == BoundKind.BaseReference)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 10327, 10511);

                    f_10432_10327_10510(_diagnostics, f_10432_10376_10408(f_10432_10376_10392(node)), node.Syntax, hasBaseReceiver, _containingSymbol, f_10432_10459_10491(_containingSymbol), BinderFlags.None);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 10151, 10526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 10540, 10579);

                f_10432_10540_10578(this, f_10432_10561_10577(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 10593, 10628);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitEventAccess(node), 10432, 10600, 10627);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 9885, 10639);

                bool
                f_10432_10155_10175(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.IsUsableAsField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10155, 10175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10432_10232_10248(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10232, 10248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_10260_10276(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10260, 10276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10432_10260_10281(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10260, 10281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10432_10376_10392(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10376, 10392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10432_10376_10408(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10376, 10408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10432_10459_10491(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10459, 10491);
                    return return_v;
                }


                int
                f_10432_10327_10510(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.BinderFlags
                location)
                {
                    Binder.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol?)symbol, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver, (Microsoft.CodeAnalysis.CSharp.Symbol)containingMember, containingType, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 10327, 10510);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10432_10561_10577(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10561, 10577);
                    return return_v;
                }


                int
                f_10432_10540_10578(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    this_param.CheckReceiverIfField(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 10540, 10578);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 9885, 10639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 9885, 10639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitEventAssignmentOperator(BoundEventAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 10651, 11349);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 10765, 10897) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 10765, 10897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 10822, 10882);

                    f_10432_10822_10881(this, ErrorCode.ERR_ExpressionTreeContainsAssignment, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 10765, 10897);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 10913, 11013);

                bool
                hasBaseReceiver = f_10432_10936_10952(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10432, 10936, 11012) && f_10432_10964_10985(f_10432_10964_10980(node)) == BoundKind.BaseReference)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 11027, 11224);

                f_10432_11027_11223(_diagnostics, f_10432_11076_11086(node), f_10432_11088_11134(((AssignmentExpressionSyntax)node.Syntax)), hasBaseReceiver, _containingSymbol, f_10432_11172_11204(_containingSymbol), BinderFlags.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 11238, 11277);

                f_10432_11238_11276(this, f_10432_11259_11275(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 11291, 11338);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitEventAssignmentOperator(node), 10432, 11298, 11337);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 10651, 11349);

                int
                f_10432_10822_10881(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 10822, 10881);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10432_10936_10952(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10936, 10952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_10964_10980(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10964, 10980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10432_10964_10985(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 10964, 10985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10432_11076_11086(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Event;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 11076, 11086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10432_11088_11134(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 11088, 11134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10432_11172_11204(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 11172, 11204);
                    return return_v;
                }


                int
                f_10432_11027_11223(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.BinderFlags
                location)
                {
                    Binder.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver, (Microsoft.CodeAnalysis.CSharp.Symbol)containingMember, containingType, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 11027, 11223);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10432_11259_11275(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 11259, 11275);
                    return return_v;
                }


                int
                f_10432_11238_11276(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    this_param.CheckReceiverIfField(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 11238, 11276);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 10651, 11349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 10651, 11349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCompoundAssignmentOperator(BoundCompoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 11361, 11596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 11481, 11519);

                f_10432_11481_11518(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 11535, 11585);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCompoundAssignmentOperator(node), 10432, 11542, 11584);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 11361, 11596);

                int
                f_10432_11481_11518(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node)
                {
                    this_param.CheckCompoundAssignmentOperator(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 11481, 11518);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 11361, 11596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 11361, 11596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitCall(
                    MethodSymbol method,
                    PropertySymbol propertyAccess,
                    ImmutableArray<BoundExpression> arguments,
                    ImmutableArray<RefKind> argumentRefKindsOpt,
                    ImmutableArray<string> argumentNamesOpt,
                    BitVector defaultArguments,
                    BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 11608, 14235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 11972, 12009);

                f_10432_11972_12008((object)method != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 12023, 12281);

                f_10432_12023_12280(((object)propertyAccess == null) || (DynAbs.Tracing.TraceSender.Expression_False(10432, 12036, 12144) || (method == f_10432_12100_12143(propertyAccess))) || (DynAbs.Tracing.TraceSender.Expression_False(10432, 12036, 12220) || (method == f_10432_12176_12219(propertyAccess))) || (DynAbs.Tracing.TraceSender.Expression_False(10432, 12036, 12279) || f_10432_12241_12279(propertyAccess)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 12297, 12352);

                f_10432_12297_12351(this, argumentRefKindsOpt, arguments, method);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 12368, 13816) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 12368, 13816);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 12425, 13801) || true) && (f_10432_12429_12468(method, f_10432_12452_12467(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 12425, 13801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 12510, 12567);

                        f_10432_12510_12566(this, ErrorCode.ERR_PartialMethodInExpressionTree, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 12425, 13801);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 12425, 13801);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 12609, 13801) || true) && ((object)propertyAccess != null && (DynAbs.Tracing.TraceSender.Expression_True(10432, 12613, 12681) && f_10432_12647_12681(propertyAccess)) && (DynAbs.Tracing.TraceSender.Expression_True(10432, 12613, 12710) && f_10432_12685_12710_M(!propertyAccess.IsIndexer)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 12609, 13801);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 12752, 12817);

                            f_10432_12752_12816(this, ErrorCode.ERR_ExpressionTreeContainsIndexedProperty, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 12609, 13801);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 12609, 13801);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 12859, 13801) || true) && (f_10432_12863_12910(arguments, defaultArguments))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 12859, 13801);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 12952, 13018);

                                f_10432_12952_13017(this, ErrorCode.ERR_ExpressionTreeContainsOptionalArgument, node);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 12859, 13801);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 12859, 13801);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13060, 13801) || true) && (f_10432_13064_13098_M(!argumentNamesOpt.IsDefaultOrEmpty))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 13060, 13801);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13140, 13203);

                                    f_10432_13140_13202(this, ErrorCode.ERR_ExpressionTreeContainsNamedArgument, node);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 13060, 13801);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 13060, 13801);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13245, 13801) || true) && (f_10432_13249_13312(method, arguments, argumentRefKindsOpt))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 13245, 13801);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13354, 13408);

                                        f_10432_13354_13407(this, ErrorCode.ERR_ComRefCallInExpressionTree, node);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 13245, 13801);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 13245, 13801);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13450, 13801) || true) && (f_10432_13454_13471(method) == MethodKind.LocalFunction)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 13450, 13801);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13541, 13604);

                                            f_10432_13541_13603(this, ErrorCode.ERR_ExpressionTreeContainsLocalFunction, node);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 13450, 13801);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 13450, 13801);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13646, 13801) || true) && (f_10432_13650_13664(method) != RefKind.None)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 13646, 13801);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13722, 13782);

                                                f_10432_13722_13781(this, ErrorCode.ERR_RefReturningCallInExpressionTree, node);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 13646, 13801);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 13450, 13801);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 13245, 13801);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 13060, 13801);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 12859, 13801);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 12609, 13801);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 12425, 13801);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 12368, 13816);
                }

                static bool hasDefaultArgument(ImmutableArray<BoundExpression> arguments, BitVector defaultArguments)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10432, 13832, 14224);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13975, 13980);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 13966, 14176) || true) && (i < arguments.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 14004, 14007)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 13966, 14176))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 13966, 14176);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 14049, 14157) || true) && (defaultArguments[i])
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 14049, 14157);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 14122, 14134);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 14049, 14157);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10432, 1, 211);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10432, 1, 211);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 14196, 14209);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10432, 13832, 14224);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 13832, 14224);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 13832, 14224);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 11608, 14235);

                int
                f_10432_11972_12008(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 11972, 12008);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10432_12100_12143(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12100, 12143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10432_12176_12219(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12176, 12219);
                    return return_v;
                }


                bool
                f_10432_12241_12279(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.MustCallMethodsDirectly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 12241, 12279);
                    return return_v;
                }


                int
                f_10432_12023_12280(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12023, 12280);
                    return 0;
                }


                int
                f_10432_12297_12351(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.CheckArguments(argumentRefKindsOpt, arguments, (Microsoft.CodeAnalysis.CSharp.Symbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12297, 12351);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10432_12452_12467(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 12452, 12467);
                    return return_v;
                }


                bool
                f_10432_12429_12468(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree)
                {
                    var return_v = this_param.CallsAreOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12429, 12468);
                    return return_v;
                }


                int
                f_10432_12510_12566(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12510, 12566);
                    return 0;
                }


                bool
                f_10432_12647_12681(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = symbol.IsIndexedProperty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12647, 12681);
                    return return_v;
                }


                bool
                f_10432_12685_12710_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 12685, 12710);
                    return return_v;
                }


                int
                f_10432_12752_12816(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12752, 12816);
                    return 0;
                }


                bool
                f_10432_12863_12910(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.BitVector
                defaultArguments)
                {
                    var return_v = hasDefaultArgument(arguments, defaultArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12863, 12910);
                    return return_v;
                }


                int
                f_10432_12952_13017(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 12952, 13017);
                    return 0;
                }


                bool
                f_10432_13064_13098_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 13064, 13098);
                    return return_v;
                }


                int
                f_10432_13140_13202(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 13140, 13202);
                    return 0;
                }


                bool
                f_10432_13249_13312(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt)
                {
                    var return_v = IsComCallWithRefOmitted(method, arguments, argumentRefKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 13249, 13312);
                    return return_v;
                }


                int
                f_10432_13354_13407(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 13354, 13407);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10432_13454_13471(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 13454, 13471);
                    return return_v;
                }


                int
                f_10432_13541_13603(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 13541, 13603);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10432_13650_13664(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 13650, 13664);
                    return return_v;
                }


                int
                f_10432_13722_13781(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 13722, 13781);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 11608, 14235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 11608, 14235);
            }
        }

        public override BoundNode Visit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 14247, 14784);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 14319, 14735) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 14323, 14471) &&                // Ignoring BoundConversion nodes prevents redundant diagnostics
                                !(node is BoundConversion)) && (DynAbs.Tracing.TraceSender.Expression_True(10432, 14323, 14520) && node is BoundExpression expr) && (DynAbs.Tracing.TraceSender.Expression_True(10432, 14323, 14569) && f_10432_14541_14550(expr) is TypeSymbol type) && (DynAbs.Tracing.TraceSender.Expression_True(10432, 14323, 14613) && f_10432_14590_14613(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 14319, 14735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 14647, 14720);

                    f_10432_14647_14719(this, ErrorCode.ERR_ExpressionTreeCantContainRefStruct, node, f_10432_14709_14718(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 14319, 14735);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 14749, 14773);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10432, 14756, 14772);
                var temp = base.Visit(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 14756, 14772);
                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 14247, 14784);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10432_14541_14550(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 14541, 14550);
                    return return_v;
                }


                bool
                f_10432_14590_14613(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 14590, 14613);
                    return return_v;
                }


                string
                f_10432_14709_14718(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 14709, 14718);
                    return return_v;
                }


                int
                f_10432_14647_14719(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 14647, 14719);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 14247, 14784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 14247, 14784);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRefTypeOperator(BoundRefTypeOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 14796, 15104);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 14894, 15038) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 14894, 15038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 14951, 15023);

                    f_10432_14951_15022(this, ErrorCode.ERR_FeatureNotValidInExpressionTree, node, "__reftype");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 14894, 15038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15054, 15093);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitRefTypeOperator(node), 10432, 15061, 15092);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 14796, 15104);

                int
                f_10432_14951_15022(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 14951, 15022);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 14796, 15104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 14796, 15104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRefValueOperator(BoundRefValueOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 15116, 15428);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15216, 15361) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 15216, 15361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15273, 15346);

                    f_10432_15273_15345(this, ErrorCode.ERR_FeatureNotValidInExpressionTree, node, "__refvalue");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 15216, 15361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15377, 15417);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitRefValueOperator(node), 10432, 15384, 15416);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 15116, 15428);

                int
                f_10432_15273_15345(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundRefValueOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 15273, 15345);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 15116, 15428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 15116, 15428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMakeRefOperator(BoundMakeRefOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 15440, 15748);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15538, 15682) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 15538, 15682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15595, 15667);

                    f_10432_15595_15666(this, ErrorCode.ERR_FeatureNotValidInExpressionTree, node, "__makeref");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 15538, 15682);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15698, 15737);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitMakeRefOperator(node), 10432, 15705, 15736);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 15440, 15748);

                int
                f_10432_15595_15666(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 15595, 15666);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 15440, 15748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 15440, 15748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArgListOperator(BoundArgListOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 15760, 16047);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15858, 15981) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 15858, 15981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15915, 15966);

                    f_10432_15915_15965(this, ErrorCode.ERR_VarArgsInExpressionTree, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 15858, 15981);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 15997, 16036);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitArgListOperator(node), 10432, 16004, 16035);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 15760, 16047);

                int
                f_10432_15915_15965(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 15915, 15965);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 15760, 16047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 15760, 16047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalAccess(BoundConditionalAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 16059, 16362);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 16161, 16294) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 16161, 16294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 16218, 16279);

                    f_10432_16218_16278(this, ErrorCode.ERR_NullPropagatingOpInExpressionTree, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 16161, 16294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 16310, 16351);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConditionalAccess(node), 10432, 16317, 16350);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 16059, 16362);

                int
                f_10432_16218_16278(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundConditionalAccess
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 16218, 16278);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 16059, 16362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 16059, 16362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectInitializerMember(BoundObjectInitializerMember node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 16374, 16896);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 16488, 16661) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 16492, 16547) && f_10432_16515_16547_M(!node.Arguments.IsDefaultOrEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 16488, 16661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 16581, 16646);

                    f_10432_16581_16645(this, ErrorCode.ERR_DictionaryInitializerInExpressionTree, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 16488, 16661);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 16677, 16822) || true) && (f_10432_16681_16698(node) is PropertySymbol property)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 16677, 16822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 16759, 16807);

                    f_10432_16759_16806(this, node, property);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 16677, 16822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 16838, 16885);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitObjectInitializerMember(node), 10432, 16845, 16884);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 16374, 16896);

                bool
                f_10432_16515_16547_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 16515, 16547);
                    return return_v;
                }


                int
                f_10432_16581_16645(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 16581, 16645);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10432_16681_16698(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 16681, 16698);
                    return return_v;
                }


                int
                f_10432_16759_16806(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                node, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    this_param.CheckRefReturningPropertyAccess((Microsoft.CodeAnalysis.CSharp.BoundNode)node, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 16759, 16806);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 16374, 16896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 16374, 16896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCall(BoundCall node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 16908, 17284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 16984, 17107);

                f_10432_16984_17106(this, f_10432_16994_17005(node), null, f_10432_17013_17027(node), f_10432_17029_17053(node), f_10432_17055_17076(node), f_10432_17078_17099(node), node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 17121, 17160);

                f_10432_17121_17159(this, f_10432_17142_17158(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 17174, 17231);

                f_10432_17174_17230(this, node, f_10432_17218_17229(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 17245, 17273);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCall(node), 10432, 17252, 17272);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 16908, 17284);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10432_16994_17005(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 16994, 17005);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10432_17013_17027(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 17013, 17027);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10432_17029_17053(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 17029, 17053);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10432_17055_17076(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 17055, 17076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10432_17078_17099(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 17078, 17099);
                    return return_v;
                }


                int
                f_10432_16984_17106(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertyAccess, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.BoundCall
                node)
                {
                    this_param.VisitCall(method, propertyAccess, arguments, argumentRefKindsOpt, argumentNamesOpt, defaultArguments, (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 16984, 17106);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10432_17142_17158(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 17142, 17158);
                    return return_v;
                }


                int
                f_10432_17121_17159(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    this_param.CheckReceiverIfField(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 17121, 17159);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10432_17218_17229(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 17218, 17229);
                    return return_v;
                }


                int
                f_10432_17174_17230(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                node, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.CheckReferenceToMethodIfLocalFunction((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 17174, 17230);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 16908, 17284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 16908, 17284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckOutDeclaration(BoundLocal local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 17467, 17687);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 17542, 17676) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 17542, 17676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 17599, 17661);

                    f_10432_17599_17660(this, ErrorCode.ERR_ExpressionTreeContainsOutVariable, local);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 17542, 17676);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 17467, 17687);

                int
                f_10432_17599_17660(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundLocal
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 17599, 17660);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 17467, 17687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 17467, 17687);
            }
        }

        private void CheckDiscard(BoundDiscardExpression argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 17699, 17926);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 17782, 17915) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 17782, 17915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 17839, 17900);

                    f_10432_17839_17899(this, ErrorCode.ERR_ExpressionTreeContainsDiscard, argument);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 17782, 17915);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 17699, 17926);

                int
                f_10432_17839_17899(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 17839, 17899);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 17699, 17926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 17699, 17926);
            }
        }

        public override BoundNode VisitCollectionElementInitializer(BoundCollectionElementInitializer node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 17938, 18479);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 18062, 18242) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 18066, 18112) && f_10432_18089_18112(f_10432_18089_18103(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 18062, 18242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 18146, 18227);

                    f_10432_18146_18226(this, ErrorCode.ERR_ExtensionCollectionElementInitializerInExpressionTree, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 18062, 18242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 18258, 18402);

                f_10432_18258_18401(this, f_10432_18268_18282(node), null, f_10432_18290_18304(node), default(ImmutableArray<RefKind>), default(ImmutableArray<string>), f_10432_18373_18394(node), node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 18416, 18468);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCollectionElementInitializer(node), 10432, 18423, 18467);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 17938, 18479);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10432_18089_18103(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18089, 18103);
                    return return_v;
                }


                bool
                f_10432_18089_18112(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18089, 18112);
                    return return_v;
                }


                int
                f_10432_18146_18226(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 18146, 18226);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10432_18268_18282(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18268, 18282);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10432_18290_18304(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18290, 18304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10432_18373_18394(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18373, 18394);
                    return return_v;
                }


                int
                f_10432_18258_18401(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertyAccess, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                node)
                {
                    this_param.VisitCall(method, propertyAccess, arguments, argumentRefKindsOpt, argumentNamesOpt, defaultArguments, (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 18258, 18401);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 17938, 18479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 17938, 18479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectCreationExpression(BoundObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 18491, 18808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 18607, 18735);

                f_10432_18607_18734(this, f_10432_18617_18633(node), null, f_10432_18641_18655(node), f_10432_18657_18681(node), f_10432_18683_18704(node), f_10432_18706_18727(node), node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 18749, 18797);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitObjectCreationExpression(node), 10432, 18756, 18796);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 18491, 18808);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10432_18617_18633(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18617, 18633);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10432_18641_18655(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18641, 18655);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10432_18657_18681(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18657, 18681);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10432_18683_18704(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18683, 18704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10432_18706_18727(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18706, 18727);
                    return return_v;
                }


                int
                f_10432_18607_18734(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertyAccess, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                node)
                {
                    this_param.VisitCall(method, propertyAccess, arguments, argumentRefKindsOpt, argumentNamesOpt, defaultArguments, (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 18607, 18734);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 18491, 18808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 18491, 18808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIndexerAccess(BoundIndexerAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 18820, 19370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 18914, 18941);

                var
                indexer = f_10432_18928_18940(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 18955, 19045);

                var
                method = f_10432_18968_19004(indexer) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10432, 18968, 19044) ?? f_10432_19008_19044(indexer))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19059, 19255) || true) && ((object)method != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 19059, 19255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19119, 19240);

                    f_10432_19119_19239(this, method, indexer, f_10432_19146_19160(node), f_10432_19162_19186(node), f_10432_19188_19209(node), f_10432_19211_19232(node), node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 19059, 19255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19269, 19308);

                f_10432_19269_19307(this, f_10432_19290_19306(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19322, 19359);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitIndexerAccess(node), 10432, 19329, 19358);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 18820, 19370);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10432_18928_18940(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 18928, 18940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10432_18968_19004(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 18968, 19004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10432_19008_19044(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 19008, 19044);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10432_19146_19160(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 19146, 19160);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10432_19162_19186(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 19162, 19186);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10432_19188_19209(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 19188, 19209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10432_19211_19232(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 19211, 19232);
                    return return_v;
                }


                int
                f_10432_19119_19239(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertyAccess, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                node)
                {
                    this_param.VisitCall(method, propertyAccess, arguments, argumentRefKindsOpt, argumentNamesOpt, defaultArguments, (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 19119, 19239);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10432_19290_19306(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 19290, 19306);
                    return return_v;
                }


                int
                f_10432_19269_19307(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    this_param.CheckReceiverIfField(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 19269, 19307);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 18820, 19370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 18820, 19370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckRefReturningPropertyAccess(BoundNode node, PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 19382, 19671);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19492, 19660) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 19496, 19551) && f_10432_19519_19535(property) != RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 19492, 19660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19585, 19645);

                    f_10432_19585_19644(this, ErrorCode.ERR_RefReturningCallInExpressionTree, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 19492, 19660);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 19382, 19671);

                Microsoft.CodeAnalysis.RefKind
                f_10432_19519_19535(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 19519, 19535);
                    return return_v;
                }


                int
                f_10432_19585_19644(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, params object[]
                args)
                {
                    this_param.Error(code, node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 19585, 19644);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 19382, 19671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 19382, 19671);
            }
        }

        public override BoundNode VisitPropertyAccess(BoundPropertyAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 19683, 19992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19779, 19814);

                var
                property = f_10432_19794_19813(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19828, 19876);

                f_10432_19828_19875(this, node, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19890, 19929);

                f_10432_19890_19928(this, f_10432_19911_19927(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 19943, 19981);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPropertyAccess(node), 10432, 19950, 19980);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 19683, 19992);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10432_19794_19813(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 19794, 19813);
                    return return_v;
                }


                int
                f_10432_19828_19875(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                node, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    this_param.CheckRefReturningPropertyAccess((Microsoft.CodeAnalysis.CSharp.BoundNode)node, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 19828, 19875);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10432_19911_19927(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 19911, 19927);
                    return return_v;
                }


                int
                f_10432_19890_19928(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    this_param.CheckReceiverIfField(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 19890, 19928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 19683, 19992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 19683, 19992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 20004, 23509);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 20084, 23147) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 20084, 23147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 20141, 20166);

                    var
                    lambda = f_10432_20154_20165(node)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 20184, 20723);
                        foreach (var p in f_10432_20202_20219_I(f_10432_20202_20219(lambda)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 20184, 20723);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 20261, 20469) || true) && (f_10432_20265_20274(p) != RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10432, 20265, 20317) && p.Locations.Length != 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 20261, 20469);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 20367, 20446);

                                f_10432_20367_20445(_diagnostics, ErrorCode.ERR_ByRefParameterInExpressionTree, f_10432_20430_20441(p)[0]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 20261, 20469);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 20491, 20704) || true) && (p.TypeWithAnnotations.IsRestrictedType())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 20491, 20704);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 20585, 20681);

                                f_10432_20585_20680(_diagnostics, ErrorCode.ERR_ExpressionTreeCantContainRefStruct, f_10432_20652_20663(p)[0], f_10432_20668_20679(f_10432_20668_20674(p)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 20491, 20704);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 20184, 20723);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10432, 1, 540);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10432, 1, 540);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 20743, 23132);

                    switch (f_10432_20751_20769(node.Syntax))
                    {

                        case SyntaxKind.ParenthesizedLambdaExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 20743, 23132);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 20914, 20982);

                                var
                                lambdaSyntax = (ParenthesizedLambdaExpressionSyntax)node.Syntax
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 21012, 21703) || true) && (lambdaSyntax.AsyncKeyword.Kind() == SyntaxKind.AsyncKeyword)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 21012, 21703);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 21141, 21191);

                                    f_10432_21141_21190(this, ErrorCode.ERR_BadAsyncExpressionTree, node);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 21012, 21703);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 21012, 21703);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 21257, 21703) || true) && (f_10432_21261_21285(f_10432_21261_21278(lambdaSyntax)) == SyntaxKind.Block)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 21257, 21703);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 21371, 21430);

                                        f_10432_21371_21429(this, ErrorCode.ERR_StatementLambdaToExpressionTree, node);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 21257, 21703);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 21257, 21703);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 21496, 21703) || true) && (f_10432_21500_21524(f_10432_21500_21517(lambdaSyntax)) == SyntaxKind.RefExpression)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 21496, 21703);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 21618, 21672);

                                            f_10432_21618_21671(this, ErrorCode.ERR_BadRefReturnExpressionTree, node);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 21496, 21703);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 21257, 21703);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 21012, 21703);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10432, 21756, 21762);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 20743, 23132);

                        case SyntaxKind.SimpleLambdaExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 20743, 23132);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 21882, 21943);

                                var
                                lambdaSyntax = (SimpleLambdaExpressionSyntax)node.Syntax
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 21973, 22664) || true) && (lambdaSyntax.AsyncKeyword.Kind() == SyntaxKind.AsyncKeyword)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 21973, 22664);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 22102, 22152);

                                    f_10432_22102_22151(this, ErrorCode.ERR_BadAsyncExpressionTree, node);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 21973, 22664);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 21973, 22664);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 22218, 22664) || true) && (f_10432_22222_22246(f_10432_22222_22239(lambdaSyntax)) == SyntaxKind.Block)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 22218, 22664);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 22332, 22391);

                                        f_10432_22332_22390(this, ErrorCode.ERR_StatementLambdaToExpressionTree, node);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 22218, 22664);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 22218, 22664);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 22457, 22664) || true) && (f_10432_22461_22485(f_10432_22461_22478(lambdaSyntax)) == SyntaxKind.RefExpression)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 22457, 22664);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 22579, 22633);

                                            f_10432_22579_22632(this, ErrorCode.ERR_BadRefReturnExpressionTree, node);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 22457, 22664);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 22218, 22664);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 21973, 22664);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10432, 22717, 22723);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 20743, 23132);

                        case SyntaxKind.AnonymousMethodExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 20743, 23132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 22815, 22880);

                            f_10432_22815_22879(this, ErrorCode.ERR_ExpressionTreeContainsAnonymousMethod, node);
                            DynAbs.Tracing.TraceSender.TraceBreak(10432, 22906, 22912);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 20743, 23132);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 20743, 23132);
                            DynAbs.Tracing.TraceSender.TraceBreak(10432, 23107, 23113);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 20743, 23132);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 20084, 23147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 23163, 23220);

                var
                outerLocalFunction = _staticLocalOrAnonymousFunction
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 23234, 23353) || true) && (f_10432_23238_23258(f_10432_23238_23249(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 23234, 23353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 23292, 23338);

                    _staticLocalOrAnonymousFunction = f_10432_23326_23337(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 23234, 23353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 23367, 23403);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLambda(node), 10432, 23380, 23402)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 23417, 23470);

                _staticLocalOrAnonymousFunction = outerLocalFunction;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 23484, 23498);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 20004, 23509);

                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10432_20154_20165(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 20154, 20165);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10432_20202_20219(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 20202, 20219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10432_20265_20274(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 20265, 20274);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10432_20430_20441(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 20430, 20441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10432_20367_20445(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 20367, 20445);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10432_20652_20663(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 20652, 20663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10432_20668_20674(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 20668, 20674);
                    return return_v;
                }


                string
                f_10432_20668_20679(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 20668, 20679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10432_20585_20680(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 20585, 20680);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10432_20202_20219_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 20202, 20219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10432_20751_20769(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 20751, 20769);
                    return return_v;
                }


                int
                f_10432_21141_21190(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 21141, 21190);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10432_21261_21278(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 21261, 21278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10432_21261_21285(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 21261, 21285);
                    return return_v;
                }


                int
                f_10432_21371_21429(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 21371, 21429);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10432_21500_21517(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 21500, 21517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10432_21500_21524(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 21500, 21524);
                    return return_v;
                }


                int
                f_10432_21618_21671(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 21618, 21671);
                    return 0;
                }


                int
                f_10432_22102_22151(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 22102, 22151);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10432_22222_22239(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 22222, 22239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10432_22222_22246(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 22222, 22246);
                    return return_v;
                }


                int
                f_10432_22332_22390(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 22332, 22390);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10432_22461_22478(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 22461, 22478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10432_22461_22485(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 22461, 22485);
                    return return_v;
                }


                int
                f_10432_22579_22632(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 22579, 22632);
                    return 0;
                }


                int
                f_10432_22815_22879(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 22815, 22879);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10432_23238_23249(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 23238, 23249);
                    return return_v;
                }


                bool
                f_10432_23238_23258(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 23238, 23258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10432_23326_23337(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 23326, 23337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 20004, 23509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 20004, 23509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBinaryOperator(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 23521, 24546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24026, 24061);

                BoundBinaryOperator
                current = node
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24075, 24507) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 24075, 24507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24120, 24149);

                        f_10432_24120_24148(this, current);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24169, 24190);

                        f_10432_24169_24189(this, f_10432_24175_24188(current));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24208, 24492) || true) && (f_10432_24212_24229(f_10432_24212_24224(current)) == BoundKind.BinaryOperator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 24208, 24492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24299, 24343);

                            current = (BoundBinaryOperator)f_10432_24330_24342(current);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 24208, 24492);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 24208, 24492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24425, 24445);

                            f_10432_24425_24444(this, f_10432_24431_24443(current));
                            DynAbs.Tracing.TraceSender.TraceBreak(10432, 24467, 24473);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 24208, 24492);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 24075, 24507);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10432, 24075, 24507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10432, 24075, 24507);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24523, 24535);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 23521, 24546);

                int
                f_10432_24120_24148(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node)
                {
                    this_param.CheckBinaryOperator(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 24120, 24148);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_24175_24188(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 24175, 24188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10432_24169_24189(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 24169, 24189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_24212_24224(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 24212, 24224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10432_24212_24229(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 24212, 24229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_24330_24342(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 24330, 24342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_24431_24443(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 24431, 24443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10432_24425_24444(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 24425, 24444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 23521, 24546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 23521, 24546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUserDefinedConditionalLogicalOperator(BoundUserDefinedConditionalLogicalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 24558, 24841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24700, 24755);

                f_10432_24700_24754(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24769, 24830);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitUserDefinedConditionalLogicalOperator(node), 10432, 24776, 24829);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 24558, 24841);

                int
                f_10432_24700_24754(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                node)
                {
                    this_param.CheckLiftedUserDefinedConditionalLogicalOperator(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 24700, 24754);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 24558, 24841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 24558, 24841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckDynamic(BoundUnaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 24853, 25110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 24928, 25099) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 24932, 24984) && f_10432_24955_24984(f_10432_24955_24972(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 24928, 25099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25018, 25084);

                    f_10432_25018_25083(this, ErrorCode.ERR_ExpressionTreeContainsDynamicOperation, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 24928, 25099);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 24853, 25110);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10432_24955_24972(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 24955, 24972);
                    return return_v;
                }


                bool
                f_10432_24955_24984(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 24955, 24984);
                    return return_v;
                }


                int
                f_10432_25018_25083(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 25018, 25083);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 24853, 25110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 24853, 25110);
            }
        }

        private void CheckDynamic(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 25122, 25380);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25198, 25369) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 25202, 25254) && f_10432_25225_25254(f_10432_25225_25242(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 25198, 25369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25288, 25354);

                    f_10432_25288_25353(this, ErrorCode.ERR_ExpressionTreeContainsDynamicOperation, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 25198, 25369);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 25122, 25380);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10432_25225_25242(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 25225, 25242);
                    return return_v;
                }


                bool
                f_10432_25225_25254(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 25225, 25254);
                    return return_v;
                }


                int
                f_10432_25288_25353(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 25288, 25353);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 25122, 25380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 25122, 25380);
            }
        }

        public override BoundNode VisitUnaryOperator(BoundUnaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 25392, 25642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25486, 25508);

                f_10432_25486_25507(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25522, 25547);

                f_10432_25522_25546(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25561, 25580);

                f_10432_25561_25579(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25594, 25631);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitUnaryOperator(node), 10432, 25601, 25630);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 25392, 25642);

                int
                f_10432_25486_25507(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                e)
                {
                    this_param.CheckUnsafeType((Microsoft.CodeAnalysis.CSharp.BoundExpression)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 25486, 25507);
                    return 0;
                }


                int
                f_10432_25522_25546(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                node)
                {
                    this_param.CheckLiftedUnaryOp(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 25522, 25546);
                    return 0;
                }


                int
                f_10432_25561_25579(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                node)
                {
                    this_param.CheckDynamic(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 25561, 25579);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 25392, 25642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 25392, 25642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAddressOfOperator(BoundAddressOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 25654, 26065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25756, 25778);

                f_10432_25756_25777(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25792, 25831);

                BoundExpression
                operand = f_10432_25818_25830(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25845, 25999) || true) && (f_10432_25849_25861(operand) == BoundKind.FieldAccess)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 25845, 25999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 25920, 25984);

                    f_10432_25920_25983(this, operand, consumerOpt: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 25845, 25999);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26013, 26054);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAddressOfOperator(node), 10432, 26020, 26053);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 25654, 26065);

                int
                f_10432_25756_25777(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                e)
                {
                    this_param.CheckUnsafeType((Microsoft.CodeAnalysis.CSharp.BoundExpression)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 25756, 25777);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_25818_25830(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 25818, 25830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10432_25849_25861(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 25849, 25861);
                    return return_v;
                }


                int
                f_10432_25920_25983(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                fieldAccess, Microsoft.CodeAnalysis.CSharp.Symbol
                consumerOpt)
                {
                    this_param.CheckFieldAddress((Microsoft.CodeAnalysis.CSharp.BoundFieldAccess)fieldAccess, consumerOpt: consumerOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 25920, 25983);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 25654, 26065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 25654, 26065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIncrementOperator(BoundIncrementOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 26077, 26379);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26179, 26311) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 26179, 26311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26236, 26296);

                    f_10432_26236_26295(this, ErrorCode.ERR_ExpressionTreeContainsAssignment, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 26179, 26311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26327, 26368);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitIncrementOperator(node), 10432, 26334, 26367);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 26077, 26379);

                int
                f_10432_26236_26295(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 26236, 26295);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 26077, 26379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 26077, 26379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPointerElementAccess(BoundPointerElementAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 26391, 26585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26499, 26516);

                f_10432_26499_26515(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26530, 26574);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPointerElementAccess(node), 10432, 26537, 26573);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 26391, 26585);

                int
                f_10432_26499_26515(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                node)
                {
                    this_param.NoteUnsafe((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 26499, 26515);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 26391, 26585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 26391, 26585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPointerIndirectionOperator(BoundPointerIndirectionOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 26597, 26809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26717, 26734);

                f_10432_26717_26733(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26748, 26798);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPointerIndirectionOperator(node), 10432, 26755, 26797);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 26597, 26809);

                int
                f_10432_26717_26733(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                node)
                {
                    this_param.NoteUnsafe((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 26717, 26733);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 26597, 26809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 26597, 26809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConversion(BoundConversion node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 26821, 28819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26909, 26939);

                f_10432_26909_26938(this, f_10432_26925_26937(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26953, 26975);

                f_10432_26953_26974(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 26989, 27038);

                bool
                wasInExpressionLambda = _inExpressionLambda
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 27052, 27093);

                bool
                oldReportedUnsafe = _reportedUnsafe
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 27107, 28616);

                switch (f_10432_27115_27134(node))
                {

                    case ConversionKind.MethodGroup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 27107, 28616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 27222, 27332);

                        f_10432_27222_27331(this, f_10432_27257_27269(node), node.Conversion.Method, parentIsConversion: true, f_10432_27321_27330(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 27356, 27368);

                        return node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 27107, 28616);

                    case ConversionKind.AnonymousFunction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 27107, 28616);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 27448, 27760) || true) && (!wasInExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 27452, 27506) && f_10432_27478_27506(f_10432_27478_27487(node))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 27448, 27760);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 27556, 27583);

                            _inExpressionLambda = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 27713, 27737);

                            _reportedUnsafe = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 27448, 27760);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10432, 27782, 27788);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 27107, 28616);

                    case ConversionKind.ImplicitDynamic:
                    case ConversionKind.ExplicitDynamic:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 27107, 28616);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 27920, 28082) || true) && (_inExpressionLambda)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 27920, 28082);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 27993, 28059);

                            f_10432_27993_28058(this, ErrorCode.ERR_ExpressionTreeContainsDynamicOperation, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 27920, 28082);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10432, 28104, 28110);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 27107, 28616);

                    case ConversionKind.ExplicitTuple:
                    case ConversionKind.ExplicitTupleLiteral:
                    case ConversionKind.ImplicitTuple:
                    case ConversionKind.ImplicitTupleLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 27107, 28616);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 28356, 28517) || true) && (_inExpressionLambda)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 28356, 28517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 28429, 28494);

                            f_10432_28429_28493(this, ErrorCode.ERR_ExpressionTreeContainsTupleConversion, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 28356, 28517);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10432, 28539, 28545);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 27107, 28616);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 27107, 28616);
                        DynAbs.Tracing.TraceSender.TraceBreak(10432, 28595, 28601);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 27107, 28616);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 28632, 28672);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConversion(node), 10432, 28645, 28671)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 28686, 28730);

                _inExpressionLambda = wasInExpressionLambda;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 28744, 28780);

                _reportedUnsafe = oldReportedUnsafe;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 28794, 28808);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 26821, 28819);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_26925_26937(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 26925, 26937);
                    return return_v;
                }


                int
                f_10432_26909_26938(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    this_param.CheckUnsafeType(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 26909, 26938);
                    return 0;
                }


                int
                f_10432_26953_26974(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                e)
                {
                    this_param.CheckUnsafeType((Microsoft.CodeAnalysis.CSharp.BoundExpression)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 26953, 26974);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10432_27115_27134(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 27115, 27134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_27257_27269(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 27257, 27269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10432_27321_27330(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 27321, 27330);
                    return return_v;
                }


                int
                f_10432_27222_27331(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method, bool
                parentIsConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                convertedToType)
                {
                    this_param.CheckMethodGroup((Microsoft.CodeAnalysis.CSharp.BoundMethodGroup)node, method, parentIsConversion: parentIsConversion, convertedToType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 27222, 27331);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10432_27478_27487(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 27478, 27487);
                    return return_v;
                }


                bool
                f_10432_27478_27506(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                _type)
                {
                    var return_v = _type.IsExpressionTree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 27478, 27506);
                    return return_v;
                }


                int
                f_10432_27993_28058(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundConversion
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 27993, 28058);
                    return 0;
                }


                int
                f_10432_28429_28493(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundConversion
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 28429, 28493);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 26821, 28819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 26821, 28819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDelegateCreationExpression(BoundDelegateCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 28831, 29298);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 28951, 29259) || true) && (f_10432_28955_28973(f_10432_28955_28968(node)) != BoundKind.MethodGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 28951, 29259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 29032, 29058);

                    f_10432_29032_29057(this, f_10432_29043_29056(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 28951, 29259);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 28951, 29259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 29124, 29244);

                    f_10432_29124_29243(this, f_10432_29159_29172(node), f_10432_29174_29188(node), parentIsConversion: true, convertedToType: f_10432_29233_29242(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 28951, 29259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 29275, 29287);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 28831, 29298);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_28955_28968(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 28955, 28968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10432_28955_28973(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 28955, 28973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_29043_29056(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 29043, 29056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10432_29032_29057(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 29032, 29057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_29159_29172(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 29159, 29172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10432_29174_29188(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 29174, 29188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10432_29233_29242(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 29233, 29242);
                    return return_v;
                }


                int
                f_10432_29124_29243(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method, bool
                parentIsConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                convertedToType)
                {
                    this_param.CheckMethodGroup((Microsoft.CodeAnalysis.CSharp.BoundMethodGroup)node, method, parentIsConversion: parentIsConversion, convertedToType: convertedToType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 29124, 29243);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 28831, 29298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 28831, 29298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMethodGroup(BoundMethodGroup node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 29310, 29524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 29400, 29487);

                f_10432_29400_29486(this, node, method: null, parentIsConversion: false, convertedToType: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 29501, 29513);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 29310, 29524);

                int
                f_10432_29400_29486(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, bool
                parentIsConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                convertedToType)
                {
                    this_param.CheckMethodGroup(node, method: method, parentIsConversion: parentIsConversion, convertedToType: convertedToType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 29400, 29486);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 29310, 29524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 29310, 29524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckMethodGroup(BoundMethodGroup node, MethodSymbol method, bool parentIsConversion, TypeSymbol convertedToType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 29536, 30826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 29923, 29983);

                f_10432_29923_29982(!(!parentIsConversion && (DynAbs.Tracing.TraceSender.Expression_True(10432, 29938, 29980) && _inExpressionLambda)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 29999, 30552) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 29999, 30552);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 30083, 30537) || true) && ((f_10432_30088_30108(node) is MethodSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10432, 30087, 30204) && f_10432_30129_30176(((MethodSymbol)f_10432_30144_30164(node))) == MethodKind.LocalFunction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 30083, 30537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 30246, 30309);

                        f_10432_30246_30308(this, ErrorCode.ERR_ExpressionTreeContainsLocalFunction, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 30083, 30537);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 30083, 30537);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 30351, 30537) || true) && (parentIsConversion && (DynAbs.Tracing.TraceSender.Expression_True(10432, 30355, 30412) && f_10432_30377_30412(convertedToType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 30351, 30537);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 30454, 30518);

                            f_10432_30454_30517(this, ErrorCode.ERR_AddressOfMethodGroupInExpressionTree, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 30351, 30537);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 30083, 30537);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 29999, 30552);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 30568, 30607);

                f_10432_30568_30606(this, f_10432_30589_30605(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 30621, 30673);

                f_10432_30621_30672(this, node, method);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 30689, 30815) || true) && (method is null || (DynAbs.Tracing.TraceSender.Expression_False(10432, 30693, 30742) || f_10432_30711_30742(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 30689, 30815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 30776, 30800);

                    f_10432_30776_30799(this, f_10432_30782_30798(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 30689, 30815);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 29536, 30826);

                int
                f_10432_29923_29982(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 29923, 29982);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10432_30088_30108(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.LookupSymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 30088, 30108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10432_30144_30164(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.LookupSymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 30144, 30164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10432_30129_30176(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 30129, 30176);
                    return return_v;
                }


                int
                f_10432_30246_30308(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 30246, 30308);
                    return 0;
                }


                bool
                f_10432_30377_30412(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 30377, 30412);
                    return return_v;
                }


                int
                f_10432_30454_30517(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 30454, 30517);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10432_30589_30605(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 30589, 30605);
                    return return_v;
                }


                int
                f_10432_30568_30606(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    this_param.CheckReceiverIfField(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 30568, 30606);
                    return 0;
                }


                int
                f_10432_30621_30672(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.CheckReferenceToMethodIfLocalFunction((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 30621, 30672);
                    return 0;
                }


                bool
                f_10432_30711_30742(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 30711, 30742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10432_30782_30798(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 30782, 30798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10432_30776_30799(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 30776, 30799);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 29536, 30826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 29536, 30826);
            }
        }

        public override BoundNode VisitNameOfOperator(BoundNameOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 30838, 31114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 31091, 31103);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 30838, 31114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 30838, 31114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 30838, 31114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNullCoalescingOperator(BoundNullCoalescingOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 31126, 31533);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 31238, 31460) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10432, 31242, 31338) && (f_10432_31266_31298(f_10432_31266_31282(node)) || (DynAbs.Tracing.TraceSender.Expression_False(10432, 31266, 31337) || f_10432_31302_31337(f_10432_31302_31318(node))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 31238, 31460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 31372, 31445);

                    f_10432_31372_31444(this, ErrorCode.ERR_ExpressionTreeContainsBadCoalesce, f_10432_31427_31443(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 31238, 31460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 31476, 31522);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitNullCoalescingOperator(node), 10432, 31483, 31521);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 31126, 31533);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_31266_31282(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 31266, 31282);
                    return return_v;
                }


                bool
                f_10432_31266_31298(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 31266, 31298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_31302_31318(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 31302, 31318);
                    return return_v;
                }


                bool
                f_10432_31302_31337(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 31302, 31337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_31427_31443(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 31427, 31443);
                    return return_v;
                }


                int
                f_10432_31372_31444(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 31372, 31444);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 31126, 31533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 31126, 31533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNullCoalescingAssignmentOperator(BoundNullCoalescingAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 31545, 31909);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 31677, 31826) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 31677, 31826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 31734, 31811);

                    f_10432_31734_31810(this, ErrorCode.ERR_ExpressionTreeCantContainNullCoalescingAssignment, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 31677, 31826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 31842, 31898);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitNullCoalescingAssignmentOperator(node), 10432, 31849, 31897);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 31545, 31909);

                int
                f_10432_31734_31810(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 31734, 31810);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 31545, 31909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 31545, 31909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicInvocation(BoundDynamicInvocation node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 31921, 32488);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32023, 32420) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 32023, 32420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32080, 32146);

                    f_10432_32080_32145(this, ErrorCode.ERR_ExpressionTreeContainsDynamicOperation, node);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32231, 32405) || true) && (f_10432_32235_32255(f_10432_32235_32250(node)) == BoundKind.MethodGroup)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 32231, 32405);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32322, 32386);

                        // LAFHIS
                        var temp = base.VisitMethodGroup((BoundMethodGroup)f_10432_32369_32384(node));
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 32329, 32385);
                        return temp;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 32231, 32405);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 32023, 32420);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32436, 32477);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDynamicInvocation(node), 10432, 32443, 32476);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 31921, 32488);

                int
                f_10432_32080_32145(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 32080, 32145);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_32235_32250(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 32235, 32250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10432_32235_32255(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 32235, 32255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_32369_32384(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 32369, 32384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 31921, 32488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 31921, 32488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicIndexerAccess(BoundDynamicIndexerAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 32500, 32867);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32608, 32746) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 32608, 32746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32665, 32731);

                    f_10432_32665_32730(this, ErrorCode.ERR_ExpressionTreeContainsDynamicOperation, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 32608, 32746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32762, 32798);

                f_10432_32762_32797(this, f_10432_32783_32796(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32812, 32856);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDynamicIndexerAccess(node), 10432, 32819, 32855);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 32500, 32867);

                int
                f_10432_32665_32730(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 32665, 32730);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10432_32783_32796(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10432, 32783, 32796);
                    return return_v;
                }


                int
                f_10432_32762_32797(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt)
                {
                    this_param.CheckReceiverIfField(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 32762, 32797);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 32500, 32867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 32500, 32867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicMemberAccess(BoundDynamicMemberAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 32879, 33193);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 32985, 33123) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 32985, 33123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 33042, 33108);

                    f_10432_33042_33107(this, ErrorCode.ERR_ExpressionTreeContainsDynamicOperation, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 32985, 33123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 33139, 33182);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDynamicMemberAccess(node), 10432, 33146, 33181);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 32879, 33193);

                int
                f_10432_33042_33107(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 33042, 33107);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 32879, 33193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 32879, 33193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicCollectionElementInitializer(BoundDynamicCollectionElementInitializer node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 33205, 33567);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 33343, 33481) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 33343, 33481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 33400, 33466);

                    f_10432_33400_33465(this, ErrorCode.ERR_ExpressionTreeContainsDynamicOperation, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 33343, 33481);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 33497, 33556);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDynamicCollectionElementInitializer(node), 10432, 33504, 33555);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 33205, 33567);

                int
                f_10432_33400_33465(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundDynamicCollectionElementInitializer
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 33400, 33465);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 33205, 33567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 33205, 33567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicObjectCreationExpression(BoundDynamicObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 33579, 33929);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 33709, 33847) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 33709, 33847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 33766, 33832);

                    f_10432_33766_33831(this, ErrorCode.ERR_ExpressionTreeContainsDynamicOperation, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 33709, 33847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 33863, 33918);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDynamicObjectCreationExpression(node), 10432, 33870, 33917);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 33579, 33929);

                int
                f_10432_33766_33831(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 33766, 33831);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 33579, 33929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 33579, 33929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIsPatternExpression(BoundIsPatternExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 33941, 34246);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34047, 34176) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 34047, 34176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34104, 34161);

                    f_10432_34104_34160(this, ErrorCode.ERR_ExpressionTreeContainsIsMatch, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 34047, 34176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34192, 34235);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitIsPatternExpression(node), 10432, 34199, 34234);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 33941, 34246);

                int
                f_10432_34104_34160(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 34104, 34160);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 33941, 34246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 33941, 34246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConvertedTupleLiteral(BoundConvertedTupleLiteral node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 34258, 34574);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34368, 34502) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 34368, 34502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34425, 34487);

                    f_10432_34425_34486(this, ErrorCode.ERR_ExpressionTreeContainsTupleLiteral, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 34368, 34502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34518, 34563);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConvertedTupleLiteral(node), 10432, 34525, 34562);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 34258, 34574);

                int
                f_10432_34425_34486(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 34425, 34486);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 34258, 34574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 34258, 34574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTupleLiteral(BoundTupleLiteral node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 34586, 34875);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34678, 34812) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 34678, 34812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34735, 34797);

                    f_10432_34735_34796(this, ErrorCode.ERR_ExpressionTreeContainsTupleLiteral, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 34678, 34812);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34828, 34864);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTupleLiteral(node), 10432, 34835, 34863);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 34586, 34875);

                int
                f_10432_34735_34796(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 34735, 34796);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 34586, 34875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 34586, 34875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTupleBinaryOperator(BoundTupleBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 34887, 35195);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 34993, 35125) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 34993, 35125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 35050, 35110);

                    f_10432_35050_35109(this, ErrorCode.ERR_ExpressionTreeContainsTupleBinOp, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 34993, 35125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 35141, 35184);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTupleBinaryOperator(node), 10432, 35148, 35183);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 34887, 35195);

                int
                f_10432_35050_35109(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 35050, 35109);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 34887, 35195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 34887, 35195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThrowExpression(BoundThrowExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 35207, 35508);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 35305, 35442) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 35305, 35442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 35362, 35427);

                    f_10432_35362_35426(this, ErrorCode.ERR_ExpressionTreeContainsThrowExpression, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 35305, 35442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 35458, 35497);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitThrowExpression(node), 10432, 35465, 35496);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 35207, 35508);

                int
                f_10432_35362_35426(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 35362, 35426);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 35207, 35508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 35207, 35508);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitWithExpression(BoundWithExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10432, 35520, 35817);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 35616, 35752) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10432, 35616, 35752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 35673, 35737);

                    f_10432_35673_35736(this, ErrorCode.ERR_ExpressionTreeContainsWithExpression, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10432, 35616, 35752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10432, 35768, 35806);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitWithExpression(node), 10432, 35775, 35805);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10432, 35520, 35817);

                int
                f_10432_35673_35736(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundWithExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 35673, 35736);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10432, 35520, 35817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 35520, 35817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DiagnosticsPass()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10432, 782, 35824);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10432, 782, 35824);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10432, 782, 35824);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10432, 782, 35824);

        int
        f_10432_2104_2137(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 2104, 2137);
            return 0;
        }


        int
        f_10432_2152_2198(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10432, 2152, 2198);
            return 0;
        }

    }
}
