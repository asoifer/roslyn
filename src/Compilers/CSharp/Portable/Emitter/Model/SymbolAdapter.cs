// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class
            SymbolAdapter
            : Cci.IReference
    {
        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 809, 946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 898, 935);

                throw f_10213_904_934();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 809, 946);

                System.Exception
                f_10213_904_934()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 904, 934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 809, 946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 809, 946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 1030, 1046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 1033, 1046);
                return f_10213_1033_1046(); DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 1030, 1046);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 1030, 1046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 1030, 1046);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbol
            f_10213_1033_1046()
            {
                var return_v = AdaptedSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 1033, 1046);
                return return_v;
            }

        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 1059, 1189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 1141, 1178);

                throw f_10213_1147_1177();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 1059, 1189);

                System.Exception
                f_10213_1147_1177()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 1147, 1177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 1059, 1189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 1059, 1189);
            }
        }

        IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 1201, 1400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 1309, 1389);

                return f_10213_1316_1388(f_10213_1316_1329(), context.Module);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 1201, 1400);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10213_1316_1329()
                {
                    var return_v = AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 1316, 1329);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10213_1316_1388(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit((Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder)moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 1316, 1388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 1201, 1400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 1201, 1400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10213, 669, 1407);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10213, 669, 1407);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 669, 1407);
        }


        static SymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10213, 669, 1407);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10213, 669, 1407);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 669, 1407);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10213, 669, 1407);
    }
    internal partial class Symbol
    {
        internal SymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 1511, 1533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 1514, 1533);
                return f_10213_1514_1533(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 1511, 1533);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 1511, 1533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 1511, 1533);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.SymbolAdapter
            f_10213_1514_1533(Microsoft.CodeAnalysis.CSharp.Symbol
            this_param)
            {
                var return_v = this_param.GetCciAdapterImpl();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 1514, 1533);
                return return_v;
            }

        }

        protected virtual SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 1596, 1635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 1599, 1635);
                throw f_10213_1605_1635(); DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 1596, 1635);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 1596, 1635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 1596, 1635);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10213_1605_1635()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 1605, 1635);
                return return_v;
            }

        }

        [Conditional("DEBUG")]
        protected internal void CheckDefinitionInvariant()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 1911, 2436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 2065, 2097);

                f_10213_2065_2096(f_10213_2078_2095(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 2176, 2425);

                f_10213_2176_2424(f_10213_2189_2210(this) is SourceModuleSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10213, 2189, 2328) || (f_10213_2263_2272(this) == SymbolKind.Assembly && (DynAbs.Tracing.TraceSender.Expression_True(10213, 2263, 2327) && this is SourceAssemblySymbol))) || (DynAbs.Tracing.TraceSender.Expression_False(10213, 2189, 2423) || (f_10213_2359_2368(this) == SymbolKind.NetModule && (DynAbs.Tracing.TraceSender.Expression_True(10213, 2359, 2422) && this is SourceModuleSymbol))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 1911, 2436);

                bool
                f_10213_2078_2095(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 2078, 2095);
                    return return_v;
                }


                int
                f_10213_2065_2096(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 2065, 2096);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10213_2189_2210(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 2189, 2210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10213_2263_2272(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 2263, 2272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10213_2359_2368(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 2359, 2368);
                    return return_v;
                }


                int
                f_10213_2176_2424(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 2176, 2424);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 1911, 2436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 1911, 2436);
            }
        }

        Cci.IReference CodeAnalysis.Symbols.ISymbolInternal.GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 2516, 2534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 2519, 2534);
                return f_10213_2519_2534(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 2516, 2534);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 2516, 2534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 2516, 2534);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.SymbolAdapter
            f_10213_2519_2534(Microsoft.CodeAnalysis.CSharp.Symbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 2519, 2534);
                return return_v;
            }

        }

        internal bool IsDefinitionOrDistinct()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 2802, 2997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 2865, 2986);

                return f_10213_2872_2889(this) || (DynAbs.Tracing.TraceSender.Expression_False(10213, 2872, 2985) || !f_10213_2894_2985(this, f_10213_2906_2929(this), f_10213_2931_2984(SymbolEqualityComparer.ConsiderEverything)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 2802, 2997);

                bool
                f_10213_2872_2889(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 2872, 2889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10213_2906_2929(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 2906, 2929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeCompareKind
                f_10213_2931_2984(Microsoft.CodeAnalysis.SymbolEqualityComparer
                this_param)
                {
                    var return_v = this_param.CompareKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 2931, 2984);
                    return return_v;
                }


                bool
                f_10213_2894_2985(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 2894, 2985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 2802, 2997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 2802, 2997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 3009, 3349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 3140, 3167);

                f_10213_3140_3166(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 3183, 3230);

                f_10213_3183_3229(f_10213_3196_3205(this) != SymbolKind.Assembly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 3244, 3338);

                return f_10213_3251_3337(this, moduleBuilder, emittingAssemblyAttributesInNetModule: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 3009, 3349);

                int
                f_10213_3140_3166(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 3140, 3166);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10213_3196_3205(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 3196, 3205);
                    return return_v;
                }


                int
                f_10213_3183_3229(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 3183, 3229);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10213_3251_3337(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, bool
                emittingAssemblyAttributesInNetModule)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder, emittingAssemblyAttributesInNetModule: emittingAssemblyAttributesInNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 3251, 3337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 3009, 3349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 3009, 3349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder, bool emittingAssemblyAttributesInNetModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 3361, 4259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 3528, 3555);

                f_10213_3528_3554(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 3569, 3616);

                f_10213_3569_3615(f_10213_3582_3591(this) != SymbolKind.Assembly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 3632, 3680);

                ImmutableArray<CSharpAttributeData>
                userDefined
                = default(ImmutableArray<CSharpAttributeData>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 3694, 3752);

                ArrayBuilder<SynthesizedAttributeData>
                synthesized = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 3766, 3801);

                userDefined = f_10213_3780_3800(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 3815, 3877);

                f_10213_3815_3876(this, moduleBuilder, ref synthesized);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 4090, 4248);

                return f_10213_4097_4247(this, userDefined, synthesized, isReturnType: false, emittingAssemblyAttributesInNetModule: emittingAssemblyAttributesInNetModule);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 3361, 4259);

                int
                f_10213_3528_3554(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 3528, 3554);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10213_3582_3591(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 3582, 3591);
                    return return_v;
                }


                int
                f_10213_3569_3615(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 3569, 3615);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10213_3780_3800(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 3780, 3800);
                    return return_v;
                }


                int
                f_10213_3815_3876(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>?
                attributes)
                {
                    this_param.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 3815, 3876);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10213_4097_4247(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                userDefined, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                synthesized, bool
                isReturnType, bool
                emittingAssemblyAttributesInNetModule)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(userDefined, synthesized, isReturnType: isReturnType, emittingAssemblyAttributesInNetModule: emittingAssemblyAttributesInNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 4097, 4247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 3361, 4259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 3361, 4259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(
                    ImmutableArray<CSharpAttributeData> userDefined,
                    ArrayBuilder<SynthesizedAttributeData> synthesized,
                    bool isReturnType,
                    bool emittingAssemblyAttributesInNetModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 4495, 5244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 4804, 4831);

                f_10213_4804_4830(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 4933, 5097) || true) && (userDefined.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10213, 4937, 4979) && synthesized == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10213, 4933, 5097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 5013, 5082);

                    return f_10213_5020_5081();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10213, 4933, 5097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 5113, 5233);

                return f_10213_5120_5232(this, userDefined, synthesized, isReturnType, emittingAssemblyAttributesInNetModule);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 4495, 5244);

                int
                f_10213_4804_4830(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 4804, 4830);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10213_5020_5081()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 5020, 5081);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10213_5120_5232(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                userDefined, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                synthesized, bool
                isReturnType, bool
                emittingAssemblyAttributesInNetModule)
                {
                    var return_v = this_param.GetCustomAttributesToEmitIterator(userDefined, synthesized, isReturnType, emittingAssemblyAttributesInNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 5120, 5232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 4495, 5244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 4495, 5244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<CSharpAttributeData> GetCustomAttributesToEmitIterator(
                    ImmutableArray<CSharpAttributeData> userDefined,
                    ArrayBuilder<SynthesizedAttributeData> synthesized,
                    bool isReturnType,
                    bool emittingAssemblyAttributesInNetModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 5256, 6917);

                var listYield = new List<CSharpAttributeData>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 5572, 5599);

                f_10213_5572_5598(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 5615, 6041) || true) && (synthesized != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10213, 5615, 6041);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 5672, 5987);
                        foreach (var attribute in f_10213_5698_5709_I(synthesized))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10213, 5672, 5987);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 5820, 5923);

                            f_10213_5820_5922(f_10213_5833_5921(attribute, this, isReturnType, emittingAssemblyAttributesInNetModule));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 5945, 5968);

                            listYield.Add(attribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10213, 5672, 5987);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10213, 1, 316);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10213, 1, 316);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6007, 6026);

                    f_10213_6007_6025(
                                    synthesized);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10213, 5615, 6041);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6066, 6071);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6057, 6906) || true) && (i < userDefined.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6097, 6100)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10213, 6057, 6906))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10213, 6057, 6906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6134, 6181);

                        CSharpAttributeData
                        attribute = userDefined[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6199, 6695) || true) && (f_10213_6203_6212(this) == SymbolKind.Assembly)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10213, 6199, 6695);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6525, 6676) || true) && (f_10213_6529_6594(((SourceAssemblySymbol)this), i))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10213, 6525, 6676);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6644, 6653);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10213, 6525, 6676);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10213, 6199, 6695);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6715, 6891) || true) && (f_10213_6719_6807(attribute, this, isReturnType, emittingAssemblyAttributesInNetModule))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10213, 6715, 6891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 6849, 6872);

                            listYield.Add(attribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10213, 6715, 6891);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10213, 1, 850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10213, 1, 850);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 5256, 6917);

                return listYield;

                int
                f_10213_5572_5598(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 5572, 5598);
                    return 0;
                }


                bool
                f_10213_5833_5921(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                target, bool
                isReturnType, bool
                emittingAssemblyAttributesInNetModule)
                {
                    var return_v = this_param.ShouldEmitAttribute(target, isReturnType, emittingAssemblyAttributesInNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 5833, 5921);
                    return return_v;
                }


                int
                f_10213_5820_5922(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 5820, 5922);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                f_10213_5698_5709_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 5698, 5709);
                    return return_v;
                }


                int
                f_10213_6007_6025(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 6007, 6025);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10213_6203_6212(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 6203, 6212);
                    return return_v;
                }


                bool
                f_10213_6529_6594(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, int
                index)
                {
                    var return_v = this_param.IsIndexOfOmittedAssemblyAttribute(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 6529, 6594);
                    return return_v;
                }


                bool
                f_10213_6719_6807(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                target, bool
                isReturnType, bool
                emittingAssemblyAttributesInNetModule)
                {
                    var return_v = this_param.ShouldEmitAttribute(target, isReturnType, emittingAssemblyAttributesInNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 6719, 6807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 5256, 6917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 5256, 6917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal partial class SymbolAdapter
    {
        internal abstract Symbol AdaptedSymbol { get; }

        public sealed override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 7055, 7163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 7120, 7152);

                return f_10213_7127_7151(f_10213_7127_7140());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 7055, 7163);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10213_7127_7140()
                {
                    var return_v = AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 7127, 7140);
                    return return_v;
                }


                string
                f_10213_7127_7151(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 7127, 7151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 7055, 7163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 7055, 7163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 7175, 7454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 7389, 7443);

                throw f_10213_7395_7442();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 7175, 7454);

                System.Exception
                f_10213_7395_7442()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 7395, 7442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 7175, 7454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 7175, 7454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 7466, 7739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 7674, 7728);

                throw f_10213_7680_7727();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 7466, 7739);

                System.Exception
                f_10213_7680_7727()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 7680, 7727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 7466, 7739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 7466, 7739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        protected internal void CheckDefinitionInvariant()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 7834, 7877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 7837, 7877);
                f_10213_7837_7877(f_10213_7837_7850()); DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 7834, 7877);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 7834, 7877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 7834, 7877);
            }

            Microsoft.CodeAnalysis.CSharp.Symbol
            f_10213_7837_7850()
            {
                var return_v = AdaptedSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 7837, 7850);
                return return_v;
            }


            int
            f_10213_7837_7877(Microsoft.CodeAnalysis.CSharp.Symbol
            this_param)
            {
                this_param.CheckDefinitionInvariant();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 7837, 7877);
                return 0;
            }

        }

        internal bool IsDefinitionOrDistinct()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10213, 7890, 8010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10213, 7953, 7999);

                return f_10213_7960_7998(f_10213_7960_7973());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10213, 7890, 8010);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10213_7960_7973()
                {
                    var return_v = AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10213, 7960, 7973);
                    return return_v;
                }


                bool
                f_10213_7960_7998(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10213, 7960, 7998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10213, 7890, 8010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10213, 7890, 8010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
