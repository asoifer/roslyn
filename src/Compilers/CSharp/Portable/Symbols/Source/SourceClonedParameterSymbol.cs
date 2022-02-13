// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceClonedParameterSymbol : SourceParameterSymbolBase
    {
        private readonly bool _suppressOptional;

        private readonly SourceParameterSymbol _originalParam;

        internal SourceClonedParameterSymbol(SourceParameterSymbol originalParam, Symbol newOwner, int newOrdinal, bool suppressOptional)
        : base(f_10239_1197_1205_C(newOwner), newOrdinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10239, 1047, 1396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 951, 968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 1020, 1034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 1243, 1287);

                f_10239_1243_1286((object)originalParam != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 1303, 1340);

                _suppressOptional = suppressOptional;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 1354, 1385);

                _originalParam = originalParam;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10239, 1047, 1396);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 1047, 1396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 1047, 1396);
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 1450, 1457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 1453, 1457);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 1450, 1457);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 1450, 1457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 1450, 1457);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsDiscard
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 1501, 1528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 1504, 1528);
                    return f_10239_1504_1528(_originalParam); DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 1501, 1528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 1501, 1528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 1501, 1528);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 1639, 1932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 1872, 1917);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 1639, 1932);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 1541, 1943);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 1541, 1943);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsParams
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 2009, 2070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 2015, 2068);

                    return !_suppressOptional && (DynAbs.Tracing.TraceSender.Expression_True(10239, 2022, 2067) && f_10239_2044_2067(_originalParam));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 2009, 2070);

                    bool
                    f_10239_2044_2067(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsParams;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 2044, 2067);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 1955, 2081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 1955, 2081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 2159, 2374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 2260, 2359);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10239, 2267, 2284) || ((_suppressOptional && DynAbs.Tracing.TraceSender.Conditional_F2(10239, 2287, 2322)) || DynAbs.Tracing.TraceSender.Conditional_F3(10239, 2325, 2358))) ? f_10239_2287_2322(_originalParam) : f_10239_2325_2358(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 2159, 2374);

                    bool
                    f_10239_2287_2322(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasOptionalAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 2287, 2322);
                        return return_v;
                    }


                    bool
                    f_10239_2325_2358(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 2325, 2358);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 2093, 2385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 2093, 2385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue ExplicitDefaultConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 2482, 2713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 2583, 2698);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10239, 2590, 2607) || ((_suppressOptional && DynAbs.Tracing.TraceSender.Conditional_F2(10239, 2610, 2651)) || DynAbs.Tracing.TraceSender.Conditional_F3(10239, 2654, 2697))) ? f_10239_2610_2651(_originalParam) : f_10239_2654_2697(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 2482, 2713);

                    Microsoft.CodeAnalysis.ConstantValue
                    f_10239_2610_2651(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.DefaultValueFromAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 2610, 2651);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10239_2654_2697(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitDefaultConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 2654, 2697);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 2397, 2724);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 2397, 2724);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue DefaultValueFromAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 2819, 2876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 2825, 2874);

                    return f_10239_2832_2873(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 2819, 2876);

                    Microsoft.CodeAnalysis.ConstantValue
                    f_10239_2832_2873(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.DefaultValueFromAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 2832, 2873);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 2736, 2887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 2736, 2887);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ParameterSymbol WithCustomModifiersAndParams(TypeSymbol newType, ImmutableArray<CustomModifier> newCustomModifiers, ImmutableArray<CustomModifier> newRefCustomModifiers, bool newIsParams)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 2899, 3418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 3129, 3407);

                return f_10239_3136_3406(f_10239_3186_3298(_originalParam, newType, newCustomModifiers, newRefCustomModifiers, newIsParams), f_10239_3317_3338(this), f_10239_3357_3369(this), _suppressOptional);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 2899, 3418);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                f_10239_3186_3298(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                newCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                newRefCustomModifiers, bool
                newIsParams)
                {
                    var return_v = this_param.WithCustomModifiersAndParamsCore(newType, newCustomModifiers, newRefCustomModifiers, newIsParams);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10239, 3186, 3298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10239_3317_3338(Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 3317, 3338);
                    return return_v;
                }


                int
                f_10239_3357_3369(Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 3357, 3369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol
                f_10239_3136_3406(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                originalParam, Microsoft.CodeAnalysis.CSharp.Symbol
                newOwner, int
                newOrdinal, bool
                suppressOptional)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol(originalParam, newOwner, newOrdinal, suppressOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10239, 3136, 3406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 2899, 3418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 2899, 3418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 3539, 3589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 3545, 3587);

                    return f_10239_3552_3586(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 3539, 3589);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10239_3552_3586(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 3552, 3586);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 3459, 3600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 3459, 3600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 3668, 3706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 3674, 3704);

                    return f_10239_3681_3703(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 3668, 3706);

                    Microsoft.CodeAnalysis.RefKind
                    f_10239_3681_3703(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 3681, 3703);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 3612, 3717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 3612, 3717);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 3789, 3832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 3795, 3830);

                    return f_10239_3802_3829(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 3789, 3832);

                    bool
                    f_10239_3802_3829(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 3802, 3829);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 3729, 3843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 3729, 3843);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 3916, 3960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 3922, 3958);

                    return f_10239_3929_3957(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 3916, 3960);

                    bool
                    f_10239_3929_3957(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataOut;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 3929, 3957);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 3855, 3971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 3855, 3971);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 4058, 4098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 4064, 4096);

                    return f_10239_4071_4095(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 4058, 4098);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10239_4071_4095(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 4071, 4095);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 3983, 4109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 3983, 4109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 4121, 4262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 4213, 4251);

                return f_10239_4220_4250(_originalParam);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 4121, 4262);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10239_4220_4250(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10239, 4220, 4250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 4121, 4262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 4121, 4262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 4333, 4368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 4339, 4366);

                    return f_10239_4346_4365(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 4333, 4368);

                    string
                    f_10239_4346_4365(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 4346, 4365);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 4274, 4379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 4274, 4379);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 4481, 4530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 4487, 4528);

                    return f_10239_4494_4527(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 4481, 4530);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10239_4494_4527(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 4494, 4527);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 4391, 4541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 4391, 4541);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 4651, 4704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 4657, 4702);

                    return f_10239_4664_4701(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 4651, 4704);

                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10239_4664_4701(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 4664, 4701);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 4553, 4715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 4553, 4715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIDispatchConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 4794, 4844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 4800, 4842);

                    return f_10239_4807_4841(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 4794, 4844);

                    bool
                    f_10239_4807_4841(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsIDispatchConstant;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 4807, 4841);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 4727, 4855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 4727, 4855);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIUnknownConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 4933, 4982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 4939, 4980);

                    return f_10239_4946_4979(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 4933, 4982);

                    bool
                    f_10239_4946_4979(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsIUnknownConstant;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 4946, 4979);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 4867, 4993);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 4867, 4993);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerFilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 5069, 5116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 5075, 5114);

                    return f_10239_5082_5113(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 5069, 5116);

                    bool
                    f_10239_5082_5113(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsCallerFilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 5082, 5113);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 5005, 5127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 5005, 5127);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 5205, 5254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 5211, 5252);

                    return f_10239_5218_5251(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 5205, 5254);

                    bool
                    f_10239_5218_5251(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsCallerLineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 5218, 5251);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 5139, 5265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 5139, 5265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerMemberName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 5343, 5392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 5349, 5390);

                    return f_10239_5356_5389(_originalParam);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 5343, 5392);

                    bool
                    f_10239_5356_5389(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsCallerMemberName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 5356, 5389);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 5277, 5403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 5277, 5403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 5505, 5549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 5511, 5547);

                    return FlowAnalysisAnnotations.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 5505, 5549);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 5415, 5560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 5415, 5560);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableHashSet<string> NotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10239, 5665, 5711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10239, 5671, 5709);

                    return ImmutableHashSet<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10239, 5665, 5711);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10239, 5572, 5722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 5572, 5722);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceClonedParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10239, 772, 5751);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10239, 772, 5751);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10239, 772, 5751);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10239, 772, 5751);

        int
        f_10239_1243_1286(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10239, 1243, 1286);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10239_1197_1205_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10239, 1047, 1396);
            return return_v;
        }


        bool
        f_10239_1504_1528(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
        this_param)
        {
            var return_v = this_param.IsDiscard;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10239, 1504, 1528);
            return return_v;
        }

    }
}
