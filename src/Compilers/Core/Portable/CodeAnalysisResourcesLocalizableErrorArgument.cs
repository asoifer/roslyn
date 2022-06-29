// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Globalization;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    internal struct CodeAnalysisResourcesLocalizableErrorArgument : IFormattable
    {

        private readonly string _targetResourceId;

        internal CodeAnalysisResourcesLocalizableErrorArgument(string targetResourceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(4, 494, 705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(4, 598, 643);

                f_4_598_642(targetResourceId != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(4, 657, 694);

                _targetResourceId = targetResourceId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(4, 494, 705);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(4, 494, 705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(4, 494, 705);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(4, 717, 814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(4, 775, 803);

                return ToString(null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(4, 717, 814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(4, 717, 814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(4, 717, 814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(4, 826, 1189);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(4, 922, 1142) || true) && (_targetResourceId != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(4, 922, 1142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(4, 985, 1127);

                    return f_4_992_1110(f_4_992_1029(), _targetResourceId, formatProvider as System.Globalization.CultureInfo) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(4, 992, 1126) ?? string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(4, 922, 1142);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(4, 1158, 1178);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(4, 826, 1189);

                System.Resources.ResourceManager
                f_4_992_1029()
                {
                    var return_v = CodeAnalysisResources.ResourceManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(4, 992, 1029);
                    return return_v;
                }


                string?
                f_4_992_1110(System.Resources.ResourceManager
                this_param, string
                name, System.IFormatProvider?
                culture)
                {
                    var return_v = this_param.GetString(name, (System.Globalization.CultureInfo?)culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(4, 992, 1110);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(4, 826, 1189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(4, 826, 1189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static CodeAnalysisResourcesLocalizableErrorArgument()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(4, 347, 1196);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(4, 347, 1196);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(4, 347, 1196);
        }

        static int
        f_4_598_642(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(4, 598, 642);
            return 0;
        }

    }
}
