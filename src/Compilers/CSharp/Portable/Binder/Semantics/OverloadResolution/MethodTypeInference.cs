// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

/*
SPEC:

Type inference occurs as part of the compile-time processing of a method invocation
and takes place before the overload resolution step of the invocation. When a
particular method group is specified in a method invocation, and no type arguments
are specified as part of the method invocation, type inference is applied to each
generic method in the method group. If type inference succeeds, then the inferred
type arguments are used to determine the types of formal parameters for subsequent 
overload resolution. If overload resolution chooses a generic method as the one to
invoke then the inferred type arguments are used as the actual type arguments for the
invocation. If type inference for a particular method fails, that method does not
participate in overload resolution. The failure of type inference, in and of itself,
does not cause a compile-time error. However, it often leads to a compile-time error
when overload resolution then fails to find any applicable methods.

If the supplied number of arguments is different than the number of parameters in
the method, then inference immediately fails. Otherwise, assume that the generic
method has the following signature:

Tr M<X1...Xn>(T1 x1 ... Tm xm)

With a method call of the form M(E1...Em) the task of type inference is to find
unique type arguments S1...Sn for each of the type parameters X1...Xn so that the
call M<S1...Sn>(E1...Em)becomes valid.

During the process of inference each type parameter Xi is either fixed to a particular
type Si or unfixed with an associated set of bounds. Each of the bounds is some type T.
Each bound is classified as an upper bound, lower bound or exact bound.
Initially each type variable Xi is unfixed with an empty set of bounds.

*/

