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
                if (_lazyAllExtensions.IsDefault)
                {
                    ImmutableInterlocked.InterlockedInitialize(ref _lazyAllExtensions, CreateExtensionsForAllLanguages(this, includeDuplicates));
                }

                return _lazyAllExtensions;
            }

            private static ImmutableArray<TExtension> CreateExtensionsForAllLanguages(Extensions<TExtension> extensions, bool includeDuplicates)
            {
                // Get all analyzers in the assembly.
                var map = ImmutableDictionary.CreateBuilder<string, ImmutableArray<TExtension>>();
                extensions.AddExtensions(map);

                var builder = ImmutableArray.CreateBuilder<TExtension>();
                foreach (var analyzers in map.Values)
                {
                    foreach (var analyzer in analyzers)
                    {
                        builder.Add(analyzer);
                    }
                }

                if (includeDuplicates)
                {
                    return builder.ToImmutable();
                }
                else
                {
                    return builder.Distinct(ExtTypeComparer.Instance).ToImmutableArray();
                }
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

                public int GetHashCode(TExtension obj) => obj.GetType().GetHashCode();

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
                if (string.IsNullOrEmpty(language))
                {
                    throw new ArgumentException("language");
                }

                return ImmutableInterlocked.GetOrAdd(ref _lazyExtensionsPerLanguage, language, CreateLanguageSpecificExtensions, this);
            }

            private static ImmutableArray<TExtension> CreateLanguageSpecificExtensions(string language, Extensions<TExtension> extensions)
            {
                // Get all analyzers in the assembly for the given language.
                var builder = ImmutableArray.CreateBuilder<TExtension>();
                extensions.AddExtensions(builder, language);
                return builder.ToImmutable();
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
                ImmutableDictionary<string, ImmutableHashSet<string>> analyzerTypeNameMap;
                Assembly analyzerAssembly;

                try
                {
                    analyzerTypeNameMap = GetExtensionTypeNameMap();
                    if (analyzerTypeNameMap.Count == 0)
                    {
                        return;
                    }

                    analyzerAssembly = _reference.GetAssembly();
                }
                catch (Exception e)
                {
                    _reference.AnalyzerLoadFailed?.Invoke(_reference, CreateAnalyzerFailedArgs(e));
                    return;
                }

                var initialCount = builder.Count;
                var reportedError = false;

                // Add language specific analyzers.
                foreach (var (language, _) in analyzerTypeNameMap)
                {
                    if (language == null)
                    {
                        continue;
                    }

                    var analyzers = GetLanguageSpecificAnalyzers(analyzerAssembly, analyzerTypeNameMap, language, ref reportedError);
                    builder.Add(language, analyzers);
                }

                // If there were types with the attribute but weren't an analyzer, generate a diagnostic.
                // If we've reported errors already while trying to instantiate types, don't complain that there are no analyzers.
                if (builder.Count == initialCount && !reportedError)
                {
                    _reference.AnalyzerLoadFailed?.Invoke(_reference, new AnalyzerLoadFailureEventArgs(AnalyzerLoadFailureEventArgs.FailureErrorCode.NoAnalyzers, CodeAnalysisResources.NoAnalyzersFound));
                }
            }

            internal void AddExtensions(ImmutableArray<TExtension>.Builder builder, string language)
            {
                ImmutableDictionary<string, ImmutableHashSet<string>> analyzerTypeNameMap;
                Assembly analyzerAssembly;

                try
                {
                    analyzerTypeNameMap = GetExtensionTypeNameMap();

                    // If there are no analyzers, don't load the assembly at all.
                    if (!analyzerTypeNameMap.ContainsKey(language))
                    {
                        return;
                    }

                    analyzerAssembly = _reference.GetAssembly();
                    if (analyzerAssembly == null)
                    {
                        // This can be null if NoOpAnalyzerAssemblyLoader is used.
                        return;
                    }
                }
                catch (Exception e)
                {
                    _reference.AnalyzerLoadFailed?.Invoke(_reference, CreateAnalyzerFailedArgs(e));
                    return;
                }

                var initialCount = builder.Count;
                var reportedError = false;

                // Add language specific analyzers.
                var analyzers = GetLanguageSpecificAnalyzers(analyzerAssembly, analyzerTypeNameMap, language, ref reportedError);
                builder.AddRange(analyzers);

                // If there were types with the attribute but weren't an analyzer, generate a diagnostic.
                // If we've reported errors already while trying to instantiate types, don't complain that there are no analyzers.
                if (builder.Count == initialCount && !reportedError)
                {
                    _reference.AnalyzerLoadFailed?.Invoke(_reference, new AnalyzerLoadFailureEventArgs(AnalyzerLoadFailureEventArgs.FailureErrorCode.NoAnalyzers, CodeAnalysisResources.NoAnalyzersFound));
                }
            }

            private ImmutableArray<TExtension> GetLanguageSpecificAnalyzers(Assembly analyzerAssembly, ImmutableDictionary<string, ImmutableHashSet<string>> analyzerTypeNameMap, string language, ref bool reportedError)
            {
                ImmutableHashSet<string>? languageSpecificAnalyzerTypeNames;
                if (!analyzerTypeNameMap.TryGetValue(language, out languageSpecificAnalyzerTypeNames))
                {
                    return ImmutableArray<TExtension>.Empty;
                }
                return this.GetAnalyzersForTypeNames(analyzerAssembly, languageSpecificAnalyzerTypeNames, ref reportedError);
            }

            private ImmutableArray<TExtension> GetAnalyzersForTypeNames(Assembly analyzerAssembly, IEnumerable<string> analyzerTypeNames, ref bool reportedError)
            {
                var analyzers = ImmutableArray.CreateBuilder<TExtension>();

                // Given the type names, get the actual System.Type and try to create an instance of the type through reflection.
                foreach (var typeName in analyzerTypeNames)
                {
                    Type? type;
                    try
                    {
                        type = analyzerAssembly.GetType(typeName, throwOnError: true, ignoreCase: false);
                    }
                    catch (Exception e)
                    {
                        _reference.AnalyzerLoadFailed?.Invoke(_reference, CreateAnalyzerFailedArgs(e, typeName));
                        reportedError = true;
                        continue;
                    }

                    Debug.Assert(type != null);

                    // check if this references net framework, and issue a diagnostic that this isn't supported
                    if (!_allowNetFramework)
                    {
                        var targetFrameworkAttribute = analyzerAssembly.GetCustomAttribute<TargetFrameworkAttribute>();
                        if (targetFrameworkAttribute is object && targetFrameworkAttribute.FrameworkName.StartsWith(".NETFramework", StringComparison.OrdinalIgnoreCase))
                        {
                            _reference.AnalyzerLoadFailed?.Invoke(_reference, new AnalyzerLoadFailureEventArgs(
                                AnalyzerLoadFailureEventArgs.FailureErrorCode.ReferencesFramework,
                                string.Format(CodeAnalysisResources.AssemblyReferencesNetFramework, typeName),
                                typeNameOpt: typeName));
                            continue;
                        }
                    }

                    TExtension? analyzer;
                    try
                    {
                        analyzer = Activator.CreateInstance(type) as TExtension;
                    }
                    catch (Exception e)
                    {
                        _reference.AnalyzerLoadFailed?.Invoke(_reference, CreateAnalyzerFailedArgs(e, typeName));
                        reportedError = true;
                        continue;
                    }

                    if (analyzer != null)
                    {
                        analyzers.Add(analyzer);
                    }
                }

                return analyzers.ToImmutable();
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
