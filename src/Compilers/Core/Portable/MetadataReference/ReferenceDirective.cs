// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{

    internal readonly struct ReferenceDirective
    {

        public readonly string? File;

        public readonly Location? Location;

        public ReferenceDirective(string file, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(436, 577, 804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(436, 659, 686);

                f_436_659_685(file != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(436, 700, 731);

                f_436_700_730(location != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(436, 747, 759);

                File = file;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(436, 773, 793);

                Location = location;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(436, 577, 804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(436, 577, 804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(436, 577, 804);
            }
        }
        static ReferenceDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(436, 431, 811);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(436, 431, 811);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(436, 431, 811);
        }

        static int
        f_436_659_685(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(436, 659, 685);
            return 0;
        }


        static int
        f_436_700_730(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(436, 700, 730);
            return 0;
        }

    }
}
