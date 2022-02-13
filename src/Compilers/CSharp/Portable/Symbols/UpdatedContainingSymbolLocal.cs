// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class UpdatedContainingSymbolAndNullableAnnotationLocal : LocalSymbol
    {
        internal static UpdatedContainingSymbolAndNullableAnnotationLocal CreateForTest(SourceLocalSymbol underlyingLocal, Symbol updatedContainingSymbol, TypeWithAnnotations updatedType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10179, 719, 1075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 923, 1064);

                return f_10179_930_1063(underlyingLocal, updatedContainingSymbol, updatedType, assertContaining: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10179, 719, 1075);

                Microsoft.CodeAnalysis.CSharp.Symbols.UpdatedContainingSymbolAndNullableAnnotationLocal
                f_10179_930_1063(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                underlyingLocal, Microsoft.CodeAnalysis.CSharp.Symbol
                updatedContainingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                updatedType, bool
                assertContaining)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UpdatedContainingSymbolAndNullableAnnotationLocal(underlyingLocal, updatedContainingSymbol, updatedType, assertContaining: assertContaining);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 930, 1063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 719, 1075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 719, 1075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UpdatedContainingSymbolAndNullableAnnotationLocal(SourceLocalSymbol underlyingLocal, Symbol updatedContainingSymbol, TypeWithAnnotations updatedType, bool assertContaining)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10179, 1087, 1727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2065, 2081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2092, 2140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 1292, 1338);

                f_10179_1292_1337(underlyingLocal is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 1352, 1406);

                f_10179_1352_1405(updatedContainingSymbol is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 1420, 1562);

                f_10179_1420_1561(!assertContaining || (DynAbs.Tracing.TraceSender.Expression_False(10179, 1433, 1560) || f_10179_1454_1560(updatedContainingSymbol, f_10179_1485_1517(underlyingLocal), TypeCompareKind.AllNullableIgnoreOptions)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 1576, 1619);

                ContainingSymbol = updatedContainingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 1633, 1667);

                TypeWithAnnotations = updatedType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 1681, 1716);

                _underlyingLocal = underlyingLocal;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10179, 1087, 1727);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 1087, 1727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 1087, 1727);
            }
        }

        internal UpdatedContainingSymbolAndNullableAnnotationLocal(SourceLocalSymbol underlyingLocal, Symbol updatedContainingSymbol, TypeWithAnnotations updatedType)
        : this(f_10179_1918_1933_C(underlyingLocal), updatedContainingSymbol, updatedType, assertContaining: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10179, 1739, 2018);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10179, 1739, 2018);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 1739, 2018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 1739, 2018);
            }
        }

        private readonly SourceLocalSymbol _underlyingLocal;

        public override Symbol ContainingSymbol { get; }

        public override TypeWithAnnotations TypeWithAnnotations { get; }

        public override bool Equals(Symbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 2226, 3286);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2321, 2407) || true) && (other == (object)this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10179, 2321, 2407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2380, 2392);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10179, 2321, 2407);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2423, 2523) || true) && (!(other is LocalSymbol otherLocal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10179, 2423, 2523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2495, 2508);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10179, 2423, 2523);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2539, 2804);

                SourceLocalSymbol?
                otherSource = otherLocal switch
                {
                    UpdatedContainingSymbolAndNullableAnnotationLocal updated when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2622, 2707) && DynAbs.Tracing.TraceSender.Expression_True(10179, 2622, 2707))
=> updated._underlyingLocal,
                    SourceLocalSymbol source when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2726, 2760) && DynAbs.Tracing.TraceSender.Expression_True(10179, 2726, 2760))
