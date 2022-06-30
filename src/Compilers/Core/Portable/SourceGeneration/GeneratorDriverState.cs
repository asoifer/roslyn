// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis.Diagnostics;
namespace Microsoft.CodeAnalysis
{

    internal readonly struct GeneratorDriverState
    {

        internal GeneratorDriverState(ParseOptions parseOptions,
                                              AnalyzerConfigOptionsProvider optionsProvider,
                                              ImmutableArray<ISourceGenerator> generators,
                                              ImmutableArray<AdditionalText> additionalTexts,
                                              ImmutableArray<GeneratorState> generatorStates,
                                              ImmutableArray<PendingEdit> edits,
                                              bool editsFailed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(551, 488, 1407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(551, 1044, 1068);

                Generators = generators;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(551, 1082, 1116);

                GeneratorStates = generatorStates;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(551, 1130, 1164);

                AdditionalTexts = additionalTexts;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(551, 1178, 1192);

                Edits = edits;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(551, 1206, 1234);

                ParseOptions = parseOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(551, 1248, 1282);

                OptionsProvider = optionsProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(551, 1296, 1322);

                EditsFailed = editsFailed;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(551, 1338, 1396);

                f_551_1338_1395(Generators.Length == GeneratorStates.Length);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(551, 488, 1407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(551, 488, 1407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(551, 488, 1407);
            }
        }

        internal readonly ImmutableArray<ISourceGenerator> Generators;

        internal readonly ImmutableArray<GeneratorState> GeneratorStates;

        internal readonly ImmutableArray<AdditionalText> AdditionalTexts;

        internal readonly AnalyzerConfigOptionsProvider OptionsProvider;

        internal readonly ImmutableArray<PendingEdit> Edits;

        internal readonly bool EditsFailed;

        internal readonly ParseOptions ParseOptions;

        internal GeneratorDriverState With(
                    ImmutableArray<ISourceGenerator>? generators = null,
                    ImmutableArray<GeneratorState>? generatorStates = null,
                    ImmutableArray<AdditionalText>? additionalTexts = null,
                    ImmutableArray<PendingEdit>? edits = null,
                    bool? editsFailed = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(551, 3356, 4104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(551, 3715, 4093);

                return f_551_3722_4092(this.ParseOptions, this.OptionsProvider, generators ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>?>(551, 3840, 3869) ?? this.Generators), additionalTexts ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?>(551, 3888, 3927) ?? this.AdditionalTexts), generatorStates ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorState>?>(551, 3946, 3985) ?? this.GeneratorStates), edits ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PendingEdit>?>(551, 4004, 4023) ?? this.Edits), editsFailed ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(551, 4042, 4073) ?? this.EditsFailed
                ));
                DynAbs.Tracing.TraceSender.TraceExitMethod(551, 3356, 4104);

                Microsoft.CodeAnalysis.GeneratorDriverState
                f_551_3722_4092(Microsoft.CodeAnalysis.ParseOptions
                parseOptions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
                optionsProvider, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                generators, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalTexts, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorState>
                generatorStates, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PendingEdit>
                edits, bool
                editsFailed)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorDriverState(parseOptions, optionsProvider, generators, additionalTexts, generatorStates, edits, editsFailed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(551, 3722, 4092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(551, 3356, 4104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(551, 3356, 4104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static GeneratorDriverState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(551, 426, 4111);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(551, 426, 4111);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(551, 426, 4111);
        }

        static int
        f_551_1338_1395(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(551, 1338, 1395);
            return 0;
        }

    }
}
