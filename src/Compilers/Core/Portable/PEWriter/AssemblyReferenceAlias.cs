// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.Cci
{

    internal struct AssemblyReferenceAlias
    {

        public readonly string Name;

        public readonly IAssemblyReference Assembly;

        internal AssemblyReferenceAlias(string name, IAssemblyReference assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(476, 781, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(476, 879, 912);

                f_476_879_911(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(476, 926, 963);

                f_476_926_962(assembly != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(476, 979, 991);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(476, 1005, 1025);

                Assembly = assembly;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(476, 781, 1036);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(476, 781, 1036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(476, 781, 1036);
            }
        }
        static AssemblyReferenceAlias()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(476, 435, 1043);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(476, 435, 1043);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(476, 435, 1043);
        }

        static int
        f_476_879_911(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(476, 879, 911);
            return 0;
        }


        static int
        f_476_926_962(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(476, 926, 962);
            return 0;
        }

    }
}
