// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceParameterSymbol : SourceParameterSymbolBase
    {
        protected SymbolCompletionState state;

        protected readonly TypeWithAnnotations parameterType;

        private readonly string _name;

        private readonly ImmutableArray<Location> _locations;

        private readonly RefKind _refKind;

        public static SourceParameterSymbol Create(
                    Binder context,
                    Symbol owner,
                    TypeWithAnnotations parameterType,
                    ParameterSyntax syntax,
                    RefKind refKind,
                    SyntaxToken identifier,
                    int ordinal,
                    bool isParams,
                    bool isExtensionMethodThis,
                    bool addRefReadOnlyModifier,
                    DiagnosticBag declarationDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10270, 1139, 3661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 1603, 1642);

                f_10270_1603_1641(!(owner is LambdaSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 1717, 1749);

                var
                name = identifier.ValueText
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 1763, 1843);

                var
                locations = f_10270_1779_1842(f_10270_1811_1841(identifier))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 1859, 2256) || true) && (isParams)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10270, 1859, 2256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 1996, 2241);

                    f_10270_1996_2240(f_10270_2050_2069(context), WellKnownMember.System_ParamArrayAttribute__ctor, declarationDiagnostics, f_10270_2208_2239(identifier.Parent));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10270, 1859, 2256);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 2272, 2439);

                ImmutableArray<CustomModifier>
                inModifiers = f_10270_2317_2438(refKind, addRefReadOnlyModifier, context, declarationDiagnostics, syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 2455, 2947) || true) && (f_10270_2459_2488_M(!inModifiers.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10270, 2455, 2947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 2522, 2932);

                    return f_10270_2529_2931(owner, ordinal, parameterType, refKind, inModifiers, name, locations, f_10270_2834_2855(syntax), isParams, isExtensionMethodThis);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10270, 2455, 2947);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 2963, 3327) || true) && (!isParams && (DynAbs.Tracing.TraceSender.Expression_True(10270, 2967, 3019) && !isExtensionMethodThis) && (DynAbs.Tracing.TraceSender.Expression_True(10270, 2967, 3064) && (f_10270_3041_3055(syntax) == null)) && (DynAbs.Tracing.TraceSender.Expression_True(10270, 2967, 3119) && (syntax.AttributeLists.Count == 0)) && (DynAbs.Tracing.TraceSender.Expression_True(10270, 2967, 3164) && !f_10270_3141_3164(owner)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10270, 2963, 3327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 3198, 3312);

                    return f_10270_3205_3311(owner, parameterType, ordinal, refKind, name, isDiscard: false, locations);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10270, 2963, 3327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 3343, 3650);

                return f_10270_3350_3649(owner, ordinal, parameterType, refKind, name, locations, f_10270_3560_3581(syntax), isParams, isExtensionMethodThis);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10270, 1139, 3661);

                int
                f_10270_1603_1641(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 1603, 1641);
                    return 0;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10270_1811_1841(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 1811, 1841);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10270_1779_1842(Microsoft.CodeAnalysis.SourceLocation
                item)
                {
                    var return_v = ImmutableArray.Create<Location>((Microsoft.CodeAnalysis.Location)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 1779, 1842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10270_2050_2069(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 2050, 2069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10270_2208_2239(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 2208, 2239);
                    return return_v;
                }


                int
                f_10270_1996_2240(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 1996, 2240);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10270_2317_2438(Microsoft.CodeAnalysis.RefKind
                refKind, bool
                addRefReadOnlyModifier, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax)
                {
                    var return_v = ParameterHelpers.ConditionallyCreateInModifiers(refKind, addRefReadOnlyModifier, binder, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 2317, 2438);
                    return return_v;
                }


                bool
                f_10270_2459_2488_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 2459, 2488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10270_2834_2855(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 2834, 2855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbolWithCustomModifiersPrecedingByRef
                f_10270_2529_2931(Microsoft.CodeAnalysis.CSharp.Symbol
                owner, int
                ordinal, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, Microsoft.CodeAnalysis.RefKind
                refKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, Microsoft.CodeAnalysis.SyntaxReference
                syntaxRef, bool
                isParams, bool
                isExtensionMethodThis)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbolWithCustomModifiersPrecedingByRef(owner, ordinal, parameterType, refKind, refCustomModifiers, name, locations, syntaxRef, isParams, isExtensionMethodThis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 2529, 2931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10270_3041_3055(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 3041, 3055);
                    return return_v;
                }


                bool
                f_10270_3141_3164(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.IsPartialMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 3141, 3164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                f_10270_3205_3311(Microsoft.CodeAnalysis.CSharp.Symbol
                owner, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, bool
                isDiscard, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol(owner, parameterType, ordinal, refKind, name, isDiscard: isDiscard, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 3205, 3311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10270_3560_3581(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 3560, 3581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                f_10270_3350_3649(Microsoft.CodeAnalysis.CSharp.Symbol
                owner, int
                ordinal, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, Microsoft.CodeAnalysis.SyntaxReference
                syntaxRef, bool
                isParams, bool
                isExtensionMethodThis)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol(owner, ordinal, parameterType, refKind, name, locations, syntaxRef, isParams, isExtensionMethodThis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 3350, 3649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 1139, 3661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 1139, 3661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SourceParameterSymbol(
                    Symbol owner,
                    TypeWithAnnotations parameterType,
                    int ordinal,
                    RefKind refKind,
                    string name,
                    ImmutableArray<Location> locations)
        : base(f_10270_3932_3937_C(owner), ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10270, 3673, 4363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 1014, 1019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 1118, 1126);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 3983, 4097);
                    foreach (var location in f_10270_4008_4017_I(locations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10270, 3983, 4097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 4051, 4082);

                        f_10270_4051_4081(location != null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10270, 3983, 4097);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10270, 1, 115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10270, 1, 115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 4119, 4206);

                f_10270_4119_4205((f_10270_4133_4143(owner) == SymbolKind.Method) || (DynAbs.Tracing.TraceSender.Expression_False(10270, 4132, 4204) || (f_10270_4170_4180(owner) == SymbolKind.Property)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 4220, 4255);

                this.parameterType = parameterType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 4269, 4288);

                _refKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 4302, 4315);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 4329, 4352);

                _locations = locations;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10270, 3673, 4363);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 3673, 4363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 3673, 4363);
            }
        }

        internal override ParameterSymbol WithCustomModifiersAndParams(TypeSymbol newType, ImmutableArray<CustomModifier> newCustomModifiers, ImmutableArray<CustomModifier> newRefCustomModifiers, bool newIsParams)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 4375, 4721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 4605, 4710);

                return f_10270_4612_4709(this, newType, newCustomModifiers, newRefCustomModifiers, newIsParams);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 4375, 4721);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                f_10270_4612_4709(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                newCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                newRefCustomModifiers, bool
                newIsParams)
                {
                    var return_v = this_param.WithCustomModifiersAndParamsCore(newType, newCustomModifiers, newRefCustomModifiers, newIsParams);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 4612, 4709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 4375, 4721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 4375, 4721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SourceParameterSymbol WithCustomModifiersAndParamsCore(TypeSymbol newType, ImmutableArray<CustomModifier> newCustomModifiers, ImmutableArray<CustomModifier> newRefCustomModifiers, bool newIsParams)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 4733, 6261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 4964, 5063);

                newType = f_10270_4974_5062(newType, f_10270_5027_5036(this), f_10270_5038_5061(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 5079, 5197);

                TypeWithAnnotations
                newTypeWithModifiers = this.TypeWithAnnotations.WithTypeAndModifiers(newType, newCustomModifiers)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 5213, 5676) || true) && (newRefCustomModifiers.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10270, 5213, 5676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 5280, 5661);

                    return f_10270_5287_5660(f_10270_5342_5363(this), f_10270_5386_5398(this), newTypeWithModifiers, _refKind, _name, _locations, f_10270_5556_5576(this), newIsParams, f_10270_5633_5659(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10270, 5213, 5676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 5759, 5816);

                f_10270_5759_5815(!(f_10270_5774_5790() is LocalFunctionSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 5832, 6250);

                return f_10270_5839_6249(f_10270_5923_5944(this), f_10270_5963_5975(this), newTypeWithModifiers, _refKind, newRefCustomModifiers, _name, _locations, f_10270_6153_6173(this), newIsParams, f_10270_6222_6248(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 4733, 6261);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10270_5027_5036(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 5027, 5036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10270_5038_5061(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 5038, 5061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10270_4974_5062(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destinationType, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                containingAssembly)
                {
                    var return_v = CustomModifierUtils.CopyTypeCustomModifiers(sourceType, destinationType, containingAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 4974, 5062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10270_5342_5363(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 5342, 5363);
                    return return_v;
                }


                int
                f_10270_5386_5398(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 5386, 5398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10270_5556_5576(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 5556, 5576);
                    return return_v;
                }


                bool
                f_10270_5633_5659(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethodThis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 5633, 5659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                f_10270_5287_5660(Microsoft.CodeAnalysis.CSharp.Symbol
                owner, int
                ordinal, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, Microsoft.CodeAnalysis.SyntaxReference
                syntaxRef, bool
                isParams, bool
                isExtensionMethodThis)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol(owner, ordinal, parameterType, refKind, name, locations, syntaxRef, isParams, isExtensionMethodThis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 5287, 5660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10270_5774_5790()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 5774, 5790);
                    return return_v;
                }


                int
                f_10270_5759_5815(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 5759, 5815);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10270_5923_5944(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 5923, 5944);
                    return return_v;
                }


                int
                f_10270_5963_5975(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 5963, 5975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10270_6153_6173(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 6153, 6173);
                    return return_v;
                }


                bool
                f_10270_6222_6248(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethodThis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 6222, 6248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbolWithCustomModifiersPrecedingByRef
                f_10270_5839_6249(Microsoft.CodeAnalysis.CSharp.Symbol
                owner, int
                ordinal, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, Microsoft.CodeAnalysis.RefKind
                refKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, Microsoft.CodeAnalysis.SyntaxReference
                syntaxRef, bool
                isParams, bool
                isExtensionMethodThis)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbolWithCustomModifiersPrecedingByRef(owner, ordinal, parameterType, refKind, refCustomModifiers, name, locations, syntaxRef, isParams, isExtensionMethodThis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 5839, 6249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 4733, 6261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 4733, 6261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool RequiresCompletion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 6346, 6366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 6352, 6364);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 6346, 6366);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 6273, 6377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 6273, 6377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 6389, 6518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 6476, 6507);

                return state.HasComplete(part);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 6389, 6518);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 6389, 6518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 6389, 6518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            state.DefaultForceComplete(this, cancellationToken);
        }

        internal abstract bool HasOptionalAttribute { get; }

        internal abstract bool HasDefaultArgumentSyntax { get; }

        internal abstract SyntaxList<AttributeListSyntax> AttributeDeclarationList { get; }

        internal abstract CustomAttributesBag<CSharpAttributeData> GetAttributesBag();

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 7486, 7638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 7585, 7627);

                return f_10270_7592_7626(f_10270_7592_7615(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 7486, 7638);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10270_7592_7615(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 7592, 7615);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10270_7592_7626(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 7592, 7626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 7486, 7638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 7486, 7638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddDeclarationDiagnostics(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 8107, 8165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 8110, 8165);
                f_10270_8110_8165(f_10270_8110_8126(), diagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 8107, 8165);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 8107, 8165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 8107, 8165);
            }

            Microsoft.CodeAnalysis.CSharp.Symbol
            f_10270_8110_8126()
            {
                var return_v = ContainingSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 8110, 8126);
                return return_v;
            }


            int
            f_10270_8110_8165(Microsoft.CodeAnalysis.CSharp.Symbol
            this_param, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                this_param.AddDeclarationDiagnostics(diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 8110, 8165);
                return 0;
            }

        }

        internal abstract SyntaxReference SyntaxReference { get; }

        internal abstract bool IsExtensionMethodThis { get; }

        public sealed override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 8376, 8443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 8412, 8428);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 8376, 8443);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 8313, 8454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 8313, 8454);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 8525, 8589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 8561, 8574);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 8525, 8589);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 8466, 8600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 8466, 8600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 8694, 8763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 8730, 8748);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 8694, 8763);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 8612, 8774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 8612, 8774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 8891, 9117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 8927, 9102);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10270, 8934, 8954) || ((f_10270_8934_8954() && DynAbs.Tracing.TraceSender.Conditional_F2(10270, 8978, 9015)) || DynAbs.Tracing.TraceSender.Conditional_F3(10270, 9039, 9101))) ? ImmutableArray<SyntaxReference>.Empty : f_10270_9039_9101(_locations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 8891, 9117);

                    bool
                    f_10270_8934_8954()
                    {
                        var return_v = IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 8934, 8954);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10270_9039_9101(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    locations)
                    {
                        var return_v = GetDeclaringSyntaxReferenceHelper<ParameterSyntax>(locations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 9039, 9101);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 8786, 9128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 8786, 9128);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 9227, 9304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 9263, 9289);

                    return this.parameterType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 9227, 9304);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 9140, 9315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 9140, 9315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 9393, 9780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 9621, 9682);

                    MethodSymbol
                    owningMethod = f_10270_9649_9665() as MethodSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 9700, 9765);

                    return (object)owningMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10270, 9707, 9764) && f_10270_9739_9764(owningMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 9393, 9780);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10270_9649_9665()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 9649, 9665);
                        return return_v;
                    }


                    bool
                    f_10270_9739_9764(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodSymbol)
                    {
                        var return_v = methodSymbol.IsAccessor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 9739, 9764);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 9327, 9791);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 9327, 9791);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 9839, 9863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 9842, 9863);
                    return f_10270_9842_9849() == RefKind.In; DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 9839, 9863);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 9839, 9863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 9839, 9863);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10270, 9913, 9938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10270, 9916, 9938);
                    return f_10270_9916_9923() == RefKind.Out; DynAbs.Tracing.TraceSender.TraceExitMethod(10270, 9913, 9938);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10270, 9913, 9938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 9913, 9938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10270, 789, 9946);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10270, 789, 9946);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10270, 789, 9946);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10270, 789, 9946);

        int
        f_10270_4051_4081(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 4051, 4081);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10270_4008_4017_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 4008, 4017);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10270_4133_4143(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 4133, 4143);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10270_4170_4180(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 4170, 4180);
            return return_v;
        }


        int
        f_10270_4119_4205(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10270, 4119, 4205);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10270_3932_3937_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10270, 3673, 4363);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10270_9842_9849()
        {
            var return_v = RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 9842, 9849);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10270_9916_9923()
        {
            var return_v = RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10270, 9916, 9923);
            return return_v;
        }

    }
}
