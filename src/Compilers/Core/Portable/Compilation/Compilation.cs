// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.DiaSymReader;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract partial class Compilation
    {
        public abstract bool IsCaseSensitive { get; }

        private SmallDictionary<int, bool>? _lazyMakeWellKnownTypeMissingMap;

        private SmallDictionary<int, bool>? _lazyMakeMemberMissingMap;

        protected readonly IReadOnlyDictionary<string, string> _features;

        public ScriptCompilationInfo? ScriptCompilationInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 2751, 2781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 2754, 2781);
                    return f_145_2754_2781(); DynAbs.Tracing.TraceSender.TraceExitMethod(145, 2751, 2781);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 2751, 2781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 2751, 2781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract ScriptCompilationInfo? CommonScriptCompilationInfo { get; }

        internal Compilation(
                    string? name,
                    ImmutableArray<MetadataReference> references,
                    IReadOnlyDictionary<string, string> features,
                    bool isSubmission,
                    SemanticModelProvider? semanticModelProvider,
                    AsyncQueue<CompilationEvent>? eventQueue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(145, 2881, 3683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 2310, 2342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 2507, 2532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 2677, 2686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 12691, 12727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 15378, 15402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 22433, 22495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 22623, 22681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 44166, 44281);
                this._getTypeCache = f_145_44195_44281(50, ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 136118, 136152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(532, 1678, 1747);
                // LAFHIS // new WeakList<IAssemblySymbolInternal>(); (532)
                //this._retargetingAssemblySymbols = f_577_1708_1747();
                this._retargetingAssemblySymbols = f_532_1708_1747();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3218, 3260);

                f_145_3218_3259(f_145_3237_3258_M(!references.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3274, 3311);

                f_145_3274_3310(features != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3327, 3352);

                this.AssemblyName = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3366, 3403);

                this.ExternalReferences = references;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3417, 3468);

                this.SemanticModelProvider = semanticModelProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3482, 3511);

                this.EventQueue = eventQueue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3527, 3637);

                _lazySubmissionSlotIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 3554, 3566) || ((isSubmission && DynAbs.Tracing.TraceSender.Conditional_F2(145, 3569, 3601)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 3604, 3636))) ? SubmissionSlotIndexToBeAllocated : SubmissionSlotIndexNotApplicable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3651, 3672);

                _features = features;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(145, 2881, 3683);

                static WeakList<IAssemblySymbolInternal> f_532_1708_1747()
                {
                    var temp = new WeakList<IAssemblySymbolInternal>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(532, 1708, 1747);
                    return temp;
                }
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 2881, 3683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 2881, 3683);
            }
        }

        protected static IReadOnlyDictionary<string, string> SyntaxTreeCommonFeatures(IEnumerable<SyntaxTree> trees)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 3695, 4663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3828, 3876);

                IReadOnlyDictionary<string, string>?
                set = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3892, 4435);
                    foreach (var tree in f_145_3913_3918_I(trees))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 3892, 4435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 3952, 3993);

                        var
                        treeFeatures = f_145_3971_3992(f_145_3971_3983(tree))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 4011, 4420) || true) && (set == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 4011, 4420);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 4068, 4087);

                            set = treeFeatures;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 4011, 4420);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 4011, 4420);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 4169, 4401) || true) && ((object)set != treeFeatures && (DynAbs.Tracing.TraceSender.Expression_True(145, 4173, 4232) && !f_145_4205_4232(set, treeFeatures)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 4169, 4401);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 4282, 4378);

                                throw f_145_4288_4377(f_145_4310_4361(), nameof(trees));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 4169, 4401);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 4011, 4420);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 3892, 4435);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 544);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 4451, 4625) || true) && (set == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 4451, 4625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 4562, 4610);

                    set = ImmutableDictionary<string, string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 4451, 4625);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 4641, 4652);

                return set;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 3695, 4663);

                Microsoft.CodeAnalysis.ParseOptions
                f_145_3971_3983(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 3971, 3983);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_145_3971_3992(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 3971, 3992);
                    return return_v;
                }


                bool
                f_145_4205_4232(System.Collections.Generic.IReadOnlyDictionary<string, string>
                source1, System.Collections.Generic.IReadOnlyDictionary<string, string>
                source2)
                {
                    var return_v = source1.SetEquals<System.Collections.Generic.KeyValuePair<string, string>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)source2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 4205, 4232);
                    return return_v;
                }


                string
                f_145_4310_4361()
                {
                    var return_v = CodeAnalysisResources.InconsistentSyntaxTreeFeature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 4310, 4361);
                    return return_v;
                }


                System.ArgumentException
                f_145_4288_4377(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 4288, 4377);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_145_3913_3918_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 3913, 3918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 3695, 4663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 3695, 4663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract AnalyzerDriver CreateAnalyzerDriver(ImmutableArray<DiagnosticAnalyzer> analyzers, AnalyzerManager analyzerManager, SeverityFilter severityFilter);

        public abstract string Language { get; }

        internal abstract void SerializePdbEmbeddedCompilationOptions(BlobBuilder builder);

        internal static void ValidateScriptCompilationParameters(Compilation? previousScriptCompilation, Type? returnType, ref Type? globalsType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 5109, 6629);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 5271, 5496) || true) && (globalsType != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 5275, 5333) && !f_145_5299_5333(globalsType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 5271, 5496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 5367, 5481);

                    throw f_145_5373_5480(f_145_5395_5458(), nameof(globalsType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 5271, 5496);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 5512, 5732) || true) && (returnType != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 5516, 5578) && !f_145_5539_5578(returnType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 5512, 5732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 5612, 5717);

                    throw f_145_5618_5716(f_145_5640_5695(), nameof(returnType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 5512, 5732);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 5748, 6618) || true) && (previousScriptCompilation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 5748, 6618);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 5819, 6224) || true) && (globalsType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 5819, 6224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 5884, 5939);

                        globalsType = f_145_5898_5938(previousScriptCompilation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 5819, 6224);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 5819, 6224);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 5981, 6224) || true) && (globalsType != f_145_6000_6040(previousScriptCompilation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 5981, 6224);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 6082, 6205);

                            throw f_145_6088_6204(f_145_6110_6182(), nameof(globalsType));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 5981, 6224);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 5819, 6224);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 6360, 6603) || true) && (f_145_6364_6406(previousScriptCompilation).Any(d => d.Severity == DiagnosticSeverity.Error))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 6360, 6603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 6497, 6584);

                        throw f_145_6503_6583(f_145_6533_6582());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 6360, 6603);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 5748, 6618);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 5109, 6629);

                bool
                f_145_5299_5333(System.Type
                type)
                {
                    var return_v = IsValidHostObjectType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 5299, 5333);
                    return return_v;
                }


                string
                f_145_5395_5458()
                {
                    var return_v = CodeAnalysisResources.ReturnTypeCannotBeValuePointerbyRefOrOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 5395, 5458);
                    return return_v;
                }


                System.ArgumentException
                f_145_5373_5480(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 5373, 5480);
                    return return_v;
                }


                bool
                f_145_5539_5578(System.Type
                type)
                {
                    var return_v = IsValidSubmissionReturnType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 5539, 5578);
                    return return_v;
                }


                string
                f_145_5640_5695()
                {
                    var return_v = CodeAnalysisResources.ReturnTypeCannotBeVoidByRefOrOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 5640, 5695);
                    return return_v;
                }


                System.ArgumentException
                f_145_5618_5716(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 5618, 5716);
                    return return_v;
                }


                System.Type?
                f_145_5898_5938(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.HostObjectType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 5898, 5938);
                    return return_v;
                }


                System.Type?
                f_145_6000_6040(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.HostObjectType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 6000, 6040);
                    return return_v;
                }


                string
                f_145_6110_6182()
                {
                    var return_v = CodeAnalysisResources.TypeMustBeSameAsHostObjectTypeOfPreviousSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 6110, 6182);
                    return return_v;
                }


                System.ArgumentException
                f_145_6088_6204(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 6088, 6204);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_145_6364_6406(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 6364, 6406);
                    return return_v;
                }


                string
                f_145_6533_6582()
                {
                    var return_v = CodeAnalysisResources.PreviousSubmissionHasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 6533, 6582);
                    return return_v;
                }


                System.InvalidOperationException
                f_145_6503_6583(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 6503, 6583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 5109, 6629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 5109, 6629);
            }
        }

        internal static void CheckSubmissionOptions(CompilationOptions? options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 6845, 7701);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 6942, 7017) || true) && (options == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 6942, 7017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 6995, 7002);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 6942, 7017);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 7033, 7274) || true) && (f_145_7037_7065(f_145_7037_7055(options)) && (DynAbs.Tracing.TraceSender.Expression_True(145, 7037, 7126) && f_145_7069_7087(options) != OutputKind.DynamicallyLinkedLibrary))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 7033, 7274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 7160, 7259);

                    throw f_145_7166_7258(f_145_7188_7240(), nameof(options));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 7033, 7274);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 7290, 7690) || true) && (f_145_7294_7320(options) != null || (DynAbs.Tracing.TraceSender.Expression_False(145, 7294, 7378) || f_145_7349_7370(options) != null) || (DynAbs.Tracing.TraceSender.Expression_False(145, 7294, 7424) || f_145_7399_7416(options) != null) || (DynAbs.Tracing.TraceSender.Expression_False(145, 7294, 7477) || f_145_7445_7477_M(!options.CryptoPublicKey.IsEmpty)) || (DynAbs.Tracing.TraceSender.Expression_False(145, 7294, 7547) || (f_145_7499_7516(options) == true && (DynAbs.Tracing.TraceSender.Expression_True(145, 7499, 7546) && f_145_7528_7546(options)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 7290, 7690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 7581, 7675);

                    throw f_145_7587_7674(f_145_7609_7656(), nameof(options));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 7290, 7690);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 6845, 7701);

                Microsoft.CodeAnalysis.OutputKind
                f_145_7037_7055(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7037, 7055);
                    return return_v;
                }


                bool
                f_145_7037_7065(Microsoft.CodeAnalysis.OutputKind
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 7037, 7065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_7069_7087(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7069, 7087);
                    return return_v;
                }


                string
                f_145_7188_7240()
                {
                    var return_v = CodeAnalysisResources.InvalidOutputKindForSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7188, 7240);
                    return return_v;
                }


                System.ArgumentException
                f_145_7166_7258(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 7166, 7258);
                    return return_v;
                }


                string?
                f_145_7294_7320(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7294, 7320);
                    return return_v;
                }


                string?
                f_145_7349_7370(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.CryptoKeyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7349, 7370);
                    return return_v;
                }


                bool?
                f_145_7399_7416(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.DelaySign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7399, 7416);
                    return return_v;
                }


                bool
                f_145_7445_7477_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7445, 7477);
                    return return_v;
                }


                bool?
                f_145_7499_7516(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.DelaySign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7499, 7516);
                    return return_v;
                }


                bool
                f_145_7528_7546(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.PublicSign;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7528, 7546);
                    return return_v;
                }


                string
                f_145_7609_7656()
                {
                    var return_v = CodeAnalysisResources.InvalidCompilationOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 7609, 7656);
                    return return_v;
                }


                System.ArgumentException
                f_145_7587_7674(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 7587, 7674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 6845, 7701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 6845, 7701);
            }
        }

        public Compilation Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 7855, 7938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 7906, 7927);

                return f_145_7913_7926(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 7855, 7938);

                Microsoft.CodeAnalysis.Compilation
                f_145_7913_7926(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.CommonClone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 7913, 7926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 7855, 7938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 7855, 7938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Compilation CommonClone();

        internal abstract Compilation WithEventQueue(AsyncQueue<CompilationEvent>? eventQueue);

        internal abstract Compilation WithSemanticModelProvider(SemanticModelProvider semanticModelProvider);

        public SemanticModel GetSemanticModel(SyntaxTree syntaxTree, bool ignoreAccessibility = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 8944, 9002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 8947, 9002);
                return f_145_8947_9002(this, syntaxTree, ignoreAccessibility); DynAbs.Tracing.TraceSender.TraceExitMethod(145, 8944, 9002);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 8944, 9002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 8944, 9002);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SemanticModel
            f_145_8947_9002(Microsoft.CodeAnalysis.Compilation
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            syntaxTree, bool
            ignoreAccessibility)
            {
                var return_v = this_param.CommonGetSemanticModel(syntaxTree, ignoreAccessibility);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 8947, 9002);
                return return_v;
            }

        }

        protected abstract SemanticModel CommonGetSemanticModel(SyntaxTree syntaxTree, bool ignoreAccessibility);

        internal abstract SemanticModel CreateSemanticModel(SyntaxTree syntaxTree, bool ignoreAccessibility);

        public INamedTypeSymbol CreateErrorTypeSymbol(INamespaceOrTypeSymbol? container, string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 10593, 11073);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 10722, 10833) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 10722, 10833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 10772, 10818);

                    throw f_145_10778_10817(nameof(name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 10722, 10833);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 10849, 10987) || true) && (arity < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 10849, 10987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 10896, 10972);

                    throw f_145_10902_10971($"{nameof(arity)} must be >= 0", nameof(arity));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 10849, 10987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 11003, 11062);

                return f_145_11010_11061(this, container, name, arity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 10593, 11073);

                System.ArgumentNullException
                f_145_10778_10817(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 10778, 10817);
                    return return_v;
                }


                System.ArgumentException
                f_145_10902_10971(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 10902, 10971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_145_11010_11061(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                container, string
                name, int
                arity)
                {
                    var return_v = this_param.CommonCreateErrorTypeSymbol(container, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 11010, 11061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 10593, 11073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 10593, 11073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract INamedTypeSymbol CommonCreateErrorTypeSymbol(INamespaceOrTypeSymbol? container, string name, int arity);

        public INamespaceSymbol CreateErrorNamespaceSymbol(INamespaceSymbol container, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 11374, 11822);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 11490, 11611) || true) && (container == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 11490, 11611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 11545, 11596);

                    throw f_145_11551_11595(nameof(container));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 11490, 11611);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 11627, 11738) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 11627, 11738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 11677, 11723);

                    throw f_145_11683_11722(nameof(name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 11627, 11738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 11754, 11811);

                return f_145_11761_11810(this, container, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 11374, 11822);

                System.ArgumentNullException
                f_145_11551_11595(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 11551, 11595);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_11683_11722(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 11683, 11722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol
                f_145_11761_11810(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                container, string
                name)
                {
                    var return_v = this_param.CommonCreateErrorNamespaceSymbol(container, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 11761, 11810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 11374, 11822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 11374, 11822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract INamespaceSymbol CommonCreateErrorNamespaceSymbol(INamespaceSymbol container, string name);

        internal const string
        UnspecifiedModuleAssemblyName = "?"
        ;

        public string? AssemblyName { get; }

        internal void CheckAssemblyName(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 12739, 13231);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 13014, 13220) || true) && (f_145_13018_13035(this) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 13014, 13220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 13077, 13205);

                    f_145_13077_13204(f_145_13119_13136(this), f_145_13138_13153(), f_145_13155_13190(f_145_13155_13170()), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 13014, 13220);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 12739, 13231);

                string?
                f_145_13018_13035(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13018, 13035);
                    return return_v;
                }


                string
                f_145_13119_13136(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13119, 13136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_13138_13153()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13138, 13153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_13155_13170()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13155, 13170);
                    return return_v;
                }


                int
                f_145_13155_13190(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadAssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13155, 13190);
                    return return_v;
                }


                int
                f_145_13077_13204(string
                name, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                code, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    MetadataHelpers.CheckAssemblyOrModuleName(name, messageProvider, code, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 13077, 13204);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 12739, 13231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 12739, 13231);
            }
        }

        internal string MakeSourceAssemblySimpleName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 13243, 13378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 13314, 13367);

                return f_145_13321_13333() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(145, 13321, 13366) ?? UnspecifiedModuleAssemblyName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 13243, 13378);

                string?
                f_145_13321_13333()
                {
                    var return_v = AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13321, 13333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 13243, 13378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 13243, 13378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string MakeSourceModuleName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 13390, 13626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 13453, 13615);

                return f_145_13460_13478(f_145_13460_13467()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(145, 13460, 13614) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(145, 13503, 13523) || ((f_145_13503_13515() != null && DynAbs.Tracing.TraceSender.Conditional_F2(145, 13526, 13581)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 13584, 13613))) ? f_145_13526_13538() + f_145_13541_13581(f_145_13541_13559(f_145_13541_13548())) : UnspecifiedModuleAssemblyName));
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 13390, 13626);

                Microsoft.CodeAnalysis.CompilationOptions
                f_145_13460_13467()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13460, 13467);
                    return return_v;
                }


                string?
                f_145_13460_13478(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13460, 13478);
                    return return_v;
                }


                string?
                f_145_13503_13515()
                {
                    var return_v = AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13503, 13515);
                    return return_v;
                }


                string
                f_145_13526_13538()
                {
                    var return_v = AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13526, 13538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_13541_13548()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13541, 13548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_13541_13559(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 13541, 13559);
                    return return_v;
                }


                string
                f_145_13541_13581(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.GetDefaultExtension();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 13541, 13581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 13390, 13626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 13390, 13626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Compilation WithAssemblyName(string? assemblyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 13876, 14013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 13958, 14002);

                return f_145_13965_14001(this, assemblyName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 13876, 14013);

                Microsoft.CodeAnalysis.Compilation
                f_145_13965_14001(Microsoft.CodeAnalysis.Compilation
                this_param, string?
                outputName)
                {
                    var return_v = this_param.CommonWithAssemblyName(outputName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 13965, 14001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 13876, 14013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 13876, 14013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Compilation CommonWithAssemblyName(string? outputName);

        public CompilationOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 14307, 14336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 14313, 14334);

                    return f_145_14320_14333();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 14307, 14336);

                    Microsoft.CodeAnalysis.CompilationOptions
                    f_145_14320_14333()
                    {
                        var return_v = CommonOptions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 14320, 14333);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 14271, 14338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 14271, 14338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract CompilationOptions CommonOptions { get; }

        public Compilation WithOptions(CompilationOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 14659, 14787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 14742, 14776);

                return f_145_14749_14775(this, options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 14659, 14787);

                Microsoft.CodeAnalysis.Compilation
                f_145_14749_14775(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.CompilationOptions
                options)
                {
                    var return_v = this_param.CommonWithOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 14749, 14775);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 14659, 14787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 14659, 14787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Compilation CommonWithOptions(CompilationOptions options);

        private int _lazySubmissionSlotIndex;

        private const int
        SubmissionSlotIndexNotApplicable = -3
        ;

        private const int
        SubmissionSlotIndexToBeAllocated = -2
        ;

        internal bool IsSubmission
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 15720, 15839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 15756, 15824);

                    return _lazySubmissionSlotIndex != SubmissionSlotIndexNotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 15720, 15839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 15669, 15850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 15669, 15850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Compilation? PreviousSubmission
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 16028, 16135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 16064, 16120);

                    return f_145_16071_16119_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_145_16071_16092(), 145, 16071, 16119)?.PreviousScriptCompilation);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 16028, 16135);

                    Microsoft.CodeAnalysis.ScriptCompilationInfo?
                    f_145_16071_16092()
                    {
                        var return_v = ScriptCompilationInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 16071, 16092);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Compilation?
                    f_145_16071_16119_M(Microsoft.CodeAnalysis.Compilation?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 16071, 16119);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 15964, 16146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 15964, 16146);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int GetSubmissionSlotIndex()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 16442, 16924);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 16504, 16865) || true) && (_lazySubmissionSlotIndex == SubmissionSlotIndexToBeAllocated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 16504, 16865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 16653, 16753);

                    int
                    lastSlotIndex = f_145_16673_16747_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_145_16673_16721(ScriptCompilationInfo!), 145, 16673, 16747).GetSubmissionSlotIndex()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(145, 16673, 16752) ?? 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 16771, 16850);

                    _lazySubmissionSlotIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 16798, 16813) || ((f_145_16798_16813(this) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 16816, 16833)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 16836, 16849))) ? lastSlotIndex + 1 : lastSlotIndex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 16504, 16865);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 16881, 16913);

                return _lazySubmissionSlotIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 16442, 16924);

                Microsoft.CodeAnalysis.Compilation?
                f_145_16673_16721(Microsoft.CodeAnalysis.ScriptCompilationInfo
                this_param)
                {
                    var return_v = this_param.PreviousScriptCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 16673, 16721);
                    return return_v;
                }


                int?
                f_145_16673_16747_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 16673, 16747);
                    return return_v;
                }


                bool
                f_145_16798_16813(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.HasCodeToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 16798, 16813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 16442, 16924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 16442, 16924);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Type? SubmissionReturnType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 17638, 17677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 17641, 17677);
                    return f_145_17641_17677_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_145_17641_17662(), 145, 17641, 17677)?.ReturnTypeOpt); DynAbs.Tracing.TraceSender.TraceExitMethod(145, 17638, 17677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 17638, 17677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 17638, 17677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool IsValidSubmissionReturnType(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 17690, 17880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 17774, 17869);

                return !(type == typeof(void) || (DynAbs.Tracing.TraceSender.Expression_False(145, 17783, 17819) || f_145_17807_17819(type)) || (DynAbs.Tracing.TraceSender.Expression_False(145, 17783, 17867) || f_145_17823_17867(f_145_17823_17841(type))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 17690, 17880);

                bool
                f_145_17807_17819(System.Type
                this_param)
                {
                    var return_v = this_param.IsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 17807, 17819);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_145_17823_17841(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 17823, 17841);
                    return return_v;
                }


                bool
                f_145_17823_17867(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.ContainsGenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 17823, 17867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 17690, 17880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 17690, 17880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Type? HostObjectType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 18060, 18097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 18063, 18097);
                    return f_145_18063_18097_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_145_18063_18084(), 145, 18063, 18097)?.GlobalsType); DynAbs.Tracing.TraceSender.TraceExitMethod(145, 18060, 18097);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 18060, 18097);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 18060, 18097);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool IsValidHostObjectType(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 18110, 18338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 18188, 18218);

                var
                info = f_145_18199_18217(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 18232, 18327);

                return !(f_145_18241_18257(info) || (DynAbs.Tracing.TraceSender.Expression_False(145, 18241, 18275) || f_145_18261_18275(info)) || (DynAbs.Tracing.TraceSender.Expression_False(145, 18241, 18291) || f_145_18279_18291(info)) || (DynAbs.Tracing.TraceSender.Expression_False(145, 18241, 18325) || f_145_18295_18325(info)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 18110, 18338);

                System.Reflection.TypeInfo
                f_145_18199_18217(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 18199, 18217);
                    return return_v;
                }


                bool
                f_145_18241_18257(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 18241, 18257);
                    return return_v;
                }


                bool
                f_145_18261_18275(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 18261, 18275);
                    return return_v;
                }


                bool
                f_145_18279_18291(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 18279, 18291);
                    return return_v;
                }


                bool
                f_145_18295_18325(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.ContainsGenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 18295, 18325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 18110, 18338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 18110, 18338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract bool HasSubmissionResult();

        public Compilation WithScriptCompilationInfo(ScriptCompilationInfo? info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 18481, 18521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 18484, 18521);
                return f_145_18484_18521(this, info); DynAbs.Tracing.TraceSender.TraceExitMethod(145, 18481, 18521);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 18481, 18521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 18481, 18521);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Compilation
            f_145_18484_18521(Microsoft.CodeAnalysis.Compilation
            this_param, Microsoft.CodeAnalysis.ScriptCompilationInfo?
            info)
            {
                var return_v = this_param.CommonWithScriptCompilationInfo(info);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 18484, 18521);
                return return_v;
            }

        }

        protected abstract Compilation CommonWithScriptCompilationInfo(ScriptCompilationInfo? info);

        public IEnumerable<SyntaxTree> SyntaxTrees
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 18883, 18916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 18889, 18914);

                    return f_145_18896_18913();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 18883, 18916);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    f_145_18896_18913()
                    {
                        var return_v = CommonSyntaxTrees;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 18896, 18913);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 18838, 18918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 18838, 18918);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract IEnumerable<SyntaxTree> CommonSyntaxTrees { get; }

        public Compilation AddSyntaxTrees(params SyntaxTree[] trees)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 19239, 19370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 19324, 19359);

                return f_145_19331_19358(this, trees);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 19239, 19370);

                Microsoft.CodeAnalysis.Compilation
                f_145_19331_19358(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree[]
                trees)
                {
                    var return_v = this_param.CommonAddSyntaxTrees((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 19331, 19358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 19239, 19370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 19239, 19370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Compilation AddSyntaxTrees(IEnumerable<SyntaxTree> trees)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 19612, 19747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 19701, 19736);

                return f_145_19708_19735(this, trees);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 19612, 19747);

                Microsoft.CodeAnalysis.Compilation
                f_145_19708_19735(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                trees)
                {
                    var return_v = this_param.CommonAddSyntaxTrees(trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 19708, 19735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 19612, 19747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 19612, 19747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Compilation CommonAddSyntaxTrees(IEnumerable<SyntaxTree> trees);

        public Compilation RemoveSyntaxTrees(params SyntaxTree[] trees)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 20159, 20296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 20247, 20285);

                return f_145_20254_20284(this, trees);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 20159, 20296);

                Microsoft.CodeAnalysis.Compilation
                f_145_20254_20284(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree[]
                trees)
                {
                    var return_v = this_param.CommonRemoveSyntaxTrees((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 20254, 20284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 20159, 20296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 20159, 20296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Compilation RemoveSyntaxTrees(IEnumerable<SyntaxTree> trees)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 20613, 20754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 20705, 20743);

                return f_145_20712_20742(this, trees);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 20613, 20754);

                Microsoft.CodeAnalysis.Compilation
                f_145_20712_20742(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                trees)
                {
                    var return_v = this_param.CommonRemoveSyntaxTrees(trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 20712, 20742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 20613, 20754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 20613, 20754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Compilation CommonRemoveSyntaxTrees(IEnumerable<SyntaxTree> trees);

        public Compilation RemoveAllSyntaxTrees()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 21045, 21158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 21111, 21147);

                return f_145_21118_21146(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 21045, 21158);

                Microsoft.CodeAnalysis.Compilation
                f_145_21118_21146(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.CommonRemoveAllSyntaxTrees();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 21118, 21146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 21045, 21158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 21045, 21158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Compilation CommonRemoveAllSyntaxTrees();

        public Compilation ReplaceSyntaxTree(SyntaxTree oldTree, SyntaxTree newTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 21608, 21769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 21709, 21758);

                return f_145_21716_21757(this, oldTree, newTree);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 21608, 21769);

                Microsoft.CodeAnalysis.Compilation
                f_145_21716_21757(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                oldTree, Microsoft.CodeAnalysis.SyntaxTree
                newTree)
                {
                    var return_v = this_param.CommonReplaceSyntaxTree(oldTree, newTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 21716, 21757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 21608, 21769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 21608, 21769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Compilation CommonReplaceSyntaxTree(SyntaxTree oldTree, SyntaxTree newTree);

        public bool ContainsSyntaxTree(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 22088, 22221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 22166, 22210);

                return f_145_22173_22209(this, syntaxTree);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 22088, 22221);

                bool
                f_145_22173_22209(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.CommonContainsSyntaxTree(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 22173, 22209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 22088, 22221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 22088, 22221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract bool CommonContainsSyntaxTree(SyntaxTree? syntaxTree);

        internal SemanticModelProvider? SemanticModelProvider { get; }

        internal AsyncQueue<CompilationEvent>? EventQueue { get; }

        internal static ImmutableArray<MetadataReference> ValidateReferences<T>(IEnumerable<MetadataReference>? references)
                    where T : CompilationReference
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 22745, 23800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 22929, 22974);

                var
                result = f_145_22942_22973(references)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 22997, 23002);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 22988, 23759) || true) && (i < result.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23023, 23026)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(145, 22988, 23759))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 22988, 23759);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23060, 23086);

                        var
                        reference = result[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23104, 23248) || true) && (reference == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 23104, 23248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23167, 23229);

                            throw f_145_23173_23228($"{nameof(references)}[{i}]");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 23104, 23248);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23268, 23327);

                        var
                        peReference = reference as PortableExecutableReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23345, 23744) || true) && (peReference == null && (DynAbs.Tracing.TraceSender.Expression_True(145, 23349, 23389) && !(reference is T)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 23345, 23744);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23431, 23523);

                            f_145_23431_23522(reference is UnresolvedMetadataReference || (DynAbs.Tracing.TraceSender.Expression_False(145, 23444, 23521) || reference is CompilationReference));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23545, 23725);

                            throw f_145_23551_23724(f_145_23573_23656(f_145_23587_23634(), f_145_23636_23655(reference)), $"{nameof(references)}[{i}]");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 23345, 23744);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 772);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23775, 23789);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 22745, 23800);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_145_22942_22973(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 22942, 22973);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_23173_23228(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 23173, 23228);
                    return return_v;
                }


                int
                f_145_23431_23522(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 23431, 23522);
                    return 0;
                }


                string
                f_145_23587_23634()
                {
                    var return_v = CodeAnalysisResources.ReferenceOfTypeIsInvalid1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 23587, 23634);
                    return return_v;
                }


                System.Type
                f_145_23636_23655(Microsoft.CodeAnalysis.MetadataReference
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 23636, 23655);
                    return return_v;
                }


                string
                f_145_23573_23656(string
                format, System.Type
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 23573, 23656);
                    return return_v;
                }


                System.ArgumentException
                f_145_23551_23724(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 23551, 23724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 22745, 23800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 22745, 23800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommonReferenceManager GetBoundReferenceManager()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 23812, 23946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 23895, 23935);

                return f_145_23902_23934(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 23812, 23946);

                Microsoft.CodeAnalysis.CommonReferenceManager
                f_145_23902_23934(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.CommonGetBoundReferenceManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 23902, 23934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 23812, 23946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 23812, 23946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract CommonReferenceManager CommonGetBoundReferenceManager();

        public ImmutableArray<MetadataReference> ExternalReferences { get; }

        public abstract ImmutableArray<MetadataReference> DirectiveReferences { get; }

        internal abstract IEnumerable<ReferenceDirective> ReferenceDirectives { get; }

        internal abstract IDictionary<(string path, string content), MetadataReference> ReferenceDirectiveMap { get; }

        public IEnumerable<MetadataReference> References
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 25205, 25533);

                    var listYield = new List<MetadataReference>();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 25241, 25369);
                        foreach (var reference in f_145_25267_25285_I(f_145_25267_25285()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 25241, 25369);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 25327, 25350);

                            listYield.Add(reference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 25241, 25369);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 129);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 129);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 25389, 25518);
                        foreach (var reference in f_145_25415_25434_I(f_145_25415_25434()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 25389, 25518);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 25476, 25499);

                            listYield.Add(reference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 25389, 25518);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 130);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 130);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 25205, 25533);

                    return listYield;

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    f_145_25267_25285()
                    {
                        var return_v = ExternalReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 25267, 25285);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    f_145_25267_25285_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 25267, 25285);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    f_145_25415_25434()
                    {
                        var return_v = DirectiveReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 25415, 25434);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    f_145_25415_25434_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 25415, 25434);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 25132, 25544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 25132, 25544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract CompilationReference ToMetadataReference(ImmutableArray<string> aliases = default(ImmutableArray<string>), bool embedInteropTypes = false);

        public Compilation WithReferences(IEnumerable<MetadataReference> newReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 26494, 26657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 26598, 26646);

                return f_145_26605_26645(this, newReferences);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 26494, 26657);

                Microsoft.CodeAnalysis.Compilation
                f_145_26605_26645(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                newReferences)
                {
                    var return_v = this_param.CommonWithReferences(newReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 26605, 26645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 26494, 26657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 26494, 26657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Compilation WithReferences(params MetadataReference[] newReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 26906, 27091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 27006, 27080);

                return f_145_27013_27079(this, newReferences);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 26906, 27091);

                Microsoft.CodeAnalysis.Compilation
                f_145_27013_27079(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.MetadataReference[]
                newReferences)
                {
                    var return_v = this_param.WithReferences((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)newReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 27013, 27079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 26906, 27091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 26906, 27091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Compilation CommonWithReferences(IEnumerable<MetadataReference> newReferences);

        public Compilation AddReferences(params MetadataReference[] references)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 27570, 27742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 27666, 27731);

                return f_145_27673_27730(this, references);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 27570, 27742);

                Microsoft.CodeAnalysis.Compilation
                f_145_27673_27730(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.AddReferences((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 27673, 27730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 27570, 27742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 27570, 27742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Compilation AddReferences(IEnumerable<MetadataReference> references)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 27994, 28416);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 28094, 28217) || true) && (references == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 28094, 28217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 28150, 28202);

                    throw f_145_28156_28201(nameof(references));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 28094, 28217);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 28233, 28318) || true) && (f_145_28237_28257(references))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 28233, 28318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 28291, 28303);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 28233, 28318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 28334, 28405);

                // LAFHIS
                //return f_145_28341_28404(this, f_145_28362_28403(this.ExternalReferences, references));

                var temp = this.ExternalReferences.Union<Microsoft.CodeAnalysis.MetadataReference>(references);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 28362, 28403);

                return f_145_28341_28404(this, temp);

                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 27994, 28416);

                System.ArgumentNullException
                f_145_28156_28201(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 28156, 28201);
                    return return_v;
                }


                bool
                f_145_28237_28257(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 28237, 28257);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_145_28362_28403(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                second)
                {
                    var return_v = first.Union<Microsoft.CodeAnalysis.MetadataReference>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 28362, 28403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_145_28341_28404(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                newReferences)
                {
                    var return_v = this_param.CommonWithReferences(newReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 28341, 28404);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 27994, 28416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 27994, 28416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Compilation RemoveReferences(params MetadataReference[] references)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 28674, 28852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 28773, 28841);

                return f_145_28780_28840(this, references);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 28674, 28852);

                Microsoft.CodeAnalysis.Compilation
                f_145_28780_28840(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.RemoveReferences((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 28780, 28840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 28674, 28852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 28674, 28852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Compilation RemoveReferences(IEnumerable<MetadataReference> references)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 29110, 30156);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 29213, 29336) || true) && (references == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 29213, 29336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 29269, 29321);

                    throw f_145_29275_29320(nameof(references));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 29213, 29336);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 29352, 29437) || true) && (f_145_29356_29376(references))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 29352, 29437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 29410, 29422);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 29352, 29437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 29453, 29522);

                var
                refSet = f_145_29466_29521(f_145_29497_29520(this))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 29772, 30093);
                    foreach (var r in f_145_29790_29811_I(f_145_29790_29811(references)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 29772, 30093);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 29845, 30078) || true) && (!f_145_29850_29866(refSet, r))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 29845, 30078);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 29908, 30059);

                            throw f_145_29914_30058(f_145_29936_30004(f_145_29950_30000(), r), nameof(references));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 29845, 30078);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 29772, 30093);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 30109, 30145);

                return f_145_30116_30144(this, refSet);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 29110, 30156);

                System.ArgumentNullException
                f_145_29275_29320(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 29275, 29320);
                    return return_v;
                }


                bool
                f_145_29356_29376(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 29356, 29376);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_145_29497_29520(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.ExternalReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 29497, 29520);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.MetadataReference>
                f_145_29466_29521(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.MetadataReference>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 29466, 29521);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_145_29790_29811(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                source)
                {
                    var return_v = source.Distinct<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 29790, 29811);
                    return return_v;
                }


                bool
                f_145_29850_29866(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 29850, 29866);
                    return return_v;
                }


                string
                f_145_29950_30000()
                {
                    var return_v = CodeAnalysisResources.MetadataRefNotFoundToRemove1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 29950, 30000);
                    return return_v;
                }


                string
                f_145_29936_30004(string
                format, Microsoft.CodeAnalysis.MetadataReference
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 29936, 30004);
                    return return_v;
                }


                System.ArgumentException
                f_145_29914_30058(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 29914, 30058);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_145_29790_29811_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 29790, 29811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_145_30116_30144(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.MetadataReference>
                newReferences)
                {
                    var return_v = this_param.CommonWithReferences((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)newReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 30116, 30144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 29110, 30156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 29110, 30156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Compilation RemoveAllReferences()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 30287, 30452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 30352, 30441);

                return f_145_30359_30440(this, f_145_30380_30439());
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 30287, 30452);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_145_30380_30439()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 30380, 30439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_145_30359_30440(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                newReferences)
                {
                    var return_v = this_param.CommonWithReferences(newReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 30359, 30440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 30287, 30452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 30287, 30452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Compilation ReplaceReference(MetadataReference oldReference, MetadataReference? newReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 30819, 31301);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 30944, 31071) || true) && (oldReference == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 30944, 31071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 31002, 31056);

                    throw f_145_31008_31055(nameof(oldReference));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 30944, 31071);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 31087, 31203) || true) && (newReference == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 31087, 31203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 31145, 31188);

                    return f_145_31152_31187(this, oldReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 31087, 31203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 31219, 31290);

                return f_145_31226_31289(f_145_31226_31261(this, oldReference), newReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 30819, 31301);

                System.ArgumentNullException
                f_145_31008_31055(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 31008, 31055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_145_31152_31187(Microsoft.CodeAnalysis.Compilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.RemoveReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 31152, 31187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_145_31226_31261(Microsoft.CodeAnalysis.Compilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.RemoveReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 31226, 31261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_145_31226_31289(Microsoft.CodeAnalysis.Compilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.AddReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 31226, 31289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 30819, 31301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 30819, 31301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ISymbol? GetAssemblyOrModuleSymbol(MetadataReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 31730, 31886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 31825, 31875);

                return f_145_31832_31874(this, reference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 31730, 31886);

                Microsoft.CodeAnalysis.ISymbol?
                f_145_31832_31874(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.MetadataReference
                reference)
                {
                    var return_v = this_param.CommonGetAssemblyOrModuleSymbol(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 31832, 31874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 31730, 31886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 31730, 31886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ISymbol? CommonGetAssemblyOrModuleSymbol(MetadataReference reference);

        public MetadataReference? GetMetadataReference(IAssemblySymbol assemblySymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 32210, 32374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 32313, 32363);

                return f_145_32320_32362(this, assemblySymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 32210, 32374);

                Microsoft.CodeAnalysis.MetadataReference?
                f_145_32320_32362(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.IAssemblySymbol
                assemblySymbol)
                {
                    var return_v = this_param.CommonGetMetadataReference(assemblySymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 32320, 32362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 32210, 32374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 32210, 32374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private protected abstract MetadataReference? CommonGetMetadataReference(IAssemblySymbol assemblySymbol);

        public abstract IEnumerable<AssemblyIdentity> ReferencedAssemblyNames { get; }

        public IAssemblySymbol Assembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 33156, 33186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 33162, 33184);

                    return f_145_33169_33183();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 33156, 33186);

                    Microsoft.CodeAnalysis.IAssemblySymbol
                    f_145_33169_33183()
                    {
                        var return_v = CommonAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 33169, 33183);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 33122, 33188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 33122, 33188);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract IAssemblySymbol CommonAssembly { get; }

        public IModuleSymbol SourceModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 33480, 33514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 33486, 33512);

                    return f_145_33493_33511();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 33480, 33514);

                    Microsoft.CodeAnalysis.IModuleSymbol
                    f_145_33493_33511()
                    {
                        var return_v = CommonSourceModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 33493, 33511);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 33444, 33516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 33444, 33516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract IModuleSymbol CommonSourceModule { get; }

        public INamespaceSymbol GlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 33863, 33900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 33869, 33898);

                    return f_145_33876_33897();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 33863, 33900);

                    Microsoft.CodeAnalysis.INamespaceSymbol
                    f_145_33876_33897()
                    {
                        var return_v = CommonGlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 33876, 33897);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 33821, 33902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 33821, 33902);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract INamespaceSymbol CommonGlobalNamespace { get; }

        public INamespaceSymbol? GetCompilationNamespace(INamespaceSymbol namespaceSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 34143, 34315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 34250, 34304);

                return f_145_34257_34303(this, namespaceSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 34143, 34315);

                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_145_34257_34303(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                namespaceSymbol)
                {
                    var return_v = this_param.CommonGetCompilationNamespace(namespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 34257, 34303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 34143, 34315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 34143, 34315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract INamespaceSymbol? CommonGetCompilationNamespace(INamespaceSymbol namespaceSymbol);

        internal abstract CommonAnonymousTypeManager CommonAnonymousTypeManager { get; }

        public IMethodSymbol? GetEntryPoint(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 34722, 34876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 34819, 34865);

                return f_145_34826_34864(this, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 34722, 34876);

                Microsoft.CodeAnalysis.IMethodSymbol?
                f_145_34826_34864(Microsoft.CodeAnalysis.Compilation
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.CommonGetEntryPoint(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 34826, 34864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 34722, 34876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 34722, 34876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract IMethodSymbol? CommonGetEntryPoint(CancellationToken cancellationToken);

        public INamedTypeSymbol GetSpecialType(SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 35156, 35331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 35244, 35320);

                return (INamedTypeSymbol)f_145_35269_35319(f_145_35269_35302(this, specialType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 35156, 35331);

                Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
                f_145_35269_35302(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.CommonGetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 35269, 35302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_145_35269_35319(Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
                this_param)
                {
                    var return_v = this_param.GetITypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 35269, 35319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 35156, 35331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 35156, 35331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract ISymbolInternal CommonGetSpecialTypeMember(SpecialMember specialMember);

        internal abstract bool IsSystemTypeReference(ITypeSymbolInternal type);

        private protected abstract INamedTypeSymbolInternal CommonGetSpecialType(SpecialType specialType);

        internal abstract ISymbolInternal? CommonGetWellKnownTypeMember(WellKnownMember member);

        internal abstract ITypeSymbolInternal CommonGetWellKnownType(WellKnownType wellknownType);

        internal abstract bool IsAttributeType(ITypeSymbol type);

        public INamedTypeSymbol ObjectType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 36816, 36848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 36822, 36846);

                    return f_145_36829_36845();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 36816, 36848);

                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_145_36829_36845()
                    {
                        var return_v = CommonObjectType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 36829, 36845);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 36779, 36850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 36779, 36850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract INamedTypeSymbol CommonObjectType { get; }

        public ITypeSymbol DynamicType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 37199, 37232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 37205, 37230);

                    return f_145_37212_37229();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 37199, 37232);

                    Microsoft.CodeAnalysis.ITypeSymbol
                    f_145_37212_37229()
                    {
                        var return_v = CommonDynamicType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 37212, 37229);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 37166, 37234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 37166, 37234);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract ITypeSymbol CommonDynamicType { get; }

        internal ITypeSymbol? ScriptGlobalsType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 37460, 37486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 37463, 37486);
                    return f_145_37463_37486(); DynAbs.Tracing.TraceSender.TraceExitMethod(145, 37460, 37486);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 37460, 37486);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 37460, 37486);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract ITypeSymbol? CommonScriptGlobalsType { get; }

        public INamedTypeSymbol? ScriptClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 37795, 37828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 37801, 37826);

                    return f_145_37808_37825();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 37795, 37828);

                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_145_37808_37825()
                    {
                        var return_v = CommonScriptClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 37808, 37825);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 37756, 37830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 37756, 37830);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract INamedTypeSymbol? CommonScriptClass { get; }

        protected INamedTypeSymbol? CommonBindScriptClass()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 38262, 39226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38338, 38398);

                string
                scriptClassName = f_145_38363_38391(f_145_38363_38375(this)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(145, 38363, 38397) ?? "")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38414, 38458);

                string[]
                parts = f_145_38431_38457(scriptClassName, '.')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38472, 38535);

                INamespaceSymbol
                container = f_145_38501_38534(f_145_38501_38518(this))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38560, 38565);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38551, 38893) || true) && (i < f_145_38571_38583(parts) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38589, 38592)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(145, 38551, 38893))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 38551, 38893);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38626, 38690);

                        INamespaceSymbol?
                        next = f_145_38651_38689(container, parts[i])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38708, 38841) || true) && (next == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 38708, 38841);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38766, 38788);

                            f_145_38766_38787(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38810, 38822);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 38708, 38841);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38861, 38878);

                        container = next;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 343);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 38909, 39151);
                    foreach (INamedTypeSymbol candidate in f_145_38948_38997_I(f_145_38948_38997(container, parts[f_145_38979_38991(parts) - 1])))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 38909, 39151);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 39031, 39136) || true) && (f_145_39035_39058(candidate))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 39031, 39136);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 39100, 39117);

                            return candidate;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 39031, 39136);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 38909, 39151);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 39167, 39189);

                f_145_39167_39188(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 39203, 39215);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 38262, 39226);

                Microsoft.CodeAnalysis.CompilationOptions
                f_145_38363_38375(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 38363, 38375);
                    return return_v;
                }


                string?
                f_145_38363_38391(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ScriptClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 38363, 38391);
                    return return_v;
                }


                string[]
                f_145_38431_38457(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 38431, 38457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IModuleSymbol
                f_145_38501_38518(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 38501, 38518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol
                f_145_38501_38534(Microsoft.CodeAnalysis.IModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 38501, 38534);
                    return return_v;
                }


                int
                f_145_38571_38583(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 38571, 38583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_145_38651_38689(Microsoft.CodeAnalysis.INamespaceSymbol
                container, string
                name)
                {
                    var return_v = container.GetNestedNamespace(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 38651, 38689);
                    return return_v;
                }


                int
                f_145_38766_38787(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    this_param.AssertNoScriptTrees();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 38766, 38787);
                    return 0;
                }


                int
                f_145_38979_38991(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 38979, 38991);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_145_38948_38997(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 38948, 38997);
                    return return_v;
                }


                bool
                f_145_39035_39058(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 39035, 39058);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_145_38948_38997_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 38948, 38997);
                    return return_v;
                }


                int
                f_145_39167_39188(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    this_param.AssertNoScriptTrees();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 39167, 39188);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 38262, 39226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 38262, 39226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        private void AssertNoScriptTrees()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 39238, 39483);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 39329, 39472);
                    foreach (var tree in f_145_39350_39366_I(f_145_39350_39366(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 39329, 39472);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 39400, 39457);

                        f_145_39400_39456(f_145_39413_39430(f_145_39413_39425(tree)) != SourceCodeKind.Script);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 39329, 39472);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 144);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 39238, 39483);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_145_39350_39366(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 39350, 39366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_145_39413_39425(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 39413, 39425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_145_39413_39430(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 39413, 39430);
                    return return_v;
                }


                int
                f_145_39400_39456(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 39400, 39456);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_145_39350_39366_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 39350, 39366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 39238, 39483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 39238, 39483);
            }
        }

        public IArrayTypeSymbol CreateArrayTypeSymbol(ITypeSymbol elementType, int rank = 1, NullableAnnotation elementNullableAnnotation = NullableAnnotation.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 39688, 39961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 39869, 39950);

                return f_145_39876_39949(this, elementType, rank, elementNullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 39688, 39961);

                Microsoft.CodeAnalysis.IArrayTypeSymbol
                f_145_39876_39949(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                elementType, int
                rank, Microsoft.CodeAnalysis.NullableAnnotation
                elementNullableAnnotation)
                {
                    var return_v = this_param.CommonCreateArrayTypeSymbol(elementType, rank, elementNullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 39876, 39949);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 39688, 39961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 39688, 39961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IArrayTypeSymbol CreateArrayTypeSymbol(ITypeSymbol elementType, int rank)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 40259, 40459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 40364, 40448);

                return f_145_40371_40447(this, elementType, rank, elementNullableAnnotation: default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 40259, 40459);

                Microsoft.CodeAnalysis.IArrayTypeSymbol
                f_145_40371_40447(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                elementType, int
                rank, Microsoft.CodeAnalysis.NullableAnnotation
                elementNullableAnnotation)
                {
                    var return_v = this_param.CreateArrayTypeSymbol(elementType, rank, elementNullableAnnotation: elementNullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 40371, 40447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 40259, 40459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 40259, 40459);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract IArrayTypeSymbol CommonCreateArrayTypeSymbol(ITypeSymbol elementType, int rank, NullableAnnotation elementNullableAnnotation);

        public IPointerTypeSymbol CreatePointerTypeSymbol(ITypeSymbol pointedAtType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 40912, 41076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 41013, 41065);

                return f_145_41020_41064(this, pointedAtType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 40912, 41076);

                Microsoft.CodeAnalysis.IPointerTypeSymbol
                f_145_41020_41064(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                elementType)
                {
                    var return_v = this_param.CommonCreatePointerTypeSymbol(elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 41020, 41064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 40912, 41076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 40912, 41076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract IPointerTypeSymbol CommonCreatePointerTypeSymbol(ITypeSymbol elementType);

        public IFunctionPointerTypeSymbol CreateFunctionPointerTypeSymbol(
                    ITypeSymbol returnType,
                    RefKind returnRefKind,
                    ImmutableArray<ITypeSymbol> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds,
                    SignatureCallingConvention callingConvention = SignatureCallingConvention.Default,
                    ImmutableArray<INamedTypeSymbol> callingConventionTypes = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 41983, 42597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 42436, 42586);

                return f_145_42443_42585(this, returnType, returnRefKind, parameterTypes, parameterRefKinds, callingConvention, callingConventionTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 41983, 42597);

                Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
                f_145_42443_42585(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                returnType, Microsoft.CodeAnalysis.RefKind
                returnRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds, System.Reflection.Metadata.SignatureCallingConvention
                callingConvention, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                callingConventionTypes)
                {
                    var return_v = this_param.CommonCreateFunctionPointerTypeSymbol(returnType, returnRefKind, parameterTypes, parameterRefKinds, callingConvention, callingConventionTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 42443, 42585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 41983, 42597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 41983, 42597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract IFunctionPointerTypeSymbol CommonCreateFunctionPointerTypeSymbol(
                    ITypeSymbol returnType,
                    RefKind returnRefKind,
                    ImmutableArray<ITypeSymbol> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds,
                    SignatureCallingConvention callingConvention,
                    ImmutableArray<INamedTypeSymbol> callingConventionTypes);

        public INamedTypeSymbol CreateNativeIntegerTypeSymbol(bool signed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 43257, 43410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 43348, 43399);

                return f_145_43355_43398(this, signed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 43257, 43410);

                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_145_43355_43398(Microsoft.CodeAnalysis.Compilation
                this_param, bool
                signed)
                {
                    var return_v = this_param.CommonCreateNativeIntegerTypeSymbol(signed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 43355, 43398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 43257, 43410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 43257, 43410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract INamedTypeSymbol CommonCreateNativeIntegerTypeSymbol(bool signed);

        private readonly ConcurrentCache<string, INamedTypeSymbol?> _getTypeCache;

        public INamedTypeSymbol? GetTypeByMetadataName(string fullyQualifiedMetadataName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 44770, 45253);
                Microsoft.CodeAnalysis.INamedTypeSymbol? val = default(Microsoft.CodeAnalysis.INamedTypeSymbol?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 44876, 45217) || true) && (!f_145_44881_44961(_getTypeCache, fullyQualifiedMetadataName, out val))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 44876, 45217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 44995, 45057);

                    val = f_145_45001_45056(this, fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 45144, 45202);

                    _ = f_145_45148_45201(_getTypeCache, fullyQualifiedMetadataName, val);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 44876, 45217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 45231, 45242);

                return val;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 44770, 45253);

                bool
                f_145_44881_44961(Microsoft.CodeAnalysis.ConcurrentCache<string, Microsoft.CodeAnalysis.INamedTypeSymbol?>
                this_param, string
                key, out Microsoft.CodeAnalysis.INamedTypeSymbol?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 44881, 44961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_145_45001_45056(Microsoft.CodeAnalysis.Compilation
                this_param, string
                metadataName)
                {
                    var return_v = this_param.CommonGetTypeByMetadataName(metadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 45001, 45056);
                    return return_v;
                }


                bool
                f_145_45148_45201(Microsoft.CodeAnalysis.ConcurrentCache<string, Microsoft.CodeAnalysis.INamedTypeSymbol?>
                this_param, string
                key, Microsoft.CodeAnalysis.INamedTypeSymbol?
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 45148, 45201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 44770, 45253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 44770, 45253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract INamedTypeSymbol? CommonGetTypeByMetadataName(string metadataName);

        public INamedTypeSymbol CreateTupleTypeSymbol(
                    ImmutableArray<ITypeSymbol> elementTypes,
                    ImmutableArray<string?> elementNames = default,
                    ImmutableArray<Location?> elementLocations = default,
                    ImmutableArray<NullableAnnotation> elementNullableAnnotations = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 45660, 47171);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46000, 46129) || true) && (elementTypes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 46000, 46129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46060, 46114);

                    throw f_145_46066_46113(nameof(elementTypes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 46000, 46129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46145, 46173);

                int
                n = elementTypes.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46187, 46366) || true) && (elementTypes.Length <= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 46187, 46366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46249, 46351);

                    throw f_145_46255_46350(f_145_46277_46327(), nameof(elementNames));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 46187, 46366);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46382, 46437);

                elementNames = f_145_46397_46436(n, elementNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46451, 46499);

                f_145_46451_46498(n, elementLocations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46513, 46581);

                f_145_46513_46580(n, elementNullableAnnotations);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46606, 46611);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46597, 47035) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46620, 46623)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(145, 46597, 47035))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 46597, 47035);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46657, 46809) || true) && (elementTypes[i] == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 46657, 46809);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46726, 46790);

                            throw f_145_46732_46789($"{nameof(elementTypes)}[{i}]");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 46657, 46809);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46829, 47020) || true) && (f_145_46833_46860_M(!elementLocations.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(145, 46833, 46891) && elementLocations[i] == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 46829, 47020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 46933, 47001);

                            throw f_145_46939_47000($"{nameof(elementLocations)}[{i}]");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 46829, 47020);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 47051, 47160);

                return f_145_47058_47159(this, elementTypes, elementNames, elementLocations, elementNullableAnnotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 45660, 47171);

                System.ArgumentNullException
                f_145_46066_46113(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 46066, 46113);
                    return return_v;
                }


                string
                f_145_46277_46327()
                {
                    var return_v = CodeAnalysisResources.TuplesNeedAtLeastTwoElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 46277, 46327);
                    return return_v;
                }


                System.ArgumentException
                f_145_46255_46350(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 46255, 46350);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_145_46397_46436(int
                cardinality, System.Collections.Immutable.ImmutableArray<string?>
                elementNames)
                {
                    var return_v = CheckTupleElementNames(cardinality, elementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 46397, 46436);
                    return return_v;
                }


                int
                f_145_46451_46498(int
                cardinality, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations)
                {
                    CheckTupleElementLocations(cardinality, elementLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 46451, 46498);
                    return 0;
                }


                int
                f_145_46513_46580(int
                cardinality, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
                elementNullableAnnotations)
                {
                    CheckTupleElementNullableAnnotations(cardinality, elementNullableAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 46513, 46580);
                    return 0;
                }


                System.ArgumentNullException
                f_145_46732_46789(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 46732, 46789);
                    return return_v;
                }


                bool
                f_145_46833_46860_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 46833, 46860);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_46939_47000(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 46939, 47000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_145_47058_47159(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                elementTypes, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
                elementNullableAnnotations)
                {
                    var return_v = this_param.CommonCreateTupleTypeSymbol(elementTypes, elementNames, elementLocations, elementNullableAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 47058, 47159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 45660, 47171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 45660, 47171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public INamedTypeSymbol CreateTupleTypeSymbol(
                    ImmutableArray<ITypeSymbol> elementTypes,
                    ImmutableArray<string?> elementNames,
                    ImmutableArray<Location?> elementLocations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 47516, 47873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 47750, 47862);

                return f_145_47757_47861(this, elementTypes, elementNames, elementLocations, elementNullableAnnotations: default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 47516, 47873);

                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_145_47757_47861(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                elementTypes, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
                elementNullableAnnotations)
                {
                    var return_v = this_param.CreateTupleTypeSymbol(elementTypes, elementNames, elementLocations, elementNullableAnnotations: elementNullableAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 47757, 47861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 47516, 47873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 47516, 47873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static void CheckTupleElementNullableAnnotations(
                    int cardinality,
                    ImmutableArray<NullableAnnotation> elementNullableAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 47885, 48420);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 48075, 48409) || true) && (f_145_48079_48116_M(!elementNullableAnnotations.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 48075, 48409);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 48150, 48394) || true) && (elementNullableAnnotations.Length != cardinality)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 48150, 48394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 48244, 48375);

                        throw f_145_48250_48374(f_145_48272_48337(), nameof(elementNullableAnnotations));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 48150, 48394);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 48075, 48409);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 47885, 48420);

                bool
                f_145_48079_48116_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 48079, 48116);
                    return return_v;
                }


                string
                f_145_48272_48337()
                {
                    var return_v = CodeAnalysisResources.TupleElementNullableAnnotationCountMismatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 48272, 48337);
                    return return_v;
                }


                System.ArgumentException
                f_145_48250_48374(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 48250, 48374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 47885, 48420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 47885, 48420);
            }
        }

        protected static ImmutableArray<string?> CheckTupleElementNames(int cardinality, ImmutableArray<string?> elementNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 48685, 49613);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 48828, 49566) || true) && (f_145_48832_48855_M(!elementNames.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 48828, 49566);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 48889, 49091) || true) && (elementNames.Length != cardinality)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 48889, 49091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 48969, 49072);

                        throw f_145_48975_49071(f_145_48997_49048(), nameof(elementNames));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 48889, 49091);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49120, 49125);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49111, 49419) || true) && (i < elementNames.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49152, 49155)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(145, 49111, 49419))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 49111, 49419);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49197, 49400) || true) && (elementNames[i] == "")
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 49197, 49400);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49272, 49377);

                                throw f_145_49278_49376(f_145_49300_49343(), $"{nameof(elementNames)}[{i}]");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 49197, 49400);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 309);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 309);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49439, 49551) || true) && (elementNames.All(n => n == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 49439, 49551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49517, 49532);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 49439, 49551);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 48828, 49566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49582, 49602);

                return elementNames;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 48685, 49613);

                bool
                f_145_48832_48855_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 48832, 48855);
                    return return_v;
                }


                string
                f_145_48997_49048()
                {
                    var return_v = CodeAnalysisResources.TupleElementNameCountMismatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 48997, 49048);
                    return return_v;
                }


                System.ArgumentException
                f_145_48975_49071(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 48975, 49071);
                    return return_v;
                }


                string
                f_145_49300_49343()
                {
                    var return_v = CodeAnalysisResources.TupleElementNameEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 49300, 49343);
                    return return_v;
                }


                System.ArgumentException
                f_145_49278_49376(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 49278, 49376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 48685, 49613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 48685, 49613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static void CheckTupleElementLocations(
                    int cardinality,
                    ImmutableArray<Location?> elementLocations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 49625, 50091);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49786, 50080) || true) && (f_145_49790_49817_M(!elementLocations.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 49786, 50080);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49851, 50065) || true) && (elementLocations.Length != cardinality)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 49851, 50065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 49935, 50046);

                        throw f_145_49941_50045(f_145_49963_50018(), nameof(elementLocations));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 49851, 50065);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 49786, 50080);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 49625, 50091);

                bool
                f_145_49790_49817_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 49790, 49817);
                    return return_v;
                }


                string
                f_145_49963_50018()
                {
                    var return_v = CodeAnalysisResources.TupleElementLocationCountMismatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 49963, 50018);
                    return return_v;
                }


                System.ArgumentException
                f_145_49941_50045(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 49941, 50045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 49625, 50091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 49625, 50091);
            }
        }

        protected abstract INamedTypeSymbol CommonCreateTupleTypeSymbol(
                    ImmutableArray<ITypeSymbol> elementTypes,
                    ImmutableArray<string?> elementNames,
                    ImmutableArray<Location?> elementLocations,
                    ImmutableArray<NullableAnnotation> elementNullableAnnotations);

        public INamedTypeSymbol CreateTupleTypeSymbol(
                    INamedTypeSymbol underlyingType,
                    ImmutableArray<string?> elementNames = default,
                    ImmutableArray<Location?> elementLocations = default,
                    ImmutableArray<NullableAnnotation> elementNullableAnnotations = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 50781, 51389);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 51112, 51251) || true) && ((object)underlyingType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 51112, 51251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 51180, 51236);

                    throw f_145_51186_51235(nameof(underlyingType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 51112, 51251);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 51267, 51378);

                return f_145_51274_51377(this, underlyingType, elementNames, elementLocations, elementNullableAnnotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 50781, 51389);

                System.ArgumentNullException
                f_145_51186_51235(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 51186, 51235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_145_51274_51377(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                underlyingType, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
                elementNullableAnnotations)
                {
                    var return_v = this_param.CommonCreateTupleTypeSymbol(underlyingType, elementNames, elementLocations, elementNullableAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 51274, 51377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 50781, 51389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 50781, 51389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public INamedTypeSymbol CreateTupleTypeSymbol(
                    INamedTypeSymbol underlyingType,
                    ImmutableArray<string?> elementNames,
                    ImmutableArray<Location?> elementLocations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 51809, 52159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 52034, 52148);

                return f_145_52041_52147(this, underlyingType, elementNames, elementLocations, elementNullableAnnotations: default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 51809, 52159);

                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_145_52041_52147(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                underlyingType, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
                elementNullableAnnotations)
                {
                    var return_v = this_param.CreateTupleTypeSymbol(underlyingType, elementNames, elementLocations, elementNullableAnnotations: elementNullableAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 52041, 52147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 51809, 52159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 51809, 52159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract INamedTypeSymbol CommonCreateTupleTypeSymbol(
                    INamedTypeSymbol underlyingType,
                    ImmutableArray<string?> elementNames,
                    ImmutableArray<Location?> elementLocations,
                    ImmutableArray<NullableAnnotation> elementNullableAnnotations);

        public INamedTypeSymbol CreateAnonymousTypeSymbol(
                    ImmutableArray<ITypeSymbol> memberTypes,
                    ImmutableArray<string> memberNames,
                    ImmutableArray<bool> memberIsReadOnly = default,
                    ImmutableArray<Location> memberLocations = default,
                    ImmutableArray<NullableAnnotation> memberNullableAnnotations = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 52912, 55746);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 53302, 53429) || true) && (memberTypes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 53302, 53429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 53361, 53414);

                    throw f_145_53367_53413(nameof(memberTypes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 53302, 53429);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 53445, 53572) || true) && (memberNames.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 53445, 53572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 53504, 53557);

                    throw f_145_53510_53556(nameof(memberNames));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 53445, 53572);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 53588, 53884) || true) && (memberTypes.Length != memberNames.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 53588, 53884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 53666, 53869);

                    throw f_145_53672_53868(f_145_53694_53867(f_145_53708_53771(), nameof(memberTypes), nameof(memberNames)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 53588, 53884);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 53900, 54228) || true) && (f_145_53904_53930_M(!memberLocations.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(145, 53904, 53978) && memberLocations.Length != memberTypes.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 53900, 54228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 54012, 54213);

                    throw f_145_54018_54212(f_145_54040_54211(f_145_54054_54111(), nameof(memberLocations), nameof(memberNames)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 53900, 54228);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 54244, 54575) || true) && (f_145_54248_54275_M(!memberIsReadOnly.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(145, 54248, 54324) && memberIsReadOnly.Length != memberTypes.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 54244, 54575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 54358, 54560);

                    throw f_145_54364_54559(f_145_54386_54558(f_145_54400_54457(), nameof(memberIsReadOnly), nameof(memberNames)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 54244, 54575);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 54591, 54949) || true) && (f_145_54595_54631_M(!memberNullableAnnotations.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(145, 54595, 54689) && memberNullableAnnotations.Length != memberTypes.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 54591, 54949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 54723, 54934);

                    throw f_145_54729_54933(f_145_54751_54932(f_145_54765_54822(), nameof(memberNullableAnnotations), nameof(memberNames)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 54591, 54949);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 54974, 54979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 54981, 55003);

                    for (int
        i = 0
        ,
        n = memberTypes.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 54965, 55592) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 55012, 55015)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(145, 54965, 55592))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 54965, 55592);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 55049, 55199) || true) && (memberTypes[i] == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 55049, 55199);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 55117, 55180);

                            throw f_145_55123_55179($"{nameof(memberTypes)}[{i}]");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 55049, 55199);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 55219, 55369) || true) && (memberNames[i] == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 55219, 55369);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 55287, 55350);

                            throw f_145_55293_55349($"{nameof(memberNames)}[{i}]");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 55219, 55369);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 55389, 55577) || true) && (f_145_55393_55419_M(!memberLocations.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(145, 55393, 55449) && memberLocations[i] == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 55389, 55577);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 55491, 55558);

                            throw f_145_55497_55557($"{nameof(memberLocations)}[{i}]");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 55389, 55577);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 628);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 55608, 55735);

                return f_145_55615_55734(this, memberTypes, memberNames, memberLocations, memberIsReadOnly, memberNullableAnnotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 52912, 55746);

                System.ArgumentNullException
                f_145_53367_53413(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 53367, 53413);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_53510_53556(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 53510, 53556);
                    return return_v;
                }


                string
                f_145_53708_53771()
                {
                    var return_v = CodeAnalysisResources.AnonymousTypeMemberAndNamesCountMismatch2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 53708, 53771);
                    return return_v;
                }


                string
                f_145_53694_53867(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 53694, 53867);
                    return return_v;
                }


                System.ArgumentException
                f_145_53672_53868(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 53672, 53868);
                    return return_v;
                }


                bool
                f_145_53904_53930_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 53904, 53930);
                    return return_v;
                }


                string
                f_145_54054_54111()
                {
                    var return_v = CodeAnalysisResources.AnonymousTypeArgumentCountMismatch2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 54054, 54111);
                    return return_v;
                }


                string
                f_145_54040_54211(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 54040, 54211);
                    return return_v;
                }


                System.ArgumentException
                f_145_54018_54212(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 54018, 54212);
                    return return_v;
                }


                bool
                f_145_54248_54275_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 54248, 54275);
                    return return_v;
                }


                string
                f_145_54400_54457()
                {
                    var return_v = CodeAnalysisResources.AnonymousTypeArgumentCountMismatch2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 54400, 54457);
                    return return_v;
                }


                string
                f_145_54386_54558(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 54386, 54558);
                    return return_v;
                }


                System.ArgumentException
                f_145_54364_54559(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 54364, 54559);
                    return return_v;
                }


                bool
                f_145_54595_54631_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 54595, 54631);
                    return return_v;
                }


                string
                f_145_54765_54822()
                {
                    var return_v = CodeAnalysisResources.AnonymousTypeArgumentCountMismatch2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 54765, 54822);
                    return return_v;
                }


                string
                f_145_54751_54932(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 54751, 54932);
                    return return_v;
                }


                System.ArgumentException
                f_145_54729_54933(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 54729, 54933);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_55123_55179(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 55123, 55179);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_55293_55349(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 55293, 55349);
                    return return_v;
                }


                bool
                f_145_55393_55419_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 55393, 55419);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_55497_55557(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 55497, 55557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_145_55615_55734(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                memberTypes, System.Collections.Immutable.ImmutableArray<string>
                memberNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                memberLocations, System.Collections.Immutable.ImmutableArray<bool>
                memberIsReadOnly, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
                memberNullableAnnotations)
                {
                    var return_v = this_param.CommonCreateAnonymousTypeSymbol(memberTypes, memberNames, memberLocations, memberIsReadOnly, memberNullableAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 55615, 55734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 52912, 55746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 52912, 55746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public INamedTypeSymbol CreateAnonymousTypeSymbol(
                    ImmutableArray<ITypeSymbol> memberTypes,
                    ImmutableArray<string> memberNames,
                    ImmutableArray<bool> memberIsReadOnly,
                    ImmutableArray<Location> memberLocations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 56263, 56689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 56548, 56678);

                return f_145_56555_56677(this, memberTypes, memberNames, memberIsReadOnly, memberLocations, memberNullableAnnotations: default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 56263, 56689);

                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_145_56555_56677(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                memberTypes, System.Collections.Immutable.ImmutableArray<string>
                memberNames, System.Collections.Immutable.ImmutableArray<bool>
                memberIsReadOnly, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                memberLocations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
                memberNullableAnnotations)
                {
                    var return_v = this_param.CreateAnonymousTypeSymbol(memberTypes, memberNames, memberIsReadOnly, memberLocations, memberNullableAnnotations: memberNullableAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 56555, 56677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 56263, 56689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 56263, 56689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract INamedTypeSymbol CommonCreateAnonymousTypeSymbol(
                    ImmutableArray<ITypeSymbol> memberTypes,
                    ImmutableArray<string> memberNames,
                    ImmutableArray<Location> memberLocations,
                    ImmutableArray<bool> memberIsReadOnly,
                    ImmutableArray<NullableAnnotation> memberNullableAnnotations);

        public abstract CommonConversion ClassifyCommonConversion(ITypeSymbol source, ITypeSymbol destination);

        public bool HasImplicitConversion(ITypeSymbol? fromType, ITypeSymbol? toType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 58205, 58304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 58208, 58304);
                return fromType != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 58208, 58242) && toType != null) && (DynAbs.Tracing.TraceSender.Expression_True(145, 58208, 58304) && f_145_58246_58293(this, fromType, toType).IsImplicit); DynAbs.Tracing.TraceSender.TraceExitMethod(145, 58205, 58304);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 58205, 58304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 58205, 58304);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Operations.CommonConversion
            f_145_58246_58293(Microsoft.CodeAnalysis.Compilation
            this_param, Microsoft.CodeAnalysis.ITypeSymbol
            source, Microsoft.CodeAnalysis.ITypeSymbol
            destination)
            {
                var return_v = this_param.ClassifyCommonConversion(source, destination);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 58246, 58293);
                return return_v;
            }

        }

        public bool IsSymbolAccessibleWithin(
                    ISymbol symbol,
                    ISymbol within,
                    ITypeSymbol? throughType = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 59836, 65210);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60002, 60117) || true) && (symbol is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 60002, 60117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60054, 60102);

                    throw f_145_60060_60101(nameof(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 60002, 60117);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60133, 60248) || true) && (within is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 60133, 60248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60185, 60233);

                    throw f_145_60191_60232(nameof(within));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 60133, 60248);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60264, 60501) || true) && (!(within is INamedTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(145, 60270, 60325) || within is IAssemblySymbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 60264, 60501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60360, 60486);

                    throw f_145_60366_60485(f_145_60388_60468(f_145_60402_60451(), nameof(within)), nameof(within));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 60264, 60501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60517, 60570);

                f_145_60517_60569(symbol, nameof(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60584, 60637);

                f_145_60584_60636(within, nameof(within));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60651, 60788) || true) && (throughType is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 60651, 60788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60710, 60773);

                    f_145_60710_60772(throughType, nameof(throughType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 60651, 60788);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60804, 60869);

                return f_145_60811_60868(this, symbol, within, throughType);

                void checkInCompilationReferences(ISymbol s, string parameterName)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 60885, 61228);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 60984, 61213) || true) && (!f_145_60989_61024(s))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 60984, 61213);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 61066, 61194);

                            throw f_145_61072_61193(f_145_61094_61177(f_145_61108_61161(), parameterName), parameterName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 60984, 61213);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(145, 60885, 61228);

                        bool
                        f_145_60989_61024(Microsoft.CodeAnalysis.ISymbol
                        s)
                        {
                            var return_v = isContainingAssemblyInReferences(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 60989, 61024);
                            return return_v;
                        }


                        string
                        f_145_61108_61161()
                        {
                            var return_v = CodeAnalysisResources.IsSymbolAccessibleWrongAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 61108, 61161);
                            return return_v;
                        }


                        string
                        f_145_61094_61177(string
                        format, string
                        arg0)
                        {
                            var return_v = string.Format(format, (object)arg0);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 61094, 61177);
                            return return_v;
                        }


                        System.ArgumentException
                        f_145_61072_61193(string
                        message, string
                        paramName)
                        {
                            var return_v = new System.ArgumentException(message, paramName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 61072, 61193);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 60885, 61228);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 60885, 61228);
                    }
                }

                bool assemblyIsInReferences(IAssemblySymbol a)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 61244, 62243);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 61323, 61442) || true) && (f_145_61327_61369(a, this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 61323, 61442);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 61411, 61423);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 61323, 61442);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 61462, 62195) || true) && (f_145_61466_61483(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 61462, 62195);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 61899, 61926);
                                // Submissions can reference symbols from previous submissions and their referenced assemblies, even
                                // though those references are missing from this.References. We work around that by digging in
                                // to find references of previous submissions. See https://github.com/dotnet/roslyn/issues/27356
                                for (Compilation?
            c = f_145_61903_61926(this)
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 61881, 62176) || true) && (c != null)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 61939, 61963)
            , c = f_145_61943_61963(c), DynAbs.Tracing.TraceSender.TraceExitCondition(145, 61881, 62176))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 61881, 62176);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62013, 62153) || true) && (f_145_62017_62056(a, c))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62013, 62153);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62114, 62126);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62013, 62153);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 296);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 296);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 61462, 62195);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62215, 62228);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(145, 61244, 62243);

                        bool
                        f_145_61327_61369(Microsoft.CodeAnalysis.IAssemblySymbol
                        a, Microsoft.CodeAnalysis.Compilation
                        compilation)
                        {
                            var return_v = assemblyIsInCompilationReferences(a, compilation);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 61327, 61369);
                            return return_v;
                        }


                        bool
                        f_145_61466_61483(Microsoft.CodeAnalysis.Compilation
                        this_param)
                        {
                            var return_v = this_param.IsSubmission;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 61466, 61483);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Compilation?
                        f_145_61903_61926(Microsoft.CodeAnalysis.Compilation
                        this_param)
                        {
                            var return_v = this_param.PreviousSubmission;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 61903, 61926);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Compilation?
                        f_145_61943_61963(Microsoft.CodeAnalysis.Compilation
                        this_param)
                        {
                            var return_v = this_param.PreviousSubmission;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 61943, 61963);
                            return return_v;
                        }


                        bool
                        f_145_62017_62056(Microsoft.CodeAnalysis.IAssemblySymbol
                        a, Microsoft.CodeAnalysis.Compilation
                        compilation)
                        {
                            var return_v = assemblyIsInCompilationReferences(a, compilation);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 62017, 62056);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 61244, 62243);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 61244, 62243);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool assemblyIsInCompilationReferences(IAssemblySymbol a, Compilation compilation)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 62259, 62805);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62374, 62481) || true) && (f_145_62378_62408(a, f_145_62387_62407(compilation)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62374, 62481);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62450, 62462);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62374, 62481);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62501, 62757);
                            foreach (var reference in f_145_62527_62549_I(f_145_62527_62549(compilation)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62501, 62757);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62591, 62738) || true) && (f_145_62595_62653(a, f_145_62604_62652(compilation, reference)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62591, 62738);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62703, 62715);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62591, 62738);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62501, 62757);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 257);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 257);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62777, 62790);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(145, 62259, 62805);

                        Microsoft.CodeAnalysis.IAssemblySymbol
                        f_145_62387_62407(Microsoft.CodeAnalysis.Compilation
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 62387, 62407);
                            return return_v;
                        }


                        bool
                        f_145_62378_62408(Microsoft.CodeAnalysis.IAssemblySymbol
                        this_param, Microsoft.CodeAnalysis.IAssemblySymbol
                        other)
                        {
                            var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 62378, 62408);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                        f_145_62527_62549(Microsoft.CodeAnalysis.Compilation
                        this_param)
                        {
                            var return_v = this_param.References;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 62527, 62549);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol?
                        f_145_62604_62652(Microsoft.CodeAnalysis.Compilation
                        this_param, Microsoft.CodeAnalysis.MetadataReference
                        reference)
                        {
                            var return_v = this_param.GetAssemblyOrModuleSymbol(reference);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 62604, 62652);
                            return return_v;
                        }


                        bool
                        f_145_62595_62653(Microsoft.CodeAnalysis.IAssemblySymbol
                        this_param, Microsoft.CodeAnalysis.ISymbol?
                        other)
                        {
                            var return_v = this_param.Equals(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 62595, 62653);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                        f_145_62527_62549_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 62527, 62549);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 62259, 62805);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 62259, 62805);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool isContainingAssemblyInReferences(ISymbol s)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 62821, 65199);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62902, 65184) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62902, 65184);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 62955, 65165);

                                switch (f_145_62963_62969(s))
                                {

                                    case SymbolKind.Assembly:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62955, 65165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63074, 63124);

                                        return f_145_63081_63123(s);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62955, 65165);

                                    case SymbolKind.PointerType:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62955, 65165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63208, 63250);

                                        s = f_145_63212_63249(((IPointerTypeSymbol)s));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63280, 63289);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62955, 65165);

                                    case SymbolKind.ArrayType:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62955, 65165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63371, 63409);

                                        s = f_145_63375_63408(((IArrayTypeSymbol)s));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63439, 63448);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62955, 65165);

                                    case SymbolKind.Alias:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62955, 65165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63526, 63555);

                                        s = f_145_63530_63554(((IAliasSymbol)s));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63585, 63594);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62955, 65165);

                                    case SymbolKind.Discard:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62955, 65165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63674, 63703);

                                        s = f_145_63678_63702(((IDiscardSymbol)s));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63733, 63742);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62955, 65165);

                                    case SymbolKind.FunctionPointerType:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62955, 65165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63834, 63878);

                                        var
                                        funcPtr = (IFunctionPointerTypeSymbol)s
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 63908, 64085) || true) && (!f_145_63913_63975(f_145_63946_63974(f_145_63946_63963(funcPtr))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 63908, 64085);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 64041, 64054);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 63908, 64085);
                                        }
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 64117, 64435);
                                            foreach (var param in f_145_64139_64167_I(f_145_64139_64167(f_145_64139_64156(funcPtr))))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 64117, 64435);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 64233, 64404) || true) && (!f_145_64238_64282(f_145_64271_64281(param)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 64233, 64404);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 64356, 64369);

                                                    return false;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 64233, 64404);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 64117, 64435);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 319);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 319);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 64467, 64479);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62955, 65165);

                                    case SymbolKind.DynamicType:
                                    case SymbolKind.ErrorType:
                                    case SymbolKind.Preprocessing:
                                    case SymbolKind.Namespace:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62955, 65165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 64957, 65026);

                                        return f_145_64964_65025(f_145_64987_65007(s) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.IAssemblySymbol>(145, 64987, 65024) ?? f_145_65011_65024(this)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62955, 65165);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 62955, 65165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 65090, 65142);

                                        return f_145_65097_65141(f_145_65120_65140(s));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62955, 65165);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 62902, 65184);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 62902, 65184);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(145, 62902, 65184);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(145, 62821, 65199);

                        Microsoft.CodeAnalysis.SymbolKind
                        f_145_62963_62969(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 62963, 62969);
                            return return_v;
                        }


                        bool
                        f_145_63081_63123(Microsoft.CodeAnalysis.ISymbol
                        a)
                        {
                            var return_v = assemblyIsInReferences((Microsoft.CodeAnalysis.IAssemblySymbol)a);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 63081, 63123);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol
                        f_145_63212_63249(Microsoft.CodeAnalysis.IPointerTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.PointedAtType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 63212, 63249);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol
                        f_145_63375_63408(Microsoft.CodeAnalysis.IArrayTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ElementType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 63375, 63408);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                        f_145_63530_63554(Microsoft.CodeAnalysis.IAliasSymbol
                        this_param)
                        {
                            var return_v = this_param.Target;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 63530, 63554);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol
                        f_145_63678_63702(Microsoft.CodeAnalysis.IDiscardSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 63678, 63702);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IMethodSymbol
                        f_145_63946_63963(Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Signature;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 63946, 63963);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol
                        f_145_63946_63974(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 63946, 63974);
                            return return_v;
                        }


                        bool
                        f_145_63913_63975(Microsoft.CodeAnalysis.ITypeSymbol
                        s)
                        {
                            var return_v = isContainingAssemblyInReferences((Microsoft.CodeAnalysis.ISymbol)s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 63913, 63975);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IMethodSymbol
                        f_145_64139_64156(Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Signature;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 64139, 64156);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                        f_145_64139_64167(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 64139, 64167);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol
                        f_145_64271_64281(Microsoft.CodeAnalysis.IParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 64271, 64281);
                            return return_v;
                        }


                        bool
                        f_145_64238_64282(Microsoft.CodeAnalysis.ITypeSymbol
                        s)
                        {
                            var return_v = isContainingAssemblyInReferences((Microsoft.CodeAnalysis.ISymbol)s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 64238, 64282);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                        f_145_64139_64167_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 64139, 64167);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IAssemblySymbol
                        f_145_64987_65007(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 64987, 65007);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IAssemblySymbol
                        f_145_65011_65024(Microsoft.CodeAnalysis.Compilation
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 65011, 65024);
                            return return_v;
                        }


                        bool
                        f_145_64964_65025(Microsoft.CodeAnalysis.IAssemblySymbol
                        a)
                        {
                            var return_v = assemblyIsInReferences(a);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 64964, 65025);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.IAssemblySymbol
                        f_145_65120_65140(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 65120, 65140);
                            return return_v;
                        }


                        bool
                        f_145_65097_65141(Microsoft.CodeAnalysis.IAssemblySymbol
                        a)
                        {
                            var return_v = assemblyIsInReferences(a);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 65097, 65141);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 62821, 65199);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 62821, 65199);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 59836, 65210);

                System.ArgumentNullException
                f_145_60060_60101(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 60060, 60101);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_60191_60232(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 60191, 60232);
                    return return_v;
                }


                string
                f_145_60402_60451()
                {
                    var return_v = CodeAnalysisResources.IsSymbolAccessibleBadWithin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 60402, 60451);
                    return return_v;
                }


                string
                f_145_60388_60468(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 60388, 60468);
                    return return_v;
                }


                System.ArgumentException
                f_145_60366_60485(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 60366, 60485);
                    return return_v;
                }


                int
                f_145_60517_60569(Microsoft.CodeAnalysis.ISymbol
                s, string
                parameterName)
                {
                    checkInCompilationReferences(s, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 60517, 60569);
                    return 0;
                }


                int
                f_145_60584_60636(Microsoft.CodeAnalysis.ISymbol
                s, string
                parameterName)
                {
                    checkInCompilationReferences(s, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 60584, 60636);
                    return 0;
                }


                int
                f_145_60710_60772(Microsoft.CodeAnalysis.ITypeSymbol
                s, string
                parameterName)
                {
                    checkInCompilationReferences((Microsoft.CodeAnalysis.ISymbol)s, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 60710, 60772);
                    return 0;
                }


                bool
                f_145_60811_60868(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.ISymbol
                within, Microsoft.CodeAnalysis.ITypeSymbol?
                throughType)
                {
                    var return_v = this_param.IsSymbolAccessibleWithinCore(symbol, within, throughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 60811, 60868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 59836, 65210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 59836, 65210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private protected abstract bool IsSymbolAccessibleWithinCore(
                    ISymbol symbol,
                    ISymbol within,
                    ITypeSymbol? throughType);

        internal abstract IConvertibleConversion ClassifyConvertibleConversion(IOperation source, ITypeSymbol destination, out ConstantValue? constantValue);

        internal const CompilationStage
        DefaultDiagnosticsStage = CompilationStage.Compile
        ;

        public abstract ImmutableArray<Diagnostic> GetParseDiagnostics(CancellationToken cancellationToken = default(CancellationToken));

        public abstract ImmutableArray<Diagnostic> GetDeclarationDiagnostics(CancellationToken cancellationToken = default(CancellationToken));

        public abstract ImmutableArray<Diagnostic> GetMethodBodyDiagnostics(CancellationToken cancellationToken = default(CancellationToken));

        public abstract ImmutableArray<Diagnostic> GetDiagnostics(CancellationToken cancellationToken = default(CancellationToken));

        internal abstract void GetDiagnostics(CompilationStage stage, bool includeEarlierStages, DiagnosticBag diagnostics, CancellationToken cancellationToken = default);

        internal void EnsureCompilationEventQueueCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 67106, 67441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 67183, 67222);

                f_145_67183_67221(f_145_67202_67212() != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 67244, 67254);

                lock (f_145_67244_67254())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 67288, 67415) || true) && (f_145_67292_67315_M(!f_145_67293_67303().IsCompleted))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 67288, 67415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 67357, 67396);

                        f_145_67357_67395(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 67288, 67415);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 67106, 67441);

                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>?
                f_145_67202_67212()
                {
                    var return_v = EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 67202, 67212);
                    return return_v;
                }


                int
                f_145_67183_67221(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 67183, 67221);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_145_67244_67254()
                {
                    var return_v = EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 67244, 67254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_145_67293_67303()
                {
                    var return_v = EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 67293, 67303);
                    return return_v;
                }


                bool
                f_145_67292_67315_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 67292, 67315);
                    return return_v;
                }


                int
                f_145_67357_67395(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    this_param.CompleteCompilationEventQueue_NoLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 67357, 67395);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 67106, 67441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 67106, 67441);
            }
        }

        internal void CompleteCompilationEventQueue_NoLock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 67453, 67788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 67530, 67569);

                f_145_67530_67568(f_145_67549_67559() != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 67632, 67691);

                f_145_67632_67690(f_145_67632_67642(), f_145_67654_67689(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 67705, 67738);

                f_145_67705_67737(f_145_67705_67715());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 67752, 67777);

                f_145_67752_67776(f_145_67752_67762());
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 67453, 67788);

                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>?
                f_145_67549_67559()
                {
                    var return_v = EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 67549, 67559);
                    return return_v;
                }


                int
                f_145_67530_67568(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 67530, 67568);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_145_67632_67642()
                {
                    var return_v = EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 67632, 67642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent
                f_145_67654_67689(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 67654, 67689);
                    return return_v;
                }


                bool
                f_145_67632_67690(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent
                value)
                {
                    var return_v = this_param.TryEnqueue((Microsoft.CodeAnalysis.Diagnostics.CompilationEvent)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 67632, 67690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_145_67705_67715()
                {
                    var return_v = EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 67705, 67715);
                    return return_v;
                }


                int
                f_145_67705_67737(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    this_param.PromiseNotToEnqueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 67705, 67737);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_145_67752_67762()
                {
                    var return_v = EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 67752, 67762);
                    return return_v;
                }


                bool
                f_145_67752_67776(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.TryComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 67752, 67776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 67453, 67788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 67453, 67788);
            }
        }

        internal abstract CommonMessageProvider MessageProvider { get; }

        internal bool FilterAndAppendAndFreeDiagnostics(DiagnosticBag accumulator, [DisallowNull] ref DiagnosticBag? incoming, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 68372, 68834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 68552, 68591);

                f_145_68552_68590(incoming is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 68605, 68735);

                bool
                result = f_145_68619_68734(this, accumulator, f_145_68659_68699(incoming), exclude: null, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 68749, 68765);

                f_145_68749_68764(incoming);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 68779, 68795);

                incoming = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 68809, 68823);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 68372, 68834);

                int
                f_145_68552_68590(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 68552, 68590);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_145_68659_68699(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerableWithoutResolution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 68659, 68699);
                    return return_v;
                }


                bool
                f_145_68619_68734(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                accumulator, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                incoming, System.Collections.Generic.HashSet<int>?
                exclude, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.FilterAndAppendDiagnostics(accumulator, incoming, exclude: exclude, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 68619, 68734);
                    return return_v;
                }


                int
                f_145_68749_68764(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 68749, 68764);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 68372, 68834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 68372, 68834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool FilterAndAppendDiagnostics(DiagnosticBag accumulator, IEnumerable<Diagnostic> incoming, HashSet<int>? exclude, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 69140, 70134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69326, 69348);

                bool
                hasError = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69362, 69433);

                bool
                reportSuppressedDiagnostics = f_145_69397_69432(f_145_69397_69404())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69449, 70090);
                    foreach (Diagnostic d in f_145_69474_69482_I(incoming))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 69449, 70090);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69516, 69623) || true) && (f_145_69520_69545_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(exclude, 145, 69520, 69545)?.Contains(f_145_69538_69544(d))) == true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 69516, 69623);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69595, 69604);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 69516, 69623);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69643, 69705);

                        var
                        filtered = f_145_69658_69704(f_145_69658_69665(), d, cancellationToken)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69723, 70029) || true) && (filtered == null || (DynAbs.Tracing.TraceSender.Expression_False(145, 69727, 69823) || (!reportSuppressedDiagnostics && (DynAbs.Tracing.TraceSender.Expression_True(145, 69769, 69822) && f_145_69801_69822(filtered)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 69723, 70029);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69865, 69874);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 69723, 70029);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 69723, 70029);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69916, 70029) || true) && (f_145_69920_69952(filtered))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 69916, 70029);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 69994, 70010);

                                hasError = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 69916, 70029);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 69723, 70029);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 70049, 70075);

                        f_145_70049_70074(
                                        accumulator, filtered);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 69449, 70090);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 70106, 70123);

                return !hasError;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 69140, 70134);

                Microsoft.CodeAnalysis.CompilationOptions
                f_145_69397_69404()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 69397, 69404);
                    return return_v;
                }


                bool
                f_145_69397_69432(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReportSuppressedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 69397, 69432);
                    return return_v;
                }


                int
                f_145_69538_69544(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 69538, 69544);
                    return return_v;
                }


                bool?
                f_145_69520_69545_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 69520, 69545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_69658_69665()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 69658, 69665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic?
                f_145_69658_69704(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.FilterDiagnostic(diagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 69658, 69704);
                    return return_v;
                }


                bool
                f_145_69801_69822(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 69801, 69822);
                    return return_v;
                }


                bool
                f_145_69920_69952(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsUnsuppressableError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 69920, 69952);
                    return return_v;
                }


                int
                f_145_70049_70074(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 70049, 70074);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_145_69474_69482_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 69474, 69482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 69140, 70134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 69140, 70134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Stream CreateDefaultWin32Resources(bool versionResource, bool noManifest, Stream? manifestContents, Stream? iconInIcoFormat)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 70310, 72295);
                //Win32 resource encodings use a lot of 16bit values. Do all of the math checked with the
                //expectation that integer types are well-chosen with size in mind.
                checked
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 70690, 70726);

                    var
                    result = f_145_70703_70725(1024)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 70812, 70839);

                    f_145_70812_70838(result);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 70859, 70938) || true) && (versionResource)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 70859, 70938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 70901, 70938);

                        f_145_70901_70937(this, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 70859, 70938);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 70958, 72012) || true) && (!noManifest)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 70958, 72012);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 71015, 71744) || true) && (f_145_71019_71058(f_145_71019_71042(f_145_71019_71031(this))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 71015, 71744);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 71197, 71456) || true) && (manifestContents == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 71197, 71456);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 71283, 71429);

                                manifestContents = f_145_71302_71428(f_145_71302_71344(f_145_71302_71335(typeof(Compilation))), "Microsoft.CodeAnalysis.Resources.default.win32manifest");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 71197, 71456);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 71015, 71744);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 71015, 71744);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 71015, 71744);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 71768, 71993) || true) && (manifestContents != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 71768, 71993);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 71846, 71970);

                            f_145_71846_71969(result, manifestContents, !f_145_71929_71968(f_145_71929_71952(f_145_71929_71941(this))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 71768, 71993);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 70958, 72012);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72032, 72197) || true) && (iconInIcoFormat != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 72032, 72197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72101, 72178);

                        f_145_72101_72177(result, iconInIcoFormat);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 72032, 72197);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72217, 72237);

                    result.Position = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72255, 72269);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 70310, 72295);

                System.IO.MemoryStream
                f_145_70703_70725(int
                capacity)
                {
                    var return_v = new System.IO.MemoryStream(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 70703, 70725);
                    return return_v;
                }


                int
                f_145_70812_70838(System.IO.MemoryStream
                resourceStream)
                {
                    AppendNullResource((System.IO.Stream)resourceStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 70812, 70838);
                    return 0;
                }


                int
                f_145_70901_70937(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.MemoryStream
                resourceStream)
                {
                    this_param.AppendDefaultVersionResource((System.IO.Stream)resourceStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 70901, 70937);
                    return 0;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_71019_71031(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 71019, 71031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_71019_71042(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 71019, 71042);
                    return return_v;
                }


                bool
                f_145_71019_71058(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 71019, 71058);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_145_71302_71335(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 71302, 71335);
                    return return_v;
                }


                System.Reflection.Assembly
                f_145_71302_71344(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 71302, 71344);
                    return return_v;
                }


                System.IO.Stream?
                f_145_71302_71428(System.Reflection.Assembly
                this_param, string
                name)
                {
                    var return_v = this_param.GetManifestResourceStream(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 71302, 71428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_71929_71941(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 71929, 71941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_71929_71952(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 71929, 71952);
                    return return_v;
                }


                bool
                f_145_71929_71968(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 71929, 71968);
                    return return_v;
                }


                int
                f_145_71846_71969(System.IO.MemoryStream
                resStream, System.IO.Stream
                manifestStream, bool
                isDll)
                {
                    Win32ResourceConversions.AppendManifestToResourceStream((System.IO.Stream)resStream, manifestStream, isDll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 71846, 71969);
                    return 0;
                }


                int
                f_145_72101_72177(System.IO.MemoryStream
                resStream, System.IO.Stream
                iconStream)
                {
                    Win32ResourceConversions.AppendIconToResourceStream((System.IO.Stream)resStream, iconStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72101, 72177);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 70310, 72295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 70310, 72295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void AppendNullResource(Stream resourceStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 72307, 73006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72394, 72440);

                var
                writer = f_145_72407_72439(resourceStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72454, 72478);

                f_145_72454_72477(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72492, 72519);

                f_145_72492_72518(writer, 0x20);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72533, 72562);

                f_145_72533_72561(writer, 0xFFFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72576, 72600);

                f_145_72576_72599(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72614, 72643);

                f_145_72614_72642(writer, 0xFFFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72657, 72681);

                f_145_72657_72680(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72695, 72719);

                f_145_72695_72718(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72758, 72782);

                f_145_72758_72781(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72821, 72845);

                f_145_72821_72844(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72883, 72907);

                f_145_72883_72906(writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 72942, 72966);

                f_145_72942_72965(writer, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 72307, 73006);

                System.IO.BinaryWriter
                f_145_72407_72439(System.IO.Stream
                output)
                {
                    var return_v = new System.IO.BinaryWriter(output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72407, 72439);
                    return return_v;
                }


                int
                f_145_72454_72477(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72454, 72477);
                    return 0;
                }


                int
                f_145_72492_72518(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72492, 72518);
                    return 0;
                }


                int
                f_145_72533_72561(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72533, 72561);
                    return 0;
                }


                int
                f_145_72576_72599(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72576, 72599);
                    return 0;
                }


                int
                f_145_72614_72642(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72614, 72642);
                    return 0;
                }


                int
                f_145_72657_72680(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72657, 72680);
                    return 0;
                }


                int
                f_145_72695_72718(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72695, 72718);
                    return 0;
                }


                int
                f_145_72758_72781(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72758, 72781);
                    return 0;
                }


                int
                f_145_72821_72844(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72821, 72844);
                    return 0;
                }


                int
                f_145_72883_72906(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72883, 72906);
                    return 0;
                }


                int
                f_145_72942_72965(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 72942, 72965);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 72307, 73006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 72307, 73006);
            }
        }

        protected abstract void AppendDefaultVersionResource(Stream resourceStream);

        internal enum Win32ResourceForm : byte
        {
            UNKNOWN,
            COFF,
            RES
        }

        internal static Win32ResourceForm DetectWin32ResourceForm(Stream win32Resources)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 73236, 74040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 73341, 73405);

                var
                reader = f_145_73354_73404(win32Resources, f_145_73387_73403())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 73421, 73467);

                var
                initialPosition = f_145_73443_73466(win32Resources)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 73481, 73521);

                var
                initial32Bits = f_145_73501_73520(reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 73535, 73577);

                win32Resources.Position = initialPosition;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 73668, 74029) || true) && (initial32Bits == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 73668, 74029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 73709, 73738);

                    return Win32ResourceForm.RES;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 73668, 74029);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 73668, 74029);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 73757, 74029) || true) && ((initial32Bits & 0xFFFF0000) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(145, 73761, 73836) || (initial32Bits & 0x0000FFFF) != 0xFFFF))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 73757, 74029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 73930, 73960);

                        return Win32ResourceForm.COFF;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 73757, 74029);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 73757, 74029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 73996, 74029);

                        return Win32ResourceForm.UNKNOWN;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 73757, 74029);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 73668, 74029);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 73236, 74040);

                System.Text.Encoding
                f_145_73387_73403()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 73387, 73403);
                    return return_v;
                }


                System.IO.BinaryReader
                f_145_73354_73404(System.IO.Stream
                input, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.BinaryReader(input, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 73354, 73404);
                    return return_v;
                }


                long
                f_145_73443_73466(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 73443, 73466);
                    return return_v;
                }


                uint
                f_145_73501_73520(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 73501, 73520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 73236, 74040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 73236, 74040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.ResourceSection? MakeWin32ResourcesFromCOFF(Stream? win32Resources, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 74052, 75207);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 74184, 74271) || true) && (win32Resources == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 74184, 74271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 74244, 74256);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 74184, 74271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 74287, 74317);

                Cci.ResourceSection
                resources
                = default(Cci.ResourceSection);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 74369, 74443);

                    resources = f_145_74381_74442(win32Resources);
                }
                catch (BadImageFormatException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 74472, 74699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 74539, 74654);

                    f_145_74539_74653(diagnostics, f_145_74555_74652(f_145_74555_74570(), f_145_74588_74624(f_145_74588_74603()), f_145_74626_74639(), f_145_74641_74651(ex)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 74672, 74684);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(145, 74472, 74699);
                }
                catch (IOException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 74713, 74928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 74768, 74883);

                    f_145_74768_74882(diagnostics, f_145_74784_74881(f_145_74784_74799(), f_145_74817_74853(f_145_74817_74832()), f_145_74855_74868(), f_145_74870_74880(ex)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 74901, 74913);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(145, 74713, 74928);
                }
                catch (ResourceException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 74942, 75163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75003, 75118);

                    f_145_75003_75117(diagnostics, f_145_75019_75116(f_145_75019_75034(), f_145_75052_75088(f_145_75052_75067()), f_145_75090_75103(), f_145_75105_75115(ex)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75136, 75148);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(145, 74942, 75163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75179, 75196);

                return resources;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 74052, 75207);

                Microsoft.Cci.ResourceSection
                f_145_74381_74442(System.IO.Stream
                stream)
                {
                    var return_v = COFFResourceReader.ReadWin32ResourcesFromCOFF(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 74381, 74442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_74555_74570()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74555, 74570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_74588_74603()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74588, 74603);
                    return return_v;
                }


                int
                f_145_74588_74624(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74588, 74624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_74626_74639()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74626, 74639);
                    return return_v;
                }


                string
                f_145_74641_74651(System.BadImageFormatException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74641, 74651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_74555_74652(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 74555, 74652);
                    return return_v;
                }


                int
                f_145_74539_74653(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 74539, 74653);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_74784_74799()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74784, 74799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_74817_74832()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74817, 74832);
                    return return_v;
                }


                int
                f_145_74817_74853(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74817, 74853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_74855_74868()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74855, 74868);
                    return return_v;
                }


                string
                f_145_74870_74880(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 74870, 74880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_74784_74881(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 74784, 74881);
                    return return_v;
                }


                int
                f_145_74768_74882(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 74768, 74882);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_75019_75034()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75019, 75034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_75052_75067()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75052, 75067);
                    return return_v;
                }


                int
                f_145_75052_75088(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75052, 75088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_75090_75103()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75090, 75103);
                    return return_v;
                }


                string
                f_145_75105_75115(Microsoft.CodeAnalysis.ResourceException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75105, 75115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_75019_75116(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 75019, 75116);
                    return return_v;
                }


                int
                f_145_75003_75117(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 75003, 75117);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 74052, 75207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 74052, 75207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<Win32Resource>? MakeWin32ResourceList(Stream? win32Resources, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 75219, 76709);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75346, 75433) || true) && (win32Resources == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 75346, 75433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75406, 75418);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 75346, 75433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75447, 75472);

                List<RESOURCE>
                resources
                = default(List<RESOURCE>);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75524, 75575);

                    resources = f_145_75536_75574(win32Resources);
                }
                catch (ResourceException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 75604, 75825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75665, 75780);

                    f_145_75665_75779(diagnostics, f_145_75681_75778(f_145_75681_75696(), f_145_75714_75750(f_145_75714_75729()), f_145_75752_75765(), f_145_75767_75777(ex)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75798, 75810);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(145, 75604, 75825);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75841, 75923) || true) && (resources == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 75841, 75923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75896, 75908);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 75841, 75923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 75939, 75984);

                var
                resourceList = f_145_75958_75983()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 76000, 76662);
                    foreach (var r in f_145_76018_76027_I(resources))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 76000, 76662);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 76061, 76602);

                        var
                        result = f_145_76074_76601(data: r.data, codePage: 0, languageId: r.LanguageId, id: unchecked((short)r.pstringName!.Ordinal), name: r.pstringName.theString, typeId: unchecked((short)r.pstringType!.Ordinal), typeName: r.pstringType.theString)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 76622, 76647);

                        f_145_76622_76646(
                                        resourceList, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 76000, 76662);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 663);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 76678, 76698);

                return resourceList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 75219, 76709);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.RESOURCE>
                f_145_75536_75574(System.IO.Stream
                stream)
                {
                    var return_v = CvtResFile.ReadResFile(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 75536, 75574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_75681_75696()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75681, 75696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_75714_75729()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75714, 75729);
                    return return_v;
                }


                int
                f_145_75714_75750(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75714, 75750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_75752_75765()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75752, 75765);
                    return return_v;
                }


                string
                f_145_75767_75777(Microsoft.CodeAnalysis.ResourceException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 75767, 75777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_75681_75778(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 75681, 75778);
                    return return_v;
                }


                int
                f_145_75665_75779(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 75665, 75779);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CodeGen.Win32Resource>
                f_145_75958_75983()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CodeGen.Win32Resource>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 75958, 75983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.Win32Resource
                f_145_76074_76601(byte[]?
                data, int
                codePage, ushort
                languageId, short
                id, string?
                name, short
                typeId, string?
                typeName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.Win32Resource(data: data, codePage: (uint)codePage, languageId: (uint)languageId, (int)id, name: name, (int)typeId, typeName: typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 76074, 76601);
                    return return_v;
                }


                int
                f_145_76622_76646(System.Collections.Generic.List<Microsoft.CodeAnalysis.CodeGen.Win32Resource>
                this_param, Microsoft.CodeAnalysis.CodeGen.Win32Resource
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 76622, 76646);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.RESOURCE>
                f_145_76018_76027_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.RESOURCE>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 76018, 76027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 75219, 76709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 75219, 76709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetupWin32Resources(CommonPEModuleBuilder moduleBeingBuilt, Stream? win32Resources, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 76721, 78289);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 76870, 76922) || true) && (win32Resources == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 76870, 76922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 76915, 76922);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 76870, 76922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 76938, 76969);

                Win32ResourceForm
                resourceForm
                = default(Win32ResourceForm);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 77021, 77076);

                    resourceForm = f_145_77036_77075(win32Resources);
                }
                catch (EndOfStreamException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 77105, 77370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 77166, 77330);

                    f_145_77166_77329(diagnostics, f_145_77182_77328(f_145_77182_77197(), f_145_77215_77251(f_145_77215_77230()), NoLocation.Singleton, f_145_77275_77327()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 77348, 77355);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(145, 77105, 77370);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 77384, 77599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 77437, 77559);

                    f_145_77437_77558(diagnostics, f_145_77453_77557(f_145_77453_77468(), f_145_77486_77522(f_145_77486_77501()), NoLocation.Singleton, f_145_77546_77556(ex)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 77577, 77584);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(145, 77384, 77599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 77615, 78278);

                switch (resourceForm)
                {

                    case Win32ResourceForm.COFF:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 77615, 78278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 77719, 77815);

                        moduleBeingBuilt.Win32ResourceSection = f_145_77759_77814(this, win32Resources, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 77837, 77843);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 77615, 78278);

                    case Win32ResourceForm.RES:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 77615, 78278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 77910, 77995);

                        moduleBeingBuilt.Win32Resources = f_145_77944_77994(this, win32Resources, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 78017, 78023);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 77615, 78278);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 77615, 78278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 78071, 78235);

                        f_145_78071_78234(diagnostics, f_145_78087_78233(f_145_78087_78102(), f_145_78120_78156(f_145_78120_78135()), NoLocation.Singleton, f_145_78180_78232()));
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 78257, 78263);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 77615, 78278);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 76721, 78289);

                Microsoft.CodeAnalysis.Compilation.Win32ResourceForm
                f_145_77036_77075(System.IO.Stream
                win32Resources)
                {
                    var return_v = DetectWin32ResourceForm(win32Resources);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 77036, 77075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_77182_77197()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 77182, 77197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_77215_77230()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 77215, 77230);
                    return return_v;
                }


                int
                f_145_77215_77251(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 77215, 77251);
                    return return_v;
                }


                string
                f_145_77275_77327()
                {
                    var return_v = CodeAnalysisResources.UnrecognizedResourceFileFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 77275, 77327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_77182_77328(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 77182, 77328);
                    return return_v;
                }


                int
                f_145_77166_77329(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 77166, 77329);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_77453_77468()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 77453, 77468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_77486_77501()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 77486, 77501);
                    return return_v;
                }


                int
                f_145_77486_77522(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 77486, 77522);
                    return return_v;
                }


                string
                f_145_77546_77556(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 77546, 77556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_77453_77557(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 77453, 77557);
                    return return_v;
                }


                int
                f_145_77437_77558(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 77437, 77558);
                    return 0;
                }


                Microsoft.Cci.ResourceSection?
                f_145_77759_77814(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.Stream
                win32Resources, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeWin32ResourcesFromCOFF(win32Resources, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 77759, 77814);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CodeGen.Win32Resource>?
                f_145_77944_77994(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.Stream
                win32Resources, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeWin32ResourceList(win32Resources, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 77944, 77994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_78087_78102()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 78087, 78102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_78120_78135()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 78120, 78135);
                    return return_v;
                }


                int
                f_145_78120_78156(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 78120, 78156);
                    return return_v;
                }


                string
                f_145_78180_78232()
                {
                    var return_v = CodeAnalysisResources.UnrecognizedResourceFileFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 78180, 78232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_78087_78233(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 78087, 78233);
                    return return_v;
                }


                int
                f_145_78071_78234(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 78071, 78234);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 76721, 78289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 76721, 78289);
            }
        }

        internal void ReportManifestResourceDuplicates(
                    IEnumerable<ResourceDescription>? manifestResources,
                    IEnumerable<string> addedModuleNames,
                    IEnumerable<string> addedModuleResourceNames,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 78301, 80582);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 78589, 78750) || true) && (f_145_78593_78611(f_145_78593_78600()) == OutputKind.NetModule && (DynAbs.Tracing.TraceSender.Expression_True(145, 78593, 78694) && !(manifestResources != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 78641, 78693) && f_145_78670_78693(manifestResources)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 78589, 78750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 78728, 78735);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 78589, 78750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 78766, 78814);

                var
                uniqueResourceNames = f_145_78792_78813()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 78830, 80134) || true) && (manifestResources != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 78834, 78886) && f_145_78863_78886(manifestResources)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 78830, 80134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 78920, 78996);

                    var
                    uniqueFileNames = f_145_78942_78995(f_145_78962_78994())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 79014, 79768);
                        foreach (var resource in f_145_79039_79056_I(manifestResources))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 79014, 79768);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 79098, 79349) || true) && (!f_145_79103_79149(uniqueResourceNames, resource.ResourceName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 79098, 79349);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 79199, 79326);

                                f_145_79199_79325(diagnostics, f_145_79215_79324(f_145_79215_79230(), f_145_79248_79285(f_145_79248_79263()), f_145_79287_79300(), resource.ResourceName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 79098, 79349);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 79445, 79478);

                            var
                            fileName = resource.FileName
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 79500, 79749) || true) && (fileName != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 79504, 79554) && !f_145_79525_79554(uniqueFileNames, fileName)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 79500, 79749);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 79604, 79726);

                                f_145_79604_79725(diagnostics, f_145_79620_79724(f_145_79620_79635(), f_145_79653_79698(f_145_79653_79668()), f_145_79700_79713(), fileName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 79500, 79749);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 79014, 79768);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 755);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 755);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 79788, 80119);
                        foreach (var fileName in f_145_79813_79829_I(addedModuleNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 79788, 80119);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 79871, 80100) || true) && (!f_145_79876_79905(uniqueFileNames, fileName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 79871, 80100);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 79955, 80077);

                                f_145_79955_80076(diagnostics, f_145_79971_80075(f_145_79971_79986(), f_145_80004_80049(f_145_80004_80019()), f_145_80051_80064(), fileName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 79871, 80100);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 79788, 80119);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 332);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 332);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 78830, 80134);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 80150, 80571) || true) && (f_145_80154_80172(f_145_80154_80161()) != OutputKind.NetModule)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 80150, 80571);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 80230, 80556);
                        foreach (string name in f_145_80254_80278_I(addedModuleResourceNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 80230, 80556);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 80320, 80537) || true) && (!f_145_80325_80354(uniqueResourceNames, name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 80320, 80537);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 80404, 80514);

                                f_145_80404_80513(diagnostics, f_145_80420_80512(f_145_80420_80435(), f_145_80453_80490(f_145_80453_80468()), f_145_80492_80505(), name));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 80320, 80537);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 80230, 80556);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 327);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 327);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 80150, 80571);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 78301, 80582);

                Microsoft.CodeAnalysis.CompilationOptions
                f_145_78593_78600()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 78593, 78600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_78593_78611(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 78593, 78611);
                    return return_v;
                }


                bool
                f_145_78670_78693(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ResourceDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 78670, 78693);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_145_78792_78813()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 78792, 78813);
                    return return_v;
                }


                bool
                f_145_78863_78886(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ResourceDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 78863, 78886);
                    return return_v;
                }


                System.StringComparer
                f_145_78962_78994()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 78962, 78994);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_145_78942_78995(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 78942, 78995);
                    return return_v;
                }


                bool
                f_145_79103_79149(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79103, 79149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_79215_79230()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 79215, 79230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_79248_79263()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 79248, 79263);
                    return return_v;
                }


                int
                f_145_79248_79285(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_ResourceNotUnique;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 79248, 79285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_79287_79300()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 79287, 79300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_79215_79324(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79215, 79324);
                    return return_v;
                }


                int
                f_145_79199_79325(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79199, 79325);
                    return 0;
                }


                bool
                f_145_79525_79554(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79525, 79554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_79620_79635()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 79620, 79635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_79653_79668()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 79653, 79668);
                    return return_v;
                }


                int
                f_145_79653_79698(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_ResourceFileNameNotUnique;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 79653, 79698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_79700_79713()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 79700, 79713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_79620_79724(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79620, 79724);
                    return return_v;
                }


                int
                f_145_79604_79725(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79604, 79725);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                f_145_79039_79056_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79039, 79056);
                    return return_v;
                }


                bool
                f_145_79876_79905(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79876, 79905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_79971_79986()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 79971, 79986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_80004_80019()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 80004, 80019);
                    return return_v;
                }


                int
                f_145_80004_80049(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_ResourceFileNameNotUnique;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 80004, 80049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_80051_80064()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 80051, 80064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_79971_80075(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79971, 80075);
                    return return_v;
                }


                int
                f_145_79955_80076(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79955, 80076);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_145_79813_79829_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 79813, 79829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_80154_80161()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 80154, 80161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_80154_80172(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 80154, 80172);
                    return return_v;
                }


                bool
                f_145_80325_80354(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 80325, 80354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_80420_80435()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 80420, 80435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_80453_80468()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 80453, 80468);
                    return return_v;
                }


                int
                f_145_80453_80490(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_ResourceNotUnique;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 80453, 80490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_80492_80505()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 80492, 80505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_80420_80512(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 80420, 80512);
                    return return_v;
                }


                int
                f_145_80404_80513(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 80404, 80513);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_145_80254_80278_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 80254, 80278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 78301, 80582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 78301, 80582);
            }
        }

        internal bool SignUsingBuilder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 81266, 81453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 81282, 81453);
                    return f_145_81282_81331(f_145_81303_81317().KeyContainer) && (DynAbs.Tracing.TraceSender.Expression_True(145, 81282, 81383) && !f_145_81349_81363().HasCounterSignature) && (DynAbs.Tracing.TraceSender.Expression_True(145, 81282, 81453) && !f_145_81401_81453(_features, "UseLegacyStrongNameProvider")); DynAbs.Tracing.TraceSender.TraceExitMethod(145, 81266, 81453);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 81266, 81453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 81266, 81453);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Cci.ModulePropertiesForSerialization ConstructModuleSerializationProperties(
                    EmitOptions emitOptions,
                    string? targetRuntimeVersion,
                    Guid moduleVersionId = default(Guid))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 81625, 87503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 81867, 81920);

                CompilationOptions
                compilationOptions = f_145_81907_81919(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 81934, 81982);

                Platform
                platform = f_145_81954_81981(compilationOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 81996, 82050);

                OutputKind
                outputKind = f_145_82020_82049(compilationOptions)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82066, 82165) || true) && (!f_145_82071_82089(platform))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 82066, 82165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82123, 82150);

                    platform = Platform.AnyCpu;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 82066, 82165);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82181, 82304) || true) && (!f_145_82186_82206(outputKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 82181, 82304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82240, 82289);

                    outputKind = OutputKind.DynamicallyLinkedLibrary;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 82181, 82304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82320, 82366);

                bool
                requires64Bit = f_145_82341_82365(platform)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82380, 82426);

                bool
                requires32Bit = f_145_82401_82425(platform)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82442, 82463);

                ushort
                fileAlignment
                = default(ushort);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82477, 82949) || true) && (f_145_82481_82506(emitOptions) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(145, 82481, 82582) || !f_145_82516_82582(f_145_82556_82581(emitOptions))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 82477, 82949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82616, 82818);

                    fileAlignment = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 82632, 82645) || ((requires64Bit
                    && DynAbs.Tracing.TraceSender.Conditional_F2(145, 82669, 82731)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 82755, 82817))) ? Cci.ModulePropertiesForSerialization.DefaultFileAlignment64Bit
                    : Cci.ModulePropertiesForSerialization.DefaultFileAlignment32Bit;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 82477, 82949);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 82477, 82949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82884, 82934);

                    fileAlignment = (ushort)f_145_82908_82933(emitOptions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 82477, 82949);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 82965, 83089);

                ulong
                baseAddress = unchecked(f_145_82995_83018(emitOptions) + 0x8000) & ((DynAbs.Tracing.TraceSender.Conditional_F1(145, 83032, 83045) || ((requires64Bit && DynAbs.Tracing.TraceSender.Conditional_F2(145, 83048, 83066)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 83069, 83087))) ? 0xffffffffffff0000 : 0x00000000ffff0000)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 83186, 83912) || true) && (baseAddress == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 83186, 83912);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 83240, 83897) || true) && (outputKind == OutputKind.ConsoleApplication || (DynAbs.Tracing.TraceSender.Expression_False(145, 83244, 83355) || outputKind == OutputKind.WindowsApplication) || (DynAbs.Tracing.TraceSender.Expression_False(145, 83244, 83430) || outputKind == OutputKind.WindowsRuntimeApplication))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 83240, 83897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 83472, 83634);

                        baseAddress = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 83486, 83501) || (((requires64Bit) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 83504, 83567)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 83570, 83633))) ? Cci.ModulePropertiesForSerialization.DefaultExeBaseAddress64Bit : Cci.ModulePropertiesForSerialization.DefaultExeBaseAddress32Bit;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 83240, 83897);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 83240, 83897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 83716, 83878);

                        baseAddress = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 83730, 83745) || (((requires64Bit) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 83748, 83811)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 83814, 83877))) ? Cci.ModulePropertiesForSerialization.DefaultDllBaseAddress64Bit : Cci.ModulePropertiesForSerialization.DefaultDllBaseAddress32Bit;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 83240, 83897);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 83186, 83912);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 83928, 84137);

                ulong
                sizeOfHeapCommit = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 83953, 83966) || ((requires64Bit
                && DynAbs.Tracing.TraceSender.Conditional_F2(145, 83986, 84051)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 84071, 84136))) ? Cci.ModulePropertiesForSerialization.DefaultSizeOfHeapCommit64Bit
                : Cci.ModulePropertiesForSerialization.DefaultSizeOfHeapCommit32Bit
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 84296, 84395);

                const ulong
                sizeOfHeapReserve = Cci.ModulePropertiesForSerialization.DefaultSizeOfHeapReserve32Bit
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 84411, 84626);

                ulong
                sizeOfStackReserve = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 84438, 84451) || ((requires64Bit
                && DynAbs.Tracing.TraceSender.Conditional_F2(145, 84471, 84538)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 84558, 84625))) ? Cci.ModulePropertiesForSerialization.DefaultSizeOfStackReserve64Bit
                : Cci.ModulePropertiesForSerialization.DefaultSizeOfStackReserve32Bit
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 84642, 84854);

                ulong
                sizeOfStackCommit = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 84668, 84681) || ((requires64Bit
                && DynAbs.Tracing.TraceSender.Conditional_F2(145, 84701, 84767)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 84787, 84853))) ? Cci.ModulePropertiesForSerialization.DefaultSizeOfStackCommit64Bit
                : Cci.ModulePropertiesForSerialization.DefaultSizeOfStackCommit32Bit
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 84870, 84904);

                SubsystemVersion
                subsystemVersion
                = default(SubsystemVersion);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 84918, 85250) || true) && (emitOptions.SubsystemVersion.Equals(SubsystemVersion.None) || (DynAbs.Tracing.TraceSender.Expression_False(145, 84922, 85021) || f_145_84984_85021_M(!emitOptions.SubsystemVersion.IsValid)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 84918, 85250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 85055, 85121);

                    subsystemVersion = SubsystemVersion.Default(outputKind, platform);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 84918, 85250);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 84918, 85250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 85187, 85235);

                    subsystemVersion = f_145_85206_85234(emitOptions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 84918, 85250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 85266, 85282);

                Machine
                machine
                = default(Machine);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 85296, 86180);

                switch (platform)
                {

                    case Platform.Arm64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 85296, 86180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 85388, 85412);

                        machine = Machine.Arm64;
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 85434, 85440);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 85296, 86180);

                    case Platform.Arm:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 85296, 86180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 85500, 85528);

                        machine = Machine.ArmThumb2;
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 85550, 85556);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 85296, 86180);

                    case Platform.X64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 85296, 86180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 85616, 85640);

                        machine = Machine.Amd64;
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 85662, 85668);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 85296, 86180);

                    case Platform.Itanium:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 85296, 86180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 85732, 85755);

                        machine = Machine.IA64;
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 85777, 85783);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 85296, 86180);

                    case Platform.X86:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 85296, 86180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 85843, 85866);

                        machine = Machine.I386;
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 85888, 85894);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 85296, 86180);

                    case Platform.AnyCpu:
                    case Platform.AnyCpu32BitPreferred:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 85296, 86180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 86010, 86036);

                        machine = Machine.Unknown;
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 86058, 86064);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 85296, 86180);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 85296, 86180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 86114, 86165);

                        throw f_145_86120_86164(platform);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 85296, 86180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 86196, 87492);

                return f_145_86203_87491(persistentIdentifier: moduleVersionId, corFlags: f_145_86328_86426(machine, f_145_86355_86368(), prefers32Bit: platform == Platform.AnyCpu32BitPreferred), fileAlignment: fileAlignment, sectionAlignment: Cci.ModulePropertiesForSerialization.DefaultSectionAlignment, targetRuntimeVersion: targetRuntimeVersion, machine: machine, baseAddress: baseAddress, sizeOfHeapReserve: sizeOfHeapReserve, sizeOfHeapCommit: sizeOfHeapCommit, sizeOfStackReserve: sizeOfStackReserve, sizeOfStackCommit: sizeOfStackCommit, dllCharacteristics: f_145_86968_87104(f_145_86990_87032(emitOptions), f_145_87034_87063(compilationOptions) == OutputKind.WindowsRuntimeApplication), imageCharacteristics: f_145_87145_87190(outputKind, requires32Bit), subsystem: f_145_87220_87244(outputKind), majorSubsystemVersion: (ushort)subsystemVersion.Major, minorSubsystemVersion: (ushort)subsystemVersion.Minor, linkerMajorVersion: f_145_87427_87450(this), linkerMinorVersion: 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 81625, 87503);

                Microsoft.CodeAnalysis.CompilationOptions
                f_145_81907_81919(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 81907, 81919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Platform
                f_145_81954_81981(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.Platform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 81954, 81981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_82020_82049(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 82020, 82049);
                    return return_v;
                }


                bool
                f_145_82071_82089(Microsoft.CodeAnalysis.Platform
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 82071, 82089);
                    return return_v;
                }


                bool
                f_145_82186_82206(Microsoft.CodeAnalysis.OutputKind
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 82186, 82206);
                    return return_v;
                }


                bool
                f_145_82341_82365(Microsoft.CodeAnalysis.Platform
                value)
                {
                    var return_v = value.Requires64Bit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 82341, 82365);
                    return return_v;
                }


                bool
                f_145_82401_82425(Microsoft.CodeAnalysis.Platform
                value)
                {
                    var return_v = value.Requires32Bit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 82401, 82425);
                    return return_v;
                }


                int
                f_145_82481_82506(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 82481, 82506);
                    return return_v;
                }


                int
                f_145_82556_82581(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 82556, 82581);
                    return return_v;
                }


                bool
                f_145_82516_82582(int
                value)
                {
                    var return_v = CompilationOptions.IsValidFileAlignment(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 82516, 82582);
                    return return_v;
                }


                int
                f_145_82908_82933(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 82908, 82933);
                    return return_v;
                }


                ulong
                f_145_82995_83018(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.BaseAddress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 82995, 83018);
                    return return_v;
                }


                bool
                f_145_84984_85021_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 84984, 85021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SubsystemVersion
                f_145_85206_85234(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.SubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 85206, 85234);
                    return return_v;
                }


                System.Exception
                f_145_86120_86164(Microsoft.CodeAnalysis.Platform
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 86120, 86164);
                    return return_v;
                }


                bool
                f_145_86355_86368()
                {
                    var return_v = HasStrongName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 86355, 86368);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CorFlags
                f_145_86328_86426(System.Reflection.PortableExecutable.Machine
                machine, bool
                strongNameSigned, bool
                prefers32Bit)
                {
                    var return_v = GetCorHeaderFlags(machine, strongNameSigned, prefers32Bit: prefers32Bit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 86328, 86426);
                    return return_v;
                }


                bool
                f_145_86990_87032(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.HighEntropyVirtualAddressSpace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 86990, 87032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_87034_87063(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 87034, 87063);
                    return return_v;
                }


                System.Reflection.PortableExecutable.DllCharacteristics
                f_145_86968_87104(bool
                enableHighEntropyVA, bool
                configureToExecuteInAppContainer)
                {
                    var return_v = GetDllCharacteristics(enableHighEntropyVA, configureToExecuteInAppContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 86968, 87104);
                    return return_v;
                }


                System.Reflection.PortableExecutable.Characteristics
                f_145_87145_87190(Microsoft.CodeAnalysis.OutputKind
                outputKind, bool
                requires32Bit)
                {
                    var return_v = GetCharacteristics(outputKind, requires32Bit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 87145, 87190);
                    return return_v;
                }


                System.Reflection.PortableExecutable.Subsystem
                f_145_87220_87244(Microsoft.CodeAnalysis.OutputKind
                outputKind)
                {
                    var return_v = GetSubsystem(outputKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 87220, 87244);
                    return return_v;
                }


                byte
                f_145_87427_87450(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.LinkerMajorVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 87427, 87450);
                    return return_v;
                }


                Microsoft.Cci.ModulePropertiesForSerialization
                f_145_86203_87491(System.Guid
                persistentIdentifier, System.Reflection.PortableExecutable.CorFlags
                corFlags, ushort
                fileAlignment, ushort
                sectionAlignment, string?
                targetRuntimeVersion, System.Reflection.PortableExecutable.Machine
                machine, ulong
                baseAddress, ulong
                sizeOfHeapReserve, ulong
                sizeOfHeapCommit, ulong
                sizeOfStackReserve, ulong
                sizeOfStackCommit, System.Reflection.PortableExecutable.DllCharacteristics
                dllCharacteristics, System.Reflection.PortableExecutable.Characteristics
                imageCharacteristics, System.Reflection.PortableExecutable.Subsystem
                subsystem, int
                majorSubsystemVersion, int
                minorSubsystemVersion, byte
                linkerMajorVersion, int
                linkerMinorVersion)
                {
                    var return_v = new Microsoft.Cci.ModulePropertiesForSerialization(persistentIdentifier: persistentIdentifier, corFlags: corFlags, fileAlignment: (int)fileAlignment, sectionAlignment: (int)sectionAlignment, targetRuntimeVersion: targetRuntimeVersion, machine: machine, baseAddress: baseAddress, sizeOfHeapReserve: sizeOfHeapReserve, sizeOfHeapCommit: sizeOfHeapCommit, sizeOfStackReserve: sizeOfStackReserve, sizeOfStackCommit: sizeOfStackCommit, dllCharacteristics: dllCharacteristics, imageCharacteristics: imageCharacteristics, subsystem: subsystem, majorSubsystemVersion: (ushort)majorSubsystemVersion, minorSubsystemVersion: (ushort)minorSubsystemVersion, linkerMajorVersion: linkerMajorVersion, linkerMinorVersion: (byte)linkerMinorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 86203, 87491);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 81625, 87503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 81625, 87503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CorFlags GetCorHeaderFlags(Machine machine, bool strongNameSigned, bool prefers32Bit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 87515, 88099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 87640, 87674);

                CorFlags
                result = CorFlags.ILOnly
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 87690, 87799) || true) && (machine == Machine.I386)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 87690, 87799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 87751, 87784);

                    result |= CorFlags.Requires32Bit;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 87690, 87799);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 87815, 87920) || true) && (strongNameSigned)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 87815, 87920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 87869, 87905);

                    result |= CorFlags.StrongNameSigned;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 87815, 87920);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 87936, 88058) || true) && (prefers32Bit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 87936, 88058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 87986, 88043);

                    result |= CorFlags.Requires32Bit | CorFlags.Prefers32Bit;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 87936, 88058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 88074, 88088);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 87515, 88099);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 87515, 88099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 87515, 88099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DllCharacteristics GetDllCharacteristics(bool enableHighEntropyVA, bool configureToExecuteInAppContainer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 88111, 88803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 88257, 88471);

                var
                result =
                                DllCharacteristics.DynamicBase |
                                DllCharacteristics.NxCompatible |
                                DllCharacteristics.NoSeh |
                                DllCharacteristics.TerminalServerAware
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 88487, 88619) || true) && (enableHighEntropyVA)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 88487, 88619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 88544, 88604);

                    result |= DllCharacteristics.HighEntropyVirtualAddressSpace;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 88487, 88619);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 88635, 88762) || true) && (configureToExecuteInAppContainer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 88635, 88762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 88705, 88747);

                    result |= DllCharacteristics.AppContainer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 88635, 88762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 88778, 88792);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 88111, 88803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 88111, 88803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 88111, 88803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Characteristics GetCharacteristics(OutputKind outputKind, bool requires32Bit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 88815, 90322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 88932, 88986);

                var
                characteristics = Characteristics.ExecutableImage
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 89002, 89659) || true) && (requires32Bit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 89002, 89659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 89246, 89294);

                    characteristics |= Characteristics.Bit32Machine;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 89002, 89659);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 89002, 89659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 89591, 89644);

                    characteristics |= Characteristics.LargeAddressAware;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 89002, 89659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 89675, 90272);

                switch (outputKind)
                {

                    case OutputKind.WindowsRuntimeMetadata:
                    case OutputKind.DynamicallyLinkedLibrary:
                    case OutputKind.NetModule:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 89675, 90272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 89891, 89930);

                        characteristics |= Characteristics.Dll;
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 89952, 89958);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 89675, 90272);

                    case OutputKind.ConsoleApplication:
                    case OutputKind.WindowsRuntimeApplication:
                    case OutputKind.WindowsApplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 89675, 90272);
                        DynAbs.Tracing.TraceSender.TraceBreak(145, 90148, 90154);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 89675, 90272);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 89675, 90272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 90204, 90257);

                        throw f_145_90210_90256(outputKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 89675, 90272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 90288, 90311);

                return characteristics;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 88815, 90322);

                System.Exception
                f_145_90210_90256(Microsoft.CodeAnalysis.OutputKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 90210, 90256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 88815, 90322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 88815, 90322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Subsystem GetSubsystem(OutputKind outputKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 90334, 91010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 90419, 90999);

                switch (outputKind)
                {

                    case OutputKind.ConsoleApplication:
                    case OutputKind.DynamicallyLinkedLibrary:
                    case OutputKind.NetModule:
                    case OutputKind.WindowsRuntimeMetadata:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 90419, 90999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 90688, 90716);

                        return Subsystem.WindowsCui;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 90419, 90999);

                    case OutputKind.WindowsRuntimeApplication:
                    case OutputKind.WindowsApplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 90419, 90999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 90853, 90881);

                        return Subsystem.WindowsGui;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 90419, 90999);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 90419, 90999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 90931, 90984);

                        throw f_145_90937_90983(outputKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 90419, 90999);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 90334, 91010);

                System.Exception
                f_145_90937_90983(Microsoft.CodeAnalysis.OutputKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 90937, 90983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 90334, 91010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 90334, 91010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract byte LinkerMajorVersion { get; }

        internal bool HasStrongName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 91766, 91966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 91802, 91951);

                    return f_145_91809_91823_M(!IsDelaySigned) && (DynAbs.Tracing.TraceSender.Expression_True(145, 91809, 91890) && f_145_91848_91866(f_145_91848_91855()) != OutputKind.NetModule
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(145, 91809, 91950) && f_145_91915_91950(f_145_91915_91929()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 91766, 91966);

                    bool
                    f_145_91809_91823_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 91809, 91823);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CompilationOptions
                    f_145_91848_91855()
                    {
                        var return_v = Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 91848, 91855);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.OutputKind
                    f_145_91848_91866(Microsoft.CodeAnalysis.CompilationOptions
                    this_param)
                    {
                        var return_v = this_param.OutputKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 91848, 91866);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.StrongNameKeys
                    f_145_91915_91929()
                    {
                        var return_v = StrongNameKeys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 91915, 91929);
                        return return_v;
                    }


                    bool
                    f_145_91915_91950(Microsoft.CodeAnalysis.StrongNameKeys
                    this_param)
                    {
                        var return_v = this_param.CanProvideStrongName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 91915, 91950);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 91714, 91977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 91714, 91977);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsRealSigned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 92040, 92648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 92453, 92633);

                    return f_145_92460_92474_M(!IsDelaySigned) && (DynAbs.Tracing.TraceSender.Expression_True(145, 92460, 92518) && f_145_92499_92518_M(!f_145_92500_92507().PublicSign)) && (DynAbs.Tracing.TraceSender.Expression_True(145, 92460, 92585) && f_145_92543_92561(f_145_92543_92550()) != OutputKind.NetModule
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(145, 92460, 92632) && f_145_92610_92632(f_145_92610_92624()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 92040, 92648);

                    bool
                    f_145_92460_92474_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 92460, 92474);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CompilationOptions
                    f_145_92500_92507()
                    {
                        var return_v = Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 92500, 92507);
                        return return_v;
                    }


                    bool
                    f_145_92499_92518_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 92499, 92518);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CompilationOptions
                    f_145_92543_92550()
                    {
                        var return_v = Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 92543, 92550);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.OutputKind
                    f_145_92543_92561(Microsoft.CodeAnalysis.CompilationOptions
                    this_param)
                    {
                        var return_v = this_param.OutputKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 92543, 92561);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.StrongNameKeys
                    f_145_92610_92624()
                    {
                        var return_v = StrongNameKeys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 92610, 92624);
                        return return_v;
                    }


                    bool
                    f_145_92610_92632(Microsoft.CodeAnalysis.StrongNameKeys
                    this_param)
                    {
                        var return_v = this_param.CanSign;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 92610, 92632);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 91989, 92659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 91989, 92659);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool HasCodeToEmit();

        internal abstract bool IsDelaySigned { get; }

        internal abstract StrongNameKeys StrongNameKeys { get; }

        internal abstract CommonPEModuleBuilder? CreateModuleBuilder(
                    EmitOptions emitOptions,
                    IMethodSymbol? debugEntryPoint,
                    Stream? sourceLinkStream,
                    IEnumerable<EmbeddedText>? embeddedTexts,
                    IEnumerable<ResourceDescription>? manifestResources,
                    CompilationTestData? testData,
                    DiagnosticBag diagnostics,
                    CancellationToken cancellationToken);

        internal abstract bool CompileMethods(
                    CommonPEModuleBuilder moduleBuilder,
                    bool emittingPdb,
                    bool emitMetadataOnly,
                    bool emitTestCoverageData,
                    DiagnosticBag diagnostics,
                    Predicate<ISymbolInternal>? filterOpt,
                    CancellationToken cancellationToken);

        internal bool CreateDebugDocuments(DebugDocumentsBuilder documentsBuilder, IEnumerable<EmbeddedText> embeddedTexts, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 93950, 97361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 94177, 94208);

                bool
                allTreesDebuggable = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 94222, 94612);
                    foreach (var tree in f_145_94243_94254_I(f_145_94243_94254()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 94222, 94612);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 94288, 94597) || true) && (!f_145_94293_94328(f_145_94314_94327(tree)) && (DynAbs.Tracing.TraceSender.Expression_True(145, 94292, 94363) && f_145_94332_94355(f_145_94332_94346(tree)) == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 94288, 94597);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 94405, 94529);

                            f_145_94405_94528(diagnostics, f_145_94421_94527(f_145_94421_94436(), f_145_94454_94496(f_145_94454_94469()), f_145_94498_94526(f_145_94498_94512(tree))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 94551, 94578);

                            allTreesDebuggable = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 94288, 94597);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 94222, 94612);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 391);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 94628, 94713) || true) && (!allTreesDebuggable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 94628, 94713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 94685, 94698);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 94628, 94713);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 94902, 95757) || true) && (!f_145_94907_94930(embeddedTexts))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 94902, 95757);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 94964, 95742);
                        foreach (var text in f_145_94985_94998_I(embeddedTexts))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 94964, 95742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 95040, 95091);

                            f_145_95040_95090(!f_145_95054_95089(f_145_95075_95088(text)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 95113, 95212);

                            string
                            normalizedPath = f_145_95137_95211(documentsBuilder, f_145_95181_95194(text), basePath: null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 95234, 95322);

                            var
                            existingDoc = f_145_95252_95321(documentsBuilder, normalizedPath)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 95344, 95723) || true) && (existingDoc == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 95344, 95723);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 95417, 95628);

                                var
                                document = f_145_95432_95627(normalizedPath, f_145_95535_95564(), () => text.GetDebugSourceInfo())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 95656, 95700);

                                f_145_95656_95699(
                                                        documentsBuilder, document);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 95344, 95723);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 94964, 95742);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 779);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 779);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 94902, 95757);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 95844, 96784);
                    foreach (var tree in f_145_95865_95876_I(f_145_95865_95876()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 95844, 96784);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 95910, 96769) || true) && (!f_145_95915_95950(f_145_95936_95949(tree)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 95910, 96769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 96192, 96291);

                            string
                            normalizedPath = f_145_96216_96290(documentsBuilder, f_145_96260_96273(tree), basePath: null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 96313, 96401);

                            var
                            existingDoc = f_145_96331_96400(documentsBuilder, normalizedPath)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 96423, 96750) || true) && (existingDoc == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 96423, 96750);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 96496, 96727);

                                f_145_96496_96726(documentsBuilder, f_145_96530_96725(normalizedPath, f_145_96633_96662(), () => tree.GetDebugSourceInfo()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 96423, 96750);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 95910, 96769);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 95844, 96784);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 941);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 97159, 97322);
                    foreach (var tree in f_145_97180_97191_I(f_145_97180_97191()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 97159, 97322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 97225, 97307);

                        f_145_97225_97306(this, documentsBuilder, tree, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 97159, 97322);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 97338, 97350);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 93950, 97361);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_145_94243_94254()
                {
                    var return_v = SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 94243, 94254);
                    return return_v;
                }


                string
                f_145_94314_94327(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 94314, 94327);
                    return return_v;
                }


                bool
                f_145_94293_94328(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 94293, 94328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_145_94332_94346(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 94332, 94346);
                    return return_v;
                }


                System.Text.Encoding?
                f_145_94332_94355(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 94332, 94355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_94421_94436()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 94421, 94436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_94454_94469()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 94454, 94469);
                    return return_v;
                }


                int
                f_145_94454_94496(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_EncodinglessSyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 94454, 94496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_145_94498_94512(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 94498, 94512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_94498_94526(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 94498, 94526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_94421_94527(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.CreateDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 94421, 94527);
                    return return_v;
                }


                int
                f_145_94405_94528(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 94405, 94528);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_145_94243_94254_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 94243, 94254);
                    return return_v;
                }


                bool
                f_145_94907_94930(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.EmbeddedText>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 94907, 94930);
                    return return_v;
                }


                string
                f_145_95075_95088(Microsoft.CodeAnalysis.EmbeddedText
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 95075, 95088);
                    return return_v;
                }


                bool
                f_145_95054_95089(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 95054, 95089);
                    return return_v;
                }


                int
                f_145_95040_95090(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 95040, 95090);
                    return 0;
                }


                string
                f_145_95181_95194(Microsoft.CodeAnalysis.EmbeddedText
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 95181, 95194);
                    return return_v;
                }


                string
                f_145_95137_95211(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, string
                path, string
                basePath)
                {
                    var return_v = this_param.NormalizeDebugDocumentPath(path, basePath: basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 95137, 95211);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_145_95252_95321(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, string
                normalizedPath)
                {
                    var return_v = this_param.TryGetDebugDocumentForNormalizedPath(normalizedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 95252, 95321);
                    return return_v;
                }


                System.Guid
                f_145_95535_95564()
                {
                    var return_v = DebugSourceDocumentLanguageId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 95535, 95564);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_145_95432_95627(string
                location, System.Guid
                language, System.Func<Microsoft.Cci.DebugSourceInfo>
                sourceInfo)
                {
                    var return_v = new Microsoft.Cci.DebugSourceDocument(location, language, sourceInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 95432, 95627);
                    return return_v;
                }


                int
                f_145_95656_95699(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, Microsoft.Cci.DebugSourceDocument
                document)
                {
                    this_param.AddDebugDocument(document);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 95656, 95699);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                f_145_94985_94998_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 94985, 94998);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_145_95865_95876()
                {
                    var return_v = SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 95865, 95876);
                    return return_v;
                }


                string
                f_145_95936_95949(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 95936, 95949);
                    return return_v;
                }


                bool
                f_145_95915_95950(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 95915, 95950);
                    return return_v;
                }


                string
                f_145_96260_96273(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 96260, 96273);
                    return return_v;
                }


                string
                f_145_96216_96290(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, string
                path, string
                basePath)
                {
                    var return_v = this_param.NormalizeDebugDocumentPath(path, basePath: basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 96216, 96290);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_145_96331_96400(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, string
                normalizedPath)
                {
                    var return_v = this_param.TryGetDebugDocumentForNormalizedPath(normalizedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 96331, 96400);
                    return return_v;
                }


                System.Guid
                f_145_96633_96662()
                {
                    var return_v = DebugSourceDocumentLanguageId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 96633, 96662);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_145_96530_96725(string
                location, System.Guid
                language, System.Func<Microsoft.Cci.DebugSourceInfo>
                sourceInfo)
                {
                    var return_v = new Microsoft.Cci.DebugSourceDocument(location, language, sourceInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 96530, 96725);
                    return return_v;
                }


                int
                f_145_96496_96726(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, Microsoft.Cci.DebugSourceDocument
                document)
                {
                    this_param.AddDebugDocument(document);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 96496, 96726);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_145_95865_95876_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 95865, 95876);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_145_97180_97191()
                {
                    var return_v = SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 97180, 97191);
                    return return_v;
                }


                int
                f_145_97225_97306(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                documentsBuilder, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDebugSourceDocumentsForChecksumDirectives(documentsBuilder, tree, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 97225, 97306);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_145_97180_97191_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 97180, 97191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 93950, 97361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 93950, 97361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract Guid DebugSourceDocumentLanguageId { get; }

        internal abstract void AddDebugSourceDocumentsForChecksumDirectives(DebugDocumentsBuilder documentsBuilder, SyntaxTree tree, DiagnosticBag diagnostics);

        internal abstract bool GenerateResourcesAndDocumentationComments(
                    CommonPEModuleBuilder moduleBeingBuilt,
                    Stream? xmlDocumentationStream,
                    Stream? win32ResourcesStream,
                    string? outputNameOverride,
                    DiagnosticBag diagnostics,
                    CancellationToken cancellationToken);

        internal abstract void ReportUnusedImports(
                    SyntaxTree? filterTree,
                    DiagnosticBag diagnostics,
                    CancellationToken cancellationToken);

        internal abstract void CompleteTrees(SyntaxTree? filterTree);

        internal bool Compile(
                    CommonPEModuleBuilder moduleBuilder,
                    bool emittingPdb,
                    DiagnosticBag diagnostics,
                    Predicate<ISymbolInternal>? filterOpt,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 99140, 99915);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 99446, 99784);

                    return f_145_99453_99783(this, moduleBuilder, emittingPdb, emitMetadataOnly: false, emitTestCoverageData: false, diagnostics: diagnostics, filterOpt: filterOpt, cancellationToken: cancellationToken);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(145, 99813, 99904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 99853, 99889);

                    f_145_99853_99888(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(145, 99813, 99904);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 99140, 99915);

                bool
                f_145_99453_99783(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBuilder, bool
                emittingPdb, bool
                emitMetadataOnly, bool
                emitTestCoverageData, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Predicate<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>?
                filterOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.CompileMethods(moduleBuilder, emittingPdb, emitMetadataOnly: emitMetadataOnly, emitTestCoverageData: emitTestCoverageData, diagnostics: diagnostics, filterOpt: filterOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 99453, 99783);
                    return return_v;
                }


                int
                f_145_99853_99888(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    this_param.CompilationFinished();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 99853, 99888);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 99140, 99915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 99140, 99915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void EnsureAnonymousTypeTemplates(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 99927, 101907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 100031, 100058);

                f_145_100031_100057(f_145_100044_100056());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 100074, 101896) || true) && (f_145_100078_100107(this) >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(145, 100078, 100131) && f_145_100116_100131(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 100074, 101896);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 100165, 101284) || true) && (f_145_100169_100220_M(!f_145_100170_100201(this).AreTemplatesSealed))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 100165, 101284);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 100262, 100317);

                        var
                        discardedDiagnostics = f_145_100289_100316()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 100341, 100806);

                        var
                        moduleBeingBuilt = f_145_100364_100805(this, emitOptions: EmitOptions.Default, debugEntryPoint: null, manifestResources: null, sourceLinkStream: null, embeddedTexts: null, testData: null, diagnostics: discardedDiagnostics, cancellationToken: cancellationToken)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 100830, 101213) || true) && (moduleBeingBuilt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 100830, 101213);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 100908, 101190);

                            f_145_100908_101189(this, moduleBeingBuilt, diagnostics: discardedDiagnostics, emittingPdb: false, filterOpt: null, cancellationToken: cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 100830, 101213);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 101237, 101265);

                        f_145_101237_101264(
                                            discardedDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 100165, 101284);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 101304, 101369);

                    f_145_101304_101368(f_145_101317_101367(f_145_101317_101348(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 100074, 101896);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 100074, 101896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 101585, 101623);

                    var
                    temp = f_145_101596_101622(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 101641, 101881) || true) && (temp != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 101641, 101881);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 101699, 101742);

                        var
                        temp2 = f_145_101711_101741(temp)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 101764, 101862) || true) && (temp2 != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 101764, 101862);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 101808, 101862);

                            f_145_101808_101861(temp2, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 101764, 101862);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 101641, 101881);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 100074, 101896);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 99927, 101907);

                bool
                f_145_100044_100056()
                {
                    var return_v = IsSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 100044, 100056);
                    return return_v;
                }


                int
                f_145_100031_100057(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 100031, 100057);
                    return 0;
                }


                int
                f_145_100078_100107(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.GetSubmissionSlotIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 100078, 100107);
                    return return_v;
                }


                bool
                f_145_100116_100131(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.HasCodeToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 100116, 100131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.CommonAnonymousTypeManager
                f_145_100170_100201(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.CommonAnonymousTypeManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 100170, 100201);
                    return return_v;
                }


                bool
                f_145_100169_100220_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 100169, 100220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_145_100289_100316()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 100289, 100316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?
                f_145_100364_100805(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData?
                testData, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.CreateModuleBuilder(emitOptions: emitOptions, debugEntryPoint: debugEntryPoint, manifestResources: manifestResources, sourceLinkStream: sourceLinkStream, embeddedTexts: embeddedTexts, testData: testData, diagnostics: diagnostics, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 100364, 100805);
                    return return_v;
                }


                bool
                f_145_100908_101189(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                emittingPdb, System.Predicate<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>?
                filterOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Compile(moduleBuilder, diagnostics: diagnostics, emittingPdb: emittingPdb, filterOpt: filterOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 100908, 101189);
                    return return_v;
                }


                int
                f_145_101237_101264(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 101237, 101264);
                    return 0;
                }


                Microsoft.CodeAnalysis.Symbols.CommonAnonymousTypeManager
                f_145_101317_101348(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.CommonAnonymousTypeManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 101317, 101348);
                    return return_v;
                }


                bool
                f_145_101317_101367(Microsoft.CodeAnalysis.Symbols.CommonAnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.AreTemplatesSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 101317, 101367);
                    return return_v;
                }


                int
                f_145_101304_101368(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 101304, 101368);
                    return 0;
                }


                Microsoft.CodeAnalysis.ScriptCompilationInfo?
                f_145_101596_101622(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.ScriptCompilationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 101596, 101622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation?
                f_145_101711_101741(Microsoft.CodeAnalysis.ScriptCompilationInfo
                this_param)
                {
                    var return_v = this_param.PreviousScriptCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 101711, 101741);
                    return return_v;
                }


                int
                f_145_101808_101861(Microsoft.CodeAnalysis.Compilation
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.EnsureAnonymousTypeTemplates(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 101808, 101861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 99927, 101907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 99927, 101907);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public EmitResult Emit(
                    Stream peStream,
                    Stream? pdbStream,
                    Stream? xmlDocumentationStream,
                    Stream? win32Resources,
                    IEnumerable<ResourceDescription>? manifestResources,
                    EmitOptions options,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 101971, 102738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 102368, 102727);

                return f_145_102375_102726(this, peStream, pdbStream, xmlDocumentationStream, win32Resources, manifestResources, options, debugEntryPoint: null, sourceLinkStream: null, embeddedTexts: null, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 101971, 102738);

                Microsoft.CodeAnalysis.Emit.EmitResult
                f_145_102375_102726(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.Stream
                peStream, System.IO.Stream?
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Emit(peStream, pdbStream, xmlDocumentationStream, win32Resources, manifestResources, options, debugEntryPoint: debugEntryPoint, sourceLinkStream: sourceLinkStream, embeddedTexts: embeddedTexts, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 102375, 102726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 101971, 102738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 101971, 102738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public EmitResult Emit(
                    Stream peStream,
                    Stream pdbStream,
                    Stream xmlDocumentationStream,
                    Stream win32Resources,
                    IEnumerable<ResourceDescription> manifestResources,
                    EmitOptions options,
                    IMethodSymbol debugEntryPoint,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 102802, 103603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 103239, 103592);

                return f_145_103246_103591(this, peStream, pdbStream, xmlDocumentationStream, win32Resources, manifestResources, options, debugEntryPoint, sourceLinkStream: null, embeddedTexts: null, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 102802, 103603);

                Microsoft.CodeAnalysis.Emit.EmitResult
                f_145_103246_103591(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.Stream
                peStream, System.IO.Stream
                pdbStream, System.IO.Stream
                xmlDocumentationStream, System.IO.Stream
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                options, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Emit(peStream, pdbStream, xmlDocumentationStream, win32Resources, manifestResources, options, debugEntryPoint, sourceLinkStream: sourceLinkStream, embeddedTexts: embeddedTexts, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 103246, 103591);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 102802, 103603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 102802, 103603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitResult Emit(
                    Stream peStream,
                    Stream? pdbStream,
                    Stream? xmlDocumentationStream,
                    Stream? win32Resources,
                    IEnumerable<ResourceDescription>? manifestResources,
                    EmitOptions options,
                    IMethodSymbol? debugEntryPoint,
                    Stream? sourceLinkStream,
                    IEnumerable<EmbeddedText>? embeddedTexts,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 103667, 104560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 104148, 104549);

                return f_145_104155_104548(this, peStream, pdbStream, xmlDocumentationStream, win32Resources, manifestResources, options, debugEntryPoint, sourceLinkStream, embeddedTexts, metadataPEStream: null, cancellationToken: cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 103667, 104560);

                Microsoft.CodeAnalysis.Emit.EmitResult
                f_145_104155_104548(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.Stream
                peStream, System.IO.Stream?
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, System.IO.Stream?
                metadataPEStream, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Emit(peStream, pdbStream, xmlDocumentationStream, win32Resources, manifestResources, options, debugEntryPoint, sourceLinkStream, embeddedTexts, metadataPEStream: metadataPEStream, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 104155, 104548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 103667, 104560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 103667, 104560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitResult Emit(
                    Stream peStream,
                    Stream? pdbStream = null,
                    Stream? xmlDocumentationStream = null,
                    Stream? win32Resources = null,
                    IEnumerable<ResourceDescription>? manifestResources = null,
                    EmitOptions? options = null,
                    IMethodSymbol? debugEntryPoint = null,
                    Stream? sourceLinkStream = null,
                    IEnumerable<EmbeddedText>? embeddedTexts = null,
                    Stream? metadataPEStream = null,
                    CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 107576, 112358);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 108189, 108308) || true) && (peStream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 108189, 108308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 108243, 108293);

                    throw f_145_108249_108292(nameof(peStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 108189, 108308);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 108324, 108487) || true) && (f_145_108328_108346_M(!peStream.CanWrite))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 108324, 108487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 108380, 108472);

                    throw f_145_108386_108471(f_145_108408_108452(), nameof(peStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 108324, 108487);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 108503, 109236) || true) && (pdbStream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 108503, 109236);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 108558, 108792) || true) && (f_145_108562_108593_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 145, 108562, 108593)?.DebugInformationFormat) == DebugInformationFormat.Embedded)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 108558, 108792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 108670, 108773);

                        throw f_145_108676_108772(f_145_108698_108752(), nameof(pdbStream));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 108558, 108792);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 108812, 108989) || true) && (f_145_108816_108835_M(!pdbStream.CanWrite))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 108812, 108989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 108877, 108970);

                        throw f_145_108883_108969(f_145_108905_108949(), nameof(pdbStream));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 108812, 108989);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 109009, 109221) || true) && (f_145_109013_109038_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 145, 109013, 109038)?.EmitMetadataOnly) == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 109009, 109221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 109088, 109202);

                        throw f_145_109094_109201(f_145_109116_109181(), nameof(pdbStream));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 109009, 109221);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 108503, 109236);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 109252, 109494) || true) && (metadataPEStream != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 109256, 109317) && f_145_109284_109309_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 145, 109284, 109309)?.EmitMetadataOnly) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 109252, 109494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 109351, 109479);

                    throw f_145_109357_109478(f_145_109379_109451(), nameof(metadataPEStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 109252, 109494);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 109510, 109770) || true) && (metadataPEStream != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 109514, 109580) && f_145_109542_109572_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 145, 109542, 109572)?.IncludePrivateMembers) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 109510, 109770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 109614, 109755);

                    throw f_145_109620_109754(f_145_109642_109727(), nameof(metadataPEStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 109510, 109770);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 109786, 110127) || true) && (metadataPEStream == null && (DynAbs.Tracing.TraceSender.Expression_True(145, 109790, 109852) && f_145_109818_109843_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 145, 109818, 109843)?.EmitMetadataOnly) == false))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 109786, 110127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 110062, 110112);

                    options = f_145_110072_110111(options, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 109786, 110127);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 110143, 110436) || true) && (f_145_110147_110178_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 145, 110147, 110178)?.DebugInformationFormat) == DebugInformationFormat.Embedded && (DynAbs.Tracing.TraceSender.Expression_True(145, 110147, 110267) && f_145_110234_110259_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 145, 110234, 110259)?.EmitMetadataOnly) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 110143, 110436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 110301, 110421);

                    throw f_145_110307_110420(f_145_110329_110393(), nameof(metadataPEStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 110143, 110436);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 110452, 111014) || true) && (f_145_110456_110479(f_145_110456_110468(this)) == OutputKind.NetModule)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 110452, 111014);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 110537, 110999) || true) && (metadataPEStream != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 110537, 110999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 110607, 110729);

                        throw f_145_110613_110728(f_145_110635_110701(), nameof(metadataPEStream));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 110537, 110999);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 110537, 110999);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 110771, 110999) || true) && (f_145_110775_110800_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 145, 110775, 110800)?.EmitMetadataOnly) == true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 110771, 110999);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 110850, 110980);

                            throw f_145_110856_110979(f_145_110878_110944(), nameof(options.EmitMetadataOnly));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 110771, 110999);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 110537, 110999);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 110452, 111014);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 111030, 111324) || true) && (win32Resources != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 111030, 111324);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 111090, 111309) || true) && (f_145_111094_111117_M(!win32Resources.CanRead) || (DynAbs.Tracing.TraceSender.Expression_False(145, 111094, 111144) || f_145_111121_111144_M(!win32Resources.CanSeek)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 111090, 111309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 111186, 111290);

                        throw f_145_111192_111289(f_145_111214_111264(), nameof(win32Resources));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 111090, 111309);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 111030, 111324);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 111340, 111545) || true) && (sourceLinkStream != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 111344, 111397) && f_145_111372_111397_M(!sourceLinkStream.CanRead)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 111340, 111545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 111431, 111530);

                    throw f_145_111437_111529(f_145_111459_111502(), nameof(sourceLinkStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 111340, 111545);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 111561, 111903) || true) && (embeddedTexts != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 111565, 111631) && !f_145_111608_111631(embeddedTexts)) && (DynAbs.Tracing.TraceSender.Expression_True(145, 111565, 111669) && pdbStream == null) && (DynAbs.Tracing.TraceSender.Expression_True(145, 111565, 111756) && f_145_111690_111721_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(options, 145, 111690, 111721)?.DebugInformationFormat) != DebugInformationFormat.Embedded))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 111561, 111903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 111790, 111888);

                    throw f_145_111796_111887(f_145_111818_111863(), nameof(embeddedTexts));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 111561, 111903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 111919, 112347);

                return f_145_111926_112346(this, peStream, metadataPEStream, pdbStream, xmlDocumentationStream, win32Resources, manifestResources, options, debugEntryPoint, sourceLinkStream, embeddedTexts, testData: null, cancellationToken: cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 107576, 112358);

                System.ArgumentNullException
                f_145_108249_108292(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 108249, 108292);
                    return return_v;
                }


                bool
                f_145_108328_108346_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 108328, 108346);
                    return return_v;
                }


                string
                f_145_108408_108452()
                {
                    var return_v = CodeAnalysisResources.StreamMustSupportWrite;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 108408, 108452);
                    return return_v;
                }


                System.ArgumentException
                f_145_108386_108471(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 108386, 108471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat?
                f_145_108562_108593_M(Microsoft.CodeAnalysis.Emit.DebugInformationFormat?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 108562, 108593);
                    return return_v;
                }


                string
                f_145_108698_108752()
                {
                    var return_v = CodeAnalysisResources.PdbStreamUnexpectedWhenEmbedding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 108698, 108752);
                    return return_v;
                }


                System.ArgumentException
                f_145_108676_108772(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 108676, 108772);
                    return return_v;
                }


                bool
                f_145_108816_108835_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 108816, 108835);
                    return return_v;
                }


                string
                f_145_108905_108949()
                {
                    var return_v = CodeAnalysisResources.StreamMustSupportWrite;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 108905, 108949);
                    return return_v;
                }


                System.ArgumentException
                f_145_108883_108969(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 108883, 108969);
                    return return_v;
                }


                bool?
                f_145_109013_109038_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 109013, 109038);
                    return return_v;
                }


                string
                f_145_109116_109181()
                {
                    var return_v = CodeAnalysisResources.PdbStreamUnexpectedWhenEmittingMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 109116, 109181);
                    return return_v;
                }


                System.ArgumentException
                f_145_109094_109201(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 109094, 109201);
                    return return_v;
                }


                bool?
                f_145_109284_109309_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 109284, 109309);
                    return return_v;
                }


                string
                f_145_109379_109451()
                {
                    var return_v = CodeAnalysisResources.MetadataPeStreamUnexpectedWhenEmittingMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 109379, 109451);
                    return return_v;
                }


                System.ArgumentException
                f_145_109357_109478(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 109357, 109478);
                    return return_v;
                }


                bool?
                f_145_109542_109572_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 109542, 109572);
                    return return_v;
                }


                string
                f_145_109642_109727()
                {
                    var return_v = CodeAnalysisResources.IncludingPrivateMembersUnexpectedWhenEmittingToMetadataPeStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 109642, 109727);
                    return return_v;
                }


                System.ArgumentException
                f_145_109620_109754(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 109620, 109754);
                    return return_v;
                }


                bool?
                f_145_109818_109843_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 109818, 109843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_145_110072_110111(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, bool
                value)
                {
                    var return_v = this_param.WithIncludePrivateMembers(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 110072, 110111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat?
                f_145_110147_110178_M(Microsoft.CodeAnalysis.Emit.DebugInformationFormat?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 110147, 110178);
                    return return_v;
                }


                bool?
                f_145_110234_110259_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 110234, 110259);
                    return return_v;
                }


                string
                f_145_110329_110393()
                {
                    var return_v = CodeAnalysisResources.EmbeddingPdbUnexpectedWhenEmittingMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 110329, 110393);
                    return return_v;
                }


                System.ArgumentException
                f_145_110307_110420(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 110307, 110420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_110456_110468(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 110456, 110468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_110456_110479(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 110456, 110479);
                    return return_v;
                }


                string
                f_145_110635_110701()
                {
                    var return_v = CodeAnalysisResources.CannotTargetNetModuleWhenEmittingRefAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 110635, 110701);
                    return return_v;
                }


                System.ArgumentException
                f_145_110613_110728(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 110613, 110728);
                    return return_v;
                }


                bool?
                f_145_110775_110800_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 110775, 110800);
                    return return_v;
                }


                string
                f_145_110878_110944()
                {
                    var return_v = CodeAnalysisResources.CannotTargetNetModuleWhenEmittingRefAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 110878, 110944);
                    return return_v;
                }


                System.ArgumentException
                f_145_110856_110979(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 110856, 110979);
                    return return_v;
                }


                bool
                f_145_111094_111117_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 111094, 111117);
                    return return_v;
                }


                bool
                f_145_111121_111144_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 111121, 111144);
                    return return_v;
                }


                string
                f_145_111214_111264()
                {
                    var return_v = CodeAnalysisResources.StreamMustSupportReadAndSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 111214, 111264);
                    return return_v;
                }


                System.ArgumentException
                f_145_111192_111289(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 111192, 111289);
                    return return_v;
                }


                bool
                f_145_111372_111397_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 111372, 111397);
                    return return_v;
                }


                string
                f_145_111459_111502()
                {
                    var return_v = CodeAnalysisResources.StreamMustSupportRead;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 111459, 111502);
                    return return_v;
                }


                System.ArgumentException
                f_145_111437_111529(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 111437, 111529);
                    return return_v;
                }


                bool
                f_145_111608_111631(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.EmbeddedText>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 111608, 111631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat?
                f_145_111690_111721_M(Microsoft.CodeAnalysis.Emit.DebugInformationFormat?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 111690, 111721);
                    return return_v;
                }


                string
                f_145_111818_111863()
                {
                    var return_v = CodeAnalysisResources.EmbeddedTextsRequirePdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 111818, 111863);
                    return return_v;
                }


                System.ArgumentException
                f_145_111796_111887(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 111796, 111887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_145_111926_112346(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.Stream
                peStream, System.IO.Stream?
                metadataPEStream, System.IO.Stream?
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions?
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData?
                testData, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Emit(peStream, metadataPEStream, pdbStream, xmlDocumentationStream, win32Resources, manifestResources, options, debugEntryPoint, sourceLinkStream, embeddedTexts, testData: testData, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 111926, 112346);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 107576, 112358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 107576, 112358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EmitResult Emit(
                    Stream peStream,
                    Stream? metadataPEStream,
                    Stream? pdbStream,
                    Stream? xmlDocumentationStream,
                    Stream? win32Resources,
                    IEnumerable<ResourceDescription>? manifestResources,
                    EmitOptions? options,
                    IMethodSymbol? debugEntryPoint,
                    Stream? sourceLinkStream,
                    IEnumerable<EmbeddedText>? embeddedTexts,
                    CompilationTestData? testData,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 112623, 116922);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 113190, 113283);

                options = options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Emit.EmitOptions?>(145, 113200, 113282) ?? f_145_113211_113282(EmitOptions.Default, metadataPEStream == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 113299, 113381);

                bool
                embedPdb = f_145_113315_113345(options) == DebugInformationFormat.Embedded
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 113395, 113440);

                f_145_113395_113439(!embedPdb || (DynAbs.Tracing.TraceSender.Expression_False(145, 113408, 113438) || pdbStream == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 113454, 113527);

                f_145_113454_113526(metadataPEStream == null || (DynAbs.Tracing.TraceSender.Expression_False(145, 113467, 113525) || f_145_113495_113525_M(!options.IncludePrivateMembers)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 113618, 113664);

                var
                diagnostics = f_145_113636_113663()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 113680, 113995);

                var
                moduleBeingBuilt = f_145_113703_113994(this, diagnostics, manifestResources, options, debugEntryPoint, sourceLinkStream, embeddedTexts, testData, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 114011, 114032);

                bool
                success = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 114048, 116831) || true) && (moduleBeingBuilt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 114048, 116831);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 114154, 114594);

                        success = f_145_114164_114593(this, moduleBeingBuilt, emittingPdb: pdbStream != null || (DynAbs.Tracing.TraceSender.Expression_False(145, 114261, 114290) || embedPdb), emitMetadataOnly: f_145_114335_114359(options), emitTestCoverageData: f_145_114408_114436(options), diagnostics: diagnostics, filterOpt: null, cancellationToken: cancellationToken);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 114618, 115545) || true) && (f_145_114622_114647_M(!options.EmitMetadataOnly))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 114618, 115545);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 114900, 115340) || true) && (!f_145_114905_115239(this, moduleBeingBuilt, xmlDocumentationStream, win32Resources, f_145_115122_115148(options), diagnostics, cancellationToken))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 114900, 115340);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 115297, 115313);

                                success = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 114900, 115340);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 115368, 115522) || true) && (success)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 115368, 115522);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 115437, 115495);

                                f_145_115437_115494(this, null, diagnostics, cancellationToken);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 115368, 115522);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 114618, 115545);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(145, 115582, 115688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 115630, 115669);

                        f_145_115630_115668(moduleBeingBuilt);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(145, 115582, 115688);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 115708, 115744);

                    RSAParameters?
                    privateKeyOpt = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 115762, 115946) || true) && (f_145_115766_115792(f_145_115766_115773()) != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 115766, 115820) && f_145_115804_115820()) && (DynAbs.Tracing.TraceSender.Expression_True(145, 115766, 115843) && f_145_115824_115843_M(!f_145_115825_115832().PublicSign)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 115762, 115946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 115885, 115927);

                        privateKeyOpt = f_145_115901_115915().PrivateKey;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 115762, 115946);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 115966, 116125) || true) && (f_145_115970_115995_M(!options.EmitMetadataOnly) && (DynAbs.Tracing.TraceSender.Expression_True(145, 115970, 116048) && f_145_115999_116048(diagnostics)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 115966, 116125);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 116090, 116106);

                        success = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 115966, 116125);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 116145, 116816) || true) && (success)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 116145, 116816);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 116198, 116797);

                        success = f_145_116208_116796(this, moduleBeingBuilt, f_145_116297_116335(peStream), (DynAbs.Tracing.TraceSender.Conditional_F1(145, 116362, 116388) || (((metadataPEStream != null) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 116391, 116437)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 116440, 116444))) ? f_145_116391_116437(metadataPEStream) : null, (DynAbs.Tracing.TraceSender.Conditional_F1(145, 116471, 116490) || (((pdbStream != null) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 116493, 116532)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 116535, 116539))) ? f_145_116493_116532(pdbStream) : null, DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(testData, 145, 116566, 116592)?.SymWriterFactory, diagnostics, emitOptions: options, privateKeyOpt: privateKeyOpt, cancellationToken: cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 116145, 116816);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 114048, 116831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 116847, 116911);

                return f_145_116854_116910(success, f_145_116878_116909(diagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 112623, 116922);

                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_145_113211_113282(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, bool
                value)
                {
                    var return_v = this_param.WithIncludePrivateMembers(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 113211, 113282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_145_113315_113345(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 113315, 113345);
                    return return_v;
                }


                int
                f_145_113395_113439(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 113395, 113439);
                    return 0;
                }


                bool
                f_145_113495_113525_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 113495, 113525);
                    return return_v;
                }


                int
                f_145_113454_113526(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 113454, 113526);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_145_113636_113663()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 113636, 113663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?
                f_145_113703_113994(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData?
                testData, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.CheckOptionsAndCreateModuleBuilder(diagnostics, manifestResources, options, debugEntryPoint, sourceLinkStream, embeddedTexts, testData, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 113703, 113994);
                    return return_v;
                }


                bool
                f_145_114335_114359(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.EmitMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 114335, 114359);
                    return return_v;
                }


                bool
                f_145_114408_114436(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.EmitTestCoverageData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 114408, 114436);
                    return return_v;
                }


                bool
                f_145_114164_114593(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBuilder, bool
                emittingPdb, bool
                emitMetadataOnly, bool
                emitTestCoverageData, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Predicate<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>?
                filterOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.CompileMethods(moduleBuilder, emittingPdb: emittingPdb, emitMetadataOnly: emitMetadataOnly, emitTestCoverageData: emitTestCoverageData, diagnostics: diagnostics, filterOpt: filterOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 114164, 114593);
                    return return_v;
                }


                bool
                f_145_114622_114647_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 114622, 114647);
                    return return_v;
                }


                string?
                f_145_115122_115148(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.OutputNameOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 115122, 115148);
                    return return_v;
                }


                bool
                f_145_114905_115239(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBeingBuilt, System.IO.Stream?
                xmlDocumentationStream, System.IO.Stream?
                win32ResourcesStream, string?
                outputNameOverride, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GenerateResourcesAndDocumentationComments(moduleBeingBuilt, xmlDocumentationStream, win32ResourcesStream, outputNameOverride, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 114905, 115239);
                    return return_v;
                }


                int
                f_145_115437_115494(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                filterTree, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ReportUnusedImports(filterTree, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 115437, 115494);
                    return 0;
                }


                int
                f_145_115630_115668(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    this_param.CompilationFinished();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 115630, 115668);
                    return 0;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_115766_115773()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 115766, 115773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider?
                f_145_115766_115792(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 115766, 115792);
                    return return_v;
                }


                bool
                f_145_115804_115820()
                {
                    var return_v = SignUsingBuilder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 115804, 115820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_115825_115832()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 115825, 115832);
                    return return_v;
                }


                bool
                f_145_115824_115843_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 115824, 115843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_145_115901_115915()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 115901, 115915);
                    return return_v;
                }


                bool
                f_145_115970_115995_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 115970, 115995);
                    return return_v;
                }


                bool
                f_145_115999_116048(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CommonCompiler.HasUnsuppressedErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 115999, 116048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation.SimpleEmitStreamProvider
                f_145_116297_116335(System.IO.Stream
                stream)
                {
                    var return_v = new Microsoft.CodeAnalysis.Compilation.SimpleEmitStreamProvider(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 116297, 116335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation.SimpleEmitStreamProvider
                f_145_116391_116437(System.IO.Stream
                stream)
                {
                    var return_v = new Microsoft.CodeAnalysis.Compilation.SimpleEmitStreamProvider(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 116391, 116437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation.SimpleEmitStreamProvider
                f_145_116493_116532(System.IO.Stream
                stream)
                {
                    var return_v = new Microsoft.CodeAnalysis.Compilation.SimpleEmitStreamProvider(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 116493, 116532);
                    return return_v;
                }


                bool
                f_145_116208_116796(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBeingBuilt, Microsoft.CodeAnalysis.Compilation.SimpleEmitStreamProvider
                peStreamProvider, Microsoft.CodeAnalysis.Compilation.SimpleEmitStreamProvider?
                metadataPEStreamProvider, Microsoft.CodeAnalysis.Compilation.SimpleEmitStreamProvider?
                pdbStreamProvider, System.Func<Microsoft.DiaSymReader.ISymWriterMetadataProvider, Microsoft.DiaSymReader.SymUnmanagedWriter>?
                testSymWriterFactory, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, System.Security.Cryptography.RSAParameters?
                privateKeyOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.SerializeToPeStream(moduleBeingBuilt, (Microsoft.CodeAnalysis.Compilation.EmitStreamProvider)peStreamProvider, (Microsoft.CodeAnalysis.Compilation.EmitStreamProvider?)metadataPEStreamProvider, (Microsoft.CodeAnalysis.Compilation.EmitStreamProvider?)pdbStreamProvider, testSymWriterFactory, diagnostics, emitOptions: emitOptions, privateKeyOpt: privateKeyOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 116208, 116796);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_145_116878_116909(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 116878, 116909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_145_116854_116910(bool
                success, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitResult(success, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 116854, 116910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 112623, 116922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 112623, 116922);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitDifferenceResult EmitDifference(
                    EmitBaseline baseline,
                    IEnumerable<SemanticEdit> edits,
                    Stream metadataStream,
                    Stream ilStream,
                    Stream pdbStream,
                    ICollection<MethodDefinitionHandle> updatedMethods,
                    CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 117369, 117894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 117760, 117883);

                return f_145_117767_117882(this, baseline, edits, s => false, metadataStream, ilStream, pdbStream, updatedMethods, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 117369, 117894);

                Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
                f_145_117767_117882(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits, System.Func<Microsoft.CodeAnalysis.ISymbol, bool>
                isAddedSymbol, System.IO.Stream
                metadataStream, System.IO.Stream
                ilStream, System.IO.Stream
                pdbStream, System.Collections.Generic.ICollection<System.Reflection.Metadata.MethodDefinitionHandle>
                updatedMethods, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.EmitDifference(baseline, edits, isAddedSymbol, metadataStream, ilStream, pdbStream, updatedMethods, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 117767, 117882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 117369, 117894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 117369, 117894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitDifferenceResult EmitDifference(
                    EmitBaseline baseline,
                    IEnumerable<SemanticEdit> edits,
                    Func<ISymbol, bool> isAddedSymbol,
                    Stream metadataStream,
                    Stream ilStream,
                    Stream pdbStream,
                    ICollection<MethodDefinitionHandle> updatedMethods,
                    CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 118341, 119898);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 118780, 118899) || true) && (baseline == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 118780, 118899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 118834, 118884);

                    throw f_145_118840_118883(nameof(baseline));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 118780, 118899);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119047, 119160) || true) && (edits == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 119047, 119160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119098, 119145);

                    throw f_145_119104_119144(nameof(edits));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 119047, 119160);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119176, 119305) || true) && (isAddedSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 119176, 119305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119235, 119290);

                    throw f_145_119241_119289(nameof(isAddedSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 119176, 119305);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119321, 119452) || true) && (metadataStream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 119321, 119452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119381, 119437);

                    throw f_145_119387_119436(nameof(metadataStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 119321, 119452);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119468, 119587) || true) && (ilStream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 119468, 119587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119522, 119572);

                    throw f_145_119528_119571(nameof(ilStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 119468, 119587);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119603, 119724) || true) && (pdbStream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 119603, 119724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119658, 119709);

                    throw f_145_119664_119708(nameof(pdbStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 119603, 119724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 119740, 119887);

                return f_145_119747_119886(this, baseline, edits, isAddedSymbol, metadataStream, ilStream, pdbStream, updatedMethods, testData: null, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 118341, 119898);

                System.ArgumentNullException
                f_145_118840_118883(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 118840, 118883);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_119104_119144(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 119104, 119144);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_119241_119289(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 119241, 119289);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_119387_119436(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 119387, 119436);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_119528_119571(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 119528, 119571);
                    return return_v;
                }


                System.ArgumentNullException
                f_145_119664_119708(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 119664, 119708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
                f_145_119747_119886(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits, System.Func<Microsoft.CodeAnalysis.ISymbol, bool>
                isAddedSymbol, System.IO.Stream
                metadataStream, System.IO.Stream
                ilStream, System.IO.Stream
                pdbStream, System.Collections.Generic.ICollection<System.Reflection.Metadata.MethodDefinitionHandle>
                updatedMethodHandles, Microsoft.CodeAnalysis.CodeGen.CompilationTestData?
                testData, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.EmitDifference(baseline, edits, isAddedSymbol, metadataStream, ilStream, pdbStream, updatedMethodHandles, testData: testData, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 119747, 119886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 118341, 119898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 118341, 119898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract EmitDifferenceResult EmitDifference(
                    EmitBaseline baseline,
                    IEnumerable<SemanticEdit> edits,
                    Func<ISymbol, bool> isAddedSymbol,
                    Stream metadataStream,
                    Stream ilStream,
                    Stream pdbStream,
                    ICollection<MethodDefinitionHandle> updatedMethodHandles,
                    CompilationTestData? testData,
                    CancellationToken cancellationToken);

        internal CommonPEModuleBuilder? CheckOptionsAndCreateModuleBuilder(
                    DiagnosticBag diagnostics,
                    IEnumerable<ResourceDescription>? manifestResources,
                    EmitOptions options,
                    IMethodSymbol? debugEntryPoint,
                    Stream? sourceLinkStream,
                    IEnumerable<EmbeddedText>? embeddedTexts,
                    CompilationTestData? testData,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 120586, 122738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 121051, 121128);

                f_145_121051_121127(options, diagnostics, f_145_121088_121103(), f_145_121105_121126(f_145_121105_121112()));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 121144, 121274) || true) && (debugEntryPoint != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 121144, 121274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 121205, 121259);

                    f_145_121205_121258(this, debugEntryPoint, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 121144, 121274);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 121290, 121815) || true) && (f_145_121294_121312(f_145_121294_121301()) == OutputKind.NetModule && (DynAbs.Tracing.TraceSender.Expression_True(145, 121294, 121365) && manifestResources != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 121290, 121815);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 121399, 121800);
                        foreach (ResourceDescription res in f_145_121435_121452_I(manifestResources))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 121399, 121800);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 121494, 121781) || true) && (res.FileName != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 121494, 121781);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 121655, 121758);

                                f_145_121655_121757(                        // Modules can have only embedded resources, not linked ones.
                                                        diagnostics, f_145_121671_121756(f_145_121671_121686(), f_145_121704_121740(f_145_121704_121719()), f_145_121742_121755()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 121494, 121781);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 121399, 121800);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 402);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 402);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 121290, 121815);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 121831, 121947) || true) && (f_145_121835_121886(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 121831, 121947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 121920, 121932);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 121831, 121947);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 122139, 122422) || true) && (f_145_122143_122155() && (DynAbs.Tracing.TraceSender.Expression_True(145, 122143, 122175) && !f_145_122160_122175(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 122139, 122422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 122316, 122377);

                    f_145_122316_122376(                // Still report diagnostics since downstream submissions will assume there are no errors.
                                    diagnostics, f_145_122337_122375(this, cancellationToken));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 122395, 122407);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 122139, 122422);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 122438, 122727);

                return f_145_122445_122726(this, options, debugEntryPoint, sourceLinkStream, embeddedTexts, manifestResources, testData, diagnostics, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 120586, 122738);

                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_121088_121103()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 121088, 121103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_121105_121112()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 121105, 121112);
                    return return_v;
                }


                bool
                f_145_121105_121126(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.Deterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 121105, 121126);
                    return return_v;
                }


                int
                f_145_121051_121127(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isDeterministic)
                {
                    this_param.ValidateOptions(diagnostics, messageProvider, isDeterministic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 121051, 121127);
                    return 0;
                }


                int
                f_145_121205_121258(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateDebugEntryPoint(debugEntryPoint, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 121205, 121258);
                    return 0;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_121294_121301()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 121294, 121301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_145_121294_121312(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 121294, 121312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_121671_121686()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 121671, 121686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_121704_121719()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 121704, 121719);
                    return return_v;
                }


                int
                f_145_121704_121740(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_ResourceInModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 121704, 121740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_121742_121755()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 121742, 121755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_121671_121756(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.CreateDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 121671, 121756);
                    return return_v;
                }


                int
                f_145_121655_121757(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 121655, 121757);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                f_145_121435_121452_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 121435, 121452);
                    return return_v;
                }


                bool
                f_145_121835_121886(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CommonCompiler.HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 121835, 121886);
                    return return_v;
                }


                bool
                f_145_122143_122155()
                {
                    var return_v = IsSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 122143, 122155);
                    return return_v;
                }


                bool
                f_145_122160_122175(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.HasCodeToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 122160, 122175);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_145_122337_122375(Microsoft.CodeAnalysis.Compilation
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnostics(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 122337, 122375);
                    return return_v;
                }


                int
                f_145_122316_122376(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 122316, 122376);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?
                f_145_122445_122726(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.CodeGen.CompilationTestData?
                testData, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.CreateModuleBuilder(emitOptions, debugEntryPoint, sourceLinkStream, embeddedTexts, manifestResources, testData, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 122445, 122726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 120586, 122738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 120586, 122738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract void ValidateDebugEntryPoint(IMethodSymbol debugEntryPoint, DiagnosticBag diagnostics);

        internal bool IsEmitDeterministic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 122901, 122930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 122904, 122930);
                    return f_145_122904_122930(f_145_122904_122916(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(145, 122901, 122930);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 122901, 122930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 122901, 122930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool SerializeToPeStream(
                    CommonPEModuleBuilder moduleBeingBuilt,
                    EmitStreamProvider peStreamProvider,
                    EmitStreamProvider? metadataPEStreamProvider,
                    EmitStreamProvider? pdbStreamProvider,
                    Func<ISymWriterMetadataProvider, SymUnmanagedWriter>? testSymWriterFactory,
                    DiagnosticBag diagnostics,
                    EmitOptions emitOptions,
                    RSAParameters? privateKeyOpt,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 122943, 129783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 123476, 123525);

                cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 123541, 123579);

                Cci.PdbWriter?
                nativePdbWriter = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 123593, 123635);

                DiagnosticBag?
                metadataDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 123649, 123678);

                DiagnosticBag?
                pdbBag = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 123694, 123735);

                bool
                deterministic = f_145_123715_123734()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 123850, 123968);

                f_145_123850_123967(f_145_123863_123902(moduleBeingBuilt) != DebugInformationFormat.Embedded || (DynAbs.Tracing.TraceSender.Expression_False(145, 123863, 123966) || pdbStreamProvider == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 123984, 124032);

                string?
                pePdbFilePath = f_145_124008_124031(emitOptions)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 124048, 124384) || true) && (f_145_124052_124091(moduleBeingBuilt) == DebugInformationFormat.Embedded || (DynAbs.Tracing.TraceSender.Expression_False(145, 124052, 124155) || pdbStreamProvider != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 124048, 124384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 124189, 124282);

                    pePdbFilePath = pePdbFilePath ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(145, 124205, 124281) ?? f_145_124222_124281(f_145_124256_124273(f_145_124256_124268()), "pdb"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 124048, 124384);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 124048, 124384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 124348, 124369);

                    pePdbFilePath = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 124048, 124384);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 124400, 124630) || true) && (f_145_124404_124443(moduleBeingBuilt) == DebugInformationFormat.Embedded && (DynAbs.Tracing.TraceSender.Expression_True(145, 124404, 124524) && !f_145_124483_124524(pePdbFilePath)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 124400, 124630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 124558, 124615);

                    pePdbFilePath = f_145_124574_124614(pePdbFilePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 124400, 124630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 124646, 124678);

                EmitStream?
                emitPeStream = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 124692, 124730);

                EmitStream?
                emitMetadataStream = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 124780, 124972);

                    var
                    signKind = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 124795, 124807) || ((f_145_124795_124807() && DynAbs.Tracing.TraceSender.Conditional_F2(145, 124831, 124924)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 124948, 124971))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(145, 124832, 124848) || ((f_145_124832_124848() && DynAbs.Tracing.TraceSender.Conditional_F2(145, 124851, 124887)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 124890, 124923))) ? EmitStreamSignKind.SignedWithBuilder : EmitStreamSignKind.SignedWithFile)
                    : EmitStreamSignKind.None
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 124990, 125076);

                    emitPeStream = f_145_125005_125075(peStreamProvider, signKind, f_145_125048_125074(f_145_125048_125055()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 125094, 125278);

                    emitMetadataStream = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 125115, 125147) || ((metadataPEStreamProvider == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(145, 125171, 125175)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 125199, 125277))) ? null
                    : f_145_125199_125277(metadataPEStreamProvider, signKind, f_145_125250_125276(f_145_125250_125257()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 125296, 125346);

                    metadataDiagnostics = f_145_125318_125345();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 125366, 126155) || true) && (f_145_125370_125409(moduleBeingBuilt) == DebugInformationFormat.Pdb && (DynAbs.Tracing.TraceSender.Expression_True(145, 125370, 125468) && pdbStreamProvider != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 125366, 126155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 125610, 125693);

                        f_145_125610_125692(!deterministic || (DynAbs.Tracing.TraceSender.Expression_False(145, 125623, 125691) || moduleBeingBuilt.PdbChecksumAlgorithm.Name != null));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 125998, 126136);

                        nativePdbWriter = f_145_126016_126135(pePdbFilePath, testSymWriterFactory, (DynAbs.Tracing.TraceSender.Conditional_F1(145, 126071, 126084) || ((deterministic && DynAbs.Tracing.TraceSender.Conditional_F2(145, 126087, 126124)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 126127, 126134))) ? f_145_126087_126124(moduleBeingBuilt) : default);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 125366, 126155);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 126175, 126484);

                    Func<Stream?>?
                    getPortablePdbStream =
                    (DynAbs.Tracing.TraceSender.Conditional_F1(145, 126234, 126340) || ((f_145_126234_126273(moduleBeingBuilt) != DebugInformationFormat.PortablePdb || (DynAbs.Tracing.TraceSender.Expression_False(145, 126234, 126340) || pdbStreamProvider == null
                    ) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 126364, 126368)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 126392, 126483))) ? null
                    : (Func<Stream?>)(() => ConditionalGetOrCreateStream(pdbStreamProvider, metadataDiagnostics))
                    ;

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 126548, 127865) || true) && (f_145_126552_127297(moduleBeingBuilt, metadataDiagnostics, f_145_126687_126702(), f_145_126729_126782(emitPeStream, metadataDiagnostics), f_145_126809_126869_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(emitMetadataStream, 145, 126809, 126869)?.GetCreateStreamFunc(metadataDiagnostics)), getPortablePdbStream, nativePdbWriter, pePdbFilePath, f_145_127025_127053(emitOptions), f_145_127080_127113(emitOptions), deterministic, f_145_127180_127212(emitOptions), privateKeyOpt, cancellationToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 126548, 127865);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 127347, 127842) || true) && (nativePdbWriter != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 127347, 127842);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 127432, 127512);

                                var
                                nativePdbStream = f_145_127454_127511(pdbStreamProvider!, metadataDiagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 127542, 127618);

                                f_145_127542_127617(nativePdbStream != null || (DynAbs.Tracing.TraceSender.Expression_False(145, 127555, 127616) || f_145_127582_127616(metadataDiagnostics)));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 127650, 127815) || true) && (nativePdbStream != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 127650, 127815);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 127743, 127784);

                                    f_145_127743_127783(nativePdbWriter, nativePdbStream);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 127650, 127815);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 127347, 127842);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 126548, 127865);
                        }
                    }
                    catch (SymUnmanagedWriterException ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 127902, 128150);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 127981, 128096);

                        f_145_127981_128095(diagnostics, f_145_127997_128094(f_145_127997_128012(), f_145_128030_128066(f_145_128030_128045()), f_145_128068_128081(), f_145_128083_128093(ex)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 128118, 128131);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(145, 127902, 128150);
                    }
                    catch (Cci.PeWritingException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 128168, 128434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 128241, 128380);

                        f_145_128241_128379(diagnostics, f_145_128257_128378(f_145_128257_128272(), f_145_128290_128326(f_145_128290_128305()), f_145_128328_128341(), f_145_128343_128371_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_145_128343_128359(e), 145, 128343, 128371).ToString()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(145, 128343, 128377) ?? "")));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 128402, 128415);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(145, 128168, 128434);
                    }
                    catch (ResourceException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 128452, 128721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 128520, 128667);

                        f_145_128520_128666(diagnostics, f_145_128536_128665(f_145_128536_128551(), f_145_128569_128605(f_145_128569_128584()), f_145_128607_128620(), f_145_128622_128631(e), f_145_128633_128658_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_145_128633_128649(e), 145, 128633, 128658)?.Message) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(145, 128633, 128664) ?? "")));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 128689, 128702);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(145, 128452, 128721);
                    }
                    catch (PermissionSetFileReadException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 128739, 129035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 128820, 128981);

                        f_145_128820_128980(diagnostics, f_145_128836_128979(f_145_128836_128851(), f_145_128869_128924(f_145_128869_128884()), f_145_128926_128939(), f_145_128941_128951(e), f_145_128953_128967(e), f_145_128969_128978(e)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129003, 129016);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(145, 128739, 129035);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129102, 129271) || true) && (!f_145_129107_129197(this, diagnostics, ref metadataDiagnostics, cancellationToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 129102, 129271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129239, 129252);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 129102, 129271);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129291, 129496);

                    return
                    f_145_129319_129386(emitPeStream, f_145_129341_129355(), f_145_129357_129372(), diagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(145, 129319, 129495) && (f_145_129412_129486_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(emitMetadataStream, 145, 129412, 129486)?.Complete(f_145_129441_129455(), f_145_129457_129472(), diagnostics)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(145, 129412, 129494) ?? true)));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(145, 129525, 129772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129565, 129592);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(nativePdbWriter, 145, 129565, 129591)?.Dispose(), 145, 129581, 129591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129610, 129632);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(emitPeStream, 145, 129610, 129631)?.Close(), 145, 129623, 129631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129650, 129678);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(emitMetadataStream, 145, 129650, 129677)?.Close(), 145, 129669, 129677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129696, 129711);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(pdbBag, 145, 129696, 129710)?.Free(), 145, 129703, 129710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129729, 129757);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(metadataDiagnostics, 145, 129729, 129756)?.Free(), 145, 129749, 129756);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(145, 129525, 129772);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 122943, 129783);

                bool
                f_145_123715_123734()
                {
                    var return_v = IsEmitDeterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 123715, 123734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_145_123863_123902(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 123863, 123902);
                    return return_v;
                }


                int
                f_145_123850_123967(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 123850, 123967);
                    return 0;
                }


                string?
                f_145_124008_124031(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 124008, 124031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_145_124052_124091(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 124052, 124091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IModuleSymbol
                f_145_124256_124268()
                {
                    var return_v = SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 124256, 124268);
                    return return_v;
                }


                string
                f_145_124256_124273(Microsoft.CodeAnalysis.IModuleSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 124256, 124273);
                    return return_v;
                }


                string?
                f_145_124222_124281(string
                path, string
                extension)
                {
                    var return_v = FileNameUtilities.ChangeExtension(path, extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 124222, 124281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_145_124404_124443(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 124404, 124443);
                    return return_v;
                }


                bool
                f_145_124483_124524(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 124483, 124524);
                    return return_v;
                }


                string?
                f_145_124574_124614(string
                path)
                {
                    var return_v = PathUtilities.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 124574, 124614);
                    return return_v;
                }


                bool
                f_145_124795_124807()
                {
                    var return_v = IsRealSigned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 124795, 124807);
                    return return_v;
                }


                bool
                f_145_124832_124848()
                {
                    var return_v = SignUsingBuilder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 124832, 124848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_125048_125055()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 125048, 125055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider?
                f_145_125048_125074(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 125048, 125074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation.EmitStream
                f_145_125005_125075(Microsoft.CodeAnalysis.Compilation.EmitStreamProvider
                emitStreamProvider, Microsoft.CodeAnalysis.Compilation.EmitStreamSignKind
                emitStreamSignKind, Microsoft.CodeAnalysis.StrongNameProvider?
                strongNameProvider)
                {
                    var return_v = new Microsoft.CodeAnalysis.Compilation.EmitStream(emitStreamProvider, emitStreamSignKind, strongNameProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 125005, 125075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_145_125250_125257()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 125250, 125257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider?
                f_145_125250_125276(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 125250, 125276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation.EmitStream
                f_145_125199_125277(Microsoft.CodeAnalysis.Compilation.EmitStreamProvider
                emitStreamProvider, Microsoft.CodeAnalysis.Compilation.EmitStreamSignKind
                emitStreamSignKind, Microsoft.CodeAnalysis.StrongNameProvider?
                strongNameProvider)
                {
                    var return_v = new Microsoft.CodeAnalysis.Compilation.EmitStream(emitStreamProvider, emitStreamSignKind, strongNameProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 125199, 125277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_145_125318_125345()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 125318, 125345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_145_125370_125409(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 125370, 125409);
                    return return_v;
                }


                int
                f_145_125610_125692(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 125610, 125692);
                    return 0;
                }


                System.Security.Cryptography.HashAlgorithmName
                f_145_126087_126124(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.PdbChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 126087, 126124);
                    return return_v;
                }


                Microsoft.Cci.PdbWriter
                f_145_126016_126135(string?
                fileName, System.Func<Microsoft.DiaSymReader.ISymWriterMetadataProvider, Microsoft.DiaSymReader.SymUnmanagedWriter>?
                symWriterFactory, System.Security.Cryptography.HashAlgorithmName
                hashAlgorithmNameOpt)
                {
                    var return_v = new Microsoft.Cci.PdbWriter(fileName, symWriterFactory, hashAlgorithmNameOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 126016, 126135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_145_126234_126273(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 126234, 126273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_126687_126702()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 126687, 126702);
                    return return_v;
                }


                System.Func<System.IO.Stream?>
                f_145_126729_126782(Microsoft.CodeAnalysis.Compilation.EmitStream
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetCreateStreamFunc(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 126729, 126782);
                    return return_v;
                }


                System.Func<System.IO.Stream?>?
                f_145_126809_126869_I(System.Func<System.IO.Stream?>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 126809, 126869);
                    return return_v;
                }


                bool
                f_145_127025_127053(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.EmitMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 127025, 127053);
                    return return_v;
                }


                bool
                f_145_127080_127113(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.IncludePrivateMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 127080, 127113);
                    return return_v;
                }


                bool
                f_145_127180_127212(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.EmitTestCoverageData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 127180, 127212);
                    return return_v;
                }


                bool
                f_145_126552_127297(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBeingBuilt, Microsoft.CodeAnalysis.DiagnosticBag
                metadataDiagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Func<System.IO.Stream?>
                getPeStream, System.Func<System.IO.Stream?>?
                getMetadataPeStreamOpt, System.Func<System.IO.Stream?>?
                getPortablePdbStreamOpt, Microsoft.Cci.PdbWriter?
                nativePdbWriterOpt, string?
                pdbPathOpt, bool
                metadataOnly, bool
                includePrivateMembers, bool
                isDeterministic, bool
                emitTestCoverageData, System.Security.Cryptography.RSAParameters?
                privateKeyOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = SerializePeToStream(moduleBeingBuilt, metadataDiagnostics, messageProvider, getPeStream, getMetadataPeStreamOpt, getPortablePdbStreamOpt, nativePdbWriterOpt, pdbPathOpt, metadataOnly, includePrivateMembers, isDeterministic, emitTestCoverageData, privateKeyOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 126552, 127297);
                    return return_v;
                }


                System.IO.Stream?
                f_145_127454_127511(Microsoft.CodeAnalysis.Compilation.EmitStreamProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetOrCreateStream(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 127454, 127511);
                    return return_v;
                }


                bool
                f_145_127582_127616(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 127582, 127616);
                    return return_v;
                }


                int
                f_145_127542_127617(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 127542, 127617);
                    return 0;
                }


                int
                f_145_127743_127783(Microsoft.Cci.PdbWriter
                this_param, System.IO.Stream
                stream)
                {
                    this_param.WriteTo(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 127743, 127783);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_127997_128012()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 127997, 128012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_128030_128045()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128030, 128045);
                    return return_v;
                }


                int
                f_145_128030_128066(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_PdbWritingFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128030, 128066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_128068_128081()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128068, 128081);
                    return return_v;
                }


                string
                f_145_128083_128093(Microsoft.DiaSymReader.SymUnmanagedWriterException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128083, 128093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_127997_128094(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 127997, 128094);
                    return return_v;
                }


                int
                f_145_127981_128095(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 127981, 128095);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_128257_128272()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128257, 128272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_128290_128305()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128290, 128305);
                    return return_v;
                }


                int
                f_145_128290_128326(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_PeWritingFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128290, 128326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_128328_128341()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128328, 128341);
                    return return_v;
                }


                System.Exception?
                f_145_128343_128359(Microsoft.Cci.PeWritingException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128343, 128359);
                    return return_v;
                }


                string?
                f_145_128343_128371_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 128343, 128371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_128257_128378(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 128257, 128378);
                    return return_v;
                }


                int
                f_145_128241_128379(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 128241, 128379);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_128536_128551()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128536, 128551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_128569_128584()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128569, 128584);
                    return return_v;
                }


                int
                f_145_128569_128605(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantReadResource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128569, 128605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_128607_128620()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128607, 128620);
                    return return_v;
                }


                string
                f_145_128622_128631(Microsoft.CodeAnalysis.ResourceException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128622, 128631);
                    return return_v;
                }


                System.Exception?
                f_145_128633_128649(Microsoft.CodeAnalysis.ResourceException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128633, 128649);
                    return return_v;
                }


                string?
                f_145_128633_128658_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128633, 128658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_128536_128665(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 128536, 128665);
                    return return_v;
                }


                int
                f_145_128520_128666(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 128520, 128666);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_128836_128851()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128836, 128851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_128869_128884()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128869, 128884);
                    return return_v;
                }


                int
                f_145_128869_128924(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_PermissionSetAttributeFileReadError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128869, 128924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_128926_128939()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128926, 128939);
                    return return_v;
                }


                string
                f_145_128941_128951(Microsoft.CodeAnalysis.CodeGen.PermissionSetFileReadException
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128941, 128951);
                    return return_v;
                }


                string
                f_145_128953_128967(Microsoft.CodeAnalysis.CodeGen.PermissionSetFileReadException
                this_param)
                {
                    var return_v = this_param.PropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128953, 128967);
                    return return_v;
                }


                string
                f_145_128969_128978(Microsoft.CodeAnalysis.CodeGen.PermissionSetFileReadException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 128969, 128978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_128836_128979(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 128836, 128979);
                    return return_v;
                }


                int
                f_145_128820_128980(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 128820, 128980);
                    return 0;
                }


                bool
                f_145_129107_129197(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                accumulator, ref Microsoft.CodeAnalysis.DiagnosticBag
                incoming, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.FilterAndAppendAndFreeDiagnostics(accumulator, ref incoming, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 129107, 129197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_145_129341_129355()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 129341, 129355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_129357_129372()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 129357, 129372);
                    return return_v;
                }


                bool
                f_145_129319_129386(Microsoft.CodeAnalysis.Compilation.EmitStream
                this_param, Microsoft.CodeAnalysis.StrongNameKeys
                strongNameKeys, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Complete(strongNameKeys, messageProvider, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 129319, 129386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_145_129441_129455()
                {
                    var return_v = StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 129441, 129455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_129457_129472()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 129457, 129472);
                    return return_v;
                }


                bool?
                f_145_129412_129486_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 129412, 129486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 122943, 129783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 122943, 129783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Stream? ConditionalGetOrCreateStream(EmitStreamProvider metadataPEStreamProvider, DiagnosticBag metadataDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 129795, 130272);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 129951, 130050) || true) && (f_145_129955_129989(metadataDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 129951, 130050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 130023, 130035);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 129951, 130050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 130066, 130146);

                var
                auxStream = f_145_130082_130145(metadataPEStreamProvider, metadataDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 130160, 130230);

                f_145_130160_130229(auxStream != null || (DynAbs.Tracing.TraceSender.Expression_False(145, 130173, 130228) || f_145_130194_130228(metadataDiagnostics)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 130244, 130261);

                return auxStream;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 129795, 130272);

                bool
                f_145_129955_129989(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 129955, 129989);
                    return return_v;
                }


                System.IO.Stream?
                f_145_130082_130145(Microsoft.CodeAnalysis.Compilation.EmitStreamProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetOrCreateStream(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 130082, 130145);
                    return return_v;
                }


                bool
                f_145_130194_130228(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 130194, 130228);
                    return return_v;
                }


                int
                f_145_130160_130229(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 130160, 130229);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 129795, 130272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 129795, 130272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool SerializePeToStream(
                    CommonPEModuleBuilder moduleBeingBuilt,
                    DiagnosticBag metadataDiagnostics,
                    CommonMessageProvider messageProvider,
                    Func<Stream?> getPeStream,
                    Func<Stream?>? getMetadataPeStreamOpt,
                    Func<Stream?>? getPortablePdbStreamOpt,
                    Cci.PdbWriter? nativePdbWriterOpt,
                    string? pdbPathOpt,
                    bool metadataOnly,
                    bool includePrivateMembers,
                    bool isDeterministic,
                    bool emitTestCoverageData,
                    RSAParameters? privateKeyOpt,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 130284, 132847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 130970, 131030);

                bool
                emitSecondaryAssembly = getMetadataPeStreamOpt != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 131046, 131134);

                bool
                includePrivateMembersOnPrimaryOutput = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 131090, 131102) || ((metadataOnly && DynAbs.Tracing.TraceSender.Conditional_F2(145, 131105, 131126)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 131129, 131133))) ? includePrivateMembers : true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 131148, 131242);

                bool
                deterministicPrimaryOutput = (metadataOnly && (DynAbs.Tracing.TraceSender.Expression_True(145, 131183, 131221) && !includePrivateMembers)) || (DynAbs.Tracing.TraceSender.Expression_False(145, 131182, 131241) || isDeterministic)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 131256, 131838) || true) && (!f_145_131261_131776(f_145_131308_131420(moduleBeingBuilt, null, metadataDiagnostics, metadataOnly, includePrivateMembersOnPrimaryOutput), messageProvider, getPeStream, getPortablePdbStreamOpt, nativePdbWriterOpt, pdbPathOpt, metadataOnly, deterministicPrimaryOutput, emitTestCoverageData, privateKeyOpt, cancellationToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 131256, 131838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 131810, 131823);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 131256, 131838);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 131924, 132808) || true) && (emitSecondaryAssembly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 131924, 132808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 131983, 132011);

                    f_145_131983_132010(!metadataOnly);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 132029, 132066);

                    f_145_132029_132065(!includePrivateMembers);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 132086, 132793) || true) && (!f_145_132091_132719(f_145_132142_132252(moduleBeingBuilt, null, metadataDiagnostics, metadataOnly: true, includePrivateMembers: false), messageProvider, getMetadataPeStreamOpt, getPortablePdbStreamOpt: null, nativePdbWriterOpt: null, pdbPathOpt: null, metadataOnly: true, isDeterministic: true, emitTestCoverageData: false, privateKeyOpt: privateKeyOpt, cancellationToken: cancellationToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 132086, 132793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 132761, 132774);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 132086, 132793);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 131924, 132808);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 132824, 132836);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 130284, 132847);

                Microsoft.CodeAnalysis.Emit.EmitContext
                f_145_131308_131420(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext(module, syntaxNodeOpt, diagnostics, metadataOnly, includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 131308, 131420);
                    return return_v;
                }


                bool
                f_145_131261_131776(Microsoft.CodeAnalysis.Emit.EmitContext
                context, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Func<System.IO.Stream?>
                getPeStream, System.Func<System.IO.Stream?>?
                getPortablePdbStreamOpt, Microsoft.Cci.PdbWriter?
                nativePdbWriterOpt, string?
                pdbPathOpt, bool
                metadataOnly, bool
                isDeterministic, bool
                emitTestCoverageData, System.Security.Cryptography.RSAParameters?
                privateKeyOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Cci.PeWriter.WritePeToStream(context, messageProvider, getPeStream, getPortablePdbStreamOpt, nativePdbWriterOpt, pdbPathOpt, metadataOnly, isDeterministic, emitTestCoverageData, privateKeyOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 131261, 131776);
                    return return_v;
                }


                int
                f_145_131983_132010(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 131983, 132010);
                    return 0;
                }


                int
                f_145_132029_132065(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 132029, 132065);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_145_132142_132252(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext(module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 132142, 132252);
                    return return_v;
                }


                bool
                f_145_132091_132719(Microsoft.CodeAnalysis.Emit.EmitContext
                context, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Func<System.IO.Stream?>?
                getPeStream, System.Func<System.IO.Stream>
                getPortablePdbStreamOpt, Microsoft.Cci.PdbWriter
                nativePdbWriterOpt, string
                pdbPathOpt, bool
                metadataOnly, bool
                isDeterministic, bool
                emitTestCoverageData, System.Security.Cryptography.RSAParameters?
                privateKeyOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Cci.PeWriter.WritePeToStream(context, messageProvider, getPeStream, getPortablePdbStreamOpt: getPortablePdbStreamOpt, nativePdbWriterOpt: nativePdbWriterOpt, pdbPathOpt: pdbPathOpt, metadataOnly: metadataOnly, isDeterministic: isDeterministic, emitTestCoverageData: emitTestCoverageData, privateKeyOpt: privateKeyOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 132091, 132719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 130284, 132847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 130284, 132847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EmitBaseline? SerializeToDeltaStreams(
                    CommonPEModuleBuilder moduleBeingBuilt,
                    EmitBaseline baseline,
                    DefinitionMap definitionMap,
                    SymbolChanges changes,
                    Stream metadataStream,
                    Stream ilStream,
                    Stream pdbStream,
                    ICollection<MethodDefinitionHandle> updatedMethods,
                    DiagnosticBag diagnostics,
                    Func<ISymWriterMetadataProvider, SymUnmanagedWriter> testSymWriterFactory,
                    string pdbFilePath,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 132859, 135860);
                System.Reflection.Metadata.Ecma335.MetadataSizes metadataSizes = default(System.Reflection.Metadata.Ecma335.MetadataSizes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 133471, 133805);

                var
                nativePdbWriterOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(145, 133496, 133567) || (((f_145_133497_133536(moduleBeingBuilt) != DebugInformationFormat.Pdb) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 133570, 133574)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 133594, 133804))) ? null : f_145_133594_133804(pdbFilePath ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(145, 133634, 133708) ?? f_145_133649_133708(f_145_133683_133700(f_145_133683_133695()), "pdb")), testSymWriterFactory, hashAlgorithmNameOpt: default)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 133821, 135849);
                using (nativePdbWriterOpt)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 133880, 133997);

                    var
                    context = f_145_133894_133996(moduleBeingBuilt, null, diagnostics, metadataOnly: false, includePrivateMembers: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 134015, 134042);

                    var
                    encId = Guid.NewGuid()
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 134106, 134405);

                        var
                        writer = f_145_134119_134404(context, f_145_134203_134218(), baseline, encId, definitionMap, changes, cancellationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 134429, 134709);

                        f_145_134429_134708(
                                            writer, nativePdbWriterOpt, metadataStream, ilStream, (DynAbs.Tracing.TraceSender.Conditional_F1(145, 134602, 134630) || (((nativePdbWriterOpt == null) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 134633, 134642)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 134645, 134649))) ? pdbStream : null, out metadataSizes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 134733, 134772);

                        f_145_134733_134771(
                                            writer, updatedMethods);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 134796, 134835);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(nativePdbWriterOpt, 145, 134796, 134834)?.WriteTo(pdbStream), 145, 134815, 134834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 134859, 134956);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(145, 134866, 134892) || ((f_145_134866_134892(diagnostics) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 134895, 134899)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 134902, 134955))) ? null : f_145_134902_134955(writer, baseline, this, encId, metadataSizes);
                    }
                    catch (SymUnmanagedWriterException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 134993, 135238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 135071, 135185);

                        f_145_135071_135184(diagnostics, f_145_135087_135183(f_145_135087_135102(), f_145_135120_135156(f_145_135120_135135()), f_145_135158_135171(), f_145_135173_135182(e)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 135207, 135219);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(145, 134993, 135238);
                    }
                    catch (Cci.PeWritingException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 135256, 135521);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 135329, 135468);

                        f_145_135329_135467(diagnostics, f_145_135345_135466(f_145_135345_135360(), f_145_135378_135414(f_145_135378_135393()), f_145_135416_135429(), f_145_135431_135459_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_145_135431_135447(e), 145, 135431, 135459).ToString()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(145, 135431, 135465) ?? "")));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 135490, 135502);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(145, 135256, 135521);
                    }
                    catch (PermissionSetFileReadException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(145, 135539, 135834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 135620, 135781);

                        f_145_135620_135780(diagnostics, f_145_135636_135779(f_145_135636_135651(), f_145_135669_135724(f_145_135669_135684()), f_145_135726_135739(), f_145_135741_135751(e), f_145_135753_135767(e), f_145_135769_135778(e)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 135803, 135815);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(145, 135539, 135834);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(145, 133821, 135849);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 132859, 135860);

                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_145_133497_133536(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 133497, 133536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IModuleSymbol
                f_145_133683_133695()
                {
                    var return_v = SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 133683, 133695);
                    return return_v;
                }


                string
                f_145_133683_133700(Microsoft.CodeAnalysis.IModuleSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 133683, 133700);
                    return return_v;
                }


                string?
                f_145_133649_133708(string
                path, string
                extension)
                {
                    var return_v = FileNameUtilities.ChangeExtension(path, extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 133649, 133708);
                    return return_v;
                }


                Microsoft.Cci.PdbWriter
                f_145_133594_133804(string
                fileName, System.Func<Microsoft.DiaSymReader.ISymWriterMetadataProvider, Microsoft.DiaSymReader.SymUnmanagedWriter>
                symWriterFactory, System.Security.Cryptography.HashAlgorithmName
                hashAlgorithmNameOpt)
                {
                    var return_v = new Microsoft.Cci.PdbWriter(fileName, symWriterFactory, hashAlgorithmNameOpt: hashAlgorithmNameOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 133594, 133804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_145_133894_133996(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext(module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 133894, 133996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_134203_134218()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 134203, 134218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
                f_145_134119_134404(Microsoft.CodeAnalysis.Emit.EmitContext
                context, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.Emit.EmitBaseline
                previousGeneration, System.Guid
                encId, Microsoft.CodeAnalysis.Emit.DefinitionMap
                definitionMap, Microsoft.CodeAnalysis.Emit.SymbolChanges
                changes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter(context, messageProvider, previousGeneration, encId, definitionMap, changes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 134119, 134404);
                    return return_v;
                }


                int
                f_145_134429_134708(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
                this_param, Microsoft.Cci.PdbWriter?
                nativePdbWriterOpt, System.IO.Stream
                metadataStream, System.IO.Stream
                ilStream, System.IO.Stream?
                portablePdbStreamOpt, out System.Reflection.Metadata.Ecma335.MetadataSizes
                metadataSizes)
                {
                    this_param.WriteMetadataAndIL(nativePdbWriterOpt, metadataStream, ilStream, portablePdbStreamOpt, out metadataSizes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 134429, 134708);
                    return 0;
                }


                int
                f_145_134733_134771(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
                this_param, System.Collections.Generic.ICollection<System.Reflection.Metadata.MethodDefinitionHandle>
                methods)
                {
                    this_param.GetMethodTokens(methods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 134733, 134771);
                    return 0;
                }


                bool
                f_145_134866_134892(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 134866, 134892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_145_134902_134955(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
                this_param, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, Microsoft.CodeAnalysis.Compilation
                compilation, System.Guid
                encId, System.Reflection.Metadata.Ecma335.MetadataSizes
                metadataSizes)
                {
                    var return_v = this_param.GetDelta(baseline, compilation, encId, metadataSizes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 134902, 134955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_135087_135102()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135087, 135102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_135120_135135()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135120, 135135);
                    return return_v;
                }


                int
                f_145_135120_135156(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_PdbWritingFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135120, 135156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_135158_135171()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135158, 135171);
                    return return_v;
                }


                string
                f_145_135173_135182(Microsoft.DiaSymReader.SymUnmanagedWriterException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135173, 135182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_135087_135183(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 135087, 135183);
                    return return_v;
                }


                int
                f_145_135071_135184(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 135071, 135184);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_135345_135360()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135345, 135360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_135378_135393()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135378, 135393);
                    return return_v;
                }


                int
                f_145_135378_135414(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_PeWritingFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135378, 135414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_135416_135429()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135416, 135429);
                    return return_v;
                }


                System.Exception?
                f_145_135431_135447(Microsoft.Cci.PeWritingException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135431, 135447);
                    return return_v;
                }


                string?
                f_145_135431_135459_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 135431, 135459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_135345_135466(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 135345, 135466);
                    return return_v;
                }


                int
                f_145_135329_135467(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 135329, 135467);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_135636_135651()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135636, 135651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_145_135669_135684()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135669, 135684);
                    return return_v;
                }


                int
                f_145_135669_135724(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_PermissionSetAttributeFileReadError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135669, 135724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_145_135726_135739()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135726, 135739);
                    return return_v;
                }


                string
                f_145_135741_135751(Microsoft.CodeAnalysis.CodeGen.PermissionSetFileReadException
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135741, 135751);
                    return return_v;
                }


                string
                f_145_135753_135767(Microsoft.CodeAnalysis.CodeGen.PermissionSetFileReadException
                this_param)
                {
                    var return_v = this_param.PropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135753, 135767);
                    return return_v;
                }


                string
                f_145_135769_135778(Microsoft.CodeAnalysis.CodeGen.PermissionSetFileReadException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 135769, 135778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_145_135636_135779(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 135636, 135779);
                    return return_v;
                }


                int
                f_145_135620_135780(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 135620, 135780);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 132859, 135860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 132859, 135860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string? Feature(string p)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 135872, 136016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 135931, 135941);

                string?
                v
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 135955, 136005);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(145, 135962, 135993) || ((f_145_135962_135993(_features, p, out v) && DynAbs.Tracing.TraceSender.Conditional_F2(145, 135996, 135997)) || DynAbs.Tracing.TraceSender.Conditional_F3(145, 136000, 136004))) ? v : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 135872, 136016);

                bool
                f_145_135962_135993(System.Collections.Generic.IReadOnlyDictionary<string, string>
                this_param, string
                key, out string?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 135962, 135993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 135872, 136016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 135872, 136016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConcurrentDictionary<SyntaxTree, SmallConcurrentSetOfInts>? _lazyTreeToUsedImportDirectivesMap;

        private static readonly Func<SyntaxTree, SmallConcurrentSetOfInts> s_createSetCallback;

        private ConcurrentDictionary<SyntaxTree, SmallConcurrentSetOfInts> TreeToUsedImportDirectivesMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 136421, 136559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 136457, 136544);

                    return f_145_136464_136543(ref _lazyTreeToUsedImportDirectivesMap);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(145, 136421, 136559);

                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts>
                    f_145_136464_136543(ref System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts>?
                    target)
                    {
                        var return_v = RoslynLazyInitializer.EnsureInitialized(ref target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 136464, 136543);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 136300, 136570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 136300, 136570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void MarkImportDirectiveAsUsed(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 136582, 136734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 136663, 136723);

                f_145_136663_136722(this, f_145_136689_136704(node), node.Span.Start);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 136582, 136734);

                Microsoft.CodeAnalysis.SyntaxTree
                f_145_136689_136704(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 136689, 136704);
                    return return_v;
                }


                int
                f_145_136663_136722(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                position)
                {
                    this_param.MarkImportDirectiveAsUsed(syntaxTree, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 136663, 136722);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 136582, 136734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 136582, 136734);
            }
        }

        internal void MarkImportDirectiveAsUsed(SyntaxTree? syntaxTree, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 136746, 137158);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 136941, 137147) || true) && (f_145_136945_136958_M(!IsSubmission) && (DynAbs.Tracing.TraceSender.Expression_True(145, 136945, 136980) && syntaxTree != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 136941, 137147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 137014, 137096);

                    var
                    set = f_145_137024_137095(f_145_137024_137053(), syntaxTree, s_createSetCallback)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 137114, 137132);

                    f_145_137114_137131(set, position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 136941, 137147);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 136746, 137158);

                bool
                f_145_136945_136958_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 136945, 136958);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts>
                f_145_137024_137053()
                {
                    var return_v = TreeToUsedImportDirectivesMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 137024, 137053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts
                f_145_137024_137095(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 137024, 137095);
                    return return_v;
                }


                bool
                f_145_137114_137131(Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts
                this_param, int
                i)
                {
                    var return_v = this_param.Add(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 137114, 137131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 136746, 137158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 136746, 137158);
            }
        }

        internal bool IsImportDirectiveUsed(SyntaxTree syntaxTree, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 137170, 137690);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 137267, 137443) || true) && (f_145_137271_137283())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 137267, 137443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 137416, 137428);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 137267, 137443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 137459, 137497);

                SmallConcurrentSetOfInts?
                usedImports
                = default(SmallConcurrentSetOfInts?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 137511, 137679);

                return syntaxTree != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 137518, 137627) && f_145_137557_137627(f_145_137557_137586(), syntaxTree, out usedImports)) && (DynAbs.Tracing.TraceSender.Expression_True(145, 137518, 137678) && f_145_137648_137678(usedImports, position));
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 137170, 137690);

                bool
                f_145_137271_137283()
                {
                    var return_v = IsSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 137271, 137283);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts>
                f_145_137557_137586()
                {
                    var return_v = TreeToUsedImportDirectivesMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 137557, 137586);
                    return return_v;
                }


                bool
                f_145_137557_137627(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 137557, 137627);
                    return return_v;
                }


                bool
                f_145_137648_137678(Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts
                this_param, int
                i)
                {
                    var return_v = this_param.Contains(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 137648, 137678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 137170, 137690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 137170, 137690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int CompareSyntaxTreeOrdering(SyntaxTree tree1, SyntaxTree tree2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 138059, 138456);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 138158, 138234) || true) && (tree1 == tree2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 138158, 138234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 138210, 138219);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 138158, 138234);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 138250, 138295);

                f_145_138250_138294(f_145_138263_138293(this, tree1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 138309, 138354);

                f_145_138309_138353(f_145_138322_138352(this, tree2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 138370, 138445);

                return f_145_138377_138409(this, tree1) - f_145_138412_138444(this, tree2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 138059, 138456);

                bool
                f_145_138263_138293(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.ContainsSyntaxTree(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 138263, 138293);
                    return return_v;
                }


                int
                f_145_138250_138294(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 138250, 138294);
                    return 0;
                }


                bool
                f_145_138322_138352(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.ContainsSyntaxTree(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 138322, 138352);
                    return return_v;
                }


                int
                f_145_138309_138353(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 138309, 138353);
                    return 0;
                }


                int
                f_145_138377_138409(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.GetSyntaxTreeOrdinal(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 138377, 138409);
                    return return_v;
                }


                int
                f_145_138412_138444(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.GetSyntaxTreeOrdinal(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 138412, 138444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 138059, 138456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 138059, 138456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract int GetSyntaxTreeOrdinal(SyntaxTree tree);

        internal abstract int CompareSourceLocations(Location loc1, Location loc2);

        internal abstract int CompareSourceLocations(SyntaxReference loc1, SyntaxReference loc2);

        internal TLocation FirstSourceLocation<TLocation>(TLocation first, TLocation second)
                    where TLocation : Location
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 139307, 139655);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 139456, 139644) || true) && (f_145_139460_139497(this, first, second) <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 139456, 139644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 139536, 139549);

                    return first;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 139456, 139644);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 139456, 139644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 139615, 139629);

                    return second;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 139456, 139644);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 139307, 139655);

                int
                f_145_139460_139497(Microsoft.CodeAnalysis.Compilation
                this_param, TLocation
                loc1, TLocation
                loc2)
                {
                    var return_v = this_param.CompareSourceLocations((Microsoft.CodeAnalysis.Location)loc1, (Microsoft.CodeAnalysis.Location)loc2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 139460, 139497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 139307, 139655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 139307, 139655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TLocation? FirstSourceLocation<TLocation>(ImmutableArray<TLocation> locations)
                    where TLocation : Location
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 139777, 140251);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 139929, 140011) || true) && (locations.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 139929, 140011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 139984, 139996);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 139929, 140011);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 140027, 140053);

                var
                result = locations[0]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 140078, 140083);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 140069, 140210) || true) && (i < locations.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 140107, 140110)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(145, 140069, 140210))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 140069, 140210);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 140144, 140195);

                        result = f_145_140153_140194(this, result, locations[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 142);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 140226, 140240);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 139777, 140251);

                TLocation
                f_145_140153_140194(Microsoft.CodeAnalysis.Compilation
                this_param, TLocation
                first, TLocation
                second)
                {
                    var return_v = this_param.FirstSourceLocation<TLocation>(first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 140153, 140194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 139777, 140251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 139777, 140251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetMessage(CompilationStage stage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 140865, 141022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 140940, 141011);

                return f_145_140947_141010("{0} ({1})", f_145_140974_140991(this), f_145_140993_141009(stage));
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 140865, 141022);

                string?
                f_145_140974_140991(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 140974, 140991);
                    return return_v;
                }


                string
                f_145_140993_141009(Microsoft.CodeAnalysis.CompilationStage
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 140993, 141009);
                    return return_v;
                }


                string
                f_145_140947_141010(string
                format, string?
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object?)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 140947, 141010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 140865, 141022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 140865, 141022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetMessage(ITypeSymbol source, ITypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 141034, 141388);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 141130, 141204) || true) && (source == null || (DynAbs.Tracing.TraceSender.Expression_False(145, 141134, 141171) || destination == null))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 141130, 141204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 141173, 141204);

                    return f_145_141180_141197(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(145, 141180, 141203) ?? "");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 141130, 141204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 141218, 141377);

                return f_145_141225_141376("{0}: {1} {2} -> {3} {4}", f_145_141266_141283(this), f_145_141285_141311(f_145_141285_141300(source)), f_145_141313_141324(source), f_145_141326_141357(f_145_141326_141346(destination)), f_145_141359_141375(destination));
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 141034, 141388);

                string?
                f_145_141180_141197(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 141180, 141197);
                    return return_v;
                }


                string?
                f_145_141266_141283(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 141266, 141283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_145_141285_141300(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 141285, 141300);
                    return return_v;
                }


                string
                f_145_141285_141311(Microsoft.CodeAnalysis.TypeKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 141285, 141311);
                    return return_v;
                }


                string
                f_145_141313_141324(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 141313, 141324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_145_141326_141346(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 141326, 141346);
                    return return_v;
                }


                string
                f_145_141326_141357(Microsoft.CodeAnalysis.TypeKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 141326, 141357);
                    return return_v;
                }


                string
                f_145_141359_141375(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 141359, 141375);
                    return return_v;
                }


                string
                f_145_141225_141376(string
                format, params object?[]
                args)
                {
                    var return_v = string.Format(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 141225, 141376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 141034, 141388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 141034, 141388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract bool ContainsSymbolsWithName(Func<string, bool> predicate, SymbolFilter filter = SymbolFilter.TypeAndMember, CancellationToken cancellationToken = default(CancellationToken));

        public abstract IEnumerable<ISymbol> GetSymbolsWithName(Func<string, bool> predicate, SymbolFilter filter = SymbolFilter.TypeAndMember, CancellationToken cancellationToken = default(CancellationToken));

        public abstract bool ContainsSymbolsWithName(string name, SymbolFilter filter = SymbolFilter.TypeAndMember, CancellationToken cancellationToken = default(CancellationToken));

        public abstract IEnumerable<ISymbol> GetSymbolsWithName(string name, SymbolFilter filter = SymbolFilter.TypeAndMember, CancellationToken cancellationToken = default(CancellationToken));

        internal void MakeMemberMissing(WellKnownMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 143599, 143721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 143679, 143710);

                f_145_143679_143709(this, member);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 143599, 143721);

                int
                f_145_143679_143709(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    this_param.MakeMemberMissing((int)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 143679, 143709);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 143599, 143721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 143599, 143721);
            }
        }

        internal void MakeMemberMissing(SpecialMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 143733, 143858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 143811, 143847);

                f_145_143811_143846(this, -(int)member - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 143733, 143858);

                int
                f_145_143811_143846(Microsoft.CodeAnalysis.Compilation
                this_param, int
                member)
                {
                    this_param.MakeMemberMissing(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 143811, 143846);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 143733, 143858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 143733, 143858);
            }
        }

        internal bool IsMemberMissing(WellKnownMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 143870, 143995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 143948, 143984);

                return f_145_143955_143983(this, member);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 143870, 143995);

                bool
                f_145_143955_143983(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.IsMemberMissing((int)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 143955, 143983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 143870, 143995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 143870, 143995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsMemberMissing(SpecialMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 144007, 144135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 144083, 144124);

                return f_145_144090_144123(this, -(int)member - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 144007, 144135);

                bool
                f_145_144090_144123(Microsoft.CodeAnalysis.Compilation
                this_param, int
                member)
                {
                    var return_v = this_param.IsMemberMissing(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 144090, 144123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 144007, 144135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 144007, 144135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MakeMemberMissing(int member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 144147, 144429);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 144214, 144361) || true) && (_lazyMakeMemberMissingMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 144214, 144361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 144285, 144346);

                    _lazyMakeMemberMissingMap = f_145_144313_144345();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 144214, 144361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 144377, 144418);

                _lazyMakeMemberMissingMap[member] = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 144147, 144429);

                Microsoft.CodeAnalysis.SmallDictionary<int, bool>
                f_145_144313_144345()
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<int, bool>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 144313, 144345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 144147, 144429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 144147, 144429);
            }
        }

        private bool IsMemberMissing(int member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 144441, 144607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 144506, 144596);

                return _lazyMakeMemberMissingMap != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 144513, 144595) && f_145_144550_144595(_lazyMakeMemberMissingMap, member));
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 144441, 144607);

                bool
                f_145_144550_144595(Microsoft.CodeAnalysis.SmallDictionary<int, bool>
                this_param, int
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 144550, 144595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 144441, 144607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 144441, 144607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void MakeTypeMissing(SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 144619, 144729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 144691, 144718);

                f_145_144691_144717(this, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 144619, 144729);

                int
                f_145_144691_144717(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    this_param.MakeTypeMissing((int)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 144691, 144717);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 144619, 144729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 144619, 144729);
            }
        }

        internal void MakeTypeMissing(WellKnownType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 144741, 144853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 144815, 144842);

                f_145_144815_144841(this, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 144741, 144853);

                int
                f_145_144815_144841(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    this_param.MakeTypeMissing((int)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 144815, 144841);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 144741, 144853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 144741, 144853);
            }
        }

        private void MakeTypeMissing(int type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 144865, 145167);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 144928, 145089) || true) && (_lazyMakeWellKnownTypeMissingMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 144928, 145089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 145006, 145074);

                    _lazyMakeWellKnownTypeMissingMap = f_145_145041_145073();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 144928, 145089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 145105, 145156);

                _lazyMakeWellKnownTypeMissingMap[(int)type] = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 144865, 145167);

                Microsoft.CodeAnalysis.SmallDictionary<int, bool>
                f_145_145041_145073()
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<int, bool>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 145041, 145073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 144865, 145167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 144865, 145167);
            }
        }

        internal bool IsTypeMissing(SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 145179, 145292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 145249, 145281);

                return f_145_145256_145280(this, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 145179, 145292);

                bool
                f_145_145256_145280(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.IsTypeMissing((int)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 145256, 145280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 145179, 145292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 145179, 145292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsTypeMissing(WellKnownType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 145304, 145419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 145376, 145408);

                return f_145_145383_145407(this, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 145304, 145419);

                bool
                f_145_145383_145407(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.IsTypeMissing((int)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 145383, 145407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 145304, 145419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 145304, 145419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsTypeMissing(int type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 145431, 145610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 145492, 145599);

                return _lazyMakeWellKnownTypeMissingMap != null && (DynAbs.Tracing.TraceSender.Expression_True(145, 145499, 145598) && f_145_145543_145598(_lazyMakeWellKnownTypeMissingMap, type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 145431, 145610);

                bool
                f_145_145543_145598(Microsoft.CodeAnalysis.SmallDictionary<int, bool>
                this_param, int
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 145543, 145598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 145431, 145610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 145431, 145610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<AssemblyIdentity> GetUnreferencedAssemblyIdentities(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(145, 145870, 146651);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 145991, 146114) || true) && (diagnostic == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 145991, 146114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 146047, 146099);

                    throw f_145_146053_146098(nameof(diagnostic));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 145991, 146114);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 146130, 146291) || true) && (!f_145_146135_146196(this, f_145_146180_146195(diagnostic)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 146130, 146291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 146230, 146276);

                    return ImmutableArray<AssemblyIdentity>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 146130, 146291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 146307, 146366);

                var
                builder = f_145_146321_146365()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 146382, 146588);
                    foreach (var argument in f_145_146407_146427_I(f_145_146407_146427(diagnostic)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 146382, 146588);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 146461, 146573) || true) && (argument is AssemblyIdentity id)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 146461, 146573);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 146538, 146554);

                            f_145_146538_146553(builder, id);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 146461, 146573);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(145, 146382, 146588);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 146604, 146640);

                return f_145_146611_146639(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(145, 145870, 146651);

                System.ArgumentNullException
                f_145_146053_146098(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 146053, 146098);
                    return return_v;
                }


                int
                f_145_146180_146195(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 146180, 146195);
                    return return_v;
                }


                bool
                f_145_146135_146196(Microsoft.CodeAnalysis.Compilation
                this_param, int
                code)
                {
                    var return_v = this_param.IsUnreferencedAssemblyIdentityDiagnosticCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 146135, 146196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_145_146321_146365()
                {
                    var return_v = ArrayBuilder<AssemblyIdentity>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 146321, 146365);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_145_146407_146427(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 146407, 146427);
                    return return_v;
                }


                int
                f_145_146538_146553(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 146538, 146553);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_145_146407_146427_I(System.Collections.Generic.IReadOnlyList<object?>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 146407, 146427);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_145_146611_146639(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 146611, 146639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 145870, 146651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 145870, 146651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract bool IsUnreferencedAssemblyIdentityDiagnosticCode(int code);

        public static string? GetRequiredLanguageVersion(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(145, 146949, 147813);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147045, 147168) || true) && (diagnostic == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 147045, 147168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147101, 147153);

                    throw f_145_147107_147152(nameof(diagnostic));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 147045, 147168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147184, 147203);

                bool
                found = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147217, 147245);

                string?
                foundVersion = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147259, 147766) || true) && (f_145_147263_147283(diagnostic) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 147259, 147766);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147325, 147751);
                        foreach (var argument in f_145_147350_147370_I(f_145_147350_147370(diagnostic)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 147325, 147751);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147412, 147732) || true) && (argument is RequiredLanguageVersion versionDiagnostic)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(145, 147412, 147732);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147519, 147540);

                                f_145_147519_147539(!found);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147626, 147639);

                                found = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147665, 147709);

                                foundVersion = f_145_147680_147708(versionDiagnostic);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(145, 147412, 147732);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(145, 147325, 147751);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(145, 1, 427);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(145, 1, 427);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(145, 147259, 147766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 147782, 147802);

                return foundVersion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(145, 146949, 147813);

                System.ArgumentNullException
                f_145_147107_147152(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 147107, 147152);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_145_147263_147283(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 147263, 147283);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_145_147350_147370(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 147350, 147370);
                    return return_v;
                }


                int
                f_145_147519_147539(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 147519, 147539);
                    return 0;
                }


                string
                f_145_147680_147708(Microsoft.CodeAnalysis.RequiredLanguageVersion
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 147680, 147708);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_145_147350_147370_I(System.Collections.Generic.IReadOnlyList<object?>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 147350, 147370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(145, 146949, 147813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(145, 146949, 147813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Microsoft.CodeAnalysis.ScriptCompilationInfo?
        f_145_2754_2781()
        {
            var return_v = CommonScriptCompilationInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 2754, 2781);
            return return_v;
        }


        bool
        f_145_3237_3258_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 3237, 3258);
            return return_v;
        }


        static int
        f_145_3218_3259(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 3218, 3259);
            return 0;
        }


        static int
        f_145_3274_3310(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 3274, 3310);
            return 0;
        }


        Microsoft.CodeAnalysis.ScriptCompilationInfo?
        f_145_17641_17662()
        {
            var return_v = ScriptCompilationInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 17641, 17662);
            return return_v;
        }


        System.Type?
        f_145_17641_17677_M(System.Type?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 17641, 17677);
            return return_v;
        }


        Microsoft.CodeAnalysis.ScriptCompilationInfo?
        f_145_18063_18084()
        {
            var return_v = ScriptCompilationInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 18063, 18084);
            return return_v;
        }


        System.Type?
        f_145_18063_18097_M(System.Type?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 18063, 18097);
            return return_v;
        }


        Microsoft.CodeAnalysis.ITypeSymbol?
        f_145_37463_37486()
        {
            var return_v = CommonScriptGlobalsType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 37463, 37486);
            return return_v;
        }


        Microsoft.CodeAnalysis.ConcurrentCache<string, Microsoft.CodeAnalysis.INamedTypeSymbol?>
        f_145_44195_44281(int
        size, Roslyn.Utilities.ReferenceEqualityComparer
        keyComparer)
        {
            var return_v = new Microsoft.CodeAnalysis.ConcurrentCache<string, Microsoft.CodeAnalysis.INamedTypeSymbol?>(size, (System.Collections.Generic.IEqualityComparer<string>)keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 44195, 44281);
            return return_v;
        }


        Microsoft.CodeAnalysis.StrongNameKeys
        f_145_81303_81317()
        {
            var return_v = StrongNameKeys;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 81303, 81317);
            return return_v;
        }


        bool
        f_145_81282_81331(string?
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 81282, 81331);
            return return_v;
        }


        Microsoft.CodeAnalysis.StrongNameKeys
        f_145_81349_81363()
        {
            var return_v = StrongNameKeys;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 81349, 81363);
            return return_v;
        }


        bool
        f_145_81401_81453(System.Collections.Generic.IReadOnlyDictionary<string, string>
        this_param, string
        key)
        {
            var return_v = this_param.ContainsKey(key);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(145, 81401, 81453);
            return return_v;
        }


        Microsoft.CodeAnalysis.CompilationOptions
        f_145_122904_122916(Microsoft.CodeAnalysis.Compilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 122904, 122916);
            return return_v;
        }


        bool
        f_145_122904_122930(Microsoft.CodeAnalysis.CompilationOptions
        this_param)
        {
            var return_v = this_param.Deterministic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(145, 122904, 122930);
            return return_v;
        }

    }
}
