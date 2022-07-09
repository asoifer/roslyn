// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Collections
{
    internal class KeyedStack<T, R>
            where T : notnull
    {
        private readonly Dictionary<T, Stack<R>> _dict;

        public void Push(T key, R value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(108, 626, 908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 683, 699);

                Stack<R>?
                store
                = default(Stack<R>?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 713, 863) || true) && (!f_108_718_751(_dict, key, out store))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(108, 713, 863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 785, 808);

                    store = f_108_793_807();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 826, 848);

                    f_108_826_847(_dict, key, store);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(108, 713, 863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 879, 897);

                f_108_879_896(
                            store, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(108, 626, 908);

                bool
                f_108_718_751(System.Collections.Generic.Dictionary<T, System.Collections.Generic.Stack<R>>
                this_param, T
                key, out System.Collections.Generic.Stack<R>?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(108, 718, 751);
                    return return_v;
                }


                System.Collections.Generic.Stack<R>
                f_108_793_807()
                {
                    var return_v = new System.Collections.Generic.Stack<R>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(108, 793, 807);
                    return return_v;
                }


                int
                f_108_826_847(System.Collections.Generic.Dictionary<T, System.Collections.Generic.Stack<R>>
                this_param, T
                key, System.Collections.Generic.Stack<R>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(108, 826, 847);
                    return 0;
                }


                int
                f_108_879_896(System.Collections.Generic.Stack<R>
                this_param, R?
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(108, 879, 896);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(108, 626, 908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(108, 626, 908);
            }
        }

        public bool TryPop(T key, [MaybeNullWhen(returnValue: false)] out R value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(108, 920, 1278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 1019, 1035);

                Stack<R>?
                store
                = default(Stack<R>?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 1049, 1204) || true) && (f_108_1053_1086(_dict, key, out store) && (DynAbs.Tracing.TraceSender.Expression_True(108, 1053, 1105) && f_108_1090_1101(store) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(108, 1049, 1204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 1139, 1159);

                    value = f_108_1147_1158(store);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 1177, 1189);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(108, 1049, 1204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 1220, 1240);

                value = default(R)!;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 1254, 1267);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(108, 920, 1278);

                bool
                f_108_1053_1086(System.Collections.Generic.Dictionary<T, System.Collections.Generic.Stack<R>>
                this_param, T
                key, out System.Collections.Generic.Stack<R>?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(108, 1053, 1086);
                    return return_v;
                }


                int
                f_108_1090_1101(System.Collections.Generic.Stack<R>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(108, 1090, 1101);
                    return return_v;
                }


                R
                f_108_1147_1158(System.Collections.Generic.Stack<R>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(108, 1147, 1158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(108, 920, 1278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(108, 920, 1278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public KeyedStack()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(108, 460, 1285);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(108, 576, 613);
            this._dict = f_108_584_613(); DynAbs.Tracing.TraceSender.TraceExitConstructor(108, 460, 1285);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(108, 460, 1285);
        }


        static KeyedStack()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(108, 460, 1285);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(108, 460, 1285);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(108, 460, 1285);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(108, 460, 1285);

        System.Collections.Generic.Dictionary<T, System.Collections.Generic.Stack<R>>
        f_108_584_613()
        {
            var return_v = new System.Collections.Generic.Dictionary<T, System.Collections.Generic.Stack<R>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(108, 584, 613);
            return return_v;
        }

    }
}
