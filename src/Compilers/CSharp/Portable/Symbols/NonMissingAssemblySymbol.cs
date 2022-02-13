// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class NonMissingAssemblySymbol : AssemblySymbol
    {
        private readonly ConcurrentDictionary<MetadataTypeName.Key, NamedTypeSymbol> _emittedNameToTypeMap;

        private NamespaceSymbol _globalNamespace;

        internal sealed override bool IsMissing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10130, 1885, 1949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 1921, 1934);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10130, 1885, 1949);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10130, 1821, 1960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10130, 1821, 1960);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override NamespaceSymbol GlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10130, 2358, 3180);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 2394, 3121) || true) && ((object)_globalNamespace == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 2394, 3121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 2676, 2770);

                        IEnumerable<NamespaceSymbol>
                        allGlobalNamespaces = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from m in Modules select m.GlobalNamespace, 10130, 2727, 2769)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 2792, 3016);

                        var
                        result = f_10130_2805_3015(f_10130_2834_2859(this), null, f_10130_2981_3014(allGlobalNamespaces))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 3038, 3102);

                        f_10130_3038_3101(ref _globalNamespace, result, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 2394, 3121);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 3141, 3165);

                    return _globalNamespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10130, 2358, 3180);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                    f_10130_2834_2859(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingAssemblySymbol
                    assembly)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)assembly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 2834, 2859);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                    f_10130_2981_3014(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                    items)
                    {
                        var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 2981, 3014);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10130_2805_3015(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                    extent, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    containingNamespace, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                    namespacesToMerge)
                    {
                        var return_v = MergedNamespaceSymbol.Create(extent, containingNamespace, namespacesToMerge);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 2805, 3015);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                    f_10130_3038_3101(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 3038, 3101);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10130, 2279, 3191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10130, 2279, 3191);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override NamedTypeSymbol LookupTopLevelMetadataTypeWithCycleDetection(ref MetadataTypeName emittedName, ConsList<AssemblySymbol> visitedAssemblies, bool digThroughForwardedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10130, 3823, 8391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 4042, 4072);

                NamedTypeSymbol
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 5467, 5527);

                result = f_10130_5476_5526(this, ref emittedName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 5543, 8380) || true) && ((object)result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 5543, 8380);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 5874, 6057) || true) && (digThroughForwardedTypes || (DynAbs.Tracing.TraceSender.Expression_False(10130, 5878, 5982) || (!f_10130_5908_5928(result) && (DynAbs.Tracing.TraceSender.Expression_True(10130, 5907, 5981) && (object)f_10130_5940_5965(result) == (object)this))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 5874, 6057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6024, 6038);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 5874, 6057);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6192, 6272);

                    return f_10130_6199_6271(f_10130_6238_6250(this)[0], ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 5543, 8380);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 5543, 8380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6512, 6539);

                    var
                    modules = f_10130_6526_6538(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6557, 6584);

                    var
                    count = modules.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6602, 6612);

                    var
                    i = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6632, 6696);

                    result = f_10130_6641_6695(modules[i], ref emittedName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6716, 7295) || true) && (result is MissingMetadataTypeSymbol)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 6716, 7295);
                        try
                        {
                            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6802, 6807)
   , i = 1; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6797, 7276) || true) && (i < count)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6820, 6823)
   , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 6797, 7276))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 6797, 7276);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 6873, 6944);

                                var
                                newResult = f_10130_6889_6943(modules[i], ref emittedName)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 7068, 7253) || true) && (!(newResult is MissingMetadataTypeSymbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 7068, 7253);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 7171, 7190);

                                    result = newResult;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10130, 7220, 7226);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 7068, 7253);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10130, 1, 480);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10130, 1, 480);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 6716, 7295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 7315, 7359);

                    bool
                    foundMatchInThisAssembly = (i < count)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 7379, 7472);

                    f_10130_7379_7471(!foundMatchInThisAssembly || (DynAbs.Tracing.TraceSender.Expression_False(10130, 7392, 7470) || (object)f_10130_7429_7454(result) == (object)this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 7492, 8007) || true) && (!foundMatchInThisAssembly && (DynAbs.Tracing.TraceSender.Expression_True(10130, 7496, 7549) && digThroughForwardedTypes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 7492, 8007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 7639, 7708);

                        f_10130_7639_7707(result is MissingMetadataTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 7732, 7845);

                        NamedTypeSymbol
                        forwarded = f_10130_7760_7844(this, ref emittedName, visitedAssemblies)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 7867, 7988) || true) && ((object)forwarded != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 7867, 7988);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 7946, 7965);

                            result = forwarded;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 7867, 7988);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 7492, 8007);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 8027, 8083);

                    f_10130_8027_8082((object)result != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 8163, 8331) || true) && (digThroughForwardedTypes || (DynAbs.Tracing.TraceSender.Expression_False(10130, 8167, 8219) || foundMatchInThisAssembly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 8163, 8331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 8261, 8312);

                        f_10130_8261_8311(this, ref emittedName, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 8163, 8331);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 8351, 8365);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 5543, 8380);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10130, 3823, 8391);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10130_5476_5526(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelMetadataTypeInCache(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 5476, 5526);
                    return return_v;
                }


                bool
                f_10130_5908_5928(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 5908, 5928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10130_5940_5965(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10130, 5940, 5965);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10130_6238_6250(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10130, 6238, 6250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10130_6199_6271(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, ref fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 6199, 6271);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10130_6526_6538(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10130, 6526, 6538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10130_6641_6695(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 6641, 6695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10130_6889_6943(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 6889, 6943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10130_7429_7454(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10130, 7429, 7454);
                    return return_v;
                }


                int
                f_10130_7379_7471(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 7379, 7471);
                    return 0;
                }


                int
                f_10130_7639_7707(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 7639, 7707);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10130_7760_7844(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                visitedAssemblies)
                {
                    var return_v = this_param.TryLookupForwardedMetadataTypeWithCycleDetection(ref emittedName, visitedAssemblies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 7760, 7844);
                    return return_v;
                }


                int
                f_10130_8027_8082(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 8027, 8082);
                    return 0;
                }


                int
                f_10130_8261_8311(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                result)
                {
                    this_param.CacheTopLevelMetadataType(ref emittedName, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 8261, 8311);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10130, 3823, 8391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10130, 3823, 8391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract override NamedTypeSymbol TryLookupForwardedMetadataTypeWithCycleDetection(ref MetadataTypeName emittedName, ConsList<AssemblySymbol> visitedAssemblies);

        private NamedTypeSymbol LookupTopLevelMetadataTypeInCache(ref MetadataTypeName emittedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10130, 8585, 8917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 8701, 8731);

                NamedTypeSymbol
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 8745, 8878) || true) && (f_10130_8749_8815(_emittedNameToTypeMap, emittedName.ToKey(), out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10130, 8745, 8878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 8849, 8863);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10130, 8745, 8878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 8894, 8906);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10130, 8585, 8917);

                bool
                f_10130_8749_8815(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.MetadataTypeName.Key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.MetadataTypeName.Key
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 8749, 8815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10130, 8585, 8917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10130, 8585, 8917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol CachedTypeByEmittedName(string emittedname)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10130, 9013, 9245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 9106, 9175);

                MetadataTypeName
                mdName = MetadataTypeName.FromFullName(emittedname)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 9189, 9234);

                return f_10130_9196_9233(_emittedNameToTypeMap, mdName.ToKey());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10130, 9013, 9245);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10130_9196_9233(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.MetadataTypeName.Key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.MetadataTypeName.Key
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10130, 9196, 9233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10130, 9013, 9245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10130, 9013, 9245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int EmittedNameToTypeMapCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10130, 9404, 9490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 9440, 9475);

                    return f_10130_9447_9474(_emittedNameToTypeMap);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10130, 9404, 9490);

                    int
                    f_10130_9447_9474(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.MetadataTypeName.Key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10130, 9447, 9474);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10130, 9341, 9501);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10130, 9341, 9501);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void CacheTopLevelMetadataType(
                    ref MetadataTypeName emittedName,
                    NamedTypeSymbol result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10130, 9513, 9951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 9661, 9692);

                NamedTypeSymbol
                result1 = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 9706, 9776);

                result1 = f_10130_9716_9775(_emittedNameToTypeMap, emittedName.ToKey(), result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 9790, 9895);

                f_10130_9790_9894(f_10130_9822_9893(result1, result, TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10130, 9513, 9951);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10130_9716_9775(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.MetadataTypeName.Key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.MetadataTypeName.Key
                key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 9716, 9775);
                    return return_v;
                }


                bool
                f_10130_9822_9893(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 9822, 9893);
                    return return_v;
                }


                int
                f_10130_9790_9894(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 9790, 9894);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10130, 9513, 9951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10130, 9513, 9951);
            }
        }

        public NonMissingAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10130, 804, 9958);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 1546, 1648);
            this._emittedNameToTypeMap = f_10130_1583_1648(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10130, 1685, 1701);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10130, 804, 9958);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10130, 804, 9958);
        }


        static NonMissingAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10130, 804, 9958);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10130, 804, 9958);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10130, 804, 9958);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10130, 804, 9958);

        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.MetadataTypeName.Key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_10130_1583_1648()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.MetadataTypeName.Key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10130, 1583, 1648);
            return return_v;
        }

    }
}
