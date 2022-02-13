// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ThisParameterSymbol : ParameterSymbol
    {
        internal const string
        SymbolName = "this"
        ;

        private readonly MethodSymbol _containingMethod;

        private readonly TypeSymbol _containingType;

        internal ThisParameterSymbol(MethodSymbol forMethod) : this(f_10281_833_842_C(forMethod), f_10281_844_868(forMethod))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10281, 773, 891);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10281, 773, 891);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 773, 891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 773, 891);
            }
        }

        internal ThisParameterSymbol(MethodSymbol forMethod, TypeSymbol containingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10281, 903, 1095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 689, 706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 745, 760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1007, 1037);

                _containingMethod = forMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1051, 1084);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10281, 903, 1095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 903, 1095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 903, 1095);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 1135, 1148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1138, 1148);
                    return SymbolName; DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 1135, 1148);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 1135, 1148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 1135, 1148);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 1192, 1200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1195, 1200);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 1192, 1200);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 1192, 1200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 1192, 1200);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 1282, 1361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1285, 1361);
                    return TypeWithAnnotations.Create(_containingType, NullableAnnotation.NotAnnotated); DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 1282, 1361);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 1282, 1361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 1282, 1361);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 1430, 1958);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1466, 1594) || true) && (f_10281_1470_1494_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10281_1470_1484(), 10281, 1470, 1494)?.TypeKind) != TypeKind.Struct)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10281, 1466, 1594);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1555, 1575);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10281, 1466, 1594);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1614, 1753) || true) && (f_10281_1618_1647_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_containingMethod, 10281, 1618, 1647)?.MethodKind) == MethodKind.Constructor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10281, 1614, 1753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1715, 1734);

                        return RefKind.Out;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10281, 1614, 1753);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1773, 1904) || true) && (f_10281_1777_1817_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_containingMethod, 10281, 1777, 1817)?.IsEffectivelyReadOnly) == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10281, 1773, 1904);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1867, 1885);

                        return RefKind.In;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10281, 1773, 1904);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 1924, 1943);

                    return RefKind.Ref;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 1430, 1958);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10281_1470_1484()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10281, 1470, 1484);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind?
                    f_10281_1470_1494_M(Microsoft.CodeAnalysis.TypeKind?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10281, 1470, 1494);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind?
                    f_10281_1618_1647_M(Microsoft.CodeAnalysis.MethodKind?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10281, 1618, 1647);
                        return return_v;
                    }


                    bool?
                    f_10281_1777_1817_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10281, 1777, 1817);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 1374, 1969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 1374, 1969);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 2056, 2168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 2062, 2166);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10281, 2069, 2102) || (((object)_containingMethod != null && DynAbs.Tracing.TraceSender.Conditional_F2(10281, 2105, 2132)) || DynAbs.Tracing.TraceSender.Conditional_F3(10281, 2135, 2165))) ? f_10281_2105_2132(_containingMethod) : ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 2056, 2168);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10281_2105_2132(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10281, 2105, 2132);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 1981, 2179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 1981, 2179);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 2289, 2342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 2295, 2340);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 2289, 2342);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 2191, 2353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 2191, 2353);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 2429, 2489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 2435, 2487);

                    return (Symbol)_containingMethod ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol>(10281, 2442, 2486) ?? _containingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 2429, 2489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 2365, 2500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 2365, 2500);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 2597, 2617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 2603, 2615);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 2597, 2617);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 2512, 2628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 2512, 2628);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 2706, 2727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 2712, 2725);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 2706, 2727);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 2640, 2738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 2640, 2738);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 2804, 2825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 2810, 2823);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 2804, 2825);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 2750, 2836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 2750, 2836);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 2915, 2936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 2921, 2934);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 2915, 2936);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 2848, 2947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 2848, 2947);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 3025, 3046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 3031, 3044);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 3025, 3046);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 2959, 3057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 2959, 3057);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 3133, 3154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 3139, 3152);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 3133, 3154);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 3069, 3165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 3069, 3165);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 3243, 3264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 3249, 3262);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 3243, 3264);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 3177, 3275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 3177, 3275);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 3353, 3374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 3359, 3372);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 3353, 3374);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 3287, 3385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 3287, 3385);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 3487, 3531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 3493, 3529);

                    return FlowAnalysisAnnotations.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 3487, 3531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 3397, 3542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 3397, 3542);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 3647, 3693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 3653, 3691);

                    return ImmutableHashSet<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 3647, 3693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 3554, 3704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 3554, 3704);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 3768, 3786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 3774, 3784);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 3768, 3786);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 3716, 3797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 3716, 3797);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 3899, 3951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 3905, 3949);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 3899, 3951);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 3809, 3962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 3809, 3962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsThis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 4052, 4072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 4058, 4070);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 4052, 4072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 4000, 4083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 4000, 4083);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 4210, 4230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 4216, 4228);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 4210, 4230);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 4144, 4241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 4144, 4241);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 4313, 4334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 4319, 4332);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 4313, 4334);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 4253, 4345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 4253, 4345);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 4418, 4439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 4424, 4437);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 4418, 4439);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 4357, 4450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 4357, 4450);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10281, 4560, 4580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 4566, 4578);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10281, 4560, 4580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10281, 4462, 4591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 4462, 4591);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ThisParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10281, 529, 4598);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10281, 627, 646);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10281, 529, 4598);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10281, 529, 4598);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10281, 529, 4598);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10281_844_868(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10281, 844, 868);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10281_833_842_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10281, 773, 891);
            return return_v;
        }

    }
}
