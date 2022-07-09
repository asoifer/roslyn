// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public sealed class AnalyzerFileReference : AnalyzerReference, IEquatable<AnalyzerReference>
    {
        private delegate IEnumerable<string> AttributeLanguagesFunc(PEModule module, CustomAttributeHandle attribute);

        public override string FullPath { get; }

        private readonly IAnalyzerAssemblyLoader _assemblyLoader;

        private readonly Extensions<DiagnosticAnalyzer> _diagnosticAnalyzers;

        private readonly Extensions<ISourceGenerator> _generators;

        private string? _lazyDisplay;

        private object? _lazyIdentity;

        private Assembly? _lazyAssembly;

        public event EventHandler<AnalyzerLoadFailureEventArgs>?
AnalyzerLoadFailed
;

        public AnalyzerFileReference(string fullPath, IAnalyzerAssemblyLoader assemblyLoader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(232, 2261, 3091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 1392, 1432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 1485, 1500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 1559, 1579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 1636, 1647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 1676, 1688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 1715, 1728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 1757, 1770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 2371, 2441);

                f_232_2371_2440(fullPath, nameof(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 2457, 2477);

                FullPath = fullPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 2491, 2583);

                _assemblyLoader = assemblyLoader ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader>(232, 2509, 2582) ?? throw f_232_2533_2582(nameof(assemblyLoader)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 2599, 2736);

                _diagnosticAnalyzers = f_232_2622_2735(this, typeof(DiagnosticAnalyzerAttribute), GetDiagnosticsAnalyzerSupportedLanguages, allowNetFramework: true);

                static Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
f_232_2622_2735(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
reference, System.Type
attributeType, Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.AttributeLanguagesFunc
languagesFunc, bool
allowNetFramework)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>(reference, attributeType, languagesFunc, allowNetFramework: allowNetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 2622, 2735);
                    return return_v;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 2750, 2860);

                _generators = f_232_2764_2859(this, typeof(GeneratorAttribute), GetGeneratorSupportedLanguages, allowNetFramework: false);
                static Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.ISourceGenerator>
f_232_2764_2859(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
reference, System.Type
attributeType, Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.AttributeLanguagesFunc
languagesFunc, bool
allowNetFramework)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.ISourceGenerator>(reference, attributeType, languagesFunc, allowNetFramework: allowNetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 2764, 2859);
                    return return_v;
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3033, 3080);

                f_232_3033_3079(
                            // Note this analyzer full path as a dependency location, so that the analyzer loader
                            // can correctly load analyzer dependencies.
                            assemblyLoader, fullPath);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(232, 2261, 3091);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 2261, 3091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 2261, 3091);
            }
        }

        public IAnalyzerAssemblyLoader AssemblyLoader
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 3149, 3167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3152, 3167);
                    return _assemblyLoader; DynAbs.Tracing.TraceSender.TraceExitMethod(232, 3149, 3167);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 3149, 3167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 3149, 3167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 3234, 3273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3237, 3273);
                return f_232_3237_3273(this, obj as AnalyzerFileReference); DynAbs.Tracing.TraceSender.TraceExitMethod(232, 3234, 3273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 3234, 3273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 3234, 3273);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_232_3237_3273(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
            this_param, object?
            other)
            {
                var return_v = this_param.Equals((Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference?)other);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 3237, 3273);
                return return_v;
            }

        }

        public bool Equals(AnalyzerFileReference? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 3286, 3625);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3359, 3452) || true) && (f_232_3363_3391(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 3359, 3452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3425, 3437);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 3359, 3452);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3468, 3614);

                return other is object && (DynAbs.Tracing.TraceSender.Expression_True(232, 3475, 3566) && f_232_3511_3566(_assemblyLoader, other._assemblyLoader)) && (DynAbs.Tracing.TraceSender.Expression_True(232, 3475, 3613) && f_232_3587_3595() == f_232_3599_3613(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 3286, 3625);

                bool
                f_232_3363_3391(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                objA, Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 3363, 3391);
                    return return_v;
                }


                bool
                f_232_3511_3566(Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
                objA, Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 3511, 3566);
                    return return_v;
                }


                string
                f_232_3587_3595()
                {
                    var return_v = FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 3587, 3595);
                    return return_v;
                }


                string
                f_232_3599_3613(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                this_param)
                {
                    var return_v = this_param.FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 3599, 3613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 3286, 3625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 3286, 3625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(AnalyzerReference? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 3679, 4139);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3748, 3841) || true) && (f_232_3752_3780(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 3748, 3841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3814, 3826);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 3748, 3841);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3857, 3936) || true) && (other is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 3857, 3936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3908, 3921);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 3857, 3936);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 3952, 4078) || true) && (other is AnalyzerFileReference fileReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 3952, 4078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 4034, 4063);

                    return f_232_4041_4062(this, fileReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 3952, 4078);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 4094, 4128);

                return f_232_4101_4109() == f_232_4113_4127(other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 3679, 4139);

                bool
                f_232_3752_3780(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                objA, Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 3752, 3780);
                    return return_v;
                }


                bool
                f_232_4041_4062(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 4041, 4062);
                    return return_v;
                }


                string
                f_232_4101_4109()
                {
                    var return_v = FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 4101, 4109);
                    return return_v;
                }


                string?
                f_232_4113_4127(Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference
                this_param)
                {
                    var return_v = this_param.FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 4113, 4127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 3679, 4139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 3679, 4139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 4198, 4282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 4201, 4282);
                return f_232_4201_4282(f_232_4214_4257(_assemblyLoader), f_232_4259_4281(f_232_4259_4267())); DynAbs.Tracing.TraceSender.TraceExitMethod(232, 4198, 4282);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 4198, 4282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 4198, 4282);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_232_4214_4257(Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
            o)
            {
                var return_v = RuntimeHelpers.GetHashCode((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 4214, 4257);
                return return_v;
            }


            string
            f_232_4259_4267()
            {
                var return_v = FullPath;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 4259, 4267);
                return return_v;
            }


            int
            f_232_4259_4281(string
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 4259, 4281);
                return return_v;
            }


            int
            f_232_4201_4282(int
            newKey, int
            currentKey)
            {
                var return_v = Hash.Combine(newKey, currentKey);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 4201, 4282);
                return return_v;
            }

        }

        public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzersForAllLanguages()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 4295, 4657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 4564, 4646);

                return f_232_4571_4645(_diagnosticAnalyzers, includeDuplicates: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 4295, 4657);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_232_4571_4645(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, bool
                includeDuplicates)
                {
                    var return_v = this_param.GetExtensionsForAllLanguages(includeDuplicates: includeDuplicates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 4571, 4645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 4295, 4657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 4295, 4657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzers(string language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 4669, 4837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 4774, 4826);

                return f_232_4781_4825(_diagnosticAnalyzers, language);
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 4669, 4837);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_232_4781_4825(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, string
                language)
                {
                    var return_v = this_param.GetExtensions(language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 4781, 4825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 4669, 4837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 4669, 4837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<ISourceGenerator> GetGeneratorsForAllLanguages()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 4849, 5038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 4953, 5027);

                return f_232_4960_5026(_generators, includeDuplicates: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 4849, 5038);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                f_232_4960_5026(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.ISourceGenerator>
                this_param, bool
                includeDuplicates)
                {
                    var return_v = this_param.GetExtensionsForAllLanguages(includeDuplicates: includeDuplicates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 4960, 5026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 4849, 5038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 4849, 5038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Use GetGenerators(string language) or GetGeneratorsForAllLanguages()")]
        public override ImmutableArray<ISourceGenerator> GetGenerators()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 5050, 5297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 5231, 5286);

                return f_232_5238_5285(_generators, LanguageNames.CSharp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 5050, 5297);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                f_232_5238_5285(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.ISourceGenerator>
                this_param, string
                language)
                {
                    var return_v = this_param.GetExtensions(language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 5238, 5285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 5050, 5297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 5050, 5297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<ISourceGenerator> GetGenerators(string language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 5309, 5467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 5413, 5456);

                return f_232_5420_5455(_generators, language);
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 5309, 5467);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                f_232_5420_5455(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.ISourceGenerator>
                this_param, string
                language)
                {
                    var return_v = this_param.GetExtensions(language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 5420, 5455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 5309, 5467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 5309, 5467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 5534, 5735);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 5570, 5680) || true) && (_lazyDisplay == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 5570, 5680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 5636, 5661);

                        f_232_5636_5660(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 5570, 5680);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 5700, 5720);

                    return _lazyDisplay;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(232, 5534, 5735);

                    int
                    f_232_5636_5660(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                    this_param)
                    {
                        this_param.InitializeDisplayAndId();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 5636, 5660);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 5479, 5746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 5479, 5746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 5808, 6011);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 5844, 5955) || true) && (_lazyIdentity == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 5844, 5955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 5911, 5936);

                        f_232_5911_5935(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 5844, 5955);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 5975, 5996);

                    return _lazyIdentity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(232, 5808, 6011);

                    int
                    f_232_5911_5935(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                    this_param)
                    {
                        this_param.InitializeDisplayAndId();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 5911, 5935);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 5758, 6022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 5758, 6022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [MemberNotNull(nameof(_lazyIdentity), nameof(_lazyDisplay))]
        private void InitializeDisplayAndId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 6034, 6904);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 6358, 6424);

                    using var
                    reader = f_232_6377_6423(f_232_6390_6422(f_232_6413_6421()))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 6444, 6492);

                    var
                    metadataReader = f_232_6465_6491(reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 6510, 6578);

                    var
                    assemblyIdentity = f_232_6533_6577(metadataReader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 6596, 6633);

                    _lazyDisplay = f_232_6611_6632(assemblyIdentity);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 6651, 6684);

                    _lazyIdentity = assemblyIdentity;
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(232, 6713, 6893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 6751, 6831);

                    _lazyDisplay = f_232_6766_6830(f_232_6796_6804(), includeExtension: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 6849, 6878);

                    _lazyIdentity = _lazyDisplay;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(232, 6713, 6893);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 6034, 6904);

                string
                f_232_6413_6421()
                {
                    var return_v = FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 6413, 6421);
                    return return_v;
                }


                System.IO.Stream
                f_232_6390_6422(string
                fullPath)
                {
                    var return_v = FileUtilities.OpenRead(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 6390, 6422);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_232_6377_6423(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 6377, 6423);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_232_6465_6491(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 6465, 6491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_232_6533_6577(System.Reflection.Metadata.MetadataReader
                reader)
                {
                    var return_v = reader.ReadAssemblyIdentityOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 6533, 6577);
                    return return_v;
                }


                string
                f_232_6611_6632(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 6611, 6632);
                    return return_v;
                }


                string
                f_232_6796_6804()
                {
                    var return_v = FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 6796, 6804);
                    return return_v;
                }


                string?
                f_232_6766_6830(string
                path, bool
                includeExtension)
                {
                    var return_v = FileNameUtilities.GetFileName(path, includeExtension: includeExtension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 6766, 6830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 6034, 6904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 6034, 6904);
            }
        }

        internal void AddAnalyzers(ImmutableArray<DiagnosticAnalyzer>.Builder builder, string language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 7126, 7311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 7246, 7300);

                f_232_7246_7299(_diagnosticAnalyzers, builder, language);
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 7126, 7311);

                int
                f_232_7246_7299(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                builder, string
                language)
                {
                    this_param.AddExtensions(builder, language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 7246, 7299);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 7126, 7311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 7126, 7311);
            }
        }

        internal void AddGenerators(ImmutableArray<ISourceGenerator>.Builder builder, string language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 7531, 7706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 7650, 7695);

                f_232_7650_7694(_generators, builder, language);
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 7531, 7706);

                int
                f_232_7650_7694(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.ISourceGenerator>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>.Builder
                builder, string
                language)
                {
                    this_param.AddExtensions(builder, language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 7650, 7694);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 7531, 7706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 7531, 7706);
            }
        }

        private static AnalyzerLoadFailureEventArgs CreateAnalyzerFailedArgs(Exception e, string? typeName = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(232, 7718, 8385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 7873, 7915);

                e = (e as TargetInvocationException) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Reflection.TargetInvocationException?>(232, 7877, 7914) ?? e);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 7997, 8060);

                string
                message = f_232_8014_8059(f_232_8014_8041(f_232_8014_8023(e), "\r", ""), "\n", "")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 8076, 8285);

                var
                errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(232, 8092, 8110) || (((typeName != null) && DynAbs.Tracing.TraceSender.Conditional_F2(232, 8130, 8198)) || DynAbs.Tracing.TraceSender.Conditional_F3(232, 8218, 8284))) ? AnalyzerLoadFailureEventArgs.FailureErrorCode.UnableToCreateAnalyzer : AnalyzerLoadFailureEventArgs.FailureErrorCode.UnableToLoadAnalyzer
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 8301, 8374);

                return f_232_8308_8373(errorCode, message, e, typeName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(232, 7718, 8385);

                string
                f_232_8014_8023(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 8014, 8023);
                    return return_v;
                }


                string
                f_232_8014_8041(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 8014, 8041);
                    return return_v;
                }


                string
                f_232_8014_8059(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 8014, 8059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs
                f_232_8308_8373(Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs.FailureErrorCode
                errorCode, string
                message, System.Exception
                exceptionOpt, string?
                typeNameOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs(errorCode, message, exceptionOpt, typeNameOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 8308, 8373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 7718, 8385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 7718, 8385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableDictionary<string, ImmutableHashSet<string>> GetAnalyzerTypeNameMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 8397, 8574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 8509, 8563);

                return f_232_8516_8562(_diagnosticAnalyzers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 8397, 8574);

                System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                f_232_8516_8562(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    var return_v = this_param.GetExtensionTypeNameMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 8516, 8562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 8397, 8574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 8397, 8574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/30449")]
        private static ImmutableDictionary<string, ImmutableHashSet<string>> GetAnalyzerTypeNameMap(string fullPath, Type attributeType, AttributeLanguagesFunc languagesFunc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(232, 8932, 10351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 9204, 9267);

                using var
                assembly = f_232_9225_9266(fullPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 9563, 10242);

                var
                typeNameMap = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from module in assembly.GetModules()
                                                                                      from typeDefHandle in module.MetadataReader.TypeDefinitions
                                                                                      let typeDef = module.MetadataReader.GetTypeDefinition(typeDefHandle)
                                                                                      let supportedLanguages = GetSupportedLanguages(typeDef, module.Module, attributeType, languagesFunc)
                                                                                      where supportedLanguages.Any()
                                                                                      let typeName = GetFullyQualifiedTypeName(typeDef, module.Module)
                                                                                      from supportedLanguage in supportedLanguages
                                                                                      group typeName by supportedLanguage, 232, 9581, 10241)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 10258, 10340);

                return f_232_10265_10339(typeNameMap, g => g.Key, g => g.ToImmutableHashSet());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(232, 8932, 10351);

                Microsoft.CodeAnalysis.AssemblyMetadata
                f_232_9225_9266(string
                path)
                {
                    var return_v = AssemblyMetadata.CreateFromFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 9225, 9266);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                f_232_10265_10339(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, string>>
                source, System.Func<System.Linq.IGrouping<string, string>, string>
                keySelector, System.Func<System.Linq.IGrouping<string, string>, System.Collections.Immutable.ImmutableHashSet<string>>
                elementSelector)
                {
                    var return_v = source.ToImmutableDictionary<System.Linq.IGrouping<string, string>, string, System.Collections.Immutable.ImmutableHashSet<string>>(keySelector, elementSelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 10265, 10339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 8932, 10351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 8932, 10351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<string> GetSupportedLanguages(TypeDefinition typeDef, PEModule peModule, Type attributeType, AttributeLanguagesFunc languagesFunc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(232, 10363, 11234);

                var listYield = new List<String>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 10545, 11223);
                    foreach (CustomAttributeHandle customAttrHandle in f_232_10596_10625_I(typeDef.GetCustomAttributes()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 10545, 11223);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 10659, 11208) || true) && (f_232_10663_10766(peModule, customAttrHandle, attributeType.Namespace!, f_232_10734_10752(attributeType), ctor: out _))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 10659, 11208);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 10808, 10901);

                            IEnumerable<string>?
                            attributeSupportedLanguages = f_232_10859_10900(languagesFunc, peModule, customAttrHandle)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 10923, 11189) || true) && (attributeSupportedLanguages != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 10923, 11189);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 11012, 11166);
                                    foreach (string item in f_232_11036_11063_I(attributeSupportedLanguages))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 11012, 11166);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 11121, 11139);

                                        listYield.Add(item);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 11012, 11166);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(232, 1, 155);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(232, 1, 155);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(232, 10923, 11189);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(232, 10659, 11208);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 10545, 11223);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(232, 1, 679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(232, 1, 679);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(232, 10363, 11234);

                return listYield;

                string
                f_232_10734_10752(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 10734, 10752);
                    return return_v;
                }


                bool
                f_232_10663_10766(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, string
                namespaceName, string
                typeName, out System.Reflection.Metadata.EntityHandle
                ctor)
                {
                    var return_v = this_param.IsTargetAttribute(customAttribute, namespaceName, typeName, out ctor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 10663, 10766);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_232_10859_10900(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.AttributeLanguagesFunc
                this_param, Microsoft.CodeAnalysis.PEModule
                module, System.Reflection.Metadata.CustomAttributeHandle
                attribute)
                {
                    var return_v = this_param.Invoke(module, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 10859, 10900);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_232_11036_11063_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 11036, 11063);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_232_10596_10625_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 10596, 10625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 10363, 11234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 10363, 11234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<string> GetDiagnosticsAnalyzerSupportedLanguages(PEModule peModule, CustomAttributeHandle customAttrHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(232, 11246, 11867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 11677, 11792);

                BlobReader
                argsReader = f_232_11701_11791(peModule, f_232_11733_11790(peModule, customAttrHandle))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 11806, 11856);

                return f_232_11813_11855(ref argsReader);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(232, 11246, 11867);

                System.Reflection.Metadata.BlobHandle
                f_232_11733_11790(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributeValueOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 11733, 11790);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_232_11701_11791(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.BlobHandle
                blob)
                {
                    var return_v = this_param.GetMemoryReaderOrThrow(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 11701, 11791);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_232_11813_11855(ref System.Reflection.Metadata.BlobReader
                argsReader)
                {
                    var return_v = ReadLanguagesFromAttribute(ref argsReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 11813, 11855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 11246, 11867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 11246, 11867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<string> GetGeneratorSupportedLanguages(PEModule peModule, CustomAttributeHandle customAttrHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(232, 11879, 12727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 12242, 12357);

                BlobReader
                argsReader = f_232_12266_12356(peModule, f_232_12298_12355(peModule, customAttrHandle))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 12371, 12716) || true) && (argsReader.Length == 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 12371, 12716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 12464, 12515);

                    return f_232_12471_12514(LanguageNames.CSharp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 12371, 12716);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 12371, 12716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 12651, 12701);

                    return f_232_12658_12700(ref argsReader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 12371, 12716);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(232, 11879, 12727);

                System.Reflection.Metadata.BlobHandle
                f_232_12298_12355(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributeValueOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 12298, 12355);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_232_12266_12356(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.BlobHandle
                blob)
                {
                    var return_v = this_param.GetMemoryReaderOrThrow(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 12266, 12356);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_232_12471_12514(string
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 12471, 12514);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_232_12658_12700(ref System.Reflection.Metadata.BlobReader
                argsReader)
                {
                    var return_v = ReadLanguagesFromAttribute(ref argsReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 12658, 12700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 11879, 12727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 11879, 12727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<string> ReadLanguagesFromAttribute(ref BlobReader argsReader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(232, 12739, 13980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 12852, 13899) || true) && (argsReader.Length > 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 12852, 13899);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 12970, 13884) || true) && (argsReader.ReadByte() == 1 && (DynAbs.Tracing.TraceSender.Expression_True(232, 12974, 13030) && argsReader.ReadByte() == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 12970, 13884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 13072, 13097);

                        string
                        firstLanguageName
                        = default(string);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 13119, 13328) || true) && (!f_232_13124_13199(out firstLanguageName, ref argsReader))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 13119, 13328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 13249, 13305);

                            return f_232_13256_13304();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(232, 13119, 13328);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 13352, 13399);

                        ImmutableArray<string>
                        additionalLanguageNames
                        = default(ImmutableArray<string>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 13421, 13865) || true) && (f_232_13425_13511(out additionalLanguageNames, ref argsReader))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 13421, 13865);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 13561, 13754) || true) && (additionalLanguageNames.Length == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 13561, 13754);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 13658, 13727);

                                return f_232_13665_13726(firstLanguageName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(232, 13561, 13754);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 13782, 13842);

                            return additionalLanguageNames.Insert(0, firstLanguageName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(232, 13421, 13865);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 12970, 13884);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 12852, 13899);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 13913, 13969);

                return f_232_13920_13968();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(232, 12739, 13980);

                bool
                f_232_13124_13199(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = PEModule.CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 13124, 13199);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_232_13256_13304()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 13256, 13304);
                    return return_v;
                }


                bool
                f_232_13425_13511(out System.Collections.Immutable.ImmutableArray<string>
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = PEModule.CrackStringArrayInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 13425, 13511);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_232_13665_13726(string
                value)
                {
                    var return_v = SpecializedCollections.SingletonEnumerable(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 13665, 13726);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_232_13920_13968()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 13920, 13968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 12739, 13980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 12739, 13980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetFullyQualifiedTypeName(TypeDefinition typeDef, PEModule peModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(232, 13994, 14663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 14109, 14156);

                var
                declaringType = typeDef.GetDeclaringType()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 14231, 14652) || true) && (declaringType.IsNil)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 14231, 14652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 14288, 14356);

                    return f_232_14295_14355(peModule, typeDef.Namespace, typeDef.Name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 14231, 14652);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 14231, 14652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 14422, 14502);

                    var
                    declaringTypeDef = f_232_14445_14501(f_232_14445_14468(peModule), declaringType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 14520, 14637);

                    return f_232_14527_14580(declaringTypeDef, peModule) + "+" + f_232_14589_14636(f_232_14589_14612(peModule), typeDef.Name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 14231, 14652);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(232, 13994, 14663);

                string
                f_232_14295_14355(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.StringHandle
                namespaceHandle, System.Reflection.Metadata.StringHandle
                nameHandle)
                {
                    var return_v = this_param.GetFullNameOrThrow(namespaceHandle, nameHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 14295, 14355);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_232_14445_14468(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 14445, 14468);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_232_14445_14501(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 14445, 14501);
                    return return_v;
                }


                string
                f_232_14527_14580(System.Reflection.Metadata.TypeDefinition
                typeDef, Microsoft.CodeAnalysis.PEModule
                peModule)
                {
                    var return_v = GetFullyQualifiedTypeName(typeDef, peModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 14527, 14580);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_232_14589_14612(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 14589, 14612);
                    return return_v;
                }


                string
                f_232_14589_14636(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 14589, 14636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 13994, 14663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 13994, 14663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class Extensions<TExtension>
                    where TExtension : class
        {
            private readonly AnalyzerFileReference _reference;

            private readonly Type _attributeType;

            private readonly AttributeLanguagesFunc _languagesFunc;

            private readonly bool _allowNetFramework;

            private ImmutableArray<TExtension> _lazyAllExtensions;

            private ImmutableDictionary<string, ImmutableArray<TExtension>> _lazyExtensionsPerLanguage;

            private ImmutableDictionary<string, ImmutableHashSet<string>>? _lazyExtensionTypeNameMap;

            internal Extensions(AnalyzerFileReference reference, Type attributeType, AttributeLanguagesFunc languagesFunc, bool allowNetFramework)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(232, 15298, 15814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 14820, 14830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 14867, 14881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 14936, 14950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 14987, 15005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 15152, 15178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 15256, 15281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 15465, 15488);

                    _reference = reference;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 15506, 15537);

                    _attributeType = attributeType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 15555, 15586);

                    _languagesFunc = languagesFunc;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 15604, 15643);

                    _allowNetFramework = allowNetFramework;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 15661, 15690);

                    _lazyAllExtensions = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 15708, 15799);

                    _lazyExtensionsPerLanguage = ImmutableDictionary<string, ImmutableArray<TExtension>>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(232, 15298, 15814);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 15298, 15814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 15298, 15814);
                }
            }

            internal ImmutableArray<TExtension> GetExtensionsForAllLanguages(bool includeDuplicates)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 15830, 16230);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 15951, 16169) || true) && (_lazyAllExtensions.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 15951, 16169);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 16025, 16150);

                        f_232_16025_16149(ref _lazyAllExtensions, f_232_16092_16148(this, includeDuplicates));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 15951, 16169);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 16189, 16215);

                    return _lazyAllExtensions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(232, 15830, 16230);

                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_16092_16148(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>
                    extensions, bool
                    includeDuplicates)
                    {
                        var return_v = CreateExtensionsForAllLanguages(extensions, includeDuplicates);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 16092, 16148);
                        return return_v;
                    }


                    bool
                    f_232_16025_16149(ref System.Collections.Immutable.ImmutableArray<TExtension>
                    location, System.Collections.Immutable.ImmutableArray<TExtension>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 16025, 16149);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 15830, 16230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 15830, 16230);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static ImmutableArray<TExtension> CreateExtensionsForAllLanguages(Extensions<TExtension> extensions, bool includeDuplicates)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(232, 16246, 17214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 16466, 16548);

                    var
                    map = f_232_16476_16547()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 16566, 16596);

                    f_232_16566_16595(extensions, map);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 16616, 16673);

                    var
                    builder = f_232_16630_16672()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 16691, 16917);
                        foreach (var analyzers in f_232_16717_16727_I(f_232_16717_16727(map)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 16691, 16917);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 16769, 16898);
                                foreach (var analyzer in f_232_16794_16803_I(analyzers))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 16769, 16898);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 16853, 16875);

                                    f_232_16853_16874(builder, analyzer);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 16769, 16898);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(232, 1, 130);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(232, 1, 130);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(232, 16691, 16917);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(232, 1, 227);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(232, 1, 227);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 16937, 17199) || true) && (includeDuplicates)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 16937, 17199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 17000, 17029);

                        return f_232_17007_17028(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 16937, 17199);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 16937, 17199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 17111, 17180);

                        return f_232_17118_17179(f_232_17118_17160(builder, ExtTypeComparer.Instance));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 16937, 17199);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(232, 16246, 17214);

                    System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<TExtension>>.Builder
                    f_232_16476_16547()
                    {
                        var return_v = ImmutableDictionary.CreateBuilder<string, ImmutableArray<TExtension>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 16476, 16547);
                        return return_v;
                    }


                    int
                    f_232_16566_16595(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>
                    this_param, System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<TExtension>>.Builder
                    builder)
                    {
                        this_param.AddExtensions(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 16566, 16595);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    f_232_16630_16672()
                    {
                        var return_v = ImmutableArray.CreateBuilder<TExtension>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 16630, 16672);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<TExtension>>
                    f_232_16717_16727(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<TExtension>>.Builder
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 16717, 16727);
                        return return_v;
                    }


                    int
                    f_232_16853_16874(System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    this_param, TExtension
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 16853, 16874);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_16794_16803_I(System.Collections.Immutable.ImmutableArray<TExtension>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 16794, 16803);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<TExtension>>
                    f_232_16717_16727_I(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<TExtension>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 16717, 16727);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_17007_17028(System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17007, 17028);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TExtension>
                    f_232_17118_17160(System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    source, Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>.ExtTypeComparer
                    comparer)
                    {
                        var return_v = source.Distinct<TExtension>((System.Collections.Generic.IEqualityComparer<TExtension>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17118, 17160);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_17118_17179(System.Collections.Generic.IEnumerable<TExtension>
                    items)
                    {
                        var return_v = items.ToImmutableArray<TExtension>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17118, 17179);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 16246, 17214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 16246, 17214);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private class ExtTypeComparer : IEqualityComparer<TExtension>
            {
                public static readonly ExtTypeComparer Instance;

                public bool Equals(TExtension? x, TExtension? y)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 17449, 17493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 17452, 17493);
                        return f_232_17452_17493(f_232_17466_17478_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(x, 232, 17466, 17478)?.GetType()), f_232_17480_17492_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(y, 232, 17480, 17492)?.GetType())); DynAbs.Tracing.TraceSender.TraceExitMethod(232, 17449, 17493);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 17449, 17493);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 17449, 17493);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    System.Type?
                    f_232_17466_17478_I(System.Type?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17466, 17478);
                        return return_v;
                    }


                    System.Type?
                    f_232_17480_17492_I(System.Type?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17480, 17492);
                        return return_v;
                    }


                    bool
                    f_232_17452_17493(System.Type?
                    objA, System.Type?
                    objB)
                    {
                        var return_v = object.Equals((object?)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17452, 17493);
                        return return_v;
                    }

                }

                public int GetHashCode(TExtension obj)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 17553, 17583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 17556, 17583);
                        return f_232_17556_17583(f_232_17556_17569(obj)); DynAbs.Tracing.TraceSender.TraceExitMethod(232, 17553, 17583);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 17553, 17583);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 17553, 17583);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    System.Type
                    f_232_17556_17569(TExtension
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17556, 17569);
                        return return_v;
                    }


                    int
                    f_232_17556_17583(System.Type
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17556, 17583);
                        return return_v;
                    }

                }

                public ExtTypeComparer()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(232, 17230, 17599);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(232, 17230, 17599);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 17230, 17599);
                }


                static ExtTypeComparer()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(232, 17230, 17599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 17363, 17379);
                    Instance = f_232_17374_17379();

                    static Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>.ExtTypeComparer
