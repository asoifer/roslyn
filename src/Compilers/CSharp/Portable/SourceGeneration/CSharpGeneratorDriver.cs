// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
namespace Microsoft.CodeAnalysis.CSharp
{
    public sealed class CSharpGeneratorDriver : GeneratorDriver
    {
        internal CSharpGeneratorDriver(CSharpParseOptions parseOptions, ImmutableArray<ISourceGenerator> generators, AnalyzerConfigOptionsProvider optionsProvider, ImmutableArray<AdditionalText> additionalTexts)
        : base(f_10973_1696_1708_C(parseOptions), generators, optionsProvider, additionalTexts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10973, 1472, 1777);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10973, 1472, 1777);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10973, 1472, 1777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10973, 1472, 1777);
            }
        }

        private CSharpGeneratorDriver(GeneratorDriverState state)
        : base(f_10973_1867_1872_C(state))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10973, 1789, 1895);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10973, 1789, 1895);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10973, 1789, 1895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10973, 1789, 1895);
            }
        }

        public static CSharpGeneratorDriver Create(params ISourceGenerator[] generators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10973, 2366, 2410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10973, 2369, 2410);
                return f_10973_2369_2410(generators, additionalTexts: null); DynAbs.Tracing.TraceSender.TraceExitMethod(10973, 2366, 2410);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10973, 2366, 2410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10973, 2366, 2410);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.CSharpGeneratorDriver
            f_10973_2369_2410(Microsoft.CodeAnalysis.ISourceGenerator[]
            generators, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>?
            additionalTexts)
            {
                var return_v = Create((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISourceGenerator>)generators, additionalTexts: additionalTexts);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10973, 2369, 2410);
                return return_v;
            }

        }

        public static CSharpGeneratorDriver Create(IEnumerable<ISourceGenerator> generators, IEnumerable<AdditionalText>? additionalTexts = null, CSharpParseOptions? parseOptions = null, AnalyzerConfigOptionsProvider? optionsProvider = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10973, 3633, 3838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10973, 3636, 3838);
                return f_10973_3636_3838(parseOptions ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?>(10973, 3662, 3704) ?? f_10973_3678_3704()), f_10973_3706_3735(generators), optionsProvider ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider?>(10973, 3737, 3799) ?? f_10973_3756_3799()), f_10973_3801_3837(additionalTexts)); DynAbs.Tracing.TraceSender.TraceExitMethod(10973, 3633, 3838);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10973, 3633, 3838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10973, 3633, 3838);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
            f_10973_3678_3704()
            {
                var return_v = CSharpParseOptions.Default;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10973, 3678, 3704);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
            f_10973_3706_3735(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISourceGenerator>
            items)
            {
                var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10973, 3706, 3735);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
            f_10973_3756_3799()
            {
                var return_v = CompilerAnalyzerConfigOptionsProvider.Empty;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10973, 3756, 3799);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
            f_10973_3801_3837(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>?
            items)
            {
                var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.AdditionalText>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10973, 3801, 3837);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.CSharpGeneratorDriver
            f_10973_3636_3838(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
            parseOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
            generators, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
            optionsProvider, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
            additionalTexts)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpGeneratorDriver(parseOptions, generators, optionsProvider, additionalTexts);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10973, 3636, 3838);
                return return_v;
            }

        }

        internal override SyntaxTree ParseGeneratedSourceText(GeneratedSourceText input, string fileName, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10973, 3999, 4093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10973, 4002, 4093);
                return f_10973_4002_4093(input.Text, _state.ParseOptions, fileName, cancellationToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10973, 3999, 4093);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10973, 3999, 4093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10973, 3999, 4093);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTree
            f_10973_4002_4093(Microsoft.CodeAnalysis.Text.SourceText
            text, Microsoft.CodeAnalysis.ParseOptions
            options, string
            path, System.Threading.CancellationToken
            cancellationToken)
            {
                var return_v = SyntaxFactory.ParseSyntaxTree(text, options, path, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10973, 4002, 4093);
                return return_v;
            }

        }

        internal override GeneratorDriver FromState(GeneratorDriverState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10973, 4178, 4213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10973, 4181, 4213);
                return f_10973_4181_4213(state); DynAbs.Tracing.TraceSender.TraceExitMethod(10973, 4178, 4213);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10973, 4178, 4213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10973, 4178, 4213);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.CSharpGeneratorDriver
            f_10973_4181_4213(Microsoft.CodeAnalysis.GeneratorDriverState
            state)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpGeneratorDriver(state);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10973, 4181, 4213);
                return return_v;
            }

        }

        internal override CommonMessageProvider MessageProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10973, 4282, 4316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10973, 4285, 4316);
                    return CSharp.MessageProvider.Instance; DynAbs.Tracing.TraceSender.TraceExitMethod(10973, 4282, 4316);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10973, 4282, 4316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10973, 4282, 4316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override AdditionalSourcesCollection CreateSourcesCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10973, 4401, 4442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10973, 4404, 4442);
                return f_10973_4404_4442(".cs"); DynAbs.Tracing.TraceSender.TraceExitMethod(10973, 4401, 4442);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10973, 4401, 4442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10973, 4401, 4442);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.AdditionalSourcesCollection
            f_10973_4404_4442(string
            fileExtension)
            {
                var return_v = new Microsoft.CodeAnalysis.AdditionalSourcesCollection(fileExtension);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10973, 4404, 4442);
                return return_v;
            }

        }

        static CSharpGeneratorDriver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10973, 725, 4450);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10973, 725, 4450);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10973, 725, 4450);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10973, 725, 4450);

        static Microsoft.CodeAnalysis.ParseOptions
        f_10973_1696_1708_C(Microsoft.CodeAnalysis.ParseOptions
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10973, 1472, 1777);
            return return_v;
        }


        static Microsoft.CodeAnalysis.GeneratorDriverState
        f_10973_1867_1872_C(Microsoft.CodeAnalysis.GeneratorDriverState
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10973, 1789, 1895);
            return return_v;
        }

    }
}
