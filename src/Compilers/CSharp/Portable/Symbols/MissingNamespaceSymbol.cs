// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class MissingNamespaceSymbol : NamespaceSymbol
    {
        private readonly string _name;

        private readonly Symbol _containingSymbol;

        public MissingNamespaceSymbol(MissingModuleSymbol containingModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10125, 903, 1141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 833, 838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 873, 890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 995, 1042);

                f_10125_995_1041((object)containingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 1058, 1095);

                _containingSymbol = containingModule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 1109, 1130);

                _name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10125, 903, 1141);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 903, 1141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 903, 1141);
            }
        }

        public MissingNamespaceSymbol(NamespaceSymbol containingNamespace, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10125, 1153, 1442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 833, 838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 873, 890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 1257, 1307);

                f_10125_1257_1306((object)containingNamespace != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 1321, 1348);

                f_10125_1321_1347(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 1364, 1404);

                _containingSymbol = containingNamespace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 1418, 1431);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10125, 1153, 1442);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 1153, 1442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 1153, 1442);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 1506, 1570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 1542, 1555);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 1506, 1570);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 1454, 1581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 1454, 1581);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 1657, 1733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 1693, 1718);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 1657, 1733);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 1593, 1744);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 1593, 1744);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 1830, 1925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 1866, 1910);

                    return f_10125_1873_1909(_containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 1830, 1925);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10125_1873_1909(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10125, 1873, 1909);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 1756, 1936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 1756, 1936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamespaceExtent Extent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 2013, 2306);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 2049, 2220) || true) && (f_10125_2053_2075(_containingSymbol) == SymbolKind.NetModule)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10125, 2049, 2220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 2141, 2201);

                        return f_10125_2148_2200((ModuleSymbol)_containingSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10125, 2049, 2220);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 2240, 2291);

                    return f_10125_2247_2290(((NamespaceSymbol)_containingSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 2013, 2306);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10125_2053_2075(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10125, 2053, 2075);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                    f_10125_2148_2200(Microsoft.CodeAnalysis.CSharp.Symbol
                    module)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 2148, 2200);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                    f_10125_2247_2290(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10125, 2247, 2290);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 1948, 2317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 1948, 2317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 2329, 2472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 2387, 2461);

                return f_10125_2394_2460(f_10125_2407_2438(_containingSymbol), f_10125_2440_2459(_name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 2329, 2472);

                int
                f_10125_2407_2438(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 2407, 2438);
                    return return_v;
                }


                int
                f_10125_2440_2459(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 2440, 2459);
                    return return_v;
                }


                int
                f_10125_2394_2460(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 2394, 2460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 2329, 2472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 2329, 2472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 2484, 2896);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 2577, 2668) || true) && (f_10125_2581_2607(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10125, 2577, 2668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 2641, 2653);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10125, 2577, 2668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 2684, 2745);

                MissingNamespaceSymbol
                other = obj as MissingNamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 2761, 2885);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10125, 2768, 2818) && f_10125_2793_2818(_name, other._name)) && (DynAbs.Tracing.TraceSender.Expression_True(10125, 2768, 2884) && f_10125_2822_2884(_containingSymbol, other._containingSymbol, compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 2484, 2896);

                bool
                f_10125_2581_2607(Microsoft.CodeAnalysis.CSharp.Symbols.MissingNamespaceSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 2581, 2607);
                    return return_v;
                }


                bool
                f_10125_2793_2818(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 2793, 2818);
                    return return_v;
                }


                bool
                f_10125_2822_2884(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 2822, 2884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 2484, 2896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 2484, 2896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 2983, 3072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 3019, 3057);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 2983, 3072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 2908, 3083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 2908, 3083);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 3193, 3289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 3229, 3274);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 3193, 3289);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 3095, 3300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 3095, 3300);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 3312, 3457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 3401, 3446);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 3312, 3457);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 3312, 3457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 3312, 3457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 3469, 3625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 3569, 3614);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 3469, 3625);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 3469, 3625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 3469, 3625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 3637, 3804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 3748, 3793);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 3637, 3804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 3637, 3804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 3637, 3804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 3816, 3939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 3892, 3928);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 3816, 3939);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 3816, 3939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 3816, 3939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10125, 3951, 4085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10125, 4038, 4074);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10125, 3951, 4085);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10125, 3951, 4085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 3951, 4085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MissingNamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10125, 737, 4092);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10125, 737, 4092);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10125, 737, 4092);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10125, 737, 4092);

        int
        f_10125_995_1041(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 995, 1041);
            return 0;
        }


        int
        f_10125_1257_1306(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 1257, 1306);
            return 0;
        }


        int
        f_10125_1321_1347(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10125, 1321, 1347);
            return 0;
        }

    }
}
