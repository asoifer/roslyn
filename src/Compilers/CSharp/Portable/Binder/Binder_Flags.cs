// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private sealed class BinderWithContainingMemberOrLambda : Binder
        {
            private readonly Symbol _containingMemberOrLambda;

            internal BinderWithContainingMemberOrLambda(Binder next, Symbol containingMemberOrLambda)
            : base(f_10307_839_843_C(next))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10307, 725, 1012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 683, 708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 877, 924);

                    f_10307_877_923(containingMemberOrLambda != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 944, 997);

                    _containingMemberOrLambda = containingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10307, 725, 1012);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 725, 1012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 725, 1012);
                }
            }

            internal BinderWithContainingMemberOrLambda(Binder next, BinderFlags flags, Symbol containingMemberOrLambda)
            : base(f_10307_1161_1165_C(next), flags)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10307, 1028, 1341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 683, 708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 1206, 1253);

                    f_10307_1206_1252(containingMemberOrLambda != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 1273, 1326);

                    _containingMemberOrLambda = containingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10307, 1028, 1341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 1028, 1341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 1028, 1341);
                }
            }

            internal override Symbol ContainingMemberOrLambda
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10307, 1439, 1480);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 1445, 1478);

                        return _containingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10307, 1439, 1480);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 1357, 1495);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 1357, 1495);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static BinderWithContainingMemberOrLambda()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10307, 570, 1506);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10307, 570, 1506);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 570, 1506);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10307, 570, 1506);

            int
            f_10307_877_923(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 877, 923);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Binder
            f_10307_839_843_C(Microsoft.CodeAnalysis.CSharp.Binder
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10307, 725, 1012);
                return return_v;
            }


            int
            f_10307_1206_1252(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 1206, 1252);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Binder
            f_10307_1161_1165_C(Microsoft.CodeAnalysis.CSharp.Binder
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10307, 1028, 1341);
                return return_v;
            }

        }
        private sealed class BinderWithConditionalReceiver : Binder
        {
            private readonly BoundExpression _receiverExpression;

            internal BinderWithConditionalReceiver(Binder next, BoundExpression receiverExpression)
            : base(f_10307_1990_1994_C(next))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10307, 1878, 2145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 1842, 1861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 2028, 2069);

                    f_10307_2028_2068(receiverExpression != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 2089, 2130);

                    _receiverExpression = receiverExpression;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10307, 1878, 2145);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 1878, 2145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 1878, 2145);
                }
            }

            internal override BoundExpression ConditionalReceiverExpression
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10307, 2257, 2292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 2263, 2290);

                        return _receiverExpression;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10307, 2257, 2292);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 2161, 2307);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 2161, 2307);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static BinderWithConditionalReceiver()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10307, 1725, 2318);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10307, 1725, 2318);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 1725, 2318);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10307, 1725, 2318);

            int
            f_10307_2028_2068(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 2028, 2068);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Binder
            f_10307_1990_1994_C(Microsoft.CodeAnalysis.CSharp.Binder
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10307, 1878, 2145);
                return return_v;
            }

        }

        internal Binder WithFlags(BinderFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10307, 2330, 2504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 2399, 2493);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10307, 2406, 2425) || ((this.Flags == flags
                && DynAbs.Tracing.TraceSender.Conditional_F2(10307, 2445, 2449)) || DynAbs.Tracing.TraceSender.Conditional_F3(10307, 2469, 2492))) ? this
                : f_10307_2469_2492(this, flags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10307, 2330, 2504);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10307_2469_2492(Microsoft.CodeAnalysis.CSharp.Binder
                next, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder(next, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 2469, 2492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 2330, 2504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 2330, 2504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Binder WithAdditionalFlags(BinderFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10307, 2516, 2720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 2595, 2709);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10307, 2602, 2628) || ((f_10307_2602_2628(this.Flags, flags) && DynAbs.Tracing.TraceSender.Conditional_F2(10307, 2648, 2652)) || DynAbs.Tracing.TraceSender.Conditional_F3(10307, 2672, 2708))) ? this
                : f_10307_2672_2708(this, this.Flags | flags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10307, 2516, 2720);

                bool
                f_10307_2602_2628(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 2602, 2628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10307_2672_2708(Microsoft.CodeAnalysis.CSharp.Binder
                next, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder(next, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 2672, 2708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 2516, 2720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 2516, 2720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Binder WithContainingMemberOrLambda(Symbol containing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10307, 2732, 2950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 2820, 2861);

                f_10307_2820_2860((object)containing != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 2875, 2939);

                return f_10307_2882_2938(this, containing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10307, 2732, 2950);

                int
                f_10307_2820_2860(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 2820, 2860);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.BinderWithContainingMemberOrLambda
                f_10307_2882_2938(Microsoft.CodeAnalysis.CSharp.Binder
                next, Microsoft.CodeAnalysis.CSharp.Symbol
                containingMemberOrLambda)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.BinderWithContainingMemberOrLambda(next, containingMemberOrLambda);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 2882, 2938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 2732, 2950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 2732, 2950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Binder WithAdditionalFlagsAndContainingMemberOrLambda(BinderFlags flags, Symbol containing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10307, 3165, 3440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 3290, 3331);

                f_10307_3290_3330((object)containing != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 3345, 3429);

                return f_10307_3352_3428(this, this.Flags | flags, containing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10307, 3165, 3440);

                int
                f_10307_3290_3330(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 3290, 3330);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.BinderWithContainingMemberOrLambda
                f_10307_3352_3428(Microsoft.CodeAnalysis.CSharp.Binder
                next, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbol
                containingMemberOrLambda)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.BinderWithContainingMemberOrLambda(next, flags, containingMemberOrLambda);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 3352, 3428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 3165, 3440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 3165, 3440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Binder WithUnsafeRegionIfNecessary(SyntaxTokenList modifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10307, 3452, 3756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 3547, 3745);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10307, 3554, 3645) || (((f_10307_3555_3600(this.Flags, BinderFlags.UnsafeRegion) || (DynAbs.Tracing.TraceSender.Expression_False(10307, 3555, 3644) || !modifiers.Any(SyntaxKind.UnsafeKeyword)))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10307, 3665, 3669)) || DynAbs.Tracing.TraceSender.Conditional_F3(10307, 3689, 3744))) ? this
                : f_10307_3689_3744(this, this.Flags | BinderFlags.UnsafeRegion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10307, 3452, 3756);

                bool
                f_10307_3555_3600(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 3555, 3600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10307_3689_3744(Microsoft.CodeAnalysis.CSharp.Binder
                next, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder(next, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 3689, 3744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 3452, 3756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 3452, 3756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Binder WithCheckedOrUncheckedRegion(bool @checked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10307, 3768, 4304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 3852, 3944);

                f_10307_3852_3943(!f_10307_3866_3942(this.Flags, BinderFlags.UncheckedRegion | BinderFlags.CheckedRegion));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 3960, 4047);

                BinderFlags
                added = (DynAbs.Tracing.TraceSender.Conditional_F1(10307, 3980, 3988) || ((@checked && DynAbs.Tracing.TraceSender.Conditional_F2(10307, 3991, 4016)) || DynAbs.Tracing.TraceSender.Conditional_F3(10307, 4019, 4046))) ? BinderFlags.CheckedRegion : BinderFlags.UncheckedRegion
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 4061, 4150);

                BinderFlags
                removed = (DynAbs.Tracing.TraceSender.Conditional_F1(10307, 4083, 4091) || ((@checked && DynAbs.Tracing.TraceSender.Conditional_F2(10307, 4094, 4121)) || DynAbs.Tracing.TraceSender.Conditional_F3(10307, 4124, 4149))) ? BinderFlags.UncheckedRegion : BinderFlags.CheckedRegion
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10307, 4166, 4293);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10307, 4173, 4199) || ((f_10307_4173_4199(this.Flags, added) && DynAbs.Tracing.TraceSender.Conditional_F2(10307, 4219, 4223)) || DynAbs.Tracing.TraceSender.Conditional_F3(10307, 4243, 4292))) ? this
                : f_10307_4243_4292(this, (this.Flags & ~removed) | added);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10307, 3768, 4304);

                bool
                f_10307_3866_3942(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 3866, 3942);
                    return return_v;
                }


                int
                f_10307_3852_3943(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 3852, 3943);
                    return 0;
                }


                bool
                f_10307_4173_4199(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 4173, 4199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10307_4243_4292(Microsoft.CodeAnalysis.CSharp.Binder
                next, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder(next, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10307, 4243, 4292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10307, 3768, 4304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10307, 3768, 4304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
