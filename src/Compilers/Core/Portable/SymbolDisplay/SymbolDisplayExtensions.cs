// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{
    public static class SymbolDisplayExtensions
    {
        public static string ToDisplayString(this ImmutableArray<SymbolDisplayPart> parts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(574, 801, 1667);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 908, 1013) || true) && (parts.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(574, 908, 1013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 961, 998);

                    throw f_574_967_997("parts");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(574, 908, 1013);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1029, 1119) || true) && (parts.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(574, 1029, 1119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1084, 1104);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(574, 1029, 1119);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1135, 1232) || true) && (parts.Length == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(574, 1135, 1232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1190, 1217);

                    return parts[0].ToString();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(574, 1135, 1232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1248, 1293);

                var
                pool = f_574_1259_1292()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1343, 1376);

                    var
                    actualBuilder = pool.Builder
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1394, 1508);
                        foreach (var part in f_574_1415_1420_I(parts))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(574, 1394, 1508);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1462, 1489);

                            f_574_1462_1488(actualBuilder, part);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(574, 1394, 1508);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(574, 1, 115);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(574, 1, 115);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1528, 1560);

                    return f_574_1535_1559(actualBuilder);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(574, 1589, 1656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 1629, 1641);

                    f_574_1629_1640(pool);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(574, 1589, 1656);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(574, 801, 1667);

                System.ArgumentException
                f_574_967_997(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(574, 967, 997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_574_1259_1292()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(574, 1259, 1292);
                    return return_v;
                }


                System.Text.StringBuilder
                f_574_1462_1488(System.Text.StringBuilder
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(574, 1462, 1488);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_574_1415_1420_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(574, 1415, 1420);
                    return return_v;
                }


                string
                f_574_1535_1559(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(574, 1535, 1559);
                    return return_v;
                }


                int
                f_574_1629_1640(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(574, 1629, 1640);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(574, 801, 1667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(574, 801, 1667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IncludesOption(this SymbolDisplayCompilerInternalOptions options, SymbolDisplayCompilerInternalOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(574, 2083, 2280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 2237, 2269);

                return (options & flag) == flag;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(574, 2083, 2280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(574, 2083, 2280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(574, 2083, 2280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IncludesOption(this SymbolDisplayGenericsOptions options, SymbolDisplayGenericsOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(574, 2688, 2869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 2826, 2858);

                return (options & flag) == flag;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(574, 2688, 2869);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(574, 2688, 2869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(574, 2688, 2869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IncludesOption(this SymbolDisplayMemberOptions options, SymbolDisplayMemberOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(574, 3275, 3452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 3409, 3441);

                return (options & flag) == flag;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(574, 3275, 3452);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(574, 3275, 3452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(574, 3275, 3452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IncludesOption(this SymbolDisplayMiscellaneousOptions options, SymbolDisplayMiscellaneousOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(574, 3865, 4056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 4013, 4045);

                return (options & flag) == flag;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(574, 3865, 4056);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(574, 3865, 4056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(574, 3865, 4056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IncludesOption(this SymbolDisplayParameterOptions options, SymbolDisplayParameterOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(574, 4465, 4648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 4605, 4637);

                return (options & flag) == flag;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(574, 4465, 4648);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(574, 4465, 4648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(574, 4465, 4648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IncludesOption(this SymbolDisplayKindOptions options, SymbolDisplayKindOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(574, 5052, 5225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 5182, 5214);

                return (options & flag) == flag;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(574, 5052, 5225);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(574, 5052, 5225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(574, 5052, 5225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IncludesOption(this SymbolDisplayLocalOptions options, SymbolDisplayLocalOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(574, 5630, 5805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(574, 5762, 5794);

                return (options & flag) == flag;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(574, 5630, 5805);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(574, 5630, 5805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(574, 5630, 5805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolDisplayExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(574, 458, 5812);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(574, 458, 5812);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(574, 458, 5812);
        }

    }
}
