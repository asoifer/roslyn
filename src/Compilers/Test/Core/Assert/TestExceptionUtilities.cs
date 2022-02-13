// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public static class TestExceptionUtilities
    {
        public static InvalidOperationException UnexpectedValue(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25020, 361, 696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25020, 451, 574);

                string
                output = f_25020_467_573("Unexpected value '{0}' of type '{1}'", o, (DynAbs.Tracing.TraceSender.Conditional_F1(25020, 524, 535) || (((o != null) && DynAbs.Tracing.TraceSender.Conditional_F2(25020, 538, 558)) || DynAbs.Tracing.TraceSender.Conditional_F3(25020, 561, 572))) ? f_25020_538_558(f_25020_538_549(o)) : "<unknown>")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25020, 588, 626);

                f_25020_588_625(output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25020, 640, 685);

                return f_25020_647_684(output);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25020, 361, 696);

                System.Type
                f_25020_538_549(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25020, 538, 549);
                    return return_v;
                }


                string?
                f_25020_538_558(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25020, 538, 558);
                    return return_v;
                }


                string
                f_25020_467_573(string
                format, object
                arg0, string?
                arg1)
                {
                    var return_v = string.Format(format, arg0, (object?)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25020, 467, 573);
                    return return_v;
                }


                int
                f_25020_588_625(string
                message)
                {
                    System.Diagnostics.Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25020, 588, 625);
                    return 0;
                }


                System.InvalidOperationException
                f_25020_647_684(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25020, 647, 684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25020, 361, 696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25020, 361, 696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TestExceptionUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25020, 302, 703);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25020, 302, 703);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25020, 302, 703);
        }

    }
}
