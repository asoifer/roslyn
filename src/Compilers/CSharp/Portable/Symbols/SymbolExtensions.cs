// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roslyn.Utilities;

using static System.Linq.ImmutableArrayExtensions;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static partial class SymbolExtensions
    {
        public static bool IsCompilationOutputWinMdObj(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 784, 1023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 875, 914);

                var
                comp = f_10049_886_913(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 928, 1012);

                return comp != null && (DynAbs.Tracing.TraceSender.Expression_True(10049, 935, 1011) && f_10049_951_974(f_10049_951_963(comp)) == OutputKind.WindowsRuntimeMetadata);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 784, 1023);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10049_886_913(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 886, 913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10049_951_963(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 951, 963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10049_951_974(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 951, 974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 784, 1023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 784, 1023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamedTypeSymbol ConstructIfGeneric(this NamedTypeSymbol type, ImmutableArray<TypeWithAnnotations> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 1187, 1526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 1338, 1411);

                f_10049_1338_1410(type.TypeParameters.IsEmpty == (typeArguments.Length == 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 1425, 1515);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10049, 1432, 1459) || ((type.TypeParameters.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10049, 1462, 1466)) || DynAbs.Tracing.TraceSender.Conditional_F3(10049, 1469, 1514))) ? type : f_10049_1469_1514(type, typeArguments, unbound: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 1187, 1526);

                int
                f_10049_1338_1410(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 1338, 1410);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_1469_1514(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 1469, 1514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 1187, 1526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 1187, 1526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNestedType([NotNullWhen(true)] this Symbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 1538, 1721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 1635, 1710);

                return symbol is NamedTypeSymbol && (DynAbs.Tracing.TraceSender.Expression_True(10049, 1642, 1709) && (object?)f_10049_1680_1701(symbol) != null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 1538, 1721);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_1680_1701(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 1680, 1701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 1538, 1721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 1538, 1721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAccessibleViaInheritance(this NamedTypeSymbol superType, NamedTypeSymbol subType, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 1882, 4204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3023, 3088);

                NamedTypeSymbol
                originalSuperType = f_10049_3059_3087(superType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3124, 3141);
                    for (NamedTypeSymbol?
        current = subType
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3102, 3473) || true) && ((object?)current != null)
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3203, 3285)
        , current = f_10049_3213_3285(current, ref useSiteDiagnostics), DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 3102, 3473))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 3102, 3473);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3319, 3458) || true) && (f_10049_3323_3385(f_10049_3339_3365(current), originalSuperType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 3319, 3458);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3427, 3439);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 3319, 3458);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10049, 1, 372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10049, 1, 372);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3489, 3896) || true) && (f_10049_3493_3522(originalSuperType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 3489, 3896);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3556, 3881);
                        foreach (NamedTypeSymbol current in f_10049_3592_3669_I(f_10049_3592_3669(subType, ref useSiteDiagnostics)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 3556, 3881);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3711, 3862) || true) && (f_10049_3715_3777(f_10049_3731_3757(current), originalSuperType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 3711, 3862);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 3827, 3839);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 3711, 3862);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 3556, 3881);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10049, 1, 326);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10049, 1, 326);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 3489, 3896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 4101, 4193);

                return f_10049_4108_4126(superType) == TypeKind.Submission && (DynAbs.Tracing.TraceSender.Expression_True(10049, 4108, 4192) && f_10049_4153_4169(subType) == TypeKind.Submission);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 1882, 4204);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_3059_3087(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 3059, 3087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_3213_3285(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 3213, 3285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_3339_3365(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 3339, 3365);
                    return return_v;
                }


                bool
                f_10049_3323_3385(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 3323, 3385);
                    return return_v;
                }


                bool
                f_10049_3493_3522(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 3493, 3522);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10049_3592_3669(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 3592, 3669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_3731_3757(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 3731, 3757);
                    return return_v;
                }


                bool
                f_10049_3715_3777(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 3715, 3777);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10049_3592_3669_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 3592, 3669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10049_4108_4126(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 4108, 4126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10049_4153_4169(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 4153, 4169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 1882, 4204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 1882, 4204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNoMoreVisibleThan(this Symbol symbol, TypeSymbol type, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 4216, 4441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 4365, 4430);

                return f_10049_4372_4429(type, symbol, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 4216, 4441);

                bool
                f_10049_4372_4429(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbol
                sym, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = type.IsAtLeastAsVisibleAs(sym, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 4372, 4429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 4216, 4441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 4216, 4441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNoMoreVisibleThan(this Symbol symbol, TypeWithAnnotations type, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 4453, 4687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 4611, 4676);

                return type.IsAtLeastAsVisibleAs(symbol, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 4453, 4687);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 4453, 4687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 4453, 4687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LocalizableErrorArgument GetKindText(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 4699, 4835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 4794, 4824);

                return f_10049_4801_4823(f_10049_4801_4812(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 4699, 4835);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_4801_4812(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 4801, 4812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10049_4801_4823(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 4801, 4823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 4699, 4835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 4699, 4835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamespaceOrTypeSymbol? ContainingNamespaceOrType(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 5043, 5621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 5152, 5199);

                var
                containingSymbol = f_10049_5175_5198(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 5213, 5584) || true) && ((object?)containingSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 5213, 5584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 5284, 5569);

                    switch (f_10049_5292_5313(containingSymbol))
                    {

                        case SymbolKind.Namespace:
                        case SymbolKind.NamedType:
                        case SymbolKind.ErrorType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 5284, 5569);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 5503, 5550);

                            return (NamespaceOrTypeSymbol)containingSymbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 5284, 5569);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 5213, 5584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 5598, 5610);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 5043, 5621);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10049_5175_5198(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 5175, 5198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10049_5292_5313(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 5292, 5313);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 5043, 5621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 5043, 5621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol? ContainingNonLambdaMember(this Symbol? containingMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 5633, 6160);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 5738, 6109) || true) && (containingMember is object && (DynAbs.Tracing.TraceSender.Expression_True(10049, 5745, 5817) && f_10049_5775_5796(containingMember) == SymbolKind.Method))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 5738, 6109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 5851, 5895);

                        var
                        method = (MethodSymbol)containingMember
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 5913, 6023) || true) && (f_10049_5917_5934(method) != MethodKind.AnonymousFunction && (DynAbs.Tracing.TraceSender.Expression_True(10049, 5917, 6015) && f_10049_5970_5987(method) != MethodKind.LocalFunction))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 5913, 6023);
                            DynAbs.Tracing.TraceSender.TraceBreak(10049, 6017, 6023);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 5913, 6023);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6041, 6094);

                        containingMember = f_10049_6060_6093(containingMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 5738, 6109);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10049, 5738, 6109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10049, 5738, 6109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6125, 6149);

                return containingMember;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 5633, 6160);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_5775_5796(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 5775, 5796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10049_5917_5934(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 5917, 5934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10049_5970_5987(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 5970, 5987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10049_6060_6093(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 6060, 6093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 5633, 6160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 5633, 6160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ParameterSymbol? EnclosingThisSymbol(this Symbol containingMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 6172, 7813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6279, 6312);

                Symbol
                symbol = containingMember
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6326, 7802) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 6326, 7802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6371, 6392);

                        NamedTypeSymbol
                        type
                        = default(NamedTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6412, 7424);

                        switch (f_10049_6420_6431(symbol))
                        {

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 6412, 7424);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6522, 6565);

                                MethodSymbol
                                method = (MethodSymbol)symbol
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6635, 6894) || true) && (f_10049_6639_6656(method) == MethodKind.AnonymousFunction || (DynAbs.Tracing.TraceSender.Expression_False(10049, 6639, 6737) || f_10049_6692_6709(method) == MethodKind.LocalFunction))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 6635, 6894);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6795, 6828);

                                    symbol = f_10049_6804_6827(method);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6858, 6867);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 6635, 6894);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 6922, 6950);

                                return f_10049_6929_6949(method);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 6412, 7424);

                            case SymbolKind.Field:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 6412, 7424);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 7079, 7108);

                                type = f_10049_7086_7107(symbol);
                                DynAbs.Tracing.TraceSender.TraceBreak(10049, 7134, 7140);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 6412, 7424);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 6412, 7424);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 7272, 7303);

                                type = (NamedTypeSymbol)symbol;
                                DynAbs.Tracing.TraceSender.TraceBreak(10049, 7329, 7335);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 6412, 7424);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 6412, 7424);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 7393, 7405);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 6412, 7424);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 7703, 7787);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10049, 7710, 7728) || ((f_10049_7710_7728(type) && DynAbs.Tracing.TraceSender.Conditional_F2(10049, 7731, 7779)) || DynAbs.Tracing.TraceSender.Conditional_F3(10049, 7782, 7786))) ? f_10049_7731_7779(type.InstanceConstructors.Single()) : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 6326, 7802);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10049, 6326, 7802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10049, 6326, 7802);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 6172, 7813);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_6420_6431(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 6420, 6431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10049_6639_6656(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 6639, 6656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10049_6692_6709(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 6692, 6709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10049_6804_6827(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 6804, 6827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10049_6929_6949(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 6929, 6949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_7086_7107(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 7086, 7107);
                    return return_v;
                }


                bool
                f_10049_7710_7728(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 7710, 7728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10049_7731_7779(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 7731, 7779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 6172, 7813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 6172, 7813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Symbol ConstructedFrom(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 7825, 8297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 7906, 8286);

                switch (f_10049_7914_7925(symbol))
                {

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 7906, 8286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 8007, 8056);

                        return f_10049_8014_8055(((NamedTypeSymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 7906, 8286);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 7906, 8286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 8121, 8167);

                        return f_10049_8128_8166(((MethodSymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 7906, 8286);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 7906, 8286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 8217, 8271);

                        throw f_10049_8223_8270(f_10049_8258_8269(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 7906, 8286);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 7825, 8297);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_7914_7925(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 7914, 7925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_8014_8055(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 8014, 8055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10049_8128_8166(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 8128, 8166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10049_8258_8269(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 8258, 8269);
                    return return_v;
                }


                System.Exception
                f_10049_8223_8270(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 8223, 8270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 7825, 8297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 7825, 8297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsSourceParameterWithEnumeratorCancellationAttribute(this ParameterSymbol parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 8309, 8832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 8437, 8821);

                switch (parameter)
                {

                    case SourceComplexParameterSymbol source:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 8437, 8821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 8551, 8600);

                        return f_10049_8558_8599(source);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 8437, 8821);

                    case SynthesizedComplexParameterSymbol synthesized:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 8437, 8821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 8691, 8745);

                        return f_10049_8698_8744(synthesized);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 8437, 8821);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 8437, 8821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 8793, 8806);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 8437, 8821);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 8309, 8832);

                bool
                f_10049_8558_8599(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasEnumeratorCancellationAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 8558, 8599);
                    return return_v;
                }


                bool
                f_10049_8698_8744(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasEnumeratorCancellationAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 8698, 8744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 8309, 8832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 8309, 8832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsContainingSymbolOfAllTypeParameters(this Symbol containingSymbol, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 9037, 9255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 9165, 9244);

                return f_10049_9172_9235(type, s_hasInvalidTypeParameterFunc, containingSymbol) is null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 9037, 9255);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10049_9172_9235(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbol, bool, bool>
                predicate, Microsoft.CodeAnalysis.CSharp.Symbol
                arg)
                {
                    var return_v = type.VisitType<Microsoft.CodeAnalysis.CSharp.Symbol>(predicate, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 9172, 9235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 9037, 9255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 9037, 9255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsContainingSymbolOfAllTypeParameters(this Symbol containingSymbol, ImmutableArray<TypeSymbol> types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 9461, 9690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 9606, 9679);

                return types.All(containingSymbol.IsContainingSymbolOfAllTypeParameters);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 9461, 9690);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 9461, 9690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 9461, 9690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<TypeSymbol, Symbol, bool, bool> s_hasInvalidTypeParameterFunc;

        private static bool HasInvalidTypeParameter(TypeSymbol type, Symbol? containingSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 9904, 10552);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 10015, 10514) || true) && (f_10049_10019_10032(type) == TypeKind.TypeParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 10015, 10514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 10092, 10127);

                    var
                    symbol = f_10049_10105_10126(type)
                    ;
                    try
                    {
                        for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 10145, 10469) || true) && (((object?)containingSymbol != null) && (DynAbs.Tracing.TraceSender.Expression_True(10049, 10152, 10238) && (f_10049_10192_10213(containingSymbol) != SymbolKind.Namespace)))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 10240, 10292)
   , containingSymbol = f_10049_10259_10292(containingSymbol), DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 10145, 10469))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 10145, 10469);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 10334, 10450) || true) && (containingSymbol == symbol)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 10334, 10450);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 10414, 10427);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 10334, 10450);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10049, 1, 325);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10049, 1, 325);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 10487, 10499);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 10015, 10514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 10528, 10541);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 9904, 10552);

                Microsoft.CodeAnalysis.TypeKind
                f_10049_10019_10032(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 10019, 10032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10049_10105_10126(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 10105, 10126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10049_10192_10213(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 10192, 10213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10049_10259_10292(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 10259, 10292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 9904, 10552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 9904, 10552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsTypeOrTypeAlias(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 10564, 11304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 10645, 11293);

                switch (f_10049_10653_10664(symbol))
                {

                    case SymbolKind.ArrayType:
                    case SymbolKind.DynamicType:
                    case SymbolKind.ErrorType:
                    case SymbolKind.NamedType:
                    case SymbolKind.PointerType:
                    case SymbolKind.FunctionPointerType:
                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 10645, 11293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 11028, 11040);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 10645, 11293);

                    case SymbolKind.Alias:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 10645, 11293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 11102, 11157);

                        return f_10049_11109_11156(f_10049_11127_11155(((AliasSymbol)symbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 10645, 11293);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 10645, 11293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 11205, 11243);

                        f_10049_11205_11242(!(symbol is TypeSymbol));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 11265, 11278);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 10645, 11293);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 10564, 11304);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_10653_10664(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 10653, 10664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10049_11127_11155(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 11127, 11155);
                    return return_v;
                }


                bool
                f_10049_11109_11156(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol)
                {
                    var return_v = symbol.IsTypeOrTypeAlias();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 11109, 11156);
                    return return_v;
                }


                int
                f_10049_11205_11242(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 11205, 11242);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 10564, 11304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 10564, 11304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CompilationAllowsUnsafe(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 11316, 11471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 11405, 11460);

                return f_10049_11412_11459(f_10049_11412_11447(f_10049_11412_11439(symbol)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 11316, 11471);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10049_11412_11439(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 11412, 11439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10049_11412_11447(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 11412, 11447);
                    return return_v;
                }


                bool
                f_10049_11412_11459(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AllowUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 11412, 11459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 11316, 11471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 11316, 11471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CheckUnsafeModifier(this Symbol symbol, DeclarationModifiers modifiers, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 11483, 11710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 11627, 11699);

                f_10049_11627_11698(symbol, modifiers, f_10049_11665_11681(symbol)[0], diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 11483, 11710);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10049_11665_11681(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 11665, 11681);
                    return return_v;
                }


                int
                f_10049_11627_11698(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    symbol.CheckUnsafeModifier(modifiers, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 11627, 11698);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 11483, 11710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 11483, 11710);
            }
        }

        internal static void CheckUnsafeModifier(this Symbol symbol, DeclarationModifiers modifiers, Location errorLocation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 11722, 12179);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 11890, 12168) || true) && (((modifiers & DeclarationModifiers.Unsafe) == DeclarationModifiers.Unsafe) && (DynAbs.Tracing.TraceSender.Expression_True(10049, 11894, 12005) && !f_10049_11973_12005(symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 11890, 12168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 12039, 12075);

                    f_10049_12039_12074(errorLocation != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 12093, 12153);

                    f_10049_12093_12152(diagnostics, ErrorCode.ERR_IllegalUnsafe, errorLocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 11890, 12168);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 11722, 12179);

                bool
                f_10049_11973_12005(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.CompilationAllowsUnsafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 11973, 12005);
                    return return_v;
                }


                int
                f_10049_12039_12074(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 12039, 12074);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10049_12093_12152(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 12093, 12152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 11722, 12179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 11722, 12179);
            }
        }

        public static bool IsHiddenByCodeAnalysisEmbeddedAttribute(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 12348, 12974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 12509, 12616);

                var
                upperLevelType = (DynAbs.Tracing.TraceSender.Conditional_F1(10049, 12530, 12565) || ((f_10049_12530_12541(symbol) == SymbolKind.NamedType && DynAbs.Tracing.TraceSender.Conditional_F2(10049, 12568, 12591)) || DynAbs.Tracing.TraceSender.Conditional_F3(10049, 12594, 12615))) ? (NamedTypeSymbol)symbol : f_10049_12594_12615(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 12630, 12727) || true) && ((object?)upperLevelType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 12630, 12727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 12699, 12712);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 12630, 12727);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 12743, 12892) || true) && ((object?)f_10049_12759_12788(upperLevelType) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 12743, 12892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 12830, 12877);

                        upperLevelType = f_10049_12847_12876(upperLevelType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 12743, 12892);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10049, 12743, 12892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10049, 12743, 12892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 12908, 12963);

                return f_10049_12915_12962(upperLevelType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 12348, 12974);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_12530_12541(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 12530, 12541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_12594_12615(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 12594, 12615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_12759_12788(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 12759, 12788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_12847_12876(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 12847, 12876);
                    return return_v;
                }


                bool
                f_10049_12915_12962(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.HasCodeAnalysisEmbeddedAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 12915, 12962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 12348, 12974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 12348, 12974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool MustCallMethodsDirectly(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 12986, 13431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 13073, 13420);

                switch (f_10049_13081_13092(symbol))
                {

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 13073, 13420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 13173, 13229);

                        return f_10049_13180_13228(((PropertySymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 13073, 13420);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 13073, 13420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 13291, 13344);

                        return f_10049_13298_13343(((EventSymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 13073, 13420);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 13073, 13420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 13392, 13405);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 13073, 13420);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 12986, 13431);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_13081_13092(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 13081, 13092);
                    return return_v;
                }


                bool
                f_10049_13180_13228(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.MustCallMethodsDirectly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 13180, 13228);
                    return return_v;
                }


                bool
                f_10049_13298_13343(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.MustCallMethodsDirectly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 13298, 13343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 12986, 13431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 12986, 13431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int GetArity(this Symbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 13443, 13898);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 13515, 13862) || true) && (symbol is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 13515, 13862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 13569, 13847);

                    switch (f_10049_13577_13588(symbol))
                    {

                        case SymbolKind.NamedType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 13569, 13847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 13682, 13721);

                            return f_10049_13689_13720(((NamedTypeSymbol)symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 13569, 13847);

                        case SymbolKind.Method:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 13569, 13847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 13792, 13828);

                            return f_10049_13799_13827(((MethodSymbol)symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 13569, 13847);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 13515, 13862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 13878, 13887);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 13443, 13898);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_13577_13588(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 13577, 13588);
                    return return_v;
                }


                int
                f_10049_13689_13720(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 13689, 13720);
                    return return_v;
                }


                int
                f_10049_13799_13827(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 13799, 13827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 13443, 13898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 13443, 13898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSharpSyntaxNode GetNonNullSyntaxNode(this Symbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 13910, 14779);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14009, 14694) || true) && (symbol is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 14009, 14694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14063, 14142);

                    SyntaxReference?
                    reference = symbol.DeclaringSyntaxReferences.FirstOrDefault()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14162, 14530) || true) && (reference == null && (DynAbs.Tracing.TraceSender.Expression_True(10049, 14166, 14214) && f_10049_14187_14214(symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 14162, 14530);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14256, 14307);

                        Symbol?
                        containingSymbol = f_10049_14283_14306(symbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14329, 14511) || true) && ((object?)containingSymbol != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 14329, 14511);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14416, 14488);

                            reference = containingSymbol.DeclaringSyntaxReferences.FirstOrDefault();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 14329, 14511);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 14162, 14530);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14550, 14679) || true) && (reference != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 14550, 14679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14613, 14660);

                        return (CSharpSyntaxNode)f_10049_14638_14659(reference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 14550, 14679);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 14009, 14694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14710, 14768);

                return (CSharpSyntaxNode)f_10049_14735_14767(CSharpSyntaxTree.Dummy);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 13910, 14779);

                bool
                f_10049_14187_14214(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 14187, 14214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10049_14283_14306(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 14283, 14306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10049_14638_14659(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 14638, 14659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10049_14735_14767(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 14735, 14767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 13910, 14779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 13910, 14779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static Symbol? EnsureCSharpSymbolOrNull(this ISymbol? symbol, string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 14791, 15325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 14950, 14994);

                var
                csSymbol = symbol as PublicModel.Symbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 15010, 15265) || true) && (csSymbol is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 15010, 15265);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 15064, 15218) || true) && (symbol is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 15064, 15218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 15126, 15199);

                        throw f_10049_15132_15198(f_10049_15154_15186(), paramName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 15064, 15218);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 15238, 15250);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 15010, 15265);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 15281, 15314);

                return f_10049_15288_15313(csSymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 14791, 15325);

                string
                f_10049_15154_15186()
                {
                    var return_v = CSharpResources.NotACSharpSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 15154, 15186);
                    return return_v;
                }


                System.ArgumentException
                f_10049_15132_15198(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 15132, 15198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10049_15288_15313(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param)
                {
                    var return_v = this_param.UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 15288, 15313);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 14791, 15325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 14791, 15325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static AssemblySymbol? EnsureCSharpSymbolOrNull(this IAssemblySymbol? symbol, string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 15337, 15601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 15512, 15590);

                return (AssemblySymbol?)f_10049_15536_15589(symbol, paramName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 15337, 15601);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10049_15536_15589(Microsoft.CodeAnalysis.IAssemblySymbol?
                symbol, string
                paramName)
                {
                    var return_v = ((ISymbol?)symbol).EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 15536, 15589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 15337, 15601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 15337, 15601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static NamespaceOrTypeSymbol? EnsureCSharpSymbolOrNull(this INamespaceOrTypeSymbol? symbol, string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 15613, 15898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 15802, 15887);

                return (NamespaceOrTypeSymbol?)f_10049_15833_15886(symbol, paramName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 15613, 15898);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10049_15833_15886(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                symbol, string
                paramName)
                {
                    var return_v = ((ISymbol?)symbol).EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 15833, 15886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 15613, 15898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 15613, 15898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static NamespaceSymbol? EnsureCSharpSymbolOrNull(this INamespaceSymbol? symbol, string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 15910, 16177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 16087, 16166);

                return (NamespaceSymbol?)f_10049_16112_16165(symbol, paramName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 15910, 16177);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10049_16112_16165(Microsoft.CodeAnalysis.INamespaceSymbol?
                symbol, string
                paramName)
                {
                    var return_v = ((ISymbol?)symbol).EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 16112, 16165);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 15910, 16177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 15910, 16177);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static TypeSymbol? EnsureCSharpSymbolOrNull(this ITypeSymbol? symbol, string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 16189, 16441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 16356, 16430);

                return (TypeSymbol?)f_10049_16376_16429(symbol, paramName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 16189, 16441);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10049_16376_16429(Microsoft.CodeAnalysis.ITypeSymbol?
                symbol, string
                paramName)
                {
                    var return_v = ((ISymbol?)symbol).EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 16376, 16429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 16189, 16441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 16189, 16441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static NamedTypeSymbol? EnsureCSharpSymbolOrNull(this INamedTypeSymbol? symbol, string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 16453, 16720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 16630, 16709);

                return (NamedTypeSymbol?)f_10049_16655_16708(symbol, paramName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 16453, 16720);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10049_16655_16708(Microsoft.CodeAnalysis.INamedTypeSymbol?
                symbol, string
                paramName)
                {
                    var return_v = ((ISymbol?)symbol).EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 16655, 16708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 16453, 16720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 16453, 16720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static TypeParameterSymbol? EnsureCSharpSymbolOrNull(this ITypeParameterSymbol? symbol, string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 16732, 17011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 16917, 17000);

                return (TypeParameterSymbol?)f_10049_16946_16999(symbol, paramName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 16732, 17011);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10049_16946_16999(Microsoft.CodeAnalysis.ITypeParameterSymbol?
                symbol, string
                paramName)
                {
                    var return_v = ((ISymbol?)symbol).EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 16946, 16999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 16732, 17011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 16732, 17011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static EventSymbol? EnsureCSharpSymbolOrNull(this IEventSymbol? symbol, string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 17023, 17278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 17192, 17267);

                return (EventSymbol?)f_10049_17213_17266(symbol, paramName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 17023, 17278);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10049_17213_17266(Microsoft.CodeAnalysis.IEventSymbol?
                symbol, string
                paramName)
                {
                    var return_v = ((ISymbol?)symbol).EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 17213, 17266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 17023, 17278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 17023, 17278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeWithAnnotations GetTypeOrReturnType(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 17290, 17565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 17390, 17421);

                TypeWithAnnotations
                returnType
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 17435, 17522);

                f_10049_17435_17521(symbol, refKind: out _, out returnType, refCustomModifiers: out _);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 17536, 17554);

                return returnType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 17290, 17565);

                int
                f_10049_17435_17521(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out Microsoft.CodeAnalysis.RefKind
                refKind, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers)
                {
                    symbol.GetTypeOrReturnType(out refKind, out returnType, out refCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 17435, 17521);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 17290, 17565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 17290, 17565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static FlowAnalysisAnnotations GetFlowAnalysisAnnotations(this PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 17577, 18921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 17721, 17770);

                var
                temp = f_10049_17732_17769(property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 17784, 17889);

                var
                annotations = ((DynAbs.Tracing.TraceSender.Conditional_F1(10049, 17803, 17815) || ((temp != null && DynAbs.Tracing.TraceSender.Conditional_F2(10049, 17818, 17856)) || DynAbs.Tracing.TraceSender.Conditional_F3(10049, 17859, 17887))) ? f_10049_17818_17856(temp) : FlowAnalysisAnnotations.None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 17903, 17990);

                var
                temp2 = (DynAbs.Tracing.TraceSender.Conditional_F1(10049, 17915, 17957) || ((temp != null && (DynAbs.Tracing.TraceSender.Expression_True(10049, 17915, 17957) && temp.Parameters.Length > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10049, 17960, 17982)) || DynAbs.Tracing.TraceSender.Conditional_F3(10049, 17985, 17989))) ? temp.Parameters.Last() : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 18004, 18875) || true) && (temp2 != null && (DynAbs.Tracing.TraceSender.Expression_True(10049, 18008, 18079) && f_10049_18025_18054(temp2) is { } setterAnnotations))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 18004, 18875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 18113, 18146);

                    annotations |= setterAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 18004, 18875);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 18004, 18875);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 18180, 18875) || true) && (property is SourcePropertySymbolBase sourceProperty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 18180, 18875);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 18554, 18695) || true) && (f_10049_18558_18585(sourceProperty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 18554, 18695);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 18627, 18676);

                            annotations |= FlowAnalysisAnnotations.AllowNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 18554, 18695);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 18713, 18860) || true) && (f_10049_18717_18747(sourceProperty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 18713, 18860);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 18789, 18841);

                            annotations |= FlowAnalysisAnnotations.DisallowNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 18713, 18860);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 18180, 18875);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 18004, 18875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 18891, 18910);

                return annotations;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 17577, 18921);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10049_17732_17769(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 17732, 17769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10049_17818_17856(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeFlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 17818, 17856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10049_18025_18054(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.FlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 18025, 18054);
                    return return_v;
                }


                bool
                f_10049_18558_18585(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.HasAllowNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 18558, 18585);
                    return return_v;
                }


                bool
                f_10049_18717_18747(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.HasDisallowNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 18717, 18747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 17577, 18921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 17577, 18921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static FlowAnalysisAnnotations GetFlowAnalysisAnnotations(this Symbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 18933, 19473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19045, 19462);

                return symbol switch
                {
                    MethodSymbol method when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19098, 19161) && DynAbs.Tracing.TraceSender.Expression_True(10049, 19098, 19161))
    => f_10049_19121_19161(method),
                    PropertySymbol property when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19180, 19244) && DynAbs.Tracing.TraceSender.Expression_True(10049, 19180, 19244))
    => f_10049_19207_19244(property),
                    ParameterSymbol parameter when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19263, 19325) && DynAbs.Tracing.TraceSender.Expression_True(10049, 19263, 19325))
    => f_10049_19292_19325(parameter),
                    FieldSymbol field when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19344, 19394) && DynAbs.Tracing.TraceSender.Expression_True(10049, 19344, 19394))
    => f_10049_19365_19394(field),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19413, 19446) && DynAbs.Tracing.TraceSender.Expression_True(10049, 19413, 19446))
    => FlowAnalysisAnnotations.None
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 18933, 19473);

                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10049_19121_19161(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeFlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 19121, 19161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10049_19207_19244(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetFlowAnalysisAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 19207, 19244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10049_19292_19325(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.FlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 19292, 19325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10049_19365_19394(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.FlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 19365, 19394);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 18933, 19473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 18933, 19473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void GetTypeOrReturnType(this Symbol symbol, out RefKind refKind, out TypeWithAnnotations returnType,
                                                         out ImmutableArray<CustomModifier> refCustomModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 19485, 22102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19732, 22091);

                switch (f_10049_19740_19751(symbol))
                {

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 19732, 22091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19829, 19869);

                        FieldSymbol
                        field = (FieldSymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19891, 19914);

                        refKind = RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19936, 19975);

                        returnType = f_10049_19949_19974(field);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 19997, 20055);

                        refCustomModifiers = ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceBreak(10049, 20077, 20083);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 19732, 22091);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 19732, 22091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20146, 20189);

                        MethodSymbol
                        method = (MethodSymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20211, 20236);

                        refKind = f_10049_20221_20235(method);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20258, 20304);

                        returnType = f_10049_20271_20303(method);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20326, 20373);

                        refCustomModifiers = f_10049_20347_20372(method);
                        DynAbs.Tracing.TraceSender.TraceBreak(10049, 20395, 20401);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 19732, 22091);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 19732, 22091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20466, 20515);

                        PropertySymbol
                        property = (PropertySymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20537, 20564);

                        refKind = f_10049_20547_20563(property);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20586, 20628);

                        returnType = f_10049_20599_20627(property);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20650, 20699);

                        refCustomModifiers = f_10049_20671_20698(property);
                        DynAbs.Tracing.TraceSender.TraceBreak(10049, 20721, 20727);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 19732, 22091);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 19732, 22091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20789, 20830);

                        EventSymbol
                        @event = (EventSymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20852, 20875);

                        refKind = RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20897, 20937);

                        returnType = f_10049_20910_20936(@event);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 20959, 21017);

                        refCustomModifiers = ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceBreak(10049, 21039, 21045);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 19732, 22091);

                    case SymbolKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 19732, 22091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21107, 21147);

                        LocalSymbol
                        local = (LocalSymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21169, 21193);

                        refKind = f_10049_21179_21192(local);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21215, 21254);

                        returnType = f_10049_21228_21253(local);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21276, 21334);

                        refCustomModifiers = ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceBreak(10049, 21356, 21362);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 19732, 22091);

                    case SymbolKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 19732, 22091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21428, 21480);

                        ParameterSymbol
                        parameter = (ParameterSymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21502, 21530);

                        refKind = f_10049_21512_21529(parameter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21552, 21595);

                        returnType = f_10049_21565_21594(parameter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21617, 21667);

                        refCustomModifiers = f_10049_21638_21666(parameter);
                        DynAbs.Tracing.TraceSender.TraceBreak(10049, 21689, 21695);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 19732, 22091);

                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 19732, 22091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21761, 21784);

                        refKind = RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21806, 21866);

                        returnType = TypeWithAnnotations.Create((TypeSymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 21888, 21946);

                        refCustomModifiers = ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceBreak(10049, 21968, 21974);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 19732, 22091);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 19732, 22091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 22022, 22076);

                        throw f_10049_22028_22075(f_10049_22063_22074(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 19732, 22091);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 19485, 22102);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_19740_19751(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 19740, 19751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10049_19949_19974(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 19949, 19974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10049_20221_20235(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 20221, 20235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10049_20271_20303(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 20271, 20303);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10049_20347_20372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 20347, 20372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10049_20547_20563(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 20547, 20563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10049_20599_20627(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 20599, 20627);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10049_20671_20698(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 20671, 20698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10049_20910_20936(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 20910, 20936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10049_21179_21192(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 21179, 21192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10049_21228_21253(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 21228, 21253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10049_21512_21529(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 21512, 21529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10049_21565_21594(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 21565, 21594);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10049_21638_21666(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 21638, 21666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10049_22063_22074(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22063, 22074);
                    return return_v;
                }


                System.Exception
                f_10049_22028_22075(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 22028, 22075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 19485, 22102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 19485, 22102);
            }
        }

        internal static bool IsImplementableInterfaceMember(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 22114, 22357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 22210, 22346);

                return f_10049_22217_22233_M(!symbol.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10049, 22217, 22253) && f_10049_22237_22253_M(!symbol.IsSealed)) && (DynAbs.Tracing.TraceSender.Expression_True(10049, 22217, 22296) && (f_10049_22258_22275(symbol) || (DynAbs.Tracing.TraceSender.Expression_False(10049, 22258, 22295) || f_10049_22279_22295(symbol)))) && (DynAbs.Tracing.TraceSender.Expression_True(10049, 22217, 22345) && (f_10049_22301_22335_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10049_22301_22322(symbol), 10049, 22301, 22335)?.IsInterface) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10049, 22301, 22344) ?? false)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 22114, 22357);

                bool
                f_10049_22217_22233_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22217, 22233);
                    return return_v;
                }


                bool
                f_10049_22237_22253_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22237, 22253);
                    return return_v;
                }


                bool
                f_10049_22258_22275(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22258, 22275);
                    return return_v;
                }


                bool
                f_10049_22279_22295(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22279, 22295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10049_22301_22322(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22301, 22322);
                    return return_v;
                }


                bool?
                f_10049_22301_22335_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22301, 22335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 22114, 22357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 22114, 22357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool RequiresInstanceReceiver(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 22369, 23008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 22459, 22997);

                return f_10049_22466_22477(symbol) switch
                {
                    SymbolKind.Method when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 22517, 22585) && DynAbs.Tracing.TraceSender.Expression_True(10049, 22517, 22585))
    => f_10049_22538_22585(((MethodSymbol)symbol)),
                    SymbolKind.Property when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 22604, 22676) && DynAbs.Tracing.TraceSender.Expression_True(10049, 22604, 22676))
    => f_10049_22627_22676(((PropertySymbol)symbol)),
                    SymbolKind.Field when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 22695, 22761) && DynAbs.Tracing.TraceSender.Expression_True(10049, 22695, 22761))
    => f_10049_22715_22761(((FieldSymbol)symbol)),
                    SymbolKind.Event when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 22780, 22846) && DynAbs.Tracing.TraceSender.Expression_True(10049, 22780, 22846))
    => f_10049_22800_22846(((EventSymbol)symbol)),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 22865, 22980) && DynAbs.Tracing.TraceSender.Expression_True(10049, 22865, 22980))
    => throw f_10049_22876_22980("only methods, properties, fields and events can take a receiver", nameof(symbol)),
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 22369, 23008);

                Microsoft.CodeAnalysis.SymbolKind
                f_10049_22466_22477(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22466, 22477);
                    return return_v;
                }


                bool
                f_10049_22538_22585(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22538, 22585);
                    return return_v;
                }


                bool
                f_10049_22627_22676(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22627, 22676);
                    return return_v;
                }


                bool
                f_10049_22715_22761(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22715, 22761);
                    return return_v;
                }


                bool
                f_10049_22800_22846(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 22800, 22846);
                    return return_v;
                }


                System.ArgumentException
                f_10049_22876_22980(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 22876, 22980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 22369, 23008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 22369, 23008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        private static TISymbol? GetPublicSymbol<TISymbol>(this Symbol? symbol)
                    where TISymbol : class, ISymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 23020, 23252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 23207, 23241);

                return (TISymbol?)f_10049_23225_23240_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(symbol, 10049, 23225, 23240)?.ISymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 23020, 23252);

                Microsoft.CodeAnalysis.ISymbol?
                f_10049_23225_23240_M(Microsoft.CodeAnalysis.ISymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 23225, 23240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 23020, 23252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 23020, 23252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static ISymbol? GetPublicSymbol(this Symbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 23264, 23448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 23396, 23437);

                return f_10049_23403_23436(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 23264, 23448);

                Microsoft.CodeAnalysis.ISymbol?
                f_10049_23403_23436(Microsoft.CodeAnalysis.CSharp.Symbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 23403, 23436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 23264, 23448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 23264, 23448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IMethodSymbol? GetPublicSymbol(this MethodSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 23460, 23662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 23604, 23651);

                return f_10049_23611_23650(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 23460, 23662);

                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10049_23611_23650(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IMethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 23611, 23650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 23460, 23662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 23460, 23662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IPropertySymbol? GetPublicSymbol(this PropertySymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 23674, 23882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 23822, 23871);

                return f_10049_23829_23870(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 23674, 23882);

                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10049_23829_23870(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IPropertySymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 23829, 23870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 23674, 23882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 23674, 23882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static INamedTypeSymbol? GetPublicSymbol(this NamedTypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 23894, 24105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 24044, 24094);

                return f_10049_24051_24093(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 23894, 24105);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10049_24051_24093(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.INamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 24051, 24093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 23894, 24105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 23894, 24105);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static INamespaceSymbol? GetPublicSymbol(this NamespaceSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 24117, 24328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 24267, 24317);

                return f_10049_24274_24316(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 24117, 24328);

                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_10049_24274_24316(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.INamespaceSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 24274, 24316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 24117, 24328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 24117, 24328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static ITypeSymbol? GetPublicSymbol(this TypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 24340, 24536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 24480, 24525);

                return f_10049_24487_24524(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 24340, 24536);

                Microsoft.CodeAnalysis.ITypeSymbol?
                f_10049_24487_24524(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.ITypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 24487, 24524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 24340, 24536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 24340, 24536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static ILocalSymbol? GetPublicSymbol(this LocalSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 24548, 24747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 24690, 24736);

                return f_10049_24697_24735(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 24548, 24747);

                Microsoft.CodeAnalysis.ILocalSymbol?
                f_10049_24697_24735(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.ILocalSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 24697, 24735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 24548, 24747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 24548, 24747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IAssemblySymbol? GetPublicSymbol(this AssemblySymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 24759, 24967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 24907, 24956);

                return f_10049_24914_24955(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 24759, 24967);

                Microsoft.CodeAnalysis.IAssemblySymbol?
                f_10049_24914_24955(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IAssemblySymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 24914, 24955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 24759, 24967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 24759, 24967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static INamespaceOrTypeSymbol? GetPublicSymbol(this NamespaceOrTypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 24979, 25208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 25141, 25197);

                return f_10049_25148_25196(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 24979, 25208);

                Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                f_10049_25148_25196(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 25148, 25196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 24979, 25208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 24979, 25208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IDiscardSymbol? GetPublicSymbol(this DiscardSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 25220, 25425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 25366, 25414);

                return f_10049_25373_25413(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 25220, 25425);

                Microsoft.CodeAnalysis.IDiscardSymbol?
                f_10049_25373_25413(Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IDiscardSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 25373, 25413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 25220, 25425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 25220, 25425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IFieldSymbol? GetPublicSymbol(this FieldSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 25437, 25636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 25579, 25625);

                return f_10049_25586_25624(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 25437, 25636);

                Microsoft.CodeAnalysis.IFieldSymbol?
                f_10049_25586_25624(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IFieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 25586, 25624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 25437, 25636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 25437, 25636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IParameterSymbol? GetPublicSymbol(this ParameterSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 25648, 25859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 25798, 25848);

                return f_10049_25805_25847(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 25648, 25859);

                Microsoft.CodeAnalysis.IParameterSymbol?
                f_10049_25805_25847(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 25805, 25847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 25648, 25859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 25648, 25859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IRangeVariableSymbol? GetPublicSymbol(this RangeVariableSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 25871, 26094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 26029, 26083);

                return f_10049_26036_26082(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 25871, 26094);

                Microsoft.CodeAnalysis.IRangeVariableSymbol?
                f_10049_26036_26082(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IRangeVariableSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 26036, 26082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 25871, 26094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 25871, 26094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static ILabelSymbol? GetPublicSymbol(this LabelSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 26106, 26305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 26248, 26294);

                return f_10049_26255_26293(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 26106, 26305);

                Microsoft.CodeAnalysis.ILabelSymbol?
                f_10049_26255_26293(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.ILabelSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 26255, 26293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 26106, 26305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 26106, 26305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IAliasSymbol? GetPublicSymbol(this AliasSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 26317, 26516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 26459, 26505);

                return f_10049_26466_26504(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 26317, 26516);

                Microsoft.CodeAnalysis.IAliasSymbol?
                f_10049_26466_26504(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IAliasSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 26466, 26504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 26317, 26516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 26317, 26516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IModuleSymbol? GetPublicSymbol(this ModuleSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 26528, 26730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 26672, 26719);

                return f_10049_26679_26718(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 26528, 26730);

                Microsoft.CodeAnalysis.IModuleSymbol?
                f_10049_26679_26718(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IModuleSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 26679, 26718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 26528, 26730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 26528, 26730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static ITypeParameterSymbol? GetPublicSymbol(this TypeParameterSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 26742, 26965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 26900, 26954);

                return f_10049_26907_26953(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 26742, 26965);

                Microsoft.CodeAnalysis.ITypeParameterSymbol?
                f_10049_26907_26953(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.ITypeParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 26907, 26953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 26742, 26965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 26742, 26965);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IArrayTypeSymbol? GetPublicSymbol(this ArrayTypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 26977, 27188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 27127, 27177);

                return f_10049_27134_27176(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 26977, 27188);

                Microsoft.CodeAnalysis.IArrayTypeSymbol?
                f_10049_27134_27176(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IArrayTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 27134, 27176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 26977, 27188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 26977, 27188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IPointerTypeSymbol? GetPublicSymbol(this PointerTypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 27200, 27417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 27354, 27406);

                return f_10049_27361_27405(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 27200, 27417);

                Microsoft.CodeAnalysis.IPointerTypeSymbol?
                f_10049_27361_27405(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IPointerTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 27361, 27405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 27200, 27417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 27200, 27417);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IFunctionPointerTypeSymbol? GetPublicSymbol(this FunctionPointerTypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 27429, 27670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 27599, 27659);

                return f_10049_27606_27658(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 27429, 27670);

                Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol?
                f_10049_27606_27658(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 27606, 27658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 27429, 27670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 27429, 27670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static IEventSymbol? GetPublicSymbol(this EventSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 27682, 27881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 27824, 27870);

                return f_10049_27831_27869(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 27682, 27881);

                Microsoft.CodeAnalysis.IEventSymbol?
                f_10049_27831_27869(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol<Microsoft.CodeAnalysis.IEventSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 27831, 27869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 27682, 27881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 27682, 27881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<ISymbol?> GetPublicSymbols(this IEnumerable<Symbol?> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 27893, 28075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 28007, 28064);

                return f_10049_28014_28063(symbols, p => p.GetPublicSymbol<ISymbol>());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 27893, 28075);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol?>
                f_10049_28014_28063(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol?>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.ISymbol>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbol?, Microsoft.CodeAnalysis.ISymbol?>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 28014, 28063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 27893, 28075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 27893, 28075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<TISymbol> GetPublicSymbols<TISymbol>(this ImmutableArray<Symbol> symbols)
                    where TISymbol : class, ISymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 28087, 28437);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 28260, 28345) || true) && (symbols.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10049, 28260, 28345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 28315, 28330);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10049, 28260, 28345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 28361, 28426);

                return symbols.SelectAsArray(p => p.GetPublicSymbol<TISymbol>());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 28087, 28437);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 28087, 28437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 28087, 28437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<ISymbol> GetPublicSymbols(this ImmutableArray<Symbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 28449, 28620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 28567, 28609);

                return GetPublicSymbols<ISymbol>(symbols);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 28449, 28620);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 28449, 28620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 28449, 28620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<IPropertySymbol> GetPublicSymbols(this ImmutableArray<PropertySymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 28632, 28852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 28766, 28841);

                return GetPublicSymbols<IPropertySymbol>(f_10049_28807_28839(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 28632, 28852);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_28807_28839(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 28807, 28839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 28632, 28852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 28632, 28852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<ITypeSymbol> GetPublicSymbols(this ImmutableArray<TypeSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 28864, 29072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 28990, 29061);

                return GetPublicSymbols<ITypeSymbol>(f_10049_29027_29059(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 28864, 29072);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_29027_29059(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 29027, 29059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 28864, 29072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 28864, 29072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<INamedTypeSymbol> GetPublicSymbols(this ImmutableArray<NamedTypeSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 29084, 29307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 29220, 29296);

                return GetPublicSymbols<INamedTypeSymbol>(f_10049_29262_29294(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 29084, 29307);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_29262_29294(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 29262, 29294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 29084, 29307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 29084, 29307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<ILocalSymbol> GetPublicSymbols(this ImmutableArray<LocalSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 29319, 29530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 29447, 29519);

                return GetPublicSymbols<ILocalSymbol>(f_10049_29485_29517(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 29319, 29530);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_29485_29517(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 29485, 29517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 29319, 29530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 29319, 29530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<IEventSymbol> GetPublicSymbols(this ImmutableArray<EventSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 29542, 29753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 29670, 29742);

                return GetPublicSymbols<IEventSymbol>(f_10049_29708_29740(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 29542, 29753);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_29708_29740(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 29708, 29740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 29542, 29753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 29542, 29753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<ITypeParameterSymbol> GetPublicSymbols(this ImmutableArray<TypeParameterSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 29765, 30000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 29909, 29989);

                return GetPublicSymbols<ITypeParameterSymbol>(f_10049_29955_29987(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 29765, 30000);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_29955_29987(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 29955, 29987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 29765, 30000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 29765, 30000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<IParameterSymbol> GetPublicSymbols(this ImmutableArray<ParameterSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 30012, 30235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 30148, 30224);

                return GetPublicSymbols<IParameterSymbol>(f_10049_30190_30222(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 30012, 30235);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_30190_30222(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 30190, 30222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 30012, 30235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 30012, 30235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<IMethodSymbol> GetPublicSymbols(this ImmutableArray<MethodSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 30247, 30461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 30377, 30450);

                return GetPublicSymbols<IMethodSymbol>(f_10049_30416_30448(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 30247, 30461);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_30416_30448(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 30416, 30448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 30247, 30461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 30247, 30461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<IAssemblySymbol> GetPublicSymbols(this ImmutableArray<AssemblySymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 30473, 30693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 30607, 30682);

                return GetPublicSymbols<IAssemblySymbol>(f_10049_30648_30680(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 30473, 30693);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_30648_30680(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 30648, 30680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 30473, 30693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 30473, 30693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<IFieldSymbol> GetPublicSymbols(this ImmutableArray<FieldSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 30705, 30916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 30833, 30905);

                return GetPublicSymbols<IFieldSymbol>(f_10049_30871_30903(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 30705, 30916);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_30871_30903(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 30871, 30903);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 30705, 30916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 30705, 30916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<INamespaceSymbol> GetPublicSymbols(this ImmutableArray<NamespaceSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 30928, 31151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 31064, 31140);

                return GetPublicSymbols<INamespaceSymbol>(f_10049_31106_31138(symbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 30928, 31151);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10049_31106_31138(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 31106, 31138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 30928, 31151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 30928, 31151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static TSymbol? GetSymbol<TSymbol>(this ISymbol? symbol)
                    where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 31163, 31411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 31335, 31400);

                return (TSymbol?)f_10049_31352_31399_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(((PublicModel.Symbol?)symbol), 10049, 31352, 31399)?.UnderlyingSymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 31163, 31411);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10049_31352_31399_M(Microsoft.CodeAnalysis.CSharp.Symbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10049, 31352, 31399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 31163, 31411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 31163, 31411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static Symbol? GetSymbol(this ISymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 31423, 31594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 31549, 31583);

                return f_10049_31556_31582(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 31423, 31594);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10049_31556_31582(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 31556, 31582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 31423, 31594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 31423, 31594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static TypeSymbol? GetSymbol(this ITypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 31606, 31789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 31740, 31778);

                return f_10049_31747_31777(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 31606, 31789);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10049_31747_31777(Microsoft.CodeAnalysis.ITypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 31747, 31777);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 31606, 31789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 31606, 31789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static NamedTypeSymbol? GetSymbol(this INamedTypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 31801, 31999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 31945, 31988);

                return f_10049_31952_31987(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 31801, 31999);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10049_31952_31987(Microsoft.CodeAnalysis.INamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 31952, 31987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 31801, 31999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 31801, 31999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static AliasSymbol? GetSymbol(this IAliasSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 32011, 32197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 32147, 32186);

                return f_10049_32154_32185(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 32011, 32197);

                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                f_10049_32154_32185(Microsoft.CodeAnalysis.IAliasSymbol?
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 32154, 32185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 32011, 32197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 32011, 32197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static LocalSymbol? GetSymbol(this ILocalSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 32209, 32395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 32345, 32384);

                return f_10049_32352_32383(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 32209, 32395);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?
                f_10049_32352_32383(Microsoft.CodeAnalysis.ILocalSymbol?
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 32352, 32383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 32209, 32395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 32209, 32395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static AssemblySymbol? GetSymbol(this IAssemblySymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 32407, 32602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 32549, 32591);

                return f_10049_32556_32590(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 32407, 32602);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                f_10049_32556_32590(Microsoft.CodeAnalysis.IAssemblySymbol?
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 32556, 32590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 32407, 32602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 32407, 32602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static MethodSymbol? GetSymbol(this IMethodSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 32614, 32803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 32752, 32792);

                return f_10049_32759_32791(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 32614, 32803);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10049_32759_32791(Microsoft.CodeAnalysis.IMethodSymbol?
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 32759, 32791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 32614, 32803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 32614, 32803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static PropertySymbol? GetSymbol(this IPropertySymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 32815, 33010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 32957, 32999);

                return f_10049_32964_32998(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 32815, 33010);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                f_10049_32964_32998(Microsoft.CodeAnalysis.IPropertySymbol?
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 32964, 32998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 32815, 33010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 32815, 33010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("symbol")]
        internal static FunctionPointerTypeSymbol? GetSymbol(this IFunctionPointerTypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10049, 33022, 33250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 33186, 33239);

                return f_10049_33193_33238(symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10049, 33022, 33250);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol?
                f_10049_33193_33238(Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10049, 33193, 33238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10049, 33022, 33250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10049, 33022, 33250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
