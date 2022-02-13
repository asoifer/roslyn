// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Roslyn.Utilities;
using System.Diagnostics;
using System;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedNamespaceSymbol : NamespaceSymbol
    {
        private readonly string _name;

        private readonly NamespaceSymbol _containingSymbol;

        public SynthesizedNamespaceSymbol(NamespaceSymbol containingNamespace, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10169, 820, 1109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 741, 746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 790, 807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 928, 972);

                f_10169_928_971(containingNamespace is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 986, 1015);

                f_10169_986_1014(name is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1031, 1071);

                _containingSymbol = containingNamespace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1085, 1098);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10169, 820, 1109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 820, 1109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 820, 1109);
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 1168, 1237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1171, 1237);
                return f_10169_1171_1237(f_10169_1184_1215(_containingSymbol), f_10169_1217_1236(_name)); DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 1168, 1237);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 1168, 1237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 1168, 1237);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10169_1184_1215(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10169, 1184, 1215);
                return return_v;
            }


            int
            f_10169_1217_1236(string
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10169, 1217, 1236);
                return return_v;
            }


            int
            f_10169_1171_1237(int
            newKey, int
            currentKey)
            {
                var return_v = Hash.Combine(newKey, currentKey);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10169, 1171, 1237);
                return return_v;
            }

        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 1332, 1404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1335, 1404);
                return obj is SynthesizedNamespaceSymbol other && (DynAbs.Tracing.TraceSender.Expression_True(10169, 1335, 1404) && f_10169_1378_1404(this, other, compareKind)); DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 1332, 1404);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 1332, 1404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 1332, 1404);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10169_1378_1404(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedNamespaceSymbol
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedNamespaceSymbol
            other, Microsoft.CodeAnalysis.TypeCompareKind
            compareKind)
            {
                var return_v = this_param.Equals(other, compareKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10169, 1378, 1404);
                return return_v;
            }

        }

        public bool Equals(SynthesizedNamespaceSymbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 1417, 1748);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1523, 1616) || true) && (f_10169_1527_1555(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10169, 1523, 1616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1589, 1601);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10169, 1523, 1616);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1632, 1737);

                return other is object && (DynAbs.Tracing.TraceSender.Expression_True(10169, 1639, 1683) && f_10169_1658_1683(_name, other._name)) && (DynAbs.Tracing.TraceSender.Expression_True(10169, 1639, 1736) && f_10169_1687_1736(_containingSymbol, other._containingSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 1417, 1748);

                bool
                f_10169_1527_1555(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedNamespaceSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedNamespaceSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10169, 1527, 1555);
                    return return_v;
                }


                bool
                f_10169_1658_1683(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10169, 1658, 1683);
                    return return_v;
                }


                bool
                f_10169_1687_1736(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10169, 1687, 1736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 1417, 1748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 1417, 1748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamespaceExtent Extent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 1814, 1841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1817, 1841);
                    return f_10169_1817_1841(_containingSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 1814, 1841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 1814, 1841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 1814, 1841);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 1895, 1903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1898, 1903);
                    return _name; DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 1895, 1903);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 1895, 1903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 1895, 1903);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 1969, 1989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 1972, 1989);
                    return _containingSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 1969, 1989);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 1969, 1989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 1969, 1989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 2065, 2104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 2068, 2104);
                    return f_10169_2068_2104(_containingSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 2065, 2104);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 2065, 2104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 2065, 2104);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 2181, 2214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 2184, 2214);
                    return ImmutableArray<Location>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 2181, 2214);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 2181, 2214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 2181, 2214);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 2314, 2354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 2317, 2354);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 2314, 2354);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 2314, 2354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 2314, 2354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 2445, 2485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 2448, 2485);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 2445, 2485);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 2445, 2485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 2445, 2485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 2587, 2627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 2590, 2627);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 2587, 2627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 2587, 2627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 2587, 2627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 2740, 2780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 2743, 2780);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 2740, 2780);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 2740, 2780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 2740, 2780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 2858, 2889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 2861, 2889);
                return ImmutableArray<Symbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 2858, 2889);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 2858, 2889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 2858, 2889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10169, 2978, 3009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10169, 2981, 3009);
                return ImmutableArray<Symbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10169, 2978, 3009);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10169, 2978, 3009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 2978, 3009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedNamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10169, 634, 3017);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10169, 634, 3017);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10169, 634, 3017);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10169, 634, 3017);

        int
        f_10169_928_971(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10169, 928, 971);
            return 0;
        }


        int
        f_10169_986_1014(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10169, 986, 1014);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
        f_10169_1817_1841(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.Extent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10169, 1817, 1841);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10169_2068_2104(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10169, 2068, 2104);
            return return_v;
        }

    }
}
