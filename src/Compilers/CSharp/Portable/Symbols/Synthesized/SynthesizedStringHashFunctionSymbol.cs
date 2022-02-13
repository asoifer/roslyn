// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CodeGen;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class SynthesizedStringSwitchHashMethod : SynthesizedGlobalMethodSymbol
    {
        internal SynthesizedStringSwitchHashMethod(SourceModuleSymbol containingModule, PrivateImplementationDetails privateImplType, TypeSymbol returnType, TypeSymbol paramType)
        : base(f_10691_822_838_C(containingModule), privateImplType, returnType, PrivateImplementationDetails.SynthesizedStringHashFunctionName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10691, 631, 1129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10691, 957, 1118);

                f_10691_957_1117(this, f_10691_976_1116(f_10691_1015_1115(this, TypeWithAnnotations.Create(paramType), 0, RefKind.None, "s")));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10691, 631, 1129);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10691, 631, 1129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10691, 631, 1129);
            }
        }

        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10691_1015_1115(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStringSwitchHashMethod
        container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type, int
        ordinal, Microsoft.CodeAnalysis.RefKind
        refKind, string
        name)
        {
            var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10691, 1015, 1115);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10691_976_1116(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        item)
        {
            var return_v = ImmutableArray.Create<ParameterSymbol>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10691, 976, 1116);
            return return_v;
        }


        int
        f_10691_957_1117(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStringSwitchHashMethod
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        parameters)
        {
            this_param.SetParameters(parameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10691, 957, 1117);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        f_10691_822_838_C(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10691, 631, 1129);
            return return_v;
        }

    }
}
