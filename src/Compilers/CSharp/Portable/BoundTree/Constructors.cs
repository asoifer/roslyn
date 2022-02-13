// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class BoundFieldAccess
    {
        public BoundFieldAccess(
                    SyntaxNode syntax,
                    BoundExpression? receiver,
                    FieldSymbol fieldSymbol,
                    ConstantValue? constantValueOpt,
                    bool hasErrors = false)
        : this(f_10579_669_675_C(syntax), receiver, fieldSymbol, constantValueOpt, LookupResultKind.Viable, f_10579_743_759(fieldSymbol), hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 431, 793);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 431, 793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 431, 793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 431, 793);
            }
        }

        public BoundFieldAccess(
                    SyntaxNode syntax,
                    BoundExpression? receiver,
                    FieldSymbol fieldSymbol,
                    ConstantValue? constantValueOpt,
                    LookupResultKind resultKind,
                    TypeSymbol type,
                    bool hasErrors = false)
        : this(f_10579_1115_1121_C(syntax), receiver, fieldSymbol, constantValueOpt, resultKind, f_10579_1176_1222(receiver, fieldSymbol), isDeclaration: false, type: type, hasErrors: hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 805, 1301);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 805, 1301);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 805, 1301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 805, 1301);
            }
        }

        public BoundFieldAccess(
                    SyntaxNode syntax,
                    BoundExpression? receiver,
                    FieldSymbol fieldSymbol,
                    ConstantValue? constantValueOpt,
                    LookupResultKind resultKind,
                    bool isDeclaration,
                    TypeSymbol type,
                    bool hasErrors = false)
        : this(f_10579_1656_1662_C(syntax), receiver, fieldSymbol, constantValueOpt, resultKind, f_10579_1717_1763(receiver, fieldSymbol), isDeclaration: isDeclaration, type: type, hasErrors: hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 1313, 1850);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 1313, 1850);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 1313, 1850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 1313, 1850);
            }
        }

        public BoundFieldAccess Update(
                    BoundExpression? receiver,
                    FieldSymbol fieldSymbol,
                    ConstantValue? constantValueOpt,
                    LookupResultKind resultKind,
                    TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 1862, 2251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 2120, 2240);

                return f_10579_2127_2239(this, receiver, fieldSymbol, constantValueOpt, resultKind, f_10579_2192_2206(this), f_10579_2208_2226(this), typeSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 1862, 2251);

                bool
                f_10579_2192_2206(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.IsByValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2192, 2206);
                    return return_v;
                }


                bool
                f_10579_2208_2226(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.IsDeclaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2208, 2226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10579_2127_2239(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, bool
                isByValue, bool
                isDeclaration, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiverOpt, fieldSymbol, constantValueOpt, resultKind, isByValue, isDeclaration, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 2127, 2239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 1862, 2251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 1862, 2251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedsByValueFieldAccess(BoundExpression? receiver, FieldSymbol fieldSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 2263, 3060);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 2383, 2605) || true) && (f_10579_2387_2407(fieldSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10579, 2387, 2467) || f_10579_2428_2467_M(!f_10579_2429_2455(fieldSymbol).IsValueType)) || (DynAbs.Tracing.TraceSender.Expression_False(10579, 2387, 2504) || receiver == null))
                ) // receiver may be null in error cases

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10579, 2383, 2605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 2577, 2590);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10579, 2383, 2605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 2621, 3049);

                switch (f_10579_2629_2642(receiver))
                {

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10579, 2621, 3049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 2725, 2771);

                        return f_10579_2732_2770(((BoundFieldAccess)receiver));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10579, 2621, 3049);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10579, 2621, 3049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 2834, 2887);

                        var
                        localSymbol = f_10579_2852_2886(((BoundLocal)receiver))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 2909, 2971);

                        return !(f_10579_2918_2948(localSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10579, 2918, 2969) || f_10579_2952_2969(localSymbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10579, 2621, 3049);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10579, 2621, 3049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 3021, 3034);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10579, 2621, 3049);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 2263, 3060);

                bool
                f_10579_2387_2407(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2387, 2407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10579_2429_2455(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2429, 2455);
                    return return_v;
                }


                bool
                f_10579_2428_2467_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2428, 2467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10579_2629_2642(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2629, 2642);
                    return return_v;
                }


                bool
                f_10579_2732_2770(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.IsByValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2732, 2770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10579_2852_2886(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2852, 2886);
                    return return_v;
                }


                bool
                f_10579_2918_2948(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsWritableVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2918, 2948);
                    return return_v;
                }


                bool
                f_10579_2952_2969(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 2952, 2969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 2263, 3060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 2263, 3060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10579_743_759(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 743, 759);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_669_675_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 431, 793);
            return return_v;
        }


        static bool
        f_10579_1176_1222(Microsoft.CodeAnalysis.CSharp.BoundExpression?
        receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        fieldSymbol)
        {
            var return_v = NeedsByValueFieldAccess(receiver, fieldSymbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 1176, 1222);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_1115_1121_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 805, 1301);
            return return_v;
        }


        static bool
        f_10579_1717_1763(Microsoft.CodeAnalysis.CSharp.BoundExpression?
        receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        fieldSymbol)
        {
            var return_v = NeedsByValueFieldAccess(receiver, fieldSymbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 1717, 1763);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_1656_1662_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 1313, 1850);
            return return_v;
        }

    }
    internal partial class BoundCall
    {
        public BoundCall(
                    SyntaxNode syntax,
                    BoundExpression? receiverOpt,
                    MethodSymbol method,
                    ImmutableArray<BoundExpression> arguments,
                    ImmutableArray<string> argumentNamesOpt,
                    ImmutableArray<RefKind> argumentRefKindsOpt,
                    bool isDelegateCall,
                    bool expanded,
                    bool invokedAsExtensionMethod,
                    ImmutableArray<int> argsToParamsOpt,
                    BitVector defaultArguments,
                    LookupResultKind resultKind,
                    TypeSymbol type,
                    bool hasErrors = false) : this(f_10579_3745_3751_C(syntax), receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall, expanded, invokedAsExtensionMethod, argsToParamsOpt, defaultArguments, resultKind, originalMethodsOpt: default, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 3124, 3990);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 3124, 3990);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 3124, 3990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 3124, 3990);
            }
        }

        public BoundCall Update(BoundExpression? receiverOpt,
                                        MethodSymbol method,
                                        ImmutableArray<BoundExpression> arguments,
                                        ImmutableArray<string> argumentNamesOpt,
                                        ImmutableArray<RefKind> argumentRefKindsOpt,
                                        bool isDelegateCall,
                                        bool expanded,
                                        bool invokedAsExtensionMethod,
                                        ImmutableArray<int> argsToParamsOpt,
                                        BitVector defaultArguments,
                                        LookupResultKind resultKind,
                                        TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 4760, 4970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 4763, 4970);
                return f_10579_4763_4970(this, receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall, expanded, invokedAsExtensionMethod, argsToParamsOpt, defaultArguments, resultKind, f_10579_4940_4963(this), type); DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 4760, 4970);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 4760, 4970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 4760, 4970);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            f_10579_4940_4963(Microsoft.CodeAnalysis.CSharp.BoundCall
            this_param)
            {
                var return_v = this_param.OriginalMethodsOpt;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 4940, 4963);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundCall
            f_10579_4763_4970(Microsoft.CodeAnalysis.CSharp.BoundCall
            this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
            receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
            arguments, System.Collections.Immutable.ImmutableArray<string>
            argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
            argumentRefKindsOpt, bool
            isDelegateCall, bool
            expanded, bool
            invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<int>
            argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
            defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
            resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            originalMethodsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = this_param.Update(receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall, expanded, invokedAsExtensionMethod, argsToParamsOpt, defaultArguments, resultKind, originalMethodsOpt, type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 4763, 4970);
                return return_v;
            }

        }

        public static BoundCall ErrorCall(
                    SyntaxNode node,
                    BoundExpression receiverOpt,
                    MethodSymbol method,
                    ImmutableArray<BoundExpression> arguments,
                    ImmutableArray<string> namedArguments,
                    ImmutableArray<RefKind> refKinds,
                    bool isDelegateCall,
                    bool invokedAsExtensionMethod,
                    ImmutableArray<MethodSymbol> originalMethods,
                    LookupResultKind resultKind,
                    Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 4983, 6591);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 5510, 5641) || true) && (f_10579_5514_5538_M(!originalMethods.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10579, 5510, 5641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 5557, 5641);

                    resultKind = f_10579_5570_5640(resultKind, LookupResultKind.OverloadResolutionFailure);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10579, 5510, 5641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 5657, 5745);

                f_10579_5657_5744(arguments.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10579, 5670, 5743) || (object)receiverOpt != (object)arguments[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 5761, 6580);

                return f_10579_5768_6579(syntax: node, receiverOpt: f_10579_5844_5890(binder, receiverOpt), method: method, arguments: arguments.SelectAsArray((e, binder) => binder.BindToTypeForErrorRecovery(e), binder), argumentNamesOpt: namedArguments, argumentRefKindsOpt: refKinds, isDelegateCall: isDelegateCall, expanded: false, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), resultKind: resultKind, originalMethodsOpt: originalMethods, type: f_10579_6527_6544(method), hasErrors: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 4983, 6591);

                bool
                f_10579_5514_5538_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 5514, 5538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10579_5570_5640(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind1, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind2)
                {
                    var return_v = resultKind1.WorseResultKind(resultKind2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 5570, 5640);
                    return return_v;
                }


                int
                f_10579_5657_5744(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 5657, 5744);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10579_5844_5890(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.BindToTypeForErrorRecovery(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 5844, 5890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10579_6527_6544(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6527, 6544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10579_5768_6579(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                isDelegateCall, bool
                expanded, bool
                invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalMethodsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundCall(syntax: syntax, receiverOpt: receiverOpt, method: method, arguments: arguments, argumentNamesOpt: argumentNamesOpt, argumentRefKindsOpt: argumentRefKindsOpt, isDelegateCall: isDelegateCall, expanded: expanded, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, resultKind: resultKind, originalMethodsOpt: originalMethodsOpt, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 5768, 6579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 4983, 6591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 4983, 6591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundCall Update(ImmutableArray<BoundExpression> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 6603, 6920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 6694, 6909);

                return f_10579_6701_6908(this, f_10579_6713_6724(), f_10579_6726_6732(), arguments, f_10579_6745_6761(), f_10579_6763_6782(), f_10579_6784_6798(), f_10579_6800_6808(), f_10579_6810_6834(), f_10579_6836_6851(), f_10579_6853_6869(), f_10579_6871_6881(), f_10579_6883_6901(), f_10579_6903_6907());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 6603, 6920);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10579_6713_6724()
                {
                    var return_v = ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6713, 6724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10579_6726_6732()
                {
                    var return_v = Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6726, 6732);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10579_6745_6761()
                {
                    var return_v = ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6745, 6761);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10579_6763_6782()
                {
                    var return_v = ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6763, 6782);
                    return return_v;
                }


                bool
                f_10579_6784_6798()
                {
                    var return_v = IsDelegateCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6784, 6798);
                    return return_v;
                }


                bool
                f_10579_6800_6808()
                {
                    var return_v = Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6800, 6808);
                    return return_v;
                }


                bool
                f_10579_6810_6834()
                {
                    var return_v = InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6810, 6834);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10579_6836_6851()
                {
                    var return_v = ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6836, 6851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10579_6853_6869()
                {
                    var return_v = DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6853, 6869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10579_6871_6881()
                {
                    var return_v = ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6871, 6881);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10579_6883_6901()
                {
                    var return_v = OriginalMethodsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6883, 6901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10579_6903_6907()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 6903, 6907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10579_6701_6908(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                isDelegateCall, bool
                expanded, bool
                invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalMethodsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall, expanded, invokedAsExtensionMethod, argsToParamsOpt, defaultArguments, resultKind, originalMethodsOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 6701, 6908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 6603, 6920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 6603, 6920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundCall Update(BoundExpression? receiverOpt, MethodSymbol method, ImmutableArray<BoundExpression> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 6932, 7300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 7074, 7289);

                return f_10579_7081_7288(this, receiverOpt, method, arguments, f_10579_7125_7141(), f_10579_7143_7162(), f_10579_7164_7178(), f_10579_7180_7188(), f_10579_7190_7214(), f_10579_7216_7231(), f_10579_7233_7249(), f_10579_7251_7261(), f_10579_7263_7281(), f_10579_7283_7287());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 6932, 7300);

                System.Collections.Immutable.ImmutableArray<string>
                f_10579_7125_7141()
                {
                    var return_v = ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7125, 7141);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10579_7143_7162()
                {
                    var return_v = ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7143, 7162);
                    return return_v;
                }


                bool
                f_10579_7164_7178()
                {
                    var return_v = IsDelegateCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7164, 7178);
                    return return_v;
                }


                bool
                f_10579_7180_7188()
                {
                    var return_v = Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7180, 7188);
                    return return_v;
                }


                bool
                f_10579_7190_7214()
                {
                    var return_v = InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7190, 7214);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10579_7216_7231()
                {
                    var return_v = ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7216, 7231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10579_7233_7249()
                {
                    var return_v = DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7233, 7249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10579_7251_7261()
                {
                    var return_v = ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7251, 7261);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10579_7263_7281()
                {
                    var return_v = OriginalMethodsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7263, 7281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10579_7283_7287()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 7283, 7287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10579_7081_7288(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                isDelegateCall, bool
                expanded, bool
                invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalMethodsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall, expanded, invokedAsExtensionMethod, argsToParamsOpt, defaultArguments, resultKind, originalMethodsOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 7081, 7288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 6932, 7300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 6932, 7300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundCall Synthesized(SyntaxNode syntax, BoundExpression? receiverOpt, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 7312, 7540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 7442, 7529);

                return f_10579_7449_7528(syntax, receiverOpt, method, ImmutableArray<BoundExpression>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 7312, 7540);

                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10579_7449_7528(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = Synthesized(syntax, receiverOpt, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 7449, 7528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 7312, 7540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 7312, 7540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundCall Synthesized(SyntaxNode syntax, BoundExpression? receiverOpt, MethodSymbol method, BoundExpression arg0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 7552, 7792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 7704, 7781);

                return f_10579_7711_7780(syntax, receiverOpt, method, f_10579_7752_7779(arg0));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 7552, 7792);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10579_7752_7779(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 7752, 7779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10579_7711_7780(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = Synthesized(syntax, receiverOpt, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 7711, 7780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 7552, 7792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 7552, 7792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundCall Synthesized(SyntaxNode syntax, BoundExpression? receiverOpt, MethodSymbol method, BoundExpression arg0, BoundExpression arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 7804, 8072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 7978, 8061);

                return f_10579_7985_8060(syntax, receiverOpt, method, f_10579_8026_8059(arg0, arg1));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 7804, 8072);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10579_8026_8059(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 8026, 8059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10579_7985_8060(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = Synthesized(syntax, receiverOpt, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 7985, 8060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 7804, 8072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 7804, 8072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundCall Synthesized(SyntaxNode syntax, BoundExpression? receiverOpt, MethodSymbol method, ImmutableArray<BoundExpression> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 8084, 9092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 8257, 9081);

                return new BoundCall(syntax,
                                    receiverOpt,
                                    method,
                                    arguments,
                                    argumentNamesOpt: default(ImmutableArray<string>),
                                    argumentRefKindsOpt: f_10579_8495_8519(method),
                                    isDelegateCall: false,
                                    expanded: false,
                                    invokedAsExtensionMethod: false,
                                    argsToParamsOpt: default(ImmutableArray<int>),
                                    defaultArguments: default(BitVector),
                                    resultKind: LookupResultKind.Viable,
                                    originalMethodsOpt: default,
                                    type: f_10579_8919_8936(method),
                                    hasErrors: f_10579_8970_8995(method) is ErrorMethodSymbol
                                )
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10579, 8264, 9080) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 8084, 9092);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10579_8495_8519(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 8495, 8519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10579_8919_8936(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 8919, 8936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10579_8970_8995(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 8970, 8995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 8084, 9092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 8084, 9092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_3745_3751_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 3124, 3990);
            return return_v;
        }

    }
    internal sealed partial class BoundObjectCreationExpression
    {
        public BoundObjectCreationExpression(SyntaxNode syntax, MethodSymbol constructor, params BoundExpression[] arguments)
        : this(f_10579_9321_9327_C(syntax), constructor, f_10579_9342_9391(arguments), default(ImmutableArray<string>), default(ImmutableArray<RefKind>), false, default(ImmutableArray<int>), default(BitVector), null, null, f_10579_9529_9555(constructor))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 9183, 9578);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 9183, 9578);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 9183, 9578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 9183, 9578);
            }
        }

        public BoundObjectCreationExpression(SyntaxNode syntax, MethodSymbol constructor, ImmutableArray<BoundExpression> arguments)
        : this(f_10579_9733_9739_C(syntax), constructor, arguments, default(ImmutableArray<string>), default(ImmutableArray<RefKind>), false, default(ImmutableArray<int>), default(BitVector), null, null, f_10579_9901_9927(constructor))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 9588, 9950);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 9588, 9950);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 9588, 9950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 9588, 9950);
            }
        }

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10579_9342_9391(params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
        items)
        {
            var return_v = ImmutableArray.Create<BoundExpression>(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 9342, 9391);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10579_9529_9555(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 9529, 9555);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_9321_9327_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 9183, 9578);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10579_9901_9927(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 9901, 9927);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_9733_9739_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 9588, 9950);
            return return_v;
        }

    }
    internal partial class BoundIndexerAccess
    {
        public static BoundIndexerAccess ErrorAccess(
                    SyntaxNode node,
                    BoundExpression receiverOpt,
                    PropertySymbol indexer,
                    ImmutableArray<BoundExpression> arguments,
                    ImmutableArray<string> namedArguments,
                    ImmutableArray<RefKind> refKinds,
                    ImmutableArray<PropertySymbol> originalIndexers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 10023, 10887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 10419, 10876);

                return f_10579_10426_10875(node, receiverOpt, indexer, arguments, namedArguments, refKinds, expanded: false, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), originalIndexers, type: f_10579_10828_10840(indexer), hasErrors: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 10023, 10887);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10579_10828_10840(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 10828, 10840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                f_10579_10426_10875(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                indexer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                originalIndexersOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess(syntax, receiverOpt, indexer, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded: expanded, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, originalIndexersOpt, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 10426, 10875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 10023, 10887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 10023, 10887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundIndexerAccess(
                    SyntaxNode syntax,
                    BoundExpression? receiverOpt,
                    PropertySymbol indexer,
                    ImmutableArray<BoundExpression> arguments,
                    ImmutableArray<string> argumentNamesOpt,
                    ImmutableArray<RefKind> argumentRefKindsOpt,
                    bool expanded,
                    ImmutableArray<int> argsToParamsOpt,
                    BitVector defaultArguments,
                    TypeSymbol type,
                    bool hasErrors = false) : this(f_10579_11410_11416_C(syntax), receiverOpt, indexer, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, originalIndexersOpt: default, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 10897, 11594);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 10897, 11594);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 10897, 11594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 10897, 11594);
            }
        }

        public BoundIndexerAccess Update(BoundExpression? receiverOpt,
                                                 PropertySymbol indexer,
                                                 ImmutableArray<BoundExpression> arguments,
                                                 ImmutableArray<string> argumentNamesOpt,
                                                 ImmutableArray<RefKind> argumentRefKindsOpt,
                                                 bool expanded,
                                                 ImmutableArray<int> argsToParamsOpt,
                                                 BitVector defaultArguments,
                                                 TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 12268, 12426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 12271, 12426);
                return f_10579_12271_12426(this, receiverOpt, indexer, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, f_10579_12395_12419(this), type); DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 12268, 12426);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 12268, 12426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 12268, 12426);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
            f_10579_12395_12419(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
            this_param)
            {
                var return_v = this_param.OriginalIndexersOpt;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 12395, 12419);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
            f_10579_12271_12426(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
            this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
            receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
            indexer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
            arguments, System.Collections.Immutable.ImmutableArray<string>
            argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
            argumentRefKindsOpt, bool
            expanded, System.Collections.Immutable.ImmutableArray<int>
            argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
            defaultArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
            originalIndexersOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = this_param.Update(receiverOpt, indexer, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, originalIndexersOpt, type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 12271, 12426);
                return return_v;
            }

        }

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_11410_11416_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 10897, 11594);
            return return_v;
        }

    }
    internal sealed partial class BoundConversion
    {
        public static BoundConversion SynthesizedNonUserDefined(SyntaxNode syntax, BoundExpression operand, Conversion conversion, TypeSymbol type, ConstantValue? constantValueOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 12777, 13451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 12981, 13440);

                return new BoundConversion(
                                syntax,
                                operand,
                                conversion,
                                isBaseConversion: false,
                                @checked: false,
                                explicitCastInCode: false,
                                conversionGroupOpt: null,
                                constantValueOpt: constantValueOpt,
                                originalUserDefinedConversionsOpt: default,
                                type: type)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10579, 12988, 13439) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 12777, 13451);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 12777, 13451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 12777, 13451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundConversion Synthesized(
                    SyntaxNode syntax,
                    BoundExpression operand,
                    Conversion conversion,
                    bool @checked,
                    bool explicitCastInCode,
                    ConversionGroup? conversionGroupOpt,
                    ConstantValue? constantValueOpt,
                    TypeSymbol type,
                    bool hasErrors = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 13763, 14589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 14165, 14578);

                return new BoundConversion(
                                syntax,
                                operand,
                                conversion,
                                @checked,
                                explicitCastInCode: explicitCastInCode,
                                conversionGroupOpt,
                                constantValueOpt,
                                type,
                                hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10579, 14469, 14501) || f_10579_14482_14501_M(!conversion.IsValid)))
                {
                    WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10579, 14172, 14577)
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 13763, 14589);

                bool
                f_10579_14482_14501_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 14482, 14501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 13763, 14589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 13763, 14589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundConversion(
                    SyntaxNode syntax,
                    BoundExpression operand,
                    Conversion conversion,
                    bool @checked,
                    bool explicitCastInCode,
                    ConversionGroup? conversionGroupOpt,
                    ConstantValue? constantValueOpt,
                    TypeSymbol type,
                    bool hasErrors = false)
        : this(
        f_10579_14998_15004_C(syntax), operand, conversion, isBaseConversion: false, @checked: @checked, explicitCastInCode: explicitCastInCode, constantValueOpt: constantValueOpt, conversionGroupOpt, conversion.OriginalUserDefinedConversions, type: type, hasErrors: hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10579, 15404, 15436) || f_10579_15417_15436_M(!conversion.IsValid)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 14601, 15450);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 14601, 15450);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 14601, 15450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 14601, 15450);
            }
        }

        public BoundConversion(
                    SyntaxNode syntax,
                    BoundExpression operand,
                    Conversion conversion,
                    bool isBaseConversion,
                    bool @checked,
                    bool explicitCastInCode,
                    ConstantValue? constantValueOpt,
                    ConversionGroup? conversionGroupOpt,
                    TypeSymbol type,
                    bool hasErrors = false) : this(f_10579_15877_15883_C(syntax), operand, conversion, isBaseConversion, @checked, explicitCastInCode, constantValueOpt, conversionGroupOpt, originalUserDefinedConversionsOpt: default, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 15462, 16074);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 15462, 16074);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 15462, 16074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 15462, 16074);
            }
        }

        public BoundConversion Update(BoundExpression operand,
                                              Conversion conversion,
                                              bool isBaseConversion,
                                              bool @checked,
                                              bool explicitCastInCode,
                                              ConstantValue? constantValueOpt,
                                              ConversionGroup? conversionGroupOpt,
                                              TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 16600, 16762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 16603, 16762);
                return f_10579_16603_16762(this, operand, conversion, isBaseConversion, @checked, explicitCastInCode, constantValueOpt, conversionGroupOpt, f_10579_16717_16755(this), type); DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 16600, 16762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 16600, 16762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 16600, 16762);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            f_10579_16717_16755(Microsoft.CodeAnalysis.CSharp.BoundConversion
            this_param)
            {
                var return_v = this_param.OriginalUserDefinedConversionsOpt;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 16717, 16755);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundConversion
            f_10579_16603_16762(Microsoft.CodeAnalysis.CSharp.BoundConversion
            this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
            operand, Microsoft.CodeAnalysis.CSharp.Conversion
            conversion, bool
            isBaseConversion, bool
            @checked, bool
            explicitCastInCode, Microsoft.CodeAnalysis.ConstantValue?
            constantValueOpt, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
            conversionGroupOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            originalUserDefinedConversionsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = this_param.Update(operand, conversion, isBaseConversion, @checked, explicitCastInCode, constantValueOpt, conversionGroupOpt, originalUserDefinedConversionsOpt, type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 16603, 16762);
                return return_v;
            }

        }

        static bool
        f_10579_15417_15436_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 15417, 15436);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_14998_15004_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 14601, 15450);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_15877_15883_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 15462, 16074);
            return return_v;
        }

    }
    internal sealed partial class BoundBinaryOperator
    {
        public BoundBinaryOperator(
                    SyntaxNode syntax,
                    BinaryOperatorKind operatorKind,
                    BoundExpression left,
                    BoundExpression right,
                    ConstantValue? constantValueOpt,
                    MethodSymbol? methodOpt,
                    LookupResultKind resultKind,
                    ImmutableArray<MethodSymbol> originalUserDefinedOperatorsOpt,
                    TypeSymbol type,
                    bool hasErrors = false)
        : this(
        f_10579_17327_17333_C(syntax), operatorKind, constantValueOpt, methodOpt, resultKind, originalUserDefinedOperatorsOpt, left, right, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 16844, 17627);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 16844, 17627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 16844, 17627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 16844, 17627);
            }
        }

        public BoundBinaryOperator(
                    SyntaxNode syntax,
                    BinaryOperatorKind operatorKind,
                    ConstantValue? constantValueOpt,
                    MethodSymbol? methodOpt,
                    LookupResultKind resultKind,
                    BoundExpression left,
                    BoundExpression right,
                    TypeSymbol type,
                    bool hasErrors = false) : this(f_10579_18027_18033_C(syntax), operatorKind, constantValueOpt, methodOpt, resultKind, originalUserDefinedOperatorsOpt: default, left, right, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 17637, 18183);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 17637, 18183);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 17637, 18183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 17637, 18183);
            }
        }

        public BoundBinaryOperator Update(BinaryOperatorKind operatorKind,
                                                  ConstantValue? constantValueOpt,
                                                  MethodSymbol? methodOpt,
                                                  LookupResultKind resultKind,
                                                  BoundExpression left,
                                                  BoundExpression right,
                                                  TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 18682, 18803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 18685, 18803);
                return f_10579_18685_18803(this, operatorKind, constantValueOpt, methodOpt, resultKind, f_10579_18747_18783(this), left, right, type); DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 18682, 18803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 18682, 18803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 18682, 18803);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            f_10579_18747_18783(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
            this_param)
            {
                var return_v = this_param.OriginalUserDefinedOperatorsOpt;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 18747, 18783);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
            f_10579_18685_18803(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
            this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
            operatorKind, Microsoft.CodeAnalysis.ConstantValue?
            constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            methodOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
            resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            originalUserDefinedOperatorsOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
            left, Microsoft.CodeAnalysis.CSharp.BoundExpression
            right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = this_param.Update(operatorKind, constantValueOpt, methodOpt, resultKind, originalUserDefinedOperatorsOpt, left, right, type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 18685, 18803);
                return return_v;
            }

        }

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_17327_17333_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 16844, 17627);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_18027_18033_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 17637, 18183);
            return return_v;
        }

    }
    internal sealed partial class BoundUserDefinedConditionalLogicalOperator
    {
        public BoundUserDefinedConditionalLogicalOperator(
                    SyntaxNode syntax,
                    BinaryOperatorKind operatorKind,
                    BoundExpression left,
                    BoundExpression right,
                    MethodSymbol logicalOperator,
                    MethodSymbol trueOperator,
                    MethodSymbol falseOperator,
                    LookupResultKind resultKind,
                    ImmutableArray<MethodSymbol> originalUserDefinedOperatorsOpt,
                    TypeSymbol type,
                    bool hasErrors = false)
        : this(
        f_10579_19454_19460_C(syntax), operatorKind, logicalOperator, trueOperator, falseOperator, resultKind, originalUserDefinedOperatorsOpt, left, right, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 18908, 19873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 19791, 19862);

                f_10579_19791_19861(f_10579_19804_19832(operatorKind) && (DynAbs.Tracing.TraceSender.Expression_True(10579, 19804, 19860) && f_10579_19836_19860(operatorKind)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 18908, 19873);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 18908, 19873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 18908, 19873);
            }
        }

        public BoundUserDefinedConditionalLogicalOperator Update(BinaryOperatorKind operatorKind,
                                                                         MethodSymbol logicalOperator,
                                                                         MethodSymbol trueOperator,
                                                                         MethodSymbol falseOperator,
                                                                         LookupResultKind resultKind,
                                                                         BoundExpression left,
                                                                         BoundExpression right,
                                                                         TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 20626, 20764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 20629, 20764);
                return f_10579_20629_20764(this, operatorKind, logicalOperator, trueOperator, falseOperator, resultKind, f_10579_20708_20744(this), left, right, type); DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 20626, 20764);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 20626, 20764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 20626, 20764);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            f_10579_20708_20744(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
            this_param)
            {
                var return_v = this_param.OriginalUserDefinedOperatorsOpt;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 20708, 20744);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
            f_10579_20629_20764(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
            this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
            operatorKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            logicalOperator, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            trueOperator, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            falseOperator, Microsoft.CodeAnalysis.CSharp.LookupResultKind
            resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            originalUserDefinedOperatorsOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
            left, Microsoft.CodeAnalysis.CSharp.BoundExpression
            right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = this_param.Update(operatorKind, logicalOperator, trueOperator, falseOperator, resultKind, originalUserDefinedOperatorsOpt, left, right, type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 20629, 20764);
                return return_v;
            }

        }

        bool
        f_10579_19804_19832(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
        kind)
        {
            var return_v = kind.IsUserDefined();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 19804, 19832);
            return return_v;
        }


        bool
        f_10579_19836_19860(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
        kind)
        {
            var return_v = kind.IsLogical();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 19836, 19860);
            return return_v;
        }


        int
        f_10579_19791_19861(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 19791, 19861);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_19454_19460_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 18908, 19873);
            return return_v;
        }

    }
    internal sealed partial class BoundParameter
    {
        public BoundParameter(SyntaxNode syntax, ParameterSymbol parameterSymbol, bool hasErrors = false)
        : this(f_10579_20959_20965_C(syntax), parameterSymbol, f_10579_20984_21004(parameterSymbol), hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 20841, 21038);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 20841, 21038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 20841, 21038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 20841, 21038);
            }
        }

        public BoundParameter(SyntaxNode syntax, ParameterSymbol parameterSymbol)
        : this(f_10579_21144_21150_C(syntax), parameterSymbol, f_10579_21169_21189(parameterSymbol))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 21050, 21212);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 21050, 21212);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 21050, 21212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 21050, 21212);
            }
        }

        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10579_20984_21004(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 20984, 21004);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_20959_20965_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 20841, 21038);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10579_21169_21189(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 21169, 21189);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_21144_21150_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 21050, 21212);
            return return_v;
        }

    }
    internal sealed partial class BoundTypeExpression
    {
        public BoundTypeExpression(SyntaxNode syntax, AliasSymbol? aliasOpt, BoundTypeExpression? boundContainingTypeOpt, ImmutableArray<BoundExpression> boundDimensionsOpt, TypeWithAnnotations typeWithAnnotations, bool hasErrors = false)
        : this(f_10579_21544_21550_C(syntax), aliasOpt, boundContainingTypeOpt, boundDimensionsOpt, typeWithAnnotations, typeWithAnnotations.Type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 21293, 21785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 21688, 21774);

                f_10579_21688_21773((object)typeWithAnnotations.Type != null, "Field 'type' cannot be null");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 21293, 21785);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 21293, 21785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 21293, 21785);
            }
        }

        public BoundTypeExpression(SyntaxNode syntax, AliasSymbol? aliasOpt, BoundTypeExpression? boundContainingTypeOpt, TypeWithAnnotations typeWithAnnotations, bool hasErrors = false)
        : this(f_10579_21996_22002_C(syntax), aliasOpt, boundContainingTypeOpt, ImmutableArray<BoundExpression>.Empty, typeWithAnnotations, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 21797, 22130);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 21797, 22130);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 21797, 22130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 21797, 22130);
            }
        }

        public BoundTypeExpression(SyntaxNode syntax, AliasSymbol? aliasOpt, TypeWithAnnotations typeWithAnnotations, bool hasErrors = false)
        : this(f_10579_22296_22302_C(syntax), aliasOpt, null, typeWithAnnotations, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 22142, 22373);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 22142, 22373);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 22142, 22373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 22142, 22373);
            }
        }

        public BoundTypeExpression(SyntaxNode syntax, AliasSymbol? aliasOpt, TypeSymbol type, bool hasErrors = false)
        : this(f_10579_22515_22521_C(syntax), aliasOpt, null, TypeWithAnnotations.Create(type), hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 22385, 22605);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 22385, 22605);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 22385, 22605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 22385, 22605);
            }
        }

        public BoundTypeExpression(SyntaxNode syntax, AliasSymbol? aliasOpt, ImmutableArray<BoundExpression> dimensionsOpt, TypeWithAnnotations typeWithAnnotations, bool hasErrors = false)
        : this(f_10579_22818_22824_C(syntax), aliasOpt, null, dimensionsOpt, typeWithAnnotations, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 22617, 22910);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 22617, 22910);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 22617, 22910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 22617, 22910);
            }
        }

        int
        f_10579_21688_21773(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 21688, 21773);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_21544_21550_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 21293, 21785);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_21996_22002_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 21797, 22130);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_22296_22302_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 22142, 22373);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_22515_22521_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 22385, 22605);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_22818_22824_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 22617, 22910);
            return return_v;
        }

    }
    internal sealed partial class BoundNamespaceExpression
    {
        public BoundNamespaceExpression(SyntaxNode syntax, NamespaceSymbol namespaceSymbol, bool hasErrors = false)
        : this(f_10579_23124_23130_C(syntax), namespaceSymbol, null, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 22996, 23187);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 22996, 23187);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 22996, 23187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 22996, 23187);
            }
        }

        public BoundNamespaceExpression(SyntaxNode syntax, NamespaceSymbol namespaceSymbol)
        : this(f_10579_23303_23309_C(syntax), namespaceSymbol, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 23199, 23355);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 23199, 23355);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 23199, 23355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 23199, 23355);
            }
        }

        public BoundNamespaceExpression Update(NamespaceSymbol namespaceSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 23367, 23520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 23463, 23509);

                return f_10579_23470_23508(this, namespaceSymbol, f_10579_23494_23507(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 23367, 23520);

                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                f_10579_23494_23507(Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression
                this_param)
                {
                    var return_v = this_param.AliasOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 23494, 23507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression
                f_10579_23470_23508(Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                namespaceSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                aliasOpt)
                {
                    var return_v = this_param.Update(namespaceSymbol, aliasOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 23470, 23508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 23367, 23520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 23367, 23520);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_23124_23130_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 22996, 23187);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_23303_23309_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 23199, 23355);
            return return_v;
        }

    }
    internal sealed partial class BoundAssignmentOperator
    {
        public BoundAssignmentOperator(SyntaxNode syntax, BoundExpression left, BoundExpression right,
                    TypeSymbol type, bool isRef = false, bool hasErrors = false)
        : this(f_10579_23794_23800_C(syntax), left, right, isRef, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 23605, 23860);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 23605, 23860);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 23605, 23860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 23605, 23860);
            }
        }

        static BoundAssignmentOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 23535, 23867);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 23535, 23867);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 23535, 23867);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 23535, 23867);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_23794_23800_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 23605, 23860);
            return return_v;
        }

    }
    internal sealed partial class BoundBadExpression
    {
        public BoundBadExpression(SyntaxNode syntax, LookupResultKind resultKind, ImmutableArray<Symbol?> symbols, ImmutableArray<BoundExpression> childBoundNodes, TypeSymbol type)
        : this(f_10579_24133_24139_C(syntax), resultKind, symbols, childBoundNodes, type, true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 23940, 24261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 24215, 24250);

                f_10579_24215_24249((object)type != null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 23940, 24261);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 23940, 24261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 23940, 24261);
            }
        }

        static BoundBadExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 23875, 24268);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 23875, 24268);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 23875, 24268);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 23875, 24268);

        int
        f_10579_24215_24249(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 24215, 24249);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_24133_24139_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 23940, 24261);
            return return_v;
        }

    }
    internal partial class BoundStatementList
    {
        public static BoundStatementList Synthesized(SyntaxNode syntax, params BoundStatement[] statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 24334, 24535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 24458, 24524);

                return f_10579_24465_24523(syntax, false, f_10579_24492_24522(statements));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 24334, 24535);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10579_24492_24522(Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundStatement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 24492, 24522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10579_24465_24523(Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                hasErrors, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = Synthesized(syntax, hasErrors, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 24465, 24523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 24334, 24535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 24334, 24535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundStatementList Synthesized(SyntaxNode syntax, bool hasErrors, params BoundStatement[] statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 24547, 24768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 24687, 24757);

                return f_10579_24694_24756(syntax, hasErrors, f_10579_24725_24755(statements));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 24547, 24768);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10579_24725_24755(Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundStatement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 24725, 24755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10579_24694_24756(Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                hasErrors, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = Synthesized(syntax, hasErrors, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 24694, 24756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 24547, 24768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 24547, 24768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundStatementList Synthesized(SyntaxNode syntax, ImmutableArray<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 24780, 24968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 24911, 24957);

                return f_10579_24918_24956(syntax, false, statements);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 24780, 24968);

                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10579_24918_24956(Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                hasErrors, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = Synthesized(syntax, hasErrors, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 24918, 24956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 24780, 24968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 24780, 24968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundStatementList Synthesized(SyntaxNode syntax, bool hasErrors, ImmutableArray<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 24980, 25231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 25127, 25220);

                return new BoundStatementList(syntax, statements, hasErrors) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10579, 25134, 25219) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 24980, 25231);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 24980, 25231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 24980, 25231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundStatementList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 24276, 25238);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 24276, 25238);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 24276, 25238);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 24276, 25238);
    }
    internal sealed partial class BoundReturnStatement
    {
        public static BoundReturnStatement Synthesized(SyntaxNode syntax, RefKind refKind, BoundExpression expression, bool hasErrors = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 25313, 25587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 25472, 25576);

                return new BoundReturnStatement(syntax, refKind, expression, hasErrors) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10579, 25479, 25575) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 25313, 25587);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 25313, 25587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 25313, 25587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundReturnStatement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 25246, 25594);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 25246, 25594);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 25246, 25594);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 25246, 25594);
    }
    internal sealed partial class BoundYieldBreakStatement
    {
        public static BoundYieldBreakStatement Synthesized(SyntaxNode syntax, bool hasErrors = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 25673, 25889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 25791, 25878);

                return new BoundYieldBreakStatement(syntax, hasErrors) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10579, 25798, 25877) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 25673, 25889);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 25673, 25889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 25673, 25889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundYieldBreakStatement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 25602, 25896);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 25602, 25896);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 25602, 25896);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 25602, 25896);
    }
    internal sealed partial class BoundGotoStatement
    {
        public BoundGotoStatement(SyntaxNode syntax, LabelSymbol label, bool hasErrors = false)
        : this(f_10579_26077_26083_C(syntax), label, caseExpressionOpt: null, labelExpressionOpt: null, hasErrors: hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 25969, 26186);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 25969, 26186);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 25969, 26186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 25969, 26186);
            }
        }

        static BoundGotoStatement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 25904, 26193);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 25904, 26193);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 25904, 26193);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 25904, 26193);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_26077_26083_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 25969, 26186);
            return return_v;
        }

    }
    internal partial class BoundBlock
    {
        public BoundBlock(SyntaxNode syntax, ImmutableArray<LocalSymbol> locals, ImmutableArray<BoundStatement> statements, bool hasErrors = false) : this(f_10579_26398_26404_C(syntax), locals, ImmutableArray<LocalFunctionSymbol>.Empty, statements, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 26251, 26501);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 26251, 26501);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 26251, 26501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 26251, 26501);
            }
        }

        public static BoundBlock SynthesizedNoLocals(SyntaxNode syntax, BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 26513, 26782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 26627, 26771);

                return new BoundBlock(syntax, ImmutableArray<LocalSymbol>.Empty, f_10579_26692_26724(statement))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10579, 26634, 26770) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 26513, 26782);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10579_26692_26724(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 26692, 26724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 26513, 26782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 26513, 26782);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundBlock SynthesizedNoLocals(SyntaxNode syntax, ImmutableArray<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 26794, 27045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 26925, 27034);

                return new BoundBlock(syntax, ImmutableArray<LocalSymbol>.Empty, statements) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10579, 26932, 27033) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 26794, 27045);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 26794, 27045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 26794, 27045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundBlock SynthesizedNoLocals(SyntaxNode syntax, params BoundStatement[] statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10579, 27057, 27321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 27181, 27310);

                return new BoundBlock(syntax, ImmutableArray<LocalSymbol>.Empty, f_10579_27246_27276(statements)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10579, 27188, 27309) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10579, 27057, 27321);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10579_27246_27276(Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundStatement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 27246, 27276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 27057, 27321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 27057, 27321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundBlock()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 26201, 27328);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 26201, 27328);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 26201, 27328);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 26201, 27328);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_26398_26404_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 26251, 26501);
            return return_v;
        }

    }
    internal sealed partial class BoundDefaultExpression
    {
        public BoundDefaultExpression(SyntaxNode syntax, TypeSymbol type, bool hasErrors = false)
        : this(f_10579_27515_27521_C(syntax), targetType: null, f_10579_27541_27563(type), type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 27405, 27603);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 27405, 27603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 27405, 27603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 27405, 27603);
            }
        }

        public override ConstantValue? ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 27660, 27679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 27663, 27679);
                    return f_10579_27663_27679(); DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 27660, 27679);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 27660, 27679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 27660, 27679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundDefaultExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 27336, 27687);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 27336, 27687);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 27336, 27687);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 27336, 27687);

        static Microsoft.CodeAnalysis.ConstantValue?
        f_10579_27541_27563(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.GetDefaultValue();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 27541, 27563);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_27515_27521_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 27405, 27603);
            return return_v;
        }


        Microsoft.CodeAnalysis.ConstantValue?
        f_10579_27663_27679()
        {
            var return_v = ConstantValueOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 27663, 27679);
            return return_v;
        }

    }
    internal partial class BoundTryStatement
    {
        public BoundTryStatement(SyntaxNode syntax, BoundBlock tryBlock, ImmutableArray<BoundCatchBlock> catchBlocks, BoundBlock? finallyBlockOpt, LabelSymbol? finallyLabelOpt = null)
        : this(f_10579_27948_27954_C(syntax), tryBlock, catchBlocks, finallyBlockOpt, finallyLabelOpt, preferFaultHandler: false, hasErrors: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 27752, 28079);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 27752, 28079);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 27752, 28079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 27752, 28079);
            }
        }

        static BoundTryStatement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 27695, 28086);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 27695, 28086);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 27695, 28086);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 27695, 28086);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_27948_27954_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 27752, 28079);
            return return_v;
        }

    }
    internal partial class BoundAddressOfOperator
    {
        public BoundAddressOfOperator(SyntaxNode syntax, BoundExpression operand, TypeSymbol type, bool hasErrors = false)
        : this(f_10579_28292_28298_C(syntax), operand, isManaged: false, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 28156, 28365);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 28156, 28365);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 28156, 28365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 28156, 28365);
            }
        }

        static BoundAddressOfOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10579, 28094, 28372);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10579, 28094, 28372);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 28094, 28372);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10579, 28094, 28372);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_28292_28298_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 28156, 28365);
            return return_v;
        }

    }
    internal partial class BoundDagTemp
    {
        public BoundDagTemp(SyntaxNode syntax, TypeSymbol type, BoundDagEvaluation? source)
        : this(f_10579_28536_28542_C(syntax), type, source, index: 0, hasErrors: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 28432, 28607);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 28432, 28607);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 28432, 28607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 28432, 28607);
            }
        }

        public static BoundDagTemp ForOriginalInput(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 28685, 28743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 28688, 28743);
                return f_10579_28688_28743(expr.Syntax, expr.Type!, source: null); DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 28685, 28743);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 28685, 28743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 28685, 28743);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
            f_10579_28688_28743(Microsoft.CodeAnalysis.SyntaxNode
            syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
            source)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, source: source);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 28688, 28743);
                return return_v;
            }

        }

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_28536_28542_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 28432, 28607);
            return return_v;
        }

    }
    internal partial class BoundCompoundAssignmentOperator
    {
        public BoundCompoundAssignmentOperator(SyntaxNode syntax,
                    BinaryOperatorSignature @operator,
                    BoundExpression left,
                    BoundExpression right,
                    Conversion leftConversion,
                    Conversion finalConversion,
                    LookupResultKind resultKind,
                    TypeSymbol type,
                    bool hasErrors = false)
        : this(f_10579_29217_29223_C(syntax), @operator, left, right, leftConversion, finalConversion, resultKind, originalUserDefinedOperatorsOpt: default, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 28830, 29374);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 28830, 29374);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 28830, 29374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 28830, 29374);
            }
        }

        public BoundCompoundAssignmentOperator Update(BinaryOperatorSignature @operator,
                                                              BoundExpression left,
                                                              BoundExpression right,
                                                              Conversion leftConversion,
                                                              Conversion finalConversion,
                                                              LookupResultKind resultKind,
                                                              TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 29956, 30078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 29959, 30078);
                return f_10579_29959_30078(this, @operator, left, right, leftConversion, finalConversion, resultKind, f_10579_30035_30071(this), type); DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 29956, 30078);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 29956, 30078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 29956, 30078);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            f_10579_30035_30071(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
            this_param)
            {
                var return_v = this_param.OriginalUserDefinedOperatorsOpt;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 30035, 30071);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
            f_10579_29959_30078(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
            this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
            @operator, Microsoft.CodeAnalysis.CSharp.BoundExpression
            left, Microsoft.CodeAnalysis.CSharp.BoundExpression
            right, Microsoft.CodeAnalysis.CSharp.Conversion
            leftConversion, Microsoft.CodeAnalysis.CSharp.Conversion
            finalConversion, Microsoft.CodeAnalysis.CSharp.LookupResultKind
            resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            originalUserDefinedOperatorsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = this_param.Update(@operator, left, right, leftConversion, finalConversion, resultKind, originalUserDefinedOperatorsOpt, type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 29959, 30078);
                return return_v;
            }

        }

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_29217_29223_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 28830, 29374);
            return return_v;
        }

    }
    internal partial class BoundUnaryOperator
    {
        public BoundUnaryOperator(
                    SyntaxNode syntax,
                    UnaryOperatorKind operatorKind,
                    BoundExpression operand,
                    ConstantValue? constantValueOpt,
                    MethodSymbol? methodOpt,
                    LookupResultKind resultKind,
                    TypeSymbol type,
                    bool hasErrors = false) : this(f_10579_30507_30513_C(syntax), operatorKind, operand, constantValueOpt, methodOpt, resultKind, originalUserDefinedOperatorsOpt: default, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 30152, 30659);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 30152, 30659);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 30152, 30659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 30152, 30659);
            }
        }

        public BoundUnaryOperator Update(UnaryOperatorKind operatorKind,
                                                 BoundExpression operand,
                                                 ConstantValue? constantValueOpt,
                                                 MethodSymbol? methodOpt,
                                                 LookupResultKind resultKind,
                                                 TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 31088, 31205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 31091, 31205);
                return f_10579_31091_31205(this, operatorKind, operand, constantValueOpt, methodOpt, resultKind, f_10579_31162_31198(this), type); DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 31088, 31205);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 31088, 31205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 31088, 31205);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            f_10579_31162_31198(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
            this_param)
            {
                var return_v = this_param.OriginalUserDefinedOperatorsOpt;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 31162, 31198);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
            f_10579_31091_31205(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
            this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
            operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
            operand, Microsoft.CodeAnalysis.ConstantValue?
            constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            methodOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
            resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            originalUserDefinedOperatorsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = this_param.Update(operatorKind, operand, constantValueOpt, methodOpt, resultKind, originalUserDefinedOperatorsOpt, type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 31091, 31205);
                return return_v;
            }

        }

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_30507_30513_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 30152, 30659);
            return return_v;
        }

    }
    internal partial class BoundIncrementOperator
    {
        public BoundIncrementOperator(
                    CSharpSyntaxNode syntax,
                    UnaryOperatorKind operatorKind,
                    BoundExpression operand,
                    MethodSymbol? methodOpt,
                    Conversion operandConversion,
                    Conversion resultConversion,
                    LookupResultKind resultKind,
                    TypeSymbol type,
                    bool hasErrors = false) : this(f_10579_31687_31693_C(syntax), operatorKind, operand, methodOpt, operandConversion, resultConversion, resultKind, originalUserDefinedOperatorsOpt: default, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10579, 31283, 31858);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10579, 31283, 31858);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 31283, 31858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 31283, 31858);
            }
        }

        public BoundIncrementOperator Update(UnaryOperatorKind operatorKind, BoundExpression operand, MethodSymbol? methodOpt, Conversion operandConversion, Conversion resultConversion, LookupResultKind resultKind, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10579, 31870, 32270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10579, 32118, 32259);

                return f_10579_32125_32258(this, operatorKind, operand, methodOpt, operandConversion, resultConversion, resultKind, f_10579_32215_32251(this), type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10579, 31870, 32270);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10579_32215_32251(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                this_param)
                {
                    var return_v = this_param.OriginalUserDefinedOperatorsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10579, 32215, 32251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                f_10579_32125_32258(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, Microsoft.CodeAnalysis.CSharp.Conversion
                operandConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                resultConversion, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalUserDefinedOperatorsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operatorKind, operand, methodOpt, operandConversion, resultConversion, resultKind, originalUserDefinedOperatorsOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10579, 32125, 32258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10579, 31870, 32270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10579, 31870, 32270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10579_31687_31693_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10579, 31283, 31858);
            return return_v;
        }

    }
}
