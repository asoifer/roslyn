// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedRecordOrdinaryMethod : SourceOrdinaryMethodSymbolBase
    {
        private readonly int _memberOffset;

        protected SynthesizedRecordOrdinaryMethod(SourceMemberContainerTypeSymbol containingType, string name, bool hasBody, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10730_879_893_C(containingType), name, f_10730_901_925(containingType)[0], (CSharpSyntaxNode)f_10730_948_994(f_10730_948_979(containingType)[0]), MethodKind.Ordinary, isIterator: false, isExtensionMethod: false, isPartial: false, hasBody: hasBody, isNullableAnalysisEnabled: false, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10730, 697, 1229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 671, 684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 1189, 1218);

                _memberOffset = memberOffset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10730, 697, 1229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 697, 1229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 697, 1229);
            }
        }

        protected sealed override bool HasAnyBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 1283, 1290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 1286, 1290);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 1283, 1290);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 1283, 1290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 1283, 1290);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 1352, 1360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 1355, 1360);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 1352, 1360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 1352, 1360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 1352, 1360);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 1422, 1429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 1425, 1429);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 1422, 1429);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 1422, 1429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 1422, 1429);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 1496, 1511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 1499, 1511);
                    return f_10730_1499_1508()[0]; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 1496, 1511);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 1496, 1511);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 1496, 1511);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override MethodSymbol? FindExplicitlyImplementedMethod(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 1623, 1630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 1626, 1630);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 1623, 1630);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 1623, 1630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 1623, 1630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 1703, 1759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 1706, 1759);
                return LexicalSortKey.GetSynthesizedMemberKey(_memberOffset); DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 1703, 1759);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 1703, 1759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 1703, 1759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override ImmutableArray<TypeParameterSymbol> MakeTypeParameters(CSharpSyntaxNode node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 1903, 1947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 1906, 1947);
                return ImmutableArray<TypeParameterSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 1903, 1947);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 1903, 1947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 1903, 1947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 2069, 2129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 2072, 2129);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 2069, 2129);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 2069, 2129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 2069, 2129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 2243, 2295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 2246, 2295);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 2243, 2295);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 2243, 2295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 2243, 2295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override void PartialMethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 2308, 2407);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 2308, 2407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 2308, 2407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 2308, 2407);
            }
        }

        protected sealed override void ExtensionMethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 2419, 2520);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 2419, 2520);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 2419, 2520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 2419, 2520);
            }
        }

        protected sealed override void CompleteAsyncMethodChecksBetweenStartAndFinish()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 2532, 2633);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 2532, 2633);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 2532, 2633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 2532, 2633);
            }
        }

        protected sealed override TypeSymbol? ExplicitInterfaceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 2705, 2712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 2708, 2712);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 2705, 2712);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 2705, 2712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 2705, 2712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override void CheckConstraintsForExplicitInterfaceType(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 2725, 2874);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 2725, 2874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 2725, 2874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 2725, 2874);
            }
        }

        protected sealed override SourceMemberMethodSymbol? BoundAttributesSource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 2960, 2967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 2963, 2967);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 2960, 2967);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 2960, 2967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 2960, 2967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 3075, 3136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 3078, 3136);
                return f_10730_3078_3136(default(SyntaxList<AttributeListSyntax>)); DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 3075, 3136);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 3075, 3136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 3075, 3136);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
            f_10730_3078_3136(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            one)
            {
                var return_v = OneOrMany.Create(one);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10730, 3078, 3136);
                return return_v;
            }

        }

        public sealed override string? GetDocumentationCommentXml(CultureInfo? preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 3321, 3328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 3324, 3328);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 3321, 3328);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 3321, 3328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 3321, 3328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 3378, 3386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 3381, 3386);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 3378, 3386);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 3378, 3386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 3378, 3386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 3438, 3453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 3441, 3453);
                    return RefKind.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 3438, 3453);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 3438, 3453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 3438, 3453);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 3514, 3522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 3517, 3522);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 3514, 3522);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 3514, 3522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 3514, 3522);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10730, 3593, 3600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10730, 3596, 3600);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10730, 3593, 3600);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10730, 3593, 3600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 3593, 3600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedRecordOrdinaryMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10730, 545, 3608);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10730, 545, 3608);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10730, 545, 3608);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10730, 545, 3608);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10730_901_925(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10730, 901, 925);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_10730_948_979(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.SyntaxReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10730, 948, 979);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10730_948_994(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.GetSyntax();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10730, 948, 994);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10730_879_893_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10730, 697, 1229);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10730_1499_1508()
        {
            var return_v = Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10730, 1499, 1508);
            return return_v;
        }

    }
}
