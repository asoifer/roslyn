// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class NamespaceSymbol : NamespaceOrTypeSymbol, INamespaceSymbolInternal
    {
        private ImmutableArray<NamedTypeSymbol> _lazyTypesMightContainExtensionMethods;

        private string _lazyQualifiedName;

        public IEnumerable<NamespaceSymbol> GetNamespaceMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 1625, 1769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 1707, 1758);

                return f_10128_1714_1731(this).OfType<NamespaceSymbol>();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 1625, 1769);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10128_1714_1731(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 1714, 1731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 1625, 1769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 1625, 1769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool IsGlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 2020, 2114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 2056, 2099);

                    return (object)f_10128_2071_2090() == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 2020, 2114);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10128_2071_2090()
                    {
                        var return_v = ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 2071, 2090);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 1958, 2125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 1958, 2125);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract NamespaceExtent Extent { get; }

        public NamespaceKind NamespaceKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 2769, 2801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 2775, 2799);

                    return this.Extent.Kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 2769, 2801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 2710, 2812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 2710, 2812);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CSharpCompilation ContainingCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 3010, 3106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 3016, 3104);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10128, 3023, 3070) || ((f_10128_3023_3041(this) == NamespaceKind.Compilation && DynAbs.Tracing.TraceSender.Conditional_F2(10128, 3073, 3096)) || DynAbs.Tracing.TraceSender.Conditional_F3(10128, 3099, 3103))) ? this.Extent.Compilation : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 3010, 3106);

                    Microsoft.CodeAnalysis.NamespaceKind
                    f_10128_3023_3041(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.NamespaceKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 3023, 3041);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 2939, 3117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 2939, 3117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ImmutableArray<NamespaceSymbol> ConstituentNamespaces
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 3597, 3683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 3633, 3668);

                    return f_10128_3640_3667(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 3597, 3683);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                    f_10128_3640_3667(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 3640, 3667);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 3504, 3694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 3504, 3694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 3784, 3847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 3820, 3832);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 3784, 3847);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 3706, 3858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 3706, 3858);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract override AssemblySymbol ContainingAssembly { get; }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 4102, 4349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 4138, 4163);

                    var
                    extent = f_10128_4151_4162(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 4181, 4302) || true) && (extent.Kind == NamespaceKind.Module)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 4181, 4302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 4262, 4283);

                        return extent.Module;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 4181, 4302);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 4322, 4334);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 4102, 4349);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                    f_10128_4151_4162(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 4151, 4162);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 4030, 4360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 4030, 4360);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 4525, 4604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 4561, 4589);

                    return SymbolKind.Namespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 4525, 4604);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 4462, 4615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 4462, 4615);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 4700, 4781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 4736, 4766);

                    return f_10128_4743_4765(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 4700, 4781);

                    bool
                    f_10128_4743_4765(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 4743, 4765);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 4627, 4792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 4627, 4792);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 4892, 5095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 5038, 5084);

                return f_10128_5045_5083<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 4892, 5095);

                TResult
                f_10128_5045_5083<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitNamespace(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 5045, 5083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 4892, 5095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 4892, 5095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 5107, 5228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 5188, 5217);

                f_10128_5188_5216(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 5107, 5228);

                int
                f_10128_5188_5216(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.VisitNamespace(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 5188, 5216);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 5107, 5228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 5107, 5228);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 5240, 5389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 5342, 5378);

                return f_10128_5349_5377<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 5240, 5389);

                TResult
                f_10128_5349_5377<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = this_param.VisitNamespace(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 5349, 5377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 5240, 5389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 5240, 5389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamespaceSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10128, 5461, 5509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 902, 914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 898, 916);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10128, 5461, 5509);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 5461, 5509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 5461, 5509);
            }
        }

        public sealed override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 5907, 5986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 5943, 5971);

                    return Accessibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 5907, 5986);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 5735, 5997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 5735, 5997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 6248, 6311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 6284, 6296);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 6248, 6311);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 6187, 6322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 6187, 6322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 6700, 6764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 6736, 6749);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 6700, 6764);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 6637, 6775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 6637, 6775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 7236, 7300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 7272, 7285);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 7236, 7300);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 7175, 7311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 7175, 7311);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 7684, 7704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 7690, 7702);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 7684, 7704);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 7591, 7715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 7591, 7715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol ImplicitType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 7978, 8288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 8014, 8075);

                    var
                    types = f_10128_8026_8074(this, TypeSymbol.ImplicitTypeName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 8093, 8187) || true) && (types.Length == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 8093, 8187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 8156, 8168);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 8093, 8187);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 8207, 8239);

                    f_10128_8207_8238(types.Length == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 8257, 8273);

                    return types[0];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 7978, 8288);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10128_8026_8074(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetTypeMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 8026, 8074);
                        return return_v;
                    }


                    int
                    f_10128_8207_8238(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 8207, 8238);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 7916, 8299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 7916, 8299);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamespaceSymbol LookupNestedNamespace(ImmutableArray<string> names)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 8693, 9764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 8794, 8823);

                NamespaceSymbol
                scope = this
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 8839, 9724);
                    foreach (string name in f_10128_8863_8868_I(names))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 8839, 9724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 8902, 8935);

                        NamespaceSymbol
                        nextScope = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 8955, 9559);
                            foreach (NamespaceOrTypeSymbol symbol in f_10128_8996_9018_I(f_10128_8996_9018(scope, name)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 8955, 9559);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9060, 9095);

                                var
                                ns = symbol as NamespaceSymbol
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9119, 9540) || true) && ((object)ns != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 9119, 9540);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9191, 9474) || true) && ((object)nextScope != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 9191, 9474);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9278, 9364);

                                        f_10128_9278_9363((object)nextScope == null, "Why did we run into an unmerged namespace?");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9394, 9411);

                                        nextScope = null;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10128, 9441, 9447);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 9191, 9474);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9502, 9517);

                                    nextScope = ns;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 9119, 9540);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 8955, 9559);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10128, 1, 605);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10128, 1, 605);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9579, 9597);

                        scope = nextScope;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9617, 9709) || true) && ((object)scope == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 9617, 9709);
                            DynAbs.Tracing.TraceSender.TraceBreak(10128, 9684, 9690);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 9617, 9709);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 8839, 9724);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10128, 1, 886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10128, 1, 886);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9740, 9753);

                return scope;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 8693, 9764);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10128_8996_9018(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 8996, 9018);
                    return return_v;
                }


                int
                f_10128_9278_9363(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 9278, 9363);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10128_8996_9018_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 8996, 9018);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10128_8863_8868_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 8863, 8868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 8693, 9764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 8693, 9764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamespaceSymbol GetNestedNamespace(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 9776, 10111);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9857, 10072);
                    foreach (var sym in f_10128_9877_9898_I(f_10128_9877_9898(this, name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 9857, 10072);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 9932, 10057) || true) && (f_10128_9936_9944(sym) == SymbolKind.Namespace)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 9932, 10057);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 10010, 10038);

                            return (NamespaceSymbol)sym;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 9932, 10057);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 9857, 10072);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10128, 1, 216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10128, 1, 216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 10088, 10100);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 9776, 10111);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10128_9877_9898(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 9877, 9898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10128_9936_9944(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 9936, 9944);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10128_9877_9898_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 9877, 9898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 9776, 10111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 9776, 10111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamespaceSymbol GetNestedNamespace(NameSyntax name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 10123, 11287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 10208, 11248);

                switch (f_10128_10216_10227(name))
                {

                    case SyntaxKind.GenericName: // DeclarationTreeBuilder.VisitNamespace uses the PlainName, even for generic names
                    case SyntaxKind.IdentifierName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 10208, 11248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 10444, 10522);

                        return f_10128_10451_10521(this, ((SimpleNameSyntax)name).Identifier.ValueText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 10208, 11248);

                    case SyntaxKind.QualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 10208, 11248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 10594, 10629);

                        var
                        qn = (QualifiedNameSyntax)name
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 10651, 10697);

                        var
                        leftNs = f_10128_10664_10696(this, f_10128_10688_10695(qn))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 10719, 10861) || true) && ((object)leftNs != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 10719, 10861);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 10795, 10838);

                            return f_10128_10802_10837(leftNs, f_10128_10828_10836(qn));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 10719, 10861);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10128, 10885, 10891);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 10208, 11248);

                    case SyntaxKind.AliasQualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 10208, 11248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 11154, 11233);

                        return f_10128_11161_11232(this, f_10128_11185_11210(name).Identifier.ValueText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 10208, 11248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 11264, 11276);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 10123, 11287);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10128_10216_10227(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 10216, 10227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10128_10451_10521(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetNestedNamespace(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 10451, 10521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10128_10688_10695(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 10688, 10695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10128_10664_10696(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name)
                {
                    var return_v = this_param.GetNestedNamespace(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 10664, 10696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10128_10828_10836(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 10828, 10836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10128_10802_10837(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                name)
                {
                    var return_v = this_param.GetNestedNamespace((Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 10802, 10837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10128_11185_11210(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.GetUnqualifiedName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 11185, 11210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10128_11161_11232(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetNestedNamespace(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 11161, 11232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 10123, 11287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 10123, 11287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<NamedTypeSymbol> TypesMightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 11397, 11916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 11433, 11509);

                    var
                    typesWithExtensionMethods = this._lazyTypesMightContainExtensionMethods
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 11527, 11848) || true) && (typesWithExtensionMethods.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 11527, 11848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 11608, 11735);

                        this._lazyTypesMightContainExtensionMethods = f_10128_11654_11684(this).WhereAsArray(t => t.MightContainExtensionMethods);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 11757, 11829);

                        typesWithExtensionMethods = this._lazyTypesMightContainExtensionMethods;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 11527, 11848);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 11868, 11901);

                    return typesWithExtensionMethods;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 11397, 11916);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10128_11654_11684(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeMembersUnordered();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 11654, 11684);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 11299, 11927);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 11299, 11927);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual void GetExtensionMethods(ArrayBuilder<MethodSymbol> methods, string nameOpt, int arity, LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 12402, 13184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 12554, 12593);

                var
                assembly = f_10128_12569_12592(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 12761, 12800);

                f_10128_12761_12799((object)assembly != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 12816, 12914) || true) && (f_10128_12820_12858_M(!assembly.MightContainExtensionMethods))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 12816, 12914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 12892, 12899);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 12816, 12914);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 12930, 13001);

                var
                typesWithExtensionMethods = f_10128_12962_13000(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 13017, 13173);
                    foreach (var type in f_10128_13038_13063_I(typesWithExtensionMethods))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10128, 13017, 13173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 13097, 13158);

                        f_10128_13097_13157(type, methods, nameOpt, arity, options);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10128, 13017, 13173);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10128, 1, 157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10128, 1, 157);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 12402, 13184);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10128_12569_12592(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 12569, 12592);
                    return return_v;
                }


                int
                f_10128_12761_12799(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 12761, 12799);
                    return 0;
                }


                bool
                f_10128_12820_12858_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 12820, 12858);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10128_12962_13000(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.TypesMightContainExtensionMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 12962, 13000);
                    return return_v;
                }


                int
                f_10128_13097_13157(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, string
                nameOpt, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    this_param.DoGetExtensionMethods(methods, nameOpt, arity, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 13097, 13157);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10128_13038_13063_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 13038, 13063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 12402, 13184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 12402, 13184);
            }
        }

        internal string QualifiedName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 13250, 13440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 13286, 13425);

                    return _lazyQualifiedName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10128, 13293, 13424) ?? (_lazyQualifiedName = f_10128_13358_13423(this, SymbolDisplayFormat.QualifiedNameOnlyFormat)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 13250, 13440);

                    string
                    f_10128_13358_13423(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 13358, 13423);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 13196, 13451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 13196, 13451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 13463, 13593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 13537, 13582);

                return f_10128_13544_13581(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 13463, 13593);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NamespaceSymbol
                f_10128_13544_13581(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NamespaceSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10128, 13544, 13581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 13463, 13593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 13463, 13593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool INamespaceSymbolInternal.IsGlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10128, 13653, 13678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10128, 13656, 13678);
                    return f_10128_13656_13678(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10128, 13653, 13678);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10128, 13653, 13678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10128, 13653, 13678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool
        f_10128_13656_13678(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.IsGlobalNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10128, 13656, 13678);
            return return_v;
        }

    }
}
