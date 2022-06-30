// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    internal partial class CommonReferenceManager<TCompilation, TAssemblySymbol>
    {
        [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        internal readonly struct AssemblyReferenceBinding
        {

            private readonly AssemblyIdentity? _referenceIdentity;

            private readonly int _definitionIndex;

            private readonly int _versionDifference;

            public AssemblyReferenceBinding(AssemblyIdentity referenceIdentity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(526, 915, 1210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1015, 1055);

                    f_526_1015_1054(referenceIdentity != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1075, 1114);

                    _referenceIdentity = referenceIdentity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1132, 1154);

                    _definitionIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1172, 1195);

                    _versionDifference = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(526, 915, 1210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(526, 915, 1210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(526, 915, 1210);
                }
            }

            public AssemblyReferenceBinding(AssemblyIdentity referenceIdentity, int definitionIndex, int versionDifference = 0)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(526, 1318, 1826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1466, 1506);

                    f_526_1466_1505(referenceIdentity != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1524, 1559);

                    f_526_1524_1558(definitionIndex >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1577, 1642);

                    f_526_1577_1641(versionDifference >= -1 && (DynAbs.Tracing.TraceSender.Expression_True(526, 1590, 1640) && versionDifference <= +1));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1662, 1701);

                    _referenceIdentity = referenceIdentity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1719, 1754);

                    _definitionIndex = definitionIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 1772, 1811);

                    _versionDifference = versionDifference;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(526, 1318, 1826);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(526, 1318, 1826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(526, 1318, 1826);
                }
            }

            internal bool BoundToAssemblyBeingBuilt
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(526, 2075, 2112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 2081, 2110);

                        return _definitionIndex == 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(526, 2075, 2112);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(526, 2003, 2127);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(526, 2003, 2127);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal bool IsBound
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(526, 2369, 2461);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 2413, 2442);

                        return _definitionIndex >= 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(526, 2369, 2461);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(526, 2315, 2476);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(526, 2315, 2476);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal int VersionDifference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(526, 3064, 3197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 3108, 3130);

                        f_526_3108_3129(IsBound);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 3152, 3178);

                        return _versionDifference;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(526, 3064, 3197);

                        int
                        f_526_3108_3129(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(526, 3108, 3129);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(526, 3001, 3212);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(526, 3001, 3212);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal int DefinitionIndex
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(526, 3463, 3594);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 3507, 3529);

                        f_526_3507_3528(IsBound);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 3551, 3575);

                        return _definitionIndex;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(526, 3463, 3594);

                        int
                        f_526_3507_3528(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(526, 3507, 3528);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(526, 3402, 3609);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(526, 3402, 3609);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal AssemblyIdentity? ReferenceIdentity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(526, 3702, 3791);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 3746, 3772);

                        return _referenceIdentity;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(526, 3702, 3791);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(526, 3625, 3806);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(526, 3625, 3806);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private string GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(526, 3822, 4122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 3890, 3950);

                    var
                    displayName = f_526_3908_3943_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(ReferenceIdentity, 526, 3908, 3943)?.GetDisplayName()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(526, 3908, 3949) ?? "")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(526, 3968, 4107);

                    //return (DynAbs.Tracing.TraceSender.Conditional_F1(526, 3975, 3982) || 
                    //    ((IsBound && DynAbs.Tracing.TraceSender.Conditional_F2(526, 3985, 4094)) || 
                    //    DynAbs.Tracing.TraceSender.Conditional_F3(526, 4097, 4106))) ? displayName + " -> #" + 
                    //    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (DefinitionIndex).ToString(), 526, 4009, 4024) + 
                    //    ((DynAbs.Tracing.TraceSender.Conditional_F1(526, 4028, 4050) || 
                    //    ((VersionDifference != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(526, 4053, 4088)) || 
                    //    DynAbs.Tracing.TraceSender.Conditional_F3(526, 4091, 4093))) ? " VersionDiff=" + 
                    //    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (VersionDifference).ToString(), 526, 4071, 4088) : "") 
                    //    : "unbound";

                    if (DynAbs.Tracing.TraceSender.Conditional_F1(526, 3975, 3982) ||
                        ((IsBound && DynAbs.Tracing.TraceSender.Conditional_F2(526, 3985, 4094)) ||
                        DynAbs.Tracing.TraceSender.Conditional_F3(526, 4097, 4106)))
                    {
                        var temp = displayName + " -> #" + (DefinitionIndex).ToString();
                        //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (DefinitionIndex).ToString(), 526, 4009, 4024);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(526, 4009, 4024);

                        if (DynAbs.Tracing.TraceSender.Conditional_F1(526, 4028, 4050) ||
                        ((VersionDifference != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(526, 4053, 4088)) ||
                        DynAbs.Tracing.TraceSender.Conditional_F3(526, 4091, 4093)))
                        {
                            temp += " VersionDiff=" + (VersionDifference).ToString();
                            //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (VersionDifference).ToString(), 526, 4071, 4088)
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(526, 4071, 4088);
                        }
                        else
                        {
                            temp += "";
                        }

                        return temp;
                    }
                    else
                    {
                        return "unbound";
                    }

                    DynAbs.Tracing.TraceSender.TraceExitMethod(526, 3822, 4122);

                    string?
                    f_526_3908_3943_I(string?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(526, 3908, 3943);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(526, 3822, 4122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(526, 3822, 4122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static AssemblyReferenceBinding()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(526, 520, 4133);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(526, 520, 4133);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(526, 520, 4133);
            }

            static int
            f_526_1015_1054(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(526, 1015, 1054);
                return 0;
            }


            static int
            f_526_1466_1505(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(526, 1466, 1505);
                return 0;
            }


            static int
            f_526_1524_1558(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(526, 1524, 1558);
                return 0;
            }


            static int
            f_526_1577_1641(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(526, 1577, 1641);
                return 0;
            }

        }
    }
}
