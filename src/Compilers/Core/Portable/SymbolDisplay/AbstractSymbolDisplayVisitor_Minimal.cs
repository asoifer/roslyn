// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.SymbolDisplay
{
    internal abstract partial class AbstractSymbolDisplayVisitor : SymbolVisitor
    {
        protected abstract bool ShouldRestrictMinimallyQualifyLookupToNamespacesAndTypes();

        protected bool IsMinimizing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(566, 623, 668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 629, 666);

                    return this.semanticModelOpt != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(566, 623, 668);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(566, 571, 679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(566, 571, 679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool NameBoundSuccessfullyToSameSymbol(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(566, 691, 2334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 789, 1063);

                ImmutableArray<ISymbol>
                normalSymbols = (DynAbs.Tracing.TraceSender.Conditional_F1(566, 829, 887) || ((f_566_829_887(this) && DynAbs.Tracing.TraceSender.Conditional_F2(566, 907, 980)) || DynAbs.Tracing.TraceSender.Conditional_F3(566, 1000, 1062))) ? f_566_907_980(semanticModelOpt, positionOpt, name: f_566_968_979(symbol)) : f_566_1000_1062(semanticModelOpt, positionOpt, name: f_566_1050_1061(symbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 1077, 1151);

                ISymbol
                normalSymbol = f_566_1100_1150(normalSymbols, f_566_1137_1149(symbol))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 1167, 1253) || true) && (normalSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 1167, 1253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 1225, 1238);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(566, 1167, 1253);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 1394, 1505) || true) && (f_566_1398_1444(normalSymbol, f_566_1418_1443(symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 1394, 1505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 1478, 1490);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(566, 1394, 1505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 1702, 1818);

                ImmutableArray<ISymbol>
                typeOnlySymbols = f_566_1744_1817(semanticModelOpt, positionOpt, name: f_566_1805_1816(symbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 1832, 1910);

                ISymbol
                typeOnlySymbol = f_566_1857_1909(typeOnlySymbols, f_566_1896_1908(symbol))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 1926, 2014) || true) && (typeOnlySymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 1926, 2014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 1986, 1999);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(566, 1926, 2014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 2030, 2070);

                var
                type1 = f_566_2042_2069(normalSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 2084, 2126);

                var
                type2 = f_566_2096_2125(typeOnlySymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 2142, 2323);

                return
                                type1 != null && (DynAbs.Tracing.TraceSender.Expression_True(566, 2166, 2213) && type2 != null) && (DynAbs.Tracing.TraceSender.Expression_True(566, 2166, 2253) && f_566_2234_2253(type1, type2)) && (DynAbs.Tracing.TraceSender.Expression_True(566, 2166, 2322) && f_566_2274_2322(typeOnlySymbol, f_566_2296_2321(symbol)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(566, 691, 2334);

                bool
                f_566_829_887(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.ShouldRestrictMinimallyQualifyLookupToNamespacesAndTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 829, 887);
                    return return_v;
                }


                string
                f_566_968_979(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 968, 979);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_566_907_980(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupNamespacesAndTypes(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 907, 980);
                    return return_v;
                }


                string
                f_566_1050_1061(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 1050, 1061);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_566_1000_1062(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupSymbols(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 1000, 1062);
                    return return_v;
                }


                int
                f_566_1137_1149(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 1137, 1149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_566_1100_1150(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                candidates, int
                desiredArity)
                {
                    var return_v = SingleSymbolWithArity(candidates, desiredArity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 1100, 1150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_566_1418_1443(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 1418, 1443);
                    return return_v;
                }


                bool
                f_566_1398_1444(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 1398, 1444);
                    return return_v;
                }


                string
                f_566_1805_1816(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 1805, 1816);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_566_1744_1817(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupNamespacesAndTypes(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 1744, 1817);
                    return return_v;
                }


                int
                f_566_1896_1908(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 1896, 1908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_566_1857_1909(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                candidates, int
                desiredArity)
                {
                    var return_v = SingleSymbolWithArity(candidates, desiredArity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 1857, 1909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_566_2042_2069(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = GetSymbolType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 2042, 2069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_566_2096_2125(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = GetSymbolType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 2096, 2125);
                    return return_v;
                }


                bool
                f_566_2234_2253(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 2234, 2253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_566_2296_2321(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 2296, 2321);
                    return return_v;
                }


                bool
                f_566_2274_2322(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 2274, 2322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(566, 691, 2334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(566, 691, 2334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ISymbol SingleSymbolWithArity(ImmutableArray<ISymbol> candidates, int desiredArity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(566, 2346, 3504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 2469, 2497);

                ISymbol
                singleSymbol = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 2511, 3459);
                    foreach (ISymbol candidate in f_566_2541_2551_I(candidates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 2511, 3459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 2585, 2595);

                        int
                        arity
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 2613, 3066);

                        switch (f_566_2621_2635(candidate))
                        {

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 2613, 3066);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 2729, 2773);

                                arity = f_566_2737_2772(((INamedTypeSymbol)candidate));
                                DynAbs.Tracing.TraceSender.TraceBreak(566, 2799, 2805);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(566, 2613, 3066);

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 2613, 3066);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 2876, 2917);

                                arity = f_566_2884_2916(((IMethodSymbol)candidate));
                                DynAbs.Tracing.TraceSender.TraceBreak(566, 2943, 2949);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(566, 2613, 3066);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 2613, 3066);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3005, 3015);

                                arity = 0;
                                DynAbs.Tracing.TraceSender.TraceBreak(566, 3041, 3047);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(566, 2613, 3066);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3086, 3444) || true) && (arity == desiredArity)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 3086, 3444);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3153, 3425) || true) && (singleSymbol == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 3153, 3425);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3227, 3252);

                                singleSymbol = candidate;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(566, 3153, 3425);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 3153, 3425);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3350, 3370);

                                singleSymbol = null;
                                DynAbs.Tracing.TraceSender.TraceBreak(566, 3396, 3402);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(566, 3153, 3425);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(566, 3086, 3444);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(566, 2511, 3459);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(566, 1, 949);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(566, 1, 949);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3473, 3493);

                return singleSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(566, 2346, 3504);

                Microsoft.CodeAnalysis.SymbolKind
                f_566_2621_2635(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 2621, 2635);
                    return return_v;
                }


                int
                f_566_2737_2772(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 2737, 2772);
                    return return_v;
                }


                int
                f_566_2884_2916(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 2884, 2916);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_566_2541_2551_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(566, 2541, 2551);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(566, 2346, 3504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(566, 2346, 3504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static ITypeSymbol GetSymbolType(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(566, 3516, 4519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3599, 3640);

                var
                localSymbol = symbol as ILocalSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3654, 3750) || true) && (localSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 3654, 3750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3711, 3735);

                    return f_566_3718_3734(localSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(566, 3654, 3750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3766, 3807);

                var
                fieldSymbol = symbol as IFieldSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3821, 3917) || true) && (fieldSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 3821, 3917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3878, 3902);

                    return f_566_3885_3901(fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(566, 3821, 3917);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3933, 3980);

                var
                propertySymbol = symbol as IPropertySymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 3994, 4096) || true) && (propertySymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 3994, 4096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 4054, 4081);

                    return f_566_4061_4080(propertySymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(566, 3994, 4096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 4112, 4161);

                var
                parameterSymbol = symbol as IParameterSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 4175, 4279) || true) && (parameterSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 4175, 4279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 4236, 4264);

                    return f_566_4243_4263(parameterSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(566, 4175, 4279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 4295, 4336);

                var
                aliasSymbol = symbol as IAliasSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 4350, 4463) || true) && (aliasSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(566, 4350, 4463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 4407, 4448);

                    return f_566_4414_4432(aliasSymbol) as ITypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(566, 4350, 4463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(566, 4479, 4508);

                return symbol as ITypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(566, 3516, 4519);

                Microsoft.CodeAnalysis.ITypeSymbol
                f_566_3718_3734(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 3718, 3734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_566_3885_3901(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 3885, 3901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_566_4061_4080(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 4061, 4080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_566_4243_4263(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 4243, 4263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                f_566_4414_4432(Microsoft.CodeAnalysis.IAliasSymbol
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(566, 4414, 4432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(566, 3516, 4519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(566, 3516, 4519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
