// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal abstract class AbstractWarningStateMap<TWarningState>
            where TWarningState : struct
    {
        private readonly WarningStateMapEntry[] _warningStateMapEntries;

        protected AbstractWarningStateMap(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(655, 869, 1028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 833, 856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 950, 1017);

                _warningStateMapEntries = f_655_976_1016(this, syntaxTree);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(655, 869, 1028);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(655, 869, 1028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(655, 869, 1028);
            }
        }

        protected abstract WarningStateMapEntry[] CreateWarningStateMapEntries(SyntaxTree syntaxTree);

        /// <summary>
        /// Returns the reporting state for the supplied diagnostic id at the supplied position
        /// in the associated syntax tree.
        /// </summary>
        public TWarningState GetWarningState(string id, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(655, 1641, 2007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 1727, 1776);

                var
                entry = f_655_1739_1775(this, position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 1792, 1812);

                TWarningState
                state
                = default(TWarningState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 1826, 1946) || true) && (f_655_1830_1884(entry.SpecificWarningOption, id, out state))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(655, 1826, 1946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 1918, 1931);

                    return state;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(655, 1826, 1946);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 1962, 1996);

                return entry.GeneralWarningOption;
                DynAbs.Tracing.TraceSender.TraceExitMethod(655, 1641, 2007);

                Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<TWarningState>.WarningStateMapEntry
                f_655_1739_1775(Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<TWarningState>
                this_param, int
                position)
                {
                    var return_v = this_param.GetEntryAtOrBeforePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(655, 1739, 1775);
                    return return_v;
                }


                bool
                f_655_1830_1884(System.Collections.Immutable.ImmutableDictionary<string, TWarningState>
                this_param, string
                key, out TWarningState
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(655, 1830, 1884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(655, 1641, 2007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(655, 1641, 2007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private WarningStateMapEntry GetEntryAtOrBeforePosition(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(655, 2161, 2522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 2255, 2339);

                f_655_2255_2338(_warningStateMapEntries != null && (DynAbs.Tracing.TraceSender.Expression_True(655, 2268, 2337) && f_655_2303_2333(_warningStateMapEntries) > 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 2353, 2441);

                int
                r = f_655_2361_2440(_warningStateMapEntries, f_655_2405_2439(position))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 2455, 2511);

                return _warningStateMapEntries[(DynAbs.Tracing.TraceSender.Conditional_F1(655, 2486, 2492) || ((r >= 0 && DynAbs.Tracing.TraceSender.Conditional_F2(655, 2495, 2496)) || DynAbs.Tracing.TraceSender.Conditional_F3(655, 2499, 2509))) ? r : ((~r) - 1)];
                DynAbs.Tracing.TraceSender.TraceExitMethod(655, 2161, 2522);

                int
                f_655_2303_2333(Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<TWarningState>.WarningStateMapEntry[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(655, 2303, 2333);
                    return return_v;
                }


                int
                f_655_2255_2338(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(655, 2255, 2338);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<TWarningState>.WarningStateMapEntry
                f_655_2405_2439(int
                position)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<TWarningState>.WarningStateMapEntry(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(655, 2405, 2439);
                    return return_v;
                }


                int
                f_655_2361_2440(Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<TWarningState>.WarningStateMapEntry[]
                array, Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<TWarningState>.WarningStateMapEntry
                value)
                {
                    var return_v = Array.BinarySearch(array, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(655, 2361, 2440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(655, 2161, 2522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(655, 2161, 2522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected readonly struct WarningStateMapEntry : IComparable<WarningStateMapEntry>
        {

            public readonly int Position;

            public readonly TWarningState GeneralWarningOption;

            public readonly ImmutableDictionary<string, TWarningState> SpecificWarningOption;

            public WarningStateMapEntry(int position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(655, 3312, 3579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 3386, 3411);

                    this.Position = position;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 3429, 3465);

                    this.GeneralWarningOption = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 3483, 3564);

                    this.SpecificWarningOption = f_655_3512_3563<TWarningState>();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(655, 3312, 3579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(655, 3312, 3579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(655, 3312, 3579);
                }
            }

            public WarningStateMapEntry(int position, TWarningState general, ImmutableDictionary<string, TWarningState> specific)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(655, 3595, 3950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 3745, 3770);

                    this.Position = position;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 3788, 3824);

                    this.GeneralWarningOption = general;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 3842, 3935);

                    this.SpecificWarningOption = specific ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableDictionary<string, TWarningState>>(655, 3871, 3934) ?? f_655_3883_3934<TWarningState>());
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(655, 3595, 3950);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(655, 3595, 3950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(655, 3595, 3950);
                }
            }

            public int CompareTo(WarningStateMapEntry other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(655, 3966, 4100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(655, 4047, 4085);

                    return this.Position - other.Position;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(655, 3966, 4100);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(655, 3966, 4100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(655, 3966, 4100);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static WarningStateMapEntry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(655, 2701, 4111);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(655, 2701, 4111);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(655, 2701, 4111);
            }

            static System.Collections.Immutable.ImmutableDictionary<string, TWarningState>
            f_655_3512_3563<TWarningState>()
            {
                var return_v = ImmutableDictionary.Create<string, TWarningState>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(655, 3512, 3563);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableDictionary<string, TWarningState>
            f_655_3883_3934<TWarningState>()
            {
                var return_v = ImmutableDictionary.Create<string, TWarningState>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(655, 3883, 3934);
                return return_v;
            }

        }

        static AbstractWarningStateMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(655, 377, 4118);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(655, 377, 4118);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(655, 377, 4118);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(655, 377, 4118);

        static Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<TWarningState>.WarningStateMapEntry[]
        f_655_976_1016<TWarningState>(Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<TWarningState>
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree) where TWarningState : struct

        {
            var return_v = this_param.CreateWarningStateMapEntries(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(655, 976, 1016);
            return return_v;
        }

    }
}
