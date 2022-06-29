// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Specifies the version of the SARIF log file to produce.
    /// </summary>
    public enum SarifVersion
    {
        /// <summary>
        /// The original, non-standardized version of the SARIF format.
        /// </summary>
        Sarif1 = 1,

        /// <summary>
        /// The first standardized version of the SARIF format.
        /// </summary>
        Sarif2 = 2,

        /// <summary>
        /// The default SARIF version, which is v1.0.0 for compatibility with
        /// previous versions of the compiler.
        /// </summary>
        Default = Sarif1,

        /// <summary>
        /// The latest supported SARIF version.
        /// </summary>
        Latest = int.MaxValue
    }
    public static class SarifVersionFacts
    {
        public static bool TryParse(string version, out SarifVersion result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(140, 1176, 2144);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1269, 1397) || true) && (version == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(140, 1269, 1397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1322, 1352);

                    result = SarifVersion.Default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1370, 1382);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(140, 1269, 1397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1413, 2133);

                switch (f_140_1421_1463(version))
                {

                    case "default":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(140, 1413, 2133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1534, 1564);

                        result = SarifVersion.Default;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1586, 1598);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(140, 1413, 2133);

                    case "latest":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(140, 1413, 2133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1654, 1683);

                        result = SarifVersion.Latest;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1705, 1717);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(140, 1413, 2133);

                    case "1":
                    case "1.0":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(140, 1413, 2133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1797, 1826);

                        result = SarifVersion.Sarif1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1848, 1860);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(140, 1413, 2133);

                    case "2":
                    case "2.1":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(140, 1413, 2133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1940, 1969);

                        result = SarifVersion.Sarif2;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 1991, 2003);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(140, 1413, 2133);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(140, 1413, 2133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 2053, 2083);

                        result = SarifVersion.Default;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(140, 2105, 2118);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(140, 1413, 2133);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(140, 1176, 2144);

                string?
                f_140_1421_1463(string
                value)
                {
                    var return_v = CaseInsensitiveComparison.ToLower(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(140, 1421, 1463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(140, 1176, 2144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(140, 1176, 2144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SarifVersionFacts()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(140, 1007, 2151);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(140, 1007, 2151);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(140, 1007, 2151);
        }

    }
}
