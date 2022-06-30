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
using Microsoft.CodeAnalysis.CodeGen;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class SecurityWellKnownAttributeData
    {
        private byte[] _lazySecurityActions;

        private string[] _lazyPathsForPermissionSetFixup;

        public void SetSecurityAttribute(int attributeIndex, DeclarativeSecurityAction action, int totalSourceAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(814, 1330, 1934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 1468, 1544);

                f_814_1468_1543(attributeIndex >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(814, 1481, 1542) && attributeIndex < totalSourceAttributes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 1558, 1584);

                f_814_1558_1583(action != 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 1600, 1774) || true) && (_lazySecurityActions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(814, 1600, 1774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 1666, 1759);

                    f_814_1666_1758(ref _lazySecurityActions, new byte[totalSourceAttributes], null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(814, 1600, 1774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 1790, 1857);

                f_814_1790_1856(f_814_1803_1830(_lazySecurityActions) == totalSourceAttributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 1871, 1923);

                _lazySecurityActions[attributeIndex] = (byte)action;
                DynAbs.Tracing.TraceSender.TraceExitMethod(814, 1330, 1934);

                int
                f_814_1468_1543(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 1468, 1543);
                    return 0;
                }


                int
                f_814_1558_1583(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 1558, 1583);
                    return 0;
                }


                byte[]?
                f_814_1666_1758(ref byte[]?
                location1, byte[]
                value, byte[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 1666, 1758);
                    return return_v;
                }


                int
                f_814_1803_1830(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(814, 1803, 1830);
                    return return_v;
                }


                int
                f_814_1790_1856(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 1790, 1856);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(814, 1330, 1934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(814, 1330, 1934);
            }
        }

        public void SetPathForPermissionSetAttributeFixup(int attributeIndex, string resolvedFilePath, int totalSourceAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(814, 1946, 2621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 2092, 2168);

                f_814_2092_2167(attributeIndex >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(814, 2105, 2166) && attributeIndex < totalSourceAttributes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 2182, 2221);

                f_814_2182_2220(resolvedFilePath != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 2237, 2435) || true) && (_lazyPathsForPermissionSetFixup == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(814, 2237, 2435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 2314, 2420);

                    f_814_2314_2419(ref _lazyPathsForPermissionSetFixup, new string[totalSourceAttributes], null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(814, 2237, 2435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 2451, 2529);

                f_814_2451_2528(f_814_2464_2502(_lazyPathsForPermissionSetFixup) == totalSourceAttributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 2543, 2610);

                _lazyPathsForPermissionSetFixup[attributeIndex] = resolvedFilePath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(814, 1946, 2621);

                int
                f_814_2092_2167(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 2092, 2167);
                    return 0;
                }


                int
                f_814_2182_2220(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 2182, 2220);
                    return 0;
                }


                string[]?
                f_814_2314_2419(ref string[]?
                location1, string[]
                value, string[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 2314, 2419);
                    return return_v;
                }


                int
                f_814_2464_2502(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(814, 2464, 2502);
                    return return_v;
                }


                int
                f_814_2451_2528(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 2451, 2528);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(814, 1946, 2621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(814, 1946, 2621);
            }
        }

        public IEnumerable<Cci.SecurityAttribute> GetSecurityAttributes<T>(ImmutableArray<T> customAttributes)
                    where T : Cci.ICustomAttribute
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(814, 2808, 4158);

                var listYield = new List<Cci.SecurityAttribute>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 2979, 3021);

                f_814_2979_3020(f_814_2992_3019_M(!customAttributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3035, 3194);

                f_814_3035_3193(_lazyPathsForPermissionSetFixup == null || (DynAbs.Tracing.TraceSender.Expression_False(814, 3048, 3192) || _lazySecurityActions != null && (DynAbs.Tracing.TraceSender.Expression_True(814, 3091, 3192) && f_814_3123_3161(_lazyPathsForPermissionSetFixup) == f_814_3165_3192(_lazySecurityActions))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3210, 4147) || true) && (_lazySecurityActions != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(814, 3210, 4147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3276, 3319);

                    f_814_3276_3318(_lazySecurityActions != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3337, 3406);

                    f_814_3337_3405(f_814_3350_3377(_lazySecurityActions) == customAttributes.Length);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3435, 3440);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3426, 4132) || true) && (i < customAttributes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3471, 3474)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(814, 3426, 4132))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(814, 3426, 4132);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3516, 4113) || true) && (_lazySecurityActions[i] != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(814, 3516, 4113);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3598, 3662);

                                var
                                action = (DeclarativeSecurityAction)_lazySecurityActions[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3688, 3741);

                                Cci.ICustomAttribute
                                attribute = customAttributes[i]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3769, 4004) || true) && (f_814_3773_3808_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyPathsForPermissionSetFixup, 814, 3773, 3808)?[i]) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(814, 3769, 4004);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 3874, 3977);

                                    attribute = f_814_3886_3976(attribute, _lazyPathsForPermissionSetFixup[i]);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(814, 3769, 4004);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 4032, 4090);

                                listYield.Add(f_814_4045_4089(action, attribute));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(814, 3516, 4113);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(814, 1, 707);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(814, 1, 707);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(814, 3210, 4147);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(814, 2808, 4158);

                return listYield;

                bool
                f_814_2992_3019_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(814, 2992, 3019);
                    return return_v;
                }


                int
                f_814_2979_3020(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 2979, 3020);
                    return 0;
                }


                int
                f_814_3123_3161(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(814, 3123, 3161);
                    return return_v;
                }


                int
                f_814_3165_3192(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(814, 3165, 3192);
                    return return_v;
                }


                int
                f_814_3035_3193(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 3035, 3193);
                    return 0;
                }


                int
                f_814_3276_3318(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 3276, 3318);
                    return 0;
                }


                int
                f_814_3350_3377(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(814, 3350, 3377);
                    return return_v;
                }


                int
                f_814_3337_3405(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 3337, 3405);
                    return 0;
                }


                string?
                f_814_3773_3808_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(814, 3773, 3808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.PermissionSetAttributeWithFileReference
                f_814_3886_3976(Microsoft.Cci.ICustomAttribute
                sourceAttribute, string
                resolvedPermissionSetFilePath)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.PermissionSetAttributeWithFileReference(sourceAttribute, resolvedPermissionSetFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 3886, 3976);
                    return return_v;
                }


                Microsoft.Cci.SecurityAttribute
                f_814_4045_4089(System.Reflection.DeclarativeSecurityAction
                action, Microsoft.Cci.ICustomAttribute
                attribute)
                {
                    var return_v = new Microsoft.Cci.SecurityAttribute(action, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(814, 4045, 4089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(814, 2808, 4158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(814, 2808, 4158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SecurityWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(814, 689, 4165);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 959, 979);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(814, 1286, 1317);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(814, 689, 4165);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(814, 689, 4165);
        }


        static SecurityWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(814, 689, 4165);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(814, 689, 4165);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(814, 689, 4165);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(814, 689, 4165);
    }
}
