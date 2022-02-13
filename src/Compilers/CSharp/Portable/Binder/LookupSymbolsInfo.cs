// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LookupSymbolsInfo : AbstractLookupSymbolsInfo<Symbol>
    {
        private const int
        poolSize = 64
        ;

        private static readonly ObjectPool<LookupSymbolsInfo> s_pool;

        private LookupSymbolsInfo()
        : base(f_10356_757_779_C(f_10356_757_779()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10356, 709, 802);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10356, 709, 802);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10356, 709, 802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10356, 709, 802);
            }
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10356, 912, 1105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10356, 1049, 1062);

                f_10356_1049_1061(            // Note that poolables are not finalizable. If one gets collected - no big deal.
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10356, 1076, 1094);

                f_10356_1076_1093(s_pool, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10356, 912, 1105);

                int
                f_10356_1049_1061(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10356, 1049, 1061);
                    return 0;
                }


                int
                f_10356_1076_1093(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10356, 1076, 1093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10356, 912, 1105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10356, 912, 1105);
            }
        }

        public static LookupSymbolsInfo GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10356, 1167, 1347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10356, 1237, 1266);

                var
                info = f_10356_1248_1265(s_pool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10356, 1280, 1310);

                f_10356_1280_1309(f_10356_1293_1303(info) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10356, 1324, 1336);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10356, 1167, 1347);

                Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                f_10356_1248_1265(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10356, 1248, 1265);
                    return return_v;
                }


                int
                f_10356_1293_1303(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10356, 1293, 1303);
                    return return_v;
                }


                int
                f_10356_1280_1309(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10356, 1280, 1309);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10356, 1167, 1347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10356, 1167, 1347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LookupSymbolsInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10356, 391, 1354);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10356, 535, 548);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10356, 613, 696);
            s_pool = f_10356_622_696(() => new LookupSymbolsInfo(), poolSize); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10356, 391, 1354);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10356, 391, 1354);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10356, 391, 1354);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo>
        f_10356_622_696(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo>(factory, size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10356, 622, 696);
            return return_v;
        }


        static System.StringComparer
        f_10356_757_779()
        {
            var return_v = StringComparer.Ordinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10356, 757, 779);
            return return_v;
        }


        static System.Collections.Generic.IEqualityComparer<string>
        f_10356_757_779_C(System.Collections.Generic.IEqualityComparer<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10356, 709, 802);
            return return_v;
        }

    }
}
