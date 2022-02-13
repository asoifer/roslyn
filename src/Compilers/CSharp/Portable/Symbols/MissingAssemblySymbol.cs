// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class MissingAssemblySymbol : AssemblySymbol
    {
        protected readonly AssemblyIdentity identity;

        protected readonly MissingModuleSymbol moduleSymbol;

        private ImmutableArray<ModuleSymbol> _lazyModules;

        public MissingAssemblySymbol(AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10121, 1065, 1288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 920, 928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 978, 990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 1145, 1176);

                f_10121_1145_1175(identity != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 1190, 1215);

                this.identity = identity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 1229, 1277);

                moduleSymbol = f_10121_1244_1276(this, 0);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10121, 1065, 1288);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 1065, 1288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 1065, 1288);
            }
        }

        internal sealed override bool IsMissing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 1364, 1427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 1400, 1412);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 1364, 1427);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 1300, 1438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 1300, 1438);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsLinked
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 1506, 1570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 1542, 1555);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 1506, 1570);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 1450, 1581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 1450, 1581);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbol GetDeclaredSpecialTypeMember(SpecialMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 1593, 1716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 1693, 1705);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 1593, 1716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 1593, 1716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 1593, 1716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AssemblyIdentity Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 1794, 1861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 1830, 1846);

                    return identity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 1794, 1861);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 1728, 1872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 1728, 1872);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Version AssemblyVersionPattern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 1931, 1938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 1934, 1938);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 1931, 1938);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 1931, 1938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 1931, 1938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> PublicKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 2024, 2058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2030, 2056);

                    return f_10121_2037_2055(f_10121_2037_2045());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 2024, 2058);

                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10121_2037_2045()
                    {
                        var return_v = Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10121, 2037, 2045);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10121_2037_2055(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.PublicKey;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10121, 2037, 2055);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 1951, 2069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 1951, 2069);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ModuleSymbol> Modules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 2158, 2401);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2194, 2346) || true) && (_lazyModules.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10121, 2194, 2346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2262, 2327);

                        _lazyModules = f_10121_2277_2326(moduleSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10121, 2194, 2346);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2366, 2386);

                    return _lazyModules;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 2158, 2401);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10121_2277_2326(Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create<ModuleSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 2277, 2326);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 2081, 2412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 2081, 2412);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 2424, 2523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2482, 2512);

                return f_10121_2489_2511(identity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 2424, 2523);

                int
                f_10121_2489_2511(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 2489, 2511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 2424, 2523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 2424, 2523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 2535, 2683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2628, 2672);

                return f_10121_2635_2671(this, obj as MissingAssemblySymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 2535, 2683);

                bool
                f_10121_2635_2671(Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 2635, 2671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 2535, 2683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 2535, 2683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(MissingAssemblySymbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 2695, 3029);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2767, 2854) || true) && ((object)other == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10121, 2767, 2854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2826, 2839);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10121, 2767, 2854);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2870, 2963) || true) && (f_10121_2874_2902(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10121, 2870, 2963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2936, 2948);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10121, 2870, 2963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 2979, 3018);

                return f_10121_2986_3017(identity, f_10121_3002_3016(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 2695, 3029);

                bool
                f_10121_2874_2902(Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 2874, 2902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10121_3002_3016(Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10121, 3002, 3016);
                    return return_v;
                }


                bool
                f_10121_2986_3017(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 2986, 3017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 2695, 3029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 2695, 3029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 3116, 3205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 3152, 3190);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 3116, 3205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 3041, 3216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 3041, 3216);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void SetLinkedReferencedAssemblies(ImmutableArray<AssemblySymbol> assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 3228, 3396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 3348, 3385);

                throw f_10121_3354_3384();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 3228, 3396);

                System.Exception
                f_10121_3354_3384()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10121, 3354, 3384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 3228, 3396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 3228, 3396);
            }
        }

        internal override ImmutableArray<AssemblySymbol> GetLinkedReferencedAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 3408, 3568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 3513, 3557);

                return ImmutableArray<AssemblySymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 3408, 3568);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 3408, 3568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 3408, 3568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void SetNoPiaResolutionAssemblies(ImmutableArray<AssemblySymbol> assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 3580, 3747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 3699, 3736);

                throw f_10121_3705_3735();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 3580, 3747);

                System.Exception
                f_10121_3705_3735()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10121, 3705, 3735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 3580, 3747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 3580, 3747);
            }
        }

        internal override ImmutableArray<AssemblySymbol> GetNoPiaResolutionAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 3759, 3918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 3863, 3907);

                return ImmutableArray<AssemblySymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 3759, 3918);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 3759, 3918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 3759, 3918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override NamespaceSymbol GlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 4009, 4101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 4045, 4086);

                    return f_10121_4052_4085(this.moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 4009, 4101);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10121_4052_4085(Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10121, 4052, 4085);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 3930, 4112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 3930, 4112);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ICollection<string> TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 4194, 4301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 4230, 4286);

                    return f_10121_4237_4285();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 4194, 4301);

                    System.Collections.Generic.ICollection<string>
                    f_10121_4237_4285()
                    {
                        var return_v = SpecializedCollections.EmptyCollection<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 4237, 4285);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 4124, 4312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 4124, 4312);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ICollection<string> NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 4399, 4506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 4435, 4491);

                    return f_10121_4442_4490();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 4399, 4506);

                    System.Collections.Generic.ICollection<string>
                    f_10121_4442_4490()
                    {
                        var return_v = SpecializedCollections.EmptyCollection<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 4442, 4490);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 4324, 4517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 4324, 4517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol LookupTopLevelMetadataTypeWithCycleDetection(ref MetadataTypeName emittedName, ConsList<AssemblySymbol> visitedAssemblies, bool digThroughForwardedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 4529, 4919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 4741, 4816);

                var
                result = f_10121_4754_4815(this.moduleSymbol, ref emittedName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 4830, 4880);

                f_10121_4830_4879(result is MissingMetadataTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 4894, 4908);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 4529, 4919);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10121_4754_4815(Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 4754, 4815);
                    return return_v;
                }


                int
                f_10121_4830_4879(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 4830, 4879);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 4529, 4919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 4529, 4919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetDeclaredSpecialType(SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 4931, 5078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 5030, 5067);

                throw f_10121_5036_5066();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 4931, 5078);

                System.Exception
                f_10121_5036_5066()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10121, 5036, 5066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 4931, 5078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 4931, 5078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool AreInternalsVisibleToThisAssembly(AssemblySymbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 5090, 5217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 5193, 5206);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 5090, 5217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 5090, 5217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 5090, 5217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<ImmutableArray<byte>> GetInternalsVisibleToPublicKeys(string simpleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 5229, 5437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 5356, 5426);

                return f_10121_5363_5425();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 5229, 5437);

                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10121_5363_5425()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 5363, 5425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 5229, 5437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 5229, 5437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 5523, 5587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 5559, 5572);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 5523, 5587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 5449, 5598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 5449, 5598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblyMetadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 5657, 5664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 5660, 5664);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 5657, 5664);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 5657, 5664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 5657, 5664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override IEnumerable<NamedTypeSymbol> GetAllTopLevelForwardedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10121, 5677, 5862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10121, 5786, 5851);

                return f_10121_5793_5850();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10121, 5677, 5862);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10121_5793_5850()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 5793, 5850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10121, 5677, 5862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 5677, 5862);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MissingAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10121, 814, 5869);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10121, 814, 5869);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10121, 814, 5869);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10121, 814, 5869);

        int
        f_10121_1145_1175(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 1145, 1175);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbol
        f_10121_1244_1276(Microsoft.CodeAnalysis.CSharp.Symbols.MissingAssemblySymbol
        assembly, int
        ordinal)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)assembly, ordinal);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10121, 1244, 1276);
            return return_v;
        }

    }
}
