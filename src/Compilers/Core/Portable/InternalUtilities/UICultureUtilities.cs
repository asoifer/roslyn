// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;

namespace Roslyn.Utilities
{
    internal static class UICultureUtilities
    {
        private const string
        currentUICultureName = "CurrentUICulture"
        ;

        private static readonly Action<CultureInfo>? s_setCurrentUICulture;

        private static bool TryGetCurrentUICultureSetter([NotNullWhen(returnValue: true)] out Action<CultureInfo>? setter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(393, 661, 2381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 800, 870);

                const string
                cultureInfoTypeName = "System.Globalization.CultureInfo"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 884, 1046);

                const string
                cultureInfoTypeNameGlobalization = cultureInfoTypeName + ", System.Globalization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1098, 1226);

                    var
                    type = f_393_1109_1155(cultureInfoTypeNameGlobalization) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type?>(393, 1109, 1225) ?? f_393_1159_1225(f_393_1159_1196(f_393_1159_1187(typeof(object))), cultureInfoTypeName))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1244, 1379) || true) && ((object?)type == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 1244, 1379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1311, 1325);

                        setter = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1347, 1360);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(393, 1244, 1379);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1399, 1500);

                    var
                    currentUICultureSetter = f_393_1428_1499_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_393_1428_1488(f_393_1428_1446(type), currentUICultureName), 393, 1428, 1499)?.SetMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1518, 1812) || true) && ((object?)currentUICultureSetter == null || (DynAbs.Tracing.TraceSender.Expression_False(393, 1522, 1597) || f_393_1565_1597_M(!currentUICultureSetter.IsStatic)) || (DynAbs.Tracing.TraceSender.Expression_False(393, 1522, 1649) || f_393_1601_1649(currentUICultureSetter)) || (DynAbs.Tracing.TraceSender.Expression_False(393, 1522, 1702) || f_393_1653_1686(currentUICultureSetter) != typeof(void)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 1518, 1812);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1744, 1758);

                        setter = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1780, 1793);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(393, 1518, 1812);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1832, 1888);

                    var
                    parameters = f_393_1849_1887(currentUICultureSetter)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 1906, 2096) || true) && (f_393_1910_1927(parameters) != 1 || (DynAbs.Tracing.TraceSender.Expression_False(393, 1910, 1986) || f_393_1936_1963(parameters[0]) != typeof(CultureInfo)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 1906, 2096);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2028, 2042);

                        setter = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2064, 2077);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(393, 1906, 2096);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2116, 2213);

                    setter = (Action<CultureInfo>)f_393_2146_2212(currentUICultureSetter, typeof(Action<CultureInfo>));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2231, 2243);

                    return true;
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(393, 2272, 2370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2310, 2324);

                    setter = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2342, 2355);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(393, 2272, 2370);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(393, 661, 2381);

                System.Type?
                f_393_1109_1155(string
                typeName)
                {
                    var return_v = Type.GetType(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 1109, 1155);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_393_1159_1187(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 1159, 1187);
                    return return_v;
                }


                System.Reflection.Assembly
                f_393_1159_1196(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 1159, 1196);
                    return return_v;
                }


                System.Type?
                f_393_1159_1225(System.Reflection.Assembly
                this_param, string
                name)
                {
                    var return_v = this_param.GetType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 1159, 1225);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_393_1428_1446(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 1428, 1446);
                    return return_v;
                }


                System.Reflection.PropertyInfo?
                f_393_1428_1488(System.Reflection.TypeInfo
                this_param, string
                name)
                {
                    var return_v = this_param?.GetDeclaredProperty(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 1428, 1488);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_393_1428_1499_M(System.Reflection.MethodInfo?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 1428, 1499);
                    return return_v;
                }


                bool
                f_393_1565_1597_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 1565, 1597);
                    return return_v;
                }


                bool
                f_393_1601_1649(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ContainsGenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 1601, 1649);
                    return return_v;
                }


                System.Type
                f_393_1653_1686(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 1653, 1686);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_393_1849_1887(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 1849, 1887);
                    return return_v;
                }


                int
                f_393_1910_1927(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 1910, 1927);
                    return return_v;
                }


                System.Type
                f_393_1936_1963(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 1936, 1963);
                    return return_v;
                }


                System.Delegate
                f_393_2146_2212(System.Reflection.MethodInfo
                this_param, System.Type
                delegateType)
                {
                    var return_v = this_param.CreateDelegate(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 2146, 2212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(393, 661, 2381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(393, 661, 2381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetCurrentThreadUICultureSetter([NotNullWhen(returnValue: true)] out Action<CultureInfo>? setter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(393, 2393, 4489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2538, 2594);

                const string
                threadTypeName = "System.Threading.Thread"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2608, 2657);

                const string
                currentThreadName = "CurrentThread"
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2709, 2782);

                    var
                    type = f_393_2720_2781(f_393_2720_2757(f_393_2720_2748(typeof(object))), threadTypeName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2800, 2926) || true) && (type is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 2800, 2926);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2858, 2872);

                        setter = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2894, 2907);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(393, 2800, 2926);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2946, 2980);

                    var
                    typeInfo = f_393_2961_2979(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 2998, 3083);

                    var
                    currentThreadGetter = f_393_3024_3082_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_393_3024_3071(typeInfo, currentThreadName), 393, 3024, 3082)?.GetMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 3101, 3426) || true) && ((object?)currentThreadGetter == null || (DynAbs.Tracing.TraceSender.Expression_False(393, 3105, 3174) || f_393_3145_3174_M(!currentThreadGetter.IsStatic)) || (DynAbs.Tracing.TraceSender.Expression_False(393, 3105, 3223) || f_393_3178_3223(currentThreadGetter)) || (DynAbs.Tracing.TraceSender.Expression_False(393, 3105, 3265) || f_393_3227_3257(currentThreadGetter) != type) || (DynAbs.Tracing.TraceSender.Expression_False(393, 3105, 3316) || f_393_3269_3311(f_393_3269_3304(currentThreadGetter)) != 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 3101, 3426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 3358, 3372);

                        setter = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 3394, 3407);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(393, 3101, 3426);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 3446, 3537);

                    var
                    currentUICultureSetter = f_393_3475_3536_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_393_3475_3525(typeInfo, currentUICultureName), 393, 3475, 3536)?.SetMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 3555, 3848) || true) && ((object?)currentUICultureSetter == null || (DynAbs.Tracing.TraceSender.Expression_False(393, 3559, 3633) || f_393_3602_3633(currentUICultureSetter)) || (DynAbs.Tracing.TraceSender.Expression_False(393, 3559, 3685) || f_393_3637_3685(currentUICultureSetter)) || (DynAbs.Tracing.TraceSender.Expression_False(393, 3559, 3738) || f_393_3689_3722(currentUICultureSetter) != typeof(void)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 3555, 3848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 3780, 3794);

                        setter = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 3816, 3829);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(393, 3555, 3848);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 3868, 3924);

                    var
                    parameters = f_393_3885_3923(currentUICultureSetter)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 3942, 4132) || true) && (f_393_3946_3963(parameters) != 1 || (DynAbs.Tracing.TraceSender.Expression_False(393, 3946, 4022) || f_393_3972_3999(parameters[0]) != typeof(CultureInfo)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 3942, 4132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4064, 4078);

                        setter = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4100, 4113);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(393, 3942, 4132);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4152, 4321);

                    setter = culture =>
                                    {
                                        currentUICultureSetter.Invoke(currentThreadGetter.Invoke(null, null), new[] { culture });
                                    };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4339, 4351);

                    return true;
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(393, 4380, 4478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4418, 4432);

                    setter = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4450, 4463);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(393, 4380, 4478);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(393, 2393, 4489);

                System.Reflection.TypeInfo
                f_393_2720_2748(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 2720, 2748);
                    return return_v;
                }


                System.Reflection.Assembly
                f_393_2720_2757(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 2720, 2757);
                    return return_v;
                }


                System.Type?
                f_393_2720_2781(System.Reflection.Assembly
                this_param, string
                name)
                {
                    var return_v = this_param.GetType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 2720, 2781);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_393_2961_2979(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 2961, 2979);
                    return return_v;
                }


                System.Reflection.PropertyInfo?
                f_393_3024_3071(System.Reflection.TypeInfo
                this_param, string
                name)
                {
                    var return_v = this_param?.GetDeclaredProperty(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 3024, 3071);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_393_3024_3082_M(System.Reflection.MethodInfo?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3024, 3082);
                    return return_v;
                }


                bool
                f_393_3145_3174_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3145, 3174);
                    return return_v;
                }


                bool
                f_393_3178_3223(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ContainsGenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3178, 3223);
                    return return_v;
                }


                System.Type
                f_393_3227_3257(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3227, 3257);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_393_3269_3304(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 3269, 3304);
                    return return_v;
                }


                int
                f_393_3269_3311(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3269, 3311);
                    return return_v;
                }


                System.Reflection.PropertyInfo?
                f_393_3475_3525(System.Reflection.TypeInfo
                this_param, string
                name)
                {
                    var return_v = this_param?.GetDeclaredProperty(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 3475, 3525);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_393_3475_3536_M(System.Reflection.MethodInfo?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3475, 3536);
                    return return_v;
                }


                bool
                f_393_3602_3633(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3602, 3633);
                    return return_v;
                }


                bool
                f_393_3637_3685(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ContainsGenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3637, 3685);
                    return return_v;
                }


                System.Type
                f_393_3689_3722(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3689, 3722);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_393_3885_3923(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 3885, 3923);
                    return return_v;
                }


                int
                f_393_3946_3963(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3946, 3963);
                    return return_v;
                }


                System.Type
                f_393_3972_3999(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 3972, 3999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(393, 2393, 4489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(393, 2393, 4489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UICultureUtilities()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(393, 4501, 4785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 530, 571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 627, 648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4553, 4774) || true) && (!f_393_4558_4613(out s_setCurrentUICulture) && (DynAbs.Tracing.TraceSender.Expression_True(393, 4557, 4696) && !f_393_4635_4696(out s_setCurrentUICulture)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 4553, 4774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4730, 4759);

                    s_setCurrentUICulture = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(393, 4553, 4774);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(393, 4501, 4785);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(393, 4501, 4785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(393, 4501, 4785);
            }
        }

        public static Action WithCurrentUICulture(Action action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(393, 4797, 5659);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4878, 4974) || true) && (s_setCurrentUICulture == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 4878, 4974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4945, 4959);

                    return action;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(393, 4878, 4974);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 4990, 5038);

                var
                savedCulture = f_393_5009_5037()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 5052, 5648);

                return () =>
                            {
                                var currentCulture = CultureInfo.CurrentUICulture;
                                if (currentCulture != savedCulture)
                                {
                                    s_setCurrentUICulture(savedCulture);
                                    try
                                    {
                                        action();
                                    }
                                    finally
                                    {
                                        s_setCurrentUICulture(currentCulture);
                                    }
                                }
                                else
                                {
                                    action();
                                }
                            };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(393, 4797, 5659);

                System.Globalization.CultureInfo
                f_393_5009_5037()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 5009, 5037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(393, 4797, 5659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(393, 4797, 5659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Action<T> WithCurrentUICulture<T>(Action<T> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(393, 5671, 6555);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 5761, 5857) || true) && (s_setCurrentUICulture == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 5761, 5857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 5828, 5842);

                    return action;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(393, 5761, 5857);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 5873, 5921);

                var
                savedCulture = f_393_5892_5920()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 5935, 6544);

                return param =>
                            {
                                var currentCulture = CultureInfo.CurrentUICulture;
                                if (currentCulture != savedCulture)
                                {
                                    s_setCurrentUICulture(savedCulture);
                                    try
                                    {
                                        action(param);
                                    }
                                    finally
                                    {
                                        s_setCurrentUICulture(currentCulture);
                                    }
                                }
                                else
                                {
                                    action(param);
                                }
                            };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(393, 5671, 6555);

                System.Globalization.CultureInfo
                f_393_5892_5920()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 5892, 5920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(393, 5671, 6555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(393, 5671, 6555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Func<T> WithCurrentUICulture<T>(Func<T> func)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(393, 6567, 7440);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 6651, 6745) || true) && (s_setCurrentUICulture == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(393, 6651, 6745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 6718, 6730);

                    return func;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(393, 6651, 6745);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 6761, 6809);

                var
                savedCulture = f_393_6780_6808()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(393, 6823, 7429);

                return () =>
                            {
                                var currentCulture = CultureInfo.CurrentUICulture;
                                if (currentCulture != savedCulture)
                                {
                                    s_setCurrentUICulture(savedCulture);
                                    try
                                    {
                                        return func();
                                    }
                                    finally
                                    {
                                        s_setCurrentUICulture(currentCulture);
                                    }
                                }
                                else
                                {
                                    return func();
                                }
                            };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(393, 6567, 7440);

                System.Globalization.CultureInfo
                f_393_6780_6808()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(393, 6780, 6808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(393, 6567, 7440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(393, 6567, 7440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static bool
        f_393_4558_4613(out System.Action<System.Globalization.CultureInfo>?
        setter)
        {
            var return_v = TryGetCurrentUICultureSetter(out setter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 4558, 4613);
            return return_v;
        }


        static bool
        f_393_4635_4696(out System.Action<System.Globalization.CultureInfo>?
        setter)
        {
            var return_v = TryGetCurrentThreadUICultureSetter(out setter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(393, 4635, 4696);
            return return_v;
        }

    }
}
