// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class OutDeconstructVarPendingInference
    {
        public BoundDeconstructValuePlaceholder? Placeholder;

        public BoundDeconstructValuePlaceholder SetInferredTypeWithAnnotations(TypeWithAnnotations type, Binder binder, bool success)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10587, 494, 982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10587, 644, 678);

                f_10587_644_677(Placeholder is null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10587, 800, 938);

                Placeholder = f_10587_814_937(this.Syntax, f_10587_864_886(binder), type.Type, hasErrors: f_10587_910_924(this) || (DynAbs.Tracing.TraceSender.Expression_False(10587, 910, 936) || !success));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10587, 952, 971);

                return Placeholder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10587, 494, 982);

                int
                f_10587_644_677(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10587, 644, 677);
                    return 0;
                }


                uint
                f_10587_864_886(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10587, 864, 886);
                    return return_v;
                }


                bool
                f_10587_910_924(Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10587, 910, 924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                f_10587_814_937(Microsoft.CodeAnalysis.SyntaxNode
                syntax, uint
                valEscape, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder(syntax, valEscape, type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10587, 814, 937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10587, 494, 982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10587, 494, 982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundDeconstructValuePlaceholder FailInference(Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10587, 994, 1214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10587, 1087, 1203);

                return f_10587_1094_1202(this, TypeWithAnnotations.Create(f_10587_1152_1176(binder)), binder, success: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10587, 994, 1214);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10587_1152_1176(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10587, 1152, 1176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                f_10587_1094_1202(Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Binder
                binder, bool
                success)
                {
                    var return_v = this_param.SetInferredTypeWithAnnotations(type, binder, success: success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10587, 1094, 1202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10587, 994, 1214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10587, 994, 1214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
