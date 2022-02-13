// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class SynthesizedStateMachineMethod : SynthesizedImplementationMethod, ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly bool _hasMethodBodyDependency;

        protected SynthesizedStateMachineMethod(
                    string name,
                    MethodSymbol interfaceMethod,
                    StateMachineTypeSymbol stateMachineType,
                    PropertySymbol associatedProperty,
                    bool generateDebugInfo,
                    bool hasMethodBodyDependency)
        : base(f_10545_1145_1160_C(interfaceMethod), stateMachineType, name, generateDebugInfo, associatedProperty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10545, 833, 1311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 796, 820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 1249, 1300);

                _hasMethodBodyDependency = hasMethodBodyDependency;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10545, 833, 1311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10545, 833, 1311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 833, 1311);
            }
        }

        public StateMachineTypeSymbol StateMachineType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10545, 1394, 1450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 1400, 1448);

                    return (StateMachineTypeSymbol)f_10545_1431_1447();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10545, 1394, 1450);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10545_1431_1447()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10545, 1431, 1447);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10545, 1323, 1461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 1323, 1461);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10545, 1533, 1573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 1539, 1571);

                    return _hasMethodBodyDependency;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10545, 1533, 1573);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10545, 1473, 1584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 1473, 1584);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10545, 1692, 1738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 1698, 1736);

                    return f_10545_1705_1721().KickoffMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10545, 1692, 1738);

                    Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                    f_10545_1705_1721()
                    {
                        var return_v = StateMachineType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10545, 1705, 1721);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10545, 1596, 1749);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 1596, 1749);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10545, 1761, 1982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 1875, 1971);

                return f_10545_1882_1970(f_10545_1882_1903(this).KickoffMethod, localPosition, localTree);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10545, 1761, 1982);

                Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                f_10545_1882_1903(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                this_param)
                {
                    var return_v = this_param.StateMachineType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10545, 1882, 1903);
                    return return_v;
                }


                int
                f_10545_1882_1970(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                localPosition, Microsoft.CodeAnalysis.SyntaxTree
                localTree)
                {
                    var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 1882, 1970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10545, 1761, 1982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 1761, 1982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedStateMachineMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10545, 626, 1989);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10545, 626, 1989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 626, 1989);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10545, 626, 1989);

        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10545_1145_1160_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10545, 833, 1311);
            return return_v;
        }

    }
    internal sealed class SynthesizedStateMachineMoveNextMethod : SynthesizedStateMachineMethod
    {
        private ImmutableArray<CSharpAttributeData> _attributes;

        public SynthesizedStateMachineMoveNextMethod(MethodSymbol interfaceMethod, StateMachineTypeSymbol stateMachineType)
        : base(f_10545_2510_2549_C(WellKnownMemberNames.MoveNextMethodName), interfaceMethod, stateMachineType, null, generateDebugInfo: true, hasMethodBodyDependency: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10545, 2374, 2669);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10545, 2374, 2669);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10545, 2374, 2669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 2374, 2669);
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10545, 2681, 4443);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 2773, 4397) || true) && (_attributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10545, 2773, 4397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 2832, 2879);

                    f_10545_2832_2878(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetAttributes(), 10545, 2845, 2865).Length == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 2899, 2948);

                    ArrayBuilder<CSharpAttributeData>
                    builder = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 3036, 3087);

                    var
                    kickoffMethod = f_10545_3056_3072().KickoffMethod
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 3105, 4029);
                        foreach (var attribute in f_10545_3131_3160_I(f_10545_3131_3160(kickoffMethod)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10545, 3105, 4029);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 3202, 4010) || true) && (f_10545_3206_3294(attribute, kickoffMethod, AttributeDescription.DebuggerHiddenAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10545, 3206, 3416) || f_10545_3323_3416(attribute, kickoffMethod, AttributeDescription.DebuggerNonUserCodeAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10545, 3206, 3542) || f_10545_3445_3542(attribute, kickoffMethod, AttributeDescription.DebuggerStepperBoundaryAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10545, 3206, 3664) || f_10545_3571_3664(attribute, kickoffMethod, AttributeDescription.DebuggerStepThroughAttribute)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10545, 3202, 4010);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 3714, 3936) || true) && (builder == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10545, 3714, 3936);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 3791, 3850);

                                    builder = f_10545_3801_3849(4);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10545, 3714, 3936);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 3964, 3987);

                                f_10545_3964_3986(
                                                        builder, attribute);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10545, 3202, 4010);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10545, 3105, 4029);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10545, 1, 925);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10545, 1, 925);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 4049, 4382);

                    f_10545_4049_4381(ref _attributes, (DynAbs.Tracing.TraceSender.Conditional_F1(10545, 4179, 4194) || ((builder == null && DynAbs.Tracing.TraceSender.Conditional_F2(10545, 4197, 4238)) || DynAbs.Tracing.TraceSender.Conditional_F3(10545, 4241, 4269))) ? ImmutableArray<CSharpAttributeData>.Empty : f_10545_4241_4269(builder), default(ImmutableArray<CSharpAttributeData>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10545, 2773, 4397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 4413, 4432);

                return _attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10545, 2681, 4443);

                int
                f_10545_2832_2878(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 2832, 2878);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                f_10545_3056_3072()
                {
                    var return_v = StateMachineType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10545, 3056, 3072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10545_3131_3160(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 3131, 3160);
                    return return_v;
                }


                bool
                f_10545_3206_3294(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 3206, 3294);
                    return return_v;
                }


                bool
                f_10545_3323_3416(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 3323, 3416);
                    return return_v;
                }


                bool
                f_10545_3445_3542(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 3445, 3542);
                    return return_v;
                }


                bool
                f_10545_3571_3664(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 3571, 3664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10545_3801_3849(int
                capacity)
                {
                    var return_v = ArrayBuilder<CSharpAttributeData>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 3801, 3849);
                    return return_v;
                }


                int
                f_10545_3964_3986(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 3964, 3986);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10545_3131_3160_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 3131, 3160);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10545_4241_4269(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 4241, 4269);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10545_4049_4381(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 4049, 4381);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10545, 2681, 4443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 2681, 4443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedStateMachineMoveNextMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10545, 2198, 4450);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10545, 2198, 4450);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 2198, 4450);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10545, 2198, 4450);

        static string
        f_10545_2510_2549_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10545, 2374, 2669);
            return return_v;
        }

    }
    internal sealed class SynthesizedStateMachineDebuggerHiddenMethod : SynthesizedStateMachineMethod
    {
        public SynthesizedStateMachineDebuggerHiddenMethod(
                    string name,
                    MethodSymbol interfaceMethod,
                    StateMachineTypeSymbol stateMachineType,
                    PropertySymbol associatedProperty,
                    bool hasMethodBodyDependency)
        : base(f_10545_5029_5033_C(name), interfaceMethod, stateMachineType, associatedProperty, generateDebugInfo: false, hasMethodBodyDependency: hasMethodBodyDependency)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10545, 4743, 5187);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10545, 4743, 5187);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10545, 4743, 5187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 4743, 5187);
            }
        }

        internal sealed override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10545, 5199, 5652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 5364, 5408);

                var
                compilation = f_10545_5382_5407(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 5422, 5564);

                f_10545_5422_5563(ref attributes, f_10545_5462_5562(compilation, WellKnownMember.System_Diagnostics_DebuggerHiddenAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10545, 5580, 5641);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10545, 5580, 5640);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 5580, 5640);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10545, 5199, 5652);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10545_5382_5407(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineDebuggerHiddenMethod
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10545, 5382, 5407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10545_5462_5562(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 5462, 5562);
                    return return_v;
                }


                int
                f_10545_5422_5563(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10545, 5422, 5563);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10545, 5199, 5652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 5199, 5652);
            }
        }

        static SynthesizedStateMachineDebuggerHiddenMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10545, 4629, 5659);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10545, 4629, 5659);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10545, 4629, 5659);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10545, 4629, 5659);

        static string
        f_10545_5029_5033_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10545, 4743, 5187);
            return return_v;
        }

    }
}
