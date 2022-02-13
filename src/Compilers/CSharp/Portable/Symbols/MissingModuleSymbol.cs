// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class MissingModuleSymbol : ModuleSymbol
    {
        protected readonly AssemblySymbol assembly;

        protected readonly int ordinal;

        protected readonly MissingNamespaceSymbol globalNamespace;

        public MissingModuleSymbol(AssemblySymbol assembly, int ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10124, 1057, 1381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 927, 935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 969, 976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1029, 1044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1146, 1185);

                f_10124_1146_1184((object)assembly != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1199, 1227);

                f_10124_1199_1226(ordinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1243, 1268);

                this.assembly = assembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1282, 1305);

                this.ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1319, 1370);

                globalNamespace = f_10124_1337_1369(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10124, 1057, 1381);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 1057, 1381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 1057, 1381);
            }
        }

        internal override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 1447, 1513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1483, 1498);

                    return ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 1447, 1513);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 1393, 1524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 1393, 1524);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Machine Machine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 1594, 1665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1630, 1650);

                    return Machine.I386;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 1594, 1665);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 1536, 1676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 1536, 1676);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Bit32Required
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 1749, 1813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1785, 1798);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 1749, 1813);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 1688, 1824);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 1688, 1824);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMissing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 1900, 1963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 1936, 1948);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 1900, 1963);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 1836, 1974);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 1836, 1974);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 2038, 2214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 2173, 2199);

                    return "<Missing Module>";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 2038, 2214);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 1986, 2225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 1986, 2225);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 2311, 2378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 2347, 2363);

                    return assembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 2311, 2378);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 2237, 2389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 2237, 2389);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 2465, 2532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 2501, 2517);

                    return assembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 2465, 2532);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 2401, 2543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 2401, 2543);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamespaceSymbol GlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 2627, 2701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 2663, 2686);

                    return globalNamespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 2627, 2701);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 2555, 2712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 2555, 2712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 2724, 2823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 2782, 2812);

                return f_10124_2789_2811(assembly);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 2724, 2823);

                int
                f_10124_2789_2811(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 2789, 2811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 2724, 2823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 2724, 2823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 2835, 3194);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 2928, 3019) || true) && (f_10124_2932_2958(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10124, 2928, 3019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 2992, 3004);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10124, 2928, 3019);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 3035, 3090);

                MissingModuleSymbol
                other = obj as MissingModuleSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 3106, 3183);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10124, 3113, 3182) && f_10124_3138_3182(assembly, other.assembly, compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 2835, 3194);

                bool
                f_10124_2932_2958(Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 2932, 2958);
                    return return_v;
                }


                bool
                f_10124_3138_3182(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 3138, 3182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 2835, 3194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 2835, 3194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 3281, 3370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 3317, 3355);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 3281, 3370);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 3206, 3381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 3206, 3381);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ICollection<string> NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 3470, 3577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 3506, 3562);

                    return f_10124_3513_3561();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 3470, 3577);

                    System.Collections.Generic.ICollection<string>
                    f_10124_3513_3561()
                    {
                        var return_v = SpecializedCollections.EmptyCollection<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 3513, 3561);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 3393, 3588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 3393, 3588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ICollection<string> TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 3672, 3779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 3708, 3764);

                    return f_10124_3715_3763();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 3672, 3779);

                    System.Collections.Generic.ICollection<string>
                    f_10124_3715_3763()
                    {
                        var return_v = SpecializedCollections.EmptyCollection<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 3715, 3763);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 3600, 3790);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 3600, 3790);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol LookupTopLevelMetadataType(ref MetadataTypeName emittedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 3802, 4001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 3921, 3990);

                return f_10124_3928_3989(this, ref emittedName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 3802, 4001);

                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10124_3928_3989(Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module, ref fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 3928, 3989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 3802, 4001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 3802, 4001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<AssemblyIdentity> GetReferencedAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 4013, 4171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 4114, 4160);

                return ImmutableArray<AssemblyIdentity>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 4013, 4171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 4013, 4171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 4013, 4171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<AssemblySymbol> GetReferencedAssemblySymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 4183, 4342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 4287, 4331);

                return ImmutableArray<AssemblySymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 4183, 4342);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 4183, 4342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 4183, 4342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void SetReferences(ModuleReferences<AssemblySymbol> moduleReferences, SourceAssemblySymbol originatingSourceAssemblyDebugOnly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 4354, 4571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 4523, 4560);

                throw f_10124_4529_4559();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 4354, 4571);

                System.Exception
                f_10124_4529_4559()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10124, 4529, 4559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 4354, 4571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 4354, 4571);
            }
        }

        internal override bool HasUnifiedReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 4651, 4672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 4657, 4670);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 4651, 4672);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 4583, 4683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 4583, 4683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GetUnificationUseSiteDiagnostic(ref DiagnosticInfo result, TypeSymbol dependentType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 4695, 4875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 4827, 4864);

                throw f_10124_4833_4863();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 4695, 4875);

                System.Exception
                f_10124_4833_4863()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10124, 4833, 4863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 4695, 4875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 4695, 4875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool HasAssemblyCompilationRelaxationsAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 4977, 4998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 4983, 4996);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 4977, 4998);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 4887, 5009);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 4887, 5009);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasAssemblyRuntimeCompatibilityAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 5109, 5130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 5115, 5128);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 5109, 5130);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 5021, 5141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 5021, 5141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet? DefaultMarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 5230, 5250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 5236, 5248);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 5230, 5250);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 5153, 5261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 5153, 5261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ModuleMetadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 5318, 5325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 5321, 5325);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 5318, 5325);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 5318, 5325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 5318, 5325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 5406, 5451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 5412, 5449);

                    throw f_10124_5418_5448();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 5406, 5451);

                    System.Exception
                    f_10124_5418_5448()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10124, 5418, 5448);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 5338, 5462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 5338, 5462);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static MissingModuleSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10124, 827, 5469);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10124, 827, 5469);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 827, 5469);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10124, 827, 5469);

        int
        f_10124_1146_1184(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 1146, 1184);
            return 0;
        }


        int
        f_10124_1199_1226(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 1199, 1226);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MissingNamespaceSymbol
        f_10124_1337_1369(Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbol
        containingModule)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingNamespaceSymbol(containingModule);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 1337, 1369);
            return return_v;
        }

    }
    internal sealed class MissingModuleSymbolWithName : MissingModuleSymbol
    {
        private readonly string _name;

        public MissingModuleSymbolWithName(AssemblySymbol assembly, string name)
        : base(f_10124_5700_5708_C(assembly), ordinal: -1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10124, 5607, 5814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 5589, 5594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 5747, 5774);

                f_10124_5747_5773(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 5790, 5803);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10124, 5607, 5814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 5607, 5814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 5607, 5814);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 5878, 5942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 5914, 5927);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 5878, 5942);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 5826, 5953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 5826, 5953);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 5965, 6131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 6023, 6120);

                return f_10124_6030_6119(f_10124_6043_6065(assembly), f_10124_6067_6118(f_10124_6067_6099(), _name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 5965, 6131);

                int
                f_10124_6043_6065(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 6043, 6065);
                    return return_v;
                }


                System.StringComparer
                f_10124_6067_6099()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10124, 6067, 6099);
                    return return_v;
                }


                int
                f_10124_6067_6118(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 6067, 6118);
                    return return_v;
                }


                int
                f_10124_6030_6119(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 6030, 6119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 5965, 6131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 5965, 6131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10124, 6143, 6591);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 6236, 6327) || true) && (f_10124_6240_6266(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10124, 6236, 6327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 6300, 6312);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10124, 6236, 6327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 6343, 6414);

                MissingModuleSymbolWithName
                other = obj as MissingModuleSymbolWithName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10124, 6430, 6580);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10124, 6437, 6506) && f_10124_6462_6506(assembly, other.assembly, compareKind)) && (DynAbs.Tracing.TraceSender.Expression_True(10124, 6437, 6579) && f_10124_6510_6579(_name, other._name, StringComparison.OrdinalIgnoreCase));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10124, 6143, 6591);

                bool
                f_10124_6240_6266(Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbolWithName
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 6240, 6266);
                    return return_v;
                }


                bool
                f_10124_6462_6506(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 6462, 6506);
                    return return_v;
                }


                bool
                f_10124_6510_6579(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 6510, 6579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10124, 6143, 6591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 6143, 6591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MissingModuleSymbolWithName()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10124, 5477, 6598);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10124, 5477, 6598);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10124, 5477, 6598);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10124, 5477, 6598);

        int
        f_10124_5747_5773(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10124, 5747, 5773);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10124_5700_5708_C(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10124, 5607, 5814);
            return return_v;
        }

    }
}
