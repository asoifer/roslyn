// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedParameterSymbolBase : ParameterSymbol
    {
        private readonly MethodSymbol? _container;

        private readonly TypeWithAnnotations _type;

        private readonly int _ordinal;

        private readonly string _name;

        private readonly RefKind _refKind;

        public SynthesizedParameterSymbolBase(
                    MethodSymbol? container,
                    TypeWithAnnotations type,
                    int ordinal,
                    RefKind refKind,
                    string name = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10687, 892, 1416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 692, 702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 787, 795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 830, 835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 871, 879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1119, 1152);

                f_10687_1119_1151(type.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1166, 1199);

                f_10687_1166_1198(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1213, 1246);

                f_10687_1213_1245(ordinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1262, 1285);

                _container = container;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1299, 1312);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1326, 1345);

                _ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1359, 1378);

                _refKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1392, 1405);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10687, 892, 1416);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 892, 1416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 892, 1416);
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 1484, 1492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1487, 1492);
                    return _type; DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 1484, 1492);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 1484, 1492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 1484, 1492);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 1537, 1548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1540, 1548);
                    return _refKind; DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 1537, 1548);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 1537, 1548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 1537, 1548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsDiscard
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 1599, 1607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1602, 1607);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 1599, 1607);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 1599, 1607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 1599, 1607);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 1656, 1680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1659, 1680);
                    return f_10687_1659_1666() == RefKind.In; DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 1656, 1680);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 1656, 1680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 1656, 1680);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 1730, 1755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1733, 1755);
                    return f_10687_1733_1740() == RefKind.Out; DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 1730, 1755);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 1730, 1755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 1730, 1755);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 1820, 1841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 1826, 1839);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 1820, 1841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 1768, 1852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 1768, 1852);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract override ImmutableArray<CustomModifier> RefCustomModifiers { get; }

        public override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 2011, 2035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 2017, 2033);

                    return _ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 2011, 2035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 1959, 2046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 1959, 2046);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 2112, 2133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 2118, 2131);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 2112, 2133);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 2058, 2144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 2058, 2144);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 2222, 2243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 2228, 2241);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 2222, 2243);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 2156, 2254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 2156, 2254);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 2332, 2352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 2338, 2350);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 2332, 2352);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 2266, 2363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 2266, 2363);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue? ExplicitDefaultConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 2461, 2481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 2467, 2479);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 2461, 2481);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 2375, 2492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 2375, 2492);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 2571, 2592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 2577, 2590);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 2571, 2592);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 2504, 2603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 2504, 2603);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 2681, 2702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 2687, 2700);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 2681, 2702);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 2615, 2713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 2615, 2713);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 2791, 2812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 2797, 2810);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 2791, 2812);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 2725, 2823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 2725, 2823);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 2899, 2920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 2905, 2918);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 2899, 2920);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 2835, 2931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 2835, 2931);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 3009, 3030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 3015, 3028);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 3009, 3030);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 2943, 3041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 2943, 3041);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 3143, 3187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 3149, 3185);

                    return FlowAnalysisAnnotations.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 3143, 3187);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 3053, 3198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 3053, 3198);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 3303, 3349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 3309, 3347);

                    return ImmutableHashSet<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 3303, 3349);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 3210, 3360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 3210, 3360);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 3437, 3463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 3443, 3461);

                    return _container;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 3437, 3463);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 3372, 3474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 3372, 3474);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 3561, 3607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 3567, 3605);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 3561, 3607);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 3486, 3618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 3486, 3618);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 3728, 3824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 3764, 3809);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 3728, 3824);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 3630, 3835);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 3630, 3835);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 3847, 5849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 4411, 4455);

                var
                compilation = f_10687_4429_4454(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 4469, 4505);

                var
                type = f_10687_4480_4504(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 4519, 4840) || true) && (f_10687_4523_4550(type.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10687, 4523, 4592) && f_10687_4554_4592(compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10687, 4523, 4624) && f_10687_4596_4624(compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10687, 4519, 4840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 4658, 4825);

                    f_10687_4658_4824(ref attributes, f_10687_4698_4823(compilation, type.Type, type.CustomModifiers.Length + this.RefCustomModifiers.Length, f_10687_4810_4822(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10687, 4519, 4840);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 4856, 5047) || true) && (f_10687_4860_4893(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10687, 4856, 5047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 4927, 5032);

                    f_10687_4927_5031(ref attributes, f_10687_4967_5030(moduleBuilder, this, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10687, 4856, 5047);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 5063, 5395) || true) && (f_10687_5067_5097(type.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10687, 5067, 5153) && f_10687_5118_5153(compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10687, 5067, 5231) && f_10687_5174_5231(compilation, SpecialType.System_String)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10687, 5063, 5395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 5265, 5380);

                    f_10687_5265_5379(ref attributes, f_10687_5326_5378(compilation, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10687, 5063, 5395);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 5411, 5643) || true) && (f_10687_5415_5461(compilation, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10687, 5411, 5643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 5495, 5628);

                    f_10687_5495_5627(ref attributes, f_10687_5535_5626(moduleBuilder, this, f_10687_5594_5619(this), type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10687, 5411, 5643);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 5659, 5838) || true) && (f_10687_5663_5675(this) == RefKind.RefReadOnly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10687, 5659, 5838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 5732, 5823);

                    f_10687_5732_5822(ref attributes, f_10687_5772_5821(moduleBuilder, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10687, 5659, 5838);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 3847, 5849);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10687_4429_4454(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 4429, 4454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10687_4480_4504(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 4480, 4504);
                    return return_v;
                }


                bool
                f_10687_4523_4550(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 4523, 4550);
                    return return_v;
                }


                bool
                f_10687_4554_4592(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.HasDynamicEmitAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 4554, 4592);
                    return return_v;
                }


                bool
                f_10687_4596_4624(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.CanEmitBoolean();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 4596, 4624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10687_4810_4822(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 4810, 4822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10687_4698_4823(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, int
                customModifiersCount, Microsoft.CodeAnalysis.RefKind
                refKindOpt)
                {
                    var return_v = this_param.SynthesizeDynamicAttribute(type, customModifiersCount, refKindOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 4698, 4823);
                    return return_v;
                }


                int
                f_10687_4658_4824(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 4658, 4824);
                    return 0;
                }


                bool
                f_10687_4860_4893(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 4860, 4893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10687_4967_5030(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbolBase
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 4967, 5030);
                    return return_v;
                }


                int
                f_10687_4927_5031(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 4927, 5031);
                    return 0;
                }


                bool
                f_10687_5067_5097(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5067, 5097);
                    return return_v;
                }


                bool
                f_10687_5118_5153(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.HasTupleNamesAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 5118, 5153);
                    return return_v;
                }


                bool
                f_10687_5174_5231(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.CanEmitSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5174, 5231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10687_5326_5378(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeTupleNamesAttribute(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5326, 5378);
                    return return_v;
                }


                int
                f_10687_5265_5379(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5265, 5379);
                    return 0;
                }


                bool
                f_10687_5415_5461(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbolBase
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5415, 5461);
                    return return_v;
                }


                byte?
                f_10687_5594_5619(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5594, 5619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10687_5535_5626(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbolBase
                symbol, byte?
                nullableContextValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, nullableContextValue, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5535, 5626);
                    return return_v;
                }


                int
                f_10687_5495_5627(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5495, 5627);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10687_5663_5675(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 5663, 5675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10687_5772_5821(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbolBase
                symbol)
                {
                    var return_v = this_param.SynthesizeIsReadOnlyAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5772, 5821);
                    return return_v;
                }


                int
                f_10687_5732_5822(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 5732, 5822);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 3847, 5849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 3847, 5849);
            }
        }

        static SynthesizedParameterSymbolBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10687, 572, 5856);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10687, 572, 5856);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 572, 5856);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10687, 572, 5856);

        int
        f_10687_1119_1151(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 1119, 1151);
            return 0;
        }


        int
        f_10687_1166_1198(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 1166, 1198);
            return 0;
        }


        int
        f_10687_1213_1245(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 1213, 1245);
            return 0;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10687_1659_1666()
        {
            var return_v = RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 1659, 1666);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10687_1733_1740()
        {
            var return_v = RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 1733, 1740);
            return return_v;
        }

    }
    internal sealed class SynthesizedParameterSymbol : SynthesizedParameterSymbolBase
    {
        private SynthesizedParameterSymbol(
                    MethodSymbol? container,
                    TypeWithAnnotations type,
                    int ordinal,
                    RefKind refKind,
                    string name)
        : base(f_10687_6177_6186_C(container), type, ordinal, refKind, name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10687, 5962, 6239);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10687, 5962, 6239);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 5962, 6239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 5962, 6239);
            }
        }

        public static ParameterSymbol Create(
                    MethodSymbol? container,
                    TypeWithAnnotations type,
                    int ordinal,
                    RefKind refKind,
                    string name = "",
                    ImmutableArray<CustomModifier> refCustomModifiers = default,
                    SourceComplexParameterSymbol? baseParameterForAttributes = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10687, 6251, 7129);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 6629, 6834) || true) && (refCustomModifiers.IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10687, 6633, 6706) && baseParameterForAttributes is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10687, 6629, 6834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 6740, 6819);

                    return f_10687_6747_6818(container, type, ordinal, refKind, name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10687, 6629, 6834);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 6850, 7118);

                return f_10687_6857_7117(container, type, ordinal, refKind, name, refCustomModifiers.NullToEmpty(), baseParameterForAttributes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10687, 6251, 7129);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbol
                f_10687_6747_6818(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedParameterSymbol(container, type, ordinal, refKind, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 6747, 6818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedComplexParameterSymbol
                f_10687_6857_7117(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol?
                baseParameterForAttributes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedComplexParameterSymbol(container, type, ordinal, refKind, name, refCustomModifiers, baseParameterForAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 6857, 7117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 6251, 7129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 6251, 7129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<ParameterSymbol> DeriveParameters(MethodSymbol sourceMethod, MethodSymbol destinationMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10687, 7547, 8414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 7695, 7753);

                var
                builder = f_10687_7709_7752()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 7769, 8351);
                    foreach (var oldParam in f_10687_7794_7817_I(f_10687_7794_7817(sourceMethod)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10687, 7769, 8351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 7851, 7914);

                        f_10687_7851_7913(!(oldParam is SynthesizedComplexParameterSymbol));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 8005, 8336);

                        f_10687_8005_8335(                //same properties as the old one, just change the owner
                                        builder, f_10687_8017_8334(destinationMethod, f_10687_8086_8114(oldParam), f_10687_8137_8153(oldParam), f_10687_8176_8192(oldParam), f_10687_8215_8228(oldParam), f_10687_8251_8278(oldParam), baseParameterForAttributes: null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10687, 7769, 8351);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10687, 1, 583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10687, 1, 583);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 8367, 8403);

                return f_10687_8374_8402(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10687, 7547, 8414);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10687_7709_7752()
                {
                    var return_v = ArrayBuilder<ParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 7709, 7752);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10687_7794_7817(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 7794, 7817);
                    return return_v;
                }


                int
                f_10687_7851_7913(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 7851, 7913);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10687_8086_8114(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 8086, 8114);
                    return return_v;
                }


                int
                f_10687_8137_8153(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 8137, 8153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10687_8176_8192(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 8176, 8192);
                    return return_v;
                }


                string
                f_10687_8215_8228(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 8215, 8228);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10687_8251_8278(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 8251, 8278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10687_8017_8334(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol?
                baseParameterForAttributes)
                {
                    var return_v = Create(container, type, ordinal, refKind, name, refCustomModifiers, baseParameterForAttributes: baseParameterForAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 8017, 8334);
                    return return_v;
                }


                int
                f_10687_8005_8335(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 8005, 8335);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10687_7794_7817_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 7794, 7817);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10687_8374_8402(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 8374, 8402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 7547, 8414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 7547, 8414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 8516, 8568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 8522, 8566);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 8516, 8568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 8426, 8579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 8426, 8579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData? MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 8690, 8710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 8696, 8708);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 8690, 8710);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 8591, 8721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 8591, 8721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10687, 5864, 8728);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10687, 5864, 8728);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 5864, 8728);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10687, 5864, 8728);

        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_10687_6177_6186_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10687, 5962, 6239);
            return return_v;
        }

    }
    internal sealed class SynthesizedComplexParameterSymbol : SynthesizedParameterSymbolBase
    {
        private readonly ImmutableArray<CustomModifier> _refCustomModifiers;

        private readonly SourceComplexParameterSymbol? _baseParameterForAttributes;

        public SynthesizedComplexParameterSymbol(
                    MethodSymbol? container,
                    TypeWithAnnotations type,
                    int ordinal,
                    RefKind refKind,
                    string name,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    SourceComplexParameterSymbol? baseParameterForAttributes)
        : base(f_10687_9464_9473_C(container), type, ordinal, refKind, name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10687, 9108, 9808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 9068, 9095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 9529, 9573);

                f_10687_9529_9572(f_10687_9542_9571_M(!refCustomModifiers.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 9587, 9669);

                f_10687_9587_9668(f_10687_9600_9627_M(!refCustomModifiers.IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10687, 9600, 9667) || baseParameterForAttributes is object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 9685, 9726);

                _refCustomModifiers = refCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 9740, 9797);

                _baseParameterForAttributes = baseParameterForAttributes;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10687, 9108, 9808);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 9108, 9808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 9108, 9808);
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 9910, 9945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 9916, 9943);

                    return _refCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 9910, 9945);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 9820, 9956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 9820, 9956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 9968, 10168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 10060, 10157);

                return f_10687_10067_10111_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_baseParameterForAttributes, 10687, 10067, 10111)?.GetAttributes()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?>(10687, 10067, 10156) ?? ImmutableArray<CSharpAttributeData>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 9968, 10168);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                f_10687_10067_10111_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 10067, 10111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 9968, 10168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 9968, 10168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasEnumeratorCancellationAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 10227, 10302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 10230, 10302);
                    return f_10687_10230_10293_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_baseParameterForAttributes, 10687, 10230, 10293)?.HasEnumeratorCancellationAttribute) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10687, 10230, 10302) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 10227, 10302);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 10227, 10302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 10227, 10302);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData? MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10687, 10390, 10444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10687, 10393, 10444);
                    return f_10687_10393_10444_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_baseParameterForAttributes, 10687, 10393, 10444)?.MarshallingInformation); DynAbs.Tracing.TraceSender.TraceExitMethod(10687, 10390, 10444);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10687, 10390, 10444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 10390, 10444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedComplexParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10687, 8736, 10452);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10687, 8736, 10452);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10687, 8736, 10452);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10687, 8736, 10452);

        bool
        f_10687_9542_9571_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 9542, 9571);
            return return_v;
        }


        int
        f_10687_9529_9572(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 9529, 9572);
            return 0;
        }


        bool
        f_10687_9600_9627_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 9600, 9627);
            return return_v;
        }


        int
        f_10687_9587_9668(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10687, 9587, 9668);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_10687_9464_9473_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10687, 9108, 9808);
            return return_v;
        }


        bool?
        f_10687_10230_10293_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 10230, 10293);
            return return_v;
        }


        Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData?
        f_10687_10393_10444_M(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10687, 10393, 10444);
            return return_v;
        }

    }
}
