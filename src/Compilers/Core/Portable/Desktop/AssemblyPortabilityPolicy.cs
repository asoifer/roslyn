// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using System.Xml;

namespace Microsoft.CodeAnalysis
{

    internal struct AssemblyPortabilityPolicy : IEquatable<AssemblyPortabilityPolicy>
    {

        public readonly bool SuppressSilverlightPlatformAssembliesPortability;

        public readonly bool SuppressSilverlightLibraryAssembliesPortability;

        public AssemblyPortabilityPolicy(
                    bool suppressSilverlightPlatformAssembliesPortability,
                    bool suppressSilverlightLibraryAssembliesPortability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(173, 867, 1293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 1060, 1163);

                this.SuppressSilverlightLibraryAssembliesPortability = suppressSilverlightLibraryAssembliesPortability;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 1177, 1282);

                this.SuppressSilverlightPlatformAssembliesPortability = suppressSilverlightPlatformAssembliesPortability;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(173, 867, 1293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(173, 867, 1293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(173, 867, 1293);
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(173, 1305, 1462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 1369, 1451);

                return obj is AssemblyPortabilityPolicy && (DynAbs.Tracing.TraceSender.Expression_True(173, 1376, 1450) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(173, 1305, 1462);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(173, 1305, 1462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(173, 1305, 1462);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(AssemblyPortabilityPolicy other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(173, 1474, 1810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 1550, 1799);

                return this.SuppressSilverlightLibraryAssembliesPortability == other.SuppressSilverlightLibraryAssembliesPortability
                && (DynAbs.Tracing.TraceSender.Expression_True(173, 1557, 1798) && this.SuppressSilverlightPlatformAssembliesPortability == other.SuppressSilverlightPlatformAssembliesPortability);
                DynAbs.Tracing.TraceSender.TraceExitMethod(173, 1474, 1810);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(173, 1474, 1810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(173, 1474, 1810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(173, 1822, 2047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 1880, 2036);

                return ((DynAbs.Tracing.TraceSender.Conditional_F1(173, 1888, 1940) || ((this.SuppressSilverlightLibraryAssembliesPortability && DynAbs.Tracing.TraceSender.Conditional_F2(173, 1943, 1944)) || DynAbs.Tracing.TraceSender.Conditional_F3(173, 1947, 1948))) ? 1 : 0) |
                                   ((DynAbs.Tracing.TraceSender.Conditional_F1(173, 1973, 2026) || ((this.SuppressSilverlightPlatformAssembliesPortability && DynAbs.Tracing.TraceSender.Conditional_F2(173, 2029, 2030)) || DynAbs.Tracing.TraceSender.Conditional_F3(173, 2033, 2034))) ? 2 : 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(173, 1822, 2047);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(173, 1822, 2047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(173, 1822, 2047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ReadToChild(XmlReader reader, int depth, string elementName, string elementNamespace = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(173, 2059, 2292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 2194, 2281);

                return f_173_2201_2255(reader, elementName, elementNamespace) && (DynAbs.Tracing.TraceSender.Expression_True(173, 2201, 2280) && f_173_2259_2271(reader) == depth);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(173, 2059, 2292);

                bool
                f_173_2201_2255(System.Xml.XmlReader
                this_param, string
                localName, string
                namespaceURI)
                {
                    var return_v = this_param.ReadToDescendant(localName, namespaceURI);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 2201, 2255);
                    return return_v;
                }


                int
                f_173_2259_2271(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Depth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(173, 2259, 2271);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(173, 2059, 2292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(173, 2059, 2292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly XmlReaderSettings s_xmlSettings;

        internal static AssemblyPortabilityPolicy LoadFromXml(Stream input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(173, 2473, 5012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 2709, 2762);

                const string
                ns = "urn:schemas-microsoft-com:asm.v1"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 2778, 5001);
                using (XmlReader
                xml = f_173_2801_2839(input, s_xmlSettings)
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 2873, 3212) || true) && (!ReadToChild(xml, 0, "configuration") || (DynAbs.Tracing.TraceSender.Expression_False(173, 2877, 2970) || !ReadToChild(xml, 1, "runtime")) || (DynAbs.Tracing.TraceSender.Expression_False(173, 2877, 3038) || !ReadToChild(xml, 2, "assemblyBinding", ns)) || (DynAbs.Tracing.TraceSender.Expression_False(173, 2877, 3109) || !ReadToChild(xml, 3, "supportPortability", ns)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(173, 2873, 3212);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 3151, 3193);

                        return default(AssemblyPortabilityPolicy);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(173, 2873, 3212);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 3269, 3298);

                    bool
                    suppressLibrary = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 3355, 3385);

                    bool
                    suppressPlatform = false
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(173, 3405, 4894);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 3874, 3911);

                                string
                                pkt = f_173_3887_3910(xml, "PKT")
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 3933, 3985);

                                string
                                enableAttribute = f_173_3958_3984(xml, "enable")
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 4009, 4281);

                                bool?
                                enable =
                                (DynAbs.Tracing.TraceSender.Conditional_F1(173, 4049, 4124) || ((f_173_4049_4124(enableAttribute, "false", StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(173, 4127, 4132)) || DynAbs.Tracing.TraceSender.Conditional_F3(173, 4160, 4280))) ? false : (DynAbs.Tracing.TraceSender.Conditional_F1(173, 4160, 4234) || ((f_173_4160_4234(enableAttribute, "true", StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(173, 4237, 4241)) || DynAbs.Tracing.TraceSender.Conditional_F3(173, 4269, 4280))) ? true : (bool?)null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 4305, 4818) || true) && (enable != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(173, 4305, 4818);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 4373, 4795) || true) && (f_173_4377_4451(pkt, "31bf3856ad364e35", StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(173, 4373, 4795);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 4509, 4541);

                                        suppressLibrary = f_173_4527_4540_M(!enable.Value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(173, 4373, 4795);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(173, 4373, 4795);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 4599, 4795) || true) && (f_173_4603_4677(pkt, "7cec85d7bea7798e", StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(173, 4599, 4795);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 4735, 4768);

                                            suppressPlatform = f_173_4754_4767_M(!enable.Value);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(173, 4599, 4795);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(173, 4373, 4795);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(173, 4305, 4818);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(173, 3405, 4894);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 3405, 4894) || true) && (f_173_4845_4892(xml, "supportPortability", ns))
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(173, 3405, 4894);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(173, 3405, 4894);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 4914, 4986);

                    return f_173_4921_4985(suppressPlatform, suppressLibrary);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(173, 2778, 5001);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(173, 2473, 5012);

                System.Xml.XmlReader
                f_173_2801_2839(System.IO.Stream
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create(input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 2801, 2839);
                    return return_v;
                }


                string
                f_173_3887_3910(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 3887, 3910);
                    return return_v;
                }


                string
                f_173_3958_3984(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 3958, 3984);
                    return return_v;
                }


                bool
                f_173_4049_4124(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 4049, 4124);
                    return return_v;
                }


                bool
                f_173_4160_4234(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 4160, 4234);
                    return return_v;
                }


                bool
                f_173_4377_4451(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 4377, 4451);
                    return return_v;
                }


                bool
                f_173_4527_4540_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(173, 4527, 4540);
                    return return_v;
                }


                bool
                f_173_4603_4677(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 4603, 4677);
                    return return_v;
                }


                bool
                f_173_4754_4767_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(173, 4754, 4767);
                    return return_v;
                }


                bool
                f_173_4845_4892(System.Xml.XmlReader
                this_param, string
                localName, string
                namespaceURI)
                {
                    var return_v = this_param.ReadToNextSibling(localName, namespaceURI);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 4845, 4892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyPortabilityPolicy
                f_173_4921_4985(bool
                suppressSilverlightPlatformAssembliesPortability, bool
                suppressSilverlightLibraryAssembliesPortability)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyPortabilityPolicy(suppressSilverlightPlatformAssembliesPortability, suppressSilverlightLibraryAssembliesPortability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(173, 4921, 4985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(173, 2473, 5012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(173, 2473, 5012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static AssemblyPortabilityPolicy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(173, 467, 5019);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(173, 2346, 2460);
            s_xmlSettings = new XmlReaderSettings()
            {
                DtdProcessing = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => DtdProcessing.Prohibit, 173, 2362, 2460)
            }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(173, 467, 5019);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(173, 467, 5019);
        }
    }
}