// This file contains the implementation for method type inference on calls (with
// arguments, and method type inference on conversion of method groups to delegate
// types (which will not have arguments.)

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class PooledDictionaryIgnoringNullableModifiersForReferenceTypes
    {
        private static readonly ObjectPool<PooledDictionary<NamedTypeSymbol, NamedTypeSymbol>> s_poolInstance
        ;

        internal static PooledDictionary<NamedTypeSymbol, NamedTypeSymbol> GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 3008, 3243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 3113, 3154);

                var
                instance = f_10873_3128_3153(s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 3168, 3202);

                f_10873_3168_3201(f_10873_3181_3195(instance) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 3216, 3232);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 3008, 3243);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_3128_3153(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 3128, 3153);
                    return return_v;
                }


                int
                f_10873_3181_3195(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 3181, 3195);
                    return return_v;
                }


                int
                f_10873_3168_3201(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 3168, 3201);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 3008, 3243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 3008, 3243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PooledDictionaryIgnoringNullableModifiersForReferenceTypes()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10873, 2671, 3250);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 2855, 2995);
            s_poolInstance = f_10873_2885_2995(Symbols.SymbolEqualityComparer.IgnoringNullable); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10873, 2671, 3250);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 2671, 3250);
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
        f_10873_2885_2995(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
        keyComparer)
        {
            var return_v = PooledDictionary<NamedTypeSymbol, NamedTypeSymbol>.CreatePool((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 2885, 2995);
            return return_v;
        }

    }

    internal struct MethodTypeInferenceResult
    {

        public readonly ImmutableArray<TypeWithAnnotations> InferredTypeArguments;

        public readonly bool Success;

        public MethodTypeInferenceResult(
                    bool success,
                    ImmutableArray<TypeWithAnnotations> inferredTypeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10873, 3525, 3781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 3682, 3705);

                this.Success = success;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 3719, 3770);

                this.InferredTypeArguments = inferredTypeArguments;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10873, 3525, 3781);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 3525, 3781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 3525, 3781);
            }
        }
        static MethodTypeInferenceResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10873, 3342, 3788);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10873, 3342, 3788);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 3342, 3788);
        }
    }
    internal sealed class MethodTypeInferrer
    {
        internal abstract class Extensions
        {
            internal static readonly Extensions Default;

            internal abstract TypeWithAnnotations GetTypeWithAnnotations(BoundExpression expr);

            internal abstract TypeWithAnnotations GetMethodGroupResultType(BoundMethodGroup group, MethodSymbol method);
            private sealed class DefaultExtensions : Extensions
            {
                internal override TypeWithAnnotations GetTypeWithAnnotations(BoundExpression expr)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 4305, 4492);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 4428, 4473);

                        return TypeWithAnnotations.Create(f_10873_4462_4471(expr));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 4305, 4492);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10873_4462_4471(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 4462, 4471);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 4305, 4492);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 4305, 4492);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal override TypeWithAnnotations GetMethodGroupResultType(BoundMethodGroup group, MethodSymbol method)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 4512, 4719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 4660, 4700);

                        return f_10873_4667_4699(method);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 4512, 4719);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10873_4667_4699(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnTypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 4667, 4699);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 4512, 4719);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 4512, 4719);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public DefaultExtensions()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10873, 4221, 4734);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10873, 4221, 4734);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 4221, 4734);
                }


                static DefaultExtensions()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10873, 4221, 4734);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10873, 4221, 4734);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 4221, 4734);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10873, 4221, 4734);
            }

            public Extensions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10873, 3853, 4745);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10873, 3853, 4745);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 3853, 4745);
            }


            static Extensions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10873, 3853, 4745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 3948, 3981);
                Default = f_10873_3958_3981(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10873, 3853, 4745);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 3853, 4745);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10873, 3853, 4745);

            static Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.Extensions.DefaultExtensions
            f_10873_3958_3981()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.Extensions.DefaultExtensions();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 3958, 3981);
                return return_v;
            }

        }

        private enum InferenceResult
        {
            InferenceFailed,
            MadeProgress,
            NoProgress,
            Success
        }

        private enum Dependency
        {
            Unknown = 0x00,
            NotDependent = 0x01,
            DependsMask = 0x10,
            Direct = 0x11,
            Indirect = 0x12
        }

        private readonly ConversionsBase _conversions;

        private readonly ImmutableArray<TypeParameterSymbol> _methodTypeParameters;

        private readonly NamedTypeSymbol _constructedContainingTypeOfMethod;

        private readonly ImmutableArray<TypeWithAnnotations> _formalParameterTypes;

        private readonly ImmutableArray<RefKind> _formalParameterRefKinds;

        private readonly ImmutableArray<BoundExpression> _arguments;

        private readonly Extensions _extensions;

        private readonly TypeWithAnnotations[] _fixedResults;

        private readonly HashSet<TypeWithAnnotations>[] _exactBounds;

        private readonly HashSet<TypeWithAnnotations>[] _upperBounds;

        private readonly HashSet<TypeWithAnnotations>[] _lowerBounds;

        private Dependency[,] _dependencies;

        private bool _dependenciesDirty;

        private int NumberArgumentsToProcess
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 6308, 6375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 6311, 6375);
                    return f_10873_6311_6375(_arguments.Length, _formalParameterTypes.Length); DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 6308, 6375);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 6308, 6375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 6308, 6375);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MethodTypeInferenceResult Infer(
                    Binder binder,
                    ConversionsBase conversions,
                    ImmutableArray<TypeParameterSymbol> methodTypeParameters,
                    // We are attempting to build a map from method type parameters 
                    // to inferred type arguments.

                    NamedTypeSymbol constructedContainingTypeOfMethod,
                    ImmutableArray<TypeWithAnnotations> formalParameterTypes,

                    // We have some unusual requirements for the types that flow into the inference engine.
                    // Consider the following inference problems:
                    // 
                    // Scenario one: 
                    //
                    // class C<T> 
                    // {
                    //   delegate Y FT<X, Y>(T t, X x);
                    //   static void M<U, V>(U u, FT<U, V> f);
                    //   ...
                    //   C<double>.M(123, (t,x)=>t+x);
                    //
                    // From the first argument we infer that U is int. How now must we make an inference on
                    // the second argument? The *declared* type of the formal is C<T>.FT<U,V>. The
                    // actual type at the time of inference is known to be C<double>.FT<int, something>
                    // where "something" is to be determined by inferring the return type of the 
                    // lambda by determine the type of "double + int". 
                    // 
                    // Therefore when we do type inference, if a formal parameter type is a generic delegate
                    // then *its* formal parameter types must be the formal parameter types of the 
                    // *constructed* generic delegate C<double>.FT<...>, not C<T>.FT<...>. 
                    //
                    // One would therefore suppose that we'd expect the formal parameter types to here
                    // be passed in with the types constructed with the information known from the
                    // call site, not the declared types.
                    //
                    // Contrast that with this scenario:
                    //
                    // Scenario Two:
                    //
                    // interface I<T> 
                    // { 
                    //    void M<U>(T t, U u); 
                    // }
                    // ...
                    // static void Goo<V>(V v, I<V> iv) 
                    // {
                    //   iv.M(v, "");
                    // }
                    //
                    // Obviously inference should succeed here; it should infer that U is string. 
                    //
                    // But consider what happens during the inference process on the first argument.
                    // The first thing we will do is say "what's the type of the argument? V. What's
                    // the type of the corresponding formal parameter? The first formal parameter of
                    // I<V>.M<whatever> is of type V. The inference engine will then say "V is a 
                    // method type parameter, and therefore we have an inference from V to V". 
                    // But *V* is not one of the method type parameters being inferred; the only 
                    // method type parameter being inferred here is *U*.
                    //
                    // This is perhaps some evidence that the formal parameters passed in should be
                    // the formal parameters of the *declared* method; in this case, (T, U), not
                    // the formal parameters of the *constructed* method, (V, U). 
                    //
                    // However, one might make the argument that no, we could just add a check
                    // to ensure that if we see a method type parameter as a formal parameter type,
                    // then we only perform the inference if the method type parameter is a type 
                    // parameter of the method for which inference is being performed.
                    //
                    // Unfortunately, that does not work either:
                    //
                    // Scenario three:
                    //
                    // class C<T>
                    // {
                    //   static void M<U>(T t, U u)
                    //   {
                    //     ...
                    //     C<U>.M(u, 123);
                    //     ...
                    //   }
                    // }
                    //
                    // The *original* formal parameter types are (T, U); the *constructed* formal parameter types
                    // are (U, U), but *those are logically two different U's*. The first U is from the outer caller;
                    // the second U is the U of the recursive call.
                    //
                    // That is, suppose someone called C<string>.M<double>(string, double).  The recursive call should be to
                    // C<double>.M<int>(double, int). We should absolutely not make an inference on the first argument
                    // from U to U just because C<U>.M<something>'s first formal parameter is of type U.  If we did then
                    // inference would fail, because we'd end up with two bounds on 'U' -- 'U' and 'int'. We only want
                    // the latter bound.
                    //
                    // What these three scenarios show is that for a "normal" inference we need to have the
                    // formal parameters of the *original* method definition, but when making an inference from a lambda
                    // to a delegate, we need to have the *constructed* method signature in order that the formal
                    // parameters *of the delegate* be correct.
                    //
                    // How to solve this problem?
                    //
                    // We solve it by passing in the formal parameters in their *original* form, but also getting
                    // the *fully constructed* type that the method call is on. When constructing the fixed
                    // delegate type for inference from a lambda, we do the appropriate type substitution on
                    // the delegate.

                    ImmutableArray<RefKind> formalParameterRefKinds, // Optional; assume all value if missing.
                    ImmutableArray<BoundExpression> arguments,// Required; in scenarios like method group conversions where there are
                                                              // no arguments per se we cons up some fake arguments.
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    Extensions extensions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 6388, 13808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 12509, 12555);

                f_10873_12509_12554(f_10873_12522_12553_M(!methodTypeParameters.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 12569, 12615);

                f_10873_12569_12614(methodTypeParameters.Length > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 12629, 12675);

                f_10873_12629_12674(f_10873_12642_12673_M(!formalParameterTypes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 12689, 12802);

                f_10873_12689_12801(formalParameterRefKinds.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10873, 12702, 12800) || formalParameterRefKinds.Length == formalParameterTypes.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 12816, 12851);

                f_10873_12816_12850(f_10873_12829_12849_M(!arguments.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 12972, 13407) || true) && (formalParameterTypes.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 12972, 13407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 13042, 13132);

                    return f_10873_13049_13131(false, default(ImmutableArray<TypeWithAnnotations>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 12972, 13407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 13423, 13721);

                var
                inferrer = f_10873_13438_13720(conversions, methodTypeParameters, constructedContainingTypeOfMethod, formalParameterTypes, formalParameterRefKinds, arguments, extensions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 13735, 13797);

                return f_10873_13742_13796(inferrer, binder, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 6388, 13808);

                bool
                f_10873_12522_12553_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 12522, 12553);
                    return return_v;
                }


                int
                f_10873_12509_12554(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 12509, 12554);
                    return 0;
                }


                int
                f_10873_12569_12614(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 12569, 12614);
                    return 0;
                }


                bool
                f_10873_12642_12673_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 12642, 12673);
                    return return_v;
                }


                int
                f_10873_12629_12674(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 12629, 12674);
                    return 0;
                }


                int
                f_10873_12689_12801(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 12689, 12801);
                    return 0;
                }


                bool
                f_10873_12829_12849_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 12829, 12849);
                    return return_v;
                }


                int
                f_10873_12816_12850(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 12816, 12850);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodTypeInferenceResult
                f_10873_13049_13131(bool
                success, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                inferredTypeArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodTypeInferenceResult(success, inferredTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 13049, 13131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                f_10873_13438_13720(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                methodTypeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                constructedContainingTypeOfMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                formalParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                formalParameterRefKinds, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.Extensions?
                extensions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer(conversions, methodTypeParameters, constructedContainingTypeOfMethod, formalParameterTypes, formalParameterRefKinds, arguments, extensions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 13438, 13720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodTypeInferenceResult
                f_10873_13742_13796(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.InferTypeArgs(binder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 13742, 13796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 6388, 13808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 6388, 13808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodTypeInferrer(
                    ConversionsBase conversions,
                    ImmutableArray<TypeParameterSymbol> methodTypeParameters,
                    NamedTypeSymbol constructedContainingTypeOfMethod,
                    ImmutableArray<TypeWithAnnotations> formalParameterTypes,
                    ImmutableArray<RefKind> formalParameterRefKinds,
                    ImmutableArray<BoundExpression> arguments,
                    Extensions extensions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10873, 14305, 15595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 5165, 5177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 5306, 5340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 5610, 5621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 5673, 5686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 5745, 5757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 5816, 5828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 5887, 5899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 5932, 5945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 5991, 6009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 14759, 14786);

                _conversions = conversions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 14800, 14845);

                _methodTypeParameters = methodTypeParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 14859, 14930);

                _constructedContainingTypeOfMethod = constructedContainingTypeOfMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 14944, 14989);

                _formalParameterTypes = formalParameterTypes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15003, 15054);

                _formalParameterRefKinds = formalParameterRefKinds;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15068, 15091);

                _arguments = arguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15105, 15152);

                _extensions = extensions ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.Extensions>(10873, 15119, 15151) ?? Extensions.Default);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15166, 15235);

                _fixedResults = new TypeWithAnnotations[methodTypeParameters.Length];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15249, 15326);

                _exactBounds = new HashSet<TypeWithAnnotations>[methodTypeParameters.Length];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15340, 15417);

                _upperBounds = new HashSet<TypeWithAnnotations>[methodTypeParameters.Length];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15431, 15508);

                _lowerBounds = new HashSet<TypeWithAnnotations>[methodTypeParameters.Length];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15522, 15543);

                _dependencies = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15557, 15584);

                _dependenciesDirty = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10873, 14305, 15595);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 14305, 15595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 14305, 15595);
            }
        }

        internal string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 15620, 18733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15667, 15708);

                var
                sb = f_10873_15676_15707()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15722, 15776);

                f_10873_15722_15775(sb, "Method type inference internal state");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15790, 15892);

                f_10873_15790_15891(sb, "Inferring method type parameters <{0}>\n", f_10873_15850_15890(", ", _methodTypeParameters));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15906, 15944);

                f_10873_15906_15943(sb, "Formal parameter types (");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15967, 15972);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 15958, 16266) || true) && (i < _formalParameterTypes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16008, 16011)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 15958, 16266))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 15958, 16266);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16045, 16132) || true) && (i != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 16045, 16132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16097, 16113);

                            f_10873_16097_16112(sb, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 16045, 16132);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16152, 16197);

                        f_10873_16152_16196(
                                        sb, f_10873_16162_16195(f_10873_16162_16175(this, i)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16215, 16251);

                        f_10873_16215_16250(sb, _formalParameterTypes[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16282, 16298);

                f_10873_16282_16297(
                            sb, "\n");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16314, 16411);

                f_10873_16314_16410(
                            sb, "Argument types ({0})\n", f_10873_16356_16409(", ", DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from a in _arguments select a.Type, 10873, 16374, 16408)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16427, 17768) || true) && (_dependencies == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 16427, 17768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16486, 16539);

                    f_10873_16486_16538(sb, "Dependencies are not yet calculated");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 16427, 17768);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 16427, 17768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16605, 16698);

                    f_10873_16605_16697(sb, "Dependencies are {0}\n", (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 16647, 16665) || ((_dependenciesDirty && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 16668, 16681)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 16684, 16696))) ? "out of date" : "up to date");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16716, 16798);

                    f_10873_16716_16797(sb, "dependency matrix (Not dependent / Direct / Indirect / Unknown):");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16825, 16830);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16816, 17753) || true) && (i < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16866, 16869)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 16816, 17753))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 16816, 17753);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16920, 16925);
                                for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16911, 17696) || true) && (j < _methodTypeParameters.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 16961, 16964)
            , ++j, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 16911, 17696))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 16911, 17696);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17014, 17673);

                                    switch (_dependencies[i, j])
                                    {

                                        case Dependency.NotDependent:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 17014, 17673);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17162, 17177);

                                            f_10873_17162_17176(sb, "N");
                                            DynAbs.Tracing.TraceSender.TraceBreak(10873, 17211, 17217);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 17014, 17673);

                                        case Dependency.Direct:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 17014, 17673);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17304, 17319);

                                            f_10873_17304_17318(sb, "D");
                                            DynAbs.Tracing.TraceSender.TraceBreak(10873, 17353, 17359);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 17014, 17673);

                                        case Dependency.Indirect:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 17014, 17673);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17448, 17463);

                                            f_10873_17448_17462(sb, "I");
                                            DynAbs.Tracing.TraceSender.TraceBreak(10873, 17497, 17503);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 17014, 17673);

                                        case Dependency.Unknown:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 17014, 17673);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17591, 17606);

                                            f_10873_17591_17605(sb, "U");
                                            DynAbs.Tracing.TraceSender.TraceBreak(10873, 17640, 17646);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 17014, 17673);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 786);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 786);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17718, 17734);

                            f_10873_17718_17733(sb);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 938);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 938);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 16427, 17768);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17793, 17798);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17784, 18685) || true) && (i < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17834, 17837)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 17784, 18685))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 17784, 18685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17871, 17949);

                        f_10873_17871_17948(sb, "Method type parameter {0}: ", f_10873_17918_17947(_methodTypeParameters[i]));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 17969, 18002);

                        var
                        fixedType = _fixedResults[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18022, 18253) || true) && (f_10873_18026_18044_M(!fixedType.HasType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 18022, 18253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18086, 18108);

                            f_10873_18086_18107(sb, "UNFIXED ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 18022, 18253);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 18022, 18253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18190, 18234);

                            f_10873_18190_18233(sb, "FIXED to {0} ", fixedType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 18022, 18253);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18273, 18382);

                        f_10873_18273_18381(
                                        sb, "upper bounds: ({0}) ", (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 18313, 18338) || (((_upperBounds[i] == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 18341, 18343)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 18346, 18380))) ? "" : f_10873_18346_18380(", ", _upperBounds[i]));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18400, 18509);

                        f_10873_18400_18508(sb, "lower bounds: ({0}) ", (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 18440, 18465) || (((_lowerBounds[i] == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 18468, 18470)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 18473, 18507))) ? "" : f_10873_18473_18507(", ", _lowerBounds[i]));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18527, 18636);

                        f_10873_18527_18635(sb, "exact bounds: ({0}) ", (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 18567, 18592) || (((_exactBounds[i] == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 18595, 18597)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 18600, 18634))) ? "" : f_10873_18600_18634(", ", _exactBounds[i]));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18654, 18670);

                        f_10873_18654_18669(sb);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 902);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18701, 18722);

                return f_10873_18708_18721(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 15620, 18733);

                System.Text.StringBuilder
                f_10873_15676_15707()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 15676, 15707);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_15722_15775(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 15722, 15775);
                    return return_v;
                }


                string
                f_10873_15850_15890(string
                separator, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 15850, 15890);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_15790_15891(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 15790, 15891);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_15906_15943(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 15906, 15943);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_16097_16112(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16097, 16112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10873_16162_16175(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.GetRefKind(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16162, 16175);
                    return return_v;
                }


                string
                f_10873_16162_16195(Microsoft.CodeAnalysis.RefKind
                kind)
                {
                    var return_v = kind.ToParameterPrefix();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16162, 16195);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_16152_16196(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16152, 16196);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_16215_16250(System.Text.StringBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16215, 16250);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_16282_16297(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16282, 16297);
                    return return_v;
                }


                string
                f_10873_16356_16409(string
                separator, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16356, 16409);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_16314_16410(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16314, 16410);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_16486_16538(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16486, 16538);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_16605_16697(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16605, 16697);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_16716_16797(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 16716, 16797);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_17162_17176(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 17162, 17176);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_17304_17318(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 17304, 17318);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_17448_17462(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 17448, 17462);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_17591_17605(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 17591, 17605);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_17718_17733(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 17718, 17733);
                    return return_v;
                }


                string
                f_10873_17918_17947(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 17918, 17947);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_17871_17948(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 17871, 17948);
                    return return_v;
                }


                bool
                f_10873_18026_18044_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 18026, 18044);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_18086_18107(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18086, 18107);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_18190_18233(System.Text.StringBuilder
                this_param, string
                format, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18190, 18233);
                    return return_v;
                }


                string
                f_10873_18346_18380(string
                separator, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18346, 18380);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_18273_18381(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18273, 18381);
                    return return_v;
                }


                string
                f_10873_18473_18507(string
                separator, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18473, 18507);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_18400_18508(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18400, 18508);
                    return return_v;
                }


                string
                f_10873_18600_18634(string
                separator, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18600, 18634);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_18527_18635(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18527, 18635);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10873_18654_18669(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18654, 18669);
                    return return_v;
                }


                string
                f_10873_18708_18721(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18708, 18721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 15620, 18733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 15620, 18733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RefKind GetRefKind(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 18755, 18998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18817, 18882);

                f_10873_18817_18881(0 <= index && (DynAbs.Tracing.TraceSender.Expression_True(10873, 18830, 18880) && index < _formalParameterTypes.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 18896, 18987);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 18903, 18937) || ((_formalParameterRefKinds.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 18940, 18952)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 18955, 18986))) ? RefKind.None : _formalParameterRefKinds[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 18755, 18998);

                int
                f_10873_18817_18881(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 18817, 18881);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 18755, 18998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 18755, 18998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeWithAnnotations> GetResults()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 19010, 20677);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 19935, 19940);
                    // Anything we didn't infer a type for, give the error type.
                    // Note: the error type will have the same name as the name
                    // of the type parameter we were trying to infer.  This will give a
                    // nice user experience where by we will show something like
                    // the following:
                    //
                    // user types: customers.Select(
                    // we show   : IE<TResult> IE<Customer>.Select<Customer,TResult>(Func<Customer,TResult> selector)
                    //
                    // Initially we thought we'd just show ?.  i.e.:
                    //
                    //  IE<?> IE<Customer>.Select<Customer,?>(Func<Customer,?> selector)
                    //
                    // This is nice and concise.  However, it falls down if there are multiple
                    // type params that we have left.

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 19926, 20615) || true) && (i < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 19976, 19979)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 19926, 20615))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 19926, 20615);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20013, 20424) || true) && (_fixedResults[i].HasType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 20013, 20424);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20083, 20205) || true) && (!f_10873_20088_20123(_fixedResults[i].Type))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 20083, 20205);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20173, 20182);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 20083, 20205);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20229, 20276);

                            var
                            errorTypeName = f_10873_20249_20275(_fixedResults[i].Type)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20298, 20405) || true) && (errorTypeName != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 20298, 20405);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20373, 20382);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 20298, 20405);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 20013, 20424);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20442, 20600);

                        _fixedResults[i] = TypeWithAnnotations.Create(f_10873_20488_20598(_constructedContainingTypeOfMethod, f_10873_20552_20581(_methodTypeParameters[i]), 0, null, false));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 690);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20631, 20666);

                return f_10873_20638_20665(_fixedResults);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 19010, 20677);

                bool
                f_10873_20088_20123(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 20088, 20123);
                    return return_v;
                }


                string
                f_10873_20249_20275(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 20249, 20275);
                    return return_v;
                }


                string
                f_10873_20552_20581(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 20552, 20581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10873_20488_20598(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingSymbol, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticInfo?
                errorInfo, bool
                unreported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)containingSymbol, name, arity, errorInfo, unreported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 20488, 20598);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_20638_20665(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations[]
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 20638, 20665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 19010, 20677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 19010, 20677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ValidIndex(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 20689, 20817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20748, 20806);

                return 0 <= index && (DynAbs.Tracing.TraceSender.Expression_True(10873, 20755, 20805) && index < _methodTypeParameters.Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 20689, 20817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 20689, 20817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 20689, 20817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsUnfixed(int methodTypeParameterIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 20829, 21038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20906, 20957);

                f_10873_20906_20956(f_10873_20919_20955(this, methodTypeParameterIndex));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 20971, 21027);

                return f_10873_20978_21026_M(!_fixedResults[methodTypeParameterIndex].HasType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 20829, 21038);

                bool
                f_10873_20919_20955(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 20919, 20955);
                    return return_v;
                }


                int
                f_10873_20906_20956(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 20906, 20956);
                    return 0;
                }


                bool
                f_10873_20978_21026_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 20978, 21026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 20829, 21038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 20829, 21038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsUnfixedTypeParameter(TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 21050, 21583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21136, 21163);

                f_10873_21136_21162(type.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21179, 21237) || true) && (type.TypeKind != TypeKind.TypeParameter)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 21179, 21237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21224, 21237);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 21179, 21237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21253, 21320);

                TypeParameterSymbol
                typeParameter = (TypeParameterSymbol)type.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21334, 21370);

                int
                ordinal = f_10873_21348_21369(typeParameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21384, 21572);

                return f_10873_21391_21410(this, ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 21391, 21532) && f_10873_21431_21532(typeParameter, _methodTypeParameters[ordinal], TypeCompareKind.ConsiderEverything2)) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 21391, 21571) && f_10873_21553_21571(this, ordinal));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 21050, 21583);

                int
                f_10873_21136_21162(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 21136, 21162);
                    return 0;
                }


                int
                f_10873_21348_21369(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 21348, 21369);
                    return return_v;
                }


                bool
                f_10873_21391_21410(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 21391, 21410);
                    return return_v;
                }


                bool
                f_10873_21431_21532(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 21431, 21532);
                    return return_v;
                }


                bool
                f_10873_21553_21571(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 21553, 21571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 21050, 21583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 21050, 21583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AllFixed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 21595, 21964);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21652, 21680);
                    for (int
        methodTypeParameterIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21643, 21927) || true) && (methodTypeParameterIndex < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21739, 21765)
        , ++methodTypeParameterIndex, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 21643, 21927))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 21643, 21927);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21799, 21912) || true) && (f_10873_21803_21838(this, methodTypeParameterIndex))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 21799, 21912);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21880, 21893);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 21799, 21912);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 21941, 21953);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 21595, 21964);

                bool
                f_10873_21803_21838(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 21803, 21838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 21595, 21964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 21595, 21964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddBound(TypeWithAnnotations addedBound, HashSet<TypeWithAnnotations>[] collectedBounds, TypeWithAnnotations methodTypeParameterWithAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 21976, 22750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 22158, 22231);

                f_10873_22158_22230(f_10873_22171_22229(this, methodTypeParameterWithAnnotations));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 22247, 22334);

                var
                methodTypeParameter = (TypeParameterSymbol)methodTypeParameterWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 22348, 22407);

                int
                methodTypeParameterIndex = f_10873_22379_22406(methodTypeParameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 22423, 22665) || true) && (collectedBounds[methodTypeParameterIndex] == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 22423, 22665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 22510, 22650);

                    collectedBounds[methodTypeParameterIndex] = f_10873_22554_22649(TypeWithAnnotations.EqualsComparer.ConsiderEverythingComparer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 22423, 22665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 22681, 22739);

                f_10873_22681_22738(
                            collectedBounds[methodTypeParameterIndex], addedBound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 21976, 22750);

                bool
                f_10873_22171_22229(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.IsUnfixedTypeParameter(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 22171, 22229);
                    return return_v;
                }


                int
                f_10873_22158_22230(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 22158, 22230);
                    return 0;
                }


                int
                f_10873_22379_22406(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 22379, 22406);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_22554_22649(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.EqualsComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 22554, 22649);
                    return return_v;
                }


                bool
                f_10873_22681_22738(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 22681, 22738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 21976, 22750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 21976, 22750);
            }
        }

        private bool HasBound(int methodTypeParameterIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 22762, 23102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 22838, 22889);

                f_10873_22838_22888(f_10873_22851_22887(this, methodTypeParameterIndex));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 22903, 23091);

                return _lowerBounds[methodTypeParameterIndex] != null || (DynAbs.Tracing.TraceSender.Expression_False(10873, 22910, 23023) || _upperBounds[methodTypeParameterIndex] != null) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 22910, 23090) || _exactBounds[methodTypeParameterIndex] != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 22762, 23102);

                bool
                f_10873_22851_22887(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 22851, 22887);
                    return return_v;
                }


                int
                f_10873_22838_22888(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 22838, 22888);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 22762, 23102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 22762, 23102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol GetFixedDelegateOrFunctionPointer(TypeSymbol delegateOrFunctionPointerType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 23114, 24454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 23233, 23293);

                f_10873_23233_23292((object)delegateOrFunctionPointerType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 23307, 23430);

                f_10873_23307_23429(f_10873_23320_23366(delegateOrFunctionPointerType) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 23320, 23428) || delegateOrFunctionPointerType is FunctionPointerTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 23871, 23968);

                var
                fixedArguments = f_10873_23892_23967(_methodTypeParameters.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 23991, 24001);
                    for (int
        iParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 23982, 24221) || true) && (iParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 24042, 24050)
        , iParam++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 23982, 24221))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 23982, 24221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 24084, 24206);

                        f_10873_24084_24205(fixedArguments, (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 24103, 24120) || ((f_10873_24103_24120(this, iParam) && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 24123, 24180)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 24183, 24204))) ? TypeWithAnnotations.Create(_methodTypeParameters[iParam]) : _fixedResults[iParam]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 24237, 24363);

                TypeMap
                typeMap = f_10873_24255_24362(_constructedContainingTypeOfMethod, _methodTypeParameters, f_10873_24326_24361(fixedArguments))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 24377, 24443);

                return f_10873_24384_24437(typeMap, delegateOrFunctionPointerType).Type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 23114, 24454);

                int
                f_10873_23233_23292(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 23233, 23292);
                    return 0;
                }


                bool
                f_10873_23320_23366(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 23320, 23366);
                    return return_v;
                }


                int
                f_10873_23307_23429(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 23307, 23429);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_23892_23967(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 23892, 23967);
                    return return_v;
                }


                bool
                f_10873_24103_24120(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 24103, 24120);
                    return return_v;
                }


                int
                f_10873_24084_24205(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 24084, 24205);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_24326_24361(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 24326, 24361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10873_24255_24362(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(containingType, typeParameters, typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 24255, 24362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_24384_24437(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 24384, 24437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 23114, 24454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 23114, 24454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodTypeInferenceResult InferTypeArgs(Binder binder, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 24601, 25427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 25208, 25256);

                f_10873_25208_25255(this, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 25270, 25342);

                bool
                success = f_10873_25285_25341(this, binder, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 25356, 25416);

                return f_10873_25363_25415(success, f_10873_25402_25414(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 24601, 25427);

                int
                f_10873_25208_25255(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.InferTypeArgsFirstPhase(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 25208, 25255);
                    return 0;
                }


                bool
                f_10873_25285_25341(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.InferTypeArgsSecondPhase(binder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 25285, 25341);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_25402_25414(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    var return_v = this_param.GetResults();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 25402, 25414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodTypeInferenceResult
                f_10873_25363_25415(bool
                success, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                inferredTypeArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodTypeInferenceResult(success, inferredTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 25363, 25415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 24601, 25427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 24601, 25427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InferTypeArgsFirstPhase(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 25583, 26640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 25692, 25739);

                f_10873_25692_25738(f_10873_25705_25737_M(!_formalParameterTypes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 25753, 25789);

                f_10873_25753_25788(f_10873_25766_25787_M(!_arguments.IsDefault));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 26123, 26130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 26132, 26170);

                    // We expect that we have been handed a list of arguments and a list of the 
                    // formal parameter types they correspond to; all the details about named and 
                    // optional parameters have already been dealt with.

                    // SPEC: For each of the method arguments Ei:
                    for (int
        arg = 0
        ,
        length = f_10873_26141_26170(this)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 26114, 26629) || true) && (arg < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 26186, 26191)
        , arg++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 26114, 26629))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 26114, 26629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 26225, 26268);

                        BoundExpression
                        argument = _arguments[arg]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 26286, 26342);

                        TypeWithAnnotations
                        target = _formalParameterTypes[arg]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 26360, 26510);

                        ExactOrBoundsKind
                        kind = (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 26385, 26452) || ((f_10873_26385_26421(f_10873_26385_26400(this, arg)) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 26385, 26452) || f_10873_26425_26452(target.Type)) && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 26455, 26478)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 26481, 26509))) ? ExactOrBoundsKind.Exact : ExactOrBoundsKind.LowerBound
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 26530, 26614);

                        f_10873_26530_26613(this, argument, target, kind, ref useSiteDiagnostics);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 516);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 25583, 26640);

                bool
                f_10873_25705_25737_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 25705, 25737);
                    return return_v;
                }


                int
                f_10873_25692_25738(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 25692, 25738);
                    return 0;
                }


                bool
                f_10873_25766_25787_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 25766, 25787);
                    return return_v;
                }


                int
                f_10873_25753_25788(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 25753, 25788);
                    return 0;
                }


                int
                f_10873_26141_26170(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    var return_v = this_param.NumberArgumentsToProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 26141, 26170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10873_26385_26400(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.GetRefKind(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 26385, 26400);
                    return return_v;
                }


                bool
                f_10873_26385_26421(Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = refKind.IsManagedReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 26385, 26421);
                    return return_v;
                }


                bool
                f_10873_26425_26452(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 26425, 26452);
                    return return_v;
                }


                int
                f_10873_26530_26613(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.ExactOrBoundsKind
                kind, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.MakeExplicitParameterTypeInferences(argument, target, kind, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 26530, 26613);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 25583, 26640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 25583, 26640);
            }
        }

        private void MakeExplicitParameterTypeInferences(BoundExpression argument, TypeWithAnnotations target, ExactOrBoundsKind kind, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 26652, 28183);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 27412, 28172) || true) && (f_10873_27416_27429(argument) == BoundKind.UnboundLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 27412, 28172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 27490, 27563);

                    f_10873_27490_27562(this, argument, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 27412, 28172);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 27412, 28172);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 27597, 28172) || true) && (f_10873_27601_27614(argument) != BoundKind.TupleLiteral || (DynAbs.Tracing.TraceSender.Expression_False(10873, 27601, 27764) || !f_10873_27662_27764(this, argument, target, kind, ref useSiteDiagnostics)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 27597, 28172);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 27957, 28157) || true) && (f_10873_27961_27989(f_10873_27975_27988(argument)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 27957, 28157);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 28031, 28138);

                            f_10873_28031_28137(this, kind, f_10873_28060_28104(_extensions, argument), target, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 27957, 28157);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 27597, 28172);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 27412, 28172);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 26652, 28183);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_27416_27429(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 27416, 27429);
                    return return_v;
                }


                int
                f_10873_27490_27562(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExplicitParameterTypeInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 27490, 27562);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_27601_27614(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 27601, 27614);
                    return return_v;
                }


                bool
                f_10873_27662_27764(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.ExactOrBoundsKind
                kind, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MakeExplicitParameterTypeInferences((Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral)argument, target, kind, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 27662, 27764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10873_27975_27988(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 27975, 27988);
                    return return_v;
                }


                bool
                f_10873_27961_27989(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = IsReallyAType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 27961, 27989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_28060_28104(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.Extensions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.GetTypeWithAnnotations(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 28060, 28104);
                    return return_v;
                }


                int
                f_10873_28031_28137(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.ExactOrBoundsKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactOrBoundsInference(kind, source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 28031, 28137);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 26652, 28183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 26652, 28183);
            }
        }

        private bool MakeExplicitParameterTypeInferences(BoundTupleLiteral argument, TypeWithAnnotations target, ExactOrBoundsKind kind, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 28195, 30058);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 28640, 28825) || true) && (f_10873_28644_28660(target.Type) != SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 28640, 28825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 28797, 28810);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 28640, 28825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 28841, 28888);

                var
                destination = (NamedTypeSymbol)target.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 28902, 28943);

                var
                sourceArguments = f_10873_28924_28942(argument)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29054, 29244) || true) && (!f_10873_29059_29119(destination, sourceArguments.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 29054, 29244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29216, 29229);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 29054, 29244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29260, 29321);

                var
                destTypes = f_10873_29276_29320(destination)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29335, 29392);

                f_10873_29335_29391(sourceArguments.Length == destTypes.Length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29736, 29741);

                    // NOTE: we are losing tuple element names when recursing into argument expressions.
                    //       that is ok, because we are inferring type parameters used in the matching elements, 
                    //       This is not the situation where entire tuple literal is used to infer a single type param

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29727, 30019) || true) && (i < sourceArguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29771, 29774)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 29727, 30019))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 29727, 30019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29808, 29848);

                        var
                        sourceArgument = sourceArguments[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29866, 29894);

                        var
                        destType = destTypes[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 29912, 30004);

                        f_10873_29912_30003(this, sourceArgument, destType, kind, ref useSiteDiagnostics);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 293);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 30035, 30047);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 28195, 30058);

                Microsoft.CodeAnalysis.SymbolKind
                f_10873_28644_28660(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 28644, 28660);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10873_28924_28942(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 28924, 28942);
                    return return_v;
                }


                bool
                f_10873_29059_29119(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, int
                targetCardinality)
                {
                    var return_v = this_param.IsTupleTypeOfCardinality(targetCardinality);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 29059, 29119);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_29276_29320(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 29276, 29320);
                    return return_v;
                }


                int
                f_10873_29335_29391(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 29335, 29391);
                    return 0;
                }


                int
                f_10873_29912_30003(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.ExactOrBoundsKind
                kind, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.MakeExplicitParameterTypeInferences(argument, target, kind, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 29912, 30003);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 28195, 30058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 28195, 30058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool InferTypeArgsSecondPhase(Binder binder, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 30215, 33134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 32566, 32591);

                f_10873_32566_32590(this);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 32605, 33123) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 32605, 33123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 32650, 32706);

                        var
                        res = f_10873_32660_32705(this, binder, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 32724, 32772);

                        f_10873_32724_32771(res != InferenceResult.NoProgress);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 32790, 32906) || true) && (res == InferenceResult.InferenceFailed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 32790, 32906);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 32874, 32887);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 32790, 32906);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 32924, 33031) || true) && (res == InferenceResult.Success)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 32924, 33031);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 33000, 33012);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 32924, 33031);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 32605, 33123);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 32605, 33123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 32605, 33123);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 30215, 33134);

                int
                f_10873_32566_32590(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    this_param.InitializeDependencies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 32566, 32590);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.InferenceResult
                f_10873_32660_32705(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.DoSecondPhase(binder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 32660, 32705);
                    return return_v;
                }


                int
                f_10873_32724_32771(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 32724, 32771);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 30215, 33134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 30215, 33134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private InferenceResult DoSecondPhase(Binder binder, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 33146, 35627);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 33361, 33455) || true) && (f_10873_33365_33375(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 33361, 33455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 33409, 33440);

                    return InferenceResult.Success;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 33361, 33455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 33988, 34045);

                f_10873_33988_34044(this, binder, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 34613, 34633);

                InferenceResult
                res
                = default(InferenceResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 34647, 34703);

                res = f_10873_34653_34702(this, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 34717, 34814) || true) && (res != InferenceResult.NoProgress)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 34717, 34814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 34788, 34799);

                    return res;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 34717, 34814);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 35253, 35306);

                res = f_10873_35259_35305(this, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 35320, 35417) || true) && (res != InferenceResult.NoProgress)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 35320, 35417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 35391, 35402);

                    return res;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 35320, 35417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 35577, 35616);

                return InferenceResult.InferenceFailed;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 33146, 35627);

                bool
                f_10873_33365_33375(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    var return_v = this_param.AllFixed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 33365, 33375);
                    return return_v;
                }


                int
                f_10873_33988_34044(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.MakeOutputTypeInferences(binder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 33988, 34044);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.InferenceResult
                f_10873_34653_34702(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.FixNondependentParameters(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 34653, 34702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.InferenceResult
                f_10873_35259_35305(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.FixDependentParameters(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 35259, 35305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 33146, 35627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 33146, 35627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MakeOutputTypeInferences(Binder binder, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 35639, 36359);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36041, 36048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36050, 36088);
                    // SPEC: Otherwise, for all arguments Ei with corresponding parameter type Ti
                    // SPEC: where the output types contain unfixed type parameters but the input
                    // SPEC: types do not, an output type inference is made from Ei to Ti.

                    for (int
        arg = 0
        ,
        length = f_10873_36059_36088(this)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36032, 36348) || true) && (arg < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36104, 36109)
        , arg++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 36032, 36348))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 36032, 36348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36143, 36187);

                        var
                        formalType = _formalParameterTypes[arg]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36205, 36236);

                        var
                        argument = _arguments[arg]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36254, 36333);

                        f_10873_36254_36332(this, binder, argument, formalType, ref useSiteDiagnostics);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 317);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 35639, 36359);

                int
                f_10873_36059_36088(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    var return_v = this_param.NumberArgumentsToProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 36059, 36088);
                    return return_v;
                }


                int
                f_10873_36254_36332(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                formalType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.MakeOutputTypeInferences(binder, argument, formalType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 36254, 36332);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 35639, 36359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 35639, 36359);
            }
        }

        private void MakeOutputTypeInferences(Binder binder, BoundExpression argument, TypeWithAnnotations formalType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 36371, 37355);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36554, 37344) || true) && (f_10873_36558_36571(argument) == BoundKind.TupleLiteral && (DynAbs.Tracing.TraceSender.Expression_True(10873, 36558, 36630) && (object)f_10873_36609_36622(argument) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 36554, 37344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36664, 36762);

                    f_10873_36664_36761(this, binder, argument, formalType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 36554, 37344);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 36554, 37344);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 36828, 37329) || true) && (f_10873_36832_36886(this, argument, formalType.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 36832, 36944) && !f_10873_36891_36944(this, argument, formalType.Type)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 36828, 37329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 37236, 37310);

                        f_10873_37236_37309(this, binder, argument, formalType, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 36828, 37329);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 36554, 37344);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 36371, 37355);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_36558_36571(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 36558, 36571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10873_36609_36622(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 36609, 36622);
                    return return_v;
                }


                int
                f_10873_36664_36761(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                formalType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.MakeOutputTypeInferences(binder, (Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral)argument, formalType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 36664, 36761);
                    return 0;
                }


                bool
                f_10873_36832_36886(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                formalParameterType)
                {
                    var return_v = this_param.HasUnfixedParamInOutputType(argument, formalParameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 36832, 36886);
                    return return_v;
                }


                bool
                f_10873_36891_36944(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                pSource, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                pDest)
                {
                    var return_v = this_param.HasUnfixedParamInInputType(pSource, pDest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 36891, 36944);
                    return return_v;
                }


                int
                f_10873_37236_37309(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.OutputTypeInference(binder, expression, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 37236, 37309);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 36371, 37355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 36371, 37355);
            }
        }

        private void MakeOutputTypeInferences(Binder binder, BoundTupleLiteral argument, TypeWithAnnotations formalType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 37367, 38673);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 37552, 37735) || true) && (f_10873_37556_37576(formalType.Type) != SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 37552, 37735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 37713, 37720);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 37552, 37735);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 37751, 37802);

                var
                destination = (NamedTypeSymbol)formalType.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 37818, 37928);

                f_10873_37818_37927((object)f_10873_37839_37852(argument) == null, "should not need to dig into elements if tuple has natural type");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 37942, 37983);

                var
                sourceArguments = f_10873_37964_37982(argument)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38094, 38215) || true) && (!f_10873_38099_38159(destination, sourceArguments.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 38094, 38215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38193, 38200);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 38094, 38215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38231, 38292);

                var
                destTypes = f_10873_38247_38291(destination)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38306, 38363);

                f_10873_38306_38362(sourceArguments.Length == destTypes.Length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38388, 38393);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38379, 38662) || true) && (i < sourceArguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38423, 38426)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 38379, 38662))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 38379, 38662);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38460, 38500);

                        var
                        sourceArgument = sourceArguments[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38518, 38546);

                        var
                        destType = destTypes[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 38564, 38647);

                        f_10873_38564_38646(this, binder, sourceArgument, destType, ref useSiteDiagnostics);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 284);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 37367, 38673);

                Microsoft.CodeAnalysis.SymbolKind
                f_10873_37556_37576(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 37556, 37576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10873_37839_37852(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 37839, 37852);
                    return return_v;
                }


                int
                f_10873_37818_37927(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 37818, 37927);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10873_37964_37982(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 37964, 37982);
                    return return_v;
                }


                bool
                f_10873_38099_38159(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, int
                targetCardinality)
                {
                    var return_v = this_param.IsTupleTypeOfCardinality(targetCardinality);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 38099, 38159);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_38247_38291(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 38247, 38291);
                    return return_v;
                }


                int
                f_10873_38306_38362(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 38306, 38362);
                    return 0;
                }


                int
                f_10873_38564_38646(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                formalType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.MakeOutputTypeInferences(binder, argument, formalType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 38564, 38646);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 37367, 38673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 37367, 38673);
            }
        }

        private InferenceResult FixNondependentParameters(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 38685, 39229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 39121, 39218);

                return f_10873_39128_39217(this, (inferrer, index) => !inferrer.DependsOnAny(index), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 38685, 39229);

                Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.InferenceResult
                f_10873_39128_39217(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer, int, bool>
                predicate, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.FixParameters(predicate, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 39128, 39217);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 38685, 39229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 38685, 39229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private InferenceResult FixDependentParameters(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 39241, 39715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 39608, 39704);

                return f_10873_39615_39703(this, (inferrer, index) => inferrer.AnyDependsOn(index), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 39241, 39715);

                Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.InferenceResult
                f_10873_39615_39703(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer, int, bool>
                predicate, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.FixParameters(predicate, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 39615, 39703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 39241, 39715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 39241, 39715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private InferenceResult FixParameters(
                    Func<MethodTypeInferrer, int, bool> predicate,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 39727, 41210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40229, 40286);

                var
                needsFixing = new bool[_methodTypeParameters.Length]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40300, 40340);

                var
                result = InferenceResult.NoProgress
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40363, 40372);
                    for (int
        param = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40354, 40680) || true) && (param < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40412, 40419)
        , param++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 40354, 40680))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 40354, 40680);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40453, 40665) || true) && (f_10873_40457_40473(this, param) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 40457, 40492) && f_10873_40477_40492(this, param)) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 40457, 40518) && f_10873_40496_40518(predicate, this, param)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 40453, 40665);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40560, 40586);

                            needsFixing[param] = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40608, 40646);

                            result = InferenceResult.MadeProgress;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 40453, 40665);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 327);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40705, 40714);

                    for (int
        param = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40696, 41171) || true) && (param < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40754, 40761)
        , param++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 40696, 41171))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 40696, 41171);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40920, 41156) || true) && (needsFixing[param])
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 40920, 41156);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 40984, 41137) || true) && (!f_10873_40989_41023(this, param, ref useSiteDiagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 40984, 41137);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 41073, 41114);

                                result = InferenceResult.InferenceFailed;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 40984, 41137);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 40920, 41156);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 476);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 41185, 41199);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 39727, 41210);

                bool
                f_10873_40457_40473(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 40457, 40473);
                    return return_v;
                }


                bool
                f_10873_40477_40492(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.HasBound(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 40477, 40492);
                    return return_v;
                }


                bool
                f_10873_40496_40518(System.Func<Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer, int, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                arg1, int
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 40496, 40518);
                    return return_v;
                }


                bool
                f_10873_40989_41023(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                iParam, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.Fix(iParam, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 40989, 41023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 39727, 41210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 39727, 41210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool DoesInputTypeContain(BoundExpression argument, TypeSymbol formalParameterType, TypeParameterSymbol typeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 41360, 42846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 41751, 41842);

                var
                delegateOrFunctionPointerType = f_10873_41787_41841(formalParameterType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 41856, 41986) || true) && ((object)delegateOrFunctionPointerType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 41856, 41986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 41939, 41952);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 41856, 41986);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42002, 42076);

                var
                isFunctionPointer = f_10873_42026_42075(delegateOrFunctionPointerType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42090, 42369) || true) && ((isFunctionPointer && (DynAbs.Tracing.TraceSender.Expression_True(10873, 42095, 42171) && f_10873_42116_42129(argument) != BoundKind.UnconvertedAddressOfOperator)) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 42094, 42288) || (!isFunctionPointer && (DynAbs.Tracing.TraceSender.Expression_True(10873, 42194, 42287) && f_10873_42216_42229(argument) is not (BoundKind.UnboundLambda or BoundKind.MethodGroup)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 42090, 42369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42322, 42335);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 42090, 42369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42385, 42470);

                var
                parameters = f_10873_42402_42469(delegateOrFunctionPointerType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42484, 42577) || true) && (parameters.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 42484, 42577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42549, 42562);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 42484, 42577);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42593, 42806);
                    foreach (var parameter in f_10873_42619_42629_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 42593, 42806);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42663, 42791) || true) && (f_10873_42667_42718(f_10873_42667_42681(parameter), typeParameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 42663, 42791);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42760, 42772);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 42663, 42791);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 42593, 42806);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42822, 42835);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 41360, 42846);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10873_41787_41841(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateOrFunctionPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 41787, 41841);
                    return return_v;
                }


                bool
                f_10873_42026_42075(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 42026, 42075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_42116_42129(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 42116, 42129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_42216_42229(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 42216, 42229);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_42402_42469(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.DelegateOrFunctionPointerParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 42402, 42469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_42667_42681(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 42667, 42681);
                    return return_v;
                }


                bool
                f_10873_42667_42718(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                parameter)
                {
                    var return_v = type.ContainsTypeParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 42667, 42718);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_42619_42629_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 42619, 42629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 41360, 42846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 41360, 42846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasUnfixedParamInInputType(BoundExpression pSource, TypeSymbol pDest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 42858, 43358);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42974, 42984);
                    for (int
        iParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 42965, 43320) || true) && (iParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 43025, 43033)
        , iParam++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 42965, 43320))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 42965, 43320);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 43067, 43305) || true) && (f_10873_43071_43088(this, iParam))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 43067, 43305);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 43130, 43286) || true) && (f_10873_43134_43201(pSource, pDest, _methodTypeParameters[iParam]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 43130, 43286);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 43251, 43263);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 43130, 43286);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 43067, 43305);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 356);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 356);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 43334, 43347);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 42858, 43358);

                bool
                f_10873_43071_43088(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 43071, 43088);
                    return return_v;
                }


                bool
                f_10873_43134_43201(Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                formalParameterType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter)
                {
                    var return_v = DoesInputTypeContain(argument, formalParameterType, typeParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 43134, 43201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 42858, 43358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 42858, 43358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool DoesOutputTypeContain(BoundExpression argument, TypeSymbol formalParameterType,
                    TypeParameterSymbol typeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 43509, 45179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 43908, 43999);

                var
                delegateOrFunctionPointerType = f_10873_43944_43998(formalParameterType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44013, 44124) || true) && ((object)delegateOrFunctionPointerType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 44013, 44124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44096, 44109);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 44013, 44124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44140, 44214);

                var
                isFunctionPointer = f_10873_44164_44213(delegateOrFunctionPointerType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44228, 44488) || true) && ((isFunctionPointer && (DynAbs.Tracing.TraceSender.Expression_True(10873, 44233, 44309) && f_10873_44254_44267(argument) != BoundKind.UnconvertedAddressOfOperator)) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 44232, 44426) || (!isFunctionPointer && (DynAbs.Tracing.TraceSender.Expression_True(10873, 44332, 44425) && f_10873_44354_44367(argument) is not (BoundKind.UnboundLambda or BoundKind.MethodGroup)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 44228, 44488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44460, 44473);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 44228, 44488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44504, 44810);

                MethodSymbol
                method = delegateOrFunctionPointerType switch
                {
                    NamedTypeSymbol n when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44595, 44638) && DynAbs.Tracing.TraceSender.Expression_True(10873, 44595, 44638))
