// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Diagnostics;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SynthesizedClosureMethod : SynthesizedMethodBaseSymbol, ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly ImmutableArray<NamedTypeSymbol> _structEnvironments;

        internal MethodSymbol TopLevelMethod { get; }

        internal readonly DebugId LambdaId;

        internal SynthesizedClosureMethod(
                    NamedTypeSymbol containingType,
                    ImmutableArray<SynthesizedClosureEnvironment> structEnvironments,
                    ClosureKind closureKind,
                    MethodSymbol topLevelMethod,
                    DebugId topLevelMethodId,
                    MethodSymbol originalMethod,
                    SyntaxReference blockSyntax,
                    DebugId lambdaId)
        : base(f_10459_1371_1385_C(containingType), originalMethod, blockSyntax, f_10459_1476_1533(f_10459_1476_1516(originalMethod)[0]), (DynAbs.Tracing.TraceSender.Conditional_F1(10459, 1555, 1592) || ((originalMethod is LocalFunctionSymbol
        && DynAbs.Tracing.TraceSender.Conditional_F2(10459, 1616, 1707)) || DynAbs.Tracing.TraceSender.Conditional_F3(10459, 1731, 1801))) ? f_10459_1616_1707(f_10459_1625_1644(topLevelMethod), f_10459_1646_1665(originalMethod), topLevelMethodId, closureKind, lambdaId) : f_10459_1731_1801(f_10459_1740_1759(topLevelMethod), topLevelMethodId, closureKind, lambdaId), f_10459_1823_1876(closureKind, originalMethod))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10459, 958, 4757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 856, 901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 8780, 8819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 1902, 1934);

                TopLevelMethod = topLevelMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 1948, 1974);

                ClosureKind = closureKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 1988, 2008);

                LambdaId = lambdaId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 2024, 2040);

                TypeMap
                typeMap
                = default(TypeMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 2054, 2105);

                ImmutableArray<TypeParameterSymbol>
                typeParameters
                = default(ImmutableArray<TypeParameterSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 2121, 2187);

                var
                lambdaFrame = f_10459_2139_2153() as SynthesizedClosureEnvironment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 2201, 3414);

                switch (closureKind)
                {

                    case ClosureKind.Singleton: // all type parameters on method (except the top level method's)
                    case ClosureKind.General: // only lambda's type parameters on method (rest on class)
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 2201, 3414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 2470, 2513);

                        f_10459_2470_2512(!(lambdaFrame is null));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 2535, 2803);

                        typeMap = f_10459_2545_2802(f_10459_2545_2564(lambdaFrame), originalMethod, this, out typeParameters, out _, lambdaFrame.OriginalContainingMethodOpt);
                        DynAbs.Tracing.TraceSender.TraceBreak(10459, 2825, 2831);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 2201, 3414);

                    case ClosureKind.ThisOnly: // all type parameters on method
                    case ClosureKind.Static:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 2201, 3414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 2972, 3012);

                        f_10459_2972_3011(lambdaFrame is null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 3034, 3269);

                        typeMap = f_10459_3044_3268(f_10459_3044_3057(), originalMethod, this, out typeParameters, out _, stopAt: null);
                        DynAbs.Tracing.TraceSender.TraceBreak(10459, 3291, 3297);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 2201, 3414);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 2201, 3414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 3345, 3399);

                        throw f_10459_3351_3398(closureKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 2201, 3414);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 3430, 4495) || true) && (f_10459_3434_3470_M(!structEnvironments.IsDefaultOrEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10459, 3434, 3500) && typeParameters.Length != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 3430, 4495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 3534, 3610);

                    var
                    constructedStructClosures = f_10459_3566_3609()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 3628, 4246);
                        foreach (var env in f_10459_3648_3666_I(structEnvironments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 3628, 4246);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 3708, 3736);

                            NamedTypeSymbol
                            constructed
                            = default(NamedTypeSymbol);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 3758, 4162) || true) && (f_10459_3762_3771(env) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 3758, 4162);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 3826, 3844);

                                constructed = env;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 3758, 4162);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 3758, 4162);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 3942, 3992);

                                var
                                originals = f_10459_3958_3991(env)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 4018, 4076);

                                var
                                newArgs = f_10459_4032_4075(typeMap, originals)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 4102, 4139);

                                constructed = f_10459_4116_4138(env, newArgs);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 3758, 4162);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 4184, 4227);

                            f_10459_4184_4226(constructedStructClosures, constructed);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 3628, 4246);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10459, 1, 619);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10459, 1, 619);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 4264, 4333);

                    _structEnvironments = f_10459_4286_4332(constructedStructClosures);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 3430, 4495);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 3430, 4495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 4399, 4480);

                    _structEnvironments = ImmutableArray<NamedTypeSymbol>.CastUp(structEnvironments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 3430, 4495);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 4511, 4567);

                f_10459_4511_4566(this, typeMap, typeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 4651, 4746);

                f_10459_4651_4745(!(originalMethod is LocalFunctionSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10459, 4664, 4732) || f_10459_4708_4732_M(!originalMethod.IsStatic)) || (DynAbs.Tracing.TraceSender.Expression_False(10459, 4664, 4744) || f_10459_4736_4744()));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10459, 958, 4757);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 958, 4757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 958, 4757);
            }
        }

        private static DeclarationModifiers MakeDeclarationModifiers(ClosureKind closureKind, MethodSymbol originalMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10459, 4769, 5449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 4908, 5018);

                var
                mods = (DynAbs.Tracing.TraceSender.Conditional_F1(10459, 4919, 4954) || ((closureKind == ClosureKind.ThisOnly && DynAbs.Tracing.TraceSender.Conditional_F2(10459, 4957, 4985)) || DynAbs.Tracing.TraceSender.Conditional_F3(10459, 4988, 5017))) ? DeclarationModifiers.Private : DeclarationModifiers.Internal
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 5034, 5156) || true) && (closureKind == ClosureKind.Static)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 5034, 5156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 5105, 5141);

                    mods |= DeclarationModifiers.Static;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 5034, 5156);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 5172, 5282) || true) && (f_10459_5176_5198(originalMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 5172, 5282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 5232, 5267);

                    mods |= DeclarationModifiers.Async;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 5172, 5282);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 5298, 5410) || true) && (f_10459_5302_5325(originalMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10459, 5298, 5410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 5359, 5395);

                    mods |= DeclarationModifiers.Extern;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10459, 5298, 5410);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 5426, 5438);

                return mods;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10459, 4769, 5449);

                bool
                f_10459_5176_5198(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 5176, 5198);
                    return return_v;
                }


                bool
                f_10459_5302_5325(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 5302, 5325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 4769, 5449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 4769, 5449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string MakeName(string topLevelMethodName, string localFunctionName, DebugId topLevelMethodId, ClosureKind closureKind, DebugId lambdaId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10459, 5461, 5973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 5638, 5962);

                return f_10459_5645_5961(topLevelMethodName, localFunctionName, (DynAbs.Tracing.TraceSender.Conditional_F1(10459, 5773, 5809) || (((closureKind == ClosureKind.General) && DynAbs.Tracing.TraceSender.Conditional_F2(10459, 5812, 5814)) || DynAbs.Tracing.TraceSender.Conditional_F3(10459, 5817, 5841))) ? -1 : topLevelMethodId.Ordinal, topLevelMethodId.Generation, lambdaId.Ordinal, lambdaId.Generation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10459, 5461, 5973);

                string
                f_10459_5645_5961(string
                methodName, string
                localFunctionName, int
                methodOrdinal, int
                methodGeneration, int
                lambdaOrdinal, int
                lambdaGeneration)
                {
                    var return_v = GeneratedNames.MakeLocalFunctionName(methodName, localFunctionName, methodOrdinal, methodGeneration, lambdaOrdinal, lambdaGeneration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 5645, 5961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 5461, 5973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 5461, 5973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string MakeName(string topLevelMethodName, DebugId topLevelMethodId, ClosureKind closureKind, DebugId lambdaId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10459, 5985, 6834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 6536, 6823);

                return f_10459_6543_6822(topLevelMethodName, (DynAbs.Tracing.TraceSender.Conditional_F1(10459, 6634, 6670) || (((closureKind == ClosureKind.General) && DynAbs.Tracing.TraceSender.Conditional_F2(10459, 6673, 6675)) || DynAbs.Tracing.TraceSender.Conditional_F3(10459, 6678, 6702))) ? -1 : topLevelMethodId.Ordinal, topLevelMethodId.Generation, lambdaId.Ordinal, lambdaId.Generation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10459, 5985, 6834);

                string
                f_10459_6543_6822(string
                methodName, int
                methodOrdinal, int
                methodGeneration, int
                lambdaOrdinal, int
                lambdaGeneration)
                {
                    var return_v = GeneratedNames.MakeLambdaMethodName(methodName, methodOrdinal, methodGeneration, lambdaOrdinal, lambdaGeneration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 6543, 6822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 5985, 6834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 5985, 6834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<ParameterSymbol> BaseMethodParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10459, 7499, 7528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 7502, 7528);
                    return f_10459_7502_7528(this.BaseMethod); DynAbs.Tracing.TraceSender.TraceExitMethod(10459, 7499, 7528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 7499, 7528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 7499, 7528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<TypeSymbol> ExtraSynthesizedRefParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10459, 7630, 7687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 7633, 7687);
                    return ImmutableArray<TypeSymbol>.CastUp(_structEnvironments); DynAbs.Tracing.TraceSender.TraceExitMethod(10459, 7630, 7687);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 7630, 7687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 7630, 7687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int ExtraSynthesizedParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10459, 7742, 7817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 7745, 7817);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10459, 7745, 7779) || ((this._structEnvironments.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10459, 7782, 7783)) || DynAbs.Tracing.TraceSender.Conditional_F3(10459, 7786, 7817))) ? 0 : this._structEnvironments.Length; DynAbs.Tracing.TraceSender.TraceExitMethod(10459, 7742, 7817);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 7742, 7817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 7742, 7817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool InheritsBaseMethodAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10459, 7882, 7918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 7885, 7918);
                    return BaseMethod is LocalFunctionSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(10459, 7882, 7918);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 7882, 7918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 7882, 7918);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10459, 7970, 7986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 7973, 7986);
                    return f_10459_7973_7986_M(!this.IsAsync); DynAbs.Tracing.TraceSender.TraceExitMethod(10459, 7970, 7986);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 7970, 7986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 7970, 7986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10459, 8039, 8047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 8042, 8047);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10459, 8039, 8047);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 8039, 8047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 8039, 8047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10459, 8060, 8464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 8378, 8453);

                return f_10459_8385_8452(f_10459_8385_8399(), localPosition, localTree);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10459, 8060, 8464);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10459_8385_8399()
                {
                    var return_v = TopLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 8385, 8399);
                    return return_v;
                }


                int
                f_10459_8385_8452(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                localPosition, Microsoft.CodeAnalysis.SyntaxTree
                localTree)
                {
                    var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 8385, 8452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 8060, 8464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 8060, 8464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IMethodSymbolInternal? ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10459, 8549, 8566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 8552, 8566);
                    return f_10459_8552_8566(); DynAbs.Tracing.TraceSender.TraceExitMethod(10459, 8549, 8566);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 8549, 8566);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 8549, 8566);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISynthesizedMethodBodyImplementationSymbol.HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10459, 8760, 8767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10459, 8763, 8767);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10459, 8760, 8767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10459, 8760, 8767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 8760, 8767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ClosureKind ClosureKind { get; }

        static SynthesizedClosureMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10459, 638, 8826);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10459, 638, 8826);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10459, 638, 8826);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10459, 638, 8826);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_10459_1476_1516(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.DeclaringSyntaxReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 1476, 1516);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Location
        f_10459_1476_1533(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.GetLocation();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 1476, 1533);
            return return_v;
        }


        static string
        f_10459_1625_1644(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 1625, 1644);
            return return_v;
        }


        static string
        f_10459_1646_1665(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 1646, 1665);
            return return_v;
        }


        static string
        f_10459_1616_1707(string
        topLevelMethodName, string
        localFunctionName, Microsoft.CodeAnalysis.CodeGen.DebugId
        topLevelMethodId, Microsoft.CodeAnalysis.CSharp.ClosureKind
        closureKind, Microsoft.CodeAnalysis.CodeGen.DebugId
        lambdaId)
        {
            var return_v = MakeName(topLevelMethodName, localFunctionName, topLevelMethodId, closureKind, lambdaId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 1616, 1707);
            return return_v;
        }


        static string
        f_10459_1740_1759(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 1740, 1759);
            return return_v;
        }


        static string
        f_10459_1731_1801(string
        topLevelMethodName, Microsoft.CodeAnalysis.CodeGen.DebugId
        topLevelMethodId, Microsoft.CodeAnalysis.CSharp.ClosureKind
        closureKind, Microsoft.CodeAnalysis.CodeGen.DebugId
        lambdaId)
        {
            var return_v = MakeName(topLevelMethodName, topLevelMethodId, closureKind, lambdaId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 1731, 1801);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10459_1823_1876(Microsoft.CodeAnalysis.CSharp.ClosureKind
        closureKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        originalMethod)
        {
            var return_v = MakeDeclarationModifiers(closureKind, originalMethod);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 1823, 1876);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10459_2139_2153()
        {
            var return_v = ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 2139, 2153);
            return return_v;
        }


        int
        f_10459_2470_2512(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 2470, 2512);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10459_2545_2564(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
        this_param)
        {
            var return_v = this_param.TypeMap;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 2545, 2564);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10459_2545_2802(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        oldOwner, Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
        newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        newTypeParameters, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        oldTypeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        stopAt)
        {
            var return_v = this_param.WithConcatAlphaRename(oldOwner, (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, out newTypeParameters, out oldTypeParameters, stopAt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 2545, 2802);
            return return_v;
        }


        int
        f_10459_2972_3011(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 2972, 3011);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10459_3044_3057()
        {
            var return_v = TypeMap.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 3044, 3057);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10459_3044_3268(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        oldOwner, Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
        newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        newTypeParameters, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        oldTypeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        stopAt)
        {
            var return_v = this_param.WithConcatAlphaRename(oldOwner, (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, out newTypeParameters, out oldTypeParameters, stopAt: stopAt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 3044, 3268);
            return return_v;
        }


        System.Exception
        f_10459_3351_3398(Microsoft.CodeAnalysis.CSharp.ClosureKind
        o)
        {
            var return_v = ExceptionUtilities.UnexpectedValue((object)o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 3351, 3398);
            return return_v;
        }


        bool
        f_10459_3434_3470_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 3434, 3470);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_10459_3566_3609()
        {
            var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 3566, 3609);
            return return_v;
        }


        int
        f_10459_3762_3771(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
        this_param)
        {
            var return_v = this_param.Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 3762, 3771);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10459_3958_3991(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
        this_param)
        {
            var return_v = this_param.ConstructedFromTypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 3958, 3991);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10459_4032_4075(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        original)
        {
            var return_v = this_param.SubstituteTypeParameters(original);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 4032, 4075);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10459_4116_4138(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        typeArguments)
        {
            var return_v = this_param.Construct((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>)typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 4116, 4138);
            return return_v;
        }


        int
        f_10459_4184_4226(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 4184, 4226);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment>
        f_10459_3648_3666_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 3648, 3666);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_10459_4286_4332(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 4286, 4332);
            return return_v;
        }


        int
        f_10459_4511_4566(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        typeMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        typeParameters)
        {
            this_param.AssignTypeMapAndTypeParameters(typeMap, typeParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 4511, 4566);
            return 0;
        }


        bool
        f_10459_4708_4732_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 4708, 4732);
            return return_v;
        }


        bool
        f_10459_4736_4744()
        {
            var return_v = IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 4736, 4744);
            return return_v;
        }


        int
        f_10459_4651_4745(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10459, 4651, 4745);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10459_1371_1385_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10459, 958, 4757);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10459_7502_7528(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 7502, 7528);
            return return_v;
        }


        bool
        f_10459_7973_7986_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 7973, 7986);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10459_8552_8566()
        {
            var return_v = TopLevelMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10459, 8552, 8566);
            return return_v;
        }

    }
}
