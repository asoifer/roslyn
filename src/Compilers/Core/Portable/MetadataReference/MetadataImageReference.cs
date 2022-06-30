// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal sealed class MetadataImageReference : PortableExecutableReference
    {
        private readonly string? _display;

        private readonly Metadata _metadata;

        internal MetadataImageReference(Metadata metadata, MetadataReferenceProperties properties, DocumentationProvider? documentation, string? filePath, string? display)
        : base(f_430_857_867_C(properties), filePath, documentation ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DocumentationProvider?>(430, 879, 925) ?? f_430_896_925()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(430, 673, 1016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 606, 614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 651, 660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 951, 970);

                _display = display;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 984, 1005);

                _metadata = metadata;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(430, 673, 1016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(430, 673, 1016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(430, 673, 1016);
            }
        }

        protected override Metadata GetMetadataImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(430, 1028, 1126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 1098, 1115);

                return _metadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(430, 1028, 1126);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(430, 1028, 1126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(430, 1028, 1126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override DocumentationProvider CreateDocumentationProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(430, 1138, 1354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 1306, 1343);

                throw f_430_1312_1342();
                DynAbs.Tracing.TraceSender.TraceExitMethod(430, 1138, 1354);

                System.Exception
                f_430_1312_1342()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 1312, 1342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(430, 1138, 1354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(430, 1138, 1354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override PortableExecutableReference WithPropertiesImpl(MetadataReferenceProperties properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(430, 1366, 1703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 1496, 1692);

                return f_430_1503_1691(_metadata, properties, f_430_1605_1631(this), f_430_1650_1663(this), _display);
                DynAbs.Tracing.TraceSender.TraceExitMethod(430, 1366, 1703);

                Microsoft.CodeAnalysis.DocumentationProvider
                f_430_1605_1631(Microsoft.CodeAnalysis.MetadataImageReference
                this_param)
                {
                    var return_v = this_param.DocumentationProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 1605, 1631);
                    return return_v;
                }


                string?
                f_430_1650_1663(Microsoft.CodeAnalysis.MetadataImageReference
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 1650, 1663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImageReference
                f_430_1503_1691(Microsoft.CodeAnalysis.Metadata
                metadata, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider
                documentation, string?
                filePath, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataImageReference(metadata, properties, documentation, filePath, display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 1503, 1691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(430, 1366, 1703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(430, 1366, 1703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(430, 1770, 1980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 1806, 1965);

                    return _display ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(430, 1813, 1964) ?? f_430_1825_1833() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(430, 1825, 1964) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(430, 1838, 1883) || ((f_430_1838_1848().Kind == MetadataImageKind.Assembly && DynAbs.Tracing.TraceSender.Conditional_F2(430, 1886, 1924)) || DynAbs.Tracing.TraceSender.Conditional_F3(430, 1927, 1963))) ? f_430_1886_1924() : f_430_1927_1963())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(430, 1770, 1980);

                    string?
                    f_430_1825_1833()
                    {
                        var return_v = FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 1825, 1833);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MetadataReferenceProperties
                    f_430_1838_1848()
                    {
                        var return_v = Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 1838, 1848);
                        return return_v;
                    }


                    string
                    f_430_1886_1924()
                    {
                        var return_v = CodeAnalysisResources.InMemoryAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 1886, 1924);
                        return return_v;
                    }


                    string
                    f_430_1927_1963()
                    {
                        var return_v = CodeAnalysisResources.InMemoryModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 1927, 1963);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(430, 1715, 1991);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(430, 1715, 1991);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(430, 2003, 2925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2063, 2092);

                var
                sb = f_430_2072_2091()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2106, 2185);

                f_430_2106_2184(sb, (DynAbs.Tracing.TraceSender.Conditional_F1(430, 2116, 2159) || ((f_430_2116_2126().Kind == MetadataImageKind.Module && DynAbs.Tracing.TraceSender.Conditional_F2(430, 2162, 2170)) || DynAbs.Tracing.TraceSender.Conditional_F3(430, 2173, 2183))) ? "Module" : "Assembly");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2199, 2403) || true) && (f_430_2203_2230_M(!f_430_2204_2214().Aliases.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(430, 2199, 2403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2264, 2288);

                    f_430_2264_2287(sb, " Aliases={");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2306, 2355);

                    f_430_2306_2354(sb, f_430_2316_2353(", ", f_430_2334_2344().Aliases));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2373, 2388);

                    f_430_2373_2387(sb, "}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(430, 2199, 2403);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2419, 2520) || true) && (f_430_2423_2433().EmbedInteropTypes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(430, 2419, 2520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2485, 2505);

                    f_430_2485_2504(sb, " Embed");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(430, 2419, 2520);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2536, 2697) || true) && (f_430_2540_2548() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(430, 2536, 2697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2590, 2611);

                    f_430_2590_2610(sb, " Path='");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2629, 2649);

                    f_430_2629_2648(sb, f_430_2639_2647());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2667, 2682);

                    f_430_2667_2681(sb, "'");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(430, 2536, 2697);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2713, 2877) || true) && (_display != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(430, 2713, 2877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2767, 2791);

                    f_430_2767_2790(sb, " Display='");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2809, 2829);

                    f_430_2809_2828(sb, _display);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2847, 2862);

                    f_430_2847_2861(sb, "'");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(430, 2713, 2877);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(430, 2893, 2914);

                return f_430_2900_2913(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(430, 2003, 2925);

                System.Text.StringBuilder
                f_430_2072_2091()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2072, 2091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_430_2116_2126()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 2116, 2126);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2106_2184(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2106, 2184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_430_2204_2214()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 2204, 2214);
                    return return_v;
                }


                bool
                f_430_2203_2230_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 2203, 2230);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2264_2287(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2264, 2287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_430_2334_2344()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 2334, 2344);
                    return return_v;
                }


                string
                f_430_2316_2353(string
                separator, System.Collections.Immutable.ImmutableArray<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2316, 2353);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2306_2354(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2306, 2354);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2373_2387(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2373, 2387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_430_2423_2433()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 2423, 2433);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2485_2504(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2485, 2504);
                    return return_v;
                }


                string?
                f_430_2540_2548()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 2540, 2548);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2590_2610(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2590, 2610);
                    return return_v;
                }


                string
                f_430_2639_2647()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 2639, 2647);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2629_2648(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2629, 2648);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2667_2681(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2667, 2681);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2767_2790(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2767, 2790);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2809_2828(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2809, 2828);
                    return return_v;
                }


                System.Text.StringBuilder
                f_430_2847_2861(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2847, 2861);
                    return return_v;
                }


                string
                f_430_2900_2913(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(430, 2900, 2913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(430, 2003, 2925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(430, 2003, 2925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MetadataImageReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(430, 437, 2932);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(430, 437, 2932);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(430, 437, 2932);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(430, 437, 2932);

        static Microsoft.CodeAnalysis.DocumentationProvider
        f_430_896_925()
        {
            var return_v = DocumentationProvider.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(430, 896, 925);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReferenceProperties
        f_430_857_867_C(Microsoft.CodeAnalysis.MetadataReferenceProperties
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(430, 673, 1016);
            return return_v;
        }

    }
}