=> f_10873_44616_44638(n),
                    FunctionPointerTypeSymbol f when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44657, 44699) && DynAbs.Tracing.TraceSender.Expression_True(10873, 44657, 44699))
=> f_10873_44688_44699(f),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44718, 44794) && DynAbs.Tracing.TraceSender.Expression_True(10873, 44718, 44794))
=> throw f_10873_44729_44794(delegateOrFunctionPointerType)
                }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44826, 44940) || true) && ((object)method == null || (DynAbs.Tracing.TraceSender.Expression_False(10873, 44830, 44878) || f_10873_44856_44878(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 44826, 44940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44912, 44925);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 44826, 44940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 44956, 44991);

                var
                returnType = f_10873_44973_44990(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45005, 45097) || true) && ((object)returnType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 45005, 45097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45069, 45082);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 45005, 45097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45113, 45168);

                return f_10873_45120_45167(returnType, typeParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 43509, 45179);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10873_43944_43998(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateOrFunctionPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 43944, 43998);
                    return return_v;
                }


                bool
                f_10873_44164_44213(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 44164, 44213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_44254_44267(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 44254, 44267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_44354_44367(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 44354, 44367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10873_44616_44638(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 44616, 44638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10873_44688_44699(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 44688, 44699);
                    return return_v;
                }


                System.Exception
                f_10873_44729_44794(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 44729, 44794);
                    return return_v;
                }


                bool
                f_10873_44856_44878(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.HasUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 44856, 44878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_44973_44990(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 44973, 44990);
                    return return_v;
                }


                bool
                f_10873_45120_45167(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                parameter)
                {
                    var return_v = type.ContainsTypeParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 45120, 45167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 43509, 45179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 43509, 45179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasUnfixedParamInOutputType(BoundExpression argument, TypeSymbol formalParameterType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 45191, 45723);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45323, 45333);
                    for (int
        iParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45314, 45685) || true) && (iParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45374, 45382)
        , iParam++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 45314, 45685))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 45314, 45685);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45416, 45670) || true) && (f_10873_45420_45437(this, iParam))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 45416, 45670);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45479, 45651) || true) && (f_10873_45483_45566(argument, formalParameterType, _methodTypeParameters[iParam]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 45479, 45651);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45616, 45628);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 45479, 45651);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 45416, 45670);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45699, 45712);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 45191, 45723);

                bool
                f_10873_45420_45437(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 45420, 45437);
                    return return_v;
                }


                bool
                f_10873_45483_45566(Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                formalParameterType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter)
                {
                    var return_v = DoesOutputTypeContain(argument, formalParameterType, typeParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 45483, 45566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 45191, 45723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 45191, 45723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool DependsDirectlyOn(int iParam, int jParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 45874, 47191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 45953, 45986);

                f_10873_45953_45985(f_10873_45966_45984(this, iParam));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46000, 46033);

                f_10873_46000_46032(f_10873_46013_46031(this, jParam));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46536, 46568);

                f_10873_46536_46567(f_10873_46549_46566(this, iParam));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46582, 46614);

                f_10873_46582_46613(f_10873_46595_46612(this, jParam));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46639, 46647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46649, 46687);

                    for (int
        iArg = 0
        ,
        length = f_10873_46658_46687(this)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46630, 47153) || true) && (iArg < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46704, 46710)
        , iArg++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 46630, 47153))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 46630, 47153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46744, 46803);

                        var
                        formalParameterType = _formalParameterTypes[iArg].Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46821, 46853);

                        var
                        argument = _arguments[iArg]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 46871, 47138) || true) && (f_10873_46875_46957(argument, formalParameterType, _methodTypeParameters[jParam]) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 46875, 47065) && f_10873_46982_47065(argument, formalParameterType, _methodTypeParameters[iParam])))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 46871, 47138);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 47107, 47119);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 46871, 47138);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 524);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 47167, 47180);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 45874, 47191);

                bool
                f_10873_45966_45984(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 45966, 45984);
                    return return_v;
                }


                int
                f_10873_45953_45985(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 45953, 45985);
                    return 0;
                }


                bool
                f_10873_46013_46031(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 46013, 46031);
                    return return_v;
                }


                int
                f_10873_46000_46032(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 46000, 46032);
                    return 0;
                }


                bool
                f_10873_46549_46566(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 46549, 46566);
                    return return_v;
                }


                int
                f_10873_46536_46567(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 46536, 46567);
                    return 0;
                }


                bool
                f_10873_46595_46612(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 46595, 46612);
                    return return_v;
                }


                int
                f_10873_46582_46613(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 46582, 46613);
                    return 0;
                }


                int
                f_10873_46658_46687(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    var return_v = this_param.NumberArgumentsToProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 46658, 46687);
                    return return_v;
                }


                bool
                f_10873_46875_46957(Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                formalParameterType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter)
                {
                    var return_v = DoesInputTypeContain(argument, formalParameterType, typeParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 46875, 46957);
                    return return_v;
                }


                bool
                f_10873_46982_47065(Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                formalParameterType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter)
                {
                    var return_v = DoesOutputTypeContain(argument, formalParameterType, typeParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 46982, 47065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 45874, 47191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 45874, 47191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InitializeDependencies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 47203, 50316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49605, 49641);

                f_10873_49605_49640(_dependencies == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49655, 49746);

                _dependencies = new Dependency[_methodTypeParameters.Length, _methodTypeParameters.Length];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49760, 49771);

                int
                iParam
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49785, 49796);

                int
                jParam
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49810, 49853);

                f_10873_49810_49852(0 == (int)Dependency.Unknown);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49872, 49882)
   , iParam = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49867, 50265) || true) && (iParam < _methodTypeParameters.Length)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49923, 49931)
   , ++iParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 49867, 50265))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 49867, 50265);
                        try
                        {
                            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49970, 49980)
       , jParam = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 49965, 50250) || true) && (jParam < _methodTypeParameters.Length)
       ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50021, 50029)
       , ++jParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 49965, 50250))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 49965, 50250);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50071, 50231) || true) && (f_10873_50075_50108(this, iParam, jParam))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 50071, 50231);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50158, 50208);

                                    _dependencies[iParam, jParam] = Dependency.Direct;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 50071, 50231);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 286);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 286);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50281, 50305);

                f_10873_50281_50304(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 47203, 50316);

                int
                f_10873_49605_49640(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 49605, 49640);
                    return 0;
                }


                int
                f_10873_49810_49852(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 49810, 49852);
                    return 0;
                }


                bool
                f_10873_50075_50108(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                iParam, int
                jParam)
                {
                    var return_v = this_param.DependsDirectlyOn(iParam, jParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 50075, 50108);
                    return return_v;
                }


                int
                f_10873_50281_50304(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    this_param.DeduceAllDependencies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 50281, 50304);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 47203, 50316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 47203, 50316);
            }
        }

        private bool DependsOn(int iParam, int jParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 50328, 51105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50399, 50435);

                f_10873_50399_50434(_dependencies != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50708, 50775);

                f_10873_50708_50774(0 <= iParam && (DynAbs.Tracing.TraceSender.Expression_True(10873, 50721, 50773) && iParam < _methodTypeParameters.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50789, 50856);

                f_10873_50789_50855(0 <= jParam && (DynAbs.Tracing.TraceSender.Expression_True(10873, 50802, 50854) && jParam < _methodTypeParameters.Length));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50872, 51009) || true) && (_dependenciesDirty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 50872, 51009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50928, 50952);

                    f_10873_50928_50951(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 50970, 50994);

                    f_10873_50970_50993(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 50872, 51009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 51023, 51094);

                return 0 != ((_dependencies[iParam, jParam]) & Dependency.DependsMask);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 50328, 51105);

                int
                f_10873_50399_50434(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 50399, 50434);
                    return 0;
                }


                int
                f_10873_50708_50774(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 50708, 50774);
                    return 0;
                }


                int
                f_10873_50789_50855(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 50789, 50855);
                    return 0;
                }


                int
                f_10873_50928_50951(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    this_param.SetIndirectsToUnknown();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 50928, 50951);
                    return 0;
                }


                int
                f_10873_50970_50993(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    this_param.DeduceAllDependencies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 50970, 50993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 50328, 51105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 50328, 51105);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool DependsTransitivelyOn(int iParam, int jParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 51117, 52232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 51200, 51236);

                f_10873_51200_51235(_dependencies != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 51250, 51283);

                f_10873_51250_51282(f_10873_51263_51281(this, iParam));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 51297, 51330);

                f_10873_51297_51329(f_10873_51310_51328(this, jParam));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 51858, 51868);

                    // Can we find Xk such that Xi depends on Xk and Xk depends on Xj?
                    // If so, then Xi depends indirectly on Xj.  (Note that there is
                    // a minor optimization here -- the spec comment above notes that
                    // we want Xi to depend DIRECTLY on Xk, and Xk to depend directly
                    // or indirectly on Xj. But if we already know that Xi depends
                    // directly OR indirectly on Xk and Xk depends on Xj, then that's
                    // good enough.)

                    for (int
        kParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 51849, 52194) || true) && (kParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 51909, 51917)
        , ++kParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 51849, 52194))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 51849, 52194);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 51951, 52179) || true) && (((_dependencies[iParam, kParam]) & Dependency.DependsMask) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10873, 51955, 52106) && ((_dependencies[kParam, jParam]) & Dependency.DependsMask) != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 51951, 52179);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52148, 52160);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 51951, 52179);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52208, 52221);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 51117, 52232);

                int
                f_10873_51200_51235(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 51200, 51235);
                    return 0;
                }


                bool
                f_10873_51263_51281(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 51263, 51281);
                    return return_v;
                }


                int
                f_10873_51250_51282(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 51250, 51282);
                    return 0;
                }


                bool
                f_10873_51310_51328(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 51310, 51328);
                    return return_v;
                }


                int
                f_10873_51297_51329(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 51297, 51329);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 51117, 52232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 51117, 52232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DeduceAllDependencies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 52244, 52539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52305, 52323);

                bool
                madeProgress
                = default(bool);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 52337, 52445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52372, 52408);

                            madeProgress = f_10873_52387_52407(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 52337, 52445);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52337, 52445) || true) && (madeProgress)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 52337, 52445);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 52337, 52445);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52459, 52487);

                f_10873_52459_52486(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52501, 52528);

                _dependenciesDirty = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 52244, 52539);

                bool
                f_10873_52387_52407(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    var return_v = this_param.DeduceDependencies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 52387, 52407);
                    return return_v;
                }


                int
                f_10873_52459_52486(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    this_param.SetUnknownsToNotDependent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 52459, 52486);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 52244, 52539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 52244, 52539);
            }
        }

        private bool DeduceDependencies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 52551, 53346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52609, 52645);

                f_10873_52609_52644(_dependencies != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52659, 52685);

                bool
                madeProgress = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52708, 52718);
                    for (int
        iParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52699, 53301) || true) && (iParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52759, 52767)
        , ++iParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 52699, 53301))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 52699, 53301);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52810, 52820);
                            for (int
            jParam = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52801, 53286) || true) && (jParam < _methodTypeParameters.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52861, 52869)
            , ++jParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 52801, 53286))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 52801, 53286);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 52911, 53267) || true) && (_dependencies[iParam, jParam] == Dependency.Unknown)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 52911, 53267);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53016, 53244) || true) && (f_10873_53020_53057(this, iParam, jParam))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 53016, 53244);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53115, 53167);

                                        _dependencies[iParam, jParam] = Dependency.Indirect;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53197, 53217);

                                        madeProgress = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 53016, 53244);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 52911, 53267);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 486);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 486);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53315, 53335);

                return madeProgress;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 52551, 53346);

                int
                f_10873_52609_52644(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 52609, 52644);
                    return 0;
                }


                bool
                f_10873_53020_53057(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                iParam, int
                jParam)
                {
                    var return_v = this_param.DependsTransitivelyOn(iParam, jParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 53020, 53057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 52551, 53346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 52551, 53346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetUnknownsToNotDependent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 53358, 53914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53423, 53459);

                f_10873_53423_53458(_dependencies != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53482, 53492);
                    for (int
        iParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53473, 53903) || true) && (iParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53533, 53541)
        , ++iParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 53473, 53903))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 53473, 53903);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53584, 53594);
                            for (int
            jParam = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53575, 53888) || true) && (jParam < _methodTypeParameters.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53635, 53643)
            , ++jParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 53575, 53888))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 53575, 53888);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53685, 53869) || true) && (_dependencies[iParam, jParam] == Dependency.Unknown)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 53685, 53869);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53790, 53846);

                                    _dependencies[iParam, jParam] = Dependency.NotDependent;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 53685, 53869);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 314);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 314);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 431);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 53358, 53914);

                int
                f_10873_53423_53458(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 53423, 53458);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 53358, 53914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 53358, 53914);
            }
        }

        private void SetIndirectsToUnknown()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 53926, 54474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 53987, 54023);

                f_10873_53987_54022(_dependencies != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54046, 54056);
                    for (int
        iParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54037, 54463) || true) && (iParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54097, 54105)
        , ++iParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 54037, 54463))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 54037, 54463);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54148, 54158);
                            for (int
            jParam = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54139, 54448) || true) && (jParam < _methodTypeParameters.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54199, 54207)
            , ++jParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 54139, 54448))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 54139, 54448);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54249, 54429) || true) && (_dependencies[iParam, jParam] == Dependency.Indirect)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 54249, 54429);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54355, 54406);

                                    _dependencies[iParam, jParam] = Dependency.Unknown;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 54249, 54429);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 310);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 310);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 427);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 53926, 54474);

                int
                f_10873_53987_54022(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 53987, 54022);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 53926, 54474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 53926, 54474);
            }
        }

        private void UpdateDependenciesAfterFix(int iParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 54669, 55185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54745, 54778);

                f_10873_54745_54777(f_10873_54758_54776(this, iParam));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54792, 54873) || true) && (_dependencies == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 54792, 54873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54851, 54858);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 54792, 54873);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54896, 54906);
                    for (int
        jParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54887, 55134) || true) && (jParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54947, 54955)
        , ++jParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 54887, 55134))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 54887, 55134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 54989, 55045);

                        _dependencies[iParam, jParam] = Dependency.NotDependent;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55063, 55119);

                        _dependencies[jParam, iParam] = Dependency.NotDependent;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55148, 55174);

                _dependenciesDirty = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 54669, 55185);

                bool
                f_10873_54758_54776(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 54758, 54776);
                    return return_v;
                }


                int
                f_10873_54745_54777(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 54745, 54777);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 54669, 55185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 54669, 55185);
            }
        }

        private bool DependsOnAny(int iParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 55197, 55563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55259, 55292);

                f_10873_55259_55291(f_10873_55272_55290(this, iParam));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55315, 55325);
                    for (int
        jParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55306, 55525) || true) && (jParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55366, 55374)
        , ++jParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 55306, 55525))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 55306, 55525);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55408, 55510) || true) && (f_10873_55412_55437(this, iParam, jParam))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 55408, 55510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55479, 55491);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 55408, 55510);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55539, 55552);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 55197, 55563);

                bool
                f_10873_55272_55290(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 55272, 55290);
                    return return_v;
                }


                int
                f_10873_55259_55291(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 55259, 55291);
                    return 0;
                }


                bool
                f_10873_55412_55437(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                iParam, int
                jParam)
                {
                    var return_v = this_param.DependsOn(iParam, jParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 55412, 55437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 55197, 55563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 55197, 55563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AnyDependsOn(int iParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 55575, 55941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55637, 55670);

                f_10873_55637_55669(f_10873_55650_55668(this, iParam));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55693, 55703);
                    for (int
        jParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55684, 55903) || true) && (jParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55744, 55752)
        , ++jParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 55684, 55903))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 55684, 55903);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55786, 55888) || true) && (f_10873_55790_55815(this, jParam, iParam))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 55786, 55888);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55857, 55869);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 55786, 55888);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 55917, 55930);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 55575, 55941);

                bool
                f_10873_55650_55668(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                index)
                {
                    var return_v = this_param.ValidIndex(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 55650, 55668);
                    return return_v;
                }


                int
                f_10873_55637_55669(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 55637, 55669);
                    return 0;
                }


                bool
                f_10873_55790_55815(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                iParam, int
                jParam)
                {
                    var return_v = this_param.DependsOn(iParam, jParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 55790, 55815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 55575, 55941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 55575, 55941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void OutputTypeInference(Binder binder, BoundExpression expression, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 56194, 57967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 56370, 56403);

                f_10873_56370_56402(expression != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 56417, 56446);

                f_10873_56417_56445(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 56839, 56970) || true) && (f_10873_56843_56914(this, expression, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 56839, 56970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 56948, 56955);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 56839, 56970);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 57380, 57527) || true) && (f_10873_57384_57471(this, binder, expression, target.Type, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 57380, 57527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 57505, 57512);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 57380, 57527);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 57684, 57748);

                var
                sourceType = f_10873_57701_57747(_extensions, expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 57762, 57897) || true) && (sourceType.HasType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 57762, 57897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 57818, 57882);

                    f_10873_57818_57881(this, sourceType, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 57762, 57897);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 56194, 57967);

                int
                f_10873_56370_56402(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 56370, 56402);
                    return 0;
                }


                int
                f_10873_56417_56445(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 56417, 56445);
                    return 0;
                }


                bool
                f_10873_56843_56914(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.InferredReturnTypeInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 56843, 56914);
                    return return_v;
                }


                bool
                f_10873_57384_57471(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MethodGroupReturnTypeInference(binder, source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 57384, 57471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_57701_57747(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.Extensions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.GetTypeWithAnnotations(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 57701, 57747);
                    return return_v;
                }


                int
                f_10873_57818_57881(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 57818, 57881);
                    return 0;
                }

                // SPEC: * Otherwise, no inferences are made.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 56194, 57967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 56194, 57967);
            }
        }

        private bool InferredReturnTypeInference(BoundExpression source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 57979, 59581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 58144, 58173);

                f_10873_58144_58172(source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 58187, 58216);

                f_10873_58187_58215(target.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 58477, 58526);

                var
                delegateType = f_10873_58496_58525(target.Type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 58540, 58634) || true) && ((object)delegateType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 58540, 58634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 58606, 58619);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 58540, 58634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 58792, 58999);

                f_10873_58792_58998((object)f_10873_58813_58846(delegateType) != null && (DynAbs.Tracing.TraceSender.Expression_True(10873, 58805, 58908) && f_10873_58858_58908_M(!f_10873_58859_58892(delegateType).HasUseSiteError)), "This method should only be called for valid delegate types.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59013, 59090);

                var
                returnType = f_10873_59030_59089(f_10873_59030_59063(delegateType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59104, 59242) || true) && (f_10873_59108_59127_M(!returnType.HasType) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 59108, 59180) || returnType.SpecialType == SpecialType.System_Void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 59104, 59242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59214, 59227);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 59104, 59242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59258, 59345);

                var
                inferredReturnType = f_10873_59283_59344(this, source, delegateType, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59359, 59452) || true) && (f_10873_59363_59390_M(!inferredReturnType.HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 59359, 59452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59424, 59437);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 59359, 59452);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59468, 59544);

                f_10873_59468_59543(this, inferredReturnType, returnType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59558, 59570);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 57979, 59581);

                int
                f_10873_58144_58172(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 58144, 58172);
                    return 0;
                }


                int
                f_10873_58187_58215(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 58187, 58215);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10873_58496_58525(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 58496, 58525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10873_58813_58846(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 58813, 58846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10873_58859_58892(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 58859, 58892);
                    return return_v;
                }


                bool
                f_10873_58858_58908_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 58858, 58908);
                    return return_v;
                }


                int
                f_10873_58792_58998(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 58792, 58998);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10873_59030_59063(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 59030, 59063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_59030_59089(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 59030, 59089);
                    return return_v;
                }


                bool
                f_10873_59108_59127_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 59108, 59127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_59283_59344(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.InferReturnType(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 59283, 59344);
                    return return_v;
                }


                bool
                f_10873_59363_59390_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 59363, 59390);
                    return return_v;
                }


                int
                f_10873_59468_59543(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 59468, 59543);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 57979, 59581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 57979, 59581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MethodGroupReturnTypeInference(Binder binder, BoundExpression source, TypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 59593, 62997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59767, 59796);

                f_10873_59767_59795(source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 59810, 59847);

                f_10873_59810_59846((object)target != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 60259, 60409) || true) && (f_10873_60263_60274(source) is not (BoundKind.MethodGroup or BoundKind.UnconvertedAddressOfOperator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 60259, 60409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 60381, 60394);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 60259, 60409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 60425, 60503);

                var
                delegateOrFunctionPointerType = f_10873_60461_60502(target)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 60517, 60628) || true) && ((object)delegateOrFunctionPointerType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 60517, 60628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 60600, 60613);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 60517, 60628);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 60646, 60820) || true) && (f_10873_60650_60699(delegateOrFunctionPointerType) != (f_10873_60704_60715(source) == BoundKind.UnconvertedAddressOfOperator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 60646, 60820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 60792, 60805);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 60646, 60820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 61032, 61378);

                var (method, isFunctionPointerResolution) = delegateOrFunctionPointerType switch
                {
                    NamedTypeSymbol n when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 61145, 61197) && DynAbs.Tracing.TraceSender.Expression_True(10873, 61145, 61197))
    => (f_10873_61167_61189(n), false),
                    FunctionPointerTypeSymbol f when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 61216, 61266) && DynAbs.Tracing.TraceSender.Expression_True(10873, 61216, 61266))
    => (f_10873_61248_61259(f), true),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 61285, 61361) && DynAbs.Tracing.TraceSender.Expression_True(10873, 61285, 61361))
    => throw f_10873_61296_61361(delegateOrFunctionPointerType),
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 61392, 61551);

                f_10873_61392_61550(method is { HasUseSiteError: false }, "This method should only be called for valid delegate or function pointer types");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 61567, 61639);

                TypeWithAnnotations
                sourceReturnType = f_10873_61606_61638(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 61653, 61803) || true) && (f_10873_61657_61682_M(!sourceReturnType.HasType) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 61657, 61741) || sourceReturnType.SpecialType == SpecialType.System_Void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 61653, 61803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 61775, 61788);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 61653, 61803);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 61923, 62048);

                var
                fixedParameters = f_10873_61945_62047(f_10873_61945_62009(this, delegateOrFunctionPointerType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 62062, 62153) || true) && (fixedParameters.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 62062, 62153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 62125, 62138);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 62062, 62153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 62169, 62412);

                CallingConventionInfo
                callingConventionInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 62215, 62242) || ((isFunctionPointerResolution
                && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 62262, 62384)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 62404, 62411))) ? f_10873_62262_62384(f_10873_62288_62312(method), f_10873_62314_62383(((FunctionPointerMethodSymbol)method))) : default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 62426, 62547);

                BoundMethodGroup
                originalMethodGroup = source as BoundMethodGroup ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundMethodGroup?>(10873, 62465, 62546) ?? f_10873_62495_62546(((BoundUnconvertedAddressOfOperator)source)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 62563, 62743);

                var
                returnType = f_10873_62580_62742(this, binder, originalMethodGroup, fixedParameters, f_10873_62648_62662(method), isFunctionPointerResolution, ref useSiteDiagnostics, callingConventionInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 62757, 62870) || true) && (returnType.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10873, 62761, 62808) || returnType.IsVoidType()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 62757, 62870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 62842, 62855);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 62757, 62870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 62886, 62960);

                f_10873_62886_62959(this, returnType, sourceReturnType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 62974, 62986);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 59593, 62997);

                int
                f_10873_59767_59795(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 59767, 59795);
                    return 0;
                }


                int
                f_10873_59810_59846(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 59810, 59846);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_60263_60274(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 60263, 60274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10873_60461_60502(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateOrFunctionPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 60461, 60502);
                    return return_v;
                }


                bool
                f_10873_60650_60699(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 60650, 60699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_60704_60715(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 60704, 60715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10873_61167_61189(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 61167, 61189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10873_61248_61259(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 61248, 61259);
                    return return_v;
                }


                System.Exception
                f_10873_61296_61361(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 61296, 61361);
                    return return_v;
                }


                int
                f_10873_61392_61550(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 61392, 61550);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_61606_61638(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 61606, 61638);
                    return return_v;
                }


                bool
                f_10873_61657_61682_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 61657, 61682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_61945_62009(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateOrFunctionPointerType)
                {
                    var return_v = this_param.GetFixedDelegateOrFunctionPointer(delegateOrFunctionPointerType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 61945, 62009);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_61945_62047(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.DelegateOrFunctionPointerParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 61945, 62047);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10873_62288_62312(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 62288, 62312);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10873_62314_62383(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCallingConventionModifiers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 62314, 62383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                f_10873_62262_62384(Microsoft.Cci.CallingConvention
                callKind, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                unmanagedCallingConventionTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CallingConventionInfo(callKind, unmanagedCallingConventionTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 62262, 62384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10873_62495_62546(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 62495, 62546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10873_62648_62662(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 62648, 62662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_62580_62742(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                source, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                delegateParameters, Microsoft.CodeAnalysis.RefKind
                delegateRefKind, bool
                isFunctionPointerResolution, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo)
                {
                    var return_v = this_param.MethodGroupReturnType(binder, source, delegateParameters, delegateRefKind, isFunctionPointerResolution, ref useSiteDiagnostics, callingConventionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 62580, 62742);
                    return return_v;
                }


                int
                f_10873_62886_62959(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 62886, 62959);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 59593, 62997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 59593, 62997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations MethodGroupReturnType(
                    Binder binder, BoundMethodGroup source,
                    ImmutableArray<ParameterSymbol> delegateParameters,
                    RefKind delegateRefKind,
                    bool isFunctionPointerResolution,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    in CallingConventionInfo callingConventionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 63009, 64664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 63409, 63465);

                var
                analyzedArguments = f_10873_63433_63464()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 63479, 63603);

                f_10873_63479_63602(source.Syntax, analyzedArguments, delegateParameters, f_10873_63583_63601(binder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 63619, 64087);

                var
                resolution = f_10873_63636_64086(binder, source, analyzedArguments, useSiteDiagnostics: ref useSiteDiagnostics, isMethodGroupConversion: true, returnRefKind: delegateRefKind, returnType: null, isFunctionPointerResolution: isFunctionPointerResolution, callingConventionInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 64103, 64138);

                TypeWithAnnotations
                type = default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 64256, 64554) || true) && (f_10873_64260_64279_M(!resolution.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 64256, 64554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 64313, 64362);

                    var
                    result = resolution.OverloadResolutionResult
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 64380, 64539) || true) && (f_10873_64384_64400(result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 64380, 64539);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 64442, 64520);

                        type = f_10873_64449_64519(_extensions, source, result.BestResult.Member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 64380, 64539);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 64256, 64554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 64570, 64595);

                f_10873_64570_64594(
                            analyzedArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 64609, 64627);

                resolution.Free();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 64641, 64653);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 63009, 64664);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10873_63433_63464()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 63433, 63464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10873_63583_63601(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 63583, 63601);
                    return return_v;
                }


                int
                f_10873_63479_63602(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                delegateParameters, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    Conversions.GetDelegateOrFunctionPointerArguments(syntax, analyzedArguments, delegateParameters, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 63479, 63602);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10873_63636_64086(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                isMethodGroupConversion, Microsoft.CodeAnalysis.RefKind
                returnRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, bool
                isFunctionPointerResolution, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo)
                {
                    var return_v = this_param.ResolveMethodGroup(node, analyzedArguments, useSiteDiagnostics: ref useSiteDiagnostics, isMethodGroupConversion: isMethodGroupConversion, returnRefKind: returnRefKind, returnType: returnType, isFunctionPointerResolution: isFunctionPointerResolution, callingConventionInfo: callingConventionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 63636, 64086);
                    return return_v;
                }


                bool
                f_10873_64260_64279_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 64260, 64279);
                    return return_v;
                }


                bool
                f_10873_64384_64400(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Succeeded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 64384, 64400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_64449_64519(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.Extensions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                group, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.GetMethodGroupResultType(group, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 64449, 64519);
                    return return_v;
                }


                int
                f_10873_64570_64594(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 64570, 64594);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 63009, 64664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 63009, 64664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExplicitParameterTypeInference(BoundExpression source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 64837, 67120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 65005, 65034);

                f_10873_65005_65033(source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 65048, 65077);

                f_10873_65048_65076(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 65563, 65661) || true) && (f_10873_65567_65578(source) != BoundKind.UnboundLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 65563, 65661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 65639, 65646);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 65563, 65661);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 65677, 65733);

                UnboundLambda
                anonymousFunction = (UnboundLambda)source
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 65749, 65859) || true) && (f_10873_65753_65803_M(!anonymousFunction.HasExplicitlyTypedParameterList))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 65749, 65859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 65837, 65844);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 65749, 65859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 65875, 65924);

                var
                delegateType = f_10873_65894_65923(target.Type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 65938, 66026) || true) && ((object)delegateType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 65938, 66026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66004, 66011);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 65938, 66026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66042, 66101);

                var
                delegateParameters = f_10873_66067_66100(delegateType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66115, 66203) || true) && (delegateParameters.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 66115, 66203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66181, 66188);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 66115, 66203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66219, 66256);

                int
                size = delegateParameters.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66270, 66402) || true) && (f_10873_66274_66306(anonymousFunction) < size)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 66270, 66402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66347, 66387);

                    size = f_10873_66354_66386(anonymousFunction);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 66270, 66402);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66907, 66912);

                    // SPEC ISSUE: What should we do if there is an out/ref mismatch between an
                    // SPEC ISSUE: anonymous function parameter and a delegate parameter?
                    // SPEC ISSUE: The result will not be applicable no matter what, but should
                    // SPEC ISSUE: we make any inferences?  This is going to be an error
                    // SPEC ISSUE: ultimately, but it might make a difference for intellisense or
                    // SPEC ISSUE: other analysis.

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66898, 67109) || true) && (i < size)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66924, 66927)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 66898, 67109))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 66898, 67109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 66961, 67094);

                        f_10873_66961_67093(this, f_10873_66976_67025(anonymousFunction, i), f_10873_67027_67068(delegateParameters[i]), ref useSiteDiagnostics);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 212);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 64837, 67120);

                int
                f_10873_65005_65033(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 65005, 65033);
                    return 0;
                }


                int
                f_10873_65048_65076(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 65048, 65076);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_65567_65578(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 65567, 65578);
                    return return_v;
                }


                bool
                f_10873_65753_65803_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 65753, 65803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10873_65894_65923(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 65894, 65923);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_66067_66100(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.DelegateParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 66067, 66100);
                    return return_v;
                }


                int
                f_10873_66274_66306(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 66274, 66306);
                    return return_v;
                }


                int
                f_10873_66354_66386(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 66354, 66386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_66976_67025(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterTypeWithAnnotations(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 66976, 67025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_67027_67068(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 67027, 67068);
                    return return_v;
                }


                int
                f_10873_66961_67093(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 66961, 67093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 64837, 67120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 64837, 67120);
            }
        }

        private void ExactInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 67275, 69100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 67431, 67460);

                f_10873_67431_67459(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 67474, 67503);

                f_10873_67474_67502(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 67757, 67879) || true) && (f_10873_67761_67823(this, source, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 67757, 67879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 67857, 67864);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 67757, 67879);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 68024, 68127) || true) && (f_10873_68028_68071(this, source, target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 68024, 68127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 68105, 68112);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 68024, 68127);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 68327, 68446) || true) && (f_10873_68331_68390(this, source, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 68327, 68446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 68424, 68431);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 68327, 68446);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 68695, 68820) || true) && (f_10873_68699_68764(this, source, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 68695, 68820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 68798, 68805);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 68695, 68820);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 68908, 69029) || true) && (f_10873_68912_68973(this, source, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 68908, 69029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 69007, 69014);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 68908, 69029);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 67275, 69100);

                int
                f_10873_67431_67459(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 67431, 67459);
                    return 0;
                }


                int
                f_10873_67474_67502(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 67474, 67502);
                    return 0;
                }


                bool
                f_10873_67761_67823(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExactNullableInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 67761, 67823);
                    return return_v;
                }


                bool
                f_10873_68028_68071(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target)
                {
                    var return_v = this_param.ExactTypeParameterInference(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 68028, 68071);
                    return return_v;
                }


                bool
                f_10873_68331_68390(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExactArrayInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 68331, 68390);
                    return return_v;
                }


                bool
                f_10873_68699_68764(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExactConstructedInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 68699, 68764);
                    return return_v;
                }


                bool
                f_10873_68912_68973(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExactPointerInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 68912, 68973);
                    return return_v;
                }


                // SPEC: * Otherwise no inferences are made.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 67275, 69100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 67275, 69100);
            }
        }

        private bool ExactTypeParameterInference(TypeWithAnnotations source, TypeWithAnnotations target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 69112, 69634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 69233, 69262);

                f_10873_69233_69261(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 69276, 69305);

                f_10873_69276_69304(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 69444, 69596) || true) && (f_10873_69448_69478(this, target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 69444, 69596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 69512, 69551);

                    f_10873_69512_69550(this, source, _exactBounds, target);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 69569, 69581);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 69444, 69596);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 69610, 69623);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 69112, 69634);

                int
                f_10873_69233_69261(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 69233, 69261);
                    return 0;
                }


                int
                f_10873_69276_69304(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 69276, 69304);
                    return 0;
                }


                bool
                f_10873_69448_69478(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.IsUnfixedTypeParameter(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 69448, 69478);
                    return return_v;
                }


                int
                f_10873_69512_69550(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                addedBound, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>[]
                collectedBounds, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                methodTypeParameterWithAnnotations)
                {
                    this_param.AddBound(addedBound, collectedBounds, methodTypeParameterWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 69512, 69550);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 69112, 69634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 69112, 69634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ExactArrayInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 69646, 70609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 69807, 69836);

                f_10873_69807_69835(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 69850, 69879);

                f_10873_69850_69878(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 70079, 70193) || true) && (!f_10873_70084_70105(source.Type) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 70083, 70131) || !f_10873_70110_70131(target.Type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 70079, 70193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 70165, 70178);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 70079, 70193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 70209, 70256);

                var
                arraySource = (ArrayTypeSymbol)source.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 70270, 70317);

                var
                arrayTarget = (ArrayTypeSymbol)target.Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 70331, 70437) || true) && (!f_10873_70336_70375(arraySource, arrayTarget))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 70331, 70437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 70409, 70422);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 70331, 70437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 70453, 70572);

                f_10873_70453_70571(this, f_10873_70468_70506(arraySource), f_10873_70508_70546(arrayTarget), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 70586, 70598);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 69646, 70609);

                int
                f_10873_69807_69835(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 69807, 69835);
                    return 0;
                }


                int
                f_10873_69850_69878(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 69850, 69878);
                    return 0;
                }


                bool
                f_10873_70084_70105(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 70084, 70105);
                    return return_v;
                }


                bool
                f_10873_70110_70131(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 70110, 70131);
                    return return_v;
                }


                bool
                f_10873_70336_70375(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                other)
                {
                    var return_v = this_param.HasSameShapeAs(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 70336, 70375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_70468_70506(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 70468, 70506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_70508_70546(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 70508, 70546);
                    return return_v;
                }


                int
                f_10873_70453_70571(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 70453, 70571);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 69646, 70609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 69646, 70609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private enum ExactOrBoundsKind
        {
            Exact,
            LowerBound,
            UpperBound,
        }

        private void ExactOrBoundsInference(ExactOrBoundsKind kind, TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 70755, 71473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 70943, 71462);

                switch (kind)
                {

                    case ExactOrBoundsKind.Exact:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 70943, 71462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 71040, 71095);

                        f_10873_71040_71094(this, source, target, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10873, 71117, 71123);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 70943, 71462);

                    case ExactOrBoundsKind.LowerBound:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 70943, 71462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 71197, 71257);

                        f_10873_71197_71256(this, source, target, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10873, 71279, 71285);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 70943, 71462);

                    case ExactOrBoundsKind.UpperBound:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 70943, 71462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 71359, 71419);

                        f_10873_71359_71418(this, source, target, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10873, 71441, 71447);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 70943, 71462);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 70755, 71473);

                int
                f_10873_71040_71094(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 71040, 71094);
                    return 0;
                }


                int
                f_10873_71197_71256(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 71197, 71256);
                    return 0;
                }


                int
                f_10873_71359_71418(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.UpperBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 71359, 71418);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 70755, 71473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 70755, 71473);
            }
        }

        private bool ExactOrBoundsNullableInference(ExactOrBoundsKind kind, TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 71485, 72610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 71681, 71710);

                f_10873_71681_71709(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 71724, 71753);

                f_10873_71724_71752(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 71769, 72123) || true) && (source.IsNullableType() && (DynAbs.Tracing.TraceSender.Expression_True(10873, 71773, 71823) && target.IsNullableType()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 71769, 72123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 71857, 72078);

                    f_10873_71857_72077(this, kind, f_10873_71886_71965(((NamedTypeSymbol)source.Type))[0], f_10873_71970_72049(((NamedTypeSymbol)target.Type))[0], ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 72096, 72108);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 71769, 72123);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 72139, 72397) || true) && (f_10873_72143_72165(source) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 72143, 72191) && f_10873_72169_72191(target)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 72139, 72397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 72225, 72352);

                    f_10873_72225_72351(this, kind, source.AsNotNullableReferenceType(), target.AsNotNullableReferenceType(), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 72370, 72382);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 72139, 72397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 72413, 72426);

                return false;

                static bool isNullableOnly(TypeWithAnnotations type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 72558, 72598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 72561, 72598);
                        return f_10873_72561_72598(type.NullableAnnotation); DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 72558, 72598);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 72558, 72598);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 72558, 72598);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 71485, 72610);

                int
                f_10873_71681_71709(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 71681, 71709);
                    return 0;
                }


                int
                f_10873_71724_71752(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 71724, 71752);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_71886_71965(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 71886, 71965);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_71970_72049(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 71970, 72049);
                    return return_v;
                }


                int
                f_10873_71857_72077(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.ExactOrBoundsKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactOrBoundsInference(kind, source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 71857, 72077);
                    return 0;
                }


                bool
                f_10873_72143_72165(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = isNullableOnly(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 72143, 72165);
                    return return_v;
                }


                bool
                f_10873_72169_72191(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = isNullableOnly(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 72169, 72191);
                    return return_v;
                }


                int
                f_10873_72225_72351(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.ExactOrBoundsKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactOrBoundsInference(kind, source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 72225, 72351);
                    return 0;
                }


                static bool
                f_10873_72561_72598(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 72561, 72598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 71485, 72610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 71485, 72610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ExactNullableInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 72622, 72900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 72786, 72889);

                return f_10873_72793_72888(this, ExactOrBoundsKind.Exact, source, target, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 72622, 72900);

                bool
                f_10873_72793_72888(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.ExactOrBoundsKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExactOrBoundsNullableInference(kind, source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 72793, 72888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 72622, 72900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 72622, 72900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LowerBoundTupleInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 72912, 74131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 73078, 73107);

                f_10873_73078_73106(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 73121, 73150);

                f_10873_73121_73149(target.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 73486, 73534);

                ImmutableArray<TypeWithAnnotations>
                sourceTypes
                = default(ImmutableArray<TypeWithAnnotations>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 73548, 73596);

                ImmutableArray<TypeWithAnnotations>
                targetTypes
                = default(ImmutableArray<TypeWithAnnotations>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 73612, 73908) || true) && (!source.Type.TryGetElementTypesWithAnnotationsIfTupleType(out sourceTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 73616, 73785) || !target.Type.TryGetElementTypesWithAnnotationsIfTupleType(out targetTypes)) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 73616, 73846) || sourceTypes.Length != targetTypes.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 73612, 73908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 73880, 73893);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 73612, 73908);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 73933, 73938);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 73924, 74092) || true) && (i < sourceTypes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 73964, 73967)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 73924, 74092))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 73924, 74092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74001, 74077);

                        f_10873_74001_74076(this, sourceTypes[i], targetTypes[i], ref useSiteDiagnostics);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74108, 74120);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 72912, 74131);

                int
                f_10873_73078_73106(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 73078, 73106);
                    return 0;
                }


                int
                f_10873_73121_73149(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 73121, 73149);
                    return 0;
                }


                int
                f_10873_74001_74076(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 74001, 74076);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 72912, 74131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 72912, 74131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ExactConstructedInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 74143, 75290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74310, 74339);

                f_10873_74310_74338(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74353, 74382);

                f_10873_74353_74381(target.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74631, 74680);

                var
                namedSource = source.Type as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74694, 74787) || true) && ((object)namedSource == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 74694, 74787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74759, 74772);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 74694, 74787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74803, 74852);

                var
                namedTarget = target.Type as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74866, 74959) || true) && ((object)namedTarget == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 74866, 74959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74931, 74944);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 74866, 74959);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 74975, 75160) || true) && (!f_10873_74980_75098(f_10873_74998_75028(namedSource), f_10873_75030_75060(namedTarget), TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 74975, 75160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 75132, 75145);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 74975, 75160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 75176, 75253);

                f_10873_75176_75252(this, namedSource, namedTarget, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 75267, 75279);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 74143, 75290);

                int
                f_10873_74310_74338(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 74310, 74338);
                    return 0;
                }


                int
                f_10873_74353_74381(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 74353, 74381);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_74998_75028(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 74998, 75028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_75030_75060(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 75030, 75060);
                    return return_v;
                }


                bool
                f_10873_74980_75098(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 74980, 75098);
                    return return_v;
                }


                int
                f_10873_75176_75252(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactTypeArgumentInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 75176, 75252);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 74143, 75290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 74143, 75290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ExactPointerInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 75302, 76885);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 75465, 76845) || true) && (source.TypeKind == TypeKind.Pointer && (DynAbs.Tracing.TraceSender.Expression_True(10873, 75469, 75543) && target.TypeKind == TypeKind.Pointer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 75465, 76845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 75577, 75742);

                    f_10873_75577_75741(this, f_10873_75592_75653(((PointerTypeSymbol)source.Type)), f_10873_75655_75716(((PointerTypeSymbol)target.Type)), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 75760, 75772);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 75465, 76845);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 75465, 76845);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 75806, 76845) || true) && (source.Type is FunctionPointerTypeSymbol { Signature: { ParameterCount: int sourceParameterCount } sourceSignature } && (DynAbs.Tracing.TraceSender.Expression_True(10873, 75810, 76068) && target.Type is FunctionPointerTypeSymbol { Signature: { ParameterCount: int targetParameterCount } targetSignature }) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 75810, 76138) && sourceParameterCount == targetParameterCount))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 75806, 76845);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 76172, 76390) || true) && (!f_10873_76177_76239(sourceSignature, targetSignature) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 76176, 76316) || !f_10873_76244_76316(sourceSignature, targetSignature)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 76172, 76390);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 76358, 76371);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 76172, 76390);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 76419, 76424);

                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 76410, 76655) || true) && (i < sourceParameterCount)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 76452, 76455)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 76410, 76655))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 76410, 76655);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 76497, 76636);

                                f_10873_76497_76635(this, f_10873_76512_76557(sourceSignature)[i], f_10873_76562_76607(targetSignature)[i], ref useSiteDiagnostics);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 246);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 246);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 76675, 76800);

                        f_10873_76675_76799(this, f_10873_76690_76731(sourceSignature), f_10873_76733_76774(targetSignature), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 76818, 76830);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 75806, 76845);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 75465, 76845);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 76861, 76874);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 75302, 76885);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_75592_75653(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 75592, 75653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_75655_75716(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 75655, 75716);
                    return return_v;
                }


                int
                f_10873_75577_75741(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 75577, 75741);
                    return 0;
                }


                bool
                f_10873_76177_76239(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                sourceSignature, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                targetSignature)
                {
                    var return_v = FunctionPointerRefKindsEqual(sourceSignature, targetSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 76177, 76239);
                    return return_v;
                }


                bool
                f_10873_76244_76316(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                sourceSignature, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                targetSignature)
                {
                    var return_v = FunctionPointerCallingConventionsEqual(sourceSignature, targetSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 76244, 76316);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_76512_76557(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 76512, 76557);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_76562_76607(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 76562, 76607);
                    return return_v;
                }


                int
                f_10873_76497_76635(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 76497, 76635);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_76690_76731(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 76690, 76731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_76733_76774(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 76733, 76774);
                    return return_v;
                }


                int
                f_10873_76675_76799(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 76675, 76799);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 75302, 76885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 75302, 76885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool FunctionPointerCallingConventionsEqual(FunctionPointerMethodSymbol sourceSignature, FunctionPointerMethodSymbol targetSignature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 76897, 77560);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 77070, 77206) || true) && (f_10873_77074_77107(sourceSignature) != f_10873_77111_77144(targetSignature))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 77070, 77206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 77178, 77191);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 77070, 77206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 77222, 77549);

                return (f_10873_77230_77277(sourceSignature), f_10873_77279_77326(targetSignature)) switch
                {
                    (null, null) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 77367, 77387) && DynAbs.Tracing.TraceSender.Expression_True(10873, 77367, 77387))
    => true,
                    ({ } sourceModifiers, { } targetModifiers) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 77449, 77496) || true) && (f_10873_77454_77496(sourceModifiers, targetModifiers)) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 77449, 77496) || true)
    => true,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 77523, 77533) && DynAbs.Tracing.TraceSender.Expression_True(10873, 77523, 77533))
    => false
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 76897, 77560);

                Microsoft.Cci.CallingConvention
                f_10873_77074_77107(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 77074, 77107);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10873_77111_77144(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 77111, 77144);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10873_77230_77277(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCallingConventionModifiers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 77230, 77277);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10873_77279_77326(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCallingConventionModifiers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 77279, 77326);
                    return return_v;
                }


                bool
                f_10873_77454_77496(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                this_param, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                other)
                {
                    var return_v = this_param.SetEquals((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CustomModifier>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 77454, 77496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 76897, 77560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 76897, 77560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool FunctionPointerRefKindsEqual(FunctionPointerMethodSymbol sourceSignature, FunctionPointerMethodSymbol targetSignature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 77572, 78192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 77735, 78181);

                return f_10873_77742_77765(sourceSignature) == f_10873_77769_77792(targetSignature) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 77742, 78180) && (sourceSignature.ParameterRefKinds.IsDefault, targetSignature.ParameterRefKinds.IsDefault) switch
                {
                    (true, false) or (false, true) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 77960, 77999) && DynAbs.Tracing.TraceSender.Expression_True(10873, 77960, 77999))
=> false,
                    (true, true) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78025, 78045) && DynAbs.Tracing.TraceSender.Expression_True(10873, 78025, 78045))
