// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedIntrinsicOperatorSymbol : MethodSymbol
    {
        private readonly TypeSymbol _containingType;

        private readonly string _name;

        private readonly ImmutableArray<ParameterSymbol> _parameters;

        private readonly TypeSymbol _returnType;

        private readonly bool _isCheckedBuiltin;

        public SynthesizedIntrinsicOperatorSymbol(TypeSymbol leftType, string name, TypeSymbol rightType, TypeSymbol returnType, bool isCheckedBuiltin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10684, 781, 2293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 542, 557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 592, 597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 707, 718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 751, 768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 949, 1711) || true) && (f_10684_953_1104(leftType, rightType, TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 949, 1711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1138, 1165);

                    _containingType = leftType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 949, 1711);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 949, 1711);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1199, 1711) || true) && (f_10684_1203_1356(rightType, returnType, TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 1199, 1711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1390, 1418);

                        _containingType = rightType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 1199, 1711);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 1199, 1711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1484, 1651);

                        f_10684_1484_1650(f_10684_1497_1649(leftType, returnType, TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1669, 1696);

                        _containingType = leftType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 1199, 1711);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 949, 1711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1727, 1740);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1754, 1779);

                _returnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1795, 1883);

                f_10684_1795_1882((f_10684_1809_1829(leftType) || (DynAbs.Tracing.TraceSender.Expression_False(10684, 1809, 1854) || f_10684_1833_1854(rightType))) == f_10684_1859_1881(returnType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1897, 1965);

                f_10684_1897_1964(f_10684_1910_1937(_containingType) == f_10684_1941_1963(returnType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 1981, 2231);

                _parameters = f_10684_1995_2230((new ParameterSymbol[] {f_10684_2019_2084(this, leftType, 0, "left"),
f_10684_2141_2208(this, rightType, 1, "right")}));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 2245, 2282);

                _isCheckedBuiltin = isCheckedBuiltin;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10684, 781, 2293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 781, 2293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 781, 2293);
            }
        }

        public SynthesizedIntrinsicOperatorSymbol(TypeSymbol container, string name, TypeSymbol returnType, bool isCheckedBuiltin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10684, 2305, 2752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 542, 557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 592, 597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 707, 718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 751, 768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 2452, 2480);

                _containingType = container;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 2494, 2507);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 2521, 2546);

                _returnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 2560, 2690);

                _parameters = f_10684_2574_2689((new ParameterSymbol[] { f_10684_2599_2666(this, container, 0, "value") }));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 2704, 2741);

                _isCheckedBuiltin = isCheckedBuiltin;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10684, 2305, 2752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 2305, 2752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 2305, 2752);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 2816, 2880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 2852, 2865);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 2816, 2880);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 2764, 2891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 2764, 2891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsCheckedBuiltin
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 2965, 3041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 3001, 3026);

                    return _isCheckedBuiltin;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 2965, 3041);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 2903, 3052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 2903, 3052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 3126, 3211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 3162, 3196);

                    return MethodKind.BuiltinOperator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 3126, 3211);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 3064, 3222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 3064, 3222);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 3300, 3363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 3336, 3348);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 3300, 3363);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 3234, 3374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 3234, 3374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CSharpCompilation DeclaringCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 3467, 3530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 3503, 3515);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 3467, 3530);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 3386, 3541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 3386, 3541);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 3553, 3651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 3628, 3640);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 3553, 3651);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 3553, 3651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 3553, 3651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 3663, 3803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 3779, 3792);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 3663, 3803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 3663, 3803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 3663, 3803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 3815, 3955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 3931, 3944);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 3815, 3955);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 3815, 3955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 3815, 3955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 4030, 4094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 4066, 4079);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 4030, 4094);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 3967, 4105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 3967, 4105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 4167, 4227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 4203, 4212);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 4167, 4227);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 4117, 4238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 4117, 4238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 4313, 4377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 4349, 4362);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 4313, 4377);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 4250, 4388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 4250, 4388);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 4462, 4525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 4498, 4510);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 4462, 4525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 4400, 4536);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 4400, 4536);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override System.Reflection.MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 4654, 4759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 4690, 4744);

                    return System.Reflection.MethodImplAttributes.Managed;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 4654, 4759);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 4548, 4770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 4548, 4770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 4852, 4916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 4888, 4901);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 4852, 4916);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 4782, 4927);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 4782, 4927);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 4939, 5035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 5012, 5024);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 4939, 5035);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 4939, 5035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 4939, 5035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 5108, 5153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 5114, 5151);

                    throw f_10684_5120_5150();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 5108, 5153);

                    System.Exception
                    f_10684_5120_5150()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 5120, 5150);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 5047, 5164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 5047, 5164);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 5176, 5360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 5278, 5349);

                return f_10684_5285_5348();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 5176, 5360);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10684_5285_5348()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.SecurityAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 5285, 5348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 5176, 5360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 5176, 5360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 5481, 5544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 5517, 5529);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 5481, 5544);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 5372, 5555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 5372, 5555);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 5637, 5701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 5673, 5686);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 5637, 5701);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 5567, 5712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 5567, 5712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HidesBaseMethodsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 5792, 5856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 5828, 5841);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 5792, 5856);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 5724, 5867);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 5724, 5867);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 5933, 5997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 5969, 5982);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 5933, 5997);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 5879, 6008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 5879, 6008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 6077, 6141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 6113, 6126);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 6077, 6141);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 6020, 6152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 6020, 6152);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 6217, 6281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 6253, 6266);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 6217, 6281);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 6164, 6292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 6164, 6292);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 6360, 6431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 6396, 6416);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 6360, 6431);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 6304, 6442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 6304, 6442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 6540, 6638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 6576, 6623);

                    return TypeWithAnnotations.Create(_returnType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 6540, 6638);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 6454, 6649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 6454, 6649);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 6735, 6766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 6738, 6766);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 6735, 6766);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 6735, 6766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 6735, 6766);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 6852, 6885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 6855, 6885);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 6852, 6885);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 6852, 6885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 6852, 6885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 6962, 6993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 6965, 6993);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 6962, 6993);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 6962, 6993);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 6962, 6993);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 7111, 7211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 7147, 7196);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 7111, 7211);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 7006, 7222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 7006, 7222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 7325, 7425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 7361, 7410);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 7325, 7425);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 7234, 7436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 7234, 7436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 7531, 7601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 7567, 7586);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 7531, 7601);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 7448, 7612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 7448, 7612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 7726, 7819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 7762, 7804);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 7726, 7819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 7624, 7830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 7624, 7830);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 7964, 7972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 7967, 7972);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 7964, 7972);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 7964, 7972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 7964, 7972);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 8019, 8027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 8022, 8027);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 8019, 8027);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 8019, 8027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 8019, 8027);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 8130, 8225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 8166, 8210);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 8130, 8225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 8040, 8236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 8040, 8236);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 8312, 8375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 8348, 8360);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 8312, 8375);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 8248, 8386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 8248, 8386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 8398, 8541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 8494, 8530);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 8398, 8541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 8398, 8541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 8398, 8541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 8635, 8723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 8671, 8708);

                    return Cci.CallingConvention.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 8635, 8723);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 8553, 8734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 8553, 8734);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 8811, 8875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 8847, 8860);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 8811, 8875);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 8746, 8886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 8746, 8886);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 8962, 9036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 8998, 9021);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 8962, 9036);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 8898, 9047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 8898, 9047);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 9130, 9223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 9166, 9208);

                    return _containingType as NamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 9130, 9223);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 9059, 9234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 9059, 9234);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 9321, 9410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 9357, 9395);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 9321, 9410);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 9246, 9421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 9246, 9421);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 9531, 9627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 9567, 9612);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 9531, 9627);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 9433, 9638);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 9433, 9638);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 9726, 9805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 9762, 9790);

                    return Accessibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 9726, 9805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 9650, 9816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 9650, 9816);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 9882, 9945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 9918, 9930);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 9882, 9945);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 9828, 9956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 9828, 9956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 10023, 10087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 10059, 10072);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 10023, 10087);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 9968, 10098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 9968, 10098);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 10166, 10230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 10202, 10215);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 10166, 10230);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 10110, 10241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 10110, 10241);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 10309, 10373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 10345, 10358);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 10309, 10373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 10253, 10384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 10253, 10384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 10450, 10514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 10486, 10499);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 10450, 10514);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 10396, 10525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 10396, 10525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 10591, 10655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 10627, 10640);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 10591, 10655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 10537, 10666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 10537, 10666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 10764, 10827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 10800, 10812);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 10764, 10827);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 10678, 10838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 10678, 10838);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 10966, 10973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 10969, 10973);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 10966, 10973);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 10966, 10973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 10966, 10973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 10986, 11148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 11100, 11137);

                throw f_10684_11106_11136();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 10986, 11148);

                System.Exception
                f_10684_11106_11136()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 11106, 11136);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 10986, 11148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 10986, 11148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 11218, 11226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 11221, 11226);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 11218, 11226);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 11218, 11226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 11218, 11226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 11239, 12368);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 11332, 11416) || true) && (obj == (object)this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 11332, 11416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 11389, 11401);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 11332, 11416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 11432, 11486);

                var
                other = obj as SynthesizedIntrinsicOperatorSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 11502, 11589) || true) && ((object)other == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 11502, 11589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 11561, 11574);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 11502, 11589);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 11605, 12328) || true) && (_isCheckedBuiltin == other._isCheckedBuiltin && (DynAbs.Tracing.TraceSender.Expression_True(10684, 11609, 11720) && _parameters.Length == other._parameters.Length) && (DynAbs.Tracing.TraceSender.Expression_True(10684, 11609, 11800) && f_10684_11741_11800(_name, other._name, StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(10684, 11609, 11891) && f_10684_11821_11891(_containingType, other._containingType, compareKind)) && (DynAbs.Tracing.TraceSender.Expression_True(10684, 11609, 11974) && f_10684_11912_11974(_returnType, other._returnType, compareKind)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 11605, 12328);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 12017, 12022);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 12008, 12281) || true) && (i < _parameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 12048, 12051)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 12008, 12281))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 12008, 12281);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 12093, 12262) || true) && (!f_10684_12098_12176(f_10684_12116_12135(_parameters[i]), f_10684_12137_12162(other._parameters[i]), compareKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 12093, 12262);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 12226, 12239);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 12093, 12262);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10684, 1, 274);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10684, 1, 274);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 12301, 12313);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 11605, 12328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 12344, 12357);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 11239, 12368);

                bool
                f_10684_11741_11800(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 11741, 11800);
                    return return_v;
                }


                bool
                f_10684_11821_11891(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 11821, 11891);
                    return return_v;
                }


                bool
                f_10684_11912_11974(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 11912, 11974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10684_12116_12135(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 12116, 12135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10684_12137_12162(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 12137, 12162);
                    return return_v;
                }


                bool
                f_10684_12098_12176(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 12098, 12176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 11239, 12368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 11239, 12368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 12380, 12527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 12438, 12516);

                return f_10684_12445_12515(_name, f_10684_12465_12514(_containingType, _parameters.Length));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 12380, 12527);

                int
                f_10684_12465_12514(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 12465, 12514);
                    return return_v;
                }


                int
                f_10684_12445_12515(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 12445, 12515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 12380, 12527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 12380, 12527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class SynthesizedOperatorParameterSymbol : SynthesizedParameterSymbolBase
        {
            public SynthesizedOperatorParameterSymbol(
                            SynthesizedIntrinsicOperatorSymbol container,
                            TypeSymbol type,
                            int ordinal,
                            string name
                        ) : base(f_10684_12873_12882_C(container), TypeWithAnnotations.Create(type), ordinal, RefKind.None, name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10684, 12652, 12976);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10684, 12652, 12976);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 12652, 12976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 12652, 12976);
                }
            }

            public override bool Equals(Symbol obj, TypeCompareKind compareKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 12992, 13513);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 13093, 13189) || true) && (obj == (object)this)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 13093, 13189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 13158, 13170);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 13093, 13189);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 13209, 13263);

                    var
                    other = obj as SynthesizedOperatorParameterSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 13283, 13382) || true) && ((object)other == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10684, 13283, 13382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 13350, 13363);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10684, 13283, 13382);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 13402, 13498);

                    return f_10684_13409_13416() == f_10684_13420_13433(other) && (DynAbs.Tracing.TraceSender.Expression_True(10684, 13409, 13497) && f_10684_13437_13497(f_10684_13437_13453(), f_10684_13461_13483(other), compareKind));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 12992, 13513);

                    int
                    f_10684_13409_13416()
                    {
                        var return_v = Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 13409, 13416);
                        return return_v;
                    }


                    int
                    f_10684_13420_13433(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol.SynthesizedOperatorParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 13420, 13433);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10684_13437_13453()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 13437, 13453);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10684_13461_13483(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol.SynthesizedOperatorParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 13461, 13483);
                        return return_v;
                    }


                    bool
                    f_10684_13437_13497(Microsoft.CodeAnalysis.CSharp.Symbol?
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                    other, Microsoft.CodeAnalysis.TypeCompareKind
                    compareKind)
                    {
                        var return_v = this_param.Equals(other, compareKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 13437, 13497);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 12992, 13513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 12992, 13513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 13529, 13671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 13595, 13656);

                    return f_10684_13602_13655(f_10684_13615_13631(), f_10684_13633_13654(f_10684_13633_13640()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 13529, 13671);

                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10684_13615_13631()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 13615, 13631);
                        return return_v;
                    }


                    int
                    f_10684_13633_13640()
                    {
                        var return_v = Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10684, 13633, 13640);
                        return return_v;
                    }


                    int
                    f_10684_13633_13654(int
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 13633, 13654);
                        return return_v;
                    }


                    int
                    f_10684_13602_13655(Microsoft.CodeAnalysis.CSharp.Symbol?
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 13602, 13655);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 13529, 13671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 13529, 13671);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<CustomModifier> RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 13785, 13837);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 13791, 13835);

                        return ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 13785, 13837);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 13687, 13852);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 13687, 13852);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10684, 13974, 13994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10684, 13980, 13992);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10684, 13974, 13994);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10684, 13868, 14009);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 13868, 14009);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static SynthesizedOperatorParameterSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10684, 12539, 14020);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10684, 12539, 14020);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 12539, 14020);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10684, 12539, 14020);

            static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10684_12873_12882_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10684, 12652, 12976);
                return return_v;
            }

        }

        static SynthesizedIntrinsicOperatorSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10684, 426, 14027);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10684, 426, 14027);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10684, 426, 14027);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10684, 426, 14027);

        bool
        f_10684_953_1104(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        t2, Microsoft.CodeAnalysis.TypeCompareKind
        compareKind)
        {
            var return_v = this_param.Equals(t2, compareKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 953, 1104);
            return return_v;
        }


        bool
        f_10684_1203_1356(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        t2, Microsoft.CodeAnalysis.TypeCompareKind
        compareKind)
        {
            var return_v = this_param.Equals(t2, compareKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1203, 1356);
            return return_v;
        }


        bool
        f_10684_1497_1649(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        t2, Microsoft.CodeAnalysis.TypeCompareKind
        compareKind)
        {
            var return_v = this_param.Equals(t2, compareKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1497, 1649);
            return return_v;
        }


        int
        f_10684_1484_1650(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1484, 1650);
            return 0;
        }


        bool
        f_10684_1809_1829(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.IsDynamic();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1809, 1829);
            return return_v;
        }


        bool
        f_10684_1833_1854(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.IsDynamic();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1833, 1854);
            return return_v;
        }


        bool
        f_10684_1859_1881(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.IsDynamic();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1859, 1881);
            return return_v;
        }


        int
        f_10684_1795_1882(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1795, 1882);
            return 0;
        }


        bool
        f_10684_1910_1937(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.IsDynamic();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1910, 1937);
            return return_v;
        }


        bool
        f_10684_1941_1963(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.IsDynamic();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1941, 1963);
            return return_v;
        }


        int
        f_10684_1897_1964(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1897, 1964);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol.SynthesizedOperatorParameterSymbol
        f_10684_2019_2084(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol
        container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, int
        ordinal, string
        name)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol.SynthesizedOperatorParameterSymbol(container, type, ordinal, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 2019, 2084);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol.SynthesizedOperatorParameterSymbol
        f_10684_2141_2208(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol
        container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, int
        ordinal, string
        name)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol.SynthesizedOperatorParameterSymbol(container, type, ordinal, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 2141, 2208);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10684_1995_2230(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
        items)
        {
            var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 1995, 2230);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol.SynthesizedOperatorParameterSymbol
        f_10684_2599_2666(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol
        container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, int
        ordinal, string
        name)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedIntrinsicOperatorSymbol.SynthesizedOperatorParameterSymbol(container, type, ordinal, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 2599, 2666);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10684_2574_2689(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
        items)
        {
            var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10684, 2574, 2689);
            return return_v;
        }

    }
}
