// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class MergedNamespaceSymbol : NamespaceSymbol
    {
        private readonly NamespaceExtent _extent;

        private readonly ImmutableArray<NamespaceSymbol> _namespacesToMerge;

        private readonly NamespaceSymbol _containingNamespace;

        private readonly string _nameOpt;

        private readonly CachingDictionary<string, Symbol> _cachedLookup;

        private ImmutableArray<Symbol> _allMembers;

        internal static NamespaceSymbol Create(
                    NamespaceExtent extent,
                    NamespaceSymbol containingNamespace,
                    ImmutableArray<NamespaceSymbol> namespacesToMerge,
                    string nameOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10117, 3388, 4855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 4584, 4628);

                f_10117_4584_4627(namespacesToMerge.Length != 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 4644, 4844);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10117, 4651, 4701) || (((namespacesToMerge.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10117, 4652, 4700) && nameOpt == null))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10117, 4721, 4741)) || DynAbs.Tracing.TraceSender.Conditional_F3(10117, 4761, 4843))) ? namespacesToMerge[0]
                : f_10117_4761_4843(extent, containingNamespace, namespacesToMerge, nameOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10117, 3388, 4855);

                int
                f_10117_4584_4627(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 4584, 4627);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MergedNamespaceSymbol
                f_10117_4761_4843(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                extent, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                containingNamespace, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                namespacesToMerge, string?
                nameOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MergedNamespaceSymbol(extent, containingNamespace, namespacesToMerge, nameOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 4761, 4843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 3388, 4855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 3388, 4855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MergedNamespaceSymbol(NamespaceExtent extent, NamespaceSymbol containingNamespace, ImmutableArray<NamespaceSymbol> namespacesToMerge, string nameOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10117, 4938, 5690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 1708, 1728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 1860, 1868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 2157, 2170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 5120, 5137);

                _extent = extent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 5151, 5190);

                _namespacesToMerge = namespacesToMerge;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 5204, 5247);

                _containingNamespace = containingNamespace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 5261, 5391);

                _cachedLookup = f_10117_5277_5390(SlowGetChildrenOfName, SlowGetChildNames, f_10117_5357_5389());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 5405, 5424);

                _nameOpt = nameOpt;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 5523, 5671);
                    foreach (NamespaceSymbol ns in f_10117_5554_5571_I(namespacesToMerge))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 5523, 5671);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 5605, 5656);

                        f_10117_5605_5655(ns.ConstituentNamespaces.Length == 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 5523, 5671);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10117, 1, 149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10117, 1, 149);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10117, 4938, 5690);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 4938, 5690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 4938, 5690);
            }
        }

        internal NamespaceSymbol GetConstituentForCompilation(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 5702, 6177);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 5985, 6138);
                    foreach (var n in f_10117_6003_6021_I(_namespacesToMerge))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 5985, 6138);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 6055, 6123) || true) && (f_10117_6059_6091(n, compilation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 6055, 6123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 6114, 6123);

                            return n;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 6055, 6123);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 5985, 6138);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10117, 1, 154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10117, 1, 154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 6154, 6166);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 5702, 6177);

                bool
                f_10117_6059_6091(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsFromCompilation(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 6059, 6091);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10117_6003_6021_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 6003, 6021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 5702, 6177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 5702, 6177);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            foreach (var part in _namespacesToMerge)
            {
                cancellationToken.ThrowIfCancellationRequested();
                part.ForceComplete(locationOpt, cancellationToken);
            }
        }

        private ImmutableArray<Symbol> SlowGetChildrenOfName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 6743, 7936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 6833, 6887);

                ArrayBuilder<NamespaceSymbol>
                namespaceSymbols = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 6901, 6955);

                var
                otherSymbols = f_10117_6920_6954()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 7034, 7674);
                    foreach (NamespaceSymbol namespaceSymbol in f_10117_7078_7096_I(_namespacesToMerge))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 7034, 7674);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 7130, 7659);
                            foreach (Symbol childSymbol in f_10117_7161_7193_I(f_10117_7161_7193(namespaceSymbol, name)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 7130, 7659);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 7235, 7640) || true) && (f_10117_7239_7255(childSymbol) == SymbolKind.Namespace)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 7235, 7640);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 7329, 7412);

                                    namespaceSymbols = namespaceSymbols ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>?>(10117, 7348, 7411) ?? f_10117_7368_7411());
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 7438, 7489);

                                    f_10117_7438_7488(namespaceSymbols, childSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 7235, 7640);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 7235, 7640);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 7587, 7617);

                                    f_10117_7587_7616(otherSymbols, childSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 7235, 7640);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 7130, 7659);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10117, 1, 530);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10117, 1, 530);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 7034, 7674);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10117, 1, 641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10117, 1, 641);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 7690, 7868) || true) && (namespaceSymbols != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 7690, 7868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 7752, 7853);

                    f_10117_7752_7852(otherSymbols, f_10117_7769_7851(_extent, this, f_10117_7813_7850(namespaceSymbols)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 7690, 7868);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 7884, 7925);

                return f_10117_7891_7924(otherSymbols);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 6743, 7936);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_6920_6954()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 6920, 6954);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_7161_7193(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7161, 7193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10117_7239_7255(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10117, 7239, 7255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10117_7368_7411()
                {
                    var return_v = ArrayBuilder<NamespaceSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7368, 7411);
                    return return_v;
                }


                int
                f_10117_7438_7488(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7438, 7488);
                    return 0;
                }


                int
                f_10117_7587_7616(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7587, 7616);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_7161_7193_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7161, 7193);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10117_7078_7096_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7078, 7096);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10117_7813_7850(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7813, 7850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10117_7769_7851(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                extent, Microsoft.CodeAnalysis.CSharp.Symbols.MergedNamespaceSymbol
                containingNamespace, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                namespacesToMerge)
                {
                    var return_v = MergedNamespaceSymbol.Create(extent, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)containingNamespace, namespacesToMerge);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7769, 7851);
                    return return_v;
                }


                int
                f_10117_7752_7852(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7752, 7852);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_7891_7924(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 7891, 7924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 6743, 7936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 6743, 7936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HashSet<string> SlowGetChildNames(IEqualityComparer<string> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 8127, 8557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 8229, 8276);

                var
                childNames = f_10117_8246_8275(comparer)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 8292, 8512);
                    foreach (var ns in f_10117_8311_8329_I(_namespacesToMerge))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 8292, 8512);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 8363, 8497);
                            foreach (var child in f_10117_8385_8409_I(f_10117_8385_8409(ns)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 8363, 8497);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 8451, 8478);

                                f_10117_8451_8477(childNames, f_10117_8466_8476(child));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 8363, 8497);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10117, 1, 135);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10117, 1, 135);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 8292, 8512);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10117, 1, 221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10117, 1, 221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 8528, 8546);

                return childNames;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 8127, 8557);

                System.Collections.Generic.HashSet<string>
                f_10117_8246_8275(System.Collections.Generic.IEqualityComparer<string>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 8246, 8275);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_8385_8409(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 8385, 8409);
                    return return_v;
                }


                string
                f_10117_8466_8476(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10117, 8466, 8476);
                    return return_v;
                }


                bool
                f_10117_8451_8477(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 8451, 8477);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_8385_8409_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 8385, 8409);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10117_8311_8329_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 8311, 8329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 8127, 8557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 8127, 8557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 8621, 8718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 8657, 8703);

                    return _nameOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10117, 8664, 8702) ?? f_10117_8676_8702(_namespacesToMerge[0]));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 8621, 8718);

                    string
                    f_10117_8676_8702(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10117, 8676, 8702);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 8569, 8729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 8569, 8729);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 8806, 8872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 8842, 8857);

                    return _extent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 8806, 8872);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 8741, 8883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 8741, 8883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<NamespaceSymbol> ConstituentNamespaces
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 8989, 9066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 9025, 9051);

                    return _namespacesToMerge;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 8989, 9066);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 8895, 9077);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 8895, 9077);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 9089, 9523);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 9242, 9477) || true) && (_allMembers.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 9242, 9477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 9301, 9350);

                    var
                    builder = f_10117_9315_9349()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 9368, 9401);

                    f_10117_9368_9400(_cachedLookup, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 9419, 9462);

                    _allMembers = f_10117_9433_9461(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 9242, 9477);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 9493, 9512);

                return _allMembers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 9089, 9523);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_9315_9349()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 9315, 9349);
                    return return_v;
                }


                int
                f_10117_9368_9400(Microsoft.CodeAnalysis.Collections.CachingDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                array)
                {
                    this_param.AddValues(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 9368, 9400);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_9433_9461(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 9433, 9461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 9089, 9523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 9089, 9523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 9535, 9660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 9622, 9649);

                return f_10117_9629_9648(_cachedLookup, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 9535, 9660);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_9629_9648(Microsoft.CodeAnalysis.Collections.CachingDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10117, 9629, 9648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 9535, 9660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 9535, 9660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 9672, 9890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 9779, 9879);

                return f_10117_9786_9878(f_10117_9830_9851(this).OfType<NamedTypeSymbol>());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 9672, 9890);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_9830_9851(Microsoft.CodeAnalysis.CSharp.Symbols.MergedNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 9830, 9851);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10117_9786_9878(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                items)
                {
                    var return_v = ImmutableArray.CreateRange<NamedTypeSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 9786, 9878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 9672, 9890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 9672, 9890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 9902, 10100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 9998, 10089);

                return f_10117_10005_10088(f_10117_10049_10061(this).OfType<NamedTypeSymbol>());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 9902, 10100);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10117_10049_10061(Microsoft.CodeAnalysis.CSharp.Symbols.MergedNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 10049, 10061);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10117_10005_10088(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                items)
                {
                    var return_v = ImmutableArray.CreateRange<NamedTypeSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 10005, 10088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 9902, 10100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 9902, 10100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 10112, 10424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 10315, 10413);

                return f_10117_10322_10412(_cachedLookup[name].OfType<NamedTypeSymbol>());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 10112, 10424);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10117_10322_10412(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                items)
                {
                    var return_v = ImmutableArray.CreateRange<NamedTypeSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 10322, 10412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 10112, 10424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 10112, 10424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 10500, 10579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 10536, 10564);

                    return _containingNamespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 10500, 10579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 10436, 10590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 10436, 10590);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 10676, 11113);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 10712, 11098) || true) && (_extent.Kind == NamespaceKind.Module)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 10712, 11098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 10794, 10835);

                        return f_10117_10801_10834(_extent.Module);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 10712, 11098);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 10712, 11098);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 10877, 11098) || true) && (_extent.Kind == NamespaceKind.Assembly)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 10877, 11098);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 10961, 10985);

                            return _extent.Assembly;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 10877, 11098);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 10877, 11098);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 11067, 11079);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 10877, 11098);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 10712, 11098);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 10676, 11113);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10117_10801_10834(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10117, 10801, 10834);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 10602, 11124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 10602, 11124);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 11278, 11457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 11345, 11442);

                    // LAFHIS
                    //return f_10117_11352_11441(f_10117_11352_11427(_namespacesToMerge, namespaceSymbol => namespaceSymbol.Locations));

                    var temp1 = _namespacesToMerge.SelectMany<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.Location>(namespaceSymbol => namespaceSymbol.Locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 11352, 11427);

                    var temp2 = temp1.AsImmutable<Microsoft.CodeAnalysis.Location>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 11352, 11441);

                    return temp2;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 11278, 11457);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>
                    f_10117_11352_11427(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                    source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>>
                    selector)
                    {
                        var return_v = source.SelectMany<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.Location>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 11352, 11427);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10117_11352_11441(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>
                    items)
                    {
                        var return_v = items.AsImmutable<Microsoft.CodeAnalysis.Location>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 11352, 11441);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 11136, 11468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 11136, 11468);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 11578, 11742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 11614, 11727);

                    // LAFHIS
                    //return f_10117_11621_11726(f_10117_11621_11712(_namespacesToMerge, namespaceSymbol => namespaceSymbol.DeclaringSyntaxReferences));

                    var temp1 = _namespacesToMerge.SelectMany<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.SyntaxReference>(namespaceSymbol => namespaceSymbol.DeclaringSyntaxReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 11621, 11712);

                    var temp2 = temp1.AsImmutable<Microsoft.CodeAnalysis.SyntaxReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 11621, 11726);

                    return temp2;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 11578, 11742);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10117_11621_11712(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                    source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxReference>>
                    selector)
                    {
                        var return_v = source.SelectMany<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.SyntaxReference>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 11621, 11712);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10117_11621_11726(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxReference>
                    items)
                    {
                        var return_v = items.AsImmutable<Microsoft.CodeAnalysis.SyntaxReference>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 11621, 11726);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 11480, 11753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 11480, 11753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void GetExtensionMethods(ArrayBuilder<MethodSymbol> methods, string name, int arity, LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10117, 11765, 12104);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 11915, 12093);
                    foreach (NamespaceSymbol namespaceSymbol in f_10117_11959_11977_I(_namespacesToMerge))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10117, 11915, 12093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10117, 12011, 12078);

                        f_10117_12011_12077(namespaceSymbol, methods, name, arity, options);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10117, 11915, 12093);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10117, 1, 179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10117, 1, 179);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10117, 11765, 12104);

                int
                f_10117_12011_12077(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, string
                nameOpt, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    this_param.GetExtensionMethods(methods, nameOpt, arity, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 12011, 12077);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10117_11959_11977_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 11959, 11977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10117, 11765, 12104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 11765, 12104);
            }
        }

        static MergedNamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10117, 1468, 12111);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10117, 1468, 12111);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10117, 1468, 12111);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10117, 1468, 12111);

        System.Collections.Generic.EqualityComparer<string>
        f_10117_5357_5389()
        {
            var return_v = EqualityComparer<string>.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10117, 5357, 5389);
            return return_v;
        }


        Microsoft.CodeAnalysis.Collections.CachingDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10117_5277_5390(System.Func<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>>
        getElementsOfKey, System.Func<System.Collections.Generic.IEqualityComparer<string>, System.Collections.Generic.HashSet<string>>
        getKeys, System.Collections.Generic.EqualityComparer<string>
        comparer)
        {
            var return_v = new Microsoft.CodeAnalysis.Collections.CachingDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>(getElementsOfKey, getKeys, (System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 5277, 5390);
            return return_v;
        }


        int
        f_10117_5605_5655(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 5605, 5655);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
        f_10117_5554_5571_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10117, 5554, 5571);
            return return_v;
        }

    }
}
