// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ConstructedMethodSymbol : SubstitutedMethodSymbol
    {
        private readonly ImmutableArray<TypeWithAnnotations> _typeArgumentsWithAnnotations;

        internal ConstructedMethodSymbol(MethodSymbol constructedFrom, ImmutableArray<TypeWithAnnotations> typeArgumentsWithAnnotations)
        : base(containingSymbol: f_10095_783_831_C(f_10095_801_831(constructedFrom)), map: f_10095_858_998(f_10095_870_900(constructedFrom), f_10095_902_967(((MethodSymbol)f_10095_917_951(constructedFrom))), typeArgumentsWithAnnotations), originalDefinition: (MethodSymbol)f_10095_1054_1088(constructedFrom), constructedFrom: constructedFrom)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10095, 634, 1240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10095, 1168, 1229);

                _typeArgumentsWithAnnotations = typeArgumentsWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10095, 634, 1240);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10095, 634, 1240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10095, 634, 1240);
            }
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10095, 1357, 1445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10095, 1393, 1430);

                    return _typeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10095, 1357, 1445);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10095, 1252, 1456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10095, 1252, 1456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ConstructedMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10095, 451, 1463);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10095, 451, 1463);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10095, 451, 1463);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10095, 451, 1463);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10095_801_831(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10095, 801, 831);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10095_870_900(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10095, 870, 900);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10095_917_951(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.OriginalDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10095, 917, 951);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10095_902_967(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10095, 902, 967);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10095_858_998(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        containingType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        typeArguments)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(containingType, typeParameters, typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10095, 858, 998);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10095_1054_1088(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.OriginalDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10095, 1054, 1088);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10095_783_831_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10095, 634, 1240);
            return return_v;
        }

    }
}
