// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedFieldSymbolBase : FieldSymbol
    {
        private readonly NamedTypeSymbol _containingType;

        private readonly string _name;

        private readonly DeclarationModifiers _modifiers;

        public SynthesizedFieldSymbolBase(
                    NamedTypeSymbol containingType,
                    string name,
                    bool isPublic,
                    bool isReadOnly,
                    bool isStatic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10678, 813, 1496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 686, 701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 736, 741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 790, 800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 1029, 1074);

                f_10678_1029_1073((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 1088, 1130);

                f_10678_1088_1129(!f_10678_1102_1128(name));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 1146, 1179);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 1193, 1206);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 1220, 1485);

                _modifiers = ((DynAbs.Tracing.TraceSender.Conditional_F1(10678, 1234, 1242) || ((isPublic && DynAbs.Tracing.TraceSender.Conditional_F2(10678, 1245, 1272)) || DynAbs.Tracing.TraceSender.Conditional_F3(10678, 1275, 1303))) ? DeclarationModifiers.Public : DeclarationModifiers.Private) |
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(10678, 1325, 1335) || ((isReadOnly && DynAbs.Tracing.TraceSender.Conditional_F2(10678, 1338, 1367)) || DynAbs.Tracing.TraceSender.Conditional_F3(10678, 1370, 1395))) ? DeclarationModifiers.ReadOnly : DeclarationModifiers.None) |
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(10678, 1417, 1425) || ((isStatic && DynAbs.Tracing.TraceSender.Conditional_F2(10678, 1428, 1455)) || DynAbs.Tracing.TraceSender.Conditional_F3(10678, 1458, 1483))) ? DeclarationModifiers.Static : DeclarationModifiers.None);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10678, 813, 1496);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 813, 1496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 813, 1496);
            }
        }

        internal abstract bool SuppressDynamicAttribute
        {
            get;
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 1607, 3663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 1765, 1826);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10678, 1765, 1825);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 1765, 1825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 1842, 1900);

                CSharpCompilation
                compilation = f_10678_1874_1899(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 1914, 1965);

                var
                typeWithAnnotations = f_10678_1940_1964(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 1979, 2015);

                var
                type = typeWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 2132, 2197);

                f_10678_2132_2196(!(_containingType is SimpleProgramNamedTypeSymbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 2211, 2459) || true) && (f_10678_2215_2252_M(!_containingType.IsImplicitlyDeclared))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10678, 2211, 2459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 2286, 2444);

                    f_10678_2286_2443(ref attributes, f_10678_2326_2442(compilation, WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10678, 2211, 2459);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 2475, 2839) || true) && (f_10678_2479_2509_M(!this.SuppressDynamicAttribute) && (DynAbs.Tracing.TraceSender.Expression_True(10678, 2479, 2552) && f_10678_2530_2552(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10678, 2479, 2611) && f_10678_2573_2611(compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10678, 2479, 2660) && f_10678_2632_2660(compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10678, 2475, 2839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 2694, 2824);

                    f_10678_2694_2823(ref attributes, f_10678_2734_2822(compilation, type, typeWithAnnotations.CustomModifiers.Length));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10678, 2475, 2839);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 2855, 3036) || true) && (f_10678_2859_2887(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10678, 2855, 3036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 2921, 3021);

                    f_10678_2921_3020(ref attributes, f_10678_2961_3019(moduleBuilder, this, type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10678, 2855, 3036);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 3052, 3374) || true) && (f_10678_3056_3081(type) && (DynAbs.Tracing.TraceSender.Expression_True(10678, 3056, 3137) && f_10678_3102_3137(compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10678, 3056, 3215) && f_10678_3158_3215(compilation, SpecialType.System_String)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10678, 3052, 3374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 3249, 3359);

                    f_10678_3249_3358(ref attributes, f_10678_3310_3357(compilation, f_10678_3352_3356()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10678, 3052, 3374);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 3390, 3652) || true) && (f_10678_3394_3440(compilation, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10678, 3390, 3652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 3474, 3637);

                    f_10678_3474_3636(ref attributes, f_10678_3514_3635(moduleBuilder, this, f_10678_3573_3613(f_10678_3573_3587()), typeWithAnnotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10678, 3390, 3652);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 1607, 3663);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10678_1874_1899(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10678, 1874, 1899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10678_1940_1964(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbolBase
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10678, 1940, 1964);
                    return return_v;
                }


                int
                f_10678_2132_2196(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2132, 2196);
                    return 0;
                }


                bool
                f_10678_2215_2252_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10678, 2215, 2252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10678_2326_2442(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2326, 2442);
                    return return_v;
                }


                int
                f_10678_2286_2443(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2286, 2443);
                    return 0;
                }


                bool
                f_10678_2479_2509_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10678, 2479, 2509);
                    return return_v;
                }


                bool
                f_10678_2530_2552(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2530, 2552);
                    return return_v;
                }


                bool
                f_10678_2573_2611(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.HasDynamicEmitAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2573, 2611);
                    return return_v;
                }


                bool
                f_10678_2632_2660(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.CanEmitBoolean();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2632, 2660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10678_2734_2822(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, int
                customModifiersCount)
                {
                    var return_v = this_param.SynthesizeDynamicAttribute(type, customModifiersCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2734, 2822);
                    return return_v;
                }


                int
                f_10678_2694_2823(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2694, 2823);
                    return 0;
                }


                bool
                f_10678_2859_2887(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2859, 2887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10678_2961_3019(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbolBase
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2961, 3019);
                    return return_v;
                }


                int
                f_10678_2921_3020(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 2921, 3020);
                    return 0;
                }


                bool
                f_10678_3056_3081(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 3056, 3081);
                    return return_v;
                }


                bool
                f_10678_3102_3137(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.HasTupleNamesAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10678, 3102, 3137);
                    return return_v;
                }


                bool
                f_10678_3158_3215(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.CanEmitSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 3158, 3215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10678_3352_3356()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10678, 3352, 3356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10678_3310_3357(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeTupleNamesAttribute(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 3310, 3357);
                    return return_v;
                }


                int
                f_10678_3249_3358(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 3249, 3358);
                    return 0;
                }


                bool
                f_10678_3394_3440(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbolBase
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 3394, 3440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10678_3573_3587()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10678, 3573, 3587);
                    return return_v;
                }


                byte?
                f_10678_3573_3613(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 3573, 3613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10678_3514_3635(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbolBase
                symbol, byte?
                nullableContextValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, nullableContextValue, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 3514, 3635);
                    return return_v;
                }


                int
                f_10678_3474_3636(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 3474, 3636);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 1607, 3663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 1607, 3663);
            }
        }

        internal abstract override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound);

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 3864, 3895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 3867, 3895);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 3864, 3895);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 3864, 3895);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 3864, 3895);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 3960, 3981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 3966, 3979);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 3960, 3981);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 3908, 3992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 3908, 3992);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 4068, 4131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 4104, 4116);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 4068, 4131);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 4004, 4142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 4004, 4142);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 4210, 4275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 4216, 4273);

                    return (_modifiers & DeclarationModifiers.ReadOnly) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 4210, 4275);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 4154, 4286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 4154, 4286);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVolatile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 4354, 4375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 4360, 4373);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 4354, 4375);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 4298, 4386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 4298, 4386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsConst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 4451, 4472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 4457, 4470);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 4451, 4472);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 4398, 4483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 4398, 4483);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsNotSerialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 4558, 4579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 4564, 4577);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 4558, 4579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 4495, 4590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 4495, 4590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 4700, 4720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 4706, 4718);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 4700, 4720);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 4602, 4731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 4602, 4731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int? TypeLayoutOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 4807, 4827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 4813, 4825);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 4807, 4827);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 4743, 4838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 4743, 4838);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue GetConstantValue(ConstantFieldsInProgress inProgress, bool earlyDecodingWellKnownAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 4850, 5022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 4999, 5011);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 4850, 5022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 4850, 5022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 4850, 5022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 5127, 5147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 5133, 5145);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 5127, 5147);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 5034, 5158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 5034, 5158);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 5234, 5265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 5240, 5263);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 5234, 5265);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 5170, 5276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 5170, 5276);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 5359, 5433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 5395, 5418);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 5359, 5433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 5288, 5444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 5288, 5444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 5531, 5577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 5537, 5575);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 5531, 5577);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 5456, 5588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 5456, 5588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 5698, 5794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 5734, 5779);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 5698, 5794);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 5600, 5805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 5600, 5805);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 5893, 5957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 5899, 5955);

                    return f_10678_5906_5954(_modifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 5893, 5957);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10678_5906_5954(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                    modifiers)
                    {
                        var return_v = ModifierUtils.EffectiveAccessibility(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 5906, 5954);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 5817, 5968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 5817, 5968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 6034, 6097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 6040, 6095);

                    return (_modifiers & DeclarationModifiers.Static) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 6034, 6097);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 5980, 6108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 5980, 6108);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 6182, 6224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 6188, 6222);

                    return f_10678_6195_6221(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 6182, 6224);

                    bool
                    f_10678_6195_6221(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbolBase
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10678, 6195, 6221);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 6120, 6235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 6120, 6235);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 6316, 6386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 6322, 6384);

                    return f_10678_6329_6338(this) == WellKnownMemberNames.EnumBackingFieldName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 6316, 6386);

                    string
                    f_10678_6329_6338(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbolBase
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10678, 6329, 6338);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 6247, 6397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 6247, 6397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10678, 6475, 6495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10678, 6481, 6493);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10678, 6475, 6495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10678, 6409, 6506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 6409, 6506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedFieldSymbolBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10678, 572, 6513);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10678, 572, 6513);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10678, 572, 6513);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10678, 572, 6513);

        int
        f_10678_1029_1073(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 1029, 1073);
            return 0;
        }


        bool
        f_10678_1102_1128(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 1102, 1128);
            return return_v;
        }


        int
        f_10678_1088_1129(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10678, 1088, 1129);
            return 0;
        }

    }
}
