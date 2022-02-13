// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class MissingCorLibrarySymbol : MissingAssemblySymbol
    {
        internal static readonly MissingCorLibrarySymbol Instance;

        private NamedTypeSymbol[] _lazySpecialTypes;

        private MissingCorLibrarySymbol()
        : base(f_10122_1256_1303_C(f_10122_1256_1303("<Missing Core Assembly>")))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10122, 1202, 1365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 1172, 1189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 1329, 1354);

                f_10122_1329_1353(this, this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10122, 1202, 1365);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10122, 1202, 1365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10122, 1202, 1365);
            }
        }

        internal override NamedTypeSymbol GetDeclaredSpecialType(SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10122, 1632, 2655);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 1742, 1885);
                    foreach (var module in f_10122_1765_1777_I(f_10122_1765_1777(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10122, 1742, 1885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 1811, 1870);

                        f_10122_1811_1869(f_10122_1824_1856(module).Length == 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10122, 1742, 1885);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10122, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10122, 1, 144);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 1909, 2114) || true) && (_lazySpecialTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10122, 1909, 2114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 1972, 2099);

                    f_10122_1972_2098(ref _lazySpecialTypes, new NamedTypeSymbol[(int)SpecialType.Count + 1], null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10122, 1909, 2114);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 2130, 2592) || true) && ((object)_lazySpecialTypes[(int)type] == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10122, 2130, 2592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 2212, 2353);

                    MetadataTypeName
                    emittedFullName = MetadataTypeName.FromFullName(f_10122_2277_2311(type), useCLSCompliantNameArityEncoding: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 2371, 2482);

                    NamedTypeSymbol
                    corType = f_10122_2397_2481(this.moduleSymbol, ref emittedFullName, type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 2500, 2577);

                    f_10122_2500_2576(ref _lazySpecialTypes[(int)type], corType, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10122, 2130, 2592);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 2608, 2644);

                return _lazySpecialTypes[(int)type];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10122, 1632, 2655);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10122_1765_1777(Microsoft.CodeAnalysis.CSharp.Symbols.MissingCorLibrarySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10122, 1765, 1777);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_10122_1824_1856(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 1824, 1856);
                    return return_v;
                }


                int
                f_10122_1811_1869(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 1811, 1869);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10122_1765_1777_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 1765, 1777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]?
                f_10122_1972_2098(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 1972, 2098);
                    return return_v;
                }


                string?
                f_10122_2277_2311(Microsoft.CodeAnalysis.SpecialType
                id)
                {
                    var return_v = id.GetMetadataName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 2277, 2311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10122_2397_2481(Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module, ref fullName, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 2397, 2481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10122_2500_2576(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 2500, 2576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10122, 1632, 2655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10122, 1632, 2655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MissingCorLibrarySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10122, 749, 2662);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10122, 884, 924);
            Instance = f_10122_895_924(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10122, 749, 2662);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10122, 749, 2662);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10122, 749, 2662);

        static Microsoft.CodeAnalysis.CSharp.Symbols.MissingCorLibrarySymbol
        f_10122_895_924()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingCorLibrarySymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 895, 924);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AssemblyIdentity
        f_10122_1256_1303(string
        name)
        {
            var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 1256, 1303);
            return return_v;
        }


        int
        f_10122_1329_1353(Microsoft.CodeAnalysis.CSharp.Symbols.MissingCorLibrarySymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MissingCorLibrarySymbol
        corLibrary)
        {
            this_param.SetCorLibrary((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)corLibrary);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10122, 1329, 1353);
            return 0;
        }


        static Microsoft.CodeAnalysis.AssemblyIdentity
        f_10122_1256_1303_C(Microsoft.CodeAnalysis.AssemblyIdentity
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10122, 1202, 1365);
            return return_v;
        }

    }
}