=> source,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2779, 2788) && DynAbs.Tracing.TraceSender.Expression_True(10179, 2779, 2788))
=> null
                }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2820, 2959) || true) && (otherSource is null || (DynAbs.Tracing.TraceSender.Expression_False(10179, 2824, 2897) || !f_10179_2848_2897(_underlyingLocal, otherSource, compareKind)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10179, 2820, 2959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2931, 2944);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10179, 2820, 2959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 2975, 3058);

                var
                ignoreNullable = (compareKind & TypeCompareKind.AllNullableIgnoreOptions) != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 3072, 3275);

                return ignoreNullable || (DynAbs.Tracing.TraceSender.Expression_False(10179, 3079, 3274) || (f_10179_3115_3134().Equals(f_10179_3142_3172(otherLocal), compareKind) && (DynAbs.Tracing.TraceSender.Expression_True(10179, 3115, 3273) && f_10179_3208_3273(f_10179_3208_3224(), f_10179_3232_3259(otherLocal), compareKind))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 2226, 3286);

                bool
                f_10179_2848_2897(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                obj, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)obj, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 2848, 2897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10179_3115_3134()
                {
                    var return_v = TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 3115, 3134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10179_3142_3172(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 3142, 3172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10179_3208_3224()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 3208, 3224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10179_3232_3259(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 3232, 3259);
                    return return_v;
                }


                bool
                f_10179_3208_3273(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 3208, 3273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 2226, 3286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 2226, 3286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 3608, 3641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 3611, 3641);
                return f_10179_3611_3641(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 3608, 3641);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 3608, 3641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 3608, 3641);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10179_3611_3641(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 3611, 3641);
                return return_v;
            }

        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 3712, 3739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 3715, 3739);
                    return f_10179_3715_3739(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 3712, 3739);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 3712, 3739);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 3712, 3739);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 3801, 3830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 3804, 3830);
                    return f_10179_3804_3830(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 3801, 3830);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 3801, 3830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 3801, 3830);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 3915, 3960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 3918, 3960);
                    return f_10179_3918_3960(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 3915, 3960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 3915, 3960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 3915, 3960);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 3999, 4023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4002, 4023);
                    return f_10179_4002_4023(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 3999, 4023);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 3999, 4023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 3999, 4023);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4076, 4116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4079, 4116);
                    return f_10179_4079_4116(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4076, 4116);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4076, 4116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4076, 4116);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LocalDeclarationKind DeclarationKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4182, 4217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4185, 4217);
                    return f_10179_4185_4217(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4182, 4217);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4182, 4217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4182, 4217);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SynthesizedLocalKind SynthesizedKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4283, 4318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4286, 4318);
                    return f_10179_4286_4318(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4283, 4318);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4283, 4318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4283, 4318);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxNode ScopeDesignatorOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4377, 4415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4380, 4415);
                    return f_10179_4380_4415(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4377, 4415);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4377, 4415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4377, 4415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsImportedFromMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4472, 4514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4475, 4514);
                    return f_10179_4475_4514(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4472, 4514);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4472, 4514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4472, 4514);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxToken IdentifierToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4571, 4606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4574, 4606);
                    return f_10179_4574_4606(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4571, 4606);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4571, 4606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4571, 4606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsPinned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4649, 4677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4652, 4677);
                    return f_10179_4652_4677(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4649, 4677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4649, 4677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4649, 4677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCompilerGenerated
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4731, 4770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4734, 4770);
                    return f_10179_4734_4770(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4731, 4770);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4731, 4770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4731, 4770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override uint RefEscapeScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4819, 4853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4822, 4853);
                    return f_10179_4822_4853(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4819, 4853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4819, 4853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4819, 4853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override uint ValEscapeScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 4902, 4936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 4905, 4936);
                    return f_10179_4905_4936(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 4902, 4936);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 4902, 4936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 4902, 4936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue GetConstantValue(SyntaxNode node, LocalSymbol inProgress, DiagnosticBag? diagnostics = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 5072, 5152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 5088, 5152);
                return f_10179_5088_5152(_underlyingLocal, node, inProgress, diagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 5072, 5152);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 5072, 5152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 5072, 5152);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ConstantValue
            f_10179_5088_5152(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
            this_param, Microsoft.CodeAnalysis.SyntaxNode
            node, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
            inProgress, Microsoft.CodeAnalysis.DiagnosticBag?
            diagnostics)
            {
                var return_v = this_param.GetConstantValue(node, inProgress, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 5088, 5152);
                return return_v;
            }

        }

        internal override ImmutableArray<Diagnostic> GetConstantValueDiagnostics(BoundExpression boundInitValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 5268, 5344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 5284, 5344);
                return f_10179_5284_5344(_underlyingLocal, boundInitValue); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 5268, 5344);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 5268, 5344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 5268, 5344);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
            f_10179_5284_5344(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
            this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
            boundInitValue)
            {
                var return_v = this_param.GetConstantValueDiagnostics(boundInitValue);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 5284, 5344);
                return return_v;
            }

        }

        internal override SyntaxNode GetDeclaratorSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 5406, 5460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 5422, 5460);
                return f_10179_5422_5460(_underlyingLocal); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 5406, 5460);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 5406, 5460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 5406, 5460);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxNode
            f_10179_5422_5460(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
            this_param)
            {
                var return_v = this_param.GetDeclaratorSyntax();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 5422, 5460);
                return return_v;
            }

        }

        internal override LocalSymbol WithSynthesizedLocalKindAndSyntax(SynthesizedLocalKind kind, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10179, 5581, 5633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10179, 5597, 5633);
                throw f_10179_5603_5633(); DynAbs.Tracing.TraceSender.TraceExitMethod(10179, 5581, 5633);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10179, 5581, 5633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 5581, 5633);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10179_5603_5633()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 5603, 5633);
                return return_v;
            }

        }

        static UpdatedContainingSymbolAndNullableAnnotationLocal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10179, 355, 5661);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10179, 355, 5661);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10179, 355, 5661);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10179, 355, 5661);

        int
        f_10179_1292_1337(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 1292, 1337);
            return 0;
        }


        int
        f_10179_1352_1405(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 1352, 1405);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10179_1485_1517(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 1485, 1517);
            return return_v;
        }


        bool
        f_10179_1454_1560(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        other, Microsoft.CodeAnalysis.TypeCompareKind
        compareKind)
        {
            var return_v = this_param.Equals(other, compareKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 1454, 1560);
            return return_v;
        }


        int
        f_10179_1420_1561(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10179, 1420, 1561);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        f_10179_1918_1933_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10179, 1739, 2018);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10179_3715_3739(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 3715, 3739);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10179_3804_3830(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 3804, 3830);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_10179_3918_3960(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.DeclaringSyntaxReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 3918, 3960);
            return return_v;
        }


        string
        f_10179_4002_4023(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4002, 4023);
            return return_v;
        }


        bool
        f_10179_4079_4116(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.IsImplicitlyDeclared;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4079, 4116);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
        f_10179_4185_4217(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.DeclarationKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4185, 4217);
            return return_v;
        }


        Microsoft.CodeAnalysis.SynthesizedLocalKind
        f_10179_4286_4318(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.SynthesizedKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4286, 4318);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_10179_4380_4415(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.ScopeDesignatorOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4380, 4415);
            return return_v;
        }


        bool
        f_10179_4475_4514(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.IsImportedFromMetadata;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4475, 4514);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxToken
        f_10179_4574_4606(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.IdentifierToken;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4574, 4606);
            return return_v;
        }


        bool
        f_10179_4652_4677(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.IsPinned;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4652, 4677);
            return return_v;
        }


        bool
        f_10179_4734_4770(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.IsCompilerGenerated;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4734, 4770);
            return return_v;
        }


        uint
        f_10179_4822_4853(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.RefEscapeScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4822, 4853);
            return return_v;
        }


        uint
        f_10179_4905_4936(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
        this_param)
        {
            var return_v = this_param.ValEscapeScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10179, 4905, 4936);
            return return_v;
        }

    }
}
