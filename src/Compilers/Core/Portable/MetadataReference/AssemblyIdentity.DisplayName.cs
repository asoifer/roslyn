// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public partial class AssemblyIdentity
    {
        internal const string
        InvariantCultureDisplay = "neutral"
        ;

        public string GetDisplayName(bool fullKey = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(421, 1736, 2106);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 1811, 1910) || true) && (fullKey)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 1811, 1910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 1856, 1895);

                    return f_421_1863_1894(this, fullKey: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 1811, 1910);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 1926, 2055) || true) && (_lazyDisplayName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 1926, 2055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 1988, 2040);

                    _lazyDisplayName = f_421_2007_2039(this, fullKey: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 1926, 2055);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2071, 2095);

                return _lazyDisplayName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(421, 1736, 2106);

                string
                f_421_1863_1894(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, bool
                fullKey)
                {
                    var return_v = this_param.BuildDisplayName(fullKey: fullKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 1863, 1894);
                    return return_v;
                }


                string
                f_421_2007_2039(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, bool
                fullKey)
                {
                    var return_v = this_param.BuildDisplayName(fullKey: fullKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 2007, 2039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 1736, 2106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 1736, 2106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(421, 2228, 2335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2286, 2324);

                return f_421_2293_2323(this, fullKey: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(421, 2228, 2335);

                string
                f_421_2293_2323(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, bool
                fullKey)
                {
                    var return_v = this_param.GetDisplayName(fullKey: fullKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 2293, 2323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 2228, 2335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 2228, 2335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string PublicKeyToString(ImmutableArray<byte> key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 2347, 2731);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2438, 2521) || true) && (key.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 2438, 2521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2496, 2506);

                    return "";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 2438, 2521);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2537, 2596);

                PooledStringBuilder
                sb = f_421_2562_2595()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2610, 2645);

                StringBuilder
                builder = sb.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2659, 2678);

                f_421_2659_2677(sb, key);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2692, 2720);

                return f_421_2699_2719(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 2347, 2731);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_421_2562_2595()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 2562, 2595);
                    return return_v;
                }


                int
                f_421_2659_2677(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                sb, System.Collections.Immutable.ImmutableArray<byte>
                key)
                {
                    AppendKey((System.Text.StringBuilder)sb, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 2659, 2677);
                    return 0;
                }


                string
                f_421_2699_2719(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 2699, 2719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 2347, 2731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 2347, 2731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string BuildDisplayName(bool fullKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(421, 2743, 4649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2813, 2883);

                PooledStringBuilder
                pooledBuilder = f_421_2849_2882()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2897, 2928);

                var
                sb = pooledBuilder.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2942, 2963);

                f_421_2942_2962(sb, f_421_2957_2961());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 2979, 3003);

                f_421_2979_3002(
                            sb, ", Version=");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3017, 3043);

                f_421_3017_3042(sb, f_421_3027_3041(_version));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3057, 3072);

                f_421_3057_3071(sb, ".");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3086, 3112);

                f_421_3086_3111(sb, f_421_3096_3110(_version));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3126, 3141);

                f_421_3126_3140(sb, ".");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3155, 3181);

                f_421_3155_3180(sb, f_421_3165_3179(_version));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3195, 3210);

                f_421_3195_3209(sb, ".");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3224, 3253);

                f_421_3224_3252(sb, f_421_3234_3251(_version));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3269, 3293);

                f_421_3269_3292(
                            sb, ", Culture=");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3307, 3514) || true) && (f_421_3311_3330(_cultureName) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 3307, 3514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3369, 3404);

                    f_421_3369_3403(sb, InvariantCultureDisplay);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 3307, 3514);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 3307, 3514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3470, 3499);

                    f_421_3470_3498(sb, _cultureName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 3307, 3514);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3530, 4011) || true) && (fullKey && (DynAbs.Tracing.TraceSender.Expression_True(421, 3534, 3557) && f_421_3545_3557()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 3530, 4011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3591, 3617);

                    f_421_3591_3616(sb, ", PublicKey=");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3635, 3661);

                    f_421_3635_3660(sb, _publicKey);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 3530, 4011);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 3530, 4011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3727, 3758);

                    f_421_3727_3757(sb, ", PublicKeyToken=");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3776, 3996) || true) && (f_421_3780_3794().Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 3776, 3996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3847, 3877);

                        f_421_3847_3876(sb, f_421_3861_3875());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 3776, 3996);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 3776, 3996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 3959, 3977);

                        f_421_3959_3976(sb, "null");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 3776, 3996);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 3530, 4011);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4027, 4126) || true) && (f_421_4031_4045())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 4027, 4126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4079, 4111);

                    f_421_4079_4110(sb, ", Retargetable=Yes");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 4027, 4126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4142, 4529);

                switch (_contentType)
                {

                    case AssemblyContentType.Default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 4142, 4529);
                        DynAbs.Tracing.TraceSender.TraceBreak(421, 4251, 4257);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 4142, 4529);

                    case AssemblyContentType.WindowsRuntime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 4142, 4529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4339, 4381);

                        f_421_4339_4380(sb, ", ContentType=WindowsRuntime");
                        DynAbs.Tracing.TraceSender.TraceBreak(421, 4403, 4409);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 4142, 4529);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 4142, 4529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4459, 4514);

                        throw f_421_4465_4513(_contentType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 4142, 4529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4545, 4575);

                string
                result = f_421_4561_4574(sb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4589, 4610);

                f_421_4589_4609(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4624, 4638);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(421, 2743, 4649);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_421_2849_2882()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 2849, 2882);
                    return return_v;
                }


                string
                f_421_2957_2961()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 2957, 2961);
                    return return_v;
                }


                int
                f_421_2942_2962(System.Text.StringBuilder
                result, string
                name)
                {
                    EscapeName(result, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 2942, 2962);
                    return 0;
                }


                System.Text.StringBuilder
                f_421_2979_3002(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 2979, 3002);
                    return return_v;
                }


                int
                f_421_3027_3041(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 3027, 3041);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3017_3042(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3017, 3042);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3057_3071(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3057, 3071);
                    return return_v;
                }


                int
                f_421_3096_3110(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 3096, 3110);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3086_3111(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3086, 3111);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3126_3140(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3126, 3140);
                    return return_v;
                }


                int
                f_421_3165_3179(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 3165, 3179);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3155_3180(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3155, 3180);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3195_3209(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3195, 3209);
                    return return_v;
                }


                int
                f_421_3234_3251(System.Version
                this_param)
                {
                    var return_v = this_param.Revision;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 3234, 3251);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3224_3252(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3224, 3252);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3269_3292(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3269, 3292);
                    return return_v;
                }


                int
                f_421_3311_3330(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 3311, 3330);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3369_3403(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3369, 3403);
                    return return_v;
                }


                int
                f_421_3470_3498(System.Text.StringBuilder
                result, string
                name)
                {
                    EscapeName(result, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3470, 3498);
                    return 0;
                }


                bool
                f_421_3545_3557()
                {
                    var return_v = HasPublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 3545, 3557);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_3591_3616(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3591, 3616);
                    return return_v;
                }


                int
                f_421_3635_3660(System.Text.StringBuilder
                sb, System.Collections.Immutable.ImmutableArray<byte>
                key)
                {
                    AppendKey(sb, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3635, 3660);
                    return 0;
                }


                System.Text.StringBuilder
                f_421_3727_3757(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3727, 3757);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_421_3780_3794()
                {
                    var return_v = PublicKeyToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 3780, 3794);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_421_3861_3875()
                {
                    var return_v = PublicKeyToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 3861, 3875);
                    return return_v;
                }


                int
                f_421_3847_3876(System.Text.StringBuilder
                sb, System.Collections.Immutable.ImmutableArray<byte>
                key)
                {
                    AppendKey(sb, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3847, 3876);
                    return 0;
                }


                System.Text.StringBuilder
                f_421_3959_3976(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 3959, 3976);
                    return return_v;
                }


                bool
                f_421_4031_4045()
                {
                    var return_v = IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 4031, 4045);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_4079_4110(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 4079, 4110);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_4339_4380(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 4339, 4380);
                    return return_v;
                }


                System.Exception
                f_421_4465_4513(System.Reflection.AssemblyContentType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 4465, 4513);
                    return return_v;
                }


                string
                f_421_4561_4574(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 4561, 4574);
                    return return_v;
                }


                int
                f_421_4589_4609(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 4589, 4609);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 2743, 4649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 2743, 4649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AppendKey(StringBuilder sb, ImmutableArray<byte> key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 4661, 4869);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4759, 4858);
                    foreach (byte b in f_421_4778_4781_I(key))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 4759, 4858);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4815, 4843);

                        f_421_4815_4842(sb, f_421_4825_4841(b, "x2"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 4759, 4858);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 1, 100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(421, 1, 100);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 4661, 4869);

                string
                f_421_4825_4841(byte
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 4825, 4841);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_4815_4842(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 4815, 4842);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_421_4778_4781_I(System.Collections.Immutable.ImmutableArray<byte>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 4778, 4781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 4661, 4869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 4661, 4869);
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(421, 4881, 4989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 4941, 4978);

                return f_421_4948_4977(this, fullKey: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(421, 4881, 4989);

                string
                f_421_4948_4977(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, bool
                fullKey)
                {
                    var return_v = this_param.GetDisplayName(fullKey: fullKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 4948, 4977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 4881, 4989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 4881, 4989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryParseDisplayName(string displayName, [NotNullWhen(true)] out AssemblyIdentity? identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 5001, 5356);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 5136, 5261) || true) && (displayName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 5136, 5261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 5193, 5246);

                    throw f_421_5199_5245(nameof(displayName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 5136, 5261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 5277, 5345);

                return f_421_5284_5344(displayName, out identity, parts: out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 5001, 5356);

                System.ArgumentNullException
                f_421_5199_5245(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 5199, 5245);
                    return return_v;
                }


                bool
                f_421_5284_5344(string
                displayName, out Microsoft.CodeAnalysis.AssemblyIdentity?
                identity, out Microsoft.CodeAnalysis.AssemblyIdentityParts
                parts)
                {
                    var return_v = TryParseDisplayName(displayName, out identity, out parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 5284, 5344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 5001, 5356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 5001, 5356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryParseDisplayName(string displayName, [NotNullWhen(true)] out AssemblyIdentity? identity, out AssemblyIdentityParts parts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 6416, 15034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 6687, 6703);

                identity = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 6717, 6727);

                parts = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 6743, 6868) || true) && (displayName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 6743, 6868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 6800, 6853);

                    throw f_421_6806_6852(nameof(displayName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 6743, 6868);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 6884, 6980) || true) && (f_421_6888_6913(displayName, '\0') >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 6884, 6980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 6952, 6965);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 6884, 6980);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 6996, 7013);

                int
                position = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7027, 7046);

                string?
                simpleName
                = default(string?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7060, 7187) || true) && (!f_421_7065_7125(displayName, ref position, out simpleName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 7060, 7187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7159, 7172);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 7060, 7187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7203, 7248);

                var
                parsedParts = AssemblyIdentityParts.Name
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7262, 7300);

                var
                seen = AssemblyIdentityParts.Name
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7316, 7340);

                Version?
                version = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7354, 7377);

                string?
                culture = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7391, 7419);

                bool
                isRetargetable = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7433, 7479);

                var
                contentType = AssemblyContentType.Default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7493, 7539);

                var
                publicKey = default(ImmutableArray<byte>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7553, 7604);

                var
                publicKeyToken = default(ImmutableArray<byte>)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7620, 14282) || true) && (position < f_421_7638_7656(displayName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 7620, 14282);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7735, 7841) || true) && (f_421_7739_7760(displayName, position) != ',')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 7735, 7841);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7809, 7822);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 7735, 7841);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7861, 7872);

                        position++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7892, 7913);

                        string?
                        propertyName
                        = default(string?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 7931, 8072) || true) && (!f_421_7936_7998(displayName, ref position, out propertyName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 7931, 8072);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8040, 8053);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 7931, 8072);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8092, 8232) || true) && (position >= f_421_8108_8126(displayName) || (DynAbs.Tracing.TraceSender.Expression_False(421, 8096, 8158) || f_421_8130_8151(displayName, position) != '='))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 8092, 8232);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8200, 8213);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 8092, 8232);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8252, 8263);

                        position++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8283, 8305);

                        string?
                        propertyValue
                        = default(string?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8323, 8465) || true) && (!f_421_8328_8391(displayName, ref position, out propertyValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 8323, 8465);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8433, 8446);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 8323, 8465);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8522, 14267) || true) && (f_421_8526_8600(propertyName, "Version", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 8522, 14267);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8642, 8775) || true) && ((seen & AssemblyIdentityParts.Version) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 8642, 8775);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8739, 8752);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 8642, 8775);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8799, 8837);

                            seen |= AssemblyIdentityParts.Version;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8861, 8967) || true) && (propertyValue == "*")
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 8861, 8967);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8935, 8944);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 8861, 8967);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 8991, 9009);

                            ulong
                            versionLong
                            = default(ulong);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9031, 9066);

                            AssemblyIdentityParts
                            versionParts
                            = default(AssemblyIdentityParts);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9088, 9244) || true) && (!f_421_9093_9158(propertyValue, out versionLong, out versionParts))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 9088, 9244);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9208, 9221);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 9088, 9244);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9268, 9301);

                            version = f_421_9278_9300(versionLong);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9323, 9351);

                            parsedParts |= versionParts;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 8522, 14267);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 8522, 14267);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9393, 14267) || true) && (f_421_9397_9471(propertyName, "Culture", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(421, 9397, 9576) || f_421_9501_9576(propertyName, "Language", StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 9393, 14267);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9618, 9751) || true) && ((seen & AssemblyIdentityParts.Culture) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 9618, 9751);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9715, 9728);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 9618, 9751);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9775, 9813);

                                seen |= AssemblyIdentityParts.Culture;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9837, 9943) || true) && (propertyValue == "*")
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 9837, 9943);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9911, 9920);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 9837, 9943);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 9967, 10090);

                                culture = (DynAbs.Tracing.TraceSender.Conditional_F1(421, 9977, 10066) || ((f_421_9977_10066(propertyValue, InvariantCultureDisplay, StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(421, 10069, 10073)) || DynAbs.Tracing.TraceSender.Conditional_F3(421, 10076, 10089))) ? null : propertyValue;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10112, 10157);

                                parsedParts |= AssemblyIdentityParts.Culture;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 9393, 14267);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 9393, 14267);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10199, 14267) || true) && (f_421_10203_10279(propertyName, "PublicKey", StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 10199, 14267);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10321, 10456) || true) && ((seen & AssemblyIdentityParts.PublicKey) != 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 10321, 10456);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10420, 10433);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 10321, 10456);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10480, 10520);

                                    seen |= AssemblyIdentityParts.PublicKey;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10544, 10650) || true) && (propertyValue == "*")
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 10544, 10650);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10618, 10627);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 10544, 10650);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10674, 10701);

                                    ImmutableArray<byte>
                                    value
                                    = default(ImmutableArray<byte>);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10723, 10857) || true) && (!f_421_10728_10771(propertyValue, out value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 10723, 10857);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 10821, 10834);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 10723, 10857);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11191, 11209);

                                    publicKey = value;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11231, 11278);

                                    parsedParts |= AssemblyIdentityParts.PublicKey;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 10199, 14267);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 10199, 14267);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11320, 14267) || true) && (f_421_11324_11405(propertyName, "PublicKeyToken", StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 11320, 14267);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11447, 11587) || true) && ((seen & AssemblyIdentityParts.PublicKeyToken) != 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 11447, 11587);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11551, 11564);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 11447, 11587);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11611, 11656);

                                        seen |= AssemblyIdentityParts.PublicKeyToken;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11680, 11786) || true) && (propertyValue == "*")
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 11680, 11786);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11754, 11763);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 11680, 11786);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11810, 11837);

                                        ImmutableArray<byte>
                                        value
                                        = default(ImmutableArray<byte>);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11859, 11998) || true) && (!f_421_11864_11912(propertyValue, out value))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 11859, 11998);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 11962, 11975);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 11859, 11998);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12022, 12045);

                                        publicKeyToken = value;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12067, 12119);

                                        parsedParts |= AssemblyIdentityParts.PublicKeyToken;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 11320, 14267);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 11320, 14267);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12161, 14267) || true) && (f_421_12165_12244(propertyName, "Retargetable", StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 12161, 14267);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12286, 12427) || true) && ((seen & AssemblyIdentityParts.Retargetability) != 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 12286, 12427);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12391, 12404);

                                                return false;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 12286, 12427);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12451, 12497);

                                            seen |= AssemblyIdentityParts.Retargetability;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12521, 12627) || true) && (propertyValue == "*")
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 12521, 12627);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12595, 12604);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 12521, 12627);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12651, 13129) || true) && (f_421_12655_12726(propertyValue, "Yes", StringComparison.OrdinalIgnoreCase))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 12651, 13129);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12776, 12798);

                                                isRetargetable = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 12651, 13129);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 12651, 13129);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12848, 13129) || true) && (f_421_12852_12922(propertyValue, "No", StringComparison.OrdinalIgnoreCase))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 12848, 13129);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 12972, 12995);

                                                    isRetargetable = false;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 12848, 13129);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 12848, 13129);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13093, 13106);

                                                    return false;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 12848, 13129);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 12651, 13129);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13153, 13206);

                                            parsedParts |= AssemblyIdentityParts.Retargetability;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 12161, 14267);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 12161, 14267);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13248, 14267) || true) && (f_421_13252_13330(propertyName, "ContentType", StringComparison.OrdinalIgnoreCase))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 13248, 14267);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13372, 13509) || true) && ((seen & AssemblyIdentityParts.ContentType) != 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 13372, 13509);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13473, 13486);

                                                    return false;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 13372, 13509);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13533, 13575);

                                                seen |= AssemblyIdentityParts.ContentType;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13599, 13705) || true) && (propertyValue == "*")
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 13599, 13705);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13673, 13682);

                                                    continue;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 13599, 13705);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13729, 14048) || true) && (f_421_13733_13815(propertyValue, "WindowsRuntime", StringComparison.OrdinalIgnoreCase))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 13729, 14048);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 13865, 13914);

                                                    contentType = AssemblyContentType.WindowsRuntime;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 13729, 14048);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 13729, 14048);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14012, 14025);

                                                    return false;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 13729, 14048);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14072, 14121);

                                                parsedParts |= AssemblyIdentityParts.ContentType;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 13248, 14267);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 13248, 14267);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14203, 14248);

                                                parsedParts |= AssemblyIdentityParts.Unknown;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 13248, 14267);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 12161, 14267);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 11320, 14267);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 10199, 14267);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 9393, 14267);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 8522, 14267);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 7620, 14282);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 7620, 14282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(421, 7620, 14282);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14335, 14468) || true) && (isRetargetable && (DynAbs.Tracing.TraceSender.Expression_True(421, 14339, 14406) && contentType == AssemblyContentType.WindowsRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 14335, 14468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14440, 14453);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 14335, 14468);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14484, 14525);

                bool
                hasPublicKey = f_421_14504_14524_M(!publicKey.IsDefault)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14539, 14590);

                bool
                hasPublicKeyToken = f_421_14564_14589_M(!publicKeyToken.IsDefault)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14606, 14754);

                identity = f_421_14617_14753(simpleName, version, culture, (DynAbs.Tracing.TraceSender.Conditional_F1(421, 14668, 14680) || ((hasPublicKey && DynAbs.Tracing.TraceSender.Conditional_F2(421, 14683, 14692)) || DynAbs.Tracing.TraceSender.Conditional_F3(421, 14695, 14709))) ? publicKey : publicKeyToken, hasPublicKey, isRetargetable, contentType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14770, 14961) || true) && (hasPublicKey && (DynAbs.Tracing.TraceSender.Expression_True(421, 14774, 14807) && hasPublicKeyToken) && (DynAbs.Tracing.TraceSender.Expression_True(421, 14774, 14865) && !identity.PublicKeyToken.SequenceEqual(publicKeyToken)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 14770, 14961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14899, 14915);

                    identity = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14933, 14946);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 14770, 14961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 14977, 14997);

                parts = parsedParts;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15011, 15023);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 6416, 15034);

                System.ArgumentNullException
                f_421_6806_6852(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 6806, 6852);
                    return return_v;
                }


                int
                f_421_6888_6913(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 6888, 6913);
                    return return_v;
                }


                bool
                f_421_7065_7125(string
                displayName, ref int
                position, out string?
                value)
                {
                    var return_v = TryParseNameToken(displayName, ref position, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 7065, 7125);
                    return return_v;
                }


                int
                f_421_7638_7656(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 7638, 7656);
                    return return_v;
                }


                char
                f_421_7739_7760(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 7739, 7760);
                    return return_v;
                }


                bool
                f_421_7936_7998(string
                displayName, ref int
                position, out string?
                value)
                {
                    var return_v = TryParseNameToken(displayName, ref position, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 7936, 7998);
                    return return_v;
                }


                int
                f_421_8108_8126(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 8108, 8126);
                    return return_v;
                }


                char
                f_421_8130_8151(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 8130, 8151);
                    return return_v;
                }


                bool
                f_421_8328_8391(string
                displayName, ref int
                position, out string?
                value)
                {
                    var return_v = TryParseNameToken(displayName, ref position, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 8328, 8391);
                    return return_v;
                }


                bool
                f_421_8526_8600(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 8526, 8600);
                    return return_v;
                }


                bool
                f_421_9093_9158(string
                str, out ulong
                result, out Microsoft.CodeAnalysis.AssemblyIdentityParts
                parts)
                {
                    var return_v = TryParseVersion(str, out result, out parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 9093, 9158);
                    return return_v;
                }


                System.Version
                f_421_9278_9300(ulong
                version)
                {
                    var return_v = ToVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 9278, 9300);
                    return return_v;
                }


                bool
                f_421_9397_9471(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 9397, 9471);
                    return return_v;
                }


                bool
                f_421_9501_9576(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 9501, 9576);
                    return return_v;
                }


                bool
                f_421_9977_10066(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 9977, 10066);
                    return return_v;
                }


                bool
                f_421_10203_10279(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 10203, 10279);
                    return return_v;
                }


                bool
                f_421_10728_10771(string
                value, out System.Collections.Immutable.ImmutableArray<byte>
                key)
                {
                    var return_v = TryParsePublicKey(value, out key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 10728, 10771);
                    return return_v;
                }


                bool
                f_421_11324_11405(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 11324, 11405);
                    return return_v;
                }


                bool
                f_421_11864_11912(string
                value, out System.Collections.Immutable.ImmutableArray<byte>
                token)
                {
                    var return_v = TryParsePublicKeyToken(value, out token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 11864, 11912);
                    return return_v;
                }


                bool
                f_421_12165_12244(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 12165, 12244);
                    return return_v;
                }


                bool
                f_421_12655_12726(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 12655, 12726);
                    return return_v;
                }


                bool
                f_421_12852_12922(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 12852, 12922);
                    return return_v;
                }


                bool
                f_421_13252_13330(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 13252, 13330);
                    return return_v;
                }


                bool
                f_421_13733_13815(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 13733, 13815);
                    return return_v;
                }


                bool
                f_421_14504_14524_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 14504, 14524);
                    return return_v;
                }


                bool
                f_421_14564_14589_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 14564, 14589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_421_14617_14753(string
                name, System.Version?
                version, string?
                cultureName, System.Collections.Immutable.ImmutableArray<byte>
                publicKeyOrToken, bool
                hasPublicKey, bool
                isRetargetable, System.Reflection.AssemblyContentType
                contentType)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version, cultureName, publicKeyOrToken, hasPublicKey, isRetargetable, contentType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 14617, 14753);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 6416, 15034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 6416, 15034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryParseNameToken(string displayName, ref int position, [NotNullWhen(true)] out string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 15046, 18490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15185, 15231);

                f_421_15185_15230(f_421_15198_15223(displayName, '\0') == -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15247, 15264);

                int
                i = position
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15321, 15664) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 15321, 15664);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15366, 15625) || true) && (i == f_421_15375_15393(displayName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 15366, 15625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15435, 15448);

                            value = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15470, 15483);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 15366, 15625);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 15366, 15625);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15525, 15625) || true) && (!f_421_15530_15558(f_421_15543_15557(displayName, i)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 15525, 15625);
                                DynAbs.Tracing.TraceSender.TraceBreak(421, 15600, 15606);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 15525, 15625);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 15366, 15625);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15645, 15649);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 15321, 15664);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 15321, 15664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(421, 15321, 15664);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15680, 15691);

                char
                quote
                = default(char);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15705, 15885) || true) && (f_421_15709_15732(f_421_15717_15731(displayName, i)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 15705, 15885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15766, 15791);

                    quote = f_421_15774_15790(displayName, i++);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 15705, 15885);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 15705, 15885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15857, 15870);

                    quote = '\0';
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 15705, 15885);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15901, 15920);

                int
                valueStart = i
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15934, 15968);

                int
                valueEnd = f_421_15949_15967(displayName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 15982, 16011);

                bool
                containsEscapes = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16027, 17005) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 16027, 17005);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16072, 16211) || true) && (i >= f_421_16081_16099(displayName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 16072, 16211);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16141, 16164);

                            i = f_421_16145_16163(displayName);
                            DynAbs.Tracing.TraceSender.TraceBreak(421, 16186, 16192);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 16072, 16211);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16231, 16255);

                        char
                        c = f_421_16240_16254(displayName, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16273, 16430) || true) && (c == '\\')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 16273, 16430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16328, 16351);

                            containsEscapes = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16373, 16380);

                            i += 2;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16402, 16411);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 16273, 16430);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16450, 16966) || true) && (quote == '\0')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 16450, 16966);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16509, 16782) || true) && (f_421_16513_16537(c))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 16509, 16782);
                                DynAbs.Tracing.TraceSender.TraceBreak(421, 16587, 16593);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 16509, 16782);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 16509, 16782);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16643, 16782) || true) && (f_421_16647_16657(c))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 16643, 16782);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16707, 16720);

                                    value = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16746, 16759);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 16643, 16782);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 16509, 16782);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 16450, 16966);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 16450, 16966);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16824, 16966) || true) && (c == quote)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 16824, 16966);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16880, 16893);

                                valueEnd = i;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16915, 16919);

                                i++;
                                DynAbs.Tracing.TraceSender.TraceBreak(421, 16941, 16947);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 16824, 16966);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 16450, 16966);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 16986, 16990);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 16027, 17005);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 16027, 17005);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(421, 16027, 17005);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17021, 17889) || true) && (quote == '\0')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 17021, 17889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17072, 17086);

                    int
                    j = i - 1
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17104, 17223) || true) && (j >= valueStart && (DynAbs.Tracing.TraceSender.Expression_True(421, 17111, 17158) && f_421_17130_17158(f_421_17143_17157(displayName, j))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 17104, 17223);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17200, 17204);

                            j--;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 17104, 17223);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 17104, 17223);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(421, 17104, 17223);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17243, 17260);

                    valueEnd = j + 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 17021, 17889);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 17021, 17889);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17415, 17874) || true) && (i < f_421_17426_17444(displayName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 17415, 17874);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17486, 17510);

                            char
                            c = f_421_17495_17509(displayName, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17532, 17827) || true) && (!f_421_17537_17552(c))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 17532, 17827);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17602, 17772) || true) && (!f_421_17607_17631(c))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 17602, 17772);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17689, 17702);

                                    value = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17732, 17745);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 17602, 17772);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(421, 17798, 17804);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 17532, 17827);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17851, 17855);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 17415, 17874);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 17415, 17874);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(421, 17415, 17874);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 17021, 17889);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17905, 17984);

                f_421_17905_17983(i == f_421_17923_17941(displayName) || (DynAbs.Tracing.TraceSender.Expression_False(421, 17918, 17982) || f_421_17945_17982(f_421_17967_17981(displayName, i))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 17998, 18011);

                position = i;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18049, 18168) || true) && (valueEnd == valueStart)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 18049, 18168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18109, 18122);

                    value = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18140, 18153);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 18049, 18168);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18184, 18479) || true) && (!containsEscapes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 18184, 18479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18238, 18303);

                    value = f_421_18246_18302(displayName, valueStart, valueEnd - valueStart);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18321, 18333);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 18184, 18479);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 18184, 18479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18399, 18464);

                    return f_421_18406_18463(displayName, valueStart, valueEnd, out value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 18184, 18479);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 15046, 18490);

                int
                f_421_15198_15223(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 15198, 15223);
                    return return_v;
                }


                int
                f_421_15185_15230(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 15185, 15230);
                    return 0;
                }


                int
                f_421_15375_15393(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 15375, 15393);
                    return return_v;
                }


                char
                f_421_15543_15557(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 15543, 15557);
                    return return_v;
                }


                bool
                f_421_15530_15558(char
                c)
                {
                    var return_v = IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 15530, 15558);
                    return return_v;
                }


                char
                f_421_15717_15731(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 15717, 15731);
                    return return_v;
                }


                bool
                f_421_15709_15732(char
                c)
                {
                    var return_v = IsQuote(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 15709, 15732);
                    return return_v;
                }


                char
                f_421_15774_15790(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 15774, 15790);
                    return return_v;
                }


                int
                f_421_15949_15967(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 15949, 15967);
                    return return_v;
                }


                int
                f_421_16081_16099(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 16081, 16099);
                    return return_v;
                }


                int
                f_421_16145_16163(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 16145, 16163);
                    return return_v;
                }


                char
                f_421_16240_16254(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 16240, 16254);
                    return return_v;
                }


                bool
                f_421_16513_16537(char
                c)
                {
                    var return_v = IsNameTokenTerminator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 16513, 16537);
                    return return_v;
                }


                bool
                f_421_16647_16657(char
                c)
                {
                    var return_v = IsQuote(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 16647, 16657);
                    return return_v;
                }


                char
                f_421_17143_17157(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 17143, 17157);
                    return return_v;
                }


                bool
                f_421_17130_17158(char
                c)
                {
                    var return_v = IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 17130, 17158);
                    return return_v;
                }


                int
                f_421_17426_17444(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 17426, 17444);
                    return return_v;
                }


                char
                f_421_17495_17509(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 17495, 17509);
                    return return_v;
                }


                bool
                f_421_17537_17552(char
                c)
                {
                    var return_v = IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 17537, 17552);
                    return return_v;
                }


                bool
                f_421_17607_17631(char
                c)
                {
                    var return_v = IsNameTokenTerminator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 17607, 17631);
                    return return_v;
                }


                int
                f_421_17923_17941(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 17923, 17941);
                    return return_v;
                }


                char
                f_421_17967_17981(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 17967, 17981);
                    return return_v;
                }


                bool
                f_421_17945_17982(char
                c)
                {
                    var return_v = IsNameTokenTerminator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 17945, 17982);
                    return return_v;
                }


                int
                f_421_17905_17983(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 17905, 17983);
                    return 0;
                }


                string
                f_421_18246_18302(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 18246, 18302);
                    return return_v;
                }


                bool
                f_421_18406_18463(string
                str, int
                start, int
                end, out string?
                value)
                {
                    var return_v = TryUnescape(str, start, end, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 18406, 18463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 15046, 18490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 15046, 18490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNameTokenTerminator(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 18502, 18615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18576, 18604);

                return c == '=' || (DynAbs.Tracing.TraceSender.Expression_False(421, 18583, 18603) || c == ',');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 18502, 18615);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 18502, 18615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 18502, 18615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsQuote(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 18627, 18727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18687, 18716);

                return c == '"' || (DynAbs.Tracing.TraceSender.Expression_False(421, 18694, 18715) || c == '\'');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 18627, 18727);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 18627, 18727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 18627, 18727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Version ToVersion(ulong version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 18739, 19047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 18812, 19036);

                return f_421_18819_19035(unchecked((ushort)(version >> 48)), unchecked((ushort)(version >> 32)), unchecked((ushort)(version >> 16)), unchecked((ushort)version));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 18739, 19047);

                System.Version
                f_421_18819_19035(ushort
                major, ushort
                minor, ushort
                build, ushort
                revision)
                {
                    var return_v = new System.Version((int)major, (int)minor, (int)build, (int)revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 18819, 19035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 18739, 19047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 18739, 19047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseVersion(string str, out ulong result, out AssemblyIdentityParts parts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 19463, 21611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19587, 19616);

                f_421_19587_19615(f_421_19600_19610(str) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19630, 19666);

                f_421_19630_19665(f_421_19643_19660(str, '\0') < 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19682, 19712);

                const int
                MaxVersionParts = 4
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19726, 19760);

                const int
                BitsPerVersionPart = 16
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19776, 19786);

                parts = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19800, 19811);

                result = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19825, 19885);

                int
                partOffset = BitsPerVersionPart * (MaxVersionParts - 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19899, 19917);

                int
                partIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19931, 19949);

                int
                partValue = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 19963, 19989);

                bool
                partHasValue = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20003, 20032);

                bool
                partHasWildcard = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20048, 20058);

                int
                i = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20072, 21600) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 20072, 21600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20117, 20161);

                        char
                        c = (DynAbs.Tracing.TraceSender.Conditional_F1(421, 20126, 20142) || (((i < f_421_20131_20141(str)) && DynAbs.Tracing.TraceSender.Conditional_F2(421, 20145, 20153)) || DynAbs.Tracing.TraceSender.Conditional_F3(421, 20156, 20160))) ? f_421_20145_20153(str, i++) : '\0'
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20181, 21585) || true) && (c == '.' || (DynAbs.Tracing.TraceSender.Expression_False(421, 20185, 20203) || c == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 20181, 21585);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20245, 20398) || true) && (partIndex == MaxVersionParts || (DynAbs.Tracing.TraceSender.Expression_False(421, 20249, 20312) || partHasValue && (DynAbs.Tracing.TraceSender.Expression_True(421, 20281, 20312) && partHasWildcard)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 20245, 20398);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20362, 20375);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 20245, 20398);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20422, 20465);

                            result |= ((ulong)partValue) << partOffset;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20489, 20684) || true) && (partHasValue || (DynAbs.Tracing.TraceSender.Expression_False(421, 20493, 20524) || partHasWildcard))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 20489, 20684);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20574, 20661);

                                parts |= (AssemblyIdentityParts)((int)AssemblyIdentityParts.VersionMajor << partIndex);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 20489, 20684);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20708, 20803) || true) && (c == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 20708, 20803);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20768, 20780);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 20708, 20803);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20862, 20876);

                            partValue = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20898, 20931);

                            partOffset -= BitsPerVersionPart;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20953, 20965);

                            partIndex++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 20987, 21026);

                            partHasWildcard = partHasValue = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 20181, 21585);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 20181, 21585);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21068, 21585) || true) && (c >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(421, 21072, 21092) && c <= '9'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 21068, 21585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21134, 21154);

                                partHasValue = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21176, 21213);

                                partValue = partValue * 10 + c - '0';

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21235, 21352) || true) && (partValue > ushort.MaxValue)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 21235, 21352);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21316, 21329);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 21235, 21352);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 21068, 21585);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 21068, 21585);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21394, 21585) || true) && (c == '*')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 21394, 21585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21448, 21471);

                                    partHasWildcard = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 21394, 21585);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 21394, 21585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21553, 21566);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 21394, 21585);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 21068, 21585);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 20181, 21585);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 20072, 21600);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 20072, 21600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(421, 20072, 21600);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 19463, 21611);

                int
                f_421_19600_19610(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 19600, 19610);
                    return return_v;
                }


                int
                f_421_19587_19615(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 19587, 19615);
                    return 0;
                }


                int
                f_421_19643_19660(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 19643, 19660);
                    return return_v;
                }


                int
                f_421_19630_19665(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 19630, 19665);
                    return 0;
                }


                int
                f_421_20131_20141(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 20131, 20141);
                    return return_v;
                }


                char
                f_421_20145_20153(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 20145, 20153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 19463, 21611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 19463, 21611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryParsePublicKey(string value, out ImmutableArray<byte> key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 21623, 21958);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21729, 21919) || true) && (!f_421_21734_21766(value, out key) || (DynAbs.Tracing.TraceSender.Expression_False(421, 21733, 21825) || !f_421_21788_21825(key)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 21729, 21919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21859, 21873);

                    key = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21891, 21904);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 21729, 21919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21935, 21947);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 21623, 21958);

                bool
                f_421_21734_21766(string
                value, out System.Collections.Immutable.ImmutableArray<byte>
                result)
                {
                    var return_v = TryParseHexBytes(value, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 21734, 21766);
                    return return_v;
                }


                bool
                f_421_21788_21825(System.Collections.Immutable.ImmutableArray<byte>
                bytes)
                {
                    var return_v = MetadataHelpers.IsValidPublicKey(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 21788, 21825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 21623, 21958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 21623, 21958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        PublicKeyTokenBytes = 8
        ;

        private static bool TryParsePublicKeyToken(string value, out ImmutableArray<byte> token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 22024, 22714);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22137, 22407) || true) && (f_421_22141_22205(value, "null", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(421, 22141, 22293) || f_421_22226_22293(value, "neutral", StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 22137, 22407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22327, 22362);

                    token = ImmutableArray<byte>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22380, 22392);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 22137, 22407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22423, 22451);

                ImmutableArray<byte>
                result
                = default(ImmutableArray<byte>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22465, 22646) || true) && (f_421_22469_22481(value) != (PublicKeyTokenBytes * 2) || (DynAbs.Tracing.TraceSender.Expression_False(421, 22469, 22550) || !f_421_22515_22550(value, out result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 22465, 22646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22584, 22600);

                    token = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22618, 22631);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 22465, 22646);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22662, 22677);

                token = result;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22691, 22703);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 22024, 22714);

                bool
                f_421_22141_22205(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 22141, 22205);
                    return return_v;
                }


                bool
                f_421_22226_22293(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 22226, 22293);
                    return return_v;
                }


                int
                f_421_22469_22481(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 22469, 22481);
                    return return_v;
                }


                bool
                f_421_22515_22550(string
                value, out System.Collections.Immutable.ImmutableArray<byte>
                result)
                {
                    var return_v = TryParseHexBytes(value, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 22515, 22550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 22024, 22714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 22024, 22714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryParseHexBytes(string value, out ImmutableArray<byte> result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 22726, 23601);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22834, 22979) || true) && (f_421_22838_22850(value) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(421, 22838, 22882) || (f_421_22860_22872(value) % 2) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 22834, 22979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22916, 22933);

                    result = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22951, 22964);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 22834, 22979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 22995, 23025);

                var
                length = f_421_23008_23020(value) / 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23039, 23090);

                var
                bytes = f_421_23051_23089(length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23113, 23118);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23104, 23512) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23132, 23135)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(421, 23104, 23512))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 23104, 23512);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23169, 23201);

                        int
                        hi = f_421_23178_23200(f_421_23187_23199(value, i * 2))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23219, 23255);

                        int
                        lo = f_421_23228_23254(f_421_23237_23253(value, i * 2 + 1))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23275, 23443) || true) && (hi < 0 || (DynAbs.Tracing.TraceSender.Expression_False(421, 23279, 23295) || lo < 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 23275, 23443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23337, 23354);

                            result = default;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23376, 23389);

                            f_421_23376_23388(bytes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23411, 23424);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 23275, 23443);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23463, 23497);

                        f_421_23463_23496(
                                        bytes, ((hi << 4) | lo));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 1, 409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(421, 1, 409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23528, 23564);

                result = f_421_23537_23563(bytes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23578, 23590);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 22726, 23601);

                int
                f_421_22838_22850(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 22838, 22850);
                    return return_v;
                }


                int
                f_421_22860_22872(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 22860, 22872);
                    return return_v;
                }


                int
                f_421_23008_23020(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 23008, 23020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                f_421_23051_23089(int
                capacity)
                {
                    var return_v = ArrayBuilder<byte>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 23051, 23089);
                    return return_v;
                }


                char
                f_421_23187_23199(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 23187, 23199);
                    return return_v;
                }


                int
                f_421_23178_23200(char
                c)
                {
                    var return_v = HexValue(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 23178, 23200);
                    return return_v;
                }


                char
                f_421_23237_23253(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 23237, 23253);
                    return return_v;
                }


                int
                f_421_23228_23254(char
                c)
                {
                    var return_v = HexValue(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 23228, 23254);
                    return return_v;
                }


                int
                f_421_23376_23388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 23376, 23388);
                    return 0;
                }


                int
                f_421_23463_23496(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, int
                item)
                {
                    this_param.Add((byte)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 23463, 23496);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_421_23537_23563(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 23537, 23563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 22726, 23601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 22726, 23601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int HexValue(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 23613, 24017);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23674, 23762) || true) && (c >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(421, 23678, 23698) && c <= '9'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 23674, 23762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23732, 23747);

                    return c - '0';
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 23674, 23762);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23778, 23871) || true) && (c >= 'a' && (DynAbs.Tracing.TraceSender.Expression_True(421, 23782, 23802) && c <= 'f'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 23778, 23871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23836, 23856);

                    return c - 'a' + 10;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 23778, 23871);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23887, 23980) || true) && (c >= 'A' && (DynAbs.Tracing.TraceSender.Expression_True(421, 23891, 23911) && c <= 'F'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 23887, 23980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23945, 23965);

                    return c - 'A' + 10;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 23887, 23980);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 23996, 24006);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 23613, 24017);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 23613, 24017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 23613, 24017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsWhiteSpace(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 24029, 24160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24094, 24149);

                return c == ' ' || (DynAbs.Tracing.TraceSender.Expression_False(421, 24101, 24122) || c == '\t') || (DynAbs.Tracing.TraceSender.Expression_False(421, 24101, 24135) || c == '\r') || (DynAbs.Tracing.TraceSender.Expression_False(421, 24101, 24148) || c == '\n');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 24029, 24160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 24029, 24160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 24029, 24160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void EscapeName(StringBuilder result, string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 24172, 25576);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24263, 24349) || true) && (f_421_24267_24293(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 24263, 24349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24327, 24334);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 24263, 24349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24365, 24385);

                bool
                quoted = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24399, 24563) || true) && (f_421_24403_24424(f_421_24416_24423(name, 0)) || (DynAbs.Tracing.TraceSender.Expression_False(421, 24403, 24463) || f_421_24428_24463(f_421_24441_24462(name, f_421_24446_24457(name) - 1))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 24399, 24563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24497, 24516);

                    f_421_24497_24515(result, '"');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24534, 24548);

                    quoted = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 24399, 24563);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24588, 24593);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24579, 25471) || true) && (i < f_421_24599_24610(name))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24612, 24615)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(421, 24579, 25471))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 24579, 25471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24649, 24666);

                        char
                        c = f_421_24658_24665(name, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24684, 25456);

                        switch (c)
                        {

                            case ',':
                            case '=':
                            case '\\':
                            case '"':
                            case '\'':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 24684, 25456);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24896, 24916);

                                f_421_24896_24915(result, '\\');
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 24942, 24959);

                                f_421_24942_24958(result, c);
                                DynAbs.Tracing.TraceSender.TraceBreak(421, 24985, 24991);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 24684, 25456);

                            case '\t':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 24684, 25456);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25051, 25072);

                                f_421_25051_25071(result, "\\t");
                                DynAbs.Tracing.TraceSender.TraceBreak(421, 25098, 25104);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 24684, 25456);

                            case '\r':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 24684, 25456);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25164, 25185);

                                f_421_25164_25184(result, "\\r");
                                DynAbs.Tracing.TraceSender.TraceBreak(421, 25211, 25217);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 24684, 25456);

                            case '\n':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 24684, 25456);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25277, 25298);

                                f_421_25277_25297(result, "\\n");
                                DynAbs.Tracing.TraceSender.TraceBreak(421, 25324, 25330);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 24684, 25456);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 24684, 25456);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25388, 25405);

                                f_421_25388_25404(result, c);
                                DynAbs.Tracing.TraceSender.TraceBreak(421, 25431, 25437);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 24684, 25456);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 1, 893);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(421, 1, 893);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25487, 25565) || true) && (quoted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 25487, 25565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25531, 25550);

                    f_421_25531_25549(result, '"');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 25487, 25565);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 24172, 25576);

                bool
                f_421_24267_24293(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 24267, 24293);
                    return return_v;
                }


                char
                f_421_24416_24423(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 24416, 24423);
                    return return_v;
                }


                bool
                f_421_24403_24424(char
                c)
                {
                    var return_v = IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 24403, 24424);
                    return return_v;
                }


                int
                f_421_24446_24457(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 24446, 24457);
                    return return_v;
                }


                char
                f_421_24441_24462(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 24441, 24462);
                    return return_v;
                }


                bool
                f_421_24428_24463(char
                c)
                {
                    var return_v = IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 24428, 24463);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_24497_24515(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 24497, 24515);
                    return return_v;
                }


                int
                f_421_24599_24610(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 24599, 24610);
                    return return_v;
                }


                char
                f_421_24658_24665(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 24658, 24665);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_24896_24915(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 24896, 24915);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_24942_24958(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 24942, 24958);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_25051_25071(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 25051, 25071);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_25164_25184(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 25164, 25184);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_25277_25297(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 25277, 25297);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_25388_25404(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 25388, 25404);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_25531_25549(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 25531, 25549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 24172, 25576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 24172, 25576);
            }
        }

        private static bool TryUnescape(string str, int start, int end, [NotNullWhen(true)] out string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 25588, 26322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25715, 25758);

                var
                sb = f_421_25724_25757()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25774, 25788);

                int
                i = start
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25802, 26240) || true) && (i < end)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 25802, 26240);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25850, 25868);

                        char
                        c = f_421_25859_25867(str, i++)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25886, 26225) || true) && (c == '\\')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 25886, 26225);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 25941, 26103) || true) && (!f_421_25946_25978(sb.Builder, str, ref i))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 25941, 26103);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26028, 26041);

                                value = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26067, 26080);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 25941, 26103);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 25886, 26225);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 25886, 26225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26185, 26206);

                            f_421_26185_26205(sb.Builder, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 25886, 26225);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 25802, 26240);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(421, 25802, 26240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(421, 25802, 26240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26256, 26285);

                value = f_421_26264_26284(sb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26299, 26311);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 25588, 26322);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_421_25724_25757()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 25724, 25757);
                    return return_v;
                }


                char
                f_421_25859_25867(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 25859, 25867);
                    return return_v;
                }


                bool
                f_421_25946_25978(System.Text.StringBuilder
                sb, string
                str, ref int
                i)
                {
                    var return_v = Unescape(sb, str, ref i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 25946, 25978);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_26185_26205(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 26185, 26205);
                    return return_v;
                }


                string
                f_421_26264_26284(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 26264, 26284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 25588, 26322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 25588, 26322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Unescape(StringBuilder sb, string str, ref int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(421, 26334, 28057);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26428, 26509) || true) && (i == f_421_26437_26447(str))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 26428, 26509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26481, 26494);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(421, 26428, 26509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26525, 26543);

                char
                c = f_421_26534_26542(str, i++)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26557, 28046);

                switch (c)
                {

                    case ',':
                    case '=':
                    case '\\':
                    case '/':
                    case '"':
                    case '\'':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 26557, 28046);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26768, 26781);

                        f_421_26768_26780(sb, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26803, 26815);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 26557, 28046);

                    case 't':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 26557, 28046);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26866, 26882);

                        f_421_26866_26881(sb, "\t");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26904, 26916);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 26557, 28046);

                    case 'n':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 26557, 28046);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 26967, 26983);

                        f_421_26967_26982(sb, "\n");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27005, 27017);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 26557, 28046);

                    case 'r':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 26557, 28046);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27068, 27084);

                        f_421_27068_27083(sb, "\r");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27106, 27118);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 26557, 28046);

                    case 'u':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 26557, 28046);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27169, 27205);

                        int
                        semicolon = f_421_27185_27204(str, ';', i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27227, 27332) || true) && (semicolon == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 27227, 27332);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27296, 27309);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(421, 27227, 27332);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27408, 27477);

                            int
                            codepoint = f_421_27424_27476(f_421_27440_27471(str, i, semicolon - i), 16)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27569, 27685) || true) && (codepoint == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 27569, 27685);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27645, 27658);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(421, 27569, 27685);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27713, 27757);

                            f_421_27713_27756(
                                                    sb, f_421_27723_27755(codepoint));
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(421, 27802, 27892);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27856, 27869);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(421, 27802, 27892);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27916, 27934);

                        i = semicolon + 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 27956, 27968);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 26557, 28046);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(421, 26557, 28046);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 28018, 28031);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(421, 26557, 28046);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(421, 26334, 28057);

                int
                f_421_26437_26447(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 26437, 26447);
                    return return_v;
                }


                char
                f_421_26534_26542(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(421, 26534, 26542);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_26768_26780(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 26768, 26780);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_26866_26881(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 26866, 26881);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_26967_26982(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 26967, 26982);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_27068_27083(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 27068, 27083);
                    return return_v;
                }


                int
                f_421_27185_27204(string
                this_param, char
                value, int
                startIndex)
                {
                    var return_v = this_param.IndexOf(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 27185, 27204);
                    return return_v;
                }


                string
                f_421_27440_27471(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 27440, 27471);
                    return return_v;
                }


                int
                f_421_27424_27476(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToInt32(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 27424, 27476);
                    return return_v;
                }


                string
                f_421_27723_27755(int
                utf32)
                {
                    var return_v = char.ConvertFromUtf32(utf32);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 27723, 27755);
                    return return_v;
                }


                System.Text.StringBuilder
                f_421_27713_27756(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(421, 27713, 27756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(421, 26334, 28057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(421, 26334, 28057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
