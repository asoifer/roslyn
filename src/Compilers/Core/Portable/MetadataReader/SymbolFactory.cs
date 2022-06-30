// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    internal abstract class SymbolFactory<ModuleSymbol, TypeSymbol>
            where TypeSymbol : class
    {
        internal abstract TypeSymbol GetUnsupportedMetadataTypeSymbol(ModuleSymbol moduleSymbol, BadImageFormatException exception);

        internal abstract TypeSymbol MakeUnboundIfGeneric(ModuleSymbol moduleSymbol, TypeSymbol type);

        internal abstract TypeSymbol GetSZArrayTypeSymbol(ModuleSymbol moduleSymbol, TypeSymbol elementType, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers);

        internal abstract TypeSymbol GetMDArrayTypeSymbol(ModuleSymbol moduleSymbol, int rank, TypeSymbol elementType, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers,
                                                                  ImmutableArray<int> sizes, ImmutableArray<int> lowerBounds);

        internal abstract TypeSymbol SubstituteTypeParameters(ModuleSymbol moduleSymbol, TypeSymbol generic, ImmutableArray<KeyValuePair<TypeSymbol, ImmutableArray<ModifierInfo<TypeSymbol>>>> arguments, ImmutableArray<bool> refersToNoPiaLocalType);

        internal abstract TypeSymbol MakePointerTypeSymbol(ModuleSymbol moduleSymbol, TypeSymbol type, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers);

        internal abstract TypeSymbol MakeFunctionPointerTypeSymbol(Cci.CallingConvention callingConvention, ImmutableArray<ParamInfo<TypeSymbol>> returnAndParamTypes);

        internal abstract TypeSymbol GetSpecialType(ModuleSymbol moduleSymbol, SpecialType specialType);

        internal abstract TypeSymbol GetSystemTypeSymbol(ModuleSymbol moduleSymbol);

        internal abstract TypeSymbol GetEnumUnderlyingType(ModuleSymbol moduleSymbol, TypeSymbol type);

        internal abstract Cci.PrimitiveTypeCode GetPrimitiveTypeCode(ModuleSymbol moduleSymbol, TypeSymbol type);

        public SymbolFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(416, 359, 2866);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(416, 359, 2866);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(416, 359, 2866);
        }


        static SymbolFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(416, 359, 2866);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(416, 359, 2866);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(416, 359, 2866);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(416, 359, 2866);
    }
}
