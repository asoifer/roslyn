// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.CSharp.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class WrappedParameterSymbol : ParameterSymbol
    {
        protected readonly ParameterSymbol _underlyingParameter;

        protected WrappedParameterSymbol(ParameterSymbol underlyingParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10387, 1044, 1263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 1011, 1031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 1138, 1188);

                f_10387_1138_1187((object)underlyingParameter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 1204, 1252);

                this._underlyingParameter = underlyingParameter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10387, 1044, 1263);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 1044, 1263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 1044, 1263);
            }
        }

        public ParameterSymbol UnderlyingParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 1318, 1341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 1321, 1341);
                    return _underlyingParameter; DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 1318, 1341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 1318, 1341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 1318, 1341);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 1392, 1425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 1395, 1425);
                    return f_10387_1395_1425(_underlyingParameter); DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 1392, 1425);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 1392, 1425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 1392, 1425);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 1547, 1603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 1553, 1601);

                    return f_10387_1560_1600(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 1547, 1603);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10387_1560_1600(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 1560, 1600);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 1467, 1614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 1467, 1614);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 1689, 1733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 1695, 1731);

                    return f_10387_1702_1730(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 1689, 1733);

                    Microsoft.CodeAnalysis.RefKind
                    f_10387_1702_1730(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 1702, 1730);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 1626, 1744);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 1626, 1744);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 1823, 1872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 1829, 1870);

                    return f_10387_1836_1869(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 1823, 1872);

                    bool
                    f_10387_1836_1869(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 1836, 1869);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 1756, 1883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 1756, 1883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 1963, 2013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 1969, 2011);

                    return f_10387_1976_2010(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 1963, 2013);

                    bool
                    f_10387_1976_2010(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataOut;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 1976, 2010);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 1895, 2024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 1895, 2024);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 2118, 2164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 2124, 2162);

                    return f_10387_2131_2161(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 2118, 2164);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10387_2131_2161(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 2131, 2161);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 2036, 2175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 2036, 2175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 2292, 2354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 2298, 2352);

                    return f_10387_2305_2351(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 2292, 2354);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10387_2305_2351(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 2305, 2351);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 2187, 2365);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 2187, 2365);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 2377, 2524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 2469, 2513);

                return f_10387_2476_2512(_underlyingParameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 2377, 2524);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10387_2476_2512(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10387, 2476, 2512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 2377, 2524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 2377, 2524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 2536, 2782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 2694, 2771);

                f_10387_2694_2770(_underlyingParameter, moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 2536, 2782);

                int
                f_10387_2694_2770(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes)
                {
                    this_param.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10387, 2694, 2770);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 2536, 2782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 2536, 2782);
            }
        }

        internal sealed override ConstantValue ExplicitDefaultConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 2886, 2951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 2892, 2949);

                    return f_10387_2899_2948(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 2886, 2951);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10387_2899_2948(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitDefaultConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 2899, 2948);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 2794, 2962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 2794, 2962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 3026, 3070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 3032, 3068);

                    return f_10387_3039_3067(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 3026, 3070);

                    int
                    f_10387_3039_3067(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 3039, 3067);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 2974, 3081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 2974, 3081);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 3147, 3192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 3153, 3190);

                    return f_10387_3160_3189(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 3147, 3192);

                    bool
                    f_10387_3160_3189(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsParams;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 3160, 3189);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 3093, 3203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 3093, 3203);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 3281, 3336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 3287, 3334);

                    return f_10387_3294_3333(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 3281, 3336);

                    bool
                    f_10387_3294_3333(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 3294, 3333);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 3215, 3347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 3215, 3347);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 3425, 3482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 3431, 3480);

                    return f_10387_3438_3479(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 3425, 3482);

                    bool
                    f_10387_3438_3479(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 3438, 3479);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 3359, 3493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 3359, 3493);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 3564, 3605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 3570, 3603);

                    return f_10387_3577_3602(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 3564, 3605);

                    string
                    f_10387_3577_3602(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 3577, 3602);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 3505, 3616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 3505, 3616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 3695, 3744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 3701, 3742);

                    return f_10387_3708_3741(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 3695, 3744);

                    string
                    f_10387_3708_3741(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 3708, 3741);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 3628, 3755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 3628, 3755);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 3857, 3912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 3863, 3910);

                    return f_10387_3870_3909(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 3857, 3912);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10387_3870_3909(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 3870, 3909);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 3767, 3923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 3767, 3923);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 4033, 4092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 4039, 4090);

                    return f_10387_4046_4089(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 4033, 4092);

                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10387_4046_4089(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 4046, 4089);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 3935, 4103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 3935, 4103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override UnmanagedType MarshallingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 4187, 4239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 4193, 4237);

                    return f_10387_4200_4236(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 4187, 4239);

                    System.Runtime.InteropServices.UnmanagedType
                    f_10387_4200_4236(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 4200, 4236);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 4115, 4250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 4115, 4250);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 4329, 4385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 4335, 4383);

                    return f_10387_4342_4382(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 4329, 4385);

                    bool
                    f_10387_4342_4382(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsIDispatchConstant;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 4342, 4382);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 4262, 4396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 4262, 4396);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 4474, 4529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 4480, 4527);

                    return f_10387_4487_4526(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 4474, 4529);

                    bool
                    f_10387_4487_4526(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsIUnknownConstant;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 4487, 4526);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 4408, 4540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 4408, 4540);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 4618, 4673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 4624, 4671);

                    return f_10387_4631_4670(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 4618, 4673);

                    bool
                    f_10387_4631_4670(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsCallerLineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 4631, 4670);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 4552, 4684);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 4552, 4684);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 4760, 4813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 4766, 4811);

                    return f_10387_4773_4810(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 4760, 4813);

                    bool
                    f_10387_4773_4810(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsCallerFilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 4773, 4810);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 4696, 4824);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 4696, 4824);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 4902, 4957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 4908, 4955);

                    return f_10387_4915_4954(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 4902, 4957);

                    bool
                    f_10387_4915_4954(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsCallerMemberName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 4915, 4954);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 4836, 4968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 4836, 4968);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 5163, 5223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 5169, 5221);

                    return f_10387_5176_5220(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 5163, 5223);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                    f_10387_5176_5220(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.FlowAnalysisAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 5176, 5220);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 4980, 5234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 4980, 5234);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 5339, 5401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 5345, 5399);

                    return f_10387_5352_5398(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 5339, 5401);

                    System.Collections.Immutable.ImmutableHashSet<string>
                    f_10387_5352_5398(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.NotNullIfParameterNotNull;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 5352, 5398);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 5246, 5412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 5246, 5412);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10387, 5424, 5730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10387, 5611, 5719);

                return f_10387_5618_5718(_underlyingParameter, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10387, 5424, 5730);

                string
                f_10387_5618_5718(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10387, 5618, 5718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10387, 5424, 5730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 5424, 5730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WrappedParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10387, 895, 5759);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10387, 895, 5759);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10387, 895, 5759);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10387, 895, 5759);

        int
        f_10387_1138_1187(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10387, 1138, 1187);
            return 0;
        }


        bool
        f_10387_1395_1425(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsDiscard;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10387, 1395, 1425);
            return return_v;
        }

    }
}
