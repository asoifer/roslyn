// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedMethodBaseSymbol : SourceMemberMethodSymbol
    {
        protected readonly MethodSymbol BaseMethod;

        internal TypeMap TypeMap { get; private set; }

        private readonly string _name;

        private ImmutableArray<TypeParameterSymbol> _typeParameters;

        private ImmutableArray<ParameterSymbol> _parameters;

        private TypeWithAnnotations.Boxed _iteratorElementType;

        protected SynthesizedMethodBaseSymbol(NamedTypeSymbol containingType,
                                                      MethodSymbol baseMethod,
                                                      SyntaxReference syntaxReference,
                                                      Location location,
                                                      string name,
                                                      DeclarationModifiers declarationModifiers)
        : base(f_10438_1637_1651_C(containingType), syntaxReference, location, isIterator: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10438, 1179, 2257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 861, 871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 882, 928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 964, 969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 1146, 1166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 1723, 1768);

                f_10438_1723_1767((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 1782, 1823);

                f_10438_1782_1822((object)baseMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 1839, 1868);

                this.BaseMethod = baseMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 1882, 1895);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 1911, 2246);

                f_10438_1911_2245(
                            this, methodKind: MethodKind.Ordinary, declarationModifiers: declarationModifiers, returnsVoid: f_10438_2068_2090(baseMethod), isExtensionMethod: false, isNullableAnalysisEnabled: false, isMetadataVirtualIgnoringModifiers: false);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10438, 1179, 2257);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 1179, 2257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 1179, 2257);
            }
        }

        protected void AssignTypeMapAndTypeParameters(TypeMap typeMap, ImmutableArray<TypeParameterSymbol> typeParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 2269, 2690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 2408, 2438);

                f_10438_2408_2437(typeMap != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 2452, 2487);

                f_10438_2452_2486(f_10438_2465_2477(this) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 2501, 2541);

                f_10438_2501_2540(f_10438_2514_2539_M(!typeParameters.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 2555, 2595);

                f_10438_2555_2594(_typeParameters.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 2609, 2632);

                this.TypeMap = typeMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 2646, 2679);

                _typeParameters = typeParameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 2269, 2690);

                int
                f_10438_2408_2437(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 2408, 2437);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10438_2465_2477(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 2465, 2477);
                    return return_v;
                }


                int
                f_10438_2452_2486(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 2452, 2486);
                    return 0;
                }


                bool
                f_10438_2514_2539_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 2514, 2539);
                    return return_v;
                }


                int
                f_10438_2501_2540(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 2501, 2540);
                    return 0;
                }


                int
                f_10438_2555_2594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 2555, 2594);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 2269, 2690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 2269, 2690);
            }
        }

        protected override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 2702, 2875);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 2702, 2875);
                // TODO: move more functionality into here, making these symbols more lazy
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 2702, 2875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 2702, 2875);
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 2887, 3613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 3045, 3106);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10438, 3045, 3105);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 3045, 3105);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 3206, 3351) || true) && (f_10438_3210_3245(f_10438_3210_3224()) || (DynAbs.Tracing.TraceSender.Expression_False(10438, 3210, 3295) || f_10438_3249_3263() is SimpleProgramNamedTypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10438, 3206, 3351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 3329, 3336);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10438, 3206, 3351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 3367, 3411);

                var
                compilation = f_10438_3385_3410(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 3427, 3602);

                f_10438_3427_3601(ref attributes, f_10438_3484_3600(compilation, WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 2887, 3613);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10438_3210_3224()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 3210, 3224);
                    return return_v;
                }


                bool
                f_10438_3210_3245(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 3210, 3245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10438_3249_3263()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 3249, 3263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10438_3385_3410(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 3385, 3410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10438_3484_3600(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 3484, 3600);
                    return return_v;
                }


                int
                f_10438_3427_3601(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 3427, 3601);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 2887, 3613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 2887, 3613);
            }
        }

        public sealed override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 3723, 3754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 3729, 3752);

                    return _typeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 3723, 3754);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 3625, 3765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 3625, 3765);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 3899, 3959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 3902, 3959);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 3899, 3959);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 3899, 3959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 3899, 3959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 4086, 4138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 4089, 4138);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 4086, 4138);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 4086, 4138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 4086, 4138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 4212, 4250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 4218, 4248);

                    return this.Parameters.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 4212, 4250);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 4151, 4261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 4151, 4261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 4363, 4662);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 4399, 4610) || true) && (_parameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10438, 4399, 4610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 4466, 4591);

                        f_10438_4466_4590(ref _parameters, f_10438_4531_4547(this), default(ImmutableArray<ParameterSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10438, 4399, 4610);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 4628, 4647);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 4363, 4662);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10438_4531_4547(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
                    this_param)
                    {
                        var return_v = this_param.MakeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 4531, 4547);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10438_4466_4590(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 4466, 4590);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 4273, 4673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 4273, 4673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual ImmutableArray<TypeSymbol> ExtraSynthesizedRefParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 4784, 4835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 4790, 4833);

                    return default(ImmutableArray<TypeSymbol>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 4784, 4835);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 4685, 4846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 4685, 4846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual ImmutableArray<ParameterSymbol> BaseMethodParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 4953, 4995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 4959, 4993);

                    return f_10438_4966_4992(this.BaseMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 4953, 4995);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10438_4966_4992(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 4966, 4992);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 4858, 5006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 4858, 5006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<ParameterSymbol> MakeParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 5018, 6337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 5099, 5115);

                int
                ordinal = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 5129, 5187);

                var
                builder = f_10438_5143_5186()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 5201, 5244);

                var
                parameters = f_10438_5218_5243(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 5258, 5311);

                var
                inheritAttributes = f_10438_5282_5310()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 5325, 5908);
                    foreach (var p in f_10438_5343_5353_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10438, 5325, 5908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 5387, 5893);

                        f_10438_5387_5892(builder, f_10438_5399_5891(this, f_10438_5482_5551(f_10438_5482_5494(this), f_10438_5510_5550(f_10438_5510_5530(p))), ordinal++, f_10438_5606_5615(p), f_10438_5638_5644(p), refCustomModifiers: default, (DynAbs.Tracing.TraceSender.Conditional_F1(10438, 5830, 5847) || ((inheritAttributes && DynAbs.Tracing.TraceSender.Conditional_F2(10438, 5850, 5883)) || DynAbs.Tracing.TraceSender.Conditional_F3(10438, 5886, 5890))) ? p as SourceComplexParameterSymbol : null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10438, 5325, 5908);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10438, 1, 584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10438, 1, 584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 5922, 5971);

                var
                extraSynthed = f_10438_5941_5970()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 5985, 6276) || true) && (f_10438_5989_6019_M(!extraSynthed.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10438, 5985, 6276);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 6053, 6261);
                        foreach (var extra in f_10438_6075_6087_I(extraSynthed))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10438, 6053, 6261);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 6129, 6242);

                            f_10438_6129_6241(builder, f_10438_6141_6240(this, f_10438_6181_6215(f_10438_6181_6193(this), extra), ordinal++, RefKind.Ref));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10438, 6053, 6261);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10438, 1, 209);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10438, 1, 209);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10438, 5985, 6276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 6290, 6326);

                return f_10438_6297_6325(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 5018, 6337);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10438_5143_5186()
                {
                    var return_v = ArrayBuilder<ParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 5143, 5186);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10438_5218_5243(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
                this_param)
                {
                    var return_v = this_param.BaseMethodParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 5218, 5243);
                    return return_v;
                }


                bool
                f_10438_5282_5310()
                {
                    var return_v = InheritsBaseMethodAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 5282, 5310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10438_5482_5494(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 5482, 5494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10438_5510_5530(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 5510, 5530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10438_5510_5550(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 5510, 5550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10438_5482_5551(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 5482, 5551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10438_5606_5615(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 5606, 5615);
                    return return_v;
                }


                string
                f_10438_5638_5644(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 5638, 5644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10438_5399_5891(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol?
                baseParameterForAttributes)
                {
                    var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name, refCustomModifiers: refCustomModifiers, baseParameterForAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 5399, 5891);
                    return return_v;
                }


                int
                f_10438_5387_5892(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 5387, 5892);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10438_5343_5353_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 5343, 5353);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10438_5941_5970()
                {
                    var return_v = ExtraSynthesizedRefParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 5941, 5970);
                    return return_v;
                }


                bool
                f_10438_5989_6019_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 5989, 6019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10438_6181_6193(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 6181, 6193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10438_6181_6215(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 6181, 6215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10438_6141_6240(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 6141, 6240);
                    return return_v;
                }


                int
                f_10438_6129_6241(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 6129, 6241);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10438_6075_6087_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 6075, 6087);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10438_6297_6325(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 6297, 6325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 5018, 6337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 5018, 6337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool InheritsBaseMethodAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 6579, 6587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 6582, 6587);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 6579, 6587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 6579, 6587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 6579, 6587);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 6600, 6910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 6699, 6742);

                f_10438_6699_6741(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetAttributes(), 10438, 6712, 6732).IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 6756, 6899);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10438, 6763, 6791) || ((f_10438_6763_6791() && DynAbs.Tracing.TraceSender.Conditional_F2(10438, 6811, 6837)) || DynAbs.Tracing.TraceSender.Conditional_F3(10438, 6857, 6898))) ? f_10438_6811_6837(BaseMethod) : ImmutableArray<CSharpAttributeData>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 6600, 6910);

                int
                f_10438_6699_6741(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 6699, 6741);
                    return 0;
                }


                bool
                f_10438_6763_6791()
                {
                    var return_v = InheritsBaseMethodAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 6763, 6791);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10438_6811_6837(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 6811, 6837);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 6600, 6910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 6600, 6910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetReturnTypeAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 6922, 7228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 7031, 7084);

                f_10438_7031_7083(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetReturnTypeAttributes(), 10438, 7044, 7074).IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 7098, 7217);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10438, 7105, 7133) || ((f_10438_7105_7133() && DynAbs.Tracing.TraceSender.Conditional_F2(10438, 7136, 7172)) || DynAbs.Tracing.TraceSender.Conditional_F3(10438, 7175, 7216))) ? f_10438_7136_7172(BaseMethod) : ImmutableArray<CSharpAttributeData>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 6922, 7228);

                int
                f_10438_7031_7083(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 7031, 7083);
                    return 0;
                }


                bool
                f_10438_7105_7133()
                {
                    var return_v = InheritsBaseMethodAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 7105, 7133);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10438_7136_7172(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 7136, 7172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 6922, 7228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 6922, 7228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override DllImportData? GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 7315, 7385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 7318, 7385);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10438, 7318, 7346) || ((f_10438_7318_7346() && DynAbs.Tracing.TraceSender.Conditional_F2(10438, 7349, 7378)) || DynAbs.Tracing.TraceSender.Conditional_F3(10438, 7381, 7385))) ? f_10438_7349_7378(BaseMethod) : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 7315, 7385);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 7315, 7385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 7315, 7385);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10438_7318_7346()
            {
                var return_v = InheritsBaseMethodAttributes;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 7318, 7346);
                return return_v;
            }


            Microsoft.CodeAnalysis.DllImportData?
            f_10438_7349_7378(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.GetDllImportData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 7349, 7378);
                return return_v;
            }

        }

        internal sealed override MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 7469, 7548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 7472, 7548);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10438, 7472, 7500) || ((f_10438_7472_7500() && DynAbs.Tracing.TraceSender.Conditional_F2(10438, 7503, 7538)) || DynAbs.Tracing.TraceSender.Conditional_F3(10438, 7541, 7548))) ? f_10438_7503_7538(BaseMethod) : default; DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 7469, 7548);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 7469, 7548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 7469, 7548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override MarshalPseudoCustomAttributeData? ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 7654, 7739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 7657, 7739);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10438, 7657, 7685) || ((f_10438_7657_7685() && DynAbs.Tracing.TraceSender.Conditional_F2(10438, 7688, 7732)) || DynAbs.Tracing.TraceSender.Conditional_F3(10438, 7735, 7739))) ? f_10438_7688_7732(BaseMethod) : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 7654, 7739);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 7654, 7739);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 7654, 7739);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 7797, 7857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 7800, 7857);
                    return f_10438_7800_7828() && (DynAbs.Tracing.TraceSender.Expression_True(10438, 7800, 7857) && f_10438_7832_7857(BaseMethod)); DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 7797, 7857);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 7797, 7857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 7797, 7857);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 8241, 8324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 8244, 8324);
                    return !(BaseMethod is SourceMethodSymbol sourceMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10438, 8244, 8324) || f_10438_8296_8324(sourceMethod)); DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 8241, 8324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 8241, 8324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 8241, 8324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 8390, 8458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 8393, 8458);
                    return f_10438_8393_8421() && (DynAbs.Tracing.TraceSender.Expression_True(10438, 8393, 8458) && f_10438_8425_8458(BaseMethod)); DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 8390, 8458);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 8390, 8458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 8390, 8458);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 8524, 8592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 8527, 8592);
                    return f_10438_8527_8555() && (DynAbs.Tracing.TraceSender.Expression_True(10438, 8527, 8592) && f_10438_8559_8592(BaseMethod)); DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 8524, 8592);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 8524, 8592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 8524, 8592);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override IEnumerable<SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 8686, 8851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 8689, 8851);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10438, 8689, 8717) || ((f_10438_8689_8717() && DynAbs.Tracing.TraceSender.Conditional_F2(10438, 8737, 8772)) || DynAbs.Tracing.TraceSender.Conditional_F3(10438, 8792, 8851))) ? f_10438_8737_8772(BaseMethod) : f_10438_8792_8851(); DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 8686, 8851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 8686, 8851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 8686, 8851);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10438_8689_8717()
            {
                var return_v = InheritsBaseMethodAttributes;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 8689, 8717);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
            f_10438_8737_8772(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.GetSecurityInformation();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 8737, 8772);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
            f_10438_8792_8851()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<SecurityAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 8792, 8851);
                return return_v;
            }

        }

        public sealed override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 8948, 8987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 8954, 8985);

                    return f_10438_8961_8984(this.BaseMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 8948, 8987);

                    Microsoft.CodeAnalysis.RefKind
                    f_10438_8961_8984(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 8961, 8984);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 8885, 8998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 8885, 8998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 9103, 9208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 9109, 9206);

                    return f_10438_9116_9205(f_10438_9116_9128(this), f_10438_9144_9204(f_10438_9144_9178(this.BaseMethod)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 9103, 9208);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10438_9116_9128(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 9116, 9128);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10438_9144_9178(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 9144, 9178);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10438_9144_9204(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 9144, 9204);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10438_9116_9205(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    previous)
                    {
                        var return_v = this_param.SubstituteType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 9116, 9205);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 9010, 9219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 9010, 9219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 9312, 9359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 9315, 9359);
                    return f_10438_9315_9359(BaseMethod); DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 9312, 9359);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 9312, 9359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 9312, 9359);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 9452, 9497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 9455, 9497);
                    return f_10438_9455_9497(BaseMethod); DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 9452, 9497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 9452, 9497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 9452, 9497);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 9581, 9612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 9584, 9612);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 9581, 9612);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 9581, 9612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 9581, 9612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 9686, 9726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 9692, 9724);

                    return f_10438_9699_9723(this.BaseMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 9686, 9726);

                    bool
                    f_10438_9699_9723(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 9699, 9723);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 9625, 9737);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 9625, 9737);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 9808, 9829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 9814, 9827);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 9808, 9829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 9749, 9840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 9749, 9840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 9925, 9945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 9931, 9943);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 9925, 9945);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 9852, 9956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 9852, 9956);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 10034, 10055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 10040, 10053);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 10034, 10055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 9968, 10066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 9968, 10066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations IteratorElementTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 10175, 10638);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 10211, 10569) || true) && (_iteratorElementType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10438, 10211, 10569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 10285, 10550);

                        f_10438_10285_10549(ref _iteratorElementType, f_10438_10388_10493(f_10438_10418_10492(f_10438_10418_10425(), BaseMethod.IteratorElementTypeWithAnnotations.Type)), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10438, 10211, 10569);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 10589, 10623);

                    return _iteratorElementType.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 10175, 10638);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10438_10418_10425()
                    {
                        var return_v = TypeMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 10418, 10425);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10438_10418_10492(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    previous)
                    {
                        var return_v = this_param.SubstituteType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 10418, 10492);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10438_10388_10493(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 10388, 10493);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    f_10438_10285_10549(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 10285, 10549);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 10078, 10848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 10078, 10848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 10652, 10837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 10688, 10719);

                    f_10438_10688_10718(f_10438_10701_10717_M(!value.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 10737, 10822);

                    f_10438_10737_10821(ref _iteratorElementType, f_10438_10784_10820(value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 10652, 10837);

                    bool
                    f_10438_10701_10717_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 10701, 10717);
                        return return_v;
                    }


                    int
                    f_10438_10688_10718(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 10688, 10718);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10438_10784_10820(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 10784, 10820);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10438_10737_10821(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    value)
                    {
                        var return_v = Interlocked.Exchange(ref location1, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 10737, 10821);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 10078, 10848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 10078, 10848);
                }
            }
        }

        internal override bool IsIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10438, 10894, 10918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10438, 10897, 10918);
                    return f_10438_10897_10918(BaseMethod); DynAbs.Tracing.TraceSender.TraceExitMethod(10438, 10894, 10918);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10438, 10894, 10918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 10894, 10918);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedMethodBaseSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10438, 734, 10926);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10438, 734, 10926);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10438, 734, 10926);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10438, 734, 10926);

        int
        f_10438_1723_1767(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 1723, 1767);
            return 0;
        }


        int
        f_10438_1782_1822(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 1782, 1822);
            return 0;
        }


        bool
        f_10438_2068_2090(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnsVoid;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 2068, 2090);
            return return_v;
        }


        int
        f_10438_1911_2245(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedMethodBaseSymbol
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled, bool
        isMetadataVirtualIgnoringModifiers)
        {
            this_param.MakeFlags(methodKind: methodKind, declarationModifiers: declarationModifiers, returnsVoid: returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: isMetadataVirtualIgnoringModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10438, 1911, 2245);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10438_1637_1651_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10438, 1179, 2257);
            return return_v;
        }


        bool
        f_10438_7472_7500()
        {
            var return_v = InheritsBaseMethodAttributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 7472, 7500);
            return return_v;
        }


        System.Reflection.MethodImplAttributes
        f_10438_7503_7538(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ImplementationAttributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 7503, 7538);
            return return_v;
        }


        bool
        f_10438_7657_7685()
        {
            var return_v = InheritsBaseMethodAttributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 7657, 7685);
            return return_v;
        }


        Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
        f_10438_7688_7732(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnValueMarshallingInformation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 7688, 7732);
            return return_v;
        }


        bool
        f_10438_7800_7828()
        {
            var return_v = InheritsBaseMethodAttributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 7800, 7828);
            return return_v;
        }


        bool
        f_10438_7832_7857(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.HasSpecialName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 7832, 7857);
            return return_v;
        }


        bool
        f_10438_8296_8324(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
        this_param)
        {
            var return_v = this_param.AreLocalsZeroed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 8296, 8324);
            return return_v;
        }


        bool
        f_10438_8393_8421()
        {
            var return_v = InheritsBaseMethodAttributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 8393, 8421);
            return return_v;
        }


        bool
        f_10438_8425_8458(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.RequiresSecurityObject;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 8425, 8458);
            return return_v;
        }


        bool
        f_10438_8527_8555()
        {
            var return_v = InheritsBaseMethodAttributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 8527, 8555);
            return return_v;
        }


        bool
        f_10438_8559_8592(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.HasDeclarativeSecurity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 8559, 8592);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_10438_9315_9359(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnTypeFlowAnalysisAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 9315, 9359);
            return return_v;
        }


        System.Collections.Immutable.ImmutableHashSet<string>
        f_10438_9455_9497(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnNotNullIfParameterNotNull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 9455, 9497);
            return return_v;
        }


        bool
        f_10438_10897_10918(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsIterator;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10438, 10897, 10918);
            return return_v;
        }

    }
}
