// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace Roslyn.Utilities
{
    internal static class ReflectionUtilities
    {
        private static readonly Type Missing;

        public static Type? TryGetType(string assemblyQualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 551, 932);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 763, 827);

                    return f_360_770_826(assemblyQualifiedName, throwOnError: false);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(360, 856, 921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 894, 906);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(360, 856, 921);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 551, 932);

                System.Type?
                f_360_770_826(string
                typeName, bool
                throwOnError)
                {
                    var return_v = Type.GetType(typeName, throwOnError: throwOnError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 770, 826);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 551, 932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 551, 932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Type? TryGetType([NotNull] ref Type? lazyType, string assemblyQualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 944, 1258);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 1059, 1184) || true) && (lazyType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 1059, 1184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 1113, 1169);

                    lazyType = f_360_1124_1157(assemblyQualifiedName) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type?>(360, 1124, 1168) ?? Missing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(360, 1059, 1184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 1200, 1247);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(360, 1207, 1228) || (((lazyType == Missing) && DynAbs.Tracing.TraceSender.Conditional_F2(360, 1231, 1235)) || DynAbs.Tracing.TraceSender.Conditional_F3(360, 1238, 1246))) ? null : lazyType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 944, 1258);

                System.Type?
                f_360_1124_1157(string
                assemblyQualifiedName)
                {
                    var return_v = TryGetType(assemblyQualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 1124, 1157);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 944, 1258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 944, 1258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Type? GetTypeFromEither(string contractName, string desktopName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 1523, 1813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 1626, 1662);

                var
                type = f_360_1637_1661(contractName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 1678, 1774) || true) && (type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 1678, 1774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 1728, 1759);

                    type = f_360_1735_1758(desktopName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(360, 1678, 1774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 1790, 1802);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 1523, 1813);

                System.Type?
                f_360_1637_1661(string
                assemblyQualifiedName)
                {
                    var return_v = TryGetType(assemblyQualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 1637, 1661);
                    return return_v;
                }


                System.Type?
                f_360_1735_1758(string
                assemblyQualifiedName)
                {
                    var return_v = TryGetType(assemblyQualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 1735, 1758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 1523, 1813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 1523, 1813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Type? GetTypeFromEither([NotNull] ref Type? lazyType, string contractName, string desktopName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 1825, 2168);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 1958, 2094) || true) && (lazyType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 1958, 2094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2012, 2079);

                    lazyType = f_360_2023_2067(contractName, desktopName) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type?>(360, 2023, 2078) ?? Missing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(360, 1958, 2094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2110, 2157);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(360, 2117, 2138) || (((lazyType == Missing) && DynAbs.Tracing.TraceSender.Conditional_F2(360, 2141, 2145)) || DynAbs.Tracing.TraceSender.Conditional_F3(360, 2148, 2156))) ? null : lazyType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 1825, 2168);

                System.Type?
                f_360_2023_2067(string
                contractName, string
                desktopName)
                {
                    var return_v = GetTypeFromEither(contractName, desktopName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 2023, 2067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 1825, 2168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 1825, 2168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T? FindItem<T>(IEnumerable<T> collection, params Type[] paramTypes)
                    where T : MethodBase
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 2180, 3026);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2320, 2987);
                    foreach (var current in f_360_2344_2354_I(collection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 2320, 2987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2388, 2420);

                        var
                        p = f_360_2396_2419(current)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2438, 2541) || true) && (f_360_2442_2450(p) != f_360_2454_2471(paramTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 2438, 2541);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2513, 2522);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(360, 2438, 2541);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2561, 2582);

                        bool
                        allMatch = true
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2609, 2614);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2600, 2864) || true) && (i < f_360_2620_2637(paramTypes))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2639, 2642)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(360, 2600, 2864))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 2600, 2864);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2684, 2845) || true) && (f_360_2688_2706(p[i]) != paramTypes[i])
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 2684, 2845);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2773, 2790);

                                    allMatch = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(360, 2816, 2822);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(360, 2684, 2845);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(360, 1, 265);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(360, 1, 265);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2884, 2972) || true) && (allMatch)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 2884, 2972);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 2938, 2953);

                            return current;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(360, 2884, 2972);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(360, 2320, 2987);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(360, 1, 668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(360, 1, 668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 3003, 3015);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 2180, 3026);

                System.Reflection.ParameterInfo[]
                f_360_2396_2419(T
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 2396, 2419);
                    return return_v;
                }


                int
                f_360_2442_2450(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(360, 2442, 2450);
                    return return_v;
                }


                int
                f_360_2454_2471(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(360, 2454, 2471);
                    return return_v;
                }


                int
                f_360_2620_2637(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(360, 2620, 2637);
                    return return_v;
                }


                System.Type
                f_360_2688_2706(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(360, 2688, 2706);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_360_2344_2354_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 2344, 2354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 2180, 3026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 2180, 3026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodInfo? GetDeclaredMethod(this TypeInfo typeInfo, string name, params Type[] paramTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 3038, 3245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 3171, 3234);

                return f_360_3178_3233(f_360_3187_3220(typeInfo, name), paramTypes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 3038, 3245);

                System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>
                f_360_3187_3220(System.Reflection.TypeInfo
                this_param, string
                name)
                {
                    var return_v = this_param.GetDeclaredMethods(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 3187, 3220);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_360_3178_3233(System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>
                collection, params System.Type[]
                paramTypes)
                {
                    var return_v = FindItem(collection, paramTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 3178, 3233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 3038, 3245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 3038, 3245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConstructorInfo? GetDeclaredConstructor(this TypeInfo typeInfo, params Type[] paramTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 3257, 3457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 3387, 3446);

                return f_360_3394_3445(f_360_3403_3432(typeInfo), paramTypes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 3257, 3457);

                System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo>
                f_360_3403_3432(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.DeclaredConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(360, 3403, 3432);
                    return return_v;
                }


                System.Reflection.ConstructorInfo?
                f_360_3394_3445(System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo>
                collection, params System.Type[]
                paramTypes)
                {
                    var return_v = FindItem(collection, paramTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 3394, 3445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 3257, 3457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 3257, 3457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T? CreateDelegate<T>(this MethodInfo? methodInfo)
                    where T : Delegate
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 3469, 3746);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 3589, 3672) || true) && (methodInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 3589, 3672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 3645, 3657);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(360, 3589, 3672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 3688, 3735);

                return (T)f_360_3698_3734(methodInfo, typeof(T));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 3469, 3746);

                System.Delegate
                f_360_3698_3734(System.Reflection.MethodInfo
                this_param, System.Type
                delegateType)
                {
                    var return_v = this_param.CreateDelegate(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 3698, 3734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 3469, 3746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 3469, 3746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T? InvokeConstructor<T>(this ConstructorInfo? constructorInfo, params object?[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 3758, 4389);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 3882, 3973) || true) && (constructorInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(360, 3882, 3973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 3943, 3958);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(360, 3882, 3973);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 4025, 4065);

                    return (T?)f_360_4036_4064(constructorInfo, args);
                }
                catch (TargetInvocationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(360, 4094, 4378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 4162, 4203);

                    f_360_4162_4202(f_360_4175_4191(e) is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 4221, 4277);

                    f_360_4221_4276(f_360_4221_4268(f_360_4251_4267(e)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 4295, 4330);

                    f_360_4295_4329(false, "Unreachable");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 4348, 4363);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(360, 4094, 4378);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 3758, 4389);

                object
                f_360_4036_4064(System.Reflection.ConstructorInfo
                this_param, object?[]
                parameters)
                {
                    var return_v = this_param.Invoke(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 4036, 4064);
                    return return_v;
                }


                System.Exception?
                f_360_4175_4191(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(360, 4175, 4191);
                    return return_v;
                }


                int
                f_360_4162_4202(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 4162, 4202);
                    return 0;
                }


                System.Exception
                f_360_4251_4267(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(360, 4251, 4267);
                    return return_v;
                }


                System.Runtime.ExceptionServices.ExceptionDispatchInfo
                f_360_4221_4268(System.Exception
                source)
                {
                    var return_v = ExceptionDispatchInfo.Capture(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 4221, 4268);
                    return return_v;
                }


                int
                f_360_4221_4276(System.Runtime.ExceptionServices.ExceptionDispatchInfo
                this_param)
                {
                    this_param.Throw();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 4221, 4276);
                    return 0;
                }


                int
                f_360_4295_4329(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 4295, 4329);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 3758, 4389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 3758, 4389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object? InvokeConstructor(this ConstructorInfo constructorInfo, params object?[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 4401, 4593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 4526, 4582);

                return f_360_4533_4581(constructorInfo, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 4401, 4593);

                object?
                f_360_4533_4581(System.Reflection.ConstructorInfo
                constructorInfo, params object?[]
                args)
                {
                    var return_v = constructorInfo.InvokeConstructor<object?>(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 4533, 4581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 4401, 4593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 4401, 4593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T? Invoke<T>(this MethodInfo methodInfo, object obj, params object?[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(360, 4605, 4770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 4719, 4759);

                return (T?)f_360_4730_4758(methodInfo, obj, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(360, 4605, 4770);

                object?
                f_360_4730_4758(System.Reflection.MethodInfo
                this_param, object
                obj, object?[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(360, 4730, 4758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(360, 4605, 4770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 4605, 4770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ReflectionUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(360, 429, 4777);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(360, 516, 538);
            Missing = typeof(void); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(360, 429, 4777);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(360, 429, 4777);
        }

    }
}
