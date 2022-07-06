// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

#if NETCOREAPP
using System;
using System.Collections.Generic;
using Roslyn.Test.Utilities;

namespace Roslyn.Test.Utilities.CoreClr
{
    public sealed class CoreCLRRuntimeEnvironmentFactory : IRuntimeEnvironmentFactory
    {
        public IRuntimeEnvironment Create(IEnumerable<ModuleData> additionalDependencies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25141, 570, 626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25141, 573, 626);
                return f_25141_573_626(additionalDependencies); DynAbs.Tracing.TraceSender.TraceExitMethod(25141, 570, 626);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25141, 570, 626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25141, 570, 626);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment
            f_25141_573_626(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
            additionalDependencies)
            {
                var return_v = new Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment(additionalDependencies);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25141, 573, 626);
                return return_v;
            }

        }

        public CoreCLRRuntimeEnvironmentFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25141, 377, 634);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25141, 377, 634);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25141, 377, 634);
        }


        static CoreCLRRuntimeEnvironmentFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25141, 377, 634);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25141, 377, 634);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25141, 377, 634);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25141, 377, 634);
    }
}
#endif
