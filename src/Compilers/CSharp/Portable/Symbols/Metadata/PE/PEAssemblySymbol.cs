// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class PEAssemblySymbol : MetadataOrSourceAssemblySymbol
    {
        private readonly PEAssembly _assembly;

        private readonly DocumentationProvider _documentationProvider;

        private readonly ImmutableArray<ModuleSymbol> _modules;

        private ImmutableArray<AssemblySymbol> _noPiaResolutionAssemblies;

        private ImmutableArray<AssemblySymbol> _linkedReferencedAssemblies;

        private readonly bool _isLinked;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        internal PEAssemblySymbol(PEAssembly assembly, DocumentationProvider documentationProvider, bool isLinked, MetadataImportOptions importOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10703, 2610, 3326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 783, 792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 988, 1010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 2421, 2430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 2778, 2809);

                f_10703_2778_2808(assembly != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 2823, 2867);

                f_10703_2823_2866(documentationProvider != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 2881, 2902);

                _assembly = assembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 2916, 2963);

                _documentationProvider = documentationProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 2979, 3035);

                var
                modules = new ModuleSymbol[assembly.Modules.Length]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3060, 3065);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3051, 3225) || true) && (i < assembly.Modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3096, 3099)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10703, 3051, 3225))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10703, 3051, 3225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3133, 3210);

                        modules[i] = f_10703_3146_3209(this, f_10703_3171_3187(assembly)[i], importOptions, i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10703, 1, 175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10703, 1, 175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3241, 3280);

                _modules = f_10703_3252_3279(modules);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3294, 3315);

                _isLinked = isLinked;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10703, 2610, 3326);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 2610, 3326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 2610, 3326);
            }
        }

        internal PEAssembly Assembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 3391, 3459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3427, 3444);

                    return _assembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 3391, 3459);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 3338, 3470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 3338, 3470);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblyIdentity Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 3548, 3625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3584, 3610);

                    return f_10703_3591_3609(_assembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 3548, 3625);

                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10703_3591_3609(Microsoft.CodeAnalysis.PEAssembly
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 3591, 3609);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 3482, 3636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 3482, 3636);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 3758, 3765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3761, 3765);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 3758, 3765);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 3758, 3765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 3758, 3765);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 3855, 3922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 3891, 3907);

                    return _modules;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 3855, 3922);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 3778, 3933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 3778, 3933);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 4020, 4149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 4056, 4134);

                    return f_10703_4063_4081(this).MetadataLocation.Cast<MetadataLocation, Location>();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 4020, 4149);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10703_4063_4081(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.PrimaryModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 4063, 4081);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 3945, 4160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 3945, 4160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 4172, 4818);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 4264, 4764) || true) && (_lazyCustomAttributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10703, 4264, 4764);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 4333, 4749) || true) && (f_10703_4337_4370(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10703, 4333, 4749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 4412, 4538);

                        f_10703_4412_4537(f_10703_4412_4430(this), f_10703_4468_4484(_assembly), ref _lazyCustomAttributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10703, 4333, 4749);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10703, 4333, 4749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 4620, 4730);

                        f_10703_4620_4729(f_10703_4620_4638(this), f_10703_4660_4676(_assembly), ref _lazyCustomAttributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10703, 4333, 4749);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10703, 4264, 4764);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 4778, 4807);

                return _lazyCustomAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 4172, 4818);

                bool
                f_10703_4337_4370(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param)
                {
                    var return_v = this_param.MightContainExtensionMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 4337, 4370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10703_4412_4430(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param)
                {
                    var return_v = this_param.PrimaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 4412, 4430);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_10703_4468_4484(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 4468, 4484);
                    return return_v;
                }


                int
                f_10703_4412_4537(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
                token, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    this_param.LoadCustomAttributesFilterExtensions(token, ref customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 4412, 4537);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10703_4620_4638(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param)
                {
                    var return_v = this_param.PrimaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 4620, 4638);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_10703_4660_4676(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 4660, 4676);
                    return return_v;
                }


                int
                f_10703_4620_4729(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EntityHandle
                token, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    this_param.LoadCustomAttributes(token, ref customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 4620, 4729);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 4172, 4818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 4172, 4818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal (AssemblySymbol FirstSymbol, AssemblySymbol SecondSymbol) LookupAssembliesForForwardedMetadataType(ref MetadataTypeName emittedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 5232, 5721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 5637, 5710);

                return f_10703_5644_5709(f_10703_5644_5662(this), ref emittedName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 5232, 5721);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10703_5644_5662(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param)
                {
                    var return_v = this_param.PrimaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 5644, 5662);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol FirstSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol SecondSymbol)
                f_10703_5644_5709(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName)
                {
                    var return_v = this_param.GetAssembliesForForwardedType(ref fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 5644, 5709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 5232, 5721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 5232, 5721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<NamedTypeSymbol> GetAllTopLevelForwardedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 5733, 5892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 5835, 5881);

                return f_10703_5842_5880(f_10703_5842_5860(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 5733, 5892);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10703_5842_5860(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param)
                {
                    var return_v = this_param.PrimaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 5842, 5860);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10703_5842_5880(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetForwardedTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 5842, 5880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 5733, 5892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 5733, 5892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol TryLookupForwardedMetadataTypeWithCycleDetection(ref MetadataTypeName emittedName, ConsList<AssemblySymbol> visitedAssemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 5904, 7391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 6138, 6256);

                (AssemblySymbol firstSymbol, AssemblySymbol secondSymbol) = f_10703_6198_6255(this, ref emittedName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 6272, 7352) || true) && ((object)firstSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10703, 6272, 7352);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 6337, 6680) || true) && ((object)secondSymbol != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10703, 6337, 6680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 6550, 6661);

                        return f_10703_6557_6660(this, ref emittedName, f_10703_6614_6632(this), firstSymbol, secondSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10703, 6337, 6680);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 6794, 7337) || true) && (visitedAssemblies != null && (DynAbs.Tracing.TraceSender.Expression_True(10703, 6798, 6866) && f_10703_6827_6866(visitedAssemblies, firstSymbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10703, 6794, 7337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 6908, 6974);

                        return f_10703_6915_6973(this, ref emittedName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10703, 6794, 7337);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10703, 6794, 7337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 7056, 7164);

                        visitedAssemblies = f_10703_7076_7163(this, visitedAssemblies ?? (DynAbs.Tracing.TraceSender.Expression_Null<Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>?>(10703, 7111, 7162) ?? ConsList<AssemblySymbol>.Empty));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 7186, 7318);

                        return f_10703_7193_7317(firstSymbol, ref emittedName, visitedAssemblies, digThroughForwardedTypes: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10703, 6794, 7337);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10703, 6272, 7352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 7368, 7380);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 5904, 7391);

                (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol FirstSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol SecondSymbol)
                f_10703_6198_6255(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupAssembliesForForwardedMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 6198, 6255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10703_6614_6632(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param)
                {
                    var return_v = this_param.PrimaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 6614, 6632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                f_10703_6557_6660(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                forwardingModule, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                destination1, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                destination2)
                {
                    var return_v = this_param.CreateMultipleForwardingErrorTypeSymbol(ref emittedName, (Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)forwardingModule, destination1, destination2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 6557, 6660);
                    return return_v;
                }


                bool
                f_10703_6827_6866(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                source, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                value)
                {
                    var return_v = source.Contains<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 6827, 6866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                f_10703_6915_6973(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.CreateCycleInTypeForwarderErrorTypeSymbol(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 6915, 6973);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10703_7076_7163(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                head, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                tail)
                {
                    var return_v = new Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)head, tail);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 7076, 7163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10703_7193_7317(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                visitedAssemblies, bool
                digThroughForwardedTypes)
                {
                    var return_v = this_param.LookupTopLevelMetadataTypeWithCycleDetection(ref emittedName, visitedAssemblies, digThroughForwardedTypes: digThroughForwardedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 7193, 7317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 5904, 7391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 5904, 7391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<AssemblySymbol> GetNoPiaResolutionAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 7403, 7552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 7507, 7541);

                return _noPiaResolutionAssemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 7403, 7552);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 7403, 7552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 7403, 7552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void SetNoPiaResolutionAssemblies(ImmutableArray<AssemblySymbol> assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 7564, 7734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 7683, 7723);

                _noPiaResolutionAssemblies = assemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 7564, 7734);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 7564, 7734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 7564, 7734);
            }
        }

        internal override void SetLinkedReferencedAssemblies(ImmutableArray<AssemblySymbol> assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 7746, 7918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 7866, 7907);

                _linkedReferencedAssemblies = assemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 7746, 7918);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 7746, 7918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 7746, 7918);
            }
        }

        internal override ImmutableArray<AssemblySymbol> GetLinkedReferencedAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 7930, 8081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 8035, 8070);

                return _linkedReferencedAssemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 7930, 8081);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 7930, 8081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 7930, 8081);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<byte> PublicKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 8166, 8243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 8202, 8228);

                    return f_10703_8209_8227(f_10703_8209_8217());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 8166, 8243);

                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10703_8209_8217()
                    {
                        var return_v = Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 8209, 8217);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10703_8209_8227(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.PublicKey;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 8209, 8227);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 8093, 8254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 8093, 8254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GetGuidString(out string guidString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 8266, 8438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 8350, 8427);

                return f_10703_8357_8426(f_10703_8357_8373(f_10703_8357_8365())[0], f_10703_8394_8409(f_10703_8394_8402()), out guidString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 8266, 8438);

                Microsoft.CodeAnalysis.PEAssembly
                f_10703_8357_8365()
                {
                    var return_v = Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 8357, 8365);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                f_10703_8357_8373(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 8357, 8373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEAssembly
                f_10703_8394_8402()
                {
                    var return_v = Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 8394, 8402);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_10703_8394_8409(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 8394, 8409);
                    return return_v;
                }


                bool
                f_10703_8357_8426(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, out string
                guidValue)
                {
                    var return_v = this_param.HasGuidAttribute(token, out guidValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 8357, 8426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 8266, 8438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 8266, 8438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool AreInternalsVisibleToThisAssembly(AssemblySymbol potentialGiverOfAccess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 8450, 8760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 8570, 8647);

                IVTConclusion
                conclusion = f_10703_8597_8646(this, potentialGiverOfAccess)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 8661, 8749);

                return conclusion == IVTConclusion.Match || (DynAbs.Tracing.TraceSender.Expression_False(10703, 8668, 8748) || conclusion == IVTConclusion.OneSignedOneNot);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 8450, 8760);

                Microsoft.CodeAnalysis.IVTConclusion
                f_10703_8597_8646(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                potentialGiverOfAccess)
                {
                    var return_v = this_param.MakeFinalIVTDetermination(potentialGiverOfAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 8597, 8646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 8450, 8760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 8450, 8760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<ImmutableArray<byte>> GetInternalsVisibleToPublicKeys(string simpleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 8772, 8970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 8899, 8959);

                return f_10703_8906_8958(f_10703_8906_8914(), simpleName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 8772, 8970);

                Microsoft.CodeAnalysis.PEAssembly
                f_10703_8906_8914()
                {
                    var return_v = Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 8906, 8914);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10703_8906_8958(Microsoft.CodeAnalysis.PEAssembly
                this_param, string
                simpleName)
                {
                    var return_v = this_param.GetInternalsVisibleToPublicKeys(simpleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 8906, 8958);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 8772, 8970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 8772, 8970);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal DocumentationProvider DocumentationProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 9059, 9140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 9095, 9125);

                    return _documentationProvider;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 9059, 9140);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 8982, 9151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 8982, 9151);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 9219, 9287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 9255, 9272);

                    return _isLinked;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 9219, 9287);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 9163, 9298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 9163, 9298);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 9384, 9809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 9782, 9794);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 9384, 9809);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 9310, 9820);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 9310, 9820);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PEModuleSymbol PrimaryModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 9894, 9980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 9930, 9965);

                    return (PEModuleSymbol)_modules[0];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 9894, 9980);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 9832, 9991);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 9832, 9991);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 10116, 10136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 10122, 10134);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 10116, 10136);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 10003, 10147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 10003, 10147);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblyMetadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10703, 10206, 10245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10703, 10209, 10245);
                return f_10703_10209_10245(_assembly); DynAbs.Tracing.TraceSender.TraceExitMethod(10703, 10206, 10245);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10703, 10206, 10245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 10206, 10245);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.AssemblyMetadata
            f_10703_10209_10245(Microsoft.CodeAnalysis.PEAssembly
            this_param)
            {
                var return_v = this_param.GetNonDisposableMetadata();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 10209, 10245);
                return return_v;
            }

        }

        static PEAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10703, 551, 10253);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10703, 551, 10253);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10703, 551, 10253);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10703, 551, 10253);

        int
        f_10703_2778_2808(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 2778, 2808);
            return 0;
        }


        int
        f_10703_2823_2866(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 2823, 2866);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
        f_10703_3171_3187(Microsoft.CodeAnalysis.PEAssembly
        this_param)
        {
            var return_v = this_param.Modules;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10703, 3171, 3187);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10703_3146_3209(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
        assemblySymbol, Microsoft.CodeAnalysis.PEModule
        module, Microsoft.CodeAnalysis.MetadataImportOptions
        importOptions, int
        ordinal)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol(assemblySymbol, module, importOptions, ordinal);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 3146, 3209);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        f_10703_3252_3279(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol[]
        items)
        {
            var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10703, 3252, 3279);
            return return_v;
        }

    }
}
