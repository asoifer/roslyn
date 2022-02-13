// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class ModuleReference : Cci.IModuleReference, Cci.IFileReference
    {
        private readonly PEModuleBuilder _moduleBeingBuilt;

        private readonly ModuleSymbol _underlyingModule;

        internal ModuleReference(PEModuleBuilder moduleBeingBuilt, ModuleSymbol underlyingModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10195, 734, 1063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 646, 663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 704, 721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 848, 887);

                f_10195_848_886(moduleBeingBuilt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 901, 948);

                f_10195_901_947((object)underlyingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 964, 1001);

                _moduleBeingBuilt = moduleBeingBuilt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 1015, 1052);

                _underlyingModule = underlyingModule;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10195, 734, 1063);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 734, 1063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 734, 1063);
            }
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 1075, 1210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 1157, 1199);

                f_10195_1157_1198(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 1075, 1210);

                int
                f_10195_1157_1198(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.ModuleReference
                moduleReference)
                {
                    this_param.Visit((Microsoft.Cci.IModuleReference)moduleReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10195, 1157, 1198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 1075, 1210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 1075, 1210);
            }
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 1275, 1364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 1311, 1349);

                    return f_10195_1318_1348(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 1275, 1364);

                    string
                    f_10195_1318_1348(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10195, 1318, 1348);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 1222, 1375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 1222, 1375);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFileReference.HasMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 1447, 1510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 1483, 1495);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 1447, 1510);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 1387, 1521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 1387, 1521);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string Cci.IFileReference.FileName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 1592, 1673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 1628, 1658);

                    return f_10195_1635_1657(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 1592, 1673);

                    string
                    f_10195_1635_1657(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10195, 1635, 1657);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 1533, 1684);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 1533, 1684);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<byte> Cci.IFileReference.GetHashValue(AssemblyHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 1696, 1865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 1808, 1854);

                return f_10195_1815_1853(_underlyingModule, algorithmId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 1696, 1865);

                System.Collections.Immutable.ImmutableArray<byte>
                f_10195_1815_1853(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param, System.Reflection.AssemblyHashAlgorithm
                algorithmId)
                {
                    var return_v = this_param.GetHash(algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10195, 1815, 1853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 1696, 1865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 1696, 1865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IAssemblyReference Cci.IModuleReference.GetContainingAssembly(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 1877, 2341);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 1988, 2220) || true) && (f_10195_1992_2034(_moduleBeingBuilt.OutputKind) && (DynAbs.Tracing.TraceSender.Expression_True(10195, 1992, 2159) && f_10195_2055_2159(f_10195_2071_2120(_moduleBeingBuilt.SourceModule), f_10195_2122_2158(_underlyingModule))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10195, 1988, 2220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 2193, 2205);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10195, 1988, 2220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 2236, 2330);

                return f_10195_2243_2329(_moduleBeingBuilt, f_10195_2271_2307(_underlyingModule), context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 1877, 2341);

                bool
                f_10195_1992_2034(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10195, 1992, 2034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10195_2071_2120(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10195, 2071, 2120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10195_2122_2158(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10195, 2122, 2158);
                    return return_v;
                }


                bool
                f_10195_2055_2159(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10195, 2055, 2159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10195_2271_2307(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10195, 2271, 2307);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_10195_2243_2329(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(assembly, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10195, 2243, 2329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 1877, 2341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 1877, 2341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 2353, 2458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 2411, 2447);

                return f_10195_2418_2446(_underlyingModule);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 2353, 2458);

                string
                f_10195_2418_2446(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10195, 2418, 2446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 2353, 2458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 2353, 2458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 2470, 2659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 2578, 2648);

                return f_10195_2585_2647();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 2470, 2659);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_10195_2585_2647()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10195, 2585, 2647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 2470, 2659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 2470, 2659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 2671, 2783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 2760, 2772);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 2671, 2783);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 2671, 2783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 2671, 2783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10195, 2867, 2874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10195, 2870, 2874);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10195, 2867, 2874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10195, 2867, 2874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 2867, 2874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModuleReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10195, 516, 2882);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10195, 516, 2882);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10195, 516, 2882);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10195, 516, 2882);

        int
        f_10195_848_886(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10195, 848, 886);
            return 0;
        }


        int
        f_10195_901_947(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10195, 901, 947);
            return 0;
        }

    }
}
