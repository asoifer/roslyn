// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis
{
    internal static class HashSetExtensions
    {
        internal static bool IsNullOrEmpty<T>([NotNullWhen(returnValue: false)] this HashSet<T>? hashSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(102, 382, 560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(102, 504, 549);

                return hashSet == null || (DynAbs.Tracing.TraceSender.Expression_False(102, 511, 548) || f_102_530_543(hashSet) == 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(102, 382, 560);

                int
                f_102_530_543(System.Collections.Generic.HashSet<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(102, 530, 543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(102, 382, 560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(102, 382, 560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool InitializeAndAdd<T>([NotNullIfNotNull(parameterName: "item"), NotNullWhen(returnValue: true)] ref HashSet<T>? hashSet, [NotNullWhen(returnValue: true)] T? item)
                    where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(102, 572, 1051);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(102, 807, 999) || true) && (item is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(102, 807, 999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(102, 857, 870);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(102, 807, 999);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(102, 807, 999);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(102, 904, 999) || true) && (hashSet is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(102, 904, 999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(102, 957, 984);

                        hashSet = f_102_967_983();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(102, 904, 999);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(102, 807, 999);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(102, 1015, 1040);

                return f_102_1022_1039(hashSet, item);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(102, 572, 1051);

                System.Collections.Generic.HashSet<T>
                f_102_967_983()
                {
                    var return_v = new System.Collections.Generic.HashSet<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(102, 967, 983);
                    return return_v;
                }


                bool
                f_102_1022_1039(System.Collections.Generic.HashSet<T>
                this_param, T
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(102, 1022, 1039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(102, 572, 1051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(102, 572, 1051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static HashSetExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(102, 326, 1058);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(102, 326, 1058);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(102, 326, 1058);
        }

    }
}
