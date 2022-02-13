// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal abstract class MethodReference : TypeMemberReference, Cci.IMethodReference
    {
        protected readonly MethodSymbol UnderlyingMethod;

        public MethodReference(MethodSymbol underlyingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10193, 626, 819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 597, 613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 704, 751);

                f_10193_704_750((object)underlyingMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 767, 808);

                this.UnderlyingMethod = underlyingMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10193, 626, 819);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 626, 819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 626, 819);
            }
        }

        protected override Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 898, 973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 934, 958);

                    return UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 898, 973);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 831, 984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 831, 984);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodReference.AcceptsExtraArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 1068, 1152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 1104, 1137);

                    return f_10193_1111_1136(UnderlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 1068, 1152);

                    bool
                    f_10193_1111_1136(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10193, 1111, 1136);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 996, 1163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 996, 1163);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.IMethodReference.GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 1249, 1338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 1285, 1323);

                    return (ushort)f_10193_1300_1322(UnderlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 1249, 1338);

                    int
                    f_10193_1300_1322(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10193, 1300, 1322);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 1175, 1349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 1175, 1349);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodReference.IsGeneric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 1421, 1512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 1457, 1497);

                    return f_10193_1464_1496(UnderlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 1421, 1512);

                    bool
                    f_10193_1464_1496(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGenericMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10193, 1464, 1496);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 1361, 1523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 1361, 1523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.ISignature.ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 1596, 1694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 1632, 1679);

                    return (ushort)f_10193_1647_1678(UnderlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 1596, 1694);

                    int
                    f_10193_1647_1678(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10193, 1647, 1678);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 1535, 1705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 1535, 1705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMethodDefinition Cci.IMethodReference.GetResolvedMethod(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 1717, 1846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 1823, 1835);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 1717, 1846);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 1717, 1846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 1717, 1846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Cci.IParameterTypeInformation> Cci.IMethodReference.ExtraParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 1965, 2075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 2001, 2060);

                    return ImmutableArray<Cci.IParameterTypeInformation>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 1965, 2075);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 1858, 2086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 1858, 2086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.CallingConvention Cci.ISignature.CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 2177, 2270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 2213, 2255);

                    return f_10193_2220_2254(UnderlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 2177, 2270);

                    Microsoft.Cci.CallingConvention
                    f_10193_2220_2254(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10193, 2220, 2254);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 2098, 2281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 2098, 2281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.IParameterTypeInformation> Cci.ISignature.GetParameters(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 2293, 2568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 2413, 2480);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 2494, 2557);

                return f_10193_2501_2556(moduleBeingBuilt, f_10193_2528_2555(UnderlyingMethod));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 2293, 2568);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10193_2528_2555(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10193, 2528, 2555);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_10193_2501_2556(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                @params)
                {
                    var return_v = this_param.Translate(@params);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10193, 2501, 2556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 2293, 2568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 2293, 2568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Cci.ICustomModifier> Cci.ISignature.ReturnValueCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 2682, 2843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 2718, 2828);

                    return ImmutableArray<Cci.ICustomModifier>.CastUp(UnderlyingMethod.ReturnTypeWithAnnotations.CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 2682, 2843);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 2580, 2854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 2580, 2854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ICustomModifier> Cci.ISignature.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 2960, 3098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 2996, 3083);

                    return ImmutableArray<Cci.ICustomModifier>.CastUp(f_10193_3046_3081(UnderlyingMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 2960, 3098);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10193_3046_3081(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10193, 3046, 3081);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 2866, 3109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 2866, 3109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ISignature.ReturnValueIsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 3184, 3288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 3220, 3273);

                    return f_10193_3227_3272(f_10193_3227_3251(UnderlyingMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 3184, 3288);

                    Microsoft.CodeAnalysis.RefKind
                    f_10193_3227_3251(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10193, 3227, 3251);
                        return return_v;
                    }


                    bool
                    f_10193_3227_3272(Microsoft.CodeAnalysis.RefKind
                    refKind)
                    {
                        var return_v = refKind.IsManagedReference();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10193, 3227, 3272);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 3121, 3299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 3121, 3299);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.ISignature.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 3311, 3579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 3398, 3568);

                return f_10193_3405_3567(((PEModuleBuilder)context.Module), f_10193_3449_3476(UnderlyingMethod), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 3311, 3579);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10193_3449_3476(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10193, 3449, 3476);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10193_3405_3567(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10193, 3405, 3567);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 3311, 3579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 3311, 3579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual Cci.IGenericMethodInstanceReference AsGenericMethodInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 3699, 3762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 3735, 3747);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 3699, 3762);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 3591, 3773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 3591, 3773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual Cci.ISpecializedMethodReference AsSpecializedMethodReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10193, 3885, 3948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10193, 3921, 3933);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10193, 3885, 3948);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10193, 3785, 3959);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 3785, 3959);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static MethodReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10193, 465, 3966);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10193, 465, 3966);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10193, 465, 3966);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10193, 465, 3966);

        int
        f_10193_704_750(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10193, 704, 750);
            return 0;
        }

    }
}