=> true,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78071, 78158) && DynAbs.Tracing.TraceSender.Expression_True(10873, 78071, 78158))
=> sourceSignature.ParameterRefKinds.SequenceEqual(f_10873_78124_78157(targetSignature))
                });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 77572, 78192);

                Microsoft.CodeAnalysis.RefKind
                f_10873_77742_77765(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 77742, 77765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10873_77769_77792(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 77769, 77792);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10873_78124_78157(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 78124, 78157);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 77572, 78192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 77572, 78192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExactTypeArgumentInference(NamedTypeSymbol source, NamedTypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 78204, 79333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78364, 78401);

                f_10873_78364_78400((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78415, 78452);

                f_10873_78415_78451((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78466, 78589);

                f_10873_78466_78588(f_10873_78479_78587(f_10873_78497_78522(source), f_10873_78524_78549(target), TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78605, 78679);

                var
                sourceTypeArguments = f_10873_78631_78678()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78693, 78767);

                var
                targetTypeArguments = f_10873_78719_78766()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78783, 78855);

                f_10873_78783_78854(
                            source, sourceTypeArguments, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78869, 78941);

                f_10873_78869_78940(target, targetTypeArguments, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 78957, 79026);

                f_10873_78957_79025(f_10873_78970_78995(sourceTypeArguments) == f_10873_78999_79024(targetTypeArguments));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 79051, 79058);

                    for (int
        arg = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 79042, 79238) || true) && (arg < f_10873_79066_79091(sourceTypeArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 79093, 79098)
        , ++arg, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 79042, 79238))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 79042, 79238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 79132, 79223);

                        f_10873_79132_79222(this, f_10873_79147_79171(sourceTypeArguments, arg), f_10873_79173_79197(targetTypeArguments, arg), ref useSiteDiagnostics);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 79254, 79281);

                f_10873_79254_79280(
                            sourceTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 79295, 79322);

                f_10873_79295_79321(targetTypeArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 78204, 79333);

                int
                f_10873_78364_78400(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 78364, 78400);
                    return 0;
                }


                int
                f_10873_78415_78451(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 78415, 78451);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_78497_78522(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 78497, 78522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_78524_78549(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 78524, 78549);
                    return return_v;
                }


                bool
                f_10873_78479_78587(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 78479, 78587);
                    return return_v;
                }


                int
                f_10873_78466_78588(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 78466, 78588);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_78631_78678()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 78631, 78678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_78719_78766()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 78719, 78766);
                    return return_v;
                }


                int
                f_10873_78783_78854(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 78783, 78854);
                    return 0;
                }


                int
                f_10873_78869_78940(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 78869, 78940);
                    return 0;
                }


                int
                f_10873_78970_78995(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 78970, 78995);
                    return return_v;
                }


                int
                f_10873_78999_79024(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 78999, 79024);
                    return return_v;
                }


                int
                f_10873_78957_79025(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 78957, 79025);
                    return 0;
                }


                int
                f_10873_79066_79091(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 79066, 79091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_79147_79171(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 79147, 79171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_79173_79197(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 79173, 79197);
                    return return_v;
                }


                int
                f_10873_79132_79222(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 79132, 79222);
                    return 0;
                }


                int
                f_10873_79254_79280(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 79254, 79280);
                    return 0;
                }


                int
                f_10873_79295_79321(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 79295, 79321);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 78204, 79333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 78204, 79333);
            }
        }

        private void LowerBoundInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 79494, 83605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 79655, 79684);

                f_10873_79655_79683(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 79698, 79727);

                f_10873_79698_79726(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 80452, 80579) || true) && (f_10873_80456_80523(this, source, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 80452, 80579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 80557, 80564);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 80452, 80579);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 80727, 80835) || true) && (f_10873_80731_80779(this, source, target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 80727, 80835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 80813, 80820);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 80727, 80835);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 81378, 81512) || true) && (f_10873_81382_81456(this, source.Type, target.Type, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 81378, 81512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 81490, 81497);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 81378, 81512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 83012, 83136) || true) && (f_10873_83016_83080(this, source, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 83012, 83136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 83114, 83121);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 83012, 83136);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 83229, 83369) || true) && (f_10873_83233_83313(this, source.Type, target.Type, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 83229, 83369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 83347, 83354);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 83229, 83369);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 83385, 83533) || true) && (f_10873_83389_83477(this, source.Type, target.Type, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 83385, 83533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 83511, 83518);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 83385, 83533);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 79494, 83605);

                int
                f_10873_79655_79683(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 79655, 79683);
                    return 0;
                }


                int
                f_10873_79698_79726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 79698, 79726);
                    return 0;
                }


                bool
                f_10873_80456_80523(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LowerBoundNullableInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 80456, 80523);
                    return return_v;
                }


                bool
                f_10873_80731_80779(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target)
                {
                    var return_v = this_param.LowerBoundTypeParameterInference(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 80731, 80779);
                    return return_v;
                }


                bool
                f_10873_81382_81456(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LowerBoundArrayInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 81382, 81456);
                    return return_v;
                }


                bool
                f_10873_83016_83080(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LowerBoundTupleInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 83016, 83080);
                    return return_v;
                }


                bool
                f_10873_83233_83313(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LowerBoundConstructedInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 83233, 83313);
                    return return_v;
                }


                bool
                f_10873_83389_83477(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LowerBoundFunctionPointerTypeInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 83389, 83477);
                    return return_v;
                }


                // SPEC: * Otherwise, no inferences are made.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 79494, 83605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 79494, 83605);
            }
        }

        private bool LowerBoundTypeParameterInference(TypeWithAnnotations source, TypeWithAnnotations target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 83617, 84144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 83743, 83772);

                f_10873_83743_83771(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 83786, 83815);

                f_10873_83786_83814(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 83954, 84106) || true) && (f_10873_83958_83988(this, target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 83954, 84106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84022, 84061);

                    f_10873_84022_84060(this, source, _lowerBounds, target);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84079, 84091);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 83954, 84106);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84120, 84133);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 83617, 84144);

                int
                f_10873_83743_83771(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 83743, 83771);
                    return 0;
                }


                int
                f_10873_83786_83814(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 83786, 83814);
                    return 0;
                }


                bool
                f_10873_83958_83988(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.IsUnfixedTypeParameter(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 83958, 83988);
                    return return_v;
                }


                int
                f_10873_84022_84060(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                addedBound, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>[]
                collectedBounds, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                methodTypeParameterWithAnnotations)
                {
                    this_param.AddBound(addedBound, collectedBounds, methodTypeParameterWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 84022, 84060);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 83617, 84144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 83617, 84144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeWithAnnotations GetMatchingElementType(ArrayTypeSymbol source, TypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 84156, 85472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84329, 84366);

                f_10873_84329_84365((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84380, 84417);

                f_10873_84380_84416((object)target != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84484, 84792) || true) && (f_10873_84488_84504(target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 84484, 84792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84538, 84580);

                    var
                    arrayTarget = (ArrayTypeSymbol)target
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84598, 84713) || true) && (!f_10873_84603_84637(arrayTarget, source))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 84598, 84713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84679, 84694);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 84598, 84713);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84731, 84777);

                    return f_10873_84738_84776(arrayTarget);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 84484, 84792);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84874, 84959) || true) && (f_10873_84878_84895_M(!source.IsSZArray))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 84874, 84959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 84929, 84944);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 84874, 84959);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 85231, 85340) || true) && (!f_10873_85236_85276(target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 85231, 85340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 85310, 85325);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 85231, 85340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 85356, 85461);

                return f_10873_85363_85460(((NamedTypeSymbol)target), 0, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 84156, 85472);

                int
                f_10873_84329_84365(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 84329, 84365);
                    return 0;
                }


                int
                f_10873_84380_84416(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 84380, 84416);
                    return 0;
                }


                bool
                f_10873_84488_84504(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 84488, 84504);
                    return return_v;
                }


                bool
                f_10873_84603_84637(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                other)
                {
                    var return_v = this_param.HasSameShapeAs(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 84603, 84637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_84738_84776(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 84738, 84776);
                    return return_v;
                }


                bool
                f_10873_84878_84895_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 84878, 84895);
                    return return_v;
                }


                bool
                f_10873_85236_85276(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                _type)
                {
                    var return_v = _type.IsPossibleArrayGenericInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 85236, 85276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_85363_85460(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, int
                index, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.TypeArgumentWithDefinitionUseSiteDiagnostics(index, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 85363, 85460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 84156, 85472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 84156, 85472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LowerBoundArrayInference(TypeSymbol source, TypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 85484, 87032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 85632, 85669);

                f_10873_85632_85668((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 85683, 85720);

                f_10873_85683_85719((object)target != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86263, 86346) || true) && (!f_10873_86268_86284(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 86263, 86346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86318, 86331);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 86263, 86346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86362, 86404);

                var
                arraySource = (ArrayTypeSymbol)source
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86418, 86477);

                var
                elementSource = f_10873_86438_86476(arraySource)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86491, 86579);

                var
                elementTarget = f_10873_86511_86578(arraySource, target, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86593, 86681) || true) && (f_10873_86597_86619_M(!elementTarget.HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 86593, 86681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86653, 86666);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 86593, 86681);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86697, 86993) || true) && (f_10873_86701_86735(elementSource.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 86697, 86993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86769, 86843);

                    f_10873_86769_86842(this, elementSource, elementTarget, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 86697, 86993);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 86697, 86993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 86909, 86978);

                    f_10873_86909_86977(this, elementSource, elementTarget, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 86697, 86993);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 87009, 87021);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 85484, 87032);

                int
                f_10873_85632_85668(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 85632, 85668);
                    return 0;
                }


                int
                f_10873_85683_85719(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 85683, 85719);
                    return 0;
                }


                bool
                f_10873_86268_86284(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 86268, 86284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_86438_86476(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 86438, 86476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_86511_86578(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = GetMatchingElementType(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 86511, 86578);
                    return return_v;
                }


                bool
                f_10873_86597_86619_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 86597, 86619);
                    return return_v;
                }


                bool
                f_10873_86701_86735(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 86701, 86735);
                    return return_v;
                }


                int
                f_10873_86769_86842(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 86769, 86842);
                    return 0;
                }


                int
                f_10873_86909_86977(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 86909, 86977);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 85484, 87032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 85484, 87032);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LowerBoundNullableInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 87044, 87332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 87213, 87321);

                return f_10873_87220_87320(this, ExactOrBoundsKind.LowerBound, source, target, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 87044, 87332);

                bool
                f_10873_87220_87320(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.ExactOrBoundsKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExactOrBoundsNullableInference(kind, source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 87220, 87320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 87044, 87332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 87044, 87332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LowerBoundConstructedInference(TypeSymbol source, TypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 87344, 90289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 87498, 87535);

                f_10873_87498_87534((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 87549, 87586);

                f_10873_87549_87585((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 87602, 87652);

                var
                constructedTarget = target as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 87666, 87765) || true) && ((object)constructedTarget == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 87666, 87765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 87737, 87750);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 87666, 87765);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 87781, 87892) || true) && (f_10873_87785_87825(constructedTarget) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 87781, 87892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 87864, 87877);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 87781, 87892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 88446, 88496);

                var
                constructedSource = source as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 88510, 89174) || true) && ((object)constructedSource != null && (DynAbs.Tracing.TraceSender.Expression_True(10873, 88514, 88698) && f_10873_88568_88698(f_10873_88586_88622(constructedSource), f_10873_88624_88660(constructedTarget), TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 88510, 89174);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 88732, 89129) || true) && (f_10873_88736_88765(constructedSource) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 88736, 88803) || f_10873_88769_88803(constructedSource)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 88732, 89129);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 88845, 88939);

                        f_10873_88845_88938(this, constructedSource, constructedTarget, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 88732, 89129);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 88732, 89129);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 89021, 89110);

                        f_10873_89021_89109(this, constructedSource, constructedTarget, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 88732, 89129);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 89147, 89159);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 88510, 89174);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 89563, 89703) || true) && (f_10873_89567_89642(this, source, constructedTarget, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 89563, 89703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 89676, 89688);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 89563, 89703);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 90105, 90249) || true) && (f_10873_90109_90188(this, source, constructedTarget, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 90105, 90249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 90222, 90234);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 90105, 90249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 90265, 90278);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 87344, 90289);

                int
                f_10873_87498_87534(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 87498, 87534);
                    return 0;
                }


                int
                f_10873_87549_87585(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 87549, 87585);
                    return 0;
                }


                int
                f_10873_87785_87825(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllTypeArgumentCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 87785, 87825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_88586_88622(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 88586, 88622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_88624_88660(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 88624, 88660);
                    return return_v;
                }


                bool
                f_10873_88568_88698(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 88568, 88698);
                    return return_v;
                }


                bool
                f_10873_88736_88765(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 88736, 88765);
                    return return_v;
                }


                bool
                f_10873_88769_88803(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 88769, 88803);
                    return return_v;
                }


                int
                f_10873_88845_88938(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundTypeArgumentInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 88845, 88938);
                    return 0;
                }


                int
                f_10873_89021_89109(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactTypeArgumentInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 89021, 89109);
                    return 0;
                }


                bool
                f_10873_89567_89642(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LowerBoundClassInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 89567, 89642);
                    return return_v;
                }


                bool
                f_10873_90109_90188(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LowerBoundInterfaceInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 90109, 90188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 87344, 90289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 87344, 90289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LowerBoundClassInference(TypeSymbol source, NamedTypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 90301, 92503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 90454, 90491);

                f_10873_90454_90490((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 90505, 90542);

                f_10873_90505_90541((object)target != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 90558, 90657) || true) && (f_10873_90562_90577(target) != TypeKind.Class)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 90558, 90657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 90629, 90642);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 90558, 90657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 91558, 91592);

                NamedTypeSymbol
                sourceBase = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 91608, 91978) || true) && (f_10873_91612_91627(source) == TypeKind.Class)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 91608, 91978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 91679, 91764);

                    sourceBase = f_10873_91692_91763(source, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 91608, 91978);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 91608, 91978);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 91798, 91978) || true) && (f_10873_91802_91817(source) == TypeKind.TypeParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 91798, 91978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 91877, 91963);

                        sourceBase = f_10873_91890_91962(((TypeParameterSymbol)source), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 91798, 91978);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 91608, 91978);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 91994, 92465) || true) && ((object)sourceBase != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 91994, 92465);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 92061, 92343) || true) && (f_10873_92065_92177(f_10873_92083_92112(sourceBase), f_10873_92114_92139(target), TypeCompareKind.ConsiderEverything2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 92061, 92343);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 92219, 92290);

                            f_10873_92219_92289(this, sourceBase, target, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 92312, 92324);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 92061, 92343);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 92361, 92450);

                        sourceBase = f_10873_92374_92449(sourceBase, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 91994, 92465);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 91994, 92465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 91994, 92465);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 92479, 92492);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 90301, 92503);

                int
                f_10873_90454_90490(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 90454, 90490);
                    return 0;
                }


                int
                f_10873_90505_90541(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 90505, 90541);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10873_90562_90577(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 90562, 90577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10873_91612_91627(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 91612, 91627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_91692_91763(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 91692, 91763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10873_91802_91817(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 91802, 91817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_91890_91962(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 91890, 91962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_92083_92112(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 92083, 92112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_92114_92139(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 92114, 92139);
                    return return_v;
                }


                bool
                f_10873_92065_92177(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 92065, 92177);
                    return return_v;
                }


                int
                f_10873_92219_92289(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactTypeArgumentInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 92219, 92289);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_92374_92449(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 92374, 92449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 90301, 92503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 90301, 92503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LowerBoundInterfaceInference(TypeSymbol source, NamedTypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 92515, 94899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 92672, 92709);

                f_10873_92672_92708((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 92723, 92760);

                f_10873_92723_92759((object)target != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 92776, 92861) || true) && (f_10873_92780_92799_M(!target.IsInterface))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 92776, 92861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 92833, 92846);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 92776, 92861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 93396, 93442);

                ImmutableArray<NamedTypeSymbol>
                allInterfaces
                = default(ImmutableArray<NamedTypeSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 93456, 94331);

                switch (f_10873_93464_93479(source))
                {

                    case TypeKind.Struct:
                    case TypeKind.Class:
                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 93456, 94331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 93636, 93729);

                        allInterfaces = f_10873_93652_93728(source, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10873, 93751, 93757);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 93456, 94331);

                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 93456, 94331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 93827, 93875);

                        var
                        typeParameter = (TypeParameterSymbol)source
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 93897, 94225);

                        allInterfaces = f_10873_93913_94081(f_10873_93913_93969(typeParameter, ref useSiteDiagnostics), ref useSiteDiagnostics).
                                                                Concat(f_10873_94131_94223(typeParameter, ref useSiteDiagnostics));
                        DynAbs.Tracing.TraceSender.TraceBreak(10873, 94247, 94253);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 93456, 94331);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 93456, 94331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 94303, 94316);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 93456, 94331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 94460, 94550);

                allInterfaces = f_10873_94476_94549(allInterfaces, VarianceKind.In);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 94566, 94652);

                NamedTypeSymbol
                matchingInterface = f_10873_94602_94651(allInterfaces, target)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 94666, 94765) || true) && ((object)matchingInterface == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 94666, 94765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 94737, 94750);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 94666, 94765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 94779, 94862);

                f_10873_94779_94861(this, matchingInterface, target, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 94876, 94888);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 92515, 94899);

                int
                f_10873_92672_92708(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 92672, 92708);
                    return 0;
                }


                int
                f_10873_92723_92759(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 92723, 92759);
                    return 0;
                }


                bool
                f_10873_92780_92799_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 92780, 92799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10873_93464_93479(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 93464, 93479);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_93652_93728(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 93652, 93728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_93913_93969(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 93913, 93969);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_93913_94081(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 93913, 94081);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_94131_94223(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllEffectiveInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 94131, 94223);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_94476_94549(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, Microsoft.CodeAnalysis.VarianceKind
                variance)
                {
                    var return_v = ModuloReferenceTypeNullabilityDifferences(interfaces, variance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 94476, 94549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_94602_94651(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target)
                {
                    var return_v = GetInterfaceInferenceBound(interfaces, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 94602, 94651);
                    return return_v;
                }


                int
                f_10873_94779_94861(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundTypeArgumentInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 94779, 94861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 92515, 94899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 92515, 94899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<NamedTypeSymbol> ModuloReferenceTypeNullabilityDifferences(ImmutableArray<NamedTypeSymbol> interfaces, VarianceKind variance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 94911, 95842);
                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol found = default(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 95092, 95182);

                var
                dictionary = f_10873_95109_95181()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 95198, 95652);
                    foreach (var @interface in f_10873_95225_95235_I(interfaces))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 95198, 95652);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 95269, 95637) || true) && (f_10873_95273_95322(dictionary, @interface, out found))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 95269, 95637);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 95364, 95443);

                            var
                            merged = (NamedTypeSymbol)f_10873_95394_95442(found, @interface, variance)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 95465, 95497);

                            dictionary[@interface] = merged;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 95269, 95637);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 95269, 95637);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 95579, 95618);

                            f_10873_95579_95617(dictionary, @interface, @interface);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 95269, 95637);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 95198, 95652);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 95668, 95771);

                var
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 95681, 95718) || ((f_10873_95681_95697(dictionary) != interfaces.Length && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 95721, 95757)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 95760, 95770))) ? f_10873_95721_95757(f_10873_95721_95738(dictionary)) : interfaces
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 95785, 95803);

                f_10873_95785_95802(dictionary);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 95817, 95831);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 94911, 95842);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_95109_95181()
                {
                    var return_v = PooledDictionaryIgnoringNullableModifiersForReferenceTypes.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 95109, 95181);
                    return return_v;
                }


                bool
                f_10873_95273_95322(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 95273, 95322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_95394_95442(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                other, Microsoft.CodeAnalysis.VarianceKind
                variance)
                {
                    var return_v = this_param.MergeEquivalentTypes((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)other, variance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 95394, 95442);
                    return return_v;
                }


                int
                f_10873_95579_95617(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 95579, 95617);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_95225_95235_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 95225, 95235);
                    return return_v;
                }


                int
                f_10873_95681_95697(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 95681, 95697);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueCollection
                f_10873_95721_95738(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 95721, 95738);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_95721_95757(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueCollection
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 95721, 95757);
                    return return_v;
                }


                int
                f_10873_95785_95802(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 95785, 95802);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 94911, 95842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 94911, 95842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LowerBoundTypeArgumentInference(NamedTypeSymbol source, NamedTypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 95854, 98636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 96642, 96679);

                f_10873_96642_96678((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 96693, 96730);

                f_10873_96693_96729((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 96744, 96867);

                f_10873_96744_96866(f_10873_96757_96865(f_10873_96775_96800(source), f_10873_96802_96827(target), TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 96883, 96952);

                var
                typeParameters = f_10873_96904_96951()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 96966, 97040);

                var
                sourceTypeArguments = f_10873_96992_97039()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97054, 97128);

                var
                targetTypeArguments = f_10873_97080_97127()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97144, 97207);

                f_10873_97144_97206(f_10873_97144_97169(source), typeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97221, 97293);

                f_10873_97221_97292(source, sourceTypeArguments, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97307, 97379);

                f_10873_97307_97378(target, targetTypeArguments, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97395, 97459);

                f_10873_97395_97458(f_10873_97408_97428(typeParameters) == f_10873_97432_97457(sourceTypeArguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97473, 97537);

                f_10873_97473_97536(f_10873_97486_97506(typeParameters) == f_10873_97510_97535(targetTypeArguments));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97562, 97569);

                    for (int
        arg = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97553, 98505) || true) && (arg < f_10873_97577_97602(sourceTypeArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97604, 97609)
        , ++arg, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 97553, 98505))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 97553, 98505);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97643, 97683);

                        var
                        typeParameter = f_10873_97663_97682(typeParameters, arg)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97701, 97751);

                        var
                        sourceTypeArgument = f_10873_97726_97750(sourceTypeArguments, arg)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97769, 97819);

                        var
                        targetTypeArgument = f_10873_97794_97818(targetTypeArguments, arg)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97839, 98490) || true) && (f_10873_97843_97882(sourceTypeArgument.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 97843, 97928) && f_10873_97886_97908(typeParameter) == VarianceKind.Out))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 97839, 98490);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 97970, 98054);

                            f_10873_97970_98053(this, sourceTypeArgument, targetTypeArgument, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 97839, 98490);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 97839, 98490);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 98096, 98490) || true) && (f_10873_98100_98139(sourceTypeArgument.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 98100, 98184) && f_10873_98143_98165(typeParameter) == VarianceKind.In))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 98096, 98490);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 98226, 98310);

                                f_10873_98226_98309(this, sourceTypeArgument, targetTypeArgument, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 98096, 98490);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 98096, 98490);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 98392, 98471);

                                f_10873_98392_98470(this, sourceTypeArgument, targetTypeArgument, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 98096, 98490);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 97839, 98490);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 98521, 98543);

                f_10873_98521_98542(
                            typeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 98557, 98584);

                f_10873_98557_98583(sourceTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 98598, 98625);

                f_10873_98598_98624(targetTypeArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 95854, 98636);

                int
                f_10873_96642_96678(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 96642, 96678);
                    return 0;
                }


                int
                f_10873_96693_96729(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 96693, 96729);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_96775_96800(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 96775, 96800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_96802_96827(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 96802, 96827);
                    return return_v;
                }


                bool
                f_10873_96757_96865(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 96757, 96865);
                    return return_v;
                }


                int
                f_10873_96744_96866(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 96744, 96866);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10873_96904_96951()
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 96904, 96951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_96992_97039()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 96992, 97039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_97080_97127()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 97080, 97127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_97144_97169(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97144, 97169);
                    return return_v;
                }


                int
                f_10873_97144_97206(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                result)
                {
                    type.GetAllTypeParameters(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 97144, 97206);
                    return 0;
                }


                int
                f_10873_97221_97292(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 97221, 97292);
                    return 0;
                }


                int
                f_10873_97307_97378(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 97307, 97378);
                    return 0;
                }


                int
                f_10873_97408_97428(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97408, 97428);
                    return return_v;
                }


                int
                f_10873_97432_97457(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97432, 97457);
                    return return_v;
                }


                int
                f_10873_97395_97458(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 97395, 97458);
                    return 0;
                }


                int
                f_10873_97486_97506(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97486, 97506);
                    return return_v;
                }


                int
                f_10873_97510_97535(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97510, 97535);
                    return return_v;
                }


                int
                f_10873_97473_97536(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 97473, 97536);
                    return 0;
                }


                int
                f_10873_97577_97602(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97577, 97602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10873_97663_97682(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97663, 97682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_97726_97750(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97726, 97750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_97794_97818(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97794, 97818);
                    return return_v;
                }


                bool
                f_10873_97843_97882(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97843, 97882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10873_97886_97908(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 97886, 97908);
                    return return_v;
                }


                int
                f_10873_97970_98053(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 97970, 98053);
                    return 0;
                }


                bool
                f_10873_98100_98139(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 98100, 98139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10873_98143_98165(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 98143, 98165);
                    return return_v;
                }


                int
                f_10873_98226_98309(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.UpperBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 98226, 98309);
                    return 0;
                }


                int
                f_10873_98392_98470(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 98392, 98470);
                    return 0;
                }


                int
                f_10873_98521_98542(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 98521, 98542);
                    return 0;
                }


                int
                f_10873_98557_98583(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 98557, 98583);
                    return 0;
                }


                int
                f_10873_98598_98624(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 98598, 98624);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 95854, 98636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 95854, 98636);
            }
        }

        private bool LowerBoundFunctionPointerTypeInference(TypeSymbol source, TypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 98666, 100961);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 98828, 99046) || true) && (source is not FunctionPointerTypeSymbol { Signature: { } sourceSignature } || (DynAbs.Tracing.TraceSender.Expression_False(10873, 98832, 98984) || target is not FunctionPointerTypeSymbol { Signature: { } targetSignature }))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 98828, 99046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99018, 99031);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 98828, 99046);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99062, 99192) || true) && (f_10873_99066_99096(sourceSignature) != f_10873_99100_99130(targetSignature))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 99062, 99192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99164, 99177);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 99062, 99192);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99208, 99414) || true) && (!f_10873_99213_99275(sourceSignature, targetSignature) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 99212, 99352) || !f_10873_99280_99352(sourceSignature, targetSignature)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 99208, 99414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99386, 99399);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 99208, 99414);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99691, 99696);

                    // Reference parameters are treated as "input" variance by default, and reference return types are treated as out variance by default.
                    // If they have a ref kind or are not reference types, then they are treated as invariant.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99682, 100395) || true) && (i < f_10873_99702_99732(sourceSignature))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99734, 99737)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 99682, 100395))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 99682, 100395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99771, 99819);

                        var
                        sourceParam = f_10873_99789_99815(sourceSignature)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99837, 99885);

                        var
                        targetParam = f_10873_99855_99881(targetSignature)[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 99905, 100380) || true) && ((f_10873_99910_99942(f_10873_99910_99926(sourceParam)) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 99910, 99982) || f_10873_99946_99982(f_10873_99946_99962(sourceParam)))) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 99909, 100022) && f_10873_99987_100006(sourceParam) == RefKind.None))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 99905, 100380);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 100064, 100174);

                            f_10873_100064_100173(this, f_10873_100084_100115(sourceParam), f_10873_100117_100148(targetParam), ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 99905, 100380);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 99905, 100380);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 100256, 100361);

                            f_10873_100256_100360(this, f_10873_100271_100302(sourceParam), f_10873_100304_100335(targetParam), ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 99905, 100380);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 714);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 100411, 100922) || true) && ((f_10873_100416_100458(f_10873_100416_100442(sourceSignature)) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 100416, 100508) || f_10873_100462_100508(f_10873_100462_100488(sourceSignature)))) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 100415, 100552) && f_10873_100513_100536(sourceSignature) == RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 100411, 100922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 100586, 100716);

                    f_10873_100586_100715(this, f_10873_100606_100647(sourceSignature), f_10873_100649_100690(targetSignature), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 100411, 100922);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 100411, 100922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 100782, 100907);

                    f_10873_100782_100906(this, f_10873_100797_100838(sourceSignature), f_10873_100840_100881(targetSignature), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 100411, 100922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 100938, 100950);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 98666, 100961);

                int
                f_10873_99066_99096(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 99066, 99096);
                    return return_v;
                }


                int
                f_10873_99100_99130(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 99100, 99130);
                    return return_v;
                }


                bool
                f_10873_99213_99275(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                sourceSignature, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                targetSignature)
                {
                    var return_v = FunctionPointerRefKindsEqual(sourceSignature, targetSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 99213, 99275);
                    return return_v;
                }


                bool
                f_10873_99280_99352(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                sourceSignature, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                targetSignature)
                {
                    var return_v = FunctionPointerCallingConventionsEqual(sourceSignature, targetSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 99280, 99352);
                    return return_v;
                }


                int
                f_10873_99702_99732(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 99702, 99732);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_99789_99815(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 99789, 99815);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_99855_99881(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 99855, 99881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_99910_99926(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 99910, 99926);
                    return return_v;
                }


                bool
                f_10873_99910_99942(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 99910, 99942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_99946_99962(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 99946, 99962);
                    return return_v;
                }


                bool
                f_10873_99946_99982(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 99946, 99982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10873_99987_100006(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 99987, 100006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_100084_100115(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100084, 100115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_100117_100148(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100117, 100148);
                    return return_v;
                }


                int
                f_10873_100064_100173(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.UpperBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 100064, 100173);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_100271_100302(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100271, 100302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_100304_100335(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100304, 100335);
                    return return_v;
                }


                int
                f_10873_100256_100360(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 100256, 100360);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_100416_100442(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100416, 100442);
                    return return_v;
                }


                bool
                f_10873_100416_100458(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100416, 100458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_100462_100488(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100462, 100488);
                    return return_v;
                }


                bool
                f_10873_100462_100508(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 100462, 100508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10873_100513_100536(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100513, 100536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_100606_100647(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100606, 100647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_100649_100690(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100649, 100690);
                    return return_v;
                }


                int
                f_10873_100586_100715(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 100586, 100715);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_100797_100838(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100797, 100838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_100840_100881(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 100840, 100881);
                    return return_v;
                }


                int
                f_10873_100782_100906(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 100782, 100906);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 98666, 100961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 98666, 100961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void UpperBoundInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 101141, 103569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 101302, 101331);

                f_10873_101302_101330(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 101345, 101374);

                f_10873_101345_101373(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 101646, 101773) || true) && (f_10873_101650_101717(this, source, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 101646, 101773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 101751, 101758);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 101646, 101773);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 101921, 102029) || true) && (f_10873_101925_101973(this, source, target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 101921, 102029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 102007, 102014);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 101921, 102029);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 102566, 102690) || true) && (f_10873_102570_102634(this, source, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 102566, 102690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 102668, 102675);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 102566, 102690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 102706, 102783);

                f_10873_102706_102782(f_10873_102719_102746(source.Type) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 102719, 102781) || f_10873_102750_102781(source.Type)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 103203, 103333) || true) && (f_10873_103207_103277(this, source, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 103203, 103333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 103311, 103318);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 103203, 103333);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 103349, 103497) || true) && (f_10873_103353_103441(this, source.Type, target.Type, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 103349, 103497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 103475, 103482);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 103349, 103497);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 101141, 103569);

                int
                f_10873_101302_101330(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 101302, 101330);
                    return 0;
                }


                int
                f_10873_101345_101373(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 101345, 101373);
                    return 0;
                }


                bool
                f_10873_101650_101717(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.UpperBoundNullableInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 101650, 101717);
                    return return_v;
                }


                bool
                f_10873_101925_101973(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target)
                {
                    var return_v = this_param.UpperBoundTypeParameterInference(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 101925, 101973);
                    return return_v;
                }


                bool
                f_10873_102570_102634(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.UpperBoundArrayInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 102570, 102634);
                    return return_v;
                }


                bool
                f_10873_102719_102746(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 102719, 102746);
                    return return_v;
                }


                bool
                f_10873_102750_102781(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 102750, 102781);
                    return return_v;
                }


                int
                f_10873_102706_102782(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 102706, 102782);
                    return 0;
                }


                bool
                f_10873_103207_103277(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                sourceWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                targetWithAnnotations, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.UpperBoundConstructedInference(sourceWithAnnotations, targetWithAnnotations, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 103207, 103277);
                    return return_v;
                }


                bool
                f_10873_103353_103441(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.UpperBoundFunctionPointerTypeInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 103353, 103441);
                    return return_v;
                }


                // SPEC: * Otherwise, no inferences are made.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 101141, 103569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 101141, 103569);
            }
        }

        private bool UpperBoundTypeParameterInference(TypeWithAnnotations source, TypeWithAnnotations target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 103581, 104112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 103707, 103736);

                f_10873_103707_103735(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 103750, 103779);

                f_10873_103750_103778(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 103922, 104074) || true) && (f_10873_103926_103956(this, target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 103922, 104074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 103990, 104029);

                    f_10873_103990_104028(this, source, _upperBounds, target);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 104047, 104059);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 103922, 104074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 104088, 104101);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 103581, 104112);

                int
                f_10873_103707_103735(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 103707, 103735);
                    return 0;
                }


                int
                f_10873_103750_103778(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 103750, 103778);
                    return 0;
                }


                bool
                f_10873_103926_103956(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.IsUnfixedTypeParameter(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 103926, 103956);
                    return return_v;
                }


                int
                f_10873_103990_104028(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                addedBound, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>[]
                collectedBounds, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                methodTypeParameterWithAnnotations)
                {
                    this_param.AddBound(addedBound, collectedBounds, methodTypeParameterWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 103990, 104028);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 103581, 104112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 103581, 104112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool UpperBoundArrayInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 104124, 105681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 104290, 104319);

                f_10873_104290_104318(source.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 104333, 104362);

                f_10873_104333_104361(target.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 104899, 104987) || true) && (!f_10873_104904_104925(target.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 104899, 104987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 104959, 104972);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 104899, 104987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105001, 105048);

                var
                arrayTarget = (ArrayTypeSymbol)target.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105062, 105121);

                var
                elementTarget = f_10873_105082_105120(arrayTarget)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105135, 105228);

                var
                elementSource = f_10873_105155_105227(arrayTarget, source.Type, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105242, 105330) || true) && (f_10873_105246_105268_M(!elementSource.HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 105242, 105330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105302, 105315);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 105242, 105330);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105346, 105642) || true) && (f_10873_105350_105384(elementSource.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 105346, 105642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105418, 105492);

                    f_10873_105418_105491(this, elementSource, elementTarget, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 105346, 105642);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 105346, 105642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105558, 105627);

                    f_10873_105558_105626(this, elementSource, elementTarget, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 105346, 105642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105658, 105670);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 104124, 105681);

                int
                f_10873_104290_104318(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 104290, 104318);
                    return 0;
                }


                int
                f_10873_104333_104361(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 104333, 104361);
                    return 0;
                }


                bool
                f_10873_104904_104925(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 104904, 104925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_105082_105120(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 105082, 105120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_105155_105227(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = GetMatchingElementType(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 105155, 105227);
                    return return_v;
                }


                bool
                f_10873_105246_105268_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 105246, 105268);
                    return return_v;
                }


                bool
                f_10873_105350_105384(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 105350, 105384);
                    return return_v;
                }


                int
                f_10873_105418_105491(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.UpperBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 105418, 105491);
                    return 0;
                }


                int
                f_10873_105558_105626(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 105558, 105626);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 104124, 105681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 104124, 105681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool UpperBoundNullableInference(TypeWithAnnotations source, TypeWithAnnotations target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 105693, 105981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 105862, 105970);

                return f_10873_105869_105969(this, ExactOrBoundsKind.UpperBound, source, target, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 105693, 105981);

                bool
                f_10873_105869_105969(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.ExactOrBoundsKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExactOrBoundsNullableInference(kind, source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 105869, 105969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 105693, 105981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 105693, 105981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool UpperBoundConstructedInference(TypeWithAnnotations sourceWithAnnotations, TypeWithAnnotations targetWithAnnotations, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 105993, 108602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 106195, 106239);

                f_10873_106195_106238(sourceWithAnnotations.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 106253, 106297);

                f_10873_106253_106296(targetWithAnnotations.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 106311, 106351);

                var
                source = sourceWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 106365, 106405);

                var
                target = targetWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 106421, 106471);

                var
                constructedSource = source as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 106485, 106584) || true) && ((object)constructedSource == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 106485, 106584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 106556, 106569);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 106485, 106584);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 106600, 106711) || true) && (f_10873_106604_106644(constructedSource) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 106600, 106711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 106683, 106696);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 106600, 106711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 107012, 107062);

                var
                constructedTarget = target as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 107078, 107731) || true) && ((object)constructedTarget != null && (DynAbs.Tracing.TraceSender.Expression_True(10873, 107082, 107255) && f_10873_107136_107255(f_10873_107154_107190(constructedSource), f_10873_107192_107217(target), TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 107078, 107731);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 107289, 107686) || true) && (f_10873_107293_107322(constructedTarget) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 107293, 107360) || f_10873_107326_107360(constructedTarget)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 107289, 107686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 107402, 107496);

                        f_10873_107402_107495(this, constructedSource, constructedTarget, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 107289, 107686);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 107289, 107686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 107578, 107667);

                        f_10873_107578_107666(this, constructedSource, constructedTarget, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 107289, 107686);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 107704, 107716);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 107078, 107731);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 107934, 108074) || true) && (f_10873_107938_108013(this, constructedSource, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 107934, 108074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 108047, 108059);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 107934, 108074);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 108418, 108562) || true) && (f_10873_108422_108501(this, constructedSource, target, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 108418, 108562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 108535, 108547);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 108418, 108562);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 108578, 108591);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 105993, 108602);

                int
                f_10873_106195_106238(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 106195, 106238);
                    return 0;
                }


                int
                f_10873_106253_106296(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 106253, 106296);
                    return 0;
                }


                int
                f_10873_106604_106644(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllTypeArgumentCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 106604, 106644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_107154_107190(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 107154, 107190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_107192_107217(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 107192, 107217);
                    return return_v;
                }


                bool
                f_10873_107136_107255(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 107136, 107255);
                    return return_v;
                }


                bool
                f_10873_107293_107322(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 107293, 107322);
                    return return_v;
                }


                bool
                f_10873_107326_107360(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 107326, 107360);
                    return return_v;
                }


                int
                f_10873_107402_107495(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.UpperBoundTypeArgumentInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 107402, 107495);
                    return 0;
                }


                int
                f_10873_107578_107666(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactTypeArgumentInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 107578, 107666);
                    return 0;
                }


                bool
                f_10873_107938_108013(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.UpperBoundClassInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 107938, 108013);
                    return return_v;
                }


                bool
                f_10873_108422_108501(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.UpperBoundInterfaceInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 108422, 108501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 105993, 108602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 105993, 108602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool UpperBoundClassInference(NamedTypeSymbol source, TypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 108614, 109903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 108767, 108804);

                f_10873_108767_108803((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 108818, 108855);

                f_10873_108818_108854((object)target != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 108871, 109007) || true) && (f_10873_108875_108890(source) != TypeKind.Class || (DynAbs.Tracing.TraceSender.Expression_False(10873, 108875, 108945) || f_10873_108912_108927(target) != TypeKind.Class))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 108871, 109007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 108979, 108992);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 108871, 109007);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 109287, 109376);

                var
                targetBase = f_10873_109304_109375(target, ref useSiteDiagnostics)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 109390, 109863) || true) && ((object)targetBase != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 109390, 109863);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 109457, 109739) || true) && (f_10873_109461_109573(f_10873_109479_109508(targetBase), f_10873_109510_109535(source), TypeCompareKind.ConsiderEverything2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 109457, 109739);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 109615, 109686);

                            f_10873_109615_109685(this, source, targetBase, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 109708, 109720);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 109457, 109739);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 109759, 109848);

                        targetBase = f_10873_109772_109847(targetBase, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 109390, 109863);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 109390, 109863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 109390, 109863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 109879, 109892);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 108614, 109903);

                int
                f_10873_108767_108803(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 108767, 108803);
                    return 0;
                }


                int
                f_10873_108818_108854(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 108818, 108854);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10873_108875_108890(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 108875, 108890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10873_108912_108927(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 108912, 108927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_109304_109375(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 109304, 109375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_109479_109508(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 109479, 109508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_109510_109535(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 109510, 109535);
                    return return_v;
                }


                bool
                f_10873_109461_109573(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 109461, 109573);
                    return return_v;
                }


                int
                f_10873_109615_109685(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactTypeArgumentInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 109615, 109685);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_109772_109847(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 109772, 109847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 108614, 109903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 108614, 109903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool UpperBoundInterfaceInference(NamedTypeSymbol source, TypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 109915, 111587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 110072, 110109);

                f_10873_110072_110108((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 110123, 110160);

                f_10873_110123_110159((object)target != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 110176, 110261) || true) && (f_10873_110180_110199_M(!source.IsInterface))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 110176, 110261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 110233, 110246);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 110176, 110261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 110623, 110887);

                switch (f_10873_110631_110646(target))
                {

                    case TypeKind.Struct:
                    case TypeKind.Class:
                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 110623, 110887);
                        DynAbs.Tracing.TraceSender.TraceBreak(10873, 110803, 110809);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 110623, 110887);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 110623, 110887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 110859, 110872);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 110623, 110887);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 110903, 111028);

                ImmutableArray<NamedTypeSymbol>
                allInterfaces = f_10873_110951_111027(target, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 111157, 111248);

                allInterfaces = f_10873_111173_111247(allInterfaces, VarianceKind.Out);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 111264, 111346);

                NamedTypeSymbol
                bestInterface = f_10873_111296_111345(allInterfaces, source)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 111360, 111455) || true) && ((object)bestInterface == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 111360, 111455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 111427, 111440);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 111360, 111455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 111471, 111550);

                f_10873_111471_111549(this, source, bestInterface, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 111564, 111576);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 109915, 111587);

                int
                f_10873_110072_110108(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 110072, 110108);
                    return 0;
                }


                int
                f_10873_110123_110159(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 110123, 110159);
                    return 0;
                }


                bool
                f_10873_110180_110199_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 110180, 110199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10873_110631_110646(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 110631, 110646);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_110951_111027(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 110951, 111027);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_111173_111247(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, Microsoft.CodeAnalysis.VarianceKind
                variance)
                {
                    var return_v = ModuloReferenceTypeNullabilityDifferences(interfaces, variance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 111173, 111247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_111296_111345(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target)
                {
                    var return_v = GetInterfaceInferenceBound(interfaces, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 111296, 111345);
                    return return_v;
                }


                int
                f_10873_111471_111549(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.UpperBoundTypeArgumentInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 111471, 111549);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 109915, 111587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 109915, 111587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void UpperBoundTypeArgumentInference(NamedTypeSymbol source, NamedTypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 111599, 114381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 112387, 112424);

                f_10873_112387_112423((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 112438, 112475);

                f_10873_112438_112474((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 112489, 112612);

                f_10873_112489_112611(f_10873_112502_112610(f_10873_112520_112545(source), f_10873_112547_112572(target), TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 112628, 112697);

                var
                typeParameters = f_10873_112649_112696()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 112711, 112785);

                var
                sourceTypeArguments = f_10873_112737_112784()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 112799, 112873);

                var
                targetTypeArguments = f_10873_112825_112872()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 112889, 112952);

                f_10873_112889_112951(f_10873_112889_112914(source), typeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 112966, 113038);

                f_10873_112966_113037(source, sourceTypeArguments, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113052, 113124);

                f_10873_113052_113123(target, targetTypeArguments, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113140, 113204);

                f_10873_113140_113203(f_10873_113153_113173(typeParameters) == f_10873_113177_113202(sourceTypeArguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113218, 113282);

                f_10873_113218_113281(f_10873_113231_113251(typeParameters) == f_10873_113255_113280(targetTypeArguments));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113307, 113314);

                    for (int
        arg = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113298, 114250) || true) && (arg < f_10873_113322_113347(sourceTypeArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113349, 113354)
        , ++arg, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 113298, 114250))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 113298, 114250);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113388, 113428);

                        var
                        typeParameter = f_10873_113408_113427(typeParameters, arg)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113446, 113496);

                        var
                        sourceTypeArgument = f_10873_113471_113495(sourceTypeArguments, arg)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113514, 113564);

                        var
                        targetTypeArgument = f_10873_113539_113563(targetTypeArguments, arg)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113584, 114235) || true) && (f_10873_113588_113627(sourceTypeArgument.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 113588, 113673) && f_10873_113631_113653(typeParameter) == VarianceKind.Out))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 113584, 114235);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113715, 113799);

                            f_10873_113715_113798(this, sourceTypeArgument, targetTypeArgument, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 113584, 114235);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 113584, 114235);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113841, 114235) || true) && (f_10873_113845_113884(sourceTypeArgument.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 113845, 113929) && f_10873_113888_113910(typeParameter) == VarianceKind.In))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 113841, 114235);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 113971, 114055);

                                f_10873_113971_114054(this, sourceTypeArgument, targetTypeArgument, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 113841, 114235);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 113841, 114235);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 114137, 114216);

                                f_10873_114137_114215(this, sourceTypeArgument, targetTypeArgument, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 113841, 114235);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 113584, 114235);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 114266, 114288);

                f_10873_114266_114287(
                            typeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 114302, 114329);

                f_10873_114302_114328(sourceTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 114343, 114370);

                f_10873_114343_114369(targetTypeArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 111599, 114381);

                int
                f_10873_112387_112423(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 112387, 112423);
                    return 0;
                }


                int
                f_10873_112438_112474(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 112438, 112474);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_112520_112545(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 112520, 112545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_112547_112572(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 112547, 112572);
                    return return_v;
                }


                bool
                f_10873_112502_112610(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 112502, 112610);
                    return return_v;
                }


                int
                f_10873_112489_112611(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 112489, 112611);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10873_112649_112696()
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 112649, 112696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_112737_112784()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 112737, 112784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_112825_112872()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 112825, 112872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_112889_112914(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 112889, 112914);
                    return return_v;
                }


                int
                f_10873_112889_112951(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                result)
                {
                    type.GetAllTypeParameters(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 112889, 112951);
                    return 0;
                }


                int
                f_10873_112966_113037(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 112966, 113037);
                    return 0;
                }


                int
                f_10873_113052_113123(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 113052, 113123);
                    return 0;
                }


                int
                f_10873_113153_113173(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113153, 113173);
                    return return_v;
                }


                int
                f_10873_113177_113202(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113177, 113202);
                    return return_v;
                }


                int
                f_10873_113140_113203(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 113140, 113203);
                    return 0;
                }


                int
                f_10873_113231_113251(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113231, 113251);
                    return return_v;
                }


                int
                f_10873_113255_113280(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113255, 113280);
                    return return_v;
                }


                int
                f_10873_113218_113281(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 113218, 113281);
                    return 0;
                }


                int
                f_10873_113322_113347(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113322, 113347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10873_113408_113427(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113408, 113427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_113471_113495(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113471, 113495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_113539_113563(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113539, 113563);
                    return return_v;
                }


                bool
                f_10873_113588_113627(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113588, 113627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10873_113631_113653(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113631, 113653);
                    return return_v;
                }


                int
                f_10873_113715_113798(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.UpperBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 113715, 113798);
                    return 0;
                }


                bool
                f_10873_113845_113884(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113845, 113884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10873_113888_113910(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 113888, 113910);
                    return return_v;
                }


                int
                f_10873_113971_114054(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 113971, 114054);
                    return 0;
                }


                int
                f_10873_114137_114215(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 114137, 114215);
                    return 0;
                }


                int
                f_10873_114266_114287(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 114266, 114287);
                    return 0;
                }


                int
                f_10873_114302_114328(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 114302, 114328);
                    return 0;
                }


                int
                f_10873_114343_114369(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 114343, 114369);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 111599, 114381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 111599, 114381);
            }
        }

        private bool UpperBoundFunctionPointerTypeInference(TypeSymbol source, TypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 114411, 116706);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 114573, 114791) || true) && (source is not FunctionPointerTypeSymbol { Signature: { } sourceSignature } || (DynAbs.Tracing.TraceSender.Expression_False(10873, 114577, 114729) || target is not FunctionPointerTypeSymbol { Signature: { } targetSignature }))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 114573, 114791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 114763, 114776);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 114573, 114791);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 114807, 114937) || true) && (f_10873_114811_114841(sourceSignature) != f_10873_114845_114875(targetSignature))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 114807, 114937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 114909, 114922);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 114807, 114937);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 114953, 115159) || true) && (!f_10873_114958_115020(sourceSignature, targetSignature) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 114957, 115097) || !f_10873_115025_115097(sourceSignature, targetSignature)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 114953, 115159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 115131, 115144);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 114953, 115159);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 115436, 115441);

                    // Reference parameters are treated as "input" variance by default, and reference return types are treated as out variance by default.
                    // If they have a ref kind or are not reference types, then they are treated as invariant.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 115427, 116140) || true) && (i < f_10873_115447_115477(sourceSignature))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 115479, 115482)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 115427, 116140))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 115427, 116140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 115516, 115564);

                        var
                        sourceParam = f_10873_115534_115560(sourceSignature)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 115582, 115630);

                        var
                        targetParam = f_10873_115600_115626(targetSignature)[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 115650, 116125) || true) && ((f_10873_115655_115687(f_10873_115655_115671(sourceParam)) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 115655, 115727) || f_10873_115691_115727(f_10873_115691_115707(sourceParam)))) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 115654, 115767) && f_10873_115732_115751(sourceParam) == RefKind.None))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 115650, 116125);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 115809, 115919);

                            f_10873_115809_115918(this, f_10873_115829_115860(sourceParam), f_10873_115862_115893(targetParam), ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 115650, 116125);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 115650, 116125);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 116001, 116106);

                            f_10873_116001_116105(this, f_10873_116016_116047(sourceParam), f_10873_116049_116080(targetParam), ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 115650, 116125);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 714);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 116156, 116667) || true) && ((f_10873_116161_116203(f_10873_116161_116187(sourceSignature)) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 116161, 116253) || f_10873_116207_116253(f_10873_116207_116233(sourceSignature)))) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 116160, 116297) && f_10873_116258_116281(sourceSignature) == RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 116156, 116667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 116331, 116461);

                    f_10873_116331_116460(this, f_10873_116351_116392(sourceSignature), f_10873_116394_116435(targetSignature), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 116156, 116667);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 116156, 116667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 116527, 116652);

                    f_10873_116527_116651(this, f_10873_116542_116583(sourceSignature), f_10873_116585_116626(targetSignature), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 116156, 116667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 116683, 116695);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 114411, 116706);

                int
                f_10873_114811_114841(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 114811, 114841);
                    return return_v;
                }


                int
                f_10873_114845_114875(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 114845, 114875);
                    return return_v;
                }


                bool
                f_10873_114958_115020(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                sourceSignature, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                targetSignature)
                {
                    var return_v = FunctionPointerRefKindsEqual(sourceSignature, targetSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 114958, 115020);
                    return return_v;
                }


                bool
                f_10873_115025_115097(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                sourceSignature, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                targetSignature)
                {
                    var return_v = FunctionPointerCallingConventionsEqual(sourceSignature, targetSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 115025, 115097);
                    return return_v;
                }


                int
                f_10873_115447_115477(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 115447, 115477);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_115534_115560(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 115534, 115560);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_115600_115626(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 115600, 115626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_115655_115671(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 115655, 115671);
                    return return_v;
                }


                bool
                f_10873_115655_115687(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 115655, 115687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_115691_115707(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 115691, 115707);
                    return return_v;
                }


                bool
                f_10873_115691_115727(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 115691, 115727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10873_115732_115751(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 115732, 115751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_115829_115860(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 115829, 115860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_115862_115893(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 115862, 115893);
                    return return_v;
                }


                int
                f_10873_115809_115918(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 115809, 115918);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_116016_116047(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116016, 116047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_116049_116080(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116049, 116080);
                    return return_v;
                }


                int
                f_10873_116001_116105(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 116001, 116105);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_116161_116187(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116161, 116187);
                    return return_v;
                }


                bool
                f_10873_116161_116203(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116161, 116203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_116207_116233(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116207, 116233);
                    return return_v;
                }


                bool
                f_10873_116207_116253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 116207, 116253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10873_116258_116281(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116258, 116281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_116351_116392(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116351, 116392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_116394_116435(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116394, 116435);
                    return return_v;
                }


                int
                f_10873_116331_116460(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.UpperBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 116331, 116460);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_116542_116583(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116542, 116583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_116585_116626(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 116585, 116626);
                    return return_v;
                }


                int
                f_10873_116527_116651(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ExactInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 116527, 116651);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 114411, 116706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 114411, 116706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool Fix(int iParam, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 116870, 118320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 116971, 117003);

                f_10873_116971_117002(f_10873_116984_117001(this, iParam));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 117019, 117052);

                var
                exact = _exactBounds[iParam]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 117066, 117099);

                var
                lower = _lowerBounds[iParam]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 117113, 117146);

                var
                upper = _upperBounds[iParam]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 117162, 117236);

                var
                best = f_10873_117173_117235(exact, lower, upper, ref useSiteDiagnostics, _conversions)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 117250, 117329) || true) && (f_10873_117254_117267_M(!best.HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 117250, 117329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 117301, 117314);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 117250, 117329);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 117356, 118181) || true) && (_conversions.IncludeNullability)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 117356, 118181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 117595, 117645);

                    HashSet<DiagnosticInfo>
                    ignoredDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 117663, 117774);

                    var
                    withoutNullability = f_10873_117688_117773(exact, lower, upper, ref ignoredDiagnostics, f_10873_117737_117772(_conversions, false))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 118007, 118166);

                    f_10873_118007_118165(f_10873_118020_118164(best.Type, withoutNullability.Type, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 117356, 118181);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 118205, 118234);

                _fixedResults[iParam] = best;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 118248, 118283);

                f_10873_118248_118282(this, iParam);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 118297, 118309);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 116870, 118320);

                bool
                f_10873_116984_117001(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 116984, 117001);
                    return return_v;
                }


                int
                f_10873_116971_117002(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 116971, 117002);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_117173_117235(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                exact, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                lower, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                upper, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions)
                {
                    var return_v = Fix(exact, lower, upper, ref useSiteDiagnostics, conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 117173, 117235);
                    return return_v;
                }


                bool
                f_10873_117254_117267_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 117254, 117267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionsBase
                f_10873_117737_117772(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, bool
                includeNullability)
                {
                    var return_v = this_param.WithNullability(includeNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 117737, 117772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_117688_117773(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                exact, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                lower, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                upper, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions)
                {
                    var return_v = Fix(exact, lower, upper, ref useSiteDiagnostics, conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 117688, 117773);
                    return return_v;
                }


                bool
                f_10873_118020_118164(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 118020, 118164);
                    return return_v;
                }


                int
                f_10873_118007_118165(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 118007, 118165);
                    return 0;
                }


                int
                f_10873_118248_118282(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                iParam)
                {
                    this_param.UpdateDependenciesAfterFix(iParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 118248, 118282);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 116870, 118320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 116870, 118320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeWithAnnotations Fix(
            HashSet<TypeWithAnnotations> exact,
            HashSet<TypeWithAnnotations> lower,
            HashSet<TypeWithAnnotations> upper,
            ref HashSet<DiagnosticInfo> useSiteDiagnostics,
            ConversionsBase conversions)
        {
            // UNDONE: This method makes a lot of garbage.

            // SPEC: An unfixed type parameter with a set of bounds is fixed as follows:

            // SPEC: * The set of candidate types starts out as the set of all types in
            // SPEC:   the bounds.

            // SPEC: * We then examine each bound in turn. For each exact bound U of Xi,
            // SPEC:   all types which are not identical to U are removed from the candidate set.

            // Optimization: if we have two or more exact bounds, fixing is impossible.

            var candidates = new Dictionary<TypeWithAnnotations, TypeWithAnnotations>(EqualsIgnoringDynamicTupleNamesAndNullabilityComparer.Instance);

            // Optimization: if we have one exact bound then we need not add any
            // inexact bounds; we're just going to remove them anyway.

            if (exact == null)
            {
                if (lower != null)
                {
                    // Lower bounds represent co-variance.
                    AddAllCandidates(candidates, lower, VarianceKind.Out, conversions);
                }
                if (upper != null)
                {
                    // Lower bounds represent contra-variance.
                    AddAllCandidates(candidates, upper, VarianceKind.In, conversions);
                }
            }
            else
            {
                // Exact bounds represent invariance.
                AddAllCandidates(candidates, exact, VarianceKind.None, conversions);
                if (candidates.Count >= 2)
                {
                    return default;
                }
            }

            if (candidates.Count == 0)
            {
                return default;
            }

            // Don't mutate the collection as we're iterating it.
            var initialCandidates = ArrayBuilder<TypeWithAnnotations>.GetInstance();
            GetAllCandidates(candidates, initialCandidates);

            // SPEC:   For each lower bound U of Xi all types to which there is not an
            // SPEC:   implicit conversion from U are removed from the candidate set.

            if (lower != null)
            {
                MergeOrRemoveCandidates(candidates, lower, initialCandidates, conversions, VarianceKind.Out, ref useSiteDiagnostics);
            }

            // SPEC:   For each upper bound U of Xi all types from which there is not an
            // SPEC:   implicit conversion to U are removed from the candidate set.

            if (upper != null)
            {
                MergeOrRemoveCandidates(candidates, upper, initialCandidates, conversions, VarianceKind.In, ref useSiteDiagnostics);
            }

            initialCandidates.Clear();
            GetAllCandidates(candidates, initialCandidates);

            // SPEC: * If among the remaining candidate types there is a unique type V to
            // SPEC:   which there is an implicit conversion from all the other candidate
            // SPEC:   types, then the parameter is fixed to V.
            TypeWithAnnotations best = default;
            foreach (var candidate in initialCandidates)
            {
                foreach (var candidate2 in initialCandidates)
                {
                    if (!candidate.Equals(candidate2, TypeCompareKind.ConsiderEverything) &&
                        !ImplicitConversionExists(candidate2, candidate, ref useSiteDiagnostics, conversions.WithNullability(false)))
                    {
                        goto OuterBreak;
                    }
                }

                if (!best.HasType)
                {
                    best = candidate;
                }
                else
                {
                    Debug.Assert(!best.Equals(candidate, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                    // best candidate is not unique
                    best = default;
                    break;
                }

OuterBreak:
                ;
            }

            initialCandidates.Free();

            return best;
        }

        private static bool ImplicitConversionExists(TypeWithAnnotations sourceWithAnnotations, TypeWithAnnotations destinationWithAnnotations, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConversionsBase conversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 122887, 123831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 123124, 123164);

                var
                source = sourceWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 123178, 123228);

                var
                destination = destinationWithAnnotations.Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 123400, 123512) || true) && (f_10873_123404_123422(source) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 123404, 123450) && !f_10873_123427_123450(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 123400, 123512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 123484, 123497);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 123400, 123512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 123528, 123698) || true) && (!f_10873_123533_123636(conversions, sourceWithAnnotations, destinationWithAnnotations))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 123528, 123698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 123670, 123683);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 123528, 123698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 123714, 123820);

                return f_10873_123721_123812(conversions, source, destination, ref useSiteDiagnostics).Exists;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 122887, 123831);

                bool
                f_10873_123404_123422(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 123404, 123422);
                    return return_v;
                }


                bool
                f_10873_123427_123450(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 123427, 123450);
                    return return_v;
                }


                bool
                f_10873_123533_123636(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination)
                {
                    var return_v = this_param.HasTopLevelNullabilityImplicitConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 123533, 123636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10873_123721_123812(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 123721, 123812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 122887, 123831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 122887, 123831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations InferReturnType(BoundExpression source, NamedTypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 123990, 128723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 124154, 124191);

                f_10873_124154_124190((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 124205, 124243);

                f_10873_124205_124242(f_10873_124218_124241(target));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 124257, 124452);

                f_10873_124257_124451((object)f_10873_124278_124305(target) != null && (DynAbs.Tracing.TraceSender.Expression_True(10873, 124270, 124361) && f_10873_124317_124361_M(!f_10873_124318_124345(target).HasUseSiteError)), "This method should only be called for legal delegate types.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 124466, 124521);

                f_10873_124466_124520(f_10873_124479_124519_M(!f_10873_124480_124507(target).ReturnsVoid));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 124702, 124760);

                f_10873_124702_124759(!f_10873_124716_124758(this, source, target));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 125814, 125920) || true) && (f_10873_125818_125829(source) != BoundKind.UnboundLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 125814, 125920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 125890, 125905);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 125814, 125920);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 125936, 125982);

                var
                anonymousFunction = (UnboundLambda)source
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 125996, 127014) || true) && (f_10873_126000_126030(anonymousFunction))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 125996, 127014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 126635, 126696);

                    var
                    originalDelegateParameters = f_10873_126668_126695(target)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 126714, 126830) || true) && (originalDelegateParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 126714, 126830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 126796, 126811);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 126714, 126830);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 126850, 126999) || true) && (originalDelegateParameters.Length != f_10873_126891_126923(anonymousFunction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 126850, 126999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 126965, 126980);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 126850, 126999);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 125996, 127014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 127030, 127109);

                var
                fixedDelegate = (NamedTypeSymbol)f_10873_127067_127108(this, target)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 127123, 127188);

                var
                fixedDelegateParameters = f_10873_127153_127187(fixedDelegate)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 127569, 128059) || true) && (f_10873_127573_127622(anonymousFunction))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 127569, 128059);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 127665, 127670);
                        for (int
        p = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 127656, 128044) || true) && (p < f_10873_127676_127708(anonymousFunction))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 127710, 127713)
        , ++p, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 127656, 128044))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 127656, 128044);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 127755, 128025) || true) && (!f_10873_127760_127937(f_10873_127760_127794(anonymousFunction, p), f_10873_127802_127833(fixedDelegateParameters[p]), TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 127755, 128025);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 127987, 128002);

                                return default;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 127755, 128025);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 389);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 389);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 127569, 128059);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 128618, 128712);

                return f_10873_128625_128711(anonymousFunction, _conversions, fixedDelegate, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 123990, 128723);

                int
                f_10873_124154_124190(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 124154, 124190);
                    return 0;
                }


                bool
                f_10873_124218_124241(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 124218, 124241);
                    return return_v;
                }


                int
                f_10873_124205_124242(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 124205, 124242);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10873_124278_124305(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 124278, 124305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10873_124318_124345(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 124318, 124345);
                    return return_v;
                }


                bool
                f_10873_124317_124361_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 124317, 124361);
                    return return_v;
                }


                int
                f_10873_124257_124451(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 124257, 124451);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10873_124480_124507(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 124480, 124507);
                    return return_v;
                }


                bool
                f_10873_124479_124519_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 124479, 124519);
                    return return_v;
                }


                int
                f_10873_124466_124520(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 124466, 124520);
                    return 0;
                }


                bool
                f_10873_124716_124758(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                pSource, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                pDest)
                {
                    var return_v = this_param.HasUnfixedParamInInputType(pSource, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)pDest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 124716, 124758);
                    return return_v;
                }


                int
                f_10873_124702_124759(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 124702, 124759);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10873_125818_125829(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 125818, 125829);
                    return return_v;
                }


                bool
                f_10873_126000_126030(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.HasSignature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 126000, 126030);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_126668_126695(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.DelegateParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 126668, 126695);
                    return return_v;
                }


                int
                f_10873_126891_126923(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 126891, 126923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_127067_127108(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateOrFunctionPointerType)
                {
                    var return_v = this_param.GetFixedDelegateOrFunctionPointer((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)delegateOrFunctionPointerType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 127067, 127108);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10873_127153_127187(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.DelegateParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 127153, 127187);
                    return return_v;
                }


                bool
                f_10873_127573_127622(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.HasExplicitlyTypedParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 127573, 127622);
                    return return_v;
                }


                int
                f_10873_127676_127708(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 127676, 127708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_127760_127794(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 127760, 127794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_127802_127833(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 127802, 127833);
                    return return_v;
                }


                bool
                f_10873_127760_127937(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 127760, 127937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_128625_128711(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.InferReturnType(conversions, delegateType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 128625, 128711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 123990, 128723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 123990, 128723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static NamedTypeSymbol GetInterfaceInferenceBound(ImmutableArray<NamedTypeSymbol> interfaces, NamedTypeSymbol target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 128987, 129967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 129137, 129170);

                f_10873_129137_129169(f_10873_129150_129168(target));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 129184, 129225);

                NamedTypeSymbol
                matchingInterface = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 129239, 129917);
                    foreach (var currentInterface in f_10873_129272_129282_I(interfaces))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 129239, 129917);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 129316, 129902) || true) && (f_10873_129320_129437(f_10873_129338_129373(currentInterface), f_10873_129375_129400(target), TypeCompareKind.ConsiderEverything))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 129316, 129902);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 129479, 129883) || true) && ((object)matchingInterface == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 129479, 129883);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 129566, 129603);

                                matchingInterface = currentInterface;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 129479, 129883);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 129479, 129883);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 129653, 129883) || true) && (!f_10873_129658_129748(matchingInterface, currentInterface, TypeCompareKind.ConsiderEverything))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 129653, 129883);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 129848, 129860);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 129653, 129883);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 129479, 129883);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 129316, 129902);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 129239, 129917);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 129931, 129956);

                return matchingInterface;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 128987, 129967);

                bool
                f_10873_129150_129168(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 129150, 129168);
                    return return_v;
                }


                int
                f_10873_129137_129169(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 129137, 129169);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_129338_129373(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 129338, 129373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_129375_129400(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 129375, 129400);
                    return return_v;
                }


                bool
                f_10873_129320_129437(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 129320, 129437);
                    return return_v;
                }


                bool
                f_10873_129658_129748(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 129658, 129748);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10873_129272_129282_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 129272, 129282);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 128987, 129967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 128987, 129967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TypeWithAnnotations> InferTypeArgumentsFromFirstArgument(
                    ConversionsBase conversions,
                    MethodSymbol method,
                    ImmutableArray<BoundExpression> arguments,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 131103, 132571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 131407, 131444);

                f_10873_131407_131443((object)method != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 131458, 131489);

                f_10873_131458_131488(f_10873_131471_131483(method) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 131503, 131538);

                f_10873_131503_131537(f_10873_131516_131536_M(!arguments.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 131640, 131798) || true) && ((f_10873_131645_131666(method) < 1) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 131644, 131697) || (arguments.Length < 1)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 131640, 131798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 131731, 131783);

                    return default(ImmutableArray<TypeWithAnnotations>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 131640, 131798);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 131814, 131868);

                f_10873_131814_131867(!f_10873_131828_131866(f_10873_131828_131854(method, 0)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 131884, 131935);

                var
                constructedFromMethod = f_10873_131912_131934(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 131951, 132311);

                var
                inferrer = f_10873_131966_132310(conversions, f_10873_132037_132073(constructedFromMethod), f_10873_132092_132128(constructedFromMethod), f_10873_132147_132188(constructedFromMethod), f_10873_132207_132246(constructedFromMethod), arguments, extensions: null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 132327, 132501) || true) && (!f_10873_132332_132400(inferrer, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 132327, 132501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 132434, 132486);

                    return default(ImmutableArray<TypeWithAnnotations>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 132327, 132501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 132517, 132560);

                return f_10873_132524_132559(inferrer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 131103, 132571);

                int
                f_10873_131407_131443(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 131407, 131443);
                    return 0;
                }


                int
                f_10873_131471_131483(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 131471, 131483);
                    return return_v;
                }


                int
                f_10873_131458_131488(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 131458, 131488);
                    return 0;
                }


                bool
                f_10873_131516_131536_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 131516, 131536);
                    return return_v;
                }


                int
                f_10873_131503_131537(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 131503, 131537);
                    return 0;
                }


                int
                f_10873_131645_131666(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 131645, 131666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10873_131828_131854(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 131828, 131854);
                    return return_v;
                }


                bool
                f_10873_131828_131866(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 131828, 131866);
                    return return_v;
                }


                int
                f_10873_131814_131867(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 131814, 131867);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10873_131912_131934(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 131912, 131934);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10873_132037_132073(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 132037, 132073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10873_132092_132128(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 132092, 132128);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_132147_132188(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.GetParameterTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 132147, 132188);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10873_132207_132246(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 132207, 132246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                f_10873_131966_132310(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                methodTypeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                constructedContainingTypeOfMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                formalParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                formalParameterRefKinds, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.Extensions
                extensions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer(conversions, methodTypeParameters, constructedContainingTypeOfMethod, formalParameterTypes, formalParameterRefKinds, arguments, extensions: extensions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 131966, 132310);
                    return return_v;
                }


                bool
                f_10873_132332_132400(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.InferTypeArgumentsFromFirstArgument(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 132332, 132400);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_132524_132559(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param)
                {
                    var return_v = this_param.GetInferredTypeArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 132524, 132559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 131103, 132571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 131103, 132571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool InferTypeArgumentsFromFirstArgument(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 132675, 134115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 132796, 132843);

                f_10873_132796_132842(f_10873_132809_132841_M(!_formalParameterTypes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 132857, 132905);

                f_10873_132857_132904(_formalParameterTypes.Length >= 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 132919, 132955);

                f_10873_132919_132954(f_10873_132932_132953_M(!_arguments.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 132969, 133006);

                f_10873_132969_133005(_arguments.Length >= 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133020, 133056);

                var
                dest = _formalParameterTypes[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133070, 133099);

                var
                argument = _arguments[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133113, 133147);

                TypeSymbol
                source = f_10873_133133_133146(argument)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133213, 133301) || true) && (!f_10873_133218_133239(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 133213, 133301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133273, 133286);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 133213, 133301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133315, 133411);

                f_10873_133315_133410(this, f_10873_133335_133379(_extensions, argument), dest, ref useSiteDiagnostics);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133576, 133586);
                    // Now check to see that every type parameter used by the first
                    // formal parameter type was successfully inferred.
                    for (int
        iParam = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133567, 134078) || true) && (iParam < _methodTypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133627, 133635)
        , ++iParam, DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 133567, 134078))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 133567, 134078);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133669, 133728);

                        TypeParameterSymbol
                        pParam = _methodTypeParameters[iParam]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133746, 133860) || true) && (!f_10873_133751_133790(dest.Type, pParam))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 133746, 133860);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133832, 133841);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 133746, 133860);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133878, 133910);

                        f_10873_133878_133909(f_10873_133891_133908(this, iParam));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 133928, 134063) || true) && (!f_10873_133933_133949(this, iParam) || (DynAbs.Tracing.TraceSender.Expression_False(10873, 133932, 133989) || !f_10873_133954_133989(this, iParam, ref useSiteDiagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 133928, 134063);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 134031, 134044);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 133928, 134063);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 512);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 134092, 134104);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 132675, 134115);

                bool
                f_10873_132809_132841_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 132809, 132841);
                    return return_v;
                }


                int
                f_10873_132796_132842(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 132796, 132842);
                    return 0;
                }


                int
                f_10873_132857_132904(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 132857, 132904);
                    return 0;
                }


                bool
                f_10873_132932_132953_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 132932, 132953);
                    return return_v;
                }


                int
                f_10873_132919_132954(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 132919, 132954);
                    return 0;
                }


                int
                f_10873_132969_133005(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 132969, 133005);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10873_133133_133146(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 133133, 133146);
                    return return_v;
                }


                bool
                f_10873_133218_133239(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = IsReallyAType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 133218, 133239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10873_133335_133379(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.Extensions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.GetTypeWithAnnotations(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 133335, 133379);
                    return return_v;
                }


                int
                f_10873_133315_133410(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LowerBoundInference(source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 133315, 133410);
                    return 0;
                }


                bool
                f_10873_133751_133790(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                parameter)
                {
                    var return_v = type.ContainsTypeParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 133751, 133790);
                    return return_v;
                }


                bool
                f_10873_133891_133908(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.IsUnfixed(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 133891, 133908);
                    return return_v;
                }


                int
                f_10873_133878_133909(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 133878, 133909);
                    return 0;
                }


                bool
                f_10873_133933_133949(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                methodTypeParameterIndex)
                {
                    var return_v = this_param.HasBound(methodTypeParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 133933, 133949);
                    return return_v;
                }


                bool
                f_10873_133954_133989(Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer
                this_param, int
                iParam, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.Fix(iParam, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 133954, 133989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 132675, 134115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 132675, 134115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeWithAnnotations> GetInferredTypeArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 134293, 134434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 134388, 134423);

                return f_10873_134395_134422(_fixedResults);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 134293, 134434);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_134395_134422(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations[]
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 134395, 134422);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 134293, 134434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 134293, 134434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsReallyAType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 134446, 134639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 134521, 134628);

                return (object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10873, 134528, 134588) && !f_10873_134570_134588(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10873, 134528, 134627) && !f_10873_134610_134627(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 134446, 134639);

                bool
                f_10873_134570_134588(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 134570, 134588);
                    return return_v;
                }


                bool
                f_10873_134610_134627(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 134610, 134627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 134446, 134639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 134446, 134639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetAllCandidates(Dictionary<TypeWithAnnotations, TypeWithAnnotations> candidates, ArrayBuilder<TypeWithAnnotations> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 134651, 134867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 134820, 134856);

                f_10873_134820_134855(builder, f_10873_134837_134854(candidates));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 134651, 134867);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>.ValueCollection
                f_10873_134837_134854(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10873, 134837, 134854);
                    return return_v;
                }


                int
                f_10873_134820_134855(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>.ValueCollection
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 134820, 134855);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 134651, 134867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 134651, 134867);
            }
        }

        private static void AddAllCandidates(
                    Dictionary<TypeWithAnnotations, TypeWithAnnotations> candidates,
                    HashSet<TypeWithAnnotations> bounds,
                    VarianceKind variance,
                    ConversionsBase conversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 134879, 135671);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 135147, 135660);
                    foreach (var candidate in f_10873_135173_135179_I(bounds))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 135147, 135660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 135213, 135234);

                        var
                        type = candidate
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 135252, 135564) || true) && (!conversions.IncludeNullability)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 135252, 135564);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 135492, 135545);

                            type = type.SetUnknownNullabilityForReferenceTypes();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 135252, 135564);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 135584, 135645);

                        f_10873_135584_135644(candidates, type, variance, conversions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 135147, 135660);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 514);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 134879, 135671);

                int
                f_10873_135584_135644(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                candidates, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newCandidate, Microsoft.CodeAnalysis.VarianceKind
                variance, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions)
                {
                    AddOrMergeCandidate(candidates, newCandidate, variance, conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 135584, 135644);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_135173_135179_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 135173, 135179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 134879, 135671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 134879, 135671);
            }
        }

        private static void AddOrMergeCandidate(
                    Dictionary<TypeWithAnnotations, TypeWithAnnotations> candidates,
                    TypeWithAnnotations newCandidate,
                    VarianceKind variance,
                    ConversionsBase conversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 135683, 136485);
                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations oldCandidate = default(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 135951, 136127);

                f_10873_135951_136126(conversions.IncludeNullability || (DynAbs.Tracing.TraceSender.Expression_False(10873, 135964, 136125) || newCandidate.SetUnknownNullabilityForReferenceTypes().Equals(newCandidate, TypeCompareKind.ConsiderEverything)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 136143, 136474) || true) && (f_10873_136147_136221(candidates, newCandidate, out oldCandidate))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 136143, 136474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 136255, 136350);

                    f_10873_136255_136349(candidates, oldCandidate, newCandidate, variance, conversions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 136143, 136474);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 136143, 136474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 136416, 136459);

                    f_10873_136416_136458(candidates, newCandidate, newCandidate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 136143, 136474);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 135683, 136485);

                int
                f_10873_135951_136126(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 135951, 136126);
                    return 0;
                }


                bool
                f_10873_136147_136221(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 136147, 136221);
                    return return_v;
                }


                int
                f_10873_136255_136349(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                candidates, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                oldCandidate, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newCandidate, Microsoft.CodeAnalysis.VarianceKind
                variance, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions)
                {
                    MergeAndReplaceIfStillCandidate(candidates, oldCandidate, newCandidate, variance, conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 136255, 136349);
                    return 0;
                }


                int
                f_10873_136416_136458(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                key, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 136416, 136458);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 135683, 136485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 135683, 136485);
            }
        }

        private static void MergeOrRemoveCandidates(
                    Dictionary<TypeWithAnnotations, TypeWithAnnotations> candidates,
                    HashSet<TypeWithAnnotations> bounds,
                    ArrayBuilder<TypeWithAnnotations> initialCandidates,
                    ConversionsBase conversions,
                    VarianceKind variance,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 136497, 139823);
                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations oldBound = default(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 136899, 136973);

                f_10873_136899_136972(variance == VarianceKind.In || (DynAbs.Tracing.TraceSender.Expression_False(10873, 136912, 136971) || variance == VarianceKind.Out));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137175, 137319);

                var
                comparison = (DynAbs.Tracing.TraceSender.Conditional_F1(10873, 137192, 137222) || ((conversions.IncludeNullability && DynAbs.Tracing.TraceSender.Conditional_F2(10873, 137225, 137259)) || DynAbs.Tracing.TraceSender.Conditional_F3(10873, 137262, 137318))) ? TypeCompareKind.ConsiderEverything : TypeCompareKind.IgnoreNullableModifiersForReferenceTypes
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137333, 139812);
                    foreach (var bound in f_10873_137355_137361_I(bounds))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 137333, 139812);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137395, 139797);
                            foreach (var candidate in f_10873_137421_137438_I(initialCandidates))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 137395, 139797);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137480, 137601) || true) && (bound.Equals(candidate, comparison))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 137480, 137601);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137569, 137578);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 137480, 137601);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137623, 137650);

                                TypeWithAnnotations
                                source
                                = default(TypeWithAnnotations);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137672, 137704);

                                TypeWithAnnotations
                                destination
                                = default(TypeWithAnnotations);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137726, 138059) || true) && (variance == VarianceKind.Out)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 137726, 138059);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137808, 137823);

                                    source = bound;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137849, 137873);

                                    destination = candidate;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 137726, 138059);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 137726, 138059);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 137971, 137990);

                                    source = candidate;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 138016, 138036);

                                    destination = bound;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 137726, 138059);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 138081, 139778) || true) && (!f_10873_138086_138191(source, destination, ref useSiteDiagnostics, f_10873_138156_138190(conversions, false)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 138081, 139778);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 138241, 138270);

                                    f_10873_138241_138269(candidates, candidate);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 138296, 139018) || true) && (conversions.IncludeNullability && (DynAbs.Tracing.TraceSender.Expression_True(10873, 138300, 138381) && f_10873_138334_138381(candidates, bound, out oldBound)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 138296, 139018);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 138519, 138567);

                                        var
                                        oldAnnotation = oldBound.NullableAnnotation
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 138597, 138695);

                                        var
                                        newAnnotation = f_10873_138617_138694(oldAnnotation, candidate.NullableAnnotation, variance)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 138725, 138991) || true) && (oldAnnotation != newAnnotation)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 138725, 138991);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 138825, 138897);

                                            var
                                            newBound = TypeWithAnnotations.Create(oldBound.Type, newAnnotation)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 138931, 138960);

                                            candidates[bound] = newBound;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 138725, 138991);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 138296, 139018);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 138081, 139778);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 138081, 139778);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 139068, 139778) || true) && (bound.Equals(candidate, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 139068, 139778);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 139670, 139755);

                                        f_10873_139670_139754(candidates, candidate, bound, variance, conversions);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 139068, 139778);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 138081, 139778);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 137395, 139797);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 2403);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 2403);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 137333, 139812);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10873, 1, 2480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10873, 1, 2480);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 136497, 139823);

                int
                f_10873_136899_136972(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 136899, 136972);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionsBase
                f_10873_138156_138190(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, bool
                includeNullability)
                {
                    var return_v = this_param.WithNullability(includeNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 138156, 138190);
                    return return_v;
                }


                bool
                f_10873_138086_138191(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                sourceWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destinationWithAnnotations, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions)
                {
                    var return_v = ImplicitConversionExists(sourceWithAnnotations, destinationWithAnnotations, ref useSiteDiagnostics, conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 138086, 138191);
                    return return_v;
                }


                bool
                f_10873_138241_138269(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 138241, 138269);
                    return return_v;
                }


                bool
                f_10873_138334_138381(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 138334, 138381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                f_10873_138617_138694(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                a, Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                b, Microsoft.CodeAnalysis.VarianceKind
                variance)
                {
                    var return_v = a.MergeNullableAnnotation(b, variance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 138617, 138694);
                    return return_v;
                }


                int
                f_10873_139670_139754(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                candidates, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                oldCandidate, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newCandidate, Microsoft.CodeAnalysis.VarianceKind
                variance, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions)
                {
                    MergeAndReplaceIfStillCandidate(candidates, oldCandidate, newCandidate, variance, conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 139670, 139754);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_137421_137438_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 137421, 137438);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10873_137355_137361_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 137355, 137361);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 136497, 139823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 136497, 139823);
            }
        }

        private static void MergeAndReplaceIfStillCandidate(
                    Dictionary<TypeWithAnnotations, TypeWithAnnotations> candidates,
                    TypeWithAnnotations oldCandidate,
                    TypeWithAnnotations newCandidate,
                    VarianceKind variance,
                    ConversionsBase conversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10873, 139835, 141633);
                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations latest = default(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 140259, 140348) || true) && (f_10873_140263_140292(newCandidate.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 140259, 140348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 140326, 140333);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 140259, 140348);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 140364, 141622) || true) && (f_10873_140368_140436(candidates, oldCandidate, out latest))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 140364, 141622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 141474, 141555);

                    TypeWithAnnotations
                    merged = latest.MergeEquivalentTypes(newCandidate, variance)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 141573, 141607);

                    candidates[oldCandidate] = merged;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 140364, 141622);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10873, 139835, 141633);

                bool
                f_10873_140263_140292(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 140263, 140292);
                    return return_v;
                }


                bool
                f_10873_140368_140436(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 140368, 140436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 139835, 141633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 139835, 141633);
            }
        }
        private sealed class EqualsIgnoringDynamicTupleNamesAndNullabilityComparer : EqualityComparer<TypeWithAnnotations>
        {
            internal static readonly EqualsIgnoringDynamicTupleNamesAndNullabilityComparer Instance;

            public override int GetHashCode(TypeWithAnnotations obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 142197, 142331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 142286, 142316);

                    return f_10873_142293_142315(obj.Type);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 142197, 142331);

                    int
                    f_10873_142293_142315(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 142293, 142315);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 142197, 142331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 142197, 142331);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(TypeWithAnnotations x, TypeWithAnnotations y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10873, 142347, 142857);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 142638, 142700) || true) && (f_10873_142642_142660(x.Type) ^ f_10873_142663_142681(y.Type))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10873, 142638, 142700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 142685, 142698);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10873, 142638, 142700);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 142720, 142842);

                    return x.Equals(y, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10873, 142347, 142857);

                    bool
                    f_10873_142642_142660(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsDynamic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 142642, 142660);
                        return return_v;
                    }


                    bool
                    f_10873_142663_142681(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsDynamic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 142663, 142681);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10873, 142347, 142857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 142347, 142857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualsIgnoringDynamicTupleNamesAndNullabilityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10873, 141892, 142868);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10873, 141892, 142868);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 141892, 142868);
            }


            static EqualsIgnoringDynamicTupleNamesAndNullabilityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10873, 141892, 142868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10873, 142110, 142180);
                Instance = f_10873_142121_142180(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10873, 141892, 142868);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 141892, 142868);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10873, 141892, 142868);

            static Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.EqualsIgnoringDynamicTupleNamesAndNullabilityComparer
            f_10873_142121_142180()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.MethodTypeInferrer.EqualsIgnoringDynamicTupleNamesAndNullabilityComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 142121, 142180);
                return return_v;
            }

        }

        static MethodTypeInferrer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10873, 3796, 142875);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10873, 3796, 142875);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10873, 3796, 142875);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10873, 3796, 142875);

        int
        f_10873_6311_6375(int
        val1, int
        val2)
        {
            var return_v = System.Math.Min(val1, val2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10873, 6311, 6375);
            return return_v;
        }

    }
}

