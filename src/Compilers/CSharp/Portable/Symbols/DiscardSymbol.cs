// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class DiscardSymbol : Symbol
    {
        public DiscardSymbol(TypeWithAnnotations typeWithAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10099, 431, 633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 517, 566);

                f_10099_517_565(typeWithAnnotations.Type is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 580, 622);

                TypeWithAnnotations = typeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10099, 431, 633);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 431, 633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 431, 633);
            }
        }

        public TypeWithAnnotations TypeWithAnnotations { get; }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 753, 760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 756, 760);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 753, 760);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 753, 760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 753, 760);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 823, 853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 826, 853);
                    return Accessibility.NotApplicable; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 823, 853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 823, 853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 823, 853);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 938, 978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 941, 978);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 938, 978);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 938, 978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 938, 978);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1021, 1029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1024, 1029);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1021, 1029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1021, 1029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1021, 1029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1070, 1078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1073, 1078);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1070, 1078);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1070, 1078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1070, 1078);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1131, 1138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1134, 1138);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1131, 1138);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1131, 1138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1131, 1138);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1181, 1189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1184, 1189);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1181, 1189);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1181, 1189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1181, 1189);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1230, 1238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1233, 1238);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1230, 1238);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1230, 1238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1230, 1238);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1279, 1287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1282, 1287);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1279, 1287);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1279, 1287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1279, 1287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1329, 1337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1332, 1337);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1329, 1337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1329, 1337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1329, 1337);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1380, 1401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1383, 1401);
                    return SymbolKind.Discard; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1380, 1401);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1380, 1401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1380, 1401);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1463, 1496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1466, 1496);
                    return ImmutableArray<Location>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1463, 1496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1463, 1496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1463, 1496);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1570, 1577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1573, 1577);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1570, 1577);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1570, 1577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1570, 1577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1703, 1735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1706, 1735);
                return f_10099_1706_1735<TResult, TArgument>(visitor, this, a); DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1703, 1735);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1703, 1735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1703, 1735);
            }
            throw new System.Exception("Slicer error: unreachable code");

            TResult
            f_10099_1706_1735<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol
            symbol, TArgument
            argument)
            {
                var return_v = this_param.VisitDiscard(symbol, argument);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10099, 1706, 1735);
                return return_v;
            }

        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1803, 1832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1806, 1832);
                f_10099_1806_1832(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1803, 1832);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1803, 1832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1803, 1832);
            }

            int
            f_10099_1806_1832(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol
            symbol)
            {
                this_param.VisitDiscard(symbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10099, 1806, 1832);
                return 0;
            }

        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 1921, 1950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 1924, 1950);
                return f_10099_1924_1950<TResult>(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 1921, 1950);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 1921, 1950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 1921, 1950);
            }
            throw new System.Exception("Slicer error: unreachable code");

            TResult
            f_10099_1924_1950<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol
            symbol)
            {
                var return_v = this_param.VisitDiscard(symbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10099, 1924, 1950);
                return return_v;
            }

        }

        public override bool Equals(Symbol? obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 2033, 2137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 2036, 2137);
                return obj is DiscardSymbol other && (DynAbs.Tracing.TraceSender.Expression_True(10099, 2036, 2137) && this.TypeWithAnnotations.Equals(f_10099_2098_2123(other), compareKind)); DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 2033, 2137);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 2033, 2137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 2033, 2137);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10099_2098_2123(Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol
            this_param)
            {
                var return_v = this_param.TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10099, 2098, 2123);
                return return_v;
            }

        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 2182, 2223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 2185, 2223);
                return this.TypeWithAnnotations.GetHashCode(); DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 2182, 2223);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 2182, 2223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 2182, 2223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10099, 2236, 2357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10099, 2303, 2346);

                return f_10099_2310_2345(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10099, 2236, 2357);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DiscardSymbol
                f_10099_2310_2345(Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DiscardSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10099, 2310, 2345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10099, 2236, 2357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 2236, 2357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DiscardSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10099, 370, 2364);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10099, 370, 2364);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10099, 370, 2364);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10099, 370, 2364);

        int
        f_10099_517_565(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10099, 517, 565);
            return 0;
        }

    }
}
