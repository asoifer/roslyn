// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundDiscardExpression
    {
        public BoundExpression SetInferredTypeWithAnnotations(TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10553, 393, 595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10553, 497, 540);

                f_10553_497_539(f_10553_510_514() is null && (DynAbs.Tracing.TraceSender.Expression_True(10553, 510, 538) && type.HasType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10553, 554, 584);

                return f_10553_561_583(this, type.Type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10553, 393, 595);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10553_510_514()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10553, 510, 514);
                    return return_v;
                }


                int
                f_10553_497_539(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10553, 497, 539);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                f_10553_561_583(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10553, 561, 583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10553, 393, 595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10553, 393, 595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundDiscardExpression FailInference(Binder binder, DiagnosticBag? diagnosticsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10553, 607, 955);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10553, 721, 880) || true) && (diagnosticsOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10553, 721, 880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10553, 781, 865);

                    f_10553_781_864(diagnosticsOpt, ErrorCode.ERR_DiscardTypeInferenceFailed, this.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10553, 721, 880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10553, 894, 944);

                return f_10553_901_943(this, f_10553_913_942(binder, "var"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10553, 607, 955);

                int
                f_10553_781_864(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Binder.Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10553, 781, 864);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10553_913_942(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10553, 913, 942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                f_10553_901_943(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Update((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10553, 901, 943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10553, 607, 955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10553, 607, 955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ExpressionSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10553, 1031, 1255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10553, 1067, 1098);

                    f_10553_1067_1097(f_10553_1080_1089(this) is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10553, 1116, 1240);

                    return f_10553_1123_1239(TypeWithAnnotations.Create(f_10553_1168_1177(this), f_10553_1179_1237(this.TopLevelNullability.Annotation)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10553, 1031, 1255);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10553_1080_1089(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10553, 1080, 1089);
                        return return_v;
                    }


                    int
                    f_10553_1067_1097(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10553, 1067, 1097);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10553_1168_1177(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10553, 1168, 1177);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                    f_10553_1179_1237(Microsoft.CodeAnalysis.NullableAnnotation
                    annotation)
                    {
                        var return_v = annotation.ToInternalAnnotation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10553, 1179, 1237);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol
                    f_10553_1123_1239(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    typeWithAnnotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol(typeWithAnnotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10553, 1123, 1239);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10553, 967, 1266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10553, 967, 1266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundDiscardExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10553, 331, 1273);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10553, 331, 1273);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10553, 331, 1273);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10553, 331, 1273);
    }
}
