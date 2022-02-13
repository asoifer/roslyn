// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Roslyn.Utilities;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class PointerTypeSymbol : TypeSymbol
    {
        private readonly TypeWithAnnotations _pointedAtType;

        internal PointerTypeSymbol(TypeWithAnnotations pointedAtType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10145, 924, 1104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 3668, 3680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 1010, 1046);

                f_10145_1010_1045(pointedAtType.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 1062, 1093);

                _pointedAtType = pointedAtType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10145, 924, 1104);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 924, 1104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 924, 1104);
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 1192, 1235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 1198, 1233);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 1192, 1235);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 1116, 1246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 1116, 1246);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 1312, 1376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 1348, 1361);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 1312, 1376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 1258, 1387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 1258, 1387);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 1455, 1519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 1491, 1504);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 1455, 1519);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 1399, 1530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 1399, 1530);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 1596, 1660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 1632, 1645);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 1596, 1660);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 1542, 1671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 1542, 1671);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeWithAnnotations PointedAtTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 1937, 2010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 1973, 1995);

                    return _pointedAtType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 1937, 2010);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 1857, 2021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 1857, 2021);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeSymbol PointedAtType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 2211, 2247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 2214, 2247);
                    return f_10145_2214_2242().Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 2211, 2247);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 2211, 2247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 2211, 2247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 2347, 2496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 2469, 2481);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 2347, 2496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 2260, 2507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 2260, 2507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 2519, 2803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 2747, 2792);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 2519, 2803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 2519, 2803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 2519, 2803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 2876, 2940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 2912, 2925);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 2876, 2940);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 2815, 2951);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 2815, 2951);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 3020, 3083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 3056, 3068);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 3020, 3083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 2963, 3094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 2963, 3094);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ManagedKind GetManagedKind(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 3206, 3230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 3209, 3230);
                return ManagedKind.Unmanaged; DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 3206, 3230);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 3206, 3230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 3206, 3230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 3309, 3373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 3345, 3358);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 3309, 3373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 3243, 3384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 3243, 3384);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 3459, 3523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 3495, 3508);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 3459, 3523);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 3396, 3534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 3396, 3534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 3639, 3659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 3645, 3657);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 3639, 3659);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 3546, 3670);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 3546, 3670);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 3682, 3805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 3758, 3794);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 3682, 3805);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 3682, 3805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 3682, 3805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 3817, 3951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 3904, 3940);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 3817, 3951);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 3817, 3951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 3817, 3951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 3963, 4108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 4052, 4097);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 3963, 4108);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 3963, 4108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 3963, 4108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 4120, 4276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 4220, 4265);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 4120, 4276);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 4120, 4276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 4120, 4276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 4288, 4455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 4399, 4444);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 4288, 4455);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 4288, 4455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 4288, 4455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 4523, 4604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 4559, 4589);

                    return SymbolKind.PointerType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 4523, 4604);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 4467, 4615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 4467, 4615);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 4685, 4760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 4721, 4745);

                    return TypeKind.Pointer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 4685, 4760);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 4627, 4771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 4627, 4771);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 4847, 4910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 4883, 4895);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 4847, 4910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 4783, 4921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 4783, 4921);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 5008, 5097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 5044, 5082);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 5008, 5097);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 4933, 5108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 4933, 5108);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 5218, 5314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 5254, 5299);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 5218, 5314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 5120, 5325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 5120, 5325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 5337, 5542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 5483, 5531);

                return f_10145_5490_5530<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 5337, 5542);

                TResult
                f_10145_5490_5530<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitPointerType(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 5490, 5530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 5337, 5542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 5337, 5542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 5554, 5677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 5635, 5666);

                f_10145_5635_5665(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 5554, 5677);

                int
                f_10145_5635_5665(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                symbol)
                {
                    this_param.VisitPointerType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 5635, 5665);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 5554, 5677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 5554, 5677);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 5689, 5840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 5791, 5829);

                return f_10145_5798_5828<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 5689, 5840);

                TResult
                f_10145_5798_5828<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                symbol)
                {
                    var return_v = this_param.VisitPointerType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 5798, 5828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 5689, 5840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 5689, 5840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 5852, 6398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6072, 6093);

                int
                indirections = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6107, 6133);

                TypeSymbol
                current = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6147, 6328) || true) && (f_10145_6154_6170(current) == TypeKind.Pointer)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10145, 6147, 6328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6224, 6242);

                        indirections += 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6260, 6313);

                        current = f_10145_6270_6312(((PointerTypeSymbol)current));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10145, 6147, 6328);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10145, 6147, 6328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10145, 6147, 6328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6344, 6387);

                return f_10145_6351_6386(current, indirections);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 5852, 6398);

                Microsoft.CodeAnalysis.TypeKind
                f_10145_6154_6170(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 6154, 6170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10145_6270_6312(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 6270, 6312);
                    return return_v;
                }


                int
                f_10145_6351_6386(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 6351, 6386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 5852, 6398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 5852, 6398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 6410, 6574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6507, 6563);

                return f_10145_6514_6562(this, t2 as PointerTypeSymbol, comparison);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 6410, 6574);

                bool
                f_10145_6514_6562(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol?)other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 6514, 6562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 6410, 6574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 6410, 6574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool Equals(PointerTypeSymbol other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 6586, 6978);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6683, 6776) || true) && (f_10145_6687_6715(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10145, 6683, 6776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6749, 6761);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10145, 6683, 6776);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6792, 6939) || true) && ((object)other == null || (DynAbs.Tracing.TraceSender.Expression_False(10145, 6796, 6877) || !other._pointedAtType.Equals(_pointedAtType, comparison)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10145, 6792, 6939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6911, 6924);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10145, 6792, 6939);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 6955, 6967);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 6586, 6978);

                bool
                f_10145_6687_6715(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 6687, 6715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 6586, 6978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 6586, 6978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddNullableTransforms(ArrayBuilder<byte> transforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 6990, 7164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 7090, 7153);

                f_10145_7090_7118().AddNullableTransforms(transforms);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 6990, 7164);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10145_7090_7118()
                {
                    var return_v = PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 7090, 7118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 6990, 7164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 6990, 7164);
            }
        }

        internal override bool ApplyNullableTransforms(byte defaultTransformFlag, ImmutableArray<byte> transforms, ref int position, out TypeSymbol result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 7176, 7790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 7348, 7416);

                TypeWithAnnotations
                oldPointedAtType = f_10145_7387_7415()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 7430, 7467);

                TypeWithAnnotations
                newPointedAtType
                = default(TypeWithAnnotations);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 7483, 7692) || true) && (!oldPointedAtType.ApplyNullableTransforms(defaultTransformFlag, transforms, ref position, out newPointedAtType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10145, 7483, 7692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 7632, 7646);

                    result = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 7664, 7677);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10145, 7483, 7692);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 7708, 7753);

                result = f_10145_7717_7752(this, newPointedAtType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 7767, 7779);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 7176, 7790);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10145_7387_7415()
                {
                    var return_v = PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 7387, 7415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10145_7717_7752(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newPointedAtType)
                {
                    var return_v = this_param.WithPointedAtType(newPointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 7717, 7752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 7176, 7790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 7176, 7790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol SetNullabilityForReferenceTypes(Func<TypeWithAnnotations, TypeWithAnnotations> transform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 7802, 8022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 7945, 8011);

                return f_10145_7952_8010(this, f_10145_7970_8009(transform, f_10145_7980_8008()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 7802, 8022);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10145_7980_8008()
                {
                    var return_v = PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 7980, 8008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10145_7970_8009(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 7970, 8009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10145_7952_8010(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newPointedAtType)
                {
                    var return_v = this_param.WithPointedAtType(newPointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 7952, 8010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 7802, 8022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 7802, 8022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol MergeEquivalentTypes(TypeSymbol other, VarianceKind variance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 8034, 8526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 8149, 8285);

                f_10145_8149_8284(f_10145_8162_8283(this, other, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 8299, 8461);

                TypeWithAnnotations
                pointedAtType = f_10145_8335_8363().MergeEquivalentTypes(f_10145_8385_8440(((PointerTypeSymbol)other)), VarianceKind.None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 8475, 8515);

                return f_10145_8482_8514(this, pointedAtType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 8034, 8526);

                bool
                f_10145_8162_8283(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 8162, 8283);
                    return return_v;
                }


                int
                f_10145_8149_8284(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 8149, 8284);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10145_8335_8363()
                {
                    var return_v = PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 8335, 8363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10145_8385_8440(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 8385, 8440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10145_8482_8514(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newPointedAtType)
                {
                    var return_v = this_param.WithPointedAtType(newPointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 8482, 8514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 8034, 8526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 8034, 8526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PointerTypeSymbol WithPointedAtType(TypeWithAnnotations newPointedAtType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 8538, 8768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 8645, 8757);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10145, 8652, 8707) || ((f_10145_8652_8680().IsSameAs(newPointedAtType) && DynAbs.Tracing.TraceSender.Conditional_F2(10145, 8710, 8714)) || DynAbs.Tracing.TraceSender.Conditional_F3(10145, 8717, 8756))) ? this : f_10145_8717_8756(newPointedAtType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 8538, 8768);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10145_8652_8680()
                {
                    var return_v = PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 8652, 8680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10145_8717_8756(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 8717, 8756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 8538, 8768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 8538, 8768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 8780, 9102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 8860, 8889);

                DiagnosticInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 8950, 9063);

                f_10145_8950_9062(this, ref result, f_10145_8994_9027(this), AllowedRequiredModifierType.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 9077, 9091);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 8780, 9102);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10145_8994_9027(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 8994, 9027);
                    return return_v;
                }


                bool
                f_10145_8950_9062(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, type, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 8950, 9062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 8780, 9102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 8780, 9102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 9114, 9411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 9281, 9400);

                return this.PointedAtTypeWithAnnotations.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 9114, 9411);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 9114, 9411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 9114, 9411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 9423, 9575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 9490, 9564);

                return f_10145_9497_9563(this, f_10145_9537_9562());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 9423, 9575);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10145_9537_9562()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 9537, 9562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PointerTypeSymbol
                f_10145_9497_9563(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PointerTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 9497, 9563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 9423, 9575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 9423, 9575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ITypeSymbol CreateITypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 9587, 9866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 9712, 9774);

                f_10145_9712_9773(nullableAnnotation != f_10145_9747_9772());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 9788, 9855);

                return f_10145_9795_9854(this, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 9587, 9866);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10145_9747_9772()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 9747, 9772);
                    return return_v;
                }


                int
                f_10145_9712_9773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 9712, 9773);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PointerTypeSymbol
                f_10145_9795_9854(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PointerTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 9795, 9854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 9587, 9866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 9587, 9866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10145, 9910, 9918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10145, 9913, 9918);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10145, 9910, 9918);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10145, 9910, 9918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10145, 9910, 9918);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int
        f_10145_1010_1045(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10145, 1010, 1045);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10145_2214_2242()
        {
            var return_v = PointedAtTypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10145, 2214, 2242);
            return return_v;
        }

    }
}
