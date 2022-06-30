// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public abstract partial class SyntaxNode
    {
        private readonly SyntaxNode? _parent;

        internal SyntaxTree? _syntaxTree;

        internal SyntaxNode(GreenNode green, SyntaxNode? parent, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(687, 1149, 1545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 1086, 1093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 1125, 1136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 2471, 2504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 2516, 2546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 1244, 1309);

                f_687_1244_1308(position >= 0, "position cannot be negative");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 1346, 1439);

                f_687_1346_1438(parent == null || (DynAbs.Tracing.TraceSender.Expression_False(687, 1365, 1410) || f_687_1383_1402(f_687_1383_1395(parent)) != true), "list cannot be a parent");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 1455, 1475);

                Position = position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 1489, 1503);

                Green = green;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 1517, 1534);

                _parent = parent;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(687, 1149, 1545);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 1149, 1545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 1149, 1545);
            }
        }

        internal SyntaxNode(GreenNode green, int position, SyntaxTree syntaxTree)
        : this(f_687_1842_1847_C(green), null, position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(687, 1748, 1930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 1889, 1919);

                this._syntaxTree = syntaxTree;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(687, 1748, 1930);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 1748, 1930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 1748, 1930);
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 1942, 2071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 2002, 2060);

                return f_687_2009_2023(f_687_2009_2018(this)) + " " + f_687_2032_2040() + " " + f_687_2049_2059(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 1942, 2071);

                System.Type
                f_687_2009_2018(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 2009, 2018);
                    return return_v;
                }


                string
                f_687_2009_2023(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2009, 2023);
                    return return_v;
                }


                string
                f_687_2032_2040()
                {
                    var return_v = KindText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2032, 2040);
                    return return_v;
                }


                string
                f_687_2049_2059(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 2049, 2059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 1942, 2071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 1942, 2071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int RawKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 2227, 2243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 2230, 2243);
                    return f_687_2230_2243(f_687_2230_2235()); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 2227, 2243);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 2227, 2243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 2227, 2243);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected string KindText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 2282, 2299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 2285, 2299);
                    return f_687_2285_2299(f_687_2285_2290()); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 2282, 2299);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 2282, 2299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 2282, 2299);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract string Language { get; }

        internal GreenNode Green { get; }

        internal int Position { get; }

        internal int EndPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 2583, 2612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 2586, 2612);
                    return f_687_2586_2594() + f_687_2597_2612(f_687_2597_2602()); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 2583, 2612);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 2583, 2612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 2583, 2612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 2813, 2835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 2816, 2835);
                    return f_687_2816_2835(this); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 2813, 2835);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 2813, 2835);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 2813, 2835);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 2869, 2889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 2872, 2889);
                    return f_687_2872_2889(f_687_2872_2882(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 2869, 2889);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 2869, 2889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 2869, 2889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TextSpan FullSpan
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 3076, 3128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3079, 3128);
                    return f_687_3079_3128(f_687_3092_3105(this), f_687_3107_3127(f_687_3107_3117(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 3076, 3128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 3076, 3128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 3076, 3128);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int SlotCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 3164, 3187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3167, 3187);
                    return f_687_3167_3187(f_687_3167_3177(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 3164, 3187);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 3164, 3187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 3164, 3187);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TextSpan Span
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 3398, 4043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3480, 3501);

                    var
                    start = f_687_3492_3500()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3519, 3552);

                    var
                    width = f_687_3531_3551(f_687_3531_3541(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3672, 3728);

                    var
                    precedingWidth = f_687_3693_3727(f_687_3693_3703(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3746, 3770);

                    start += precedingWidth;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3788, 3812);

                    width -= precedingWidth;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3886, 3931);

                    width -= f_687_3895_3930(f_687_3895_3905(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3951, 3976);

                    f_687_3951_3975(width >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 3994, 4028);

                    return f_687_4001_4027(start, width);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 3398, 4043);

                    int
                    f_687_3492_3500()
                    {
                        var return_v = Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3492, 3500);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode
                    f_687_3531_3541(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3531, 3541);
                        return return_v;
                    }


                    int
                    f_687_3531_3551(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3531, 3551);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode
                    f_687_3693_3703(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3693, 3703);
                        return return_v;
                    }


                    int
                    f_687_3693_3727(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 3693, 3727);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode
                    f_687_3895_3905(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3895, 3905);
                        return return_v;
                    }


                    int
                    f_687_3895_3930(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 3895, 3930);
                        return return_v;
                    }


                    int
                    f_687_3951_3975(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 3951, 3975);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_687_4001_4027(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 4001, 4027);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 3353, 4054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 3353, 4054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int SpanStart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 4309, 4352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 4312, 4352);
                    return f_687_4312_4320() + f_687_4323_4352(f_687_4323_4328()); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 4309, 4352);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 4309, 4352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 4309, 4352);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int Width
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 4674, 4693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 4677, 4693);
                    return f_687_4677_4693(f_687_4677_4687(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 4674, 4693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 4674, 4693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 4674, 4693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int FullWidth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 5017, 5040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5020, 5040);
                    return f_687_5020_5040(f_687_5020_5030(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(687, 5017, 5040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 5017, 5040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 5017, 5040);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxNode? GetRed(ref SyntaxNode? field, int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 5144, 5639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5229, 5248);

                var
                result = field
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5264, 5598) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 5264, 5598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5316, 5353);

                    var
                    green = f_687_5328_5352(f_687_5328_5338(this), slot)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5371, 5583) || true) && (green != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 5371, 5583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5430, 5527);

                        f_687_5430_5526(ref field, f_687_5469_5519(green, this, f_687_5491_5518(this, slot)), null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5549, 5564);

                        result = field;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 5371, 5583);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 5264, 5598);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5614, 5628);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 5144, 5639);

                Microsoft.CodeAnalysis.GreenNode
                f_687_5328_5338(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 5328, 5338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_687_5328_5352(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 5328, 5352);
                    return return_v;
                }


                int
                f_687_5491_5518(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetChildPosition(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 5491, 5518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_5469_5519(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 5469, 5519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_5430_5526(ref Microsoft.CodeAnalysis.SyntaxNode?
                location1, Microsoft.CodeAnalysis.SyntaxNode
                value, Microsoft.CodeAnalysis.SyntaxNode?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 5430, 5526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 5144, 5639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 5144, 5639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxNode? GetRedAtZero(ref SyntaxNode? field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 5742, 6216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5823, 5842);

                var
                result = field
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5858, 6175) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 5858, 6175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5910, 5944);

                    var
                    green = f_687_5922_5943(f_687_5922_5932(this), 0)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 5962, 6160) || true) && (green != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 5962, 6160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6021, 6104);

                        f_687_6021_6103(ref field, f_687_6060_6096(green, this, f_687_6082_6095(this)), null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6126, 6141);

                        result = field;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 5962, 6160);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 5858, 6175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6191, 6205);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 5742, 6216);

                Microsoft.CodeAnalysis.GreenNode
                f_687_5922_5932(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 5922, 5932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_687_5922_5943(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 5922, 5943);
                    return return_v;
                }


                int
                f_687_6082_6095(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 6082, 6095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_6060_6096(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 6060, 6096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_6021_6103(ref Microsoft.CodeAnalysis.SyntaxNode?
                location1, Microsoft.CodeAnalysis.SyntaxNode
                value, Microsoft.CodeAnalysis.SyntaxNode?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 6021, 6103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 5742, 6216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 5742, 6216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected T? GetRed<T>(ref T? field, int slot) where T : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 6228, 6733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6320, 6339);

                var
                result = field
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6355, 6692) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 6355, 6692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6407, 6444);

                    var
                    green = f_687_6419_6443(f_687_6419_6429(this), slot)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6462, 6677) || true) && (green != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 6462, 6677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6521, 6621);

                        f_687_6521_6620(ref field, f_687_6563_6613(green, this, f_687_6585_6612(this, slot)), null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6643, 6658);

                        result = field;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 6462, 6677);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 6355, 6692);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6708, 6722);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 6228, 6733);

                Microsoft.CodeAnalysis.GreenNode
                f_687_6419_6429(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 6419, 6429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_687_6419_6443(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 6419, 6443);
                    return return_v;
                }


                int
                f_687_6585_6612(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetChildPosition(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 6585, 6612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_6563_6613(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 6563, 6613);
                    return return_v;
                }


                T?
                f_687_6521_6620(ref T?
                location1, Microsoft.CodeAnalysis.SyntaxNode
                value, T?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (T)value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 6521, 6620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 6228, 6733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 6228, 6733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected T? GetRedAtZero<T>(ref T? field) where T : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 6836, 7320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6924, 6943);

                var
                result = field
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 6959, 7279) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 6959, 7279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7011, 7045);

                    var
                    green = f_687_7023_7044(f_687_7023_7033(this), 0)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7063, 7264) || true) && (green != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 7063, 7264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7122, 7208);

                        f_687_7122_7207(ref field, f_687_7164_7200(green, this, f_687_7186_7199(this)), null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7230, 7245);

                        result = field;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 7063, 7264);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 6959, 7279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7295, 7309);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 6836, 7320);

                Microsoft.CodeAnalysis.GreenNode
                f_687_7023_7033(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 7023, 7033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_687_7023_7044(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 7023, 7044);
                    return return_v;
                }


                int
                f_687_7186_7199(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 7186, 7199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_7164_7200(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 7164, 7200);
                    return return_v;
                }


                T?
                f_687_7122_7207(ref T?
                location1, Microsoft.CodeAnalysis.SyntaxNode
                value, T?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (T)value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 7122, 7207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 6836, 7320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 6836, 7320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxNode? GetRedElement(ref SyntaxNode? element, int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 7607, 8134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7701, 7727);

                f_687_7701_7726(f_687_7714_7725(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7743, 7764);

                var
                result = element
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7780, 8093) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 7780, 8093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7832, 7877);

                    var
                    green = f_687_7844_7876(f_687_7844_7854(this), slot)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 7937, 8043);

                    f_687_7937_8042(ref element, f_687_7978_8035(green, f_687_7994_8005(this), f_687_8007_8034(this, slot)), null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8061, 8078);

                    result = element;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 7780, 8093);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8109, 8123);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 7607, 8134);

                bool
                f_687_7714_7725(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 7714, 7725);
                    return return_v;
                }


                int
                f_687_7701_7726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 7701, 7726);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_7844_7854(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 7844, 7854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_7844_7876(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetRequiredSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 7844, 7876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_7994_8005(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 7994, 8005);
                    return return_v;
                }


                int
                f_687_8007_8034(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetChildPosition(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 8007, 8034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_7978_8035(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 7978, 8035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_7937_8042(ref Microsoft.CodeAnalysis.SyntaxNode?
                location1, Microsoft.CodeAnalysis.SyntaxNode
                value, Microsoft.CodeAnalysis.SyntaxNode?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 7937, 8042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 7607, 8134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 7607, 8134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxNode? GetRedElementIfNotToken(ref SyntaxNode? element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 8288, 8896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8382, 8408);

                f_687_8382_8407(f_687_8395_8406(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8424, 8445);

                var
                result = element
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8461, 8855) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 8461, 8855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8513, 8555);

                    var
                    green = f_687_8525_8554(f_687_8525_8535(this), 1)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8573, 8840) || true) && (f_687_8577_8591_M(!green.IsToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 8573, 8840);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8679, 8782);

                        f_687_8679_8781(ref element, f_687_8720_8774(green, f_687_8736_8747(this), f_687_8749_8773(this, 1)), null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8804, 8821);

                        result = element;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 8573, 8840);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 8461, 8855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 8871, 8885);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 8288, 8896);

                bool
                f_687_8395_8406(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 8395, 8406);
                    return return_v;
                }


                int
                f_687_8382_8407(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 8382, 8407);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_8525_8535(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 8525, 8535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_8525_8554(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetRequiredSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 8525, 8554);
                    return return_v;
                }


                bool
                f_687_8577_8591_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 8577, 8591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_8736_8747(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 8736, 8747);
                    return return_v;
                }


                int
                f_687_8749_8773(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetChildPosition(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 8749, 8773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_8720_8774(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 8720, 8774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_8679_8781(ref Microsoft.CodeAnalysis.SyntaxNode?
                location1, Microsoft.CodeAnalysis.SyntaxNode
                value, Microsoft.CodeAnalysis.SyntaxNode?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 8679, 8781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 8288, 8896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 8288, 8896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxNode GetWeakRedElement(ref WeakReference<SyntaxNode>? slot, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 8908, 9227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9018, 9043);

                SyntaxNode?
                value = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9057, 9161) || true) && (f_687_9061_9090_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(slot, 687, 9061, 9090)?.TryGetTarget(out value)) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 9057, 9161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9132, 9146);

                    return value!;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 9057, 9161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9177, 9216);

                return f_687_9184_9215(this, ref slot, index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 8908, 9227);

                bool?
                f_687_9061_9090_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 9061, 9090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_9184_9215(Microsoft.CodeAnalysis.SyntaxNode
                this_param, ref System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>?
                slot, int
                index)
                {
                    var return_v = this_param.CreateWeakItem(ref slot, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 9184, 9215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 8908, 9227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 8908, 9227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxNode CreateWeakItem(ref WeakReference<SyntaxNode>? slot, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 9265, 10146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9371, 9422);

                var
                greenChild = f_687_9388_9421(f_687_9388_9398(this), index)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9436, 9509);

                var
                newNode = f_687_9450_9508(greenChild, f_687_9471_9482(this), f_687_9484_9507(this, index))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9523, 9585);

                var
                newWeakReference = f_687_9546_9584(newNode)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9601, 10135) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 9601, 10135);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9646, 9678);

                        SyntaxNode?
                        previousNode = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9696, 9752);

                        WeakReference<SyntaxNode>?
                        previousWeakReference = slot
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9770, 9917) || true) && (f_687_9774_9827_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(previousWeakReference, 687, 9774, 9827)?.TryGetTarget(out previousNode)) == true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 9770, 9917);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9877, 9898);

                            return previousNode!;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 9770, 9917);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 9937, 10120) || true) && (f_687_9941_10019(ref slot, newWeakReference, previousWeakReference) == previousWeakReference)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 9937, 10120);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 10086, 10101);

                            return newNode;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 9937, 10120);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 9601, 10135);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 9601, 10135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 9601, 10135);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 9265, 10146);

                Microsoft.CodeAnalysis.GreenNode
                f_687_9388_9398(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 9388, 9398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_9388_9421(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetRequiredSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 9388, 9421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_9471_9482(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 9471, 9482);
                    return return_v;
                }


                int
                f_687_9484_9507(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetChildPosition(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 9484, 9507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_9450_9508(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 9450, 9508);
                    return return_v;
                }


                System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>
                f_687_9546_9584(Microsoft.CodeAnalysis.SyntaxNode
                target)
                {
                    var return_v = new System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 9546, 9584);
                    return return_v;
                }


                bool?
                f_687_9774_9827_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 9774, 9827);
                    return return_v;
                }


                System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>?
                f_687_9941_10019(ref System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>?
                location1, System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>
                value, System.WeakReference<Microsoft.CodeAnalysis.SyntaxNode>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 9941, 10019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 9265, 10146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 9265, 10146);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 10532, 10630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 10590, 10619);

                return f_687_10597_10618(f_687_10597_10607(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 10532, 10630);

                Microsoft.CodeAnalysis.GreenNode
                f_687_10597_10607(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 10597, 10607);
                    return return_v;
                }


                string
                f_687_10597_10618(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 10597, 10618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 10532, 10630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 10532, 10630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 11016, 11121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 11077, 11110);

                return f_687_11084_11109(f_687_11084_11094(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 11016, 11121);

                Microsoft.CodeAnalysis.GreenNode
                f_687_11084_11094(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 11084, 11094);
                    return return_v;
                }


                string
                f_687_11084_11109(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 11084, 11109);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 11016, 11121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 11016, 11121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual void WriteTo(TextWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 11270, 11410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 11341, 11399);

                f_687_11341_11398(f_687_11341_11351(this), writer, leading: true, trailing: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 11270, 11410);

                Microsoft.CodeAnalysis.GreenNode
                f_687_11341_11351(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 11341, 11351);
                    return return_v;
                }


                int
                f_687_11341_11398(Microsoft.CodeAnalysis.GreenNode
                this_param, System.IO.TextWriter
                writer, bool
                leading, bool
                trailing)
                {
                    this_param.WriteTo(writer, leading: leading, trailing: trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 11341, 11398);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 11270, 11410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 11270, 11410);
            }
        }

        public SourceText GetText(Encoding? encoding = null, SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 12268, 12591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 12411, 12445);

                var
                builder = f_687_12425_12444()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 12459, 12499);

                f_687_12459_12498(this, f_687_12472_12497(builder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 12513, 12580);

                return f_687_12520_12579(builder, encoding, checksumAlgorithm);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 12268, 12591);

                System.Text.StringBuilder
                f_687_12425_12444()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 12425, 12444);
                    return return_v;
                }


                System.IO.StringWriter
                f_687_12472_12497(System.Text.StringBuilder
                sb)
                {
                    var return_v = new System.IO.StringWriter(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 12472, 12497);
                    return return_v;
                }


                int
                f_687_12459_12498(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.IO.StringWriter
                writer)
                {
                    this_param.WriteTo((System.IO.TextWriter)writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 12459, 12498);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.StringBuilderText
                f_687_12520_12579(System.Text.StringBuilder
                builder, System.Text.Encoding?
                encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.StringBuilderText(builder, encodingOpt, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 12520, 12579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 12268, 12591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 12268, 12591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsEquivalentTo(SyntaxNode other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 12730, 13045);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 12799, 12877) || true) && (this == other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 12799, 12877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 12850, 12862);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 12799, 12877);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 12893, 12972) || true) && (other == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 12893, 12972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 12944, 12957);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 12893, 12972);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 12988, 13034);

                return f_687_12995_13033(f_687_12995_13005(this), f_687_13021_13032(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 12730, 13045);

                Microsoft.CodeAnalysis.GreenNode
                f_687_12995_13005(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 12995, 13005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_13021_13032(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 13021, 13032);
                    return return_v;
                }


                bool
                f_687_12995_13033(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.GreenNode
                other)
                {
                    var return_v = this_param.IsEquivalentTo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 12995, 13033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 12730, 13045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 12730, 13045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsMissing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 13503, 13582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 13539, 13567);

                    return f_687_13546_13566(f_687_13546_13556(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 13503, 13582);

                    Microsoft.CodeAnalysis.GreenNode
                    f_687_13546_13556(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 13546, 13556);
                        return return_v;
                    }


                    bool
                    f_687_13546_13566(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsMissing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 13546, 13566);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 13457, 13593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 13457, 13593);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPartOfStructuredTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 13734, 14010);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 13814, 13825);
                    for (SyntaxNode?
        node = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 13797, 13970) || true) && (node != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 13841, 13859)
        , node = f_687_13848_13859(node), DynAbs.Tracing.TraceSender.TraceExitCondition(687, 13797, 13970))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 13797, 13970);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 13893, 13955) || true) && (f_687_13897_13920(node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 13893, 13955);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 13943, 13955);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 13893, 13955);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 1, 174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 1, 174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 13986, 13999);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 13734, 14010);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_13848_13859(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 13848, 13859);
                    return return_v;
                }


                bool
                f_687_13897_13920(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.IsStructuredTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 13897, 13920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 13734, 14010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 13734, 14010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsStructuredTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 14198, 14286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 14234, 14271);

                    return f_687_14241_14270(f_687_14241_14251(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 14198, 14286);

                    Microsoft.CodeAnalysis.GreenNode
                    f_687_14241_14251(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 14241, 14251);
                        return return_v;
                    }


                    bool
                    f_687_14241_14270(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsStructuredTrivia;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 14241, 14270);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 14143, 14297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 14143, 14297);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasStructuredTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 14492, 14620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 14528, 14605);

                    return f_687_14535_14570(f_687_14535_14545(this)) && (DynAbs.Tracing.TraceSender.Expression_True(687, 14535, 14604) && f_687_14574_14604_M(!f_687_14575_14585(this).IsStructuredTrivia));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 14492, 14620);

                    Microsoft.CodeAnalysis.GreenNode
                    f_687_14535_14545(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 14535, 14545);
                        return return_v;
                    }


                    bool
                    f_687_14535_14570(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.ContainsStructuredTrivia;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 14535, 14570);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode
                    f_687_14575_14585(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 14575, 14585);
                        return return_v;
                    }


                    bool
                    f_687_14574_14604_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 14574, 14604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 14436, 14631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 14436, 14631);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsSkippedText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 14821, 14910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 14857, 14895);

                    return f_687_14864_14894(f_687_14864_14874(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 14821, 14910);

                    Microsoft.CodeAnalysis.GreenNode
                    f_687_14864_14874(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 14864, 14874);
                        return return_v;
                    }


                    bool
                    f_687_14864_14894(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.ContainsSkippedText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 14864, 14894);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 14765, 14921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 14765, 14921);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsDirectives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 15121, 15209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 15157, 15194);

                    return f_687_15164_15193(f_687_15164_15174(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 15121, 15209);

                    Microsoft.CodeAnalysis.GreenNode
                    f_687_15164_15174(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 15164, 15174);
                        return return_v;
                    }


                    bool
                    f_687_15164_15193(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.ContainsDirectives;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 15164, 15193);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 15066, 15220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 15066, 15220);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 15457, 15546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 15493, 15531);

                    return f_687_15500_15530(f_687_15500_15510(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 15457, 15546);

                    Microsoft.CodeAnalysis.GreenNode
                    f_687_15500_15510(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 15500, 15510);
                        return return_v;
                    }


                    bool
                    f_687_15500_15530(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.ContainsDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 15500, 15530);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 15401, 15557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 15401, 15557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Contains(SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 15736, 16525);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 15799, 15919) || true) && (node == null || (DynAbs.Tracing.TraceSender.Expression_False(687, 15803, 15857) || !this.FullSpan.Contains(f_687_15843_15856(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 15799, 15919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 15891, 15904);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 15799, 15919);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 15935, 16485) || true) && (node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 15935, 16485);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 15988, 16077) || true) && (node == this)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 15988, 16077);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 16046, 16058);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 15988, 16077);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 16097, 16470) || true) && (f_687_16101_16112(node) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 16097, 16470);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 16162, 16181);

                            node = f_687_16169_16180(node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 16097, 16470);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 16097, 16470);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 16223, 16470) || true) && (f_687_16227_16250(node))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 16223, 16470);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 16292, 16357);

                                node = ((IStructuredTriviaSyntax)node).ParentTrivia.Token.Parent;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(687, 16223, 16470);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 16223, 16470);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 16439, 16451);

                                node = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(687, 16223, 16470);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 16097, 16470);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 15935, 16485);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 15935, 16485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 15935, 16485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 16501, 16514);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 15736, 16525);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_687_15843_15856(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 15843, 15856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_16101_16112(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 16101, 16112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_16169_16180(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 16169, 16180);
                    return return_v;
                }


                bool
                f_687_16227_16250(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.IsStructuredTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 16227, 16250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 15736, 16525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 15736, 16525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasLeadingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 16703, 16795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 16739, 16780);

                    return f_687_16746_16769(this).Count > 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 16703, 16795);

                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_687_16746_16769(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 16746, 16769);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 16650, 16806);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 16650, 16806);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasTrailingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 16986, 17079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17022, 17064);

                    return f_687_17029_17053(this).Count > 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 16986, 17079);

                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_687_17029_17053(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 17029, 17053);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 16932, 17090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 16932, 17090);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract SyntaxNode? GetCachedSlot(int index);

        internal int GetChildIndex(int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 17350, 17903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17411, 17425);

                int
                index = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17448, 17453);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17439, 17863) || true) && (i < slot)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17465, 17468)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(687, 17439, 17863))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 17439, 17863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17502, 17535);

                        var
                        item = f_687_17513_17534(f_687_17513_17523(this), i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17553, 17848) || true) && (item != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 17553, 17848);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17611, 17829) || true) && (f_687_17615_17626(item))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 17611, 17829);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17676, 17700);

                                index += f_687_17685_17699(item);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(687, 17611, 17829);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 17611, 17829);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17798, 17806);

                                index++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(687, 17611, 17829);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 17553, 17848);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 1, 425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 1, 425);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 17879, 17892);

                return index;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 17350, 17903);

                Microsoft.CodeAnalysis.GreenNode
                f_687_17513_17523(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 17513, 17523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_687_17513_17534(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 17513, 17534);
                    return return_v;
                }


                bool
                f_687_17615_17626(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 17615, 17626);
                    return return_v;
                }


                int
                f_687_17685_17699(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 17685, 17699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 17350, 17903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 17350, 17903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int GetChildPosition(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 18500, 19161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 18573, 18588);

                int
                offset = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 18602, 18625);

                var
                green = f_687_18614_18624(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 18639, 19104) || true) && (index > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 18639, 19104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 18689, 18697);

                        index--;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 18715, 18759);

                        var
                        prevSibling = f_687_18733_18758(this, index)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 18777, 18901) || true) && (prevSibling != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 18777, 18901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 18842, 18882);

                            return f_687_18849_18872(prevSibling) + offset;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 18777, 18901);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 18919, 18957);

                        var
                        greenChild = f_687_18936_18956(green, index)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 18975, 19089) || true) && (greenChild != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 18975, 19089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 19039, 19070);

                            offset += f_687_19049_19069(greenChild);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 18975, 19089);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 18639, 19104);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 18639, 19104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 18639, 19104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 19120, 19150);

                return f_687_19127_19140(this) + offset;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 18500, 19161);

                Microsoft.CodeAnalysis.GreenNode
                f_687_18614_18624(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 18614, 18624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_18733_18758(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetCachedSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 18733, 18758);
                    return return_v;
                }


                int
                f_687_18849_18872(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.EndPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 18849, 18872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_687_18936_18956(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 18936, 18956);
                    return return_v;
                }


                int
                f_687_19049_19069(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 19049, 19069);
                    return return_v;
                }


                int
                f_687_19127_19140(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 19127, 19140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 18500, 19161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 18500, 19161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Location GetLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 19173, 19284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 19227, 19273);

                return f_687_19234_19272(f_687_19234_19249(this), f_687_19262_19271(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 19173, 19284);

                Microsoft.CodeAnalysis.SyntaxTree
                f_687_19234_19249(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 19234, 19249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_687_19262_19271(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 19262, 19271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_687_19234_19272(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetLocation(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 19234, 19272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 19173, 19284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 19173, 19284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Location Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 19347, 20473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 20281, 20308);

                    var
                    tree = f_687_20292_20307(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 20326, 20359);

                    f_687_20326_20358(tree != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 20377, 20458);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(687, 20384, 20407) || ((f_687_20384_20407_M(!tree.SupportsLocations) && DynAbs.Tracing.TraceSender.Conditional_F2(687, 20410, 20430)) || DynAbs.Tracing.TraceSender.Conditional_F3(687, 20433, 20457))) ? NoLocation.Singleton : f_687_20433_20457(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 19347, 20473);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_687_20292_20307(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 20292, 20307);
                        return return_v;
                    }


                    int
                    f_687_20326_20358(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 20326, 20358);
                        return 0;
                    }


                    bool
                    f_687_20384_20407_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 20384, 20407);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceLocation
                    f_687_20433_20457(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 20433, 20457);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 19296, 20484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 19296, 20484);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<Diagnostic> GetDiagnostics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 20774, 20901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 20846, 20890);

                return f_687_20853_20889(f_687_20853_20868(this), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 20774, 20901);

                Microsoft.CodeAnalysis.SyntaxTree
                f_687_20853_20868(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 20853, 20868);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_687_20853_20889(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetDiagnostics(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 20853, 20889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 20774, 20901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 20774, 20901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxReference GetReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 21186, 21301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 21248, 21290);

                return f_687_21255_21289(f_687_21255_21270(this), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 21186, 21301);

                Microsoft.CodeAnalysis.SyntaxTree
                f_687_21255_21270(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 21255, 21270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_687_21255_21289(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetReference(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 21255, 21289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 21186, 21301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 21186, 21301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNode? Parent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 21531, 21597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 21567, 21582);

                    return _parent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 21531, 21597);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 21481, 21608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 21481, 21608);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual SyntaxTrivia ParentTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 21685, 21765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 21721, 21750);

                    return default(SyntaxTrivia);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 21685, 21765);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 21620, 21776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 21620, 21776);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxNode? ParentOrStructuredTriviaParent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 21864, 21963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 21900, 21948);

                    return f_687_21907_21947(this, ascendOutOfTrivia: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 21864, 21963);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_687_21907_21947(Microsoft.CodeAnalysis.SyntaxNode
                    node, bool
                    ascendOutOfTrivia)
                    {
                        var return_v = GetParent(node, ascendOutOfTrivia: ascendOutOfTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 21907, 21947);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 21788, 21974);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 21788, 21974);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ChildSyntaxList ChildNodesAndTokens()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 22147, 22260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 22216, 22249);

                return f_687_22223_22248(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 22147, 22260);

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_687_22223_22248(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 22223, 22248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 22147, 22260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 22147, 22260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxNodeOrToken ChildThatContainsPosition(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 22272, 22894);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 22439, 22576) || true) && (!f_687_22444_22452().Contains(position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 22439, 22576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 22505, 22561);

                    throw f_687_22511_22560(nameof(position));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 22439, 22576);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 22592, 22687);

                SyntaxNodeOrToken
                childNodeOrToken = ChildSyntaxList.ChildThatContainsPosition(this, position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 22701, 22845);

                f_687_22701_22844(childNodeOrToken.FullSpan.Contains(position), "ChildThatContainsPosition's return value does not contain the requested position.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 22859, 22883);

                return childNodeOrToken;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 22272, 22894);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_687_22444_22452()
                {
                    var return_v = FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 22444, 22452);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_687_22511_22560(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 22511, 22560);
                    return return_v;
                }


                int
                f_687_22701_22844(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 22701, 22844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 22272, 22894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 22272, 22894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract SyntaxNode? GetNodeSlot(int slot);

        internal SyntaxNode GetRequiredNodeSlot(int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 23199, 23406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 23273, 23308);

                var
                syntaxNode = f_687_23290_23307(this, slot)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 23322, 23363);

                f_687_23322_23362(syntaxNode is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 23377, 23395);

                return syntaxNode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 23199, 23406);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_23290_23307(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNodeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 23290, 23307);
                    return return_v;
                }


                int
                f_687_23322_23362(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 23322, 23362);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 23199, 23406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 23199, 23406);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNode> ChildNodes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 23535, 23832);
                Microsoft.CodeAnalysis.SyntaxNode? node = default(Microsoft.CodeAnalysis.SyntaxNode?);

                var listYield = new List<SyntaxNode>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 23603, 23821);
                    foreach (var nodeOrToken in f_687_23631_23657_I(f_687_23631_23657(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 23603, 23821);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 23691, 23806) || true) && (nodeOrToken.AsNode(out node
                        ))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 23691, 23806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 23769, 23787);

                            listYield.Add(node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 23691, 23806);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 23603, 23821);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 1, 219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 1, 219);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 23535, 23832);

                return listYield;

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_687_23631_23657(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 23631, 23657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_687_23631_23657_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 23631, 23657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 23535, 23832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 23535, 23832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNode> Ancestors(bool ascendOutOfTrivia = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 23934, 24188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24030, 24177);

                return f_687_24037_24103_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_687_24037_24048(this), 687, 24037, 24103).AncestorsAndSelf(ascendOutOfTrivia)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>?>(687, 24037, 24176) ?? f_687_24124_24176());
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 23934, 24188);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_24037_24048(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 24037, 24048);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>?
                f_687_24037_24103_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 24037, 24103);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_687_24124_24176()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 24124, 24176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 23934, 24188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 23934, 24188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNode> AncestorsAndSelf(bool ascendOutOfTrivia = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 24313, 24579);

                var listYield = new List<SyntaxNode>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24433, 24444);
                    for (SyntaxNode?
        node = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24416, 24568) || true) && (node != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24460, 24501)
        , node = f_687_24467_24501(node, ascendOutOfTrivia), DynAbs.Tracing.TraceSender.TraceExitCondition(687, 24416, 24568))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 24416, 24568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24535, 24553);

                        listYield.Add(node);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 1, 153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 1, 153);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 24313, 24579);

                return listYield;

                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_24467_24501(Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                ascendOutOfTrivia)
                {
                    var return_v = GetParent(node, ascendOutOfTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 24467, 24501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 24313, 24579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 24313, 24579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxNode? GetParent(SyntaxNode node, bool ascendOutOfTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(687, 24591, 25075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24693, 24718);

                var
                parent = f_687_24706_24717(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24732, 25034) || true) && (parent == null && (DynAbs.Tracing.TraceSender.Expression_True(687, 24736, 24771) && ascendOutOfTrivia))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 24732, 25034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24805, 24860);

                    var
                    structuredTrivia = node as IStructuredTriviaSyntax
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24878, 25019) || true) && (structuredTrivia != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 24878, 25019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 24948, 25000);

                        parent = structuredTrivia.ParentTrivia.Token.Parent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 24878, 25019);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 24732, 25034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 25050, 25064);

                return parent;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(687, 24591, 25075);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_24706_24717(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 24706, 24717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 24591, 25075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 24591, 25075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TNode? FirstAncestorOrSelf<TNode>(Func<TNode, bool>? predicate = null, bool ascendOutOfTrivia = true)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 25209, 25731);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 25397, 25408);
                    for (SyntaxNode?
        node = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 25380, 25692) || true) && (node != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 25424, 25465)
        , node = f_687_25431_25465(node, ascendOutOfTrivia), DynAbs.Tracing.TraceSender.TraceExitCondition(687, 25380, 25692))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 25380, 25692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 25499, 25525);

                        var
                        tnode = node as TNode
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 25543, 25677) || true) && (tnode != null && (DynAbs.Tracing.TraceSender.Expression_True(687, 25547, 25603) && (predicate == null || (DynAbs.Tracing.TraceSender.Expression_False(687, 25565, 25602) || f_687_25586_25602(predicate, tnode)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 25543, 25677);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 25645, 25658);

                            return tnode;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 25543, 25677);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 1, 313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 1, 313);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 25708, 25720);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 25209, 25731);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_25431_25465(Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                ascendOutOfTrivia)
                {
                    var return_v = GetParent(node, ascendOutOfTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 25431, 25465);
                    return return_v;
                }


                bool
                f_687_25586_25602(System.Func<TNode, bool>
                this_param, TNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 25586, 25602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 25209, 25731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 25209, 25731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("ApiDesign", "RS0026:Do not add multiple public overloads with optional parameters", Justification = "Required for consistent API usage patterns.")]
        public TNode? FirstAncestorOrSelf<TNode, TArg>(Func<TNode, TArg, bool> predicate, TArg argument, bool ascendOutOfTrivia = true)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 25865, 26522);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 26239, 26250);
                    for (var
        node = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 26230, 26483) || true) && (node != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 26266, 26307)
        , node = f_687_26273_26307(node, ascendOutOfTrivia), DynAbs.Tracing.TraceSender.TraceExitCondition(687, 26230, 26483))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 26230, 26483);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 26341, 26468) || true) && (node is TNode tnode && (DynAbs.Tracing.TraceSender.Expression_True(687, 26345, 26394) && f_687_26368_26394(predicate, tnode, argument)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 26341, 26468);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 26436, 26449);

                            return tnode;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 26341, 26468);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 1, 254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 1, 254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 26499, 26511);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 25865, 26522);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_26273_26307(Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                ascendOutOfTrivia)
                {
                    var return_v = GetParent(node, ascendOutOfTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 26273, 26307);
                    return return_v;
                }


                bool
                f_687_26368_26394(System.Func<TNode, TArg, bool>
                this_param, TNode
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 26368, 26394);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 25865, 26522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 25865, 26522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNode> DescendantNodes(Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 26936, 27204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 27091, 27193);

                return f_687_27098_27192(this, f_687_27118_27131(this), descendIntoChildren, descendIntoTrivia, includeSelf: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 26936, 27204);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_687_27118_27131(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 27118, 27131);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_687_27098_27192(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesImpl(span, descendIntoChildren, descendIntoTrivia, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 27098, 27192);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 26936, 27204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 26936, 27204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNode> DescendantNodes(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 27704, 27978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 27874, 27967);

                return f_687_27881_27966(this, span, descendIntoChildren, descendIntoTrivia, includeSelf: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 27704, 27978);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_687_27881_27966(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesImpl(span, descendIntoChildren, descendIntoTrivia, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 27881, 27966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 27704, 27978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 27704, 27978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNode> DescendantNodesAndSelf(Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 28414, 28688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 28576, 28677);

                return f_687_28583_28676(this, f_687_28603_28616(this), descendIntoChildren, descendIntoTrivia, includeSelf: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 28414, 28688);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_687_28603_28616(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 28603, 28616);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_687_28583_28676(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesImpl(span, descendIntoChildren, descendIntoTrivia, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 28583, 28676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 28414, 28688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 28414, 28688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNode> DescendantNodesAndSelf(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 29210, 29490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 29387, 29479);

                return f_687_29394_29478(this, span, descendIntoChildren, descendIntoTrivia, includeSelf: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 29210, 29490);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_687_29394_29478(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesImpl(span, descendIntoChildren, descendIntoTrivia, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 29394, 29478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 29210, 29490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 29210, 29490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNodeOrToken> DescendantNodesAndTokens(Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 29915, 30208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 30086, 30197);

                return f_687_30093_30196(this, f_687_30122_30135(this), descendIntoChildren, descendIntoTrivia, includeSelf: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 29915, 30208);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_687_30122_30135(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 30122, 30135);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_30093_30196(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesAndTokensImpl(span, descendIntoChildren, descendIntoTrivia, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 30093, 30196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 29915, 30208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 29915, 30208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNodeOrToken> DescendantNodesAndTokens(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 30723, 31022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 30909, 31011);

                return f_687_30916_31010(this, span, descendIntoChildren, descendIntoTrivia, includeSelf: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 30723, 31022);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_30916_31010(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesAndTokensImpl(span, descendIntoChildren, descendIntoTrivia, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 30916, 31010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 30723, 31022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 30723, 31022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNodeOrToken> DescendantNodesAndTokensAndSelf(Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 31469, 31768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 31647, 31757);

                return f_687_31654_31756(this, f_687_31683_31696(this), descendIntoChildren, descendIntoTrivia, includeSelf: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 31469, 31768);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_687_31683_31696(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 31683, 31696);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_31654_31756(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesAndTokensImpl(span, descendIntoChildren, descendIntoTrivia, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 31654, 31756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 31469, 31768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 31469, 31768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNodeOrToken> DescendantNodesAndTokensAndSelf(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 32305, 32610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 32498, 32599);

                return f_687_32505_32598(this, span, descendIntoChildren, descendIntoTrivia, includeSelf: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 32305, 32610);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_32505_32598(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesAndTokensImpl(span, descendIntoChildren, descendIntoTrivia, includeSelf: includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 32505, 32598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 32305, 32610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 32305, 32610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNode FindNode(TextSpan span, bool findInsideTrivia = false, bool getInnermostNodeForTie = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 33490, 34663);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 33624, 33758) || true) && (!this.FullSpan.Contains(span))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 33624, 33758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 33691, 33743);

                    throw f_687_33697_33742(nameof(span));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 33624, 33758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 33774, 33957);

                var
                node = f_687_33785_33956(f_687_33785_33824(this, span.Start, findInsideTrivia).Parent
                                !, (a, span) => a.FullSpan.Contains(span), span)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 33973, 34008);

                f_687_33973_34007(node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 34022, 34070);

                SyntaxNode?
                cuRoot = f_687_34043_34069_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_687_34043_34058(node), 687, 34043, 34069).GetRoot())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 34116, 34624) || true) && (!getInnermostNodeForTie)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 34116, 34624);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 34177, 34609) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 34177, 34609);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 34230, 34255);

                            var
                            parent = f_687_34243_34254(node)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 34381, 34445) || true) && (parent == null || (DynAbs.Tracing.TraceSender.Expression_False(687, 34385, 34437) || f_687_34403_34419(parent) != f_687_34423_34437(node)))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 34381, 34445);
                                DynAbs.Tracing.TraceSender.TraceBreak(687, 34439, 34445);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(687, 34381, 34445);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 34526, 34554) || true) && (parent == cuRoot)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 34526, 34554);
                                DynAbs.Tracing.TraceSender.TraceBreak(687, 34548, 34554);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(687, 34526, 34554);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 34576, 34590);

                            node = parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 34177, 34609);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 34177, 34609);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(687, 34177, 34609);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 34116, 34624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 34640, 34652);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 33490, 34663);

                System.ArgumentOutOfRangeException
                f_687_33697_33742(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 33697, 33742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_687_33785_33824(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, bool
                findInsideTrivia)
                {
                    var return_v = this_param.FindToken(position, findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 33785, 33824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_33785_33956(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.Text.TextSpan, bool>
                predicate, Microsoft.CodeAnalysis.Text.TextSpan
                argument)
                {
                    var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.Text.TextSpan>(predicate, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 33785, 33956);
                    return return_v;
                }


                int
                f_687_33973_34007(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 33973, 34007);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_687_34043_34058(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 34043, 34058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_34043_34069_I(Microsoft.CodeAnalysis.SyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 34043, 34069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_687_34243_34254(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 34243, 34254);
                    return return_v;
                }


                int
                f_687_34403_34419(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 34403, 34419);
                    return return_v;
                }


                int
                f_687_34423_34437(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 34423, 34437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 33490, 34663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 33490, 34663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken FindToken(int position, bool findInsideTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 35211, 35369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 35309, 35358);

                return f_687_35316_35357(this, position, findInsideTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 35211, 35369);

                Microsoft.CodeAnalysis.SyntaxToken
                f_687_35316_35357(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, bool
                findInsideTrivia)
                {
                    var return_v = this_param.FindTokenCore(position, findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 35316, 35357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 35211, 35369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 35211, 35369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken GetFirstToken(bool includeZeroWidth = false, bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 35620, 35958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 35812, 35947);

                return f_687_35819_35946(SyntaxNavigator.Instance, this, includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 35620, 35958);

                Microsoft.CodeAnalysis.SyntaxToken
                f_687_35819_35946(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, bool
                includeZeroWidth, bool
                includeSkipped, bool
                includeDirectives, bool
                includeDocumentationComments)
                {
                    var return_v = this_param.GetFirstToken(current, includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 35819, 35946);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 35620, 35958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 35620, 35958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken GetLastToken(bool includeZeroWidth = false, bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 36207, 36543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 36398, 36532);

                return f_687_36405_36531(SyntaxNavigator.Instance, this, includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 36207, 36543);

                Microsoft.CodeAnalysis.SyntaxToken
                f_687_36405_36531(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                current, bool
                includeZeroWidth, bool
                includeSkipped, bool
                includeDirectives, bool
                includeDocumentationComments)
                {
                    var return_v = this_param.GetLastToken(current, includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 36405, 36531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 36207, 36543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 36207, 36543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxToken> ChildTokens()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 36668, 36971);

                var listYield = new List<SyntaxToken>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 36738, 36960);
                    foreach (var nodeOrToken in f_687_36766_36792_I(f_687_36766_36792(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 36738, 36960);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 36826, 36945) || true) && (nodeOrToken.IsToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 36826, 36945);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 36891, 36926);

                            listYield.Add(nodeOrToken.AsToken());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 36826, 36945);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 36738, 36960);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 1, 223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 1, 223);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 36668, 36971);

                return listYield;

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_687_36766_36792(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 36766, 36792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_687_36766_36792_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 36766, 36792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 36668, 36971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 36668, 36971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxToken> DescendantTokens(Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 37099, 37395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 37256, 37384);

                return f_687_37263_37383(f_687_37263_37356(f_687_37263_37332(this, descendIntoChildren, descendIntoTrivia), sn => sn.IsToken), sn => sn.AsToken());
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 37099, 37395);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_37263_37332(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantNodesAndTokens(descendIntoChildren, descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 37263, 37332);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_37263_37356(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 37263, 37356);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_687_37263_37383(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 37263, 37383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 37099, 37395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 37099, 37395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxToken> DescendantTokens(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 37528, 37845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 37700, 37834);

                return f_687_37707_37833(f_687_37707_37806(f_687_37707_37782(this, span, descendIntoChildren, descendIntoTrivia), sn => sn.IsToken), sn => sn.AsToken());
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 37528, 37845);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_37707_37782(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantNodesAndTokens(span, descendIntoChildren, descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 37707, 37782);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_37707_37806(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 37707, 37806);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_687_37707_37833(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 37707, 37833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 37528, 37845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 37528, 37845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList GetLeadingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 38114, 38251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 38181, 38240);

                return f_687_38188_38225(this, includeZeroWidth: true).LeadingTrivia;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 38114, 38251);

                Microsoft.CodeAnalysis.SyntaxToken
                f_687_38188_38225(Microsoft.CodeAnalysis.SyntaxNode
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetFirstToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 38188, 38225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 38114, 38251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 38114, 38251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList GetTrailingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 38466, 38604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 38534, 38593);

                return f_687_38541_38577(this, includeZeroWidth: true).TrailingTrivia;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 38466, 38604);

                Microsoft.CodeAnalysis.SyntaxToken
                f_687_38541_38577(Microsoft.CodeAnalysis.SyntaxNode
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetLastToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 38541, 38577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 38466, 38604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 38466, 38604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTrivia FindTrivia(int position, bool findInsideTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 39101, 39284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 39201, 39273);

                return f_687_39208_39272(this, position, (DynAbs.Tracing.TraceSender.Conditional_F1(687, 39229, 39245) || ((findInsideTrivia && DynAbs.Tracing.TraceSender.Conditional_F2(687, 39248, 39264)) || DynAbs.Tracing.TraceSender.Conditional_F3(687, 39267, 39271))) ? SyntaxTrivia.Any : null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 39101, 39284);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_687_39208_39272(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.FindTrivia(position, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 39208, 39272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 39101, 39284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 39101, 39284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTrivia FindTrivia(int position, Func<SyntaxTrivia, bool>? stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 39819, 40133);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 39924, 40077) || true) && (this.FullSpan.Contains(position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 39924, 40077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 39994, 40062);

                    return f_687_40001_40061(this, position - f_687_40037_40050(this), stepInto);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 39924, 40077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 40093, 40122);

                return default(SyntaxTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 39819, 40133);

                int
                f_687_40037_40050(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 40037, 40050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_687_40001_40061(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                textOffset, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = FindTriviaByOffset(node, textOffset, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 40001, 40061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 39819, 40133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 39819, 40133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTrivia FindTriviaByOffset(SyntaxNode node, int textOffset, Func<SyntaxTrivia, bool>? stepInto = null)
        {
recurse:
            if (textOffset >= 0)
            {
                foreach (var element in node.ChildNodesAndTokens())
                {
                    var fullWidth = element.FullWidth;
                    if (textOffset < fullWidth)
                    {
                        if (element.AsNode(out var elementNode))
                        {
                            node = elementNode;
                            goto recurse;
                        }
                        else if (element.IsToken)
                        {
                            var token = element.AsToken();
                            var leading = token.LeadingWidth;
                            if (textOffset < token.LeadingWidth)
                            {
                                foreach (var trivia in token.LeadingTrivia)
                                {
                                    if (textOffset < trivia.FullWidth)
                                    {
                                        if (trivia.HasStructure && stepInto != null && stepInto(trivia))
                                        {
                                            node = trivia.GetStructure()!;
                                            goto recurse;
                                        }

                                        return trivia;
                                    }

                                    textOffset -= trivia.FullWidth;
                                }
                            }
                            else if (textOffset >= leading + token.Width)
                            {
                                textOffset -= leading + token.Width;
                                foreach (var trivia in token.TrailingTrivia)
                                {
                                    if (textOffset < trivia.FullWidth)
                                    {
                                        if (trivia.HasStructure && stepInto != null && stepInto(trivia))
                                        {
                                            node = trivia.GetStructure()!;
                                            goto recurse;
                                        }

                                        return trivia;
                                    }

                                    textOffset -= trivia.FullWidth;
                                }
                            }

                            return default(SyntaxTrivia);
                        }
                    }

                    textOffset -= fullWidth;
                }
            }

            return default(SyntaxTrivia);
        }

        public IEnumerable<SyntaxTrivia> DescendantTrivia(Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 43208, 43460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 43366, 43449);

                return f_687_43373_43448(this, f_687_43394_43407(this), descendIntoChildren, descendIntoTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 43208, 43460);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_687_43394_43407(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 43394, 43407);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_687_43373_43448(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantTriviaImpl(span, descendIntoChildren, descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 43373, 43448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 43208, 43460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 43208, 43460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxTrivia> DescendantTrivia(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 43610, 43868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 43783, 43857);

                return f_687_43790_43856(this, span, descendIntoChildren, descendIntoTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 43610, 43868);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_687_43790_43856(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantTriviaImpl(span, descendIntoChildren, descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 43790, 43856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 43610, 43868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 43610, 43868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ContainsAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 44128, 44174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 44134, 44172);

                    return f_687_44141_44171(f_687_44141_44151(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 44128, 44174);

                    Microsoft.CodeAnalysis.GreenNode
                    f_687_44141_44151(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 44141, 44151);
                        return return_v;
                    }


                    bool
                    f_687_44141_44171(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.ContainsAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 44141, 44171);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 44072, 44185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 44072, 44185);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 44341, 44475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 44415, 44464);

                return f_687_44422_44463(f_687_44422_44432(this), annotationKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 44341, 44475);

                Microsoft.CodeAnalysis.GreenNode
                f_687_44422_44432(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 44422, 44432);
                    return return_v;
                }


                bool
                f_687_44422_44463(Microsoft.CodeAnalysis.GreenNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.HasAnnotations(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 44422, 44463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 44341, 44475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 44341, 44475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotations(IEnumerable<string> annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 44639, 44788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 44727, 44777);

                return f_687_44734_44776(f_687_44734_44744(this), annotationKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 44639, 44788);

                Microsoft.CodeAnalysis.GreenNode
                f_687_44734_44744(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 44734, 44744);
                    return return_v;
                }


                bool
                f_687_44734_44776(Microsoft.CodeAnalysis.GreenNode
                this_param, System.Collections.Generic.IEnumerable<string>
                annotationKinds)
                {
                    var return_v = this_param.HasAnnotations(annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 44734, 44776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 44639, 44788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 44639, 44788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotation([NotNullWhen(true)] SyntaxAnnotation? annotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 44918, 45073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 45018, 45062);

                return f_687_45025_45061(f_687_45025_45035(this), annotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 44918, 45073);

                Microsoft.CodeAnalysis.GreenNode
                f_687_45025_45035(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 45025, 45035);
                    return return_v;
                }


                bool
                f_687_45025_45061(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation?
                annotation)
                {
                    var return_v = this_param.HasAnnotation(annotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 45025, 45061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 44918, 45073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 44918, 45073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 45207, 45366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 45306, 45355);

                return f_687_45313_45354(f_687_45313_45323(this), annotationKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 45207, 45366);

                Microsoft.CodeAnalysis.GreenNode
                f_687_45313_45323(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 45313, 45323);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_687_45313_45354(Microsoft.CodeAnalysis.GreenNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.GetAnnotations(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 45313, 45354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 45207, 45366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 45207, 45366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(IEnumerable<string> annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 45501, 45675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 45614, 45664);

                return f_687_45621_45663(f_687_45621_45631(this), annotationKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 45501, 45675);

                Microsoft.CodeAnalysis.GreenNode
                f_687_45621_45631(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 45621, 45631);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_687_45621_45663(Microsoft.CodeAnalysis.GreenNode
                this_param, System.Collections.Generic.IEnumerable<string>
                annotationKinds)
                {
                    var return_v = this_param.GetAnnotations(annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 45621, 45663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 45501, 45675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 45501, 45675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxAnnotation[] GetAnnotations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 45687, 45802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 45756, 45791);

                return f_687_45763_45790(f_687_45763_45773(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 45687, 45802);

                Microsoft.CodeAnalysis.GreenNode
                f_687_45763_45773(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 45763, 45773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_687_45763_45790(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 45763, 45790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 45687, 45802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 45687, 45802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNodeOrToken> GetAnnotatedNodesAndTokens(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 45953, 46236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 46065, 46225);

                return f_687_46072_46224(f_687_46072_46161(this, n => n.ContainsAnnotations, descendIntoTrivia: true), t => t.HasAnnotations(annotationKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 45953, 46236);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_46072_46161(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantNodesAndTokensAndSelf(descendIntoChildren, descendIntoTrivia: descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 46072, 46161);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_46072_46224(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 46072, 46224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 45953, 46236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 45953, 46236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNodeOrToken> GetAnnotatedNodesAndTokens(params string[] annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 46388, 46682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 46510, 46671);

                return f_687_46517_46670(f_687_46517_46606(this, n => n.ContainsAnnotations, descendIntoTrivia: true), t => t.HasAnnotations(annotationKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 46388, 46682);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_46517_46606(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantNodesAndTokensAndSelf(descendIntoChildren, descendIntoTrivia: descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 46517, 46606);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_46517_46670(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 46517, 46670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 46388, 46682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 46388, 46682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNodeOrToken> GetAnnotatedNodesAndTokens(SyntaxAnnotation annotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 46811, 47095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 46929, 47084);

                return f_687_46936_47083(f_687_46936_47025(this, n => n.ContainsAnnotations, descendIntoTrivia: true), t => t.HasAnnotation(annotation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 46811, 47095);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_46936_47025(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantNodesAndTokensAndSelf(descendIntoChildren, descendIntoTrivia: descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 46936, 47025);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_46936_47083(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 46936, 47083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 46811, 47095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 46811, 47095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNode> GetAnnotatedNodes(SyntaxAnnotation syntaxAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 47213, 47435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 47321, 47424);

                return f_687_47328_47423(f_687_47328_47398(f_687_47328_47377(this, syntaxAnnotation), n => n.IsNode), n => n.AsNode()!);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 47213, 47435);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_47328_47377(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                annotation)
                {
                    var return_v = this_param.GetAnnotatedNodesAndTokens(annotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 47328, 47377);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_47328_47398(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 47328, 47398);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_687_47328_47423(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxNode>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxNode>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 47328, 47423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 47213, 47435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 47213, 47435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxNode> GetAnnotatedNodes(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 47642, 47850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 47738, 47839);

                return f_687_47745_47838(f_687_47745_47813(f_687_47745_47792(this, annotationKind), n => n.IsNode), n => n.AsNode()!);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 47642, 47850);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_47745_47792(Microsoft.CodeAnalysis.SyntaxNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.GetAnnotatedNodesAndTokens(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 47745, 47792);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_47745_47813(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 47745, 47813);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_687_47745_47838(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxNode>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxNode>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 47745, 47838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 47642, 47850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 47642, 47850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxToken> GetAnnotatedTokens(SyntaxAnnotation syntaxAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 47969, 48194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 48079, 48183);

                return f_687_48086_48182(f_687_48086_48157(f_687_48086_48135(this, syntaxAnnotation), n => n.IsToken), n => n.AsToken());
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 47969, 48194);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_48086_48135(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                annotation)
                {
                    var return_v = this_param.GetAnnotatedNodesAndTokens(annotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 48086, 48135);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_48086_48157(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 48086, 48157);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_687_48086_48182(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 48086, 48182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 47969, 48194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 47969, 48194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxToken> GetAnnotatedTokens(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 48318, 48529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 48416, 48518);

                return f_687_48423_48517(f_687_48423_48492(f_687_48423_48470(this, annotationKind), n => n.IsToken), n => n.AsToken());
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 48318, 48529);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_48423_48470(Microsoft.CodeAnalysis.SyntaxNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.GetAnnotatedNodesAndTokens(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 48423, 48470);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_687_48423_48492(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 48423, 48492);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_687_48423_48517(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 48423, 48517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 48318, 48529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 48318, 48529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxTrivia> GetAnnotatedTrivia(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 48670, 48934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 48769, 48923);

                return f_687_48776_48922(f_687_48776_48850(this, n => n.ContainsAnnotations, descendIntoTrivia: true), tr => tr.HasAnnotations(annotationKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 48670, 48934);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_687_48776_48850(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantTrivia(descendIntoChildren, descendIntoTrivia: descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 48776, 48850);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_687_48776_48922(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxTrivia>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 48776, 48922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 48670, 48934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 48670, 48934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxTrivia> GetAnnotatedTrivia(params string[] annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 49076, 49351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 49185, 49340);

                return f_687_49192_49339(f_687_49192_49266(this, n => n.ContainsAnnotations, descendIntoTrivia: true), tr => tr.HasAnnotations(annotationKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 49076, 49351);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_687_49192_49266(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantTrivia(descendIntoChildren, descendIntoTrivia: descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 49192, 49266);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_687_49192_49339(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxTrivia>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 49192, 49339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 49076, 49351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 49076, 49351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxTrivia> GetAnnotatedTrivia(SyntaxAnnotation annotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 49470, 49735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 49575, 49724);

                return f_687_49582_49723(f_687_49582_49656(this, n => n.ContainsAnnotations, descendIntoTrivia: true), tr => tr.HasAnnotation(annotation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 49470, 49735);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_687_49582_49656(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantTrivia(descendIntoChildren, descendIntoTrivia: descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 49582, 49656);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_687_49582_49723(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxTrivia>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 49582, 49723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 49470, 49735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 49470, 49735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxNode WithAdditionalAnnotationsInternal(IEnumerable<SyntaxAnnotation> annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 49747, 49953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 49868, 49942);

                return f_687_49875_49941(f_687_49875_49929(f_687_49875_49885(this), annotations));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 49747, 49953);

                Microsoft.CodeAnalysis.GreenNode
                f_687_49875_49885(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 49875, 49885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_49875_49929(Microsoft.CodeAnalysis.GreenNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = node.WithAdditionalAnnotationsGreen<Microsoft.CodeAnalysis.GreenNode>(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 49875, 49929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_49875_49941(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 49875, 49941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 49747, 49953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 49747, 49953);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxNode GetNodeWithoutAnnotations(IEnumerable<SyntaxAnnotation> annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 49965, 50156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 50078, 50145);

                return f_687_50085_50144(f_687_50085_50132(f_687_50085_50095(this), annotations));
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 49965, 50156);

                Microsoft.CodeAnalysis.GreenNode
                f_687_50085_50095(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 50085, 50095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_50085_50132(Microsoft.CodeAnalysis.GreenNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = node.WithoutAnnotationsGreen<Microsoft.CodeAnalysis.GreenNode>(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 50085, 50132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_50085_50144(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 50085, 50144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 49965, 50156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 49965, 50156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public T? CopyAnnotationsTo<T>(T? node) where T : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 50730, 51160);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 50815, 50892) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 50815, 50892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 50865, 50877);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 50815, 50892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 50908, 50954);

                var
                annotations = f_687_50926_50953(f_687_50926_50936(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 50968, 51123) || true) && (f_687_50972_50991_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(annotations, 687, 50972, 50991)?.Length) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 50968, 51123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 51029, 51108);

                    return (T)f_687_51039_51107((f_687_51040_51094(f_687_51040_51050(node), annotations)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 50968, 51123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 51137, 51149);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 50730, 51160);

                Microsoft.CodeAnalysis.GreenNode
                f_687_50926_50936(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 50926, 50936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_687_50926_50953(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 50926, 50953);
                    return return_v;
                }


                int?
                f_687_50972_50991_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 50972, 50991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_51040_51050(T
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 51040, 51050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_51040_51094(Microsoft.CodeAnalysis.GreenNode
                node, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = node.WithAdditionalAnnotationsGreen<Microsoft.CodeAnalysis.GreenNode>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>)annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 51040, 51094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_51039_51107(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 51039, 51107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 50730, 51160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 50730, 51160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsEquivalentTo(SyntaxNode node, bool topLevel = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 51763, 51907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 51854, 51896);

                return f_687_51861_51895(this, node, topLevel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 51763, 51907);

                bool
                f_687_51861_51895(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                topLevel)
                {
                    var return_v = this_param.IsEquivalentToCore(node, topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 51861, 51895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 51763, 51907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 51763, 51907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual void SerializeTo(Stream stream, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 52114, 52664);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 52232, 52347) || true) && (stream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 52232, 52347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 52284, 52332);

                    throw f_687_52290_52331(nameof(stream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 52232, 52347);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 52363, 52518) || true) && (f_687_52367_52383_M(!stream.CanWrite))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 52363, 52518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 52417, 52503);

                    throw f_687_52423_52502(f_687_52453_52501());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 52363, 52518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 52534, 52614);

                using var
                writer = f_687_52553_52613(stream, leaveOpen: true, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 52628, 52653);

                f_687_52628_52652(writer, f_687_52646_52651());
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 52114, 52664);

                System.ArgumentNullException
                f_687_52290_52331(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 52290, 52331);
                    return return_v;
                }


                bool
                f_687_52367_52383_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 52367, 52383);
                    return return_v;
                }


                string
                f_687_52453_52501()
                {
                    var return_v = CodeAnalysisResources.TheStreamCannotBeWrittenTo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 52453, 52501);
                    return return_v;
                }


                System.InvalidOperationException
                f_687_52423_52502(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 52423, 52502);
                    return return_v;
                }


                Roslyn.Utilities.ObjectWriter
                f_687_52553_52613(System.IO.Stream
                stream, bool
                leaveOpen, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Roslyn.Utilities.ObjectWriter(stream, leaveOpen: leaveOpen, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 52553, 52613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_687_52646_52651()
                {
                    var return_v = Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 52646, 52651);
                    return return_v;
                }


                int
                f_687_52628_52652(Roslyn.Utilities.ObjectWriter
                this_param, Microsoft.CodeAnalysis.GreenNode
                value)
                {
                    this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 52628, 52652);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 52114, 52664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 52114, 52664);
            }
        }

        protected virtual bool EquivalentToCore(SyntaxNode other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 52830, 52952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 52912, 52941);

                return f_687_52919_52940(this, other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 52830, 52952);

                bool
                f_687_52919_52940(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                other)
                {
                    var return_v = this_param.IsEquivalentTo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 52919, 52940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 52830, 52952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 52830, 52952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract SyntaxTree SyntaxTreeCore { get; }

        protected virtual SyntaxToken FindTokenCore(int position, bool findInsideTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 53691, 54285);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 53796, 53915) || true) && (findInsideTrivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 53796, 53915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 53850, 53900);

                    return f_687_53857_53899(this, position, SyntaxTrivia.Any);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 53796, 53915);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 53931, 53947);

                SyntaxToken
                EoF
                = default(SyntaxToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 53961, 54060) || true) && (f_687_53965_54000(this, position, out EoF))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 53961, 54060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54034, 54045);

                    return EoF;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 53961, 54060);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54076, 54218) || true) && (!this.FullSpan.Contains(position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 54076, 54218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54147, 54203);

                    throw f_687_54153_54202(nameof(position));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 54076, 54218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54234, 54274);

                return f_687_54241_54273(this, position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 53691, 54285);

                Microsoft.CodeAnalysis.SyntaxToken
                f_687_53857_53899(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                findInsideTrivia)
                {
                    var return_v = this_param.FindToken(position, findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 53857, 53899);
                    return return_v;
                }


                bool
                f_687_53965_54000(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, out Microsoft.CodeAnalysis.SyntaxToken
                Eof)
                {
                    var return_v = this_param.TryGetEofAt(position, out Eof);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 53965, 54000);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_687_54153_54202(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 54153, 54202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_687_54241_54273(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindTokenInternal(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 54241, 54273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 53691, 54285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 53691, 54285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetEofAt(int position, out SyntaxToken Eof)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 54297, 54837);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54381, 54756) || true) && (position == f_687_54397_54413(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 54381, 54756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54447, 54500);

                    var
                    compilationUnit = this as ICompilationUnitSyntax
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54518, 54741) || true) && (compilationUnit != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 54518, 54741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54587, 54624);

                        Eof = f_687_54593_54623(compilationUnit);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54646, 54688);

                        f_687_54646_54687(Eof.EndPosition == position);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54710, 54722);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 54518, 54741);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 54381, 54756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54772, 54799);

                Eof = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 54813, 54826);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 54297, 54837);

                int
                f_687_54397_54413(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.EndPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 54397, 54413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_687_54593_54623(Microsoft.CodeAnalysis.ICompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.EndOfFileToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 54593, 54623);
                    return return_v;
                }


                int
                f_687_54646_54687(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 54646, 54687);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 54297, 54837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 54297, 54837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken FindTokenInternal(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 54849, 55669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 55080, 55113);

                SyntaxNodeOrToken
                curNode = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 55129, 55658) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 55129, 55658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 55174, 55209);

                        f_687_55174_55208(curNode.RawKind != 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 55227, 55277);

                        f_687_55227_55276(curNode.FullSpan.Contains(position));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 55297, 55325);

                        var
                        node = curNode.AsNode()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 55345, 55643) || true) && (node != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 55345, 55643);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 55466, 55517);

                            curNode = f_687_55476_55516(node, position);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 55345, 55643);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 55345, 55643);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 55599, 55624);

                            return curNode.AsToken();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 55345, 55643);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 55129, 55658);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 55129, 55658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 55129, 55658);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 54849, 55669);

                int
                f_687_55174_55208(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 55174, 55208);
                    return 0;
                }


                int
                f_687_55227_55276(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 55227, 55276);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_687_55476_55516(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.ChildThatContainsPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 55476, 55516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 54849, 55669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 54849, 55669);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken FindToken(int position, Func<SyntaxTrivia, bool> findInsideTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 55681, 55852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 55792, 55841);

                return f_687_55799_55840(this, position, findInsideTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 55681, 55852);

                Microsoft.CodeAnalysis.SyntaxToken
                f_687_55799_55840(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                stepInto)
                {
                    var return_v = this_param.FindTokenCore(position, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 55799, 55840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 55681, 55852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 55681, 55852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual SyntaxToken FindTokenCore(int position, Func<SyntaxTrivia, bool> stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 56357, 56897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 56474, 56536);

                var
                token = f_687_56486_56535(this, position, findInsideTrivia: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 56550, 56857) || true) && (stepInto != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 56550, 56857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 56604, 56659);

                    var
                    trivia = f_687_56617_56658(position, token)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 56679, 56842) || true) && (trivia.HasStructure && (DynAbs.Tracing.TraceSender.Expression_True(687, 56683, 56722) && f_687_56706_56722(stepInto, trivia)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 56679, 56842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 56764, 56823);

                        token = f_687_56772_56822(trivia.GetStructure()!, position);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 56679, 56842);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 56550, 56857);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 56873, 56886);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 56357, 56897);

                Microsoft.CodeAnalysis.SyntaxToken
                f_687_56486_56535(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, bool
                findInsideTrivia)
                {
                    var return_v = this_param.FindToken(position, findInsideTrivia: findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 56486, 56535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_687_56617_56658(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = GetTriviaFromSyntaxToken(position, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 56617, 56658);
                    return return_v;
                }


                bool
                f_687_56706_56722(System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 56706, 56722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_687_56772_56822(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindTokenInternal(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 56772, 56822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 56357, 56897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 56357, 56897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTrivia GetTriviaFromSyntaxToken(int position, in SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(687, 56909, 57506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57023, 57045);

                var
                span = token.Span
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57059, 57091);

                var
                trivia = f_687_57072_57090()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57105, 57465) || true) && (position < span.Start && (DynAbs.Tracing.TraceSender.Expression_True(687, 57109, 57156) && token.HasLeadingTrivia))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 57105, 57465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57190, 57260);

                    trivia = f_687_57199_57259(token.LeadingTrivia, position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 57105, 57465);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 57105, 57465);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57294, 57465) || true) && (position >= span.End && (DynAbs.Tracing.TraceSender.Expression_True(687, 57298, 57345) && token.HasTrailingTrivia))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 57294, 57465);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57379, 57450);

                        trivia = f_687_57388_57449(token.TrailingTrivia, position);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 57294, 57465);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(687, 57105, 57465);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57481, 57495);

                return trivia;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(687, 56909, 57506);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_687_57072_57090()
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 57072, 57090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_687_57199_57259(Microsoft.CodeAnalysis.SyntaxTriviaList
                list, int
                position)
                {
                    var return_v = GetTriviaThatContainsPosition(list, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 57199, 57259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_687_57388_57449(Microsoft.CodeAnalysis.SyntaxTriviaList
                list, int
                position)
                {
                    var return_v = GetTriviaThatContainsPosition(list, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 57388, 57449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 56909, 57506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 56909, 57506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTrivia GetTriviaThatContainsPosition(in SyntaxTriviaList list, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(687, 57518, 58003);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57641, 57947);
                    foreach (var trivia in f_687_57664_57668_I(list))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 57641, 57947);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57702, 57815) || true) && (trivia.FullSpan.Contains(position))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 57702, 57815);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57782, 57796);

                            return trivia;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 57702, 57815);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57835, 57932) || true) && (trivia.Position > position)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 57835, 57932);
                            DynAbs.Tracing.TraceSender.TraceBreak(687, 57907, 57913);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(687, 57835, 57932);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 57641, 57947);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(687, 1, 307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(687, 1, 307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 57963, 57992);

                return default(SyntaxTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(687, 57518, 58003);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_687_57664_57668_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 57664, 57668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 57518, 58003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 57518, 58003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual SyntaxTrivia FindTriviaCore(int position, bool findInsideTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 58373, 58537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 58480, 58526);

                return f_687_58487_58525(this, position, findInsideTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 58373, 58537);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_687_58487_58525(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position, bool
                findInsideTrivia)
                {
                    var return_v = this_param.FindTrivia(position, findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 58487, 58525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 58373, 58537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 58373, 58537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal abstract SyntaxNode ReplaceCore<TNode>(
                    IEnumerable<TNode>? nodes = null,
                    Func<TNode, TNode, SyntaxNode>? computeReplacementNode = null,
                    IEnumerable<SyntaxToken>? tokens = null,
                    Func<SyntaxToken, SyntaxToken, SyntaxToken>? computeReplacementToken = null,
                    IEnumerable<SyntaxTrivia>? trivia = null,
                    Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia>? computeReplacementTrivia = null)
                    where TNode : SyntaxNode;

        protected internal abstract SyntaxNode ReplaceNodeInListCore(SyntaxNode originalNode, IEnumerable<SyntaxNode> replacementNodes);

        protected internal abstract SyntaxNode InsertNodesInListCore(SyntaxNode nodeInList, IEnumerable<SyntaxNode> nodesToInsert, bool insertBefore);

        protected internal abstract SyntaxNode ReplaceTokenInListCore(SyntaxToken originalToken, IEnumerable<SyntaxToken> newTokens);

        protected internal abstract SyntaxNode InsertTokensInListCore(SyntaxToken originalToken, IEnumerable<SyntaxToken> newTokens, bool insertBefore);

        protected internal abstract SyntaxNode ReplaceTriviaInListCore(SyntaxTrivia originalTrivia, IEnumerable<SyntaxTrivia> newTrivia);

        protected internal abstract SyntaxNode InsertTriviaInListCore(SyntaxTrivia originalTrivia, IEnumerable<SyntaxTrivia> newTrivia, bool insertBefore);

        protected internal abstract SyntaxNode? RemoveNodesCore(
                    IEnumerable<SyntaxNode> nodes,
                    SyntaxRemoveOptions options);

        protected internal abstract SyntaxNode NormalizeWhitespaceCore(string indentation, string eol, bool elasticTrivia);

        protected abstract bool IsEquivalentToCore(SyntaxNode node, bool topLevel = false);

        internal virtual bool ShouldCreateWeakList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 61533, 61626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 61602, 61615);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 61533, 61626);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 61533, 61626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 61533, 61626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 61686, 61883);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 61722, 61825) || true) && (f_687_61726_61751_M(!this.ContainsDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(687, 61722, 61825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 61793, 61806);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(687, 61722, 61825);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 61845, 61868);

                    return f_687_61852_61867(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(687, 61686, 61883);

                    bool
                    f_687_61726_61751_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 61726, 61751);
                        return return_v;
                    }


                    bool
                    f_687_61852_61867(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.HasErrorsSlow();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 61852, 61867);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 61638, 61894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 61638, 61894);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasErrorsSlow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(687, 61906, 62113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 61959, 62102);

                return f_687_61966_62028(f_687_62017_62027(this)).Any(info => info.Severity == DiagnosticSeverity.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(687, 61906, 62113);

                Microsoft.CodeAnalysis.GreenNode
                f_687_62017_62027(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 62017, 62027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList
                f_687_61966_62028(Microsoft.CodeAnalysis.GreenNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 61966, 62028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 61906, 62113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 61906, 62113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T CloneNodeAsRoot<T>(T node, SyntaxTree syntaxTree) where T : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(687, 62345, 62588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 62458, 62503);

                var
                clone = (T)f_687_62473_62502(f_687_62473_62483(node), null, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 62517, 62548);

                clone._syntaxTree = syntaxTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(687, 62564, 62577);

                return clone;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(687, 62345, 62588);

                Microsoft.CodeAnalysis.GreenNode
                f_687_62473_62483(T
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 62473, 62483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_687_62473_62502(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 62473, 62502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(687, 62345, 62588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 62345, 62588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxNode()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(687, 947, 62595);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(687, 947, 62595);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(687, 947, 62595);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(687, 947, 62595);

        static int
        f_687_1244_1308(bool
        b, string
        message)
        {
            RoslynDebug.Assert(b, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 1244, 1308);
            return 0;
        }


        static Microsoft.CodeAnalysis.GreenNode
        f_687_1383_1395(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 1383, 1395);
            return return_v;
        }


        static bool
        f_687_1383_1402(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.IsList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 1383, 1402);
            return return_v;
        }


        static int
        f_687_1346_1438(bool
        b, string
        message)
        {
            RoslynDebug.Assert(b, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 1346, 1438);
            return 0;
        }


        static Microsoft.CodeAnalysis.GreenNode
        f_687_1842_1847_C(Microsoft.CodeAnalysis.GreenNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(687, 1748, 1930);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode
        f_687_2230_2235()
        {
            var return_v = Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2230, 2235);
            return return_v;
        }


        int
        f_687_2230_2243(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.RawKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2230, 2243);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode
        f_687_2285_2290()
        {
            var return_v = Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2285, 2290);
            return return_v;
        }


        string
        f_687_2285_2299(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.KindText;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2285, 2299);
            return return_v;
        }


        int
        f_687_2586_2594()
        {
            var return_v = Position;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2586, 2594);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode
        f_687_2597_2602()
        {
            var return_v = Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2597, 2602);
            return return_v;
        }


        int
        f_687_2597_2612(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.FullWidth;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2597, 2612);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_687_2816_2835(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SyntaxTreeCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2816, 2835);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode
        f_687_2872_2882(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2872, 2882);
            return return_v;
        }


        bool
        f_687_2872_2889(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.IsList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 2872, 2889);
            return return_v;
        }


        int
        f_687_3092_3105(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Position;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3092, 3105);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode
        f_687_3107_3117(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3107, 3117);
            return return_v;
        }


        int
        f_687_3107_3127(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.FullWidth;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3107, 3127);
            return return_v;
        }


        Microsoft.CodeAnalysis.Text.TextSpan
        f_687_3079_3128(int
        start, int
        length)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 3079, 3128);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode
        f_687_3167_3177(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3167, 3177);
            return return_v;
        }


        int
        f_687_3167_3187(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.SlotCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 3167, 3187);
            return return_v;
        }


        int
        f_687_4312_4320()
        {
            var return_v = Position;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 4312, 4320);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode
        f_687_4323_4328()
        {
            var return_v = Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 4323, 4328);
            return return_v;
        }


        int
        f_687_4323_4352(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.GetLeadingTriviaWidth();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(687, 4323, 4352);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode
        f_687_4677_4687(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 4677, 4687);
            return return_v;
        }


        int
        f_687_4677_4693(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.Width;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 4677, 4693);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode
        f_687_5020_5030(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 5020, 5030);
            return return_v;
        }


        int
        f_687_5020_5040(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.FullWidth;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(687, 5020, 5040);
            return return_v;
        }

    }
}
