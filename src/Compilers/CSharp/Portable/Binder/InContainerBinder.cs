// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class InContainerBinder : Binder
    {
        private readonly NamespaceOrTypeSymbol _container;

        private readonly Func<ConsList<TypeSymbol>, Imports> _computeImports;

        private Imports _lazyImports;

        private ImportChain _lazyImportChain;

        private QuickAttributeChecker _lazyQuickAttributeChecker;

        private readonly SyntaxList<UsingDirectiveSyntax> _usingsSyntax;

        internal InContainerBinder(NamespaceOrTypeSymbol container, Binder next, CSharpSyntaxNode declarationSyntax, bool inUsing)
        : base(f_10346_1542_1546_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10346, 1399, 2435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 858, 868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 932, 947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 974, 986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1017, 1033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1074, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1572, 1612);

                f_10346_1572_1611((object)container != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1626, 1666);

                f_10346_1626_1665(declarationSyntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1682, 1705);

                _container = container;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1719, 1832);

                _computeImports = basesBeingResolved => Imports.FromSyntax(declarationSyntax, this, basesBeingResolved, inUsing);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1848, 2424) || true) && (!inUsing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 1848, 2424);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1894, 2409) || true) && (f_10346_1898_1922(declarationSyntax) == SyntaxKind.CompilationUnit)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 1894, 2409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1994, 2057);

                        var
                        compilationUnit = (CompilationUnitSyntax)declarationSyntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 2079, 2118);

                        _usingsSyntax = f_10346_2095_2117(compilationUnit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 1894, 2409);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 1894, 2409);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 2160, 2409) || true) && (f_10346_2164_2188(declarationSyntax) == SyntaxKind.NamespaceDeclaration)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 2160, 2409);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 2265, 2331);

                            var
                            namespaceDecl = (NamespaceDeclarationSyntax)declarationSyntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 2353, 2390);

                            _usingsSyntax = f_10346_2369_2389(namespaceDecl);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 2160, 2409);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 1894, 2409);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 1848, 2424);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10346, 1399, 2435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 1399, 2435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 1399, 2435);
            }
        }

        internal InContainerBinder(NamespaceOrTypeSymbol container, Binder next, Imports imports = null)
        : base(f_10346_2661_2665_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10346, 2544, 2854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 858, 868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 932, 947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 974, 986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1017, 1033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1074, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 2691, 2750);

                f_10346_2691_2749((object)container != null || (DynAbs.Tracing.TraceSender.Expression_False(10346, 2704, 2748) || imports != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 2766, 2789);

                _container = container;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 2803, 2843);

                _lazyImports = imports ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Imports?>(10346, 2818, 2842) ?? Imports.Empty);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10346, 2544, 2854);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 2544, 2854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 2544, 2854);
            }
        }

        internal InContainerBinder(Binder next, Func<ConsList<TypeSymbol>, Imports> computeImports)
        : base(f_10346_3095_3099_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10346, 2983, 3254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 858, 868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 932, 947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 974, 986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1017, 1033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 1074, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 3125, 3162);

                f_10346_3125_3161(computeImports != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 3178, 3196);

                _container = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 3210, 3243);

                _computeImports = computeImports;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10346, 2983, 3254);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 2983, 3254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 2983, 3254);
            }
        }

        internal NamespaceOrTypeSymbol Container
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 3331, 3400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 3367, 3385);

                    return _container;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 3331, 3400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 3266, 3411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 3266, 3411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Imports GetImports(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 3423, 3863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 3525, 3638);

                f_10346_3525_3637(_lazyImports != null || (DynAbs.Tracing.TraceSender.Expression_False(10346, 3538, 3585) || _computeImports != null), "Have neither imports nor a way to compute them.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 3654, 3816) || true) && (_lazyImports == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 3654, 3816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 3712, 3801);

                    f_10346_3712_3800(ref _lazyImports, f_10346_3758_3793(this, basesBeingResolved), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 3654, 3816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 3832, 3852);

                return _lazyImports;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 3423, 3863);

                int
                f_10346_3525_3637(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 3525, 3637);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10346_3758_3793(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                arg)
                {
                    var return_v = this_param._computeImports(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 3758, 3793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports?
                f_10346_3712_3800(ref Microsoft.CodeAnalysis.CSharp.Imports?
                location1, Microsoft.CodeAnalysis.CSharp.Imports
                value, Microsoft.CodeAnalysis.CSharp.Imports?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 3712, 3800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 3423, 3863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 3423, 3863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override AssemblySymbol GetForwardedToAssemblyInUsingNamespaces(string name, ref NamespaceOrTypeSymbol qualifierOpt, DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 4889, 5699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5086, 5137);

                var
                imports = f_10346_5100_5136(this, basesBeingResolved: null)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5151, 5573);
                    foreach (var typeOrNamespace in f_10346_5183_5197_I(imports.Usings))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 5151, 5573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5231, 5291);

                        var
                        fullName = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (typeOrNamespace.NamespaceOrType).ToString(), 10346, 5246, 5277) + "." + name
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5309, 5378);

                        var
                        result = f_10346_5322_5377(this, fullName, diagnostics, location)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5396, 5558) || true) && (result != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 5396, 5558);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5456, 5503);

                            qualifierOpt = typeOrNamespace.NamespaceOrType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5525, 5539);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 5396, 5558);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 5151, 5573);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10346, 1, 423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10346, 1, 423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5589, 5688);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetForwardedToAssemblyInUsingNamespaces(name, ref qualifierOpt, diagnostics, location), 10346, 5596, 5687);
                var temp = base.GetForwardedToAssemblyInUsingNamespaces(name, ref qualifierOpt, diagnostics, location);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 5596, 5687);
                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 4889, 5699);

                Microsoft.CodeAnalysis.CSharp.Imports
                f_10346_5100_5136(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetImports(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 5100, 5136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10346_5322_5377(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, string
                fullName, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.GetForwardedToAssembly(fullName, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 5322, 5377);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10346_5183_5197_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 5183, 5197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 4889, 5699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 4889, 5699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImportChain ImportChain
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 5777, 6410);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5813, 6292) || true) && (_lazyImportChain == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 5813, 6292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5883, 5931);

                        ImportChain
                        importChain = f_10346_5909_5930(f_10346_5909_5918(this))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 5953, 6180) || true) && ((object)_container == null || (DynAbs.Tracing.TraceSender.Expression_False(10346, 5957, 6026) || f_10346_5987_6002(_container) == SymbolKind.Namespace))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 5953, 6180);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 6076, 6157);

                            importChain = f_10346_6090_6156(f_10346_6106_6142(this, basesBeingResolved: null), importChain);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 5953, 6180);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 6204, 6273);

                        f_10346_6204_6272(ref _lazyImportChain, importChain, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 5813, 6292);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 6312, 6351);

                    f_10346_6312_6350(_lazyImportChain != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 6371, 6395);

                    return _lazyImportChain;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 5777, 6410);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10346_5909_5918(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 5909, 5918);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ImportChain?
                    f_10346_5909_5930(Microsoft.CodeAnalysis.CSharp.Binder?
                    this_param)
                    {
                        var return_v = this_param.ImportChain;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 5909, 5930);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10346_5987_6002(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 5987, 6002);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Imports
                    f_10346_6106_6142(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    basesBeingResolved)
                    {
                        var return_v = this_param.GetImports(basesBeingResolved: basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 6106, 6142);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ImportChain
                    f_10346_6090_6156(Microsoft.CodeAnalysis.CSharp.Imports
                    imports, Microsoft.CodeAnalysis.CSharp.ImportChain?
                    parentOpt)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.ImportChain(imports, parentOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 6090, 6156);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ImportChain?
                    f_10346_6204_6272(ref Microsoft.CodeAnalysis.CSharp.ImportChain?
                    location1, Microsoft.CodeAnalysis.CSharp.ImportChain?
                    value, Microsoft.CodeAnalysis.CSharp.ImportChain?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 6204, 6272);
                        return return_v;
                    }


                    int
                    f_10346_6312_6350(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 6312, 6350);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 5711, 6421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 5711, 6421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override QuickAttributeChecker QuickAttributeChecker
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 6728, 7272);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 6764, 7203) || true) && (_lazyQuickAttributeChecker == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 6764, 7203);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 6844, 6907);

                        QuickAttributeChecker
                        result = f_10346_6875_6906(f_10346_6875_6884(this))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 6931, 7124) || true) && ((object)_container == null || (DynAbs.Tracing.TraceSender.Expression_False(10346, 6935, 7004) || f_10346_6965_6980(_container) == SymbolKind.Namespace))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 6931, 7124);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 7054, 7101);

                            result = f_10346_7063_7100(result, _usingsSyntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 6931, 7124);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 7148, 7184);

                        _lazyQuickAttributeChecker = result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 6764, 7203);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 7223, 7257);

                    return _lazyQuickAttributeChecker;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 6728, 7272);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10346_6875_6884(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 6875, 6884);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                    f_10346_6875_6906(Microsoft.CodeAnalysis.CSharp.Binder?
                    this_param)
                    {
                        var return_v = this_param.QuickAttributeChecker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 6875, 6906);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10346_6965_6980(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 6965, 6980);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                    f_10346_7063_7100(Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                    this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                    usingsSyntax)
                    {
                        var return_v = this_param.AddAliasesIfAny(usingsSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 7063, 7100);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 6642, 7283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 6642, 7283);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbol ContainingMemberOrLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 7369, 7588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 7405, 7454);

                    var
                    merged = _container as MergedNamespaceSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 7472, 7573);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10346, 7479, 7503) || ((((object)merged != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10346, 7506, 7559)) || DynAbs.Tracing.TraceSender.Conditional_F3(10346, 7562, 7572))) ? f_10346_7506_7559(merged, f_10346_7542_7558(this)) : _container;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 7369, 7588);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10346_7542_7558(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 7542, 7558);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10346_7506_7559(Microsoft.CodeAnalysis.CSharp.Symbols.MergedNamespaceSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = this_param.GetConstituentForCompilation(compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 7506, 7559);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 7295, 7599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 7295, 7599);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsSubmissionClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 7666, 7775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 7672, 7773);

                    return (f_10346_7680_7696_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_container, 10346, 7680, 7696)?.Kind) == SymbolKind.NamedType) && (DynAbs.Tracing.TraceSender.Expression_True(10346, 7679, 7772) && f_10346_7725_7772(((NamedTypeSymbol)_container)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 7666, 7775);

                    Microsoft.CodeAnalysis.SymbolKind?
                    f_10346_7680_7696_M(Microsoft.CodeAnalysis.SymbolKind?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 7680, 7696);
                        return return_v;
                    }


                    bool
                    f_10346_7725_7772(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSubmissionClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 7725, 7772);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 7611, 7786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 7611, 7786);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsScriptClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 7849, 7954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 7855, 7952);

                    return (f_10346_7863_7879_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_container, 10346, 7863, 7879)?.Kind) == SymbolKind.NamedType) && (DynAbs.Tracing.TraceSender.Expression_True(10346, 7862, 7951) && f_10346_7908_7951(((NamedTypeSymbol)_container)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 7849, 7954);

                    Microsoft.CodeAnalysis.SymbolKind?
                    f_10346_7863_7879_M(Microsoft.CodeAnalysis.SymbolKind?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 7863, 7879);
                        return return_v;
                    }


                    bool
                    f_10346_7908_7951(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsScriptClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 7908, 7951);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 7798, 7965);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 7798, 7965);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsAccessibleHelper(Symbol symbol, TypeSymbol accessThroughType, out bool failedThroughTypeCheck, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 7977, 8737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 8210, 8251);

                var
                type = _container as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 8265, 8726) || true) && ((object)type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 8265, 8726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 8323, 8450);

                    return f_10346_8330_8449(this, symbol, type, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 8265, 8726);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 8265, 8726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 8516, 8646);

                    return f_10346_8523_8645(f_10346_8523_8527(), symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 8265, 8726);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 7977, 8737);

                bool
                f_10346_8330_8449(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsSymbolAccessibleConditional(symbol, within, throughTypeOpt, out failedThroughTypeCheck, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 8330, 8449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10346_8523_8527()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 8523, 8527);
                    return return_v;
                }


                bool
                f_10346_8523_8645(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.IsAccessibleHelper(symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 8523, 8645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 7977, 8737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 7977, 8737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool SupportsExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 8821, 8841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 8827, 8839);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 8821, 8841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 8749, 8852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 8749, 8852);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void GetCandidateExtensionMethods(
                    bool searchUsingsNotNamespace,
                    ArrayBuilder<MethodSymbol> methods,
                    string name,
                    int arity,
                    LookupOptions options,
                    Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 8864, 9884);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9156, 9873) || true) && (searchUsingsNotNamespace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 9156, 9873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9218, 9338);

                    f_10346_9218_9337(f_10346_9218_9259(this, basesBeingResolved: null), methods, name, arity, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 9156, 9873);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 9156, 9873);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9372, 9873) || true) && (f_10346_9376_9392_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_container, 10346, 9376, 9392)?.Kind) == SymbolKind.Namespace)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 9372, 9873);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9450, 9531);

                        f_10346_9450_9530(((NamespaceSymbol)_container), methods, name, arity, options);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 9372, 9873);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 9372, 9873);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9565, 9873) || true) && (f_10346_9569_9586())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 9565, 9873);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9629, 9658);
                                for (var
                submission = f_10346_9642_9658(this)
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9620, 9858) || true) && (submission != null)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9680, 9722)
                , submission = f_10346_9693_9722(submission), DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 9620, 9858))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 9620, 9858);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9764, 9839);

                                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10346_9764_9786(submission), 10346, 9764, 9838).GetExtensionMethods(methods, name, arity, options), 10346, 9787, 9838);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10346, 1, 239);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10346, 1, 239);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 9565, 9873);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 9372, 9873);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 9156, 9873);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 8864, 9884);

                Microsoft.CodeAnalysis.CSharp.Imports
                f_10346_9218_9259(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetImports(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 9218, 9259);
                    return return_v;
                }


                int
                f_10346_9218_9337(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.LookupExtensionMethodsInUsings(methods, name, arity, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 9218, 9337);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10346_9376_9392_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 9376, 9392);
                    return return_v;
                }


                int
                f_10346_9450_9530(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, string
                nameOpt, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    this_param.GetExtensionMethods(methods, nameOpt, arity, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 9450, 9530);
                    return 0;
                }


                bool
                f_10346_9569_9586()
                {
                    var return_v = IsSubmissionClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 9569, 9586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10346_9642_9658(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 9642, 9658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                f_10346_9693_9722(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.PreviousSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 9693, 9722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10346_9764_9786(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 9764, 9786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 8864, 9884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 8864, 9884);
            }
        }

        internal override TypeWithAnnotations GetIteratorElementType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 9896, 10552);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 9983, 10541) || true) && (f_10346_9987_10000())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 9983, 10541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 10241, 10335);

                    return TypeWithAnnotations.Create(f_10346_10275_10333(f_10346_10275_10291(this), SpecialType.System_Object));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 9983, 10541);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 9983, 10541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 10489, 10526);

                    return f_10346_10496_10525(f_10346_10496_10500());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 9983, 10541);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 9896, 10552);

                bool
                f_10346_9987_10000()
                {
                    var return_v = IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 9987, 10000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10346_10275_10291(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 10275, 10291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10346_10275_10333(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 10275, 10333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10346_10496_10500()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 10496, 10500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10346_10496_10525(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param)
                {
                    var return_v = this_param.GetIteratorElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 10496, 10525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 9896, 10552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 9896, 10552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void LookupSymbolsInSingleBinder(
                    LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 10564, 12467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 10848, 10877);

                f_10346_10848_10876(f_10346_10861_10875(result));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 10893, 11127) || true) && (f_10346_10897_10914())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 10893, 11127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 10948, 11087);

                    f_10346_10948_11086(this, result, _container, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 11105, 11112);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 10893, 11127);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 11143, 11188);

                var
                imports = f_10346_11157_11187(this, basesBeingResolved)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 11258, 12246) || true) && ((options & LookupOptions.NamespaceAliasesOnly) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10346, 11262, 11335) && _container != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 11258, 12246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 11369, 11508);

                    f_10346_11369_11507(this, result, _container, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 11528, 12231) || true) && (f_10346_11532_11552(result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 11528, 12231);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 11665, 12181) || true) && (arity == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10346, 11669, 11747) && f_10346_11683_11747(imports, name, f_10346_11710_11746(originalBinder))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 11665, 12181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 11797, 11902);

                            CSDiagnosticInfo
                            diagInfo = f_10346_11825_11901(ErrorCode.ERR_ConflictAliasAndMember, name, _container)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 11928, 12038);

                            var
                            error = f_10346_11940_12037((NamespaceOrTypeSymbol)null, name, arity, diagInfo, unreported: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 12064, 12105);

                            f_10346_12064_12104(result, f_10346_12079_12103(error));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 11665, 12181);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 12205, 12212);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 11528, 12231);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 11258, 12246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 12335, 12456);

                f_10346_12335_12455(
                            // next try using aliases or symbols in imported namespaces
                            imports, originalBinder, result, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 10564, 12467);

                bool
                f_10346_10861_10875(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 10861, 10875);
                    return return_v;
                }


                int
                f_10346_10848_10876(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 10848, 10876);
                    return 0;
                }


                bool
                f_10346_10897_10914()
                {
                    var return_v = IsSubmissionClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 10897, 10914);
                    return return_v;
                }


                int
                f_10346_10948_11086(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                nsOrType, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInternal(result, nsOrType, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 10948, 11086);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10346_11157_11187(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetImports(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 11157, 11187);
                    return return_v;
                }


                int
                f_10346_11369_11507(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                nsOrType, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInternal(result, nsOrType, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 11369, 11507);
                    return 0;
                }


                bool
                f_10346_11532_11552(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 11532, 11552);
                    return return_v;
                }


                bool
                f_10346_11710_11746(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsSemanticModelBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 11710, 11746);
                    return return_v;
                }


                bool
                f_10346_11683_11747(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, string
                name, bool
                callerIsSemanticModel)
                {
                    var return_v = this_param.IsUsingAlias(name, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 11683, 11747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10346_11825_11901(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 11825, 11901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10346_11940_12037(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containingSymbol, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo, bool
                unreported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, name, arity, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo, unreported: unreported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 11940, 12037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10346_12079_12103(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                symbol)
                {
                    var return_v = LookupResult.Good((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 12079, 12103);
                    return return_v;
                }


                int
                f_10346_12064_12104(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 12064, 12104);
                    return 0;
                }


                int
                f_10346_12335_12455(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupSymbol(originalBinder, result, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 12335, 12455);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 10564, 12467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 10564, 12467);
            }
        }

        protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 12479, 13240);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 12634, 12782) || true) && (_container != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 12634, 12782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 12690, 12767);

                    f_10346_12690_12766(this, result, _container, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 12634, 12782);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 12980, 13229) || true) && (f_10346_12984_13002_M(!IsSubmissionClass) && (DynAbs.Tracing.TraceSender.Expression_True(10346, 12984, 13049) && ((options & LookupOptions.LabelsOnly) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10346, 12980, 13229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 13083, 13134);

                    var
                    imports = f_10346_13097_13133(this, basesBeingResolved: null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 13152, 13214);

                    f_10346_13152_13213(imports, result, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10346, 12980, 13229);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 12479, 13240);

                int
                f_10346_12690_12766(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                nsOrType, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.AddMemberLookupSymbolsInfo(result, nsOrType, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 12690, 12766);
                    return 0;
                }


                bool
                f_10346_12984_13002_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 12984, 13002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10346_13097_13133(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetImports(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 13097, 13133);
                    return return_v;
                }


                int
                f_10346_13152_13213(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.AddLookupSymbolsInfo(result, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 13152, 13213);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 12479, 13240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 12479, 13240);
            }
        }

        protected override SourceLocalSymbol LookupLocal(SyntaxToken nameToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 13252, 13371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 13348, 13360);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 13252, 13371);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 13252, 13371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 13252, 13371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalFunctionSymbol LookupLocalFunction(SyntaxToken nameToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 13383, 13512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 13489, 13501);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 13383, 13512);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 13383, 13512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 13383, 13512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override uint LocalScopeDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10346, 13563, 13586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10346, 13566, 13586);
                    return Binder.ExternalScope; DynAbs.Tracing.TraceSender.TraceExitMethod(10346, 13563, 13586);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10346, 13563, 13586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 13563, 13586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static InContainerBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10346, 754, 13594);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10346, 754, 13594);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10346, 754, 13594);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10346, 754, 13594);

        int
        f_10346_1572_1611(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 1572, 1611);
            return 0;
        }


        int
        f_10346_1626_1665(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 1626, 1665);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10346_1898_1922(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.Kind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 1898, 1922);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
        f_10346_2095_2117(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
        this_param)
        {
            var return_v = this_param.Usings;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 2095, 2117);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10346_2164_2188(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.Kind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 2164, 2188);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
        f_10346_2369_2389(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Usings;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10346, 2369, 2389);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10346_1542_1546_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10346, 1399, 2435);
            return return_v;
        }


        int
        f_10346_2691_2749(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 2691, 2749);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10346_2661_2665_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10346, 2544, 2854);
            return return_v;
        }


        int
        f_10346_3125_3161(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10346, 3125, 3161);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10346_3095_3099_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10346, 2983, 3254);
            return return_v;
        }

    }
}
