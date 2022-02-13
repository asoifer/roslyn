// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedRecordEqualityOperatorBase : SourceUserDefinedOperatorSymbolBase
    {
        private readonly int _memberOffset;

        protected SynthesizedRecordEqualityOperatorBase(SourceMemberContainerTypeSymbol containingType, string name, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10724_1432_1462_C(MethodKind.UserDefinedOperator), name, containingType, f_10724_1486_1510(containingType)[0], (CSharpSyntaxNode)f_10724_1533_1579(f_10724_1533_1564(containingType)[0]), DeclarationModifiers.Public | DeclarationModifiers.Static, hasBody: true, isExpressionBodied: false, isIterator: false, isNullableAnalysisEnabled: false, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10724, 1258, 1965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 1232, 1245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 1792, 1911);

                f_10724_1792_1910(name == WellKnownMemberNames.EqualityOperatorName || (DynAbs.Tracing.TraceSender.Expression_False(10724, 1805, 1909) || name == WellKnownMemberNames.InequalityOperatorName));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 1925, 1954);

                _memberOffset = memberOffset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10724, 1258, 1965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 1258, 1965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 1258, 1965);
            }
        }

        public sealed override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 2026, 2033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 2029, 2033);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 2026, 2033);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 2026, 2033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 2026, 2033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override Location ReturnTypeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 2100, 2115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 2103, 2115);
                    return f_10724_2103_2112()[0]; DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 2100, 2115);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 2100, 2115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 2100, 2115);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 2188, 2244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 2191, 2244);
                return LexicalSortKey.GetSynthesizedMemberKey(_memberOffset); DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 2188, 2244);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 2188, 2244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 2188, 2244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override SourceMemberMethodSymbol? BoundAttributesSource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 2331, 2338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 2334, 2338);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 2331, 2338);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 2331, 2338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 2331, 2338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 2446, 2507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 2449, 2507);
                return f_10724_2449_2507(default(SyntaxList<AttributeListSyntax>)); DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 2446, 2507);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 2446, 2507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 2446, 2507);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
            f_10724_2449_2507(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            one)
            {
                var return_v = OneOrMany.Create(one);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10724, 2449, 2507);
                return return_v;
            }

        }

        public sealed override string? GetDocumentationCommentXml(CultureInfo? preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 2692, 2699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 2695, 2699);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 2692, 2699);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 2692, 2699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 2692, 2699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 2760, 2768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 2763, 2768);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 2760, 2768);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 2760, 2768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 2760, 2768);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool SynthesizesLoweredBoundBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 2839, 2846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 2842, 2846);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 2839, 2846);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 2839, 2846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 2839, 2846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 2859, 4078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 3045, 3084);

                var
                compilation = f_10724_3063_3083()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 3098, 3132);

                var
                location = f_10724_3113_3131()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 3146, 4067);

                return (ReturnType: TypeWithAnnotations.Create(f_10724_3193_3278(compilation, SpecialType.System_Boolean, location, diagnostics)),
                                    Parameters: f_10724_3314_4065(f_10724_3391_3708(owner: this, TypeWithAnnotations.Create(f_10724_3532_3546(), NullableAnnotation.Annotated), ordinal: 0, RefKind.None, "r1", isDiscard: false, f_10724_3698_3707()), f_10724_3747_4064(owner: this, TypeWithAnnotations.Create(f_10724_3888_3902(), NullableAnnotation.Annotated), ordinal: 1, RefKind.None, "r2", isDiscard: false, f_10724_4054_4063())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 2859, 4078);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10724_3063_3083()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10724, 3063, 3083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10724_3113_3131()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10724, 3113, 3131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10724_3193_3278(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10724, 3193, 3278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10724_3532_3546()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10724, 3532, 3546);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10724_3698_3707()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10724, 3698, 3707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                f_10724_3391_3708(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityOperatorBase
                owner, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, bool
                isDiscard, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol(owner: (Microsoft.CodeAnalysis.CSharp.Symbol)owner, parameterType, ordinal: ordinal, refKind, name, isDiscard: isDiscard, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10724, 3391, 3708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10724_3888_3902()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10724, 3888, 3902);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10724_4054_4063()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10724, 4054, 4063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                f_10724_3747_4064(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityOperatorBase
                owner, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, bool
                isDiscard, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol(owner: (Microsoft.CodeAnalysis.CSharp.Symbol)owner, parameterType, ordinal: ordinal, refKind, name, isDiscard: isDiscard, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10724, 3747, 4064);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10724_3314_4065(Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create<ParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item1, (Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10724, 3314, 4065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 2859, 4078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 2859, 4078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10724, 4143, 4147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10724, 4146, 4147);
                return 2; DynAbs.Tracing.TraceSender.TraceExitMethod(10724, 4143, 4147);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10724, 4143, 4147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 4143, 4147);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedRecordEqualityOperatorBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10724, 1095, 4155);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10724, 1095, 4155);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10724, 1095, 4155);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10724, 1095, 4155);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10724_1486_1510(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10724, 1486, 1510);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_10724_1533_1564(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.SyntaxReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10724, 1533, 1564);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10724_1533_1579(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.GetSyntax();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10724, 1533, 1579);
            return return_v;
        }


        int
        f_10724_1792_1910(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10724, 1792, 1910);
            return 0;
        }


        static Microsoft.CodeAnalysis.MethodKind
        f_10724_1432_1462_C(Microsoft.CodeAnalysis.MethodKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10724, 1258, 1965);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10724_2103_2112()
        {
            var return_v = Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10724, 2103, 2112);
            return return_v;
        }

    }
}
