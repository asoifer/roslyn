// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class DynamicTypeSymbol : TypeSymbol
    {
        internal static readonly DynamicTypeSymbol Instance;

        private DynamicTypeSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10101, 617, 666);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10101, 617, 666);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 617, 666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 617, 666);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 730, 798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 766, 783);

                    return "dynamic";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 730, 798);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 678, 809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 678, 809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 877, 941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 913, 926);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 877, 941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 821, 952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 821, 952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 1025, 1088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 1061, 1073);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 1025, 1088);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 964, 1099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 964, 1099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 1165, 1229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 1201, 1214);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 1165, 1229);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 1111, 1240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 1111, 1240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 1308, 1389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 1344, 1374);

                    return SymbolKind.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 1308, 1389);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 1252, 1400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 1252, 1400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 1470, 1545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 1506, 1530);

                    return TypeKind.Dynamic;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 1470, 1545);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 1412, 1556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 1412, 1556);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 1643, 1732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 1679, 1717);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 1643, 1732);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 1568, 1743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 1568, 1743);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 1853, 1949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 1889, 1934);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 1853, 1949);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 1755, 1960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 1755, 1960);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol? BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 2036, 2043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 2039, 2043);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 2036, 2043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 2036, 2043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 2036, 2043);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol>? basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 2056, 2259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 2203, 2248);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 2056, 2259);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 2056, 2259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 2056, 2259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 2325, 2389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 2361, 2374);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 2325, 2389);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 2271, 2400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 2271, 2400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 2469, 2533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 2505, 2518);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 2469, 2533);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 2412, 2544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 2412, 2544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ManagedKind GetManagedKind(ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 2657, 2679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 2660, 2679);
                return ManagedKind.Managed; DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 2657, 2679);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 2657, 2679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 2657, 2679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 2758, 2822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 2794, 2807);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 2758, 2822);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 2692, 2833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 2692, 2833);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 2908, 2972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 2944, 2957);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 2908, 2972);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 2845, 2983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 2845, 2983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 3089, 3109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 3095, 3107);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 3089, 3109);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 2995, 3120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 2995, 3120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 3132, 3255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 3208, 3244);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 3132, 3255);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 3132, 3255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 3132, 3255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 3267, 3401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 3354, 3390);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 3267, 3401);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 3267, 3401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 3267, 3401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 3413, 3569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 3513, 3558);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 3413, 3569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 3413, 3569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 3413, 3569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 3581, 3726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 3670, 3715);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 3581, 3726);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 3581, 3726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 3581, 3726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 3738, 3943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 3884, 3932);

                return f_10101_3891_3931<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 3738, 3943);

                TResult
                f_10101_3891_3931<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitDynamicType(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 3891, 3931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 3738, 3943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 3738, 3943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 3955, 4078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 4036, 4067);

                f_10101_4036_4066(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 3955, 4078);

                int
                f_10101_4036_4066(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                symbol)
                {
                    this_param.VisitDynamicType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 4036, 4066);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 3955, 4078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 3955, 4078);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 4090, 4241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 4192, 4230);

                return f_10101_4199_4229<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 4090, 4241);

                TResult
                f_10101_4199_4229<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                symbol)
                {
                    var return_v = this_param.VisitDynamicType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 4199, 4229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 4090, 4241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 4090, 4241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 4318, 4381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 4354, 4366);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 4318, 4381);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 4253, 4392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 4253, 4392);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 4480, 4566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 4516, 4551);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 4480, 4566);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 4404, 4577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 4404, 4577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 4589, 4780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 4756, 4769);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 4589, 4780);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 4589, 4780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 4589, 4780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 4792, 5107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 5035, 5096);

                return (int)Microsoft.CodeAnalysis.SpecialType.System_Object;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 4792, 5107);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 4792, 5107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 4792, 5107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol? t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 5119, 5756);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 5217, 5302) || true) && ((object?)t2 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10101, 5217, 5302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 5274, 5287);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10101, 5217, 5302);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 5318, 5443) || true) && (f_10101_5322_5347(this, t2) || (DynAbs.Tracing.TraceSender.Expression_False(10101, 5322, 5382) || f_10101_5351_5362(t2) == TypeKind.Dynamic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10101, 5318, 5443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 5416, 5428);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10101, 5318, 5443);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 5459, 5716) || true) && ((comparison & TypeCompareKind.IgnoreDynamic) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10101, 5459, 5716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 5546, 5580);

                    var
                    other = t2 as NamedTypeSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 5598, 5701);

                    return (object?)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10101, 5605, 5700) && f_10101_5631_5648(other) == Microsoft.CodeAnalysis.SpecialType.System_Object);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10101, 5459, 5716);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 5732, 5745);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 5119, 5756);

                bool
                f_10101_5322_5347(Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 5322, 5347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10101_5351_5362(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10101, 5351, 5362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10101_5631_5648(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10101, 5631, 5648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 5119, 5756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 5119, 5756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddNullableTransforms(ArrayBuilder<byte> transforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 5768, 5865);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 5768, 5865);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 5768, 5865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 5768, 5865);
            }
        }

        internal override bool ApplyNullableTransforms(byte defaultTransformFlag, ImmutableArray<byte> transforms, ref int position, out TypeSymbol result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 5877, 6100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 6049, 6063);

                result = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 6077, 6089);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 5877, 6100);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 5877, 6100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 5877, 6100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol SetNullabilityForReferenceTypes(Func<TypeWithAnnotations, TypeWithAnnotations> transform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 6112, 6278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 6255, 6267);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 6112, 6278);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 6112, 6278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 6112, 6278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol MergeEquivalentTypes(TypeSymbol other, VarianceKind variance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 6290, 6578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 6405, 6541);

                f_10101_6405_6540(f_10101_6418_6539(this, other, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 6555, 6567);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 6290, 6578);

                bool
                f_10101_6418_6539(Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 6418, 6539);
                    return return_v;
                }


                int
                f_10101_6405_6540(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 6405, 6540);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 6290, 6578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 6290, 6578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 6590, 6742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 6657, 6731);

                return f_10101_6664_6730(this, f_10101_6704_6729());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 6590, 6742);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10101_6704_6729()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10101, 6704, 6729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DynamicTypeSymbol
                f_10101_6664_6730(Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DynamicTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 6664, 6730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 6590, 6742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 6590, 6742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override ITypeSymbol CreateITypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 6754, 7040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 6886, 6948);

                f_10101_6886_6947(nullableAnnotation != f_10101_6921_6946());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 6962, 7029);

                return f_10101_6969_7028(this, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 6754, 7040);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10101_6921_6946()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10101, 6921, 6946);
                    return return_v;
                }


                int
                f_10101_6886_6947(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 6886, 6947);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DynamicTypeSymbol
                f_10101_6969_7028(Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DynamicTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 6969, 7028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 6754, 7040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 6754, 7040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10101, 7084, 7092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 7087, 7092);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10101, 7084, 7092);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10101, 7084, 7092);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 7084, 7092);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static DynamicTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10101, 450, 7100);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10101, 570, 604);
            Instance = f_10101_581_604(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10101, 450, 7100);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10101, 450, 7100);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10101, 450, 7100);

        static Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
        f_10101_581_604()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10101, 581, 604);
            return return_v;
        }

    }
}
