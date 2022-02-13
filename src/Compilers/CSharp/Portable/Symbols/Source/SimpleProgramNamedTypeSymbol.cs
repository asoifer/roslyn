// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SimpleProgramNamedTypeSymbol : SourceMemberContainerTypeSymbol
    {
        internal SimpleProgramNamedTypeSymbol(NamespaceSymbol globalNamespace, MergedTypeDeclaration declaration, DiagnosticBag diagnostics)
        : base(f_10074_1011_1026_C(globalNamespace), declaration, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10074, 858, 1422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 1078, 1126);

                f_10074_1078_1125(f_10074_1091_1124(globalNamespace));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 1140, 1204);

                f_10074_1140_1203(f_10074_1153_1169(declaration) == DeclarationKind.SimpleProgram);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 1218, 1310);

                f_10074_1218_1309(f_10074_1231_1247(declaration) == WellKnownMemberNames.TopLevelStatementsEntryPointTypeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 1326, 1384);

                state.NotePartComplete(CompletionPart.EnumUnderlyingType);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10074, 858, 1422);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 858, 1422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 858, 1422);
            }
        }

        internal static SynthesizedSimpleProgramEntryPointSymbol? GetSimpleProgramEntryPoint(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10074, 1434, 1867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 1597, 1654);

                var
                temp2 = f_10074_1609_1653(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 1668, 1715);

                var
                temp3 = f_10074_1680_1714_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(temp2, 10074, 1680, 1714)?.GetMembersAndInitializers())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 1729, 1787);

                var
                temp = (DynAbs.Tracing.TraceSender.Conditional_F1(10074, 1740, 1753) || ((temp3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(10074, 1756, 1779)) || DynAbs.Tracing.TraceSender.Conditional_F3(10074, 1782, 1786))) ? temp3.NonTypeMembers[0] : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 1801, 1856);

                return (SynthesizedSimpleProgramEntryPointSymbol?)temp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10074, 1434, 1867);

                Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol?
                f_10074_1609_1653(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = GetSimpleProgramNamedTypeSymbol(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 1609, 1653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.MembersAndInitializers?
                f_10074_1680_1714_I(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.MembersAndInitializers?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 1680, 1714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 1434, 1867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 1434, 1867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SimpleProgramNamedTypeSymbol? GetSimpleProgramNamedTypeSymbol(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10074, 1879, 2201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 2011, 2190);

                return f_10074_2018_2189(f_10074_2018_2132(f_10074_2018_2058(f_10074_2018_2042(compilation)), WellKnownMemberNames.TopLevelStatementsEntryPointTypeName).OfType<SimpleProgramNamedTypeSymbol>());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10074, 1879, 2201);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10074_2018_2042(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 2018, 2042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10074_2018_2058(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 2018, 2058);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10074_2018_2132(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 2018, 2132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol
                f_10074_2018_2189(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol>
                source)
                {
                    var return_v = source.SingleOrDefault<Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 2018, 2189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 1879, 2201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 1879, 2201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SynthesizedSimpleProgramEntryPointSymbol? GetSimpleProgramEntryPoint(CSharpCompilation compilation, CompilationUnitSyntax compilationUnit, bool fallbackToMainEntryPoint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10074, 2213, 3116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 2423, 2479);

                var
                type = f_10074_2434_2478(compilation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 2495, 2572) || true) && (type is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10074, 2495, 2572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 2545, 2557);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10074, 2495, 2572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 2588, 2673);

                ImmutableArray<Symbol>
                entryPoints = f_10074_2625_2657(type).NonTypeMembers
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 2689, 2991);
                    foreach (SynthesizedSimpleProgramEntryPointSymbol entryPoint in f_10074_2753_2764_I(entryPoints))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10074, 2689, 2991);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 2798, 2976) || true) && (f_10074_2802_2823(entryPoint) == f_10074_2827_2853(compilationUnit) && (DynAbs.Tracing.TraceSender.Expression_True(10074, 2802, 2897) && f_10074_2857_2878(entryPoint) == compilationUnit))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10074, 2798, 2976);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 2939, 2957);

                            return entryPoint;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10074, 2798, 2976);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10074, 2689, 2991);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10074, 1, 303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10074, 1, 303);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 3007, 3105);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10074, 3014, 3038) || ((fallbackToMainEntryPoint && DynAbs.Tracing.TraceSender.Conditional_F2(10074, 3041, 3097)) || DynAbs.Tracing.TraceSender.Conditional_F3(10074, 3100, 3104))) ? (SynthesizedSimpleProgramEntryPointSymbol)entryPoints[0] : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10074, 2213, 3116);

                Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol?
                f_10074_2434_2478(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = GetSimpleProgramNamedTypeSymbol(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 2434, 2478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.MembersAndInitializers
                f_10074_2625_2657(Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersAndInitializers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 2625, 2657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10074_2802_2823(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 2802, 2823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10074_2827_2853(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 2827, 2853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10074_2857_2878(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 2857, 2878);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10074_2753_2764_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 2753, 2764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 2213, 3116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 2213, 3116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 3218, 3257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 3221, 3257);
                throw f_10074_3227_3257(); DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 3218, 3257);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 3218, 3257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 3218, 3257);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10074_3227_3257()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 3227, 3257);
                return return_v;
            }

        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 3270, 3486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 3362, 3412);

                state.NotePartComplete(CompletionPart.Attributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 3426, 3475);

                return ImmutableArray<CSharpAttributeData>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 3270, 3486);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 3270, 3486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 3270, 3486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 3498, 3625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 3583, 3614);

                return AttributeUsageInfo.Null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 3498, 3625);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 3498, 3625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 3498, 3625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Location GetCorrespondingBaseListLocation(NamedTypeSymbol @base)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 3637, 3809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 3745, 3773);

                return NoLocation.Singleton;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 3637, 3809);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 3637, 3809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 3637, 3809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 3897, 3990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 3900, 3990);
                    return f_10074_3900_3990(f_10074_3900_3925(this), Microsoft.CodeAnalysis.SpecialType.System_Object); DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 3897, 3990);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 3897, 3990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 3897, 3990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void CheckBase(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 4003, 4408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 4144, 4246);

                var
                info = f_10074_4155_4245(f_10074_4155_4222(f_10074_4155_4180(this), SpecialType.System_Object))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 4260, 4397) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10074, 4260, 4397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 4310, 4382);

                    f_10074_4310_4381(info, diagnostics, NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10074, 4260, 4397);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 4003, 4408);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10074_4155_4180(Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 4155, 4180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10074_4155_4222(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 4155, 4222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10074_4155_4245(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 4155, 4245);
                    return return_v;
                }


                bool
                f_10074_4310_4381(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 4310, 4381);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 4003, 4408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 4003, 4408);
            }
        }

        internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 4420, 4586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 4539, 4575);

                return f_10074_4546_4574();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 4420, 4586);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10074_4546_4574()
                {
                    var return_v = BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 4546, 4574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 4420, 4586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 4420, 4586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 4598, 4800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 4744, 4789);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 4598, 4800);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 4598, 4800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 4598, 4800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 4812, 5005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 4949, 4994);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 4812, 5005);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 4812, 5005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 4812, 5005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void CheckInterfaces(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 5017, 5125);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 5017, 5125);
                // nop
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 5017, 5125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 5017, 5125);
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 5228, 5285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 5234, 5283);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 5228, 5285);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 5137, 5296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 5137, 5296);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 5435, 5492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 5441, 5490);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 5435, 5492);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 5308, 5503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 5308, 5503);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 5583, 5631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 5589, 5629);

                    return f_10074_5596_5628(f_10074_5596_5612());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 5583, 5631);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10074_5596_5612()
                    {
                        var return_v = ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 5596, 5612);
                        return return_v;
                    }


                    bool
                    f_10074_5596_5628(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.AreLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 5596, 5628);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 5515, 5642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 5515, 5642);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 5713, 5734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 5719, 5732);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 5713, 5734);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 5654, 5745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 5654, 5745);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol? ComImportCoClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 5833, 5853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 5839, 5851);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 5833, 5853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 5757, 5864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 5757, 5864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 5938, 5959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 5944, 5957);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 5938, 5959);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 5876, 5970);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 5876, 5970);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool ShouldAddWinRTMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 6051, 6072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 6057, 6070);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 6051, 6072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 5982, 6083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 5982, 6083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 6172, 6193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 6178, 6191);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 6172, 6193);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 6095, 6204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 6095, 6204);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 6283, 6304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 6289, 6302);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 6283, 6304);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 6216, 6315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 6216, 6315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override TypeLayout Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 6394, 6429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 6400, 6427);

                    return default(TypeLayout);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 6394, 6429);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 6327, 6440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 6327, 6440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasStructLayoutAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 6515, 6536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 6521, 6534);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 6515, 6536);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 6452, 6547);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 6452, 6547);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet MarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 6628, 6669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 6634, 6667);

                    return f_10074_6641_6666();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 6628, 6669);

                    System.Runtime.InteropServices.CharSet
                    f_10074_6641_6666()
                    {
                        var return_v = DefaultMarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 6641, 6666);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 6559, 6680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 6559, 6680);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 6769, 6790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 6775, 6788);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 6769, 6790);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 6692, 6801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 6692, 6801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 6813, 6980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 6932, 6969);

                throw f_10074_6938_6968();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 6813, 6980);

                System.Exception
                f_10074_6938_6968()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 6938, 6968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 6813, 6980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 6813, 6980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 6992, 7135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 7088, 7124);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 6992, 7135);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 6992, 7135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 6992, 7135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 7234, 7254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 7240, 7252);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 7234, 7254);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 7147, 7265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 7147, 7265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasCodeAnalysisEmbeddedAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 7333, 7341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 7336, 7341);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 7333, 7341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 7333, 7341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 7333, 7341);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override MembersAndInitializers BuildMembersAndInitializers(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 7354, 8709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 7475, 7502);

                bool
                reportAnError = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 7516, 7912);
                    foreach (var singleDecl in f_10074_7543_7567_I(f_10074_7543_7567(declaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10074, 7516, 7912);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 7601, 7897) || true) && (reportAnError)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10074, 7601, 7897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 7660, 7775);

                            f_10074_7660_7774(diagnostics, ErrorCode.ERR_SimpleProgramMultipleUnitsWithTopLevelStatements, f_10074_7750_7773(singleDecl));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10074, 7601, 7897);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10074, 7601, 7897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 7857, 7878);

                            reportAnError = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10074, 7601, 7897);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10074, 7516, 7912);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10074, 1, 397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10074, 1, 397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 7928, 8698);

                return f_10074_7935_8697(nonTypeMembers: declaration.Declarations.SelectAsArray<SingleTypeDeclaration, Symbol>(singleDeclaration => new SynthesizedSimpleProgramEntryPointSymbol(this, singleDeclaration, diagnostics)), staticInitializers: ImmutableArray<ImmutableArray<FieldOrPropertyInitializer>>.Empty, instanceInitializers: ImmutableArray<ImmutableArray<FieldOrPropertyInitializer>>.Empty, haveIndexers: false, isNullableEnabledForInstanceConstructorsAndFields: false, isNullableEnabledForStaticConstructorsAndFields: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 7354, 8709);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10074_7543_7567(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 7543, 7567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10074_7750_7773(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 7750, 7773);
                    return return_v;
                }


                int
                f_10074_7660_7774(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    Binder.Error(diagnostics, code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 7660, 7774);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10074_7543_7567_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 7543, 7567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.MembersAndInitializers
                f_10074_7935_8697(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                nonTypeMembers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                staticInitializers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                instanceInitializers, bool
                haveIndexers, bool
                isNullableEnabledForInstanceConstructorsAndFields, bool
                isNullableEnabledForStaticConstructorsAndFields)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.MembersAndInitializers(nonTypeMembers: nonTypeMembers, staticInitializers: staticInitializers, instanceInitializers: instanceInitializers, haveIndexers: haveIndexers, isNullableEnabledForInstanceConstructorsAndFields: isNullableEnabledForInstanceConstructorsAndFields, isNullableEnabledForStaticConstructorsAndFields: isNullableEnabledForStaticConstructorsAndFields);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 7935, 8697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 7354, 8709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 7354, 8709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 8763, 8771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 8766, 8771);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 8763, 8771);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 8763, 8771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 8763, 8771);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 8784, 9308);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 8936, 9268);
                    foreach (var member in f_10074_8959_9001_I(f_10074_8959_8986(this).NonTypeMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10074, 8936, 9268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 9035, 9084);

                        cancellationToken.ThrowIfCancellationRequested();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 9104, 9253) || true) && (f_10074_9108_9180(member, tree, definedWithinSpan, cancellationToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10074, 9104, 9253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 9222, 9234);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10074, 9104, 9253);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10074, 8936, 9268);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10074, 1, 333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10074, 1, 333);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 9284, 9297);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 8784, 9308);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.MembersAndInitializers
                f_10074_8959_8986(Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersAndInitializers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 8959, 8986);
                    return return_v;
                }


                bool
                f_10074_9108_9180(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan?
                definedWithinSpan, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.IsDefinedInSourceTree(tree, definedWithinSpan, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 9108, 9180);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10074_8959_9001_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 8959, 9001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 8784, 9308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 8784, 9308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 9320, 9755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 9478, 9539);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10074, 9478, 9538);

                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 9478, 9538);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 9555, 9744);

                f_10074_9555_9743(ref attributes, f_10074_9612_9742(f_10074_9612_9637(this), WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 9320, 9755);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10074_9612_9637(Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 9612, 9637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10074_9612_9742(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 9612, 9742);
                    return return_v;
                }


                int
                f_10074_9555_9743(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 9555, 9743);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 9320, 9755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 9320, 9755);
            }
        }

        internal override NamedTypeSymbol AsNativeInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 10063, 10187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 10139, 10176);

                throw f_10074_10145_10175();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 10063, 10187);

                System.Exception
                f_10074_10145_10175()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 10145, 10175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 10063, 10187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 10063, 10187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol? NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10074, 10514, 10521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10074, 10517, 10521);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10074, 10514, 10521);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10074, 10514, 10521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 10514, 10521);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SimpleProgramNamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10074, 757, 10529);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10074, 757, 10529);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10074, 757, 10529);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10074, 757, 10529);

        bool
        f_10074_1091_1124(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.IsGlobalNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 1091, 1124);
            return return_v;
        }


        int
        f_10074_1078_1125(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 1078, 1125);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationKind
        f_10074_1153_1169(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 1153, 1169);
            return return_v;
        }


        int
        f_10074_1140_1203(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 1140, 1203);
            return 0;
        }


        string
        f_10074_1231_1247(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 1231, 1247);
            return return_v;
        }


        int
        f_10074_1218_1309(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 1218, 1309);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        f_10074_1011_1026_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10074, 858, 1422);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10074_3900_3925(Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10074, 3900, 3925);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10074_3900_3990(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SpecialType
        specialType)
        {
            var return_v = this_param.GetSpecialType(specialType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10074, 3900, 3990);
            return return_v;
        }

    }
}
