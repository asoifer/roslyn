// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class PEGlobalNamespaceSymbol
            : PENamespaceSymbol
    {
        private readonly PEModuleSymbol _moduleSymbol;

        internal PEGlobalNamespaceSymbol(PEModuleSymbol moduleSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10706, 862, 1045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 836, 849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 948, 991);

                f_10706_948_990((object)moduleSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 1005, 1034);

                _moduleSymbol = moduleSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10706, 862, 1045);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10706, 862, 1045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 862, 1045);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10706, 1121, 1193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 1157, 1178);

                    return _moduleSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10706, 1121, 1193);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10706, 1057, 1204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 1057, 1204);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override PEModuleSymbol ContainingPEModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10706, 1292, 1364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 1328, 1349);

                    return _moduleSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10706, 1292, 1364);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10706, 1216, 1375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 1216, 1375);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10706, 1439, 1510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 1475, 1495);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10706, 1439, 1510);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10706, 1387, 1521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 1387, 1521);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10706, 1596, 1659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 1632, 1644);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10706, 1596, 1659);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10706, 1533, 1670);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 1533, 1670);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10706, 1756, 1847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 1792, 1832);

                    return f_10706_1799_1831(_moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10706, 1756, 1847);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10706_1799_1831(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10706, 1799, 1831);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10706, 1682, 1858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 1682, 1858);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10706, 1942, 2014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 1978, 1999);

                    return _moduleSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10706, 1942, 2014);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10706, 1870, 2025);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 1870, 2025);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void EnsureAllMembersLoaded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10706, 2037, 2693);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 2110, 2682) || true) && (lazyTypes == null || (DynAbs.Tracing.TraceSender.Expression_False(10706, 2114, 2157) || lazyNamespaces == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10706, 2110, 2682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 2191, 2251);

                    IEnumerable<IGrouping<string, TypeDefinitionHandle>>
                    groups
                    = default(IEnumerable<IGrouping<string, TypeDefinitionHandle>>);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 2315, 2405);

                        groups = f_10706_2324_2404(f_10706_2324_2344(_moduleSymbol), f_10706_2374_2403());
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10706, 2442, 2624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 2514, 2605);

                        groups = f_10706_2523_2604();
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10706, 2442, 2624);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 2644, 2667);

                    f_10706_2644_2666(this, groups);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10706, 2110, 2682);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10706, 2037, 2693);

                Microsoft.CodeAnalysis.PEModule
                f_10706_2324_2344(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10706, 2324, 2344);
                    return return_v;
                }


                System.StringComparer
                f_10706_2374_2403()
                {
                    var return_v = System.StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10706, 2374, 2403);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                f_10706_2324_2404(Microsoft.CodeAnalysis.PEModule
                this_param, System.StringComparer
                nameComparer)
                {
                    var return_v = this_param.GroupTypesByNamespaceOrThrow(nameComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10706, 2324, 2404);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                f_10706_2523_2604()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<IGrouping<string, TypeDefinitionHandle>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10706, 2523, 2604);
                    return return_v;
                }


                int
                f_10706_2644_2666(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEGlobalNamespaceSymbol
                this_param, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                typesByNS)
                {
                    this_param.LoadAllMembers(typesByNS);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10706, 2644, 2666);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10706, 2037, 2693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 2037, 2693);
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10706, 2818, 2838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10706, 2824, 2836);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10706, 2818, 2838);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10706, 2705, 2849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 2705, 2849);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PEGlobalNamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10706, 583, 2856);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10706, 583, 2856);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10706, 583, 2856);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10706, 583, 2856);

        int
        f_10706_948_990(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10706, 948, 990);
            return 0;
        }

    }
}
