// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;


namespace Microsoft.CodeAnalysis.CSharp.Emit.NoPia
{
    internal sealed class EmbeddedType : EmbeddedTypesManager.CommonEmbeddedType
    {
        private bool _embeddedAllMembersOfImplementedInterface;

        public EmbeddedType(EmbeddedTypesManager typeManager, NamedTypeSymbolAdapter underlyingNamedType) : base(f_10948_1227_1238_C(typeManager), underlyingNamedType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10948, 1109, 1540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 1055, 1096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 1285, 1355);

                f_10948_1285_1354(f_10948_1298_1353(f_10948_1298_1340(underlyingNamedType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 1369, 1443);

                f_10948_1369_1442(f_10948_1382_1441(f_10948_1382_1424(underlyingNamedType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 1457, 1529);

                f_10948_1457_1528(f_10948_1470_1527_M(!f_10948_1471_1513(underlyingNamedType).IsGenericType));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10948, 1109, 1540);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 1109, 1540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 1109, 1540);
            }
        }

        public void EmbedAllMembersOfImplementedInterface(SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 1552, 2785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 1679, 1754);

                f_10948_1679_1753(f_10948_1692_1752(f_10948_1692_1734(UnderlyingNamedType)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 1770, 1871) || true) && (_embeddedAllMembersOfImplementedInterface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 1770, 1871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 1849, 1856);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 1770, 1871);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 1887, 1936);

                _embeddedAllMembersOfImplementedInterface = true;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 1986, 2282);
                    foreach (MethodSymbol m in f_10948_2013_2074_I(f_10948_2013_2074(f_10948_2013_2055(UnderlyingNamedType))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 1986, 2282);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 2108, 2267) || true) && ((object)m != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 2108, 2267);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 2171, 2248);

                            f_10948_2171_2247(TypeManager, this, f_10948_2201_2218(m), syntaxNodeOpt, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 2108, 2267);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 1986, 2282);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10948, 1, 297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10948, 1, 297);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 2521, 2774);
                    foreach (NamedTypeSymbol @interface in f_10948_2560_2624_I(f_10948_2560_2624(f_10948_2560_2602(UnderlyingNamedType))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 2521, 2774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 2658, 2759);

                        f_10948_2658_2758(TypeManager.ModuleBeingBuilt, @interface, syntaxNodeOpt, diagnostics, fromImplements: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 2521, 2774);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10948, 1, 254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10948, 1, 254);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 1552, 2785);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_1692_1734(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 1692, 1734);
                    return return_v;
                }


                bool
                f_10948_1692_1752(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 1692, 1752);
                    return return_v;
                }


                int
                f_10948_1679_1753(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 1679, 1753);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_2013_2055(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 2013, 2055);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10948_2013_2074(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMethodsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 2013, 2074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10948_2201_2218(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 2201, 2218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                f_10948_2171_2247(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethod(type, method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 2171, 2247);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10948_2013_2074_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 2013, 2074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_2560_2602(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 2560, 2602);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10948_2560_2624(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetInterfacesToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 2560, 2624);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10948_2658_2758(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                fromImplements)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt, diagnostics, fromImplements: fromImplements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 2658, 2758);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10948_2560_2624_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 2560, 2624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 1552, 2785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 1552, 2785);
            }
        }

        protected override int GetAssemblyRefIndex()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 2797, 3121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 2866, 2977);

                ImmutableArray<AssemblySymbol>
                refs = f_10948_2904_2976(TypeManager.ModuleBeingBuilt.SourceModule)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 2991, 3110);

                return refs.IndexOf(f_10948_3011_3072(f_10948_3011_3053(UnderlyingNamedType)), ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 2797, 3121);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10948_2904_2976(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 2904, 2976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_3011_3053(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 3011, 3053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10948_3011_3072(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 3011, 3072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 2797, 3121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 2797, 3121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsPublic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 3190, 3337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 3226, 3322);

                    return f_10948_3233_3297(f_10948_3233_3275(UnderlyingNamedType)) == Accessibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 3190, 3337);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_3233_3275(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 3233, 3275);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10948_3233_3297(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 3233, 3297);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 3133, 3348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 3133, 3348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.ITypeReference GetBaseClass(PEModuleBuilder moduleBuilder, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 3360, 3746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 3519, 3618);

                NamedTypeSymbol
                baseType = f_10948_3546_3617(f_10948_3546_3588(UnderlyingNamedType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 3632, 3735);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10948, 3639, 3663) || (((object)baseType != null && DynAbs.Tracing.TraceSender.Conditional_F2(10948, 3666, 3727)) || DynAbs.Tracing.TraceSender.Conditional_F3(10948, 3730, 3734))) ? f_10948_3666_3727(moduleBuilder, baseType, syntaxNodeOpt, diagnostics) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 3360, 3746);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_3546_3588(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 3546, 3588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_3546_3617(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 3546, 3617);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10948_3666_3727(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 3666, 3727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 3360, 3746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 3360, 3746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IEnumerable<FieldSymbolAdapter> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 3758, 4016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 3851, 4005);

                return f_10948_3858_3978(f_10948_3858_3918(f_10948_3858_3900(UnderlyingNamedType)), s => s.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 3758, 4016);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_3858_3900(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 3858, 3900);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10948_3858_3918(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetFieldsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 3858, 3918);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter>
                f_10948_3858_3978(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 3858, 3978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 3758, 4016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 3758, 4016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IEnumerable<MethodSymbolAdapter> GetMethodsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 4028, 4290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 4123, 4279);

                return f_10948_4130_4252(f_10948_4130_4191(f_10948_4130_4172(UnderlyingNamedType)), s => s?.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 4028, 4290);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_4130_4172(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 4130, 4172);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10948_4130_4191(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMethodsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 4130, 4191);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?>
                f_10948_4130_4252(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 4130, 4252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 4028, 4290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 4028, 4290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IEnumerable<EventSymbolAdapter> GetEventsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 4302, 4560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 4395, 4549);

                return f_10948_4402_4522(f_10948_4402_4462(f_10948_4402_4444(UnderlyingNamedType)), s => s.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 4302, 4560);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_4402_4444(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 4402, 4444);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10948_4402_4462(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEventsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 4402, 4462);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter>
                f_10948_4402_4522(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 4402, 4522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 4302, 4560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 4302, 4560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IEnumerable<PropertySymbolAdapter> GetPropertiesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 4572, 4841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 4672, 4830);

                return f_10948_4679_4803(f_10948_4679_4743(f_10948_4679_4721(UnderlyingNamedType)), s => s.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 4572, 4841);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_4679_4721(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 4679, 4721);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10948_4679_4743(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetPropertiesToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 4679, 4743);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter>
                f_10948_4679_4803(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 4679, 4803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 4572, 4841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 4572, 4841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IEnumerable<Cci.TypeReferenceWithAttributes> GetInterfaces(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 4853, 5769);

                var listYield = new List<Cci.TypeReferenceWithAttributes>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 4976, 5045);

                f_10948_4976_5044((object)TypeManager.ModuleBeingBuilt == context.Module);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 5061, 5128);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 5144, 5758);
                    foreach (NamedTypeSymbol @interface in f_10948_5183_5247_I(f_10948_5183_5247(f_10948_5183_5225(UnderlyingNamedType))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 5144, 5758);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 5281, 5460);

                        var
                        typeRef = f_10948_5295_5459(moduleBeingBuilt, @interface, (CSharpSyntaxNode)context.SyntaxNodeOpt, context.Diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 5480, 5530);

                        var
                        type = TypeWithAnnotations.Create(@interface)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 5548, 5743);

                        listYield.Add(type.GetTypeRefWithAttributes(moduleBeingBuilt, declaringSymbol: f_10948_5669_5711(UnderlyingNamedType), typeRef));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 5144, 5758);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10948, 1, 615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10948, 1, 615);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 4853, 5769);

                return listYield;

                int
                f_10948_4976_5044(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 4976, 5044);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_5183_5225(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 5183, 5225);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10948_5183_5247(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetInterfacesToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 5183, 5247);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10948_5295_5459(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 5295, 5459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_5669_5711(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 5669, 5711);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10948_5183_5247_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 5183, 5247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 4853, 5769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 4853, 5769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 5840, 5960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 5876, 5945);

                    return f_10948_5883_5944(f_10948_5883_5925(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 5840, 5960);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_5883_5925(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 5883, 5925);
                        return return_v;
                    }


                    bool
                    f_10948_5883_5944(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 5883, 5944);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 5781, 5971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 5781, 5971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsBeforeFieldInit
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 6049, 6569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 6085, 6463);

                    switch (f_10948_6093_6144(f_10948_6093_6135(UnderlyingNamedType)))
                    {

                        case TypeKind.Enum:
                        case TypeKind.Delegate:
                        //C# interfaces don't have fields so the flag doesn't really matter, but Dev10 omits it
                        case TypeKind.Interface:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 6085, 6463);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 6431, 6444);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 6085, 6463);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 6542, 6554);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 6049, 6569);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_6093_6135(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 6093, 6135);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10948_6093_6144(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 6093, 6144);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 5983, 6580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 5983, 6580);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 6652, 6765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 6688, 6750);

                    return f_10948_6695_6749(f_10948_6695_6737(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 6652, 6765);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_6695_6737(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 6695, 6737);
                        return return_v;
                    }


                    bool
                    f_10948_6695_6749(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsComImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 6695, 6749);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 6592, 6776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 6592, 6776);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 6848, 6967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 6884, 6952);

                    return f_10948_6891_6951(f_10948_6891_6933(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 6848, 6967);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_6891_6933(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 6891, 6933);
                        return return_v;
                    }


                    bool
                    f_10948_6891_6951(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsInterfaceType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 6891, 6951);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 6788, 6978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 6788, 6978);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsDelegate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 7049, 7167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 7085, 7152);

                    return f_10948_7092_7151(f_10948_7092_7134(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 7049, 7167);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_7092_7134(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 7092, 7134);
                        return return_v;
                    }


                    bool
                    f_10948_7092_7151(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsDelegateType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 7092, 7151);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 6990, 7178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 6990, 7178);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 7253, 7369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 7289, 7354);

                    return f_10948_7296_7353(f_10948_7296_7338(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 7253, 7369);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_7296_7338(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 7296, 7338);
                        return return_v;
                    }


                    bool
                    f_10948_7296_7353(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSerializable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 7296, 7353);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 7190, 7380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 7190, 7380);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 7454, 7570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 7490, 7555);

                    return f_10948_7497_7554(f_10948_7497_7539(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 7454, 7570);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_7497_7539(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 7497, 7539);
                        return return_v;
                    }


                    bool
                    f_10948_7497_7554(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 7497, 7554);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 7392, 7581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 7392, 7581);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 7664, 7788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 7700, 7773);

                    return f_10948_7707_7772(f_10948_7707_7749(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 7664, 7788);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_7707_7749(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 7707, 7749);
                        return return_v;
                    }


                    bool
                    f_10948_7707_7772(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsWindowsRuntimeImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 7707, 7772);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 7593, 7799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 7593, 7799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 7868, 7986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 7904, 7971);

                    return f_10948_7911_7970(f_10948_7911_7953(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 7868, 7986);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_7911_7953(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 7911, 7953);
                        return return_v;
                    }


                    bool
                    f_10948_7911_7970(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 7911, 7970);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 7811, 7997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 7811, 7997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override TypeLayout? GetTypeLayoutIfStruct()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 8009, 8292);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 8088, 8255) || true) && (f_10948_8092_8149(f_10948_8092_8134(UnderlyingNamedType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 8088, 8255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 8183, 8240);

                    return f_10948_8190_8239(f_10948_8190_8232(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 8088, 8255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 8269, 8281);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 8009, 8292);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_8092_8134(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 8092, 8134);
                    return return_v;
                }


                bool
                f_10948_8092_8149(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 8092, 8149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_8190_8232(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 8190, 8232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeLayout
                f_10948_8190_8239(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Layout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 8190, 8239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 8009, 8292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 8009, 8292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override System.Runtime.InteropServices.CharSet StringFormat
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 8399, 8519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 8435, 8504);

                    return f_10948_8442_8503(f_10948_8442_8484(UnderlyingNamedType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 8399, 8519);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10948_8442_8484(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 8442, 8484);
                        return return_v;
                    }


                    System.Runtime.InteropServices.CharSet
                    f_10948_8442_8503(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 8442, 8503);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 8304, 8530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 8304, 8530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 8542, 8777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 8675, 8766);

                return f_10948_8682_8765(f_10948_8682_8724(UnderlyingNamedType), moduleBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 8542, 8777);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_8682_8724(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 8682, 8724);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10948_8682_8765(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 8682, 8765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 8542, 8777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 8542, 8777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CSharpAttributeData CreateTypeIdentifierAttribute(bool hasGuid, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 8789, 11207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 8949, 9174);

                var
                member = (DynAbs.Tracing.TraceSender.Conditional_F1(10948, 8962, 8969) || ((hasGuid && DynAbs.Tracing.TraceSender.Conditional_F2(10948, 8989, 9065)) || DynAbs.Tracing.TraceSender.Conditional_F3(10948, 9085, 9173))) ? WellKnownMember.System_Runtime_InteropServices_TypeIdentifierAttribute__ctor : WellKnownMember.System_Runtime_InteropServices_TypeIdentifierAttribute__ctorStringString
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 9188, 9266);

                var
                ctor = f_10948_9199_9265(TypeManager, member, syntaxNodeOpt, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 9280, 9365) || true) && ((object)ctor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 9280, 9365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 9338, 9350);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 9280, 9365);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 9381, 11168) || true) && (hasGuid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 9381, 11168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 9542, 9680);

                    return f_10948_9549_9679(ctor, ImmutableArray<TypedConstant>.Empty, ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 9381, 11168);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 9381, 11168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 10261, 10338);

                    var
                    stringType = f_10948_10278_10337(TypeManager, syntaxNodeOpt, diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 10358, 11153) || true) && ((object)stringType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 10358, 11153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 10430, 10547);

                        string
                        guidString = f_10948_10450_10546(TypeManager, f_10948_10484_10545(f_10948_10484_10526(UnderlyingNamedType)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 10569, 11134);

                        return f_10948_10576_11133(ctor, f_10948_10648_11036(f_10948_10670_10740(stringType, TypedConstantKind.Primitive, guidString), f_10948_10795_11035(stringType, TypedConstantKind.Primitive, f_10948_10931_11034(f_10948_10931_10973(UnderlyingNamedType), SymbolDisplayFormat.QualifiedNameOnlyFormat))), ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 10358, 11153);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 9381, 11168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 11184, 11196);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 8789, 11207);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10948_9199_9265(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetWellKnownMethod(method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 9199, 9265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10948_9549_9679(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 9549, 9679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_10278_10337(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetSystemStringType(syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 10278, 10337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_10484_10526(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 10484, 10526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10948_10484_10545(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 10484, 10545);
                    return return_v;
                }


                string
                f_10948_10450_10546(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly)
                {
                    var return_v = this_param.GetAssemblyGuidString(assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 10450, 10546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10948_10670_10740(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 10670, 10740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_10931_10973(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 10931, 10973);
                    return return_v;
                }


                string
                f_10948_10931_11034(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 10931, 11034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10948_10795_11035(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 10795, 11035);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10948_10648_11036(Microsoft.CodeAnalysis.TypedConstant
                item1, Microsoft.CodeAnalysis.TypedConstant
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 10648, 11036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10948_10576_11133(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 10576, 11133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 8789, 11207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 8789, 11207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ReportMissingAttribute(AttributeDescription description, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 11219, 11552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 11377, 11541);

                f_10948_11377_11540(diagnostics, ErrorCode.ERR_InteropTypeMissingAttribute, syntaxNodeOpt, f_10948_11475_11517(UnderlyingNamedType), description.FullName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 11219, 11552);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_11475_11517(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 11475, 11517);
                    return return_v;
                }


                int
                f_10948_11377_11540(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, params object[]
                args)
                {
                    EmbeddedTypesManager.Error(diagnostics, code, syntaxOpt, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 11377, 11540);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 11219, 11552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 11219, 11552);
            }
        }

        protected override void EmbedDefaultMembers(string defaultMember, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10948, 11564, 12731);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 11707, 12720);
                    foreach (Symbol s in f_10948_11728_11796_I(f_10948_11728_11796(f_10948_11728_11770(UnderlyingNamedType), defaultMember)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 11707, 12720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 11830, 12705);

                        switch (f_10948_11838_11844(s))
                        {

                            case SymbolKind.Field:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 11830, 12705);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 11934, 12025);

                                f_10948_11934_12024(TypeManager, this, f_10948_11963_11995(((FieldSymbol)s)), syntaxNodeOpt, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10948, 12051, 12057);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 11830, 12705);

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 11830, 12705);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 12128, 12221);

                                f_10948_12128_12220(TypeManager, this, f_10948_12158_12191(((MethodSymbol)s)), syntaxNodeOpt, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10948, 12247, 12253);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 11830, 12705);

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 11830, 12705);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 12326, 12423);

                                f_10948_12326_12422(TypeManager, this, f_10948_12358_12393(((PropertySymbol)s)), syntaxNodeOpt, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10948, 12449, 12455);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 11830, 12705);

                            case SymbolKind.Event:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10948, 11830, 12705);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10948, 12525, 12654);

                                f_10948_12525_12653(TypeManager, this, f_10948_12554_12586(((EventSymbol)s)), syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding: false);
                                DynAbs.Tracing.TraceSender.TraceBreak(10948, 12680, 12686);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 11830, 12705);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10948, 11707, 12720);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10948, 1, 1014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10948, 1, 1014);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10948, 11564, 12731);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10948_11728_11770(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 11728, 11770);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10948_11728_11796(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 11728, 11796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10948_11838_11844(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 11838, 11844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10948_11963_11995(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 11963, 11995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField
                f_10948_11934_12024(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                field, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedField(type, field, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 11934, 12024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10948_12158_12191(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 12158, 12191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                f_10948_12128_12220(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethod(type, method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 12128, 12220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                f_10948_12358_12393(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 12358, 12393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty
                f_10948_12326_12422(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                property, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedProperty(type, property, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 12326, 12422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10948_12554_12586(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 12554, 12586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                f_10948_12525_12653(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                @event, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isUsedForComAwareEventBinding)
                {
                    var return_v = this_param.EmbedEvent(type, @event, syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding: isUsedForComAwareEventBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 12525, 12653);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10948_11728_11796_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 11728, 11796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10948, 11564, 12731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 11564, 12731);
            }
        }

        static EmbeddedType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10948, 949, 12738);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10948, 949, 12738);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10948, 949, 12738);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10948, 949, 12738);

        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10948_1298_1340(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
        this_param)
        {
            var return_v = this_param.AdaptedNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 1298, 1340);
            return return_v;
        }


        bool
        f_10948_1298_1353(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 1298, 1353);
            return return_v;
        }


        int
        f_10948_1285_1354(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 1285, 1354);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10948_1382_1424(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
        this_param)
        {
            var return_v = this_param.AdaptedNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 1382, 1424);
            return return_v;
        }


        bool
        f_10948_1382_1441(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        type)
        {
            var return_v = type.IsTopLevelType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 1382, 1441);
            return return_v;
        }


        int
        f_10948_1369_1442(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 1369, 1442);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10948_1471_1513(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
        this_param)
        {
            var return_v = this_param.AdaptedNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 1471, 1513);
            return return_v;
        }


        bool
        f_10948_1470_1527_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10948, 1470, 1527);
            return return_v;
        }


        int
        f_10948_1457_1528(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10948, 1457, 1528);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
        f_10948_1227_1238_C(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10948, 1109, 1540);
            return return_v;
        }

    }
}