f_232_17374_17379()
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>.ExtTypeComparer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17374, 17379);
                        return return_v;
                    }

                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(232, 17230, 17599);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 17230, 17599);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(232, 17230, 17599);
            }

            internal ImmutableArray<TExtension> GetExtensions(string language)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 17615, 18003);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 17714, 17849) || true) && (f_232_17718_17748(language))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 17714, 17849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 17790, 17830);

                        throw f_232_17796_17829("language");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 17714, 17849);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 17869, 17988);

                    return f_232_17876_17987(ref _lazyExtensionsPerLanguage, language, CreateLanguageSpecificExtensions, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(232, 17615, 18003);

                    bool
                    f_232_17718_17748(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17718, 17748);
                        return return_v;
                    }


                    System.ArgumentException
                    f_232_17796_17829(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17796, 17829);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_17876_17987(ref System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<TExtension>>
                    location, string
                    key, System.Func<string, Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>, System.Collections.Immutable.ImmutableArray<TExtension>>
                    valueFactory, Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>
                    factoryArgument)
                    {
                        var return_v = ImmutableInterlocked.GetOrAdd(ref location, key, valueFactory, factoryArgument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 17876, 17987);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 17615, 18003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 17615, 18003);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static ImmutableArray<TExtension> CreateLanguageSpecificExtensions(string language, Extensions<TExtension> extensions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(232, 18019, 18437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 18256, 18313);

                    var
                    builder = f_232_18270_18312()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 18331, 18375);

                    f_232_18331_18374(extensions, builder, language);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 18393, 18422);

                    return f_232_18400_18421(builder);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(232, 18019, 18437);

                    System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    f_232_18270_18312()
                    {
                        var return_v = ImmutableArray.CreateBuilder<TExtension>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 18270, 18312);
                        return return_v;
                    }


                    int
                    f_232_18331_18374(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>
                    this_param, System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    builder, string
                    language)
                    {
                        this_param.AddExtensions(builder, language);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 18331, 18374);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_18400_18421(System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 18400, 18421);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 18019, 18437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 18019, 18437);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ImmutableDictionary<string, ImmutableHashSet<string>> GetExtensionTypeNameMap()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 18453, 18950);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 18574, 18882) || true) && (_lazyExtensionTypeNameMap == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 18574, 18882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 18653, 18755);

                        var
                        analyzerTypeNameMap = f_232_18679_18754(f_232_18702_18721(_reference), _attributeType, _languagesFunc)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 18777, 18863);

                        f_232_18777_18862(ref _lazyExtensionTypeNameMap, analyzerTypeNameMap, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 18574, 18882);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 18902, 18935);

                    return _lazyExtensionTypeNameMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(232, 18453, 18950);

                    string
                    f_232_18702_18721(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                    this_param)
                    {
                        var return_v = this_param.FullPath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 18702, 18721);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    f_232_18679_18754(string
                    fullPath, System.Type
                    attributeType, Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.AttributeLanguagesFunc
                    languagesFunc)
                    {
                        var return_v = GetAnalyzerTypeNameMap(fullPath, attributeType, languagesFunc);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 18679, 18754);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>?
                    f_232_18777_18862(ref System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>?
                    location1, System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    value, System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 18777, 18862);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 18453, 18950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 18453, 18950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void AddExtensions(ImmutableDictionary<string, ImmutableArray<TExtension>>.Builder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 18966, 20900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19099, 19173);

                    ImmutableDictionary<string, ImmutableHashSet<string>>
                    analyzerTypeNameMap
                    = default(ImmutableDictionary<string, ImmutableHashSet<string>>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19191, 19217);

                    Assembly
                    analyzerAssembly
                    = default(Assembly);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19281, 19329);

                        analyzerTypeNameMap = f_232_19303_19328(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19351, 19465) || true) && (f_232_19355_19380(analyzerTypeNameMap) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 19351, 19465);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19435, 19442);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(232, 19351, 19465);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19489, 19533);

                        analyzerAssembly = f_232_19508_19532(_reference);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(232, 19570, 19757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19630, 19709);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_reference.AnalyzerLoadFailed, 232, 19630, 19708).Invoke(_reference, f_232_19680_19707(e)), 232, 19660, 19708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19731, 19738);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(232, 19570, 19757);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19777, 19810);

                    var
                    initialCount = f_232_19796_19809(builder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19828, 19854);

                    var
                    reportedError = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 19927, 20331);
                        foreach (var (language, _) in f_232_19957_19976_I(analyzerTypeNameMap))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 19927, 20331);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 20018, 20120) || true) && (language == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 20018, 20120);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 20088, 20097);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(232, 20018, 20120);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 20144, 20257);

                            var
                            analyzers = f_232_20160_20256(this, analyzerAssembly, analyzerTypeNameMap, language, ref reportedError)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 20279, 20312);

                            f_232_20279_20311(builder, language, analyzers);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(232, 19927, 20331);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(232, 1, 405);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(232, 1, 405);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 20590, 20885) || true) && (f_232_20594_20607(builder) == initialCount && (DynAbs.Tracing.TraceSender.Expression_True(232, 20594, 20641) && !reportedError))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 20590, 20885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 20683, 20866);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_reference.AnalyzerLoadFailed, 232, 20683, 20865).Invoke(_reference, f_232_20733_20864(AnalyzerLoadFailureEventArgs.FailureErrorCode.NoAnalyzers, f_232_20825_20863())), 232, 20713, 20865);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 20590, 20885);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(232, 18966, 20900);

                    System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    f_232_19303_19328(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>
                    this_param)
                    {
                        var return_v = this_param.GetExtensionTypeNameMap();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 19303, 19328);
                        return return_v;
                    }


                    int
                    f_232_19355_19380(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 19355, 19380);
                        return return_v;
                    }


                    System.Reflection.Assembly
                    f_232_19508_19532(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                    this_param)
                    {
                        var return_v = this_param.GetAssembly();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 19508, 19532);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs
                    f_232_19680_19707(System.Exception
                    e)
                    {
                        var return_v = CreateAnalyzerFailedArgs(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 19680, 19707);
                        return return_v;
                    }


                    int
                    f_232_19796_19809(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<TExtension>>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 19796, 19809);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_20160_20256(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>
                    this_param, System.Reflection.Assembly
                    analyzerAssembly, System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    analyzerTypeNameMap, string
                    language, ref bool
                    reportedError)
                    {
                        var return_v = this_param.GetLanguageSpecificAnalyzers(analyzerAssembly, analyzerTypeNameMap, language, ref reportedError);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 20160, 20256);
                        return return_v;
                    }


                    int
                    f_232_20279_20311(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<TExtension>>.Builder
                    this_param, string
                    key, System.Collections.Immutable.ImmutableArray<TExtension>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 20279, 20311);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    f_232_19957_19976_I(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 19957, 19976);
                        return return_v;
                    }


                    int
                    f_232_20594_20607(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<TExtension>>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 20594, 20607);
                        return return_v;
                    }


                    string
                    f_232_20825_20863()
                    {
                        var return_v = CodeAnalysisResources.NoAnalyzersFound;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 20825, 20863);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs
                    f_232_20733_20864(Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs.FailureErrorCode
                    errorCode, string
                    message)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs(errorCode, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 20733, 20864);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 18966, 20900);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 18966, 20900);
                }
            }

            internal void AddExtensions(ImmutableArray<TExtension>.Builder builder, string language)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 20916, 22904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21037, 21111);

                    ImmutableDictionary<string, ImmutableHashSet<string>>
                    analyzerTypeNameMap
                    = default(ImmutableDictionary<string, ImmutableHashSet<string>>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21129, 21155);

                    Assembly
                    analyzerAssembly
                    = default(Assembly);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21219, 21267);

                        analyzerTypeNameMap = f_232_21241_21266(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21374, 21500) || true) && (!f_232_21379_21420(analyzerTypeNameMap, language))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 21374, 21500);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21470, 21477);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(232, 21374, 21500);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21524, 21568);

                        analyzerAssembly = f_232_21543_21567(_reference);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21590, 21782) || true) && (analyzerAssembly == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 21590, 21782);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21752, 21759);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(232, 21590, 21782);
                        }
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(232, 21819, 22006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21879, 21958);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_reference.AnalyzerLoadFailed, 232, 21879, 21957).Invoke(_reference, f_232_21929_21956(e)), 232, 21909, 21957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 21980, 21987);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(232, 21819, 22006);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 22026, 22059);

                    var
                    initialCount = f_232_22045_22058(builder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 22077, 22103);

                    var
                    reportedError = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 22176, 22289);

                    var
                    analyzers = f_232_22192_22288(this, analyzerAssembly, analyzerTypeNameMap, language, ref reportedError)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 22307, 22335);

                    f_232_22307_22334(builder, analyzers);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 22594, 22889) || true) && (f_232_22598_22611(builder) == initialCount && (DynAbs.Tracing.TraceSender.Expression_True(232, 22598, 22645) && !reportedError))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 22594, 22889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 22687, 22870);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_reference.AnalyzerLoadFailed, 232, 22687, 22869).Invoke(_reference, f_232_22737_22868(AnalyzerLoadFailureEventArgs.FailureErrorCode.NoAnalyzers, f_232_22829_22867())), 232, 22717, 22869);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 22594, 22889);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(232, 20916, 22904);

                    System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    f_232_21241_21266(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>
                    this_param)
                    {
                        var return_v = this_param.GetExtensionTypeNameMap();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 21241, 21266);
                        return return_v;
                    }


                    bool
                    f_232_21379_21420(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    this_param, string
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 21379, 21420);
                        return return_v;
                    }


                    System.Reflection.Assembly
                    f_232_21543_21567(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference
                    this_param)
                    {
                        var return_v = this_param.GetAssembly();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 21543, 21567);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs
                    f_232_21929_21956(System.Exception
                    e)
                    {
                        var return_v = CreateAnalyzerFailedArgs(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 21929, 21956);
                        return return_v;
                    }


                    int
                    f_232_22045_22058(System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 22045, 22058);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_22192_22288(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>
                    this_param, System.Reflection.Assembly
                    analyzerAssembly, System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    analyzerTypeNameMap, string
                    language, ref bool
                    reportedError)
                    {
                        var return_v = this_param.GetLanguageSpecificAnalyzers(analyzerAssembly, analyzerTypeNameMap, language, ref reportedError);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 22192, 22288);
                        return return_v;
                    }


                    int
                    f_232_22307_22334(System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    this_param, System.Collections.Immutable.ImmutableArray<TExtension>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 22307, 22334);
                        return 0;
                    }


                    int
                    f_232_22598_22611(System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 22598, 22611);
                        return return_v;
                    }


                    string
                    f_232_22829_22867()
                    {
                        var return_v = CodeAnalysisResources.NoAnalyzersFound;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 22829, 22867);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs
                    f_232_22737_22868(Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs.FailureErrorCode
                    errorCode, string
                    message)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs(errorCode, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 22737, 22868);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 20916, 22904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 20916, 22904);
                }
            }

            private ImmutableArray<TExtension> GetLanguageSpecificAnalyzers(Assembly analyzerAssembly, ImmutableDictionary<string, ImmutableHashSet<string>> analyzerTypeNameMap, string language, ref bool reportedError)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 22920, 23565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 23159, 23219);

                    ImmutableHashSet<string>?
                    languageSpecificAnalyzerTypeNames
                    = default(ImmutableHashSet<string>?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 23237, 23423) || true) && (!f_232_23242_23322(analyzerTypeNameMap, language, out languageSpecificAnalyzerTypeNames))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 23237, 23423);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 23364, 23404);

                        return ImmutableArray<TExtension>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(232, 23237, 23423);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 23441, 23550);

                    return f_232_23448_23549(this, analyzerAssembly, languageSpecificAnalyzerTypeNames, ref reportedError);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(232, 22920, 23565);

                    bool
                    f_232_23242_23322(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableHashSet<string>>
                    this_param, string
                    key, out System.Collections.Immutable.ImmutableHashSet<string>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 23242, 23322);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_23448_23549(Microsoft.CodeAnalysis.Diagnostics.AnalyzerFileReference.Extensions<TExtension>
                    this_param, System.Reflection.Assembly
                    analyzerAssembly, System.Collections.Immutable.ImmutableHashSet<string>
                    analyzerTypeNames, ref bool
                    reportedError)
                    {
                        var return_v = this_param.GetAnalyzersForTypeNames(analyzerAssembly, (System.Collections.Generic.IEnumerable<string>)analyzerTypeNames, ref reportedError);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 23448, 23549);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 22920, 23565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 22920, 23565);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<TExtension> GetAnalyzersForTypeNames(Assembly analyzerAssembly, IEnumerable<string> analyzerTypeNames, ref bool reportedError)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 23581, 26264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 23763, 23822);

                    var
                    analyzers = f_232_23779_23821()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 23973, 26198);
                        foreach (var typeName in f_232_23998_24015_I(analyzerTypeNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 23973, 26198);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 24057, 24068);

                            Type?
                            type
                            = default(Type?);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 24142, 24223);

                                type = f_232_24149_24222(analyzerAssembly, typeName, throwOnError: true, ignoreCase: false);
                            }
                            catch (Exception e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(232, 24268, 24530);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 24336, 24425);

                                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_reference.AnalyzerLoadFailed, 232, 24336, 24424).Invoke(_reference, f_232_24386_24423(e, typeName)), 232, 24366, 24424);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 24451, 24472);

                                reportedError = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 24498, 24507);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(232, 24268, 24530);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 24554, 24581);

                            f_232_24554_24580(type != null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 24718, 25556) || true) && (!_allowNetFramework)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 24718, 25556);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 24791, 24886);

                                var
                                targetFrameworkAttribute = f_232_24822_24885(analyzerAssembly)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 24912, 25533) || true) && (targetFrameworkAttribute is object && (DynAbs.Tracing.TraceSender.Expression_True(232, 24916, 25056) && f_232_24954_25056(f_232_24954_24992(targetFrameworkAttribute), ".NETFramework", StringComparison.OrdinalIgnoreCase)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 24912, 25533);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 25114, 25467);

                                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_reference.AnalyzerLoadFailed, 232, 25114, 25466).Invoke(_reference, f_232_25164_25465(AnalyzerLoadFailureEventArgs.FailureErrorCode.ReferencesFramework, f_232_25331_25408(f_232_25345_25397(), typeName), typeNameOpt: typeName)), 232, 25144, 25466);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 25497, 25506);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 24912, 25533);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(232, 24718, 25556);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 25580, 25601);

                            TExtension?
                            analyzer
                            = default(TExtension?);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 25675, 25731);

                                analyzer = f_232_25686_25716(type) as TExtension;
                            }
                            catch (Exception e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(232, 25776, 26038);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 25844, 25933);

                                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_reference.AnalyzerLoadFailed, 232, 25844, 25932).Invoke(_reference, f_232_25894_25931(e, typeName)), 232, 25874, 25932);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 25959, 25980);

                                reportedError = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 26006, 26015);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(232, 25776, 26038);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 26062, 26179) || true) && (analyzer != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 26062, 26179);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 26132, 26156);

                                f_232_26132_26155(analyzers, analyzer);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(232, 26062, 26179);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(232, 23973, 26198);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(232, 1, 2226);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(232, 1, 2226);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 26218, 26249);

                    return f_232_26225_26248(analyzers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(232, 23581, 26264);

                    System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    f_232_23779_23821()
                    {
                        var return_v = ImmutableArray.CreateBuilder<TExtension>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 23779, 23821);
                        return return_v;
                    }


                    System.Type?
                    f_232_24149_24222(System.Reflection.Assembly
                    this_param, string
                    name, bool
                    throwOnError, bool
                    ignoreCase)
                    {
                        var return_v = this_param.GetType(name, throwOnError: throwOnError, ignoreCase: ignoreCase);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 24149, 24222);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs
                    f_232_24386_24423(System.Exception
                    e, string
                    typeName)
                    {
                        var return_v = CreateAnalyzerFailedArgs(e, typeName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 24386, 24423);
                        return return_v;
                    }


                    int
                    f_232_24554_24580(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 24554, 24580);
                        return 0;
                    }


                    System.Runtime.Versioning.TargetFrameworkAttribute?
                    f_232_24822_24885(System.Reflection.Assembly
                    element)
                    {
                        var return_v = element.GetCustomAttribute<System.Runtime.Versioning.TargetFrameworkAttribute>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 24822, 24885);
                        return return_v;
                    }


                    string
                    f_232_24954_24992(System.Runtime.Versioning.TargetFrameworkAttribute
                    this_param)
                    {
                        var return_v = this_param.FrameworkName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 24954, 24992);
                        return return_v;
                    }


                    bool
                    f_232_24954_25056(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.StartsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 24954, 25056);
                        return return_v;
                    }


                    string
                    f_232_25345_25397()
                    {
                        var return_v = CodeAnalysisResources.AssemblyReferencesNetFramework;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 25345, 25397);
                        return return_v;
                    }


                    string
                    f_232_25331_25408(string
                    format, string
                    arg0)
                    {
                        var return_v = string.Format(format, (object)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 25331, 25408);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs
                    f_232_25164_25465(Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs.FailureErrorCode
                    errorCode, string
                    message, string
                    typeNameOpt)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs(errorCode, message, typeNameOpt: typeNameOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 25164, 25465);
                        return return_v;
                    }


                    object?
                    f_232_25686_25716(System.Type
                    type)
                    {
                        var return_v = Activator.CreateInstance(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 25686, 25716);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerLoadFailureEventArgs
                    f_232_25894_25931(System.Exception
                    e, string
                    typeName)
                    {
                        var return_v = CreateAnalyzerFailedArgs(e, typeName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 25894, 25931);
                        return return_v;
                    }


                    int
                    f_232_26132_26155(System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    this_param, TExtension
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 26132, 26155);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_232_23998_24015_I(System.Collections.Generic.IEnumerable<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 23998, 24015);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TExtension>
                    f_232_26225_26248(System.Collections.Immutable.ImmutableArray<TExtension>.Builder
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 26225, 26248);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 23581, 26264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 23581, 26264);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Extensions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(232, 14675, 26275);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(232, 14675, 26275);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 14675, 26275);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(232, 14675, 26275);
        }

        public Assembly GetAssembly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(232, 26287, 26518);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 26341, 26470) || true) && (_lazyAssembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(232, 26341, 26470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 26400, 26455);

                    _lazyAssembly = f_232_26416_26454(_assemblyLoader, f_232_26445_26453());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(232, 26341, 26470);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(232, 26486, 26507);

                return _lazyAssembly;
                DynAbs.Tracing.TraceSender.TraceExitMethod(232, 26287, 26518);

                string
                f_232_26445_26453()
                {
                    var return_v = FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(232, 26445, 26453);
                    return return_v;
                }


                System.Reflection.Assembly
                f_232_26416_26454(Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
                this_param, string
                fullPath)
                {
                    var return_v = this_param.LoadFromPath(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 26416, 26454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(232, 26287, 26518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 26287, 26518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnalyzerFileReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(232, 1161, 26525);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(232, 1161, 26525);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(232, 1161, 26525);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(232, 1161, 26525);

        static int
        f_232_2371_2440(string
        path, string
        argumentName)
        {
            CompilerPathUtilities.RequireAbsolutePath(path, argumentName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 2371, 2440);
            return 0;
        }


        static System.ArgumentNullException
        f_232_2533_2582(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 2533, 2582);
            return return_v;
        }


        static int
        f_232_3033_3079(Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
        this_param, string
        fullPath)
        {
            this_param.AddDependencyLocation(fullPath);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(232, 3033, 3079);
            return 0;
        }

    }
}
