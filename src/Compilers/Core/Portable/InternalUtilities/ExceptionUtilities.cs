// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Roslyn.Utilities
{
    internal static class ExceptionUtilities
    {
        internal static Exception UnexpectedValue(object? o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(327, 673, 1099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(327, 750, 873);

                string
                output = f_327_766_872("Unexpected value '{0}' of type '{1}'", o, (DynAbs.Tracing.TraceSender.Conditional_F1(327, 823, 834) || (((o != null) && DynAbs.Tracing.TraceSender.Conditional_F2(327, 837, 857)) || DynAbs.Tracing.TraceSender.Conditional_F3(327, 860, 871))) ? f_327_837_857(f_327_837_848(o)) : "<unknown>")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(327, 887, 915);

                f_327_887_914(false, output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(327, 1043, 1088);

                return f_327_1050_1087(output);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(327, 673, 1099);

                System.Type
                f_327_837_848(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(327, 837, 848);
                    return return_v;
                }


                string?
                f_327_837_857(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(327, 837, 857);
                    return return_v;
                }


                string
                f_327_766_872(string
                format, object?
                arg0, string?
                arg1)
                {
                    var return_v = string.Format(format, arg0, (object?)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(327, 766, 872);
                    return return_v;
                }


                int
                f_327_887_914(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(327, 887, 914);
                    return 0;
                }


                System.InvalidOperationException
                f_327_1050_1087(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(327, 1050, 1087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(327, 673, 1099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(327, 673, 1099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception Unreachable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(327, 1173, 1273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(327, 1179, 1271);

                    return f_327_1186_1270("This program location is thought to be unreachable.");
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(327, 1173, 1273);

                    System.InvalidOperationException
                    f_327_1186_1270(string
                    message)
                    {
                        var return_v = new System.InvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(327, 1186, 1270);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(327, 1111, 1284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(327, 1111, 1284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ExceptionUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(327, 287, 1291);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(327, 287, 1291);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(327, 287, 1291);
        }

    }
}
