// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CodeGen
{

    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal struct LocalOrParameter
    {

        public readonly LocalDefinition? Local;

        public readonly int ParameterIndex;

        private LocalOrParameter(LocalDefinition? local, int parameterIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(68, 483, 657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(68, 576, 595);

                this.Local = local;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(68, 609, 646);

                this.ParameterIndex = parameterIndex;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(68, 483, 657);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(68, 483, 657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(68, 483, 657);
            }
        }

        public static implicit operator LocalOrParameter(LocalDefinition? local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(68, 669, 816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(68, 766, 805);

                return f_68_773_804(local, -1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(68, 669, 816);

                Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                f_68_773_804(Microsoft.CodeAnalysis.CodeGen.LocalDefinition?
                local, int
                parameterIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalOrParameter(local, parameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(68, 773, 804);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(68, 669, 816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(68, 669, 816);
            }
        }
        public static implicit operator LocalOrParameter(int parameterIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(68, 828, 982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(68, 921, 971);

                return f_68_928_970(null, parameterIndex);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(68, 828, 982);

                Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                f_68_928_970(Microsoft.CodeAnalysis.CodeGen.LocalDefinition?
                local, int
                parameterIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalOrParameter(local, parameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(68, 928, 970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(68, 828, 982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(68, 828, 982);
            }
        }
        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(68, 994, 1145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(68, 1054, 1134);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(68, 1061, 1076) || (((Local != null) && DynAbs.Tracing.TraceSender.Conditional_F2(68, 1079, 1105)) || DynAbs.Tracing.TraceSender.Conditional_F3(68, 1108, 1133))) ? f_68_1079_1105(Local) : f_68_1108_1133(ParameterIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(68, 994, 1145);

                string
                f_68_1079_1105(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.GetDebuggerDisplay();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(68, 1079, 1105);
                    return return_v;
                }


                string
                f_68_1108_1133(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(68, 1108, 1133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(68, 994, 1145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(68, 994, 1145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LocalOrParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(68, 286, 1152);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(68, 286, 1152);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(68, 286, 1152);
        }
    }
}
