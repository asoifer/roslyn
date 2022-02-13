// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal abstract partial class Symbol : ISymbolInternal, IFormattable
    {
        private ISymbol _lazyISymbol;

        internal virtual bool RequiresCompletion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 1766, 1787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 1772, 1785);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 1766, 1787);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 1701, 1798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 1701, 1798);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 1810, 2063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 2013, 2052);

                f_10040_2013_2051(f_10040_2026_2050_M(!this.RequiresCompletion));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 1810, 2063);

                bool
                f_10040_2026_2050_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 2026, 2050);
                    return return_v;
                }


                int
                f_10040_2013_2051(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 2013, 2051);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 1810, 2063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 1810, 2063);
            }
        }

        internal virtual bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 2075, 2308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 2232, 2271);

                f_10040_2232_2270(f_10040_2245_2269_M(!this.RequiresCompletion));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 2285, 2297);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 2075, 2308);

                bool
                f_10040_2245_2269_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 2245, 2269);
                    return return_v;
                }


                int
                f_10040_2232_2270(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 2232, 2270);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 2075, 2308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 2075, 2308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 2546, 2617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 2582, 2602);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 2546, 2617);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 2495, 2628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 2495, 2628);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual string MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 3271, 3339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 3307, 3324);

                    return f_10040_3314_3323(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 3271, 3339);

                    string
                    f_10040_3314_3323(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 3314, 3323);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 3212, 3350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 3212, 3350);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract SymbolKind Kind { get; }

        public abstract Symbol ContainingSymbol { get; }

        public virtual NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 3879, 4932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 3915, 3956);

                    Symbol
                    container = f_10040_3934_3955(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 3976, 4039);

                    NamedTypeSymbol
                    containerAsType = container as NamedTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 4302, 4704) || true) && ((object)containerAsType == (object)container)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 4302, 4704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 4662, 4685);

                        return containerAsType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 4302, 4704);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 4885, 4917);

                    return f_10040_4892_4916(container);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 3879, 4932);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10040_3934_3955(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 3934, 3955);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10040_4892_4916(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 4892, 4916);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 3809, 4943);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 3809, 4943);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual NamespaceSymbol ContainingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 5238, 5656);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 5283, 5316);
                        for (var
        container = f_10040_5295_5316(this)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 5274, 5609) || true) && ((object)container != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 5345, 5383)
        , container = f_10040_5357_5383(container), DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 5274, 5609))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 5274, 5609);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 5425, 5463);

                            var
                            ns = container as NamespaceSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 5485, 5590) || true) && ((object)ns != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 5485, 5590);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 5557, 5567);

                                return ns;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 5485, 5590);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 336);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 336);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 5629, 5641);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 5238, 5656);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10040_5295_5316(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 5295, 5316);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10040_5357_5383(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 5357, 5383);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 5163, 5667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 5163, 5667);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 5971, 6224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 6082, 6120);

                    var
                    container = f_10040_6098_6119(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 6138, 6209);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10040, 6145, 6170) || (((object)container != null && DynAbs.Tracing.TraceSender.Conditional_F2(10040, 6173, 6201)) || DynAbs.Tracing.TraceSender.Conditional_F3(10040, 6204, 6208))) ? f_10040_6173_6201(container) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 5971, 6224);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10040_6098_6119(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 6098, 6119);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10040_6173_6201(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 6173, 6201);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 5898, 6235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 5898, 6235);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual CSharpCompilation DeclaringCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 7016, 7836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7052, 7623);

                    switch (f_10040_7060_7069(this))
                    {

                        case SymbolKind.ErrorType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 7052, 7623);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7163, 7175);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 7052, 7623);

                        case SymbolKind.Assembly:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 7052, 7623);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7248, 7353);

                            f_10040_7248_7352(!(this is SourceAssemblySymbol), "SourceAssemblySymbol must override DeclaringCompilation");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7379, 7391);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 7052, 7623);

                        case SymbolKind.NetModule:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 7052, 7623);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7465, 7566);

                            f_10040_7465_7565(!(this is SourceModuleSymbol), "SourceModuleSymbol must override DeclaringCompilation");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7592, 7604);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 7052, 7623);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7643, 7712);

                    var
                    sourceModuleSymbol = f_10040_7668_7689(this) as SourceModuleSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7730, 7821);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10040, 7737, 7771) || (((object)sourceModuleSymbol == null && DynAbs.Tracing.TraceSender.Conditional_F2(10040, 7774, 7778)) || DynAbs.Tracing.TraceSender.Conditional_F3(10040, 7781, 7820))) ? null : f_10040_7781_7820(sourceModuleSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 7016, 7836);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10040_7060_7069(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 7060, 7069);
                        return return_v;
                    }


                    int
                    f_10040_7248_7352(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 7248, 7352);
                        return 0;
                    }


                    int
                    f_10040_7465_7565(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 7465, 7565);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10040_7668_7689(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 7668, 7689);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10040_7781_7820(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 7781, 7820);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 6936, 7847);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 6936, 7847);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Compilation ISymbolInternal.DeclaringCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 7921, 7944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7924, 7944);
                    return f_10040_7924_7944(); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 7921, 7944);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 7921, 7944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 7921, 7944);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string ISymbolInternal.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 7985, 7997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 7988, 7997);
                    return f_10040_7988_7997(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 7985, 7997);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 7985, 7997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 7985, 7997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string ISymbolInternal.MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 8046, 8066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 8049, 8066);
                    return f_10040_8049_8066(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 8046, 8066);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 8046, 8066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 8046, 8066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ISymbolInternal ISymbolInternal.ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 8128, 8152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 8131, 8152);
                    return f_10040_8131_8152(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 8128, 8152);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 8128, 8152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 8128, 8152);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IModuleSymbolInternal ISymbolInternal.ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 8220, 8244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 8223, 8244);
                    return f_10040_8223_8244(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 8220, 8244);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 8220, 8244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 8220, 8244);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IAssemblySymbolInternal ISymbolInternal.ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 8316, 8342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 8319, 8342);
                    return f_10040_8319_8342(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 8316, 8342);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 8316, 8342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 8316, 8342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Location> ISymbolInternal.Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 8406, 8423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 8409, 8423);
                    return f_10040_8409_8423(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 8406, 8423);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 8406, 8423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 8406, 8423);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceSymbolInternal ISymbolInternal.ContainingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 8497, 8524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 8500, 8524);
                    return f_10040_8500_8524(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 8497, 8524);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 8497, 8524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 8497, 8524);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbolInternal.IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 8579, 8607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 8582, 8607);
                    return f_10040_8582_8607(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 8579, 8607);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 8579, 8607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 8579, 8607);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbolInternal ISymbolInternal.ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 8700, 8778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 8736, 8763);

                    return f_10040_8743_8762(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 8700, 8778);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10040_8743_8762(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 8743, 8762);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 8620, 8789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 8620, 8789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ISymbol ISymbolInternal.GetISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 8838, 8853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 8841, 8853);
                return f_10040_8841_8853(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 8838, 8853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 8838, 8853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 8838, 8853);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ISymbol
            f_10040_8841_8853(Microsoft.CodeAnalysis.CSharp.Symbol
            this_param)
            {
                var return_v = this_param.ISymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 8841, 8853);
                return return_v;
            }

        }

        internal virtual ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 9148, 9397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 9257, 9295);

                    var
                    container = f_10040_9273_9294(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 9313, 9382);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10040, 9320, 9345) || (((object)container != null && DynAbs.Tracing.TraceSender.Conditional_F2(10040, 9348, 9374)) || DynAbs.Tracing.TraceSender.Conditional_F3(10040, 9377, 9381))) ? f_10040_9348_9374(container) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 9148, 9397);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10040_9273_9294(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 9273, 9294);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10040_9348_9374(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 9348, 9374);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 9077, 9408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 9077, 9408);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual int? MemberIndexOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 9817, 9824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 9820, 9824);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 9817, 9824);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 9817, 9824);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 9817, 9824);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Symbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 10181, 10264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 10217, 10249);

                    return f_10040_10224_10248();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 10181, 10264);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10040_10224_10248()
                    {
                        var return_v = OriginalSymbolDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 10224, 10248);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 10124, 10275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 10124, 10275);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual Symbol OriginalSymbolDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 10361, 10424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 10397, 10409);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 10361, 10424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 10287, 10435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 10287, 10435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 10620, 10721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 10656, 10706);

                    return (object)this == (object)f_10040_10687_10705();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 10620, 10721);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10040_10687_10705()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 10687, 10705);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 10571, 10732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 10571, 10732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 11262, 11672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 11338, 11369);

                var
                locations = f_10040_11354_11368(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 11383, 11436);

                var
                declaringCompilation = f_10040_11410_11435(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 11450, 11493);

                f_10040_11450_11492(declaringCompilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 11545, 11661);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10040, 11552, 11574) || (((locations.Length > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10040, 11577, 11631)) || DynAbs.Tracing.TraceSender.Conditional_F3(10040, 11634, 11660))) ? f_10040_11577_11631(locations[0], declaringCompilation) : LexicalSortKey.NotInSource;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 11262, 11672);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10040_11354_11368(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 11354, 11368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10040_11410_11435(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 11410, 11435);
                    return return_v;
                }


                int
                f_10040_11450_11492(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 11450, 11492);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10040_11577_11631(Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey(location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 11577, 11631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 11262, 11672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 11262, 11672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract ImmutableArray<Location> Locations { get; }

        public abstract ImmutableArray<SyntaxReference> DeclaringSyntaxReferences { get; }

        internal static ImmutableArray<SyntaxReference> GetDeclaringSyntaxReferenceHelper<TNode>(ImmutableArray<Location> locations)
                    where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 13723, 16173);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 13916, 14031) || true) && (locations.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 13916, 14031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 13971, 14016);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 13916, 14031);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14047, 14131);

                ArrayBuilder<SyntaxReference>
                builder = f_10040_14087_14130<TNode>()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14145, 16110);
                    foreach (Location location in f_10040_14175_14184_I(locations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 14145, 16110);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14311, 14425) || true) && (location == null || (DynAbs.Tracing.TraceSender.Expression_False(10040, 14315, 14355) || f_10040_14335_14355_M(!location.IsInSource)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 14311, 14425);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14397, 14406);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 14311, 14425);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14445, 16095) || true) && (location.SourceSpan.Length != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 14445, 16095);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14522, 14609);

                            SyntaxToken
                            token = f_10040_14542_14608<TNode>(f_10040_14542_14571<TNode>(f_10040_14542_14561<TNode>(location)), location.SourceSpan.Start)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14631, 14965) || true) && (token.Kind() != SyntaxKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 14631, 14965);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14716, 14782);

                                CSharpSyntaxNode
                                node = f_10040_14740_14781<TNode>(token.Parent)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14808, 14942) || true) && (node != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 14808, 14942);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 14882, 14915);

                                    f_10040_14882_14914<TNode>(builder, f_10040_14894_14913<TNode>(node));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 14808, 14942);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 14631, 14965);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 14445, 16095);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 14445, 16095);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 15430, 15480);

                            SyntaxNode
                            parent = f_10040_15450_15479<TNode>(f_10040_15450_15469<TNode>(location))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 15502, 15526);

                            SyntaxNode
                            found = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 15548, 15926);
                                foreach (var descendant in f_10040_15575_15662_I(f_10040_15575_15662<TNode>(parent, c => c.Location.SourceSpan.Contains(location.SourceSpan))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 15548, 15926);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 15712, 15903) || true) && (descendant is TNode && (DynAbs.Tracing.TraceSender.Expression_True(10040, 15716, 15799) && f_10040_15739_15758<TNode>(descendant).SourceSpan.Contains(f_10040_15779_15798<TNode>(location))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 15712, 15903);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 15857, 15876);

                                        found = descendant;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 15712, 15903);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 15548, 15926);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 379);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 379);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 15950, 16076) || true) && (found is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 15950, 16076);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 16019, 16053);

                                f_10040_16019_16052<TNode>(builder, f_10040_16031_16051<TNode>(found));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 15950, 16076);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 14445, 16095);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 14145, 16110);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 1966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 1966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 16126, 16162);

                return f_10040_16133_16161<TNode>(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 13723, 16173);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxReference>
                f_10040_14087_14130<TNode>() where TNode : CSharpSyntaxNode

                {
                    var return_v = ArrayBuilder<SyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 14087, 14130);
                    return return_v;
                }


                bool
                f_10040_14335_14355_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 14335, 14355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10040_14542_14561<TNode>(Microsoft.CodeAnalysis.Location
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 14542, 14561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10040_14542_14571<TNode>(Microsoft.CodeAnalysis.SyntaxTree
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 14542, 14571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10040_14542_14608<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 14542, 14608);
                    return return_v;
                }


                TNode?
                f_10040_14740_14781<TNode>(Microsoft.CodeAnalysis.SyntaxNode?
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.FirstAncestorOrSelf<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 14740, 14781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10040_14894_14913<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 14894, 14913);
                    return return_v;
                }


                int
                f_10040_14882_14914<TNode>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxReference>
                this_param, Microsoft.CodeAnalysis.SyntaxReference
                item) where TNode : CSharpSyntaxNode

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 14882, 14914);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10040_15450_15469<TNode>(Microsoft.CodeAnalysis.Location
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 15450, 15469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10040_15450_15479<TNode>(Microsoft.CodeAnalysis.SyntaxTree
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 15450, 15479);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10040_15575_15662<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.DescendantNodesAndSelf(descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 15575, 15662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10040_15739_15758<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 15739, 15758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10040_15779_15798<TNode>(Microsoft.CodeAnalysis.Location
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 15779, 15798);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10040_15575_15662_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 15575, 15662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10040_16031_16051<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 16031, 16051);
                    return return_v;
                }


                int
                f_10040_16019_16052<TNode>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxReference>
                this_param, Microsoft.CodeAnalysis.SyntaxReference
                item) where TNode : CSharpSyntaxNode

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 16019, 16052);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10040_14175_14184_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 14175, 14184);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10040_16133_16161<TNode>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxReference>
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 16133, 16161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 13723, 16173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 13723, 16173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract Accessibility DeclaredAccessibility { get; }

        public abstract bool IsStatic { get; }

        public abstract bool IsVirtual { get; }

        public abstract bool IsOverride { get; }

        public abstract bool IsAbstract { get; }

        public abstract bool IsSealed { get; }

        public abstract bool IsExtern { get; }

        public virtual bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 19879, 19900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 19885, 19898);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 19879, 19900);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 19814, 19911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 19814, 19911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool CanBeReferencedByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 20343, 24017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 20379, 23530);

                    switch (f_10040_20387_20396(this))
                    {

                        case SymbolKind.Local:
                        case SymbolKind.Label:
                        case SymbolKind.Alias:
                        case SymbolKind.RangeVariable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 20379, 23530);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 20701, 20713);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 20379, 23530);

                        case SymbolKind.Namespace:
                        case SymbolKind.Field:
                        case SymbolKind.ErrorType:
                        case SymbolKind.Parameter:
                        case SymbolKind.TypeParameter:
                        case SymbolKind.Event:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 20379, 23530);
                            DynAbs.Tracing.TraceSender.TraceBreak(10040, 21025, 21031);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 20379, 23530);

                        case SymbolKind.NamedType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 20379, 23530);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 21107, 21250) || true) && (f_10040_21111_21152(((NamedTypeSymbol)this)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 21107, 21250);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 21210, 21223);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 21107, 21250);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10040, 21276, 21282);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 20379, 23530);

                        case SymbolKind.Property:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 20379, 23530);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 21357, 21393);

                            var
                            property = (PropertySymbol)this
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 21419, 21575) || true) && (f_10040_21423_21441(property) || (DynAbs.Tracing.TraceSender.Expression_False(10040, 21423, 21477) || f_10040_21445_21477(property)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 21419, 21575);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 21535, 21548);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 21419, 21575);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10040, 21601, 21607);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 20379, 23530);

                        case SymbolKind.Method:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 20379, 23530);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 21680, 21712);

                            var
                            method = (MethodSymbol)this
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 21738, 22981);

                            switch (f_10040_21746_21763(method))
                            {

                                case MethodKind.Ordinary:
                                case MethodKind.LocalFunction:
                                case MethodKind.ReducedExtension:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 21738, 22981);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10040, 22003, 22009);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 21738, 22981);

                                case MethodKind.Destructor:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 21738, 22981);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 22367, 22379);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 21738, 22981);

                                case MethodKind.DelegateInvoke:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 21738, 22981);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 22474, 22486);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 21738, 22981);

                                case MethodKind.PropertyGet:
                                case MethodKind.PropertySet:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 21738, 22981);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 22636, 22829) || true) && (!f_10040_22641_22707(((PropertySymbol)f_10040_22658_22681(method))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 22636, 22829);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 22781, 22794);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 22636, 22829);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10040, 22863, 22869);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 21738, 22981);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 21738, 22981);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 22941, 22954);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 21738, 22981);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10040, 23007, 23013);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 20379, 23530);

                        case SymbolKind.ArrayType:
                        case SymbolKind.PointerType:
                        case SymbolKind.FunctionPointerType:
                        case SymbolKind.Assembly:
                        case SymbolKind.DynamicType:
                        case SymbolKind.NetModule:
                        case SymbolKind.Discard:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 20379, 23530);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 23388, 23401);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 20379, 23530);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 20379, 23530);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 23459, 23511);

                            throw f_10040_23465_23510(f_10040_23500_23509(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 20379, 23530);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 23870, 24002);

                    return f_10040_23877_23917(f_10040_23907_23916(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10040, 23877, 24001) && !f_10040_23943_24001(f_10040_23991_24000(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 20343, 24017);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10040_20387_20396(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 20387, 20396);
                        return return_v;
                    }


                    bool
                    f_10040_21111_21152(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSubmissionClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 21111, 21152);
                        return return_v;
                    }


                    bool
                    f_10040_21423_21441(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsIndexer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 21423, 21441);
                        return return_v;
                    }


                    bool
                    f_10040_21445_21477(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.MustCallMethodsDirectly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 21445, 21477);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10040_21746_21763(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 21746, 21763);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10040_22658_22681(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 22658, 22681);
                        return return_v;
                    }


                    bool
                    f_10040_22641_22707(Microsoft.CodeAnalysis.CSharp.Symbol
                    property)
                    {
                        var return_v = ((PropertySymbol)property).CanCallMethodsDirectly();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 22641, 22707);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10040_23500_23509(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 23500, 23509);
                        return return_v;
                    }


                    System.Exception
                    f_10040_23465_23510(Microsoft.CodeAnalysis.SymbolKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 23465, 23510);
                        return return_v;
                    }


                    string
                    f_10040_23907_23916(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 23907, 23916);
                        return return_v;
                    }


                    bool
                    f_10040_23877_23917(string
                    name)
                    {
                        var return_v = SyntaxFacts.IsValidIdentifier(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 23877, 23917);
                        return return_v;
                    }


                    string
                    f_10040_23991_24000(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 23991, 24000);
                        return return_v;
                    }


                    bool
                    f_10040_23943_24001(string
                    name)
                    {
                        var return_v = SyntaxFacts.ContainsDroppedIdentifierCharacters(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 23943, 24001);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 20285, 24028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 20285, 24028);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool CanBeReferencedByNameIgnoringIllegalCharacters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 24527, 25418);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 24563, 25373) || true) && (f_10040_24567_24576(this) == SymbolKind.Method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 24563, 25373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 24639, 24671);

                        var
                        method = (MethodSymbol)this
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 24693, 25354);

                        switch (f_10040_24701_24718(method))
                        {

                            case MethodKind.Ordinary:
                            case MethodKind.LocalFunction:
                            case MethodKind.DelegateInvoke:
                            case MethodKind.Destructor: // See comment in CanBeReferencedByName.
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 24693, 25354);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 25030, 25042);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 24693, 25354);

                            case MethodKind.PropertyGet:
                            case MethodKind.PropertySet:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 24693, 25354);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 25180, 25254);

                                return f_10040_25187_25253(((PropertySymbol)f_10040_25204_25227(method)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 24693, 25354);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 24693, 25354);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 25318, 25331);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 24693, 25354);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 24563, 25373);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 25391, 25403);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 24527, 25418);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10040_24567_24576(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 24567, 24576);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10040_24701_24718(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 24701, 24718);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10040_25204_25227(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 25204, 25227);
                        return return_v;
                    }


                    bool
                    f_10040_25187_25253(Microsoft.CodeAnalysis.CSharp.Symbol
                    property)
                    {
                        var return_v = ((PropertySymbol)property).CanCallMethodsDirectly();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 25187, 25253);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 24442, 25429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 24442, 25429);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 25615, 25743);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 25615, 25743);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 25615, 25743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 25615, 25743);
            }
        }

        public static bool operator ==(Symbol left, Symbol right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 26367, 27082);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 26824, 26910) || true) && (right is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 26824, 26910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 26875, 26895);

                    return left is null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 26824, 26910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 27012, 27071);

                return (object)left == (object)right || (DynAbs.Tracing.TraceSender.Expression_False(10040, 27019, 27070) || f_10040_27052_27070(right, left));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 26367, 27082);

                bool
                f_10040_27052_27070(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 27052, 27070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 26367, 27082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 26367, 27082);
            }
        }

        public static bool operator !=(Symbol left, Symbol right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 27327, 28194);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 27933, 28021) || true) && (right is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 27933, 28021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 27984, 28006);

                    return left is object;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 27933, 28021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 28123, 28183);

                return (object)left != (object)right && (DynAbs.Tracing.TraceSender.Expression_True(10040, 28130, 28182) && !f_10040_28164_28182(right, left));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 27327, 28194);

                bool
                f_10040_28164_28182(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 28164, 28182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 27327, 28194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 27327, 28194);
            }
        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 28206, 28366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 28277, 28355);

                return f_10040_28284_28354(this, obj as Symbol, f_10040_28311_28353(SymbolEqualityComparer.Default));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 28206, 28366);

                Microsoft.CodeAnalysis.TypeCompareKind
                f_10040_28311_28353(Microsoft.CodeAnalysis.SymbolEqualityComparer
                this_param)
                {
                    var return_v = this_param.CompareKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 28311, 28353);
                    return return_v;
                }


                bool
                f_10040_28284_28354(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, object
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol?)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 28284, 28354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 28206, 28366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 28206, 28366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ISymbolInternal.Equals(ISymbolInternal other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 28378, 28542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 28482, 28531);

                return f_10040_28489_28530(this, other as Symbol, compareKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 28378, 28542);

                bool
                f_10040_28489_28530(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol?)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 28489, 28530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 28378, 28542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 28378, 28542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool Equals(Symbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 28663, 28797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 28757, 28786);

                return (object)this == other;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 28663, 28797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 28663, 28797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 28663, 28797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 28883, 29024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 28941, 29013);

                return f_10040_28948_29012(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 28883, 29024);

                int
                f_10040_28948_29012(Microsoft.CodeAnalysis.CSharp.Symbol
                o)
                {
                    var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 28948, 29012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 28883, 29024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 28883, 29024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Equals(Symbol first, Symbol second, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 29036, 29300);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 29144, 29232) || true) && (first is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 29144, 29232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 29195, 29217);

                    return second is null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 29144, 29232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 29248, 29289);

                return f_10040_29255_29288(first, second, compareKind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 29036, 29300);

                bool
                f_10040_29255_29288(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 29255, 29288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 29036, 29300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 29036, 29300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 29829, 29935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 29894, 29924);

                return f_10040_29901_29923(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 29829, 29935);

                string
                f_10040_29901_29923(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 29901, 29923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 29829, 29935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 29829, 29935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument a);

        internal Symbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10040, 30446, 30485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 1112, 1124);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10040, 30446, 30485);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 30446, 30485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 30446, 30485);
            }
        }

        internal virtual void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 30611, 30765);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 30611, 30765);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 30611, 30765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 30611, 30765);
            }
        }

        internal static void AddSynthesizedAttribute(ref ArrayBuilder<SynthesizedAttributeData> attributes, SynthesizedAttributeData attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 30939, 31368);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 31099, 31357) || true) && (attribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 31099, 31357);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 31154, 31296) || true) && (attributes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 31154, 31296);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 31218, 31277);

                        attributes = f_10040_31231_31276(1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 31154, 31296);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 31316, 31342);

                    f_10040_31316_31341(
                                    attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 31099, 31357);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 30939, 31368);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                f_10040_31231_31276(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 31231, 31276);
                    return return_v;
                }


                int
                f_10040_31316_31341(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 31316, 31341);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 30939, 31368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 30939, 31368);
            }
        }

        internal CharSet? GetEffectiveDefaultMarshallingCharSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 31827, 32071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 31909, 31991);

                f_10040_31909_31990(f_10040_31922_31931(this) == SymbolKind.NamedType || (DynAbs.Tracing.TraceSender.Expression_False(10040, 31922, 31989) || f_10040_31959_31968(this) == SymbolKind.Method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 32005, 32060);

                return f_10040_32012_32059(f_10040_32012_32033(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 31827, 32071);

                Microsoft.CodeAnalysis.SymbolKind
                f_10040_31922_31931(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 31922, 31931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10040_31959_31968(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 31959, 31968);
                    return return_v;
                }


                int
                f_10040_31909_31990(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 31909, 31990);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10040_32012_32033(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 32012, 32033);
                    return return_v;
                }


                System.Runtime.InteropServices.CharSet?
                f_10040_32012_32059(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.DefaultMarshallingCharSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 32012, 32059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 31827, 32071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 31827, 32071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsFromCompilation(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 32085, 32279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 32172, 32206);

                f_10040_32172_32205(compilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 32220, 32268);

                return compilation == f_10040_32242_32267(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 32085, 32279);

                int
                f_10040_32172_32205(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 32172, 32205);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10040_32242_32267(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 32242, 32267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 32085, 32279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 32085, 32279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Dangerous_IsFromSomeCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 33175, 33224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 33181, 33222);

                    return f_10040_33188_33213(this) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 33175, 33224);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10040_33188_33213(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 33188, 33213);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 33105, 33235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 33105, 33235);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 33247, 34142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 33427, 33484);

                var
                declaringReferences = f_10040_33453_33483(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 33498, 33706) || true) && (f_10040_33502_33527(this) && (DynAbs.Tracing.TraceSender.Expression_True(10040, 33502, 33562) && declaringReferences.Length == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 33498, 33706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 33596, 33691);

                    return f_10040_33603_33690(f_10040_33603_33624(this), tree, definedWithinSpan, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 33498, 33706);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 33722, 34102);
                    foreach (var syntaxRef in f_10040_33748_33767_I(declaringReferences))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 33722, 34102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 33801, 33850);

                        cancellationToken.ThrowIfCancellationRequested();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 33870, 34087) || true) && (f_10040_33874_33894(syntaxRef) == tree && (DynAbs.Tracing.TraceSender.Expression_True(10040, 33874, 34014) && (f_10040_33928_33955_M(!definedWithinSpan.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(10040, 33928, 34013) || syntaxRef.Span.IntersectsWith(definedWithinSpan.Value)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 33870, 34087);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 34056, 34068);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 33870, 34087);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 33722, 34102);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 381);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 34118, 34131);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 33247, 34142);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10040_33453_33483(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 33453, 33483);
                    return return_v;
                }


                bool
                f_10040_33502_33527(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 33502, 33527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10040_33603_33624(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 33603, 33624);
                    return return_v;
                }


                bool
                f_10040_33603_33690(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan?
                definedWithinSpan, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.IsDefinedInSourceTree(tree, definedWithinSpan, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 33603, 33690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10040_33874_33894(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 33874, 33894);
                    return return_v;
                }


                bool
                f_10040_33928_33955_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 33928, 33955);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10040_33748_33767_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 33748, 33767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 33247, 34142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 33247, 34142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ForceCompleteMemberByLocation(SourceLocation locationOpt, Symbol member, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 34154, 34611);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 34309, 34600) || true) && (locationOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10040, 34313, 34431) || f_10040_34336_34431(member, f_10040_34365_34387(locationOpt), f_10040_34389_34411(locationOpt), cancellationToken)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 34309, 34600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 34465, 34514);

                    cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 34532, 34585);

                    f_10040_34532_34584(member, locationOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 34309, 34600);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 34154, 34611);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10040_34365_34387(Microsoft.CodeAnalysis.SourceLocation
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 34365, 34387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10040_34389_34411(Microsoft.CodeAnalysis.SourceLocation
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 34389, 34411);
                    return return_v;
                }


                bool
                f_10040_34336_34431(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan
                definedWithinSpan, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.IsDefinedInSourceTree(tree, (Microsoft.CodeAnalysis.Text.TextSpan?)definedWithinSpan, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 34336, 34431);
                    return return_v;
                }


                int
                f_10040_34532_34584(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SourceLocation?
                locationOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ForceComplete(locationOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 34532, 34584);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 34154, 34611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 34154, 34611);
            }
        }

        public virtual string GetDocumentationCommentId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 34811, 35598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 35208, 35253);

                var
                pool = f_10040_35219_35252()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 35303, 35340);

                    StringBuilder
                    builder = pool.Builder
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 35358, 35418);

                    f_10040_35358_35417(DocumentationCommentIDVisitor.Instance, this, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 35436, 35491);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10040, 35443, 35462) || ((f_10040_35443_35457(builder) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10040, 35465, 35469)) || DynAbs.Tracing.TraceSender.Conditional_F3(10040, 35472, 35490))) ? null : f_10040_35472_35490(builder);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10040, 35520, 35587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 35560, 35572);

                    f_10040_35560_35571(pool);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10040, 35520, 35587);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 34811, 35598);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10040_35219_35252()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 35219, 35252);
                    return return_v;
                }


                object
                f_10040_35358_35417(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, System.Text.StringBuilder
                argument)
                {
                    var return_v = this_param.Visit(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 35358, 35417);
                    return return_v;
                }


                int
                f_10040_35443_35457(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 35443, 35457);
                    return return_v;
                }


                string
                f_10040_35472_35490(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 35472, 35490);
                    return return_v;
                }


                int
                f_10040_35560_35571(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 35560, 35571);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 34811, 35598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 34811, 35598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual string GetDocumentationCommentXml(
                    CultureInfo preferredCulture = null,
                    bool expandIncludes = false,
                    CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 36287, 36553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 36532, 36542);

                return "";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 36287, 36553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 36287, 36553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 36287, 36553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly SymbolDisplayFormat s_debuggerDisplayFormat;

        internal virtual string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 36991, 37141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 37060, 37130);

                return $"{f_10040_37070_37079(this)} {f_10040_37082_37127(this, s_debuggerDisplayFormat)}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 36991, 37141);

                Microsoft.CodeAnalysis.SymbolKind
                f_10040_37070_37079(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 37070, 37079);
                    return return_v;
                }


                string
                f_10040_37082_37127(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 37082, 37127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 36991, 37141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 36991, 37141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void AddDeclarationDiagnostics(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 37153, 37744);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 37263, 37436) || true) && (f_10040_37267_37283() is SourceMemberContainerTypeSymbol container)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 37263, 37436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 37362, 37421);

                    f_10040_37362_37420(container, this, forDiagnostics: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 37263, 37436);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 37458, 37733) || true) && (f_10040_37462_37499_M(!diagnostics.IsEmptyWithoutResolution))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 37458, 37733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 37533, 37591);

                    CSharpCompilation
                    compilation = f_10040_37565_37590(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 37609, 37643);

                    f_10040_37609_37642(compilation != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 37661, 37718);

                    f_10040_37661_37717(f_10040_37661_37695(compilation), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 37458, 37733);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 37153, 37744);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10040_37267_37283()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 37267, 37283);
                    return return_v;
                }


                int
                f_10040_37362_37420(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member, bool
                forDiagnostics)
                {
                    this_param.AssertMemberExposure(member, forDiagnostics: forDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 37362, 37420);
                    return 0;
                }


                bool
                f_10040_37462_37499_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 37462, 37499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10040_37565_37590(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 37565, 37590);
                    return return_v;
                }


                int
                f_10040_37609_37642(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 37609, 37642);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10040_37661_37695(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DeclarationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 37661, 37695);
                    return return_v;
                }


                int
                f_10040_37661_37717(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 37661, 37717);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 37153, 37744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 37153, 37744);
            }
        }

        internal bool HasUseSiteError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 37976, 38162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 38012, 38052);

                    var
                    diagnostic = f_10040_38029_38051(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 38070, 38147);

                    return diagnostic != null && (DynAbs.Tracing.TraceSender.Expression_True(10040, 38077, 38146) && f_10040_38099_38118(diagnostic) == DiagnosticSeverity.Error);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 37976, 38162);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_10040_38029_38051(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.GetUseSiteDiagnostic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 38029, 38051);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_10040_38099_38118(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 38099, 38118);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 37922, 38173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 37922, 38173);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 38350, 38452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 38429, 38441);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 38350, 38452);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 38350, 38452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 38350, 38452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual int HighestPriorityUseSiteError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 38780, 38851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 38816, 38836);

                    return int.MaxValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 38780, 38851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 38706, 38862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 38706, 38862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool HasUnsupportedMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 39902, 39966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 39938, 39951);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 39902, 39966);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 39835, 39977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 39835, 39977);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal DiagnosticInfo GetUseSiteDiagnosticForSymbolOrContainingType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 39989, 40345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 40085, 40124);

                var
                info = f_10040_40096_40123(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 40138, 40260) || true) && (info != null && (DynAbs.Tracing.TraceSender.Expression_True(10040, 40142, 40199) && f_10040_40158_40171(info) == DiagnosticSeverity.Error))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 40138, 40260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 40233, 40245);

                    return info;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 40138, 40260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 40276, 40334);

                return f_10040_40283_40325(f_10040_40283_40302(this)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo>(10040, 40283, 40333) ?? info);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 39989, 40345);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10040_40096_40123(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 40096, 40123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10040_40158_40171(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 40158, 40171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10040_40283_40302(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 40283, 40302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10040_40283_40325(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 40283, 40325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 39989, 40345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 39989, 40345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool MergeUseSiteDiagnostics(ref DiagnosticInfo result, DiagnosticInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 40476, 41402);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 40586, 40664) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 40586, 40664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 40636, 40649);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 40586, 40664);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 40680, 40986) || true) && (f_10040_40684_40697(info) == DiagnosticSeverity.Error && (DynAbs.Tracing.TraceSender.Expression_True(10040, 40684, 40820) && (f_10040_40730_40739(info) == f_10040_40743_40770() || (DynAbs.Tracing.TraceSender.Expression_False(10040, 40730, 40819) || f_10040_40774_40801() == Int32.MaxValue))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 40680, 40986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 40927, 40941);

                    result = info;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 40959, 40971);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 40680, 40986);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 41002, 41271) || true) && (result == null || (DynAbs.Tracing.TraceSender.Expression_False(10040, 41006, 41114) || f_10040_41024_41039(result) == DiagnosticSeverity.Warning && (DynAbs.Tracing.TraceSender.Expression_True(10040, 41024, 41114) && f_10040_41073_41086(info) == DiagnosticSeverity.Error)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 41002, 41271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 41211, 41225);

                    result = info;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 41243, 41256);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 41002, 41271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 41378, 41391);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 40476, 41402);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10040_40684_40697(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 40684, 40697);
                    return return_v;
                }


                int
                f_10040_40730_40739(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 40730, 40739);
                    return return_v;
                }


                int
                f_10040_40743_40770()
                {
                    var return_v = HighestPriorityUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 40743, 40770);
                    return return_v;
                }


                int
                f_10040_40774_40801()
                {
                    var return_v = HighestPriorityUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 40774, 40801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10040_41024_41039(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 41024, 41039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10040_41073_41086(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 41073, 41086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 40476, 41402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 40476, 41402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ReportUseSiteDiagnostic(DiagnosticInfo info, DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 41949, 42877);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 42469, 42755) || true) && (f_10040_42473_42482(info) == (int)ErrorCode.WRN_UnifyReferenceBldRev || (DynAbs.Tracing.TraceSender.Expression_False(10040, 42473, 42598) || f_10040_42546_42555(info) == (int)ErrorCode.WRN_UnifyReferenceMajMin) || (DynAbs.Tracing.TraceSender.Expression_False(10040, 42473, 42674) || f_10040_42619_42628(info) == (int)ErrorCode.ERR_AssemblyMatchBadVersion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 42469, 42755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 42708, 42740);

                    location = NoLocation.Singleton;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 42469, 42755);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 42771, 42803);

                f_10040_42771_42802(
                            diagnostics, info, location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 42817, 42866);

                return f_10040_42824_42837(info) == DiagnosticSeverity.Error;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 41949, 42877);

                int
                f_10040_42473_42482(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 42473, 42482);
                    return return_v;
                }


                int
                f_10040_42546_42555(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 42546, 42555);
                    return return_v;
                }


                int
                f_10040_42619_42628(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 42619, 42628);
                    return return_v;
                }


                int
                f_10040_42771_42802(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 42771, 42802);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10040_42824_42837(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 42824, 42837);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 41949, 42877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 41949, 42877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool DeriveUseSiteDiagnosticFromType(ref DiagnosticInfo result, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 42987, 43482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 43101, 43151);

                DiagnosticInfo
                info = f_10040_43123_43150(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 43165, 43406) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 43165, 43406);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 43215, 43391) || true) && (f_10040_43219_43228(info) == (int)ErrorCode.ERR_BogusType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 43215, 43391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 43302, 43372);

                        info = f_10040_43309_43363(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo>(10040, 43309, 43371) ?? info);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 43215, 43391);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 43165, 43406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 43422, 43471);

                return f_10040_43429_43470(this, ref result, info);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 42987, 43482);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10040_43123_43150(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 43123, 43150);
                    return return_v;
                }


                int
                f_10040_43219_43228(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 43219, 43228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10040_43309_43363(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetSymbolSpecificUnsupportedMetadataUseSiteErrorInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 43309, 43363);
                    return return_v;
                }


                bool
                f_10040_43429_43470(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.DiagnosticInfo?
                info)
                {
                    var return_v = this_param.MergeUseSiteDiagnostics(ref result, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 43429, 43470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 42987, 43482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 42987, 43482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DiagnosticInfo GetSymbolSpecificUnsupportedMetadataUseSiteErrorInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 43494, 43930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 43596, 43891);

                switch (f_10040_43604_43613(this))
                {

                    case SymbolKind.Field:
                    case SymbolKind.Method:
                    case SymbolKind.Property:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 43596, 43891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 43815, 43876);

                        return f_10040_43822_43875(ErrorCode.ERR_BindToBogus, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 43596, 43891);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 43907, 43919);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 43494, 43930);

                Microsoft.CodeAnalysis.SymbolKind
                f_10040_43604_43613(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 43604, 43613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10040_43822_43875(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 43822, 43875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 43494, 43930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 43494, 43930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool DeriveUseSiteDiagnosticFromType(ref DiagnosticInfo result, TypeWithAnnotations type, AllowedRequiredModifierType allowedRequiredModifierType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 43942, 44324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 44122, 44313);

                return f_10040_44129_44183(this, ref result, type.Type) || (DynAbs.Tracing.TraceSender.Expression_False(10040, 44129, 44312) || f_10040_44207_44312(this, ref result, type.CustomModifiers, allowedRequiredModifierType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 43942, 44324);

                bool
                f_10040_44129_44183(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 44129, 44183);
                    return return_v;
                }


                bool
                f_10040_44207_44312(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromCustomModifiers(ref result, customModifiers, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 44207, 44312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 43942, 44324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 43942, 44324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool DeriveUseSiteDiagnosticFromParameter(ref DiagnosticInfo result, ParameterSymbol param)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 44336, 45195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 44461, 45184);

                return f_10040_44468_44572(this, ref result, f_10040_44512_44537(param), AllowedRequiredModifierType.None) || (DynAbs.Tracing.TraceSender.Expression_False(10040, 44468, 45183) || f_10040_44596_45183(this, ref result, f_10040_44651_44675(param), (DynAbs.Tracing.TraceSender.Conditional_F1(10040, 44740, 44827) || ((this is MethodSymbol method && (DynAbs.Tracing.TraceSender.Expression_True(10040, 44740, 44827) && f_10040_44771_44788(method) == MethodKind.FunctionPointerSignature) && DynAbs.Tracing.TraceSender.Conditional_F2(10040, 44897, 45042)) || DynAbs.Tracing.TraceSender.Conditional_F3(10040, 45112, 45182))) ? AllowedRequiredModifierType.System_Runtime_InteropServices_InAttribute | AllowedRequiredModifierType.System_Runtime_CompilerServices_OutAttribute : AllowedRequiredModifierType.System_Runtime_InteropServices_InAttribute));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 44336, 45195);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10040_44512_44537(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 44512, 44537);
                    return return_v;
                }


                bool
                f_10040_44468_44572(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, type, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 44468, 44572);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10040_44651_44675(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 44651, 44675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10040_44771_44788(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 44771, 44788);
                    return return_v;
                }


                bool
                f_10040_44596_45183(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromCustomModifiers(ref result, customModifiers, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 44596, 45183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 44336, 45195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 44336, 45195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool DeriveUseSiteDiagnosticFromParameters(ref DiagnosticInfo result, ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 45207, 45619);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 45354, 45579);
                    foreach (ParameterSymbol param in f_10040_45388_45398_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 45354, 45579);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 45432, 45564) || true) && (f_10040_45436_45491(this, ref result, param))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 45432, 45564);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 45533, 45545);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 45432, 45564);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 45354, 45579);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 45595, 45608);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 45207, 45619);

                bool
                f_10040_45436_45491(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                param)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromParameter(ref result, param);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 45436, 45491);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10040_45388_45398_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 45388, 45398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 45207, 45619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 45207, 45619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }


        [Flags]
        internal enum AllowedRequiredModifierType
        {
            None = 0,
            System_Runtime_CompilerServices_Volatile = 1,
            System_Runtime_InteropServices_InAttribute = 1 << 1,
            System_Runtime_CompilerServices_IsExternalInit = 1 << 2,
            System_Runtime_CompilerServices_OutAttribute = 1 << 3,
        }

        internal bool DeriveUseSiteDiagnosticFromCustomModifiers(ref DiagnosticInfo result, ImmutableArray<CustomModifier> customModifiers, AllowedRequiredModifierType allowedRequiredModifierType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 46011, 49468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 46224, 46310);

                AllowedRequiredModifierType
                requiredModifiersFound = AllowedRequiredModifierType.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 46324, 46359);

                bool
                checkRequiredModifiers = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 46375, 49428);
                    foreach (CustomModifier modifier in f_10040_46411_46426_I(customModifiers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 46375, 49428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 46460, 46539);

                        NamedTypeSymbol
                        modifierType = f_10040_46491_46538(((CSharpCustomModifier)modifier))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 46559, 48970) || true) && (checkRequiredModifiers && (DynAbs.Tracing.TraceSender.Expression_True(10040, 46563, 46609) && f_10040_46589_46609_M(!modifier.IsOptional)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 46559, 48970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 46651, 46722);

                            AllowedRequiredModifierType
                            current = AllowedRequiredModifierType.None
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 46746, 48220) || true) && ((allowedRequiredModifierType & AllowedRequiredModifierType.System_Runtime_InteropServices_InAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 46750, 46927) && f_10040_46886_46927(modifierType)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 46746, 48220);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 46977, 47058);

                                current = AllowedRequiredModifierType.System_Runtime_InteropServices_InAttribute;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 46746, 48220);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 46746, 48220);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 47108, 48220) || true) && ((allowedRequiredModifierType & AllowedRequiredModifierType.System_Runtime_CompilerServices_Volatile) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 47112, 47328) && f_10040_47246_47270(modifierType) == SpecialType.System_Runtime_CompilerServices_IsVolatile))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 47108, 48220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 47378, 47457);

                                    current = AllowedRequiredModifierType.System_Runtime_CompilerServices_Volatile;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 47108, 48220);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 47108, 48220);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 47507, 48220) || true) && ((allowedRequiredModifierType & AllowedRequiredModifierType.System_Runtime_CompilerServices_IsExternalInit) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 47511, 47695) && f_10040_47651_47695(modifierType)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 47507, 48220);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 47745, 47830);

                                        current = AllowedRequiredModifierType.System_Runtime_CompilerServices_IsExternalInit;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 47507, 48220);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 47507, 48220);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 47880, 48220) || true) && ((allowedRequiredModifierType & AllowedRequiredModifierType.System_Runtime_CompilerServices_OutAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 47884, 48064) && f_10040_48022_48064(modifierType)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 47880, 48220);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 48114, 48197);

                                            current = AllowedRequiredModifierType.System_Runtime_CompilerServices_OutAttribute;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 47880, 48220);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 47507, 48220);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 47108, 48220);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 46746, 48220);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 48244, 48893) || true) && (current == AllowedRequiredModifierType.None || (DynAbs.Tracing.TraceSender.Expression_False(10040, 48248, 48417) || (current != requiredModifiersFound && (DynAbs.Tracing.TraceSender.Expression_True(10040, 48321, 48416) && requiredModifiersFound != AllowedRequiredModifierType.None))))
                            ) // At the moment we don't support applying different allowed modreqs to the same target.

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 48244, 48893);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 48556, 48811) || true) && (f_10040_48560_48714(this, ref result, f_10040_48596_48650(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo>(10040, 48596, 48713) ?? f_10040_48654_48713(ErrorCode.ERR_BogusType, string.Empty))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 48556, 48811);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 48772, 48784);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 48556, 48811);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 48839, 48870);

                                checkRequiredModifiers = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 48244, 48893);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 48917, 48951);

                            requiredModifiersFound |= current;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 46559, 48970);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 49114, 49259) || true) && (f_10040_49118_49151(modifierType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 49114, 49259);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 49193, 49240);

                            modifierType = f_10040_49208_49239(modifierType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 49114, 49259);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 49279, 49413) || true) && (f_10040_49283_49340(this, ref result, modifierType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 49279, 49413);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 49382, 49394);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 49279, 49413);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 46375, 49428);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 3054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 3054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 49444, 49457);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 46011, 49468);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10040_46491_46538(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                this_param)
                {
                    var return_v = this_param.ModifierSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 46491, 46538);
                    return return_v;
                }


                bool
                f_10040_46589_46609_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 46589, 46609);
                    return return_v;
                }


                bool
                f_10040_46886_46927(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.IsWellKnownTypeInAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 46886, 46927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10040_47246_47270(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 47246, 47270);
                    return return_v;
                }


                bool
                f_10040_47651_47695(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.IsWellKnownTypeIsExternalInit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 47651, 47695);
                    return return_v;
                }


                bool
                f_10040_48022_48064(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.IsWellKnownTypeOutAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 48022, 48064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10040_48596_48650(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetSymbolSpecificUnsupportedMetadataUseSiteErrorInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 48596, 48650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10040_48654_48713(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 48654, 48713);
                    return return_v;
                }


                bool
                f_10040_48560_48714(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = this_param.MergeUseSiteDiagnostics(ref result, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 48560, 48714);
                    return return_v;
                }


                bool
                f_10040_49118_49151(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 49118, 49151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10040_49208_49239(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 49208, 49239);
                    return return_v;
                }


                bool
                f_10040_49283_49340(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 49283, 49340);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10040_46411_46426_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 46411, 46426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 46011, 49468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 46011, 49468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetUnificationUseSiteDiagnosticRecursive<T>(ref DiagnosticInfo result, ImmutableArray<T> types, Symbol owner, ref HashSet<TypeSymbol> checkedTypes) where T : TypeSymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 49480, 49962);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 49694, 49922);
                    foreach (var t in f_10040_49712_49717_I<T>(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 49694, 49922);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 49751, 49907) || true) && (f_10040_49755_49834<T>(t, ref result, owner, ref checkedTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 49751, 49907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 49876, 49888);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 49751, 49907);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 49694, 49922);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 49938, 49951);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 49480, 49962);

                bool
                f_10040_49755_49834<T>(T
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes) where T : TypeSymbol

                {
                    var return_v = this_param.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 49755, 49834);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_10040_49712_49717_I<T>(System.Collections.Immutable.ImmutableArray<T>
                i) where T : TypeSymbol

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 49712, 49717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 49480, 49962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 49480, 49962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, ImmutableArray<TypeWithAnnotations> types, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 49974, 50450);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 50182, 50410);
                    foreach (var t in f_10040_50200_50205_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 50182, 50410);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 50239, 50395) || true) && (t.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 50239, 50395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 50364, 50376);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 50239, 50395);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 50182, 50410);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 50426, 50439);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 49974, 50450);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10040_50200_50205_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 50200, 50205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 49974, 50450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 49974, 50450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, ImmutableArray<CustomModifier> modifiers, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 50462, 50994);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 50669, 50954);
                    foreach (var modifier in f_10040_50694_50703_I(modifiers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 50669, 50954);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 50737, 50939) || true) && (f_10040_50741_50866(f_10040_50741_50788(((CSharpCustomModifier)modifier)), ref result, owner, ref checkedTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 50737, 50939);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 50908, 50920);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 50737, 50939);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 50669, 50954);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 50970, 50983);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 50462, 50994);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10040_50741_50788(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                this_param)
                {
                    var return_v = this_param.ModifierSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 50741, 50788);
                    return return_v;
                }


                bool
                f_10040_50741_50866(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = this_param.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 50741, 50866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10040_50694_50703_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 50694, 50703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 50462, 50994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 50462, 50994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, ImmutableArray<ParameterSymbol> parameters, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 51006, 51656);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 51215, 51616);
                    foreach (var parameter in f_10040_51241_51251_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 51215, 51616);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 51285, 51601) || true) && (parameter.TypeWithAnnotations.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10040, 51289, 51528) || f_10040_51421_51528(ref result, f_10040_51474_51502(parameter), owner, ref checkedTypes)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 51285, 51601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 51570, 51582);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 51285, 51601);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 51215, 51616);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 51632, 51645);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 51006, 51656);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10040_51474_51502(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 51474, 51502);
                    return return_v;
                }


                bool
                f_10040_51421_51528(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                modifiers, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, modifiers, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 51421, 51528);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10040_51241_51251_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 51241, 51251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 51006, 51656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 51006, 51656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, ImmutableArray<TypeParameterSymbol> typeParameters, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 51668, 52223);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 51885, 52183);
                    foreach (var typeParameter in f_10040_51915_51929_I(typeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 51885, 52183);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 51963, 52168) || true) && (f_10040_51967_52095(ref result, f_10040_52020_52069(typeParameter), owner, ref checkedTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 51963, 52168);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 52137, 52149);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 51963, 52168);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 51885, 52183);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 299);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 52199, 52212);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 51668, 52223);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10040_52020_52069(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 52020, 52069);
                    return return_v;
                }


                bool
                f_10040_51967_52095(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, types, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 51967, 52095);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10040_51915_51929_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 51915, 51929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 51668, 52223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 51668, 52223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ThreeState ObsoleteState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 52606, 53076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 52642, 53061);

                    switch (f_10040_52650_52662())
                    {

                        case ObsoleteAttributeKind.None:
                        case ObsoleteAttributeKind.Experimental:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 52642, 53061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 52824, 52848);

                            return ThreeState.False;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 52642, 53061);

                        case ObsoleteAttributeKind.Uninitialized:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 52642, 53061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 52937, 52963);

                            return ThreeState.Unknown;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 52642, 53061);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 52642, 53061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 53019, 53042);

                            return ThreeState.True;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 52642, 53061);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 52606, 53076);

                    Microsoft.CodeAnalysis.ObsoleteAttributeKind
                    f_10040_52650_52662()
                    {
                        var return_v = ObsoleteKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 52650, 52662);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 52548, 53087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 52548, 53087);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ObsoleteAttributeKind ObsoleteKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 53167, 53337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 53203, 53241);

                    var
                    data = f_10040_53214_53240(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 53259, 53322);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10040, 53266, 53280) || (((data == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10040, 53283, 53309)) || DynAbs.Tracing.TraceSender.Conditional_F3(10040, 53312, 53321))) ? ObsoleteAttributeKind.None : data.Kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 53167, 53337);

                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10040_53214_53240(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 53214, 53240);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 53099, 53348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 53099, 53348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract ObsoleteAttributeData ObsoleteAttributeData { get; }

        internal bool GetGuidStringDefaultImplementation(out string guidString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 54111, 54644);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 54207, 54572);
                    foreach (var attrData in f_10040_54232_54252_I(f_10040_54232_54252(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 54207, 54572);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 54286, 54557) || true) && (f_10040_54290_54358(attrData, this, AttributeDescription.GuidAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 54286, 54557);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 54400, 54538) || true) && (f_10040_54404_54453(attrData, out guidString))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 54400, 54538);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 54503, 54515);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 54400, 54538);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 54286, 54557);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 54207, 54572);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 366);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 54588, 54606);

                guidString = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 54620, 54633);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 54111, 54644);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10040_54232_54252(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 54232, 54252);
                    return return_v;
                }


                bool
                f_10040_54290_54358(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 54290, 54358);
                    return return_v;
                }


                bool
                f_10040_54404_54453(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attrData, out string
                guidString)
                {
                    var return_v = attrData.TryGetGuidAttributeValue(out guidString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 54404, 54453);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10040_54232_54252_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 54232, 54252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 54111, 54644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 54111, 54644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToDisplayString(SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 54656, 54810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 54745, 54799);

                return f_10040_54752_54798(f_10040_54782_54789(), format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 54656, 54810);

                Microsoft.CodeAnalysis.ISymbol
                f_10040_54782_54789()
                {
                    var return_v = ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 54782, 54789);
                    return return_v;
                }


                string
                f_10040_54752_54798(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayString(symbol, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 54752, 54798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 54656, 54810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 54656, 54810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<SymbolDisplayPart> ToDisplayParts(SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 54822, 55001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 54937, 54990);

                return f_10040_54944_54989(f_10040_54973_54980(), format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 54822, 55001);

                Microsoft.CodeAnalysis.ISymbol
                f_10040_54973_54980()
                {
                    var return_v = ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 54973, 54980);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10040_54944_54989(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayParts(symbol, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 54944, 54989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 54822, 55001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 54822, 55001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToMinimalDisplayString(
                    SemanticModel semanticModel,
                    int position,
                    SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 55013, 55289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 55192, 55278);

                return f_10040_55199_55277(f_10040_55236_55243(), semanticModel, position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 55013, 55289);

                Microsoft.CodeAnalysis.ISymbol
                f_10040_55236_55243()
                {
                    var return_v = ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 55236, 55243);
                    return return_v;
                }


                string
                f_10040_55199_55277(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayString(symbol, semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 55199, 55277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 55013, 55289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 55013, 55289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(
                    SemanticModel semanticModel,
                    int position,
                    SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 55301, 55602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 55506, 55591);

                return f_10040_55513_55590(f_10040_55549_55556(), semanticModel, position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 55301, 55602);

                Microsoft.CodeAnalysis.ISymbol
                f_10040_55549_55556()
                {
                    var return_v = ISymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 55549, 55556);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10040_55513_55590(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat?
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayParts(symbol, semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 55513, 55590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 55301, 55602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 55301, 55602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ReportErrorIfHasConstraints(
                    SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 55614, 56044);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 55795, 56033) || true) && (constraintClauses.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 55795, 56033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 55860, 56018);

                    f_10040_55860_56017(diagnostics, ErrorCode.ERR_ConstraintOnlyAllowedOnGenericDecl, constraintClauses[0].WhereKeyword.GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 55795, 56033);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 55614, 56044);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10040_55860_56017(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 55860, 56017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 55614, 56044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 55614, 56044);
            }
        }

        internal static void CheckForBlockAndExpressionBody(
                    CSharpSyntaxNode block,
                    CSharpSyntaxNode expression,
                    CSharpSyntaxNode syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 56056, 56469);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 56290, 56458) || true) && (block != null && (DynAbs.Tracing.TraceSender.Expression_True(10040, 56294, 56329) && expression != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 56290, 56458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 56363, 56443);

                    f_10040_56363_56442(diagnostics, ErrorCode.ERR_BlockBodyAndExpressionBody, f_10040_56421_56441(syntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 56290, 56458);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 56056, 56469);

                Microsoft.CodeAnalysis.Location
                f_10040_56421_56441(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 56421, 56441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10040_56363_56442(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 56363, 56442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 56056, 56469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 56056, 56469);
            }
        }

        [Flags]
        internal enum ReservedAttributes
        {
            DynamicAttribute = 1 << 1,
            IsReadOnlyAttribute = 1 << 2,
            IsUnmanagedAttribute = 1 << 3,
            IsByRefLikeAttribute = 1 << 4,
            TupleElementNamesAttribute = 1 << 5,
            NullableAttribute = 1 << 6,
            NullableContextAttribute = 1 << 7,
            NullablePublicOnlyAttribute = 1 << 8,
            NativeIntegerAttribute = 1 << 9,
            CaseSensitiveExtensionAttribute = 1 << 10,
        }

        internal bool ReportExplicitUseOfReservedAttributes(in DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments, ReservedAttributes reserved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 57027, 61043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 57237, 57273);

                var
                attribute = arguments.Attribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 57287, 60316) || true) && ((reserved & ReservedAttributes.DynamicAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 57291, 57437) && f_10040_57365_57437(attribute, this, AttributeDescription.DynamicAttribute)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 57287, 60316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 57538, 57638);

                    f_10040_57538_57637(                // DynamicAttribute should not be set explicitly.
                                    arguments.Diagnostics, ErrorCode.ERR_ExplicitDynamicAttr, f_10040_57599_57636(arguments.AttributeSyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 57287, 60316);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 57287, 60316);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 57672, 60316) || true) && ((reserved & ReservedAttributes.IsReadOnlyAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 57676, 57853) && f_10040_57753_57853(attribute, arguments, AttributeDescription.IsReadOnlyAttribute)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 57672, 60316);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 57672, 60316);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 57672, 60316);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 57903, 60316) || true) && ((reserved & ReservedAttributes.IsUnmanagedAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 57907, 58086) && f_10040_57985_58086(attribute, arguments, AttributeDescription.IsUnmanagedAttribute)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 57903, 60316);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 57903, 60316);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 57903, 60316);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 58136, 60316) || true) && ((reserved & ReservedAttributes.IsByRefLikeAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 58140, 58319) && f_10040_58218_58319(attribute, arguments, AttributeDescription.IsByRefLikeAttribute)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 58136, 60316);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 58136, 60316);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 58136, 60316);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 58369, 60316) || true) && ((reserved & ReservedAttributes.TupleElementNamesAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 58373, 58539) && f_10040_58457_58539(attribute, this, AttributeDescription.TupleElementNamesAttribute)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 58369, 60316);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 58573, 58688);

                                    f_10040_58573_58687(arguments.Diagnostics, ErrorCode.ERR_ExplicitTupleElementNamesAttribute, f_10040_58649_58686(arguments.AttributeSyntaxOpt));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 58369, 60316);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 58369, 60316);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 58722, 60316) || true) && ((reserved & ReservedAttributes.NullableAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 58726, 58874) && f_10040_58801_58874(attribute, this, AttributeDescription.NullableAttribute)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 58722, 60316);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 58976, 59082);

                                        f_10040_58976_59081(                // NullableAttribute should not be set explicitly.
                                                        arguments.Diagnostics, ErrorCode.ERR_ExplicitNullableAttribute, f_10040_59043_59080(arguments.AttributeSyntaxOpt));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 58722, 60316);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 58722, 60316);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 59116, 60316) || true) && ((reserved & ReservedAttributes.NullableContextAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 59120, 59307) && f_10040_59202_59307(attribute, arguments, AttributeDescription.NullableContextAttribute)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 59116, 60316);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 59116, 60316);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 59116, 60316);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 59357, 60316) || true) && ((reserved & ReservedAttributes.NullablePublicOnlyAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 59361, 59554) && f_10040_59446_59554(attribute, arguments, AttributeDescription.NullablePublicOnlyAttribute)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 59357, 60316);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 59357, 60316);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 59357, 60316);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 59604, 60316) || true) && ((reserved & ReservedAttributes.NativeIntegerAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 59608, 59791) && f_10040_59688_59791(attribute, arguments, AttributeDescription.NativeIntegerAttribute)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 59604, 60316);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 59604, 60316);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 59604, 60316);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 59841, 60316) || true) && ((reserved & ReservedAttributes.CaseSensitiveExtensionAttribute) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10040, 59845, 60021) && f_10040_59934_60021(attribute, this, AttributeDescription.CaseSensitiveExtensionAttribute)))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 59841, 60316);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 60124, 60222);

                                                        f_10040_60124_60221(                // ExtensionAttribute should not be set explicitly.
                                                                        arguments.Diagnostics, ErrorCode.ERR_ExplicitExtension, f_10040_60183_60220(arguments.AttributeSyntaxOpt));
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 59841, 60316);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 59841, 60316);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 60288, 60301);

                                                        return false;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 59841, 60316);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 59604, 60316);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 59357, 60316);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 59116, 60316);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 58722, 60316);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 58369, 60316);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 58136, 60316);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 57903, 60316);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 57672, 60316);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 57287, 60316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 60330, 60342);

                return true;

                bool reportExplicitUseOfReservedAttribute(CSharpAttributeData attribute, in DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments, in AttributeDescription attributeDescription)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 60358, 61032);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 60614, 60986) || true) && (f_10040_60618_60673(attribute, this, attributeDescription))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 60614, 60986);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 60801, 60933);

                            f_10040_60801_60932(                    // Do not use '{FullName}'. This is reserved for compiler usage.
                                                arguments.Diagnostics, ErrorCode.ERR_ExplicitReservedAttr, f_10040_60863_60900(arguments.AttributeSyntaxOpt), attributeDescription.FullName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 60955, 60967);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 60614, 60986);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 61004, 61017);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 60358, 61032);

                        bool
                        f_10040_60618_60673(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                        description)
                        {
                            var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 60618, 60673);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10040_60863_60900(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 60863, 60900);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10040_60801_60932(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 60801, 60932);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 60358, 61032);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 60358, 61032);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 57027, 61043);

                bool
                f_10040_57365_57437(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 57365, 57437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10040_57599_57636(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 57599, 57636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10040_57538_57637(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 57538, 57637);
                    return return_v;
                }


                bool
                f_10040_57753_57853(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.AttributeDescription
                attributeDescription)
                {
                    var return_v = reportExplicitUseOfReservedAttribute(attribute, arguments, attributeDescription);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 57753, 57853);
                    return return_v;
                }


                bool
                f_10040_57985_58086(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.AttributeDescription
                attributeDescription)
                {
                    var return_v = reportExplicitUseOfReservedAttribute(attribute, arguments, attributeDescription);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 57985, 58086);
                    return return_v;
                }


                bool
                f_10040_58218_58319(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.AttributeDescription
                attributeDescription)
                {
                    var return_v = reportExplicitUseOfReservedAttribute(attribute, arguments, attributeDescription);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 58218, 58319);
                    return return_v;
                }


                bool
                f_10040_58457_58539(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 58457, 58539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10040_58649_58686(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 58649, 58686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10040_58573_58687(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 58573, 58687);
                    return return_v;
                }


                bool
                f_10040_58801_58874(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 58801, 58874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10040_59043_59080(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 59043, 59080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10040_58976_59081(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 58976, 59081);
                    return return_v;
                }


                bool
                f_10040_59202_59307(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.AttributeDescription
                attributeDescription)
                {
                    var return_v = reportExplicitUseOfReservedAttribute(attribute, arguments, attributeDescription);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 59202, 59307);
                    return return_v;
                }


                bool
                f_10040_59446_59554(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.AttributeDescription
                attributeDescription)
                {
                    var return_v = reportExplicitUseOfReservedAttribute(attribute, arguments, attributeDescription);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 59446, 59554);
                    return return_v;
                }


                bool
                f_10040_59688_59791(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.AttributeDescription
                attributeDescription)
                {
                    var return_v = reportExplicitUseOfReservedAttribute(attribute, arguments, attributeDescription);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 59688, 59791);
                    return return_v;
                }


                bool
                f_10040_59934_60021(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 59934, 60021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10040_60183_60220(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 60183, 60220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10040_60124_60221(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 60124, 60221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 57027, 61043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 57027, 61043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual byte? GetNullableContextValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 61055, 61224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 61128, 61213);

                return f_10040_61135_61165(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<byte?>(10040, 61135, 61212) ?? f_10040_61169_61212_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10040_61169_61185(), 10040, 61169, 61212)?.GetNullableContextValue()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 61055, 61224);

                byte?
                f_10040_61135_61165(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetLocalNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 61135, 61165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10040_61169_61185()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 61169, 61185);
                    return return_v;
                }


                byte?
                f_10040_61169_61212_I(byte?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 61169, 61212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 61055, 61224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 61055, 61224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual byte? GetLocalNullableContextValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 61236, 61337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 61314, 61326);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 61236, 61337);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 61236, 61337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 61236, 61337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GetCommonNullableValues(CSharpCompilation compilation, ref MostCommonNullableValueBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 61349, 63887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 61486, 63876);

                switch (f_10040_61494_61503(this))
                {

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 61486, 63876);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 61585, 61762) || true) && (f_10040_61589_61635(compilation, this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 61585, 61762);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 61685, 61739);

                            builder.AddValue(f_10040_61702_61737(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 61585, 61762);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10040, 61784, 61790);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 61486, 63876);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 61486, 63876);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 61852, 62033) || true) && (f_10040_61856_61902(compilation, this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 61852, 62033);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 61952, 62010);

                            builder.AddValue(f_10040_61969_62008(((EventSymbol)this)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 61852, 62033);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10040, 62055, 62061);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 61486, 63876);

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 61486, 63876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 62123, 62153);

                        var
                        field = (FieldSymbol)this
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 62175, 62339) || true) && (field is TupleElementFieldSymbol tupleElement)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 62175, 62339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 62274, 62316);

                            field = f_10040_62282_62315(tupleElement);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 62175, 62339);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 62363, 62531) || true) && (f_10040_62367_62414(compilation, field))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 62363, 62531);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 62464, 62508);

                            builder.AddValue(f_10040_62481_62506(field));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 62363, 62531);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10040, 62553, 62559);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 61486, 63876);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 61486, 63876);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 62622, 62799) || true) && (f_10040_62626_62672(compilation, this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 62622, 62799);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 62722, 62776);

                            builder.AddValue(f_10040_62739_62774(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 62622, 62799);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10040, 62821, 62827);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 61486, 63876);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 61486, 63876);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 62892, 63156) || true) && (f_10040_62896_62942(compilation, this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 62892, 63156);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 62992, 63053);

                            builder.AddValue(f_10040_63009_63051(((PropertySymbol)this)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 62892, 63156);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10040, 63178, 63184);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 61486, 63876);

                    case SymbolKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 61486, 63876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 63250, 63312);

                        builder.AddValue(f_10040_63267_63310(((ParameterSymbol)this)));
                        DynAbs.Tracing.TraceSender.TraceBreak(10040, 63334, 63340);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 61486, 63876);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 61486, 63876);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 63410, 63833) || true) && (this is SourceTypeParameterSymbolBase typeParameter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 63410, 63833);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 63515, 63586);

                            builder.AddValue(f_10040_63532_63584(typeParameter));
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 63612, 63810);
                                foreach (var constraintType in f_10040_63643_63692_I(f_10040_63643_63692(typeParameter)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 63612, 63810);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 63750, 63783);

                                    builder.AddValue(constraintType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 63612, 63810);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 199);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 199);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 63410, 63833);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10040, 63855, 63861);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 61486, 63876);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 61349, 63887);

                Microsoft.CodeAnalysis.SymbolKind
                f_10040_61494_61503(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 61494, 61503);
                    return return_v;
                }


                bool
                f_10040_61589_61635(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 61589, 61635);
                    return return_v;
                }


                byte?
                f_10040_61702_61737(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetLocalNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 61702, 61737);
                    return return_v;
                }


                bool
                f_10040_61856_61902(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 61856, 61902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10040_61969_62008(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 61969, 62008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10040_62282_62315(Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol
                this_param)
                {
                    var return_v = this_param.TupleUnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 62282, 62315);
                    return return_v;
                }


                bool
                f_10040_62367_62414(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 62367, 62414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10040_62481_62506(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 62481, 62506);
                    return return_v;
                }


                bool
                f_10040_62626_62672(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 62626, 62672);
                    return return_v;
                }


                byte?
                f_10040_62739_62774(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetLocalNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 62739, 62774);
                    return return_v;
                }


                bool
                f_10040_62896_62942(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 62896, 62942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10040_63009_63051(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 63009, 63051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10040_63267_63310(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 63267, 63310);
                    return return_v;
                }


                byte
                f_10040_63532_63584(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.GetSynthesizedNullableAttributeValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 63532, 63584);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10040_63643_63692(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 63643, 63692);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10040_63643_63692_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 63643, 63692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 61349, 63887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 61349, 63887);
            }
        }

        internal bool ShouldEmitNullableContextValue(out byte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 63899, 64358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 63984, 64034);

                byte?
                localValue = f_10040_64003_64033(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 64048, 64160) || true) && (localValue == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 64048, 64160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 64104, 64114);

                    value = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 64132, 64145);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 64048, 64160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 64176, 64215);

                value = f_10040_64184_64214(localValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 64229, 64301);

                byte
                containingValue = f_10040_64252_64295_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10040_64252_64268(), 10040, 64252, 64295)?.GetNullableContextValue()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<byte?>(10040, 64252, 64300) ?? 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 64315, 64347);

                return value != containingValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 63899, 64358);

                byte?
                f_10040_64003_64033(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetLocalNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 64003, 64033);
                    return return_v;
                }


                byte
                f_10040_64184_64214(byte?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 64184, 64214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10040_64252_64268()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 64252, 64268);
                    return return_v;
                }


                byte?
                f_10040_64252_64295_I(byte?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 64252, 64295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 63899, 64358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 63899, 64358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsCaptured(Symbol variable, SourceMethodSymbol containingSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10040, 64520, 66640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 64630, 66024);

                switch (f_10040_64638_64651(variable))
                {

                    case SymbolKind.Field:
                    case SymbolKind.Property:
                    case SymbolKind.Event:
                    // Range variables are not captured, but their underlying parameters
                    // may be. If this is a range underlying parameter it will be a
                    // ParameterSymbol, not a RangeVariableSymbol.
                    case SymbolKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 64630, 66024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 65091, 65104);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 64630, 66024);

                    case SymbolKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 64630, 66024);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 65168, 65289) || true) && (f_10040_65172_65203(((LocalSymbol)variable)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 65168, 65289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 65253, 65266);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 65168, 65289);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10040, 65311, 65317);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 64630, 66024);

                    case SymbolKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 64630, 66024);
                        DynAbs.Tracing.TraceSender.TraceBreak(10040, 65385, 65391);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 64630, 66024);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 64630, 66024);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 65456, 65828) || true) && (variable is LocalFunctionSymbol localFunction)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 65456, 65828);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 65647, 65771) || true) && (f_10040_65651_65673(localFunction))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 65647, 65771);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 65731, 65744);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 65647, 65771);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10040, 65799, 65805);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 65456, 65828);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 65852, 65903);

                        throw f_10040_65858_65902(variable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 64630, 66024);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 64630, 66024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 65953, 66009);

                        throw f_10040_65959_66008(f_10040_65994_66007(variable));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 64630, 66024);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 66260, 66303);

                    // Walk up the containing symbols until we find the target function, in which
                    // case the variable is not captured by the target function, or null, in which
                    // case it is.
                    for (var
        currentFunction = f_10040_66278_66303(variable)
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 66251, 66601) || true) && ((object)currentFunction != null)
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 66374, 66424)
        , currentFunction = f_10040_66392_66424(currentFunction), DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 66251, 66601))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 66251, 66601);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 66458, 66586) || true) && (f_10040_66462_66512(currentFunction, containingSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 66458, 66586);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 66554, 66567);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 66458, 66586);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10040, 1, 351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10040, 1, 351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 66617, 66629);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10040, 64520, 66640);

                Microsoft.CodeAnalysis.SymbolKind
                f_10040_64638_64651(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 64638, 64651);
                    return return_v;
                }


                bool
                f_10040_65172_65203(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 65172, 65203);
                    return return_v;
                }


                bool
                f_10040_65651_65673(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 65651, 65673);
                    return return_v;
                }


                System.Exception
                f_10040_65858_65902(Microsoft.CodeAnalysis.CSharp.Symbol
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 65858, 65902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10040_65994_66007(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 65994, 66007);
                    return return_v;
                }


                System.Exception
                f_10040_65959_66008(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 65959, 66008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10040_66278_66303(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 66278, 66303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10040_66392_66424(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 66392, 66424);
                    return return_v;
                }


                bool
                f_10040_66462_66512(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 66462, 66512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 64520, 66640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 64520, 66640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ISymbolInternal.IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 66706, 66735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 66712, 66733);

                    return f_10040_66719_66732(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 66706, 66735);

                    bool
                    f_10040_66719_66732(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 66719, 66732);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 66652, 66746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 66652, 66746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbolInternal.IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 66813, 66843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 66819, 66841);

                    return f_10040_66826_66840(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 66813, 66843);

                    bool
                    f_10040_66826_66840(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 66826, 66840);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 66758, 66854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 66758, 66854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbolInternal.IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 66922, 66953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 66928, 66951);

                    return f_10040_66935_66950(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 66922, 66953);

                    bool
                    f_10040_66935_66950(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 66935, 66950);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 66866, 66964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 66866, 66964);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbolInternal.IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 67032, 67106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 67068, 67091);

                    return f_10040_67075_67090(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 67032, 67106);

                    bool
                    f_10040_67075_67090(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 67075, 67090);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 66976, 67117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 66976, 67117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Accessibility ISymbolInternal.DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 67205, 67290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 67241, 67275);

                    return f_10040_67248_67274(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 67205, 67290);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10040_67248_67274(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 67248, 67274);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 67129, 67301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 67129, 67301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract void Accept(CSharpSymbolVisitor visitor);

        public abstract TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor);

        string IFormattable.ToString(string format, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 67472, 67601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 67572, 67590);

                return f_10040_67579_67589(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 67472, 67601);

                string
                f_10040_67579_67589(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 67579, 67589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 67472, 67601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 67472, 67601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ISymbol CreateISymbol();

        internal ISymbol ISymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10040, 67717, 67962);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 67753, 67907) || true) && (_lazyISymbol is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10040, 67753, 67907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 67819, 67888);

                        f_10040_67819_67887(ref _lazyISymbol, f_10040_67865_67880(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10040, 67753, 67907);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 67927, 67947);

                    return _lazyISymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10040, 67717, 67962);

                    Microsoft.CodeAnalysis.ISymbol
                    f_10040_67865_67880(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.CreateISymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 67865, 67880);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol?
                    f_10040_67819_67887(ref Microsoft.CodeAnalysis.ISymbol?
                    location1, Microsoft.CodeAnalysis.ISymbol
                    value, Microsoft.CodeAnalysis.ISymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 67819, 67887);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10040, 67668, 67973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10040, 67668, 67973);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10040_7924_7944()
        {
            var return_v = DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 7924, 7944);
            return return_v;
        }


        string
        f_10040_7988_7997(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 7988, 7997);
            return return_v;
        }


        string
        f_10040_8049_8066(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.MetadataName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 8049, 8066);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10040_8131_8152(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 8131, 8152);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        f_10040_8223_8244(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingModule;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 8223, 8244);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10040_8319_8342(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 8319, 8342);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10040_8409_8423(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 8409, 8423);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_10040_8500_8524(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 8500, 8524);
            return return_v;
        }


        bool
        f_10040_8582_8607(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.IsImplicitlyDeclared;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10040, 8582, 8607);
            return return_v;
        }

    }
}
