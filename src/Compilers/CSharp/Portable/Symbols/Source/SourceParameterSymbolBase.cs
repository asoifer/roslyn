// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceParameterSymbolBase : ParameterSymbol
    {
        private readonly Symbol _containingSymbol;

        private readonly ushort _ordinal;

        public SourceParameterSymbolBase(Symbol containingSymbol, int ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10271, 741, 986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 668, 685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 720, 728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 836, 883);

                f_10271_836_882((object)containingSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 897, 924);

                _ordinal = (ushort)ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 938, 975);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10271, 741, 986);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10271, 741, 986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10271, 741, 986);
            }
        }

        public sealed override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10271, 998, 1579);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 1098, 1182) || true) && (obj == (object)this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10271, 1098, 1182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 1155, 1167);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10271, 1098, 1182);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 1198, 1327) || true) && (obj is NativeIntegerParameterSymbol nps)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10271, 1198, 1327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 1275, 1312);

                    return f_10271_1282_1311(nps, this, compareKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10271, 1198, 1327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 1343, 1389);

                var
                symbol = obj as SourceParameterSymbolBase
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 1403, 1568);

                return (object)symbol != null
                && (DynAbs.Tracing.TraceSender.Expression_True(10271, 1410, 1483) && f_10271_1453_1467(symbol) == f_10271_1471_1483(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10271, 1410, 1567) && f_10271_1504_1567(symbol._containingSymbol, _containingSymbol, compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10271, 998, 1579);

                bool
                f_10271_1282_1311(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 1282, 1311);
                    return return_v;
                }


                int
                f_10271_1453_1467(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 1453, 1467);
                    return return_v;
                }


                int
                f_10271_1471_1483(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.Ordinal
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 1471, 1483);
                    return return_v;
                }


                bool
                f_10271_1504_1567(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 1504, 1567);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10271, 998, 1579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10271, 998, 1579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10271, 1591, 1734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 1656, 1723);

                return f_10271_1663_1722(f_10271_1676_1707(_containingSymbol), f_10271_1709_1721(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10271, 1591, 1734);

                int
                f_10271_1676_1707(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 1676, 1707);
                    return return_v;
                }


                int
                f_10271_1709_1721(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 1709, 1721);
                    return return_v;
                }


                int
                f_10271_1663_1722(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 1663, 1722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10271, 1591, 1734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10271, 1591, 1734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10271, 1805, 1829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 1811, 1827);

                    return _ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10271, 1805, 1829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10271, 1746, 1840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10271, 1746, 1840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10271, 1923, 1956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 1929, 1954);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10271, 1923, 1956);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10271, 1852, 1967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10271, 1852, 1967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10271, 2060, 2112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 2066, 2110);

                    return f_10271_2073_2109(_containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10271, 2060, 2112);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10271_2073_2109(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 2073, 2109);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10271, 1979, 2123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10271, 1979, 2123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract ConstantValue DefaultValueFromAttributes { get; }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10271, 2214, 4443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 2372, 2433);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10271, 2372, 2432);

                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 2372, 2432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 2449, 2493);

                var
                compilation = f_10271_2467_2492(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 2509, 2701) || true) && (f_10271_2513_2526(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10271, 2509, 2701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 2560, 2686);

                    f_10271_2560_2685(ref attributes, f_10271_2600_2684(compilation, WellKnownMember.System_ParamArrayAttribute__ctor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10271, 2509, 2701);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 2824, 2877);

                var
                defaultValue = f_10271_2843_2876(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 2891, 3253) || true) && (defaultValue != ConstantValue.NotAvailable && (DynAbs.Tracing.TraceSender.Expression_True(10271, 2895, 3012) && f_10271_2958_2982(defaultValue) == SpecialType.System_Decimal) && (DynAbs.Tracing.TraceSender.Expression_True(10271, 2895, 3089) && f_10271_3033_3059() == ConstantValue.NotAvailable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10271, 2891, 3253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 3123, 3238);

                    f_10271_3123_3237(ref attributes, f_10271_3163_3236(compilation, f_10271_3210_3235(defaultValue)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10271, 2891, 3253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 3269, 3305);

                var
                type = f_10271_3280_3304(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 3321, 3568) || true) && (f_10271_3325_3352(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10271, 3321, 3568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 3386, 3553);

                    f_10271_3386_3552(ref attributes, f_10271_3426_3551(compilation, type.Type, type.CustomModifiers.Length + this.RefCustomModifiers.Length, f_10271_3538_3550(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10271, 3321, 3568);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 3584, 3775) || true) && (f_10271_3588_3621(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10271, 3584, 3775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 3655, 3760);

                    f_10271_3655_3759(ref attributes, f_10271_3695_3758(moduleBuilder, this, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10271, 3584, 3775);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 3791, 3989) || true) && (f_10271_3795_3825(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10271, 3791, 3989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 3859, 3974);

                    f_10271_3859_3973(ref attributes, f_10271_3920_3972(compilation, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10271, 3791, 3989);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 4005, 4184) || true) && (f_10271_4009_4021(this) == RefKind.RefReadOnly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10271, 4005, 4184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 4078, 4169);

                    f_10271_4078_4168(ref attributes, f_10271_4118_4167(moduleBuilder, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10271, 4005, 4184);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 4200, 4432) || true) && (f_10271_4204_4250(compilation, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10271, 4200, 4432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10271, 4284, 4417);

                    f_10271_4284_4416(ref attributes, f_10271_4324_4415(moduleBuilder, this, f_10271_4383_4408(this), type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10271, 4200, 4432);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10271, 2214, 4443);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10271_2467_2492(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 2467, 2492);
                    return return_v;
                }


                bool
                f_10271_2513_2526(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 2513, 2526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10271_2600_2684(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 2600, 2684);
                    return return_v;
                }


                int
                f_10271_2560_2685(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 2560, 2685);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10271_2843_2876(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ExplicitDefaultConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 2843, 2876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10271_2958_2982(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 2958, 2982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10271_3033_3059()
                {
                    var return_v = DefaultValueFromAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 3033, 3059);
                    return return_v;
                }


                decimal
                f_10271_3210_3235(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DecimalValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 3210, 3235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10271_3163_3236(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, decimal
                value)
                {
                    var return_v = this_param.SynthesizeDecimalConstantAttribute(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3163, 3236);
                    return return_v;
                }


                int
                f_10271_3123_3237(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3123, 3237);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10271_3280_3304(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 3280, 3304);
                    return return_v;
                }


                bool
                f_10271_3325_3352(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3325, 3352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10271_3538_3550(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 3538, 3550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10271_3426_3551(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, int
                customModifiersCount, Microsoft.CodeAnalysis.RefKind
                refKindOpt)
                {
                    var return_v = this_param.SynthesizeDynamicAttribute(type, customModifiersCount, refKindOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3426, 3551);
                    return return_v;
                }


                int
                f_10271_3386_3552(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3386, 3552);
                    return 0;
                }


                bool
                f_10271_3588_3621(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3588, 3621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10271_3695_3758(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3695, 3758);
                    return return_v;
                }


                int
                f_10271_3655_3759(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3655, 3759);
                    return 0;
                }


                bool
                f_10271_3795_3825(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3795, 3825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10271_3920_3972(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeTupleNamesAttribute(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3920, 3972);
                    return return_v;
                }


                int
                f_10271_3859_3973(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 3859, 3973);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10271_4009_4021(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10271, 4009, 4021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10271_4118_4167(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                symbol)
                {
                    var return_v = this_param.SynthesizeIsReadOnlyAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 4118, 4167);
                    return return_v;
                }


                int
                f_10271_4078_4168(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 4078, 4168);
                    return 0;
                }


                bool
                f_10271_4204_4250(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 4204, 4250);
                    return return_v;
                }


                byte?
                f_10271_4383_4408(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 4383, 4408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10271_4324_4415(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                symbol, byte?
                nullableContextValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, nullableContextValue, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 4324, 4415);
                    return return_v;
                }


                int
                f_10271_4284_4416(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 4284, 4416);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10271, 2214, 4443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10271, 2214, 4443);
            }
        }

        internal abstract ParameterSymbol WithCustomModifiersAndParams(TypeSymbol newType, ImmutableArray<CustomModifier> newCustomModifiers, ImmutableArray<CustomModifier> newRefCustomModifiers, bool newIsParams);

        static SourceParameterSymbolBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10271, 560, 4668);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10271, 560, 4668);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10271, 560, 4668);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10271, 560, 4668);

        int
        f_10271_836_882(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10271, 836, 882);
            return 0;
        }

    }
}
