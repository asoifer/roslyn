// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    [StructLayout(LayoutKind.Auto)]
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public readonly struct SyntaxNodeOrToken : IEquatable<SyntaxNodeOrToken>
    {

        private readonly SyntaxNode? _nodeOrParent;

        private readonly GreenNode? _token;

        private readonly int _position;

        private readonly int _tokenIndex;

        internal SyntaxNodeOrToken(SyntaxNode node)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(692, 1741, 2006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 1831, 1889);

                f_692_1831_1888(f_692_1844_1862_M(!f_692_1845_1855(node).IsList), "node cannot be a list");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 1903, 1929);

                _position = f_692_1915_1928(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 1943, 1964);

                _nodeOrParent = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 1978, 1995);

                _tokenIndex = -1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(692, 1741, 2006);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 1741, 2006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 1741, 2006);
            }
        }

        internal SyntaxNodeOrToken(SyntaxNode? parent, GreenNode? token, int position, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(692, 2018, 2726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2132, 2212);

                f_692_2132_2211(parent == null || (DynAbs.Tracing.TraceSender.Expression_False(692, 2145, 2183) || f_692_2163_2183_M(!f_692_2164_2176(parent).IsList)), "parent cannot be a list");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2226, 2332);

                f_692_2226_2331(token != null || (DynAbs.Tracing.TraceSender.Expression_False(692, 2239, 2303) || (parent == null && (DynAbs.Tracing.TraceSender.Expression_True(692, 2257, 2288) && position == 0) && (DynAbs.Tracing.TraceSender.Expression_True(692, 2257, 2302) && index == 0))), "parts must form a token");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2346, 2416);

                f_692_2346_2415(token == null || (DynAbs.Tracing.TraceSender.Expression_False(692, 2359, 2389) || f_692_2376_2389(token)), "token must be a token");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2430, 2485);

                f_692_2430_2484(index >= 0, "index must not be negative");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2499, 2578);

                f_692_2499_2577(parent == null || (DynAbs.Tracing.TraceSender.Expression_False(692, 2512, 2543) || token != null), "null token cannot have parent");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2594, 2615);

                _position = position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2629, 2649);

                _tokenIndex = index;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2663, 2686);

                _nodeOrParent = parent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2700, 2715);

                _token = token;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(692, 2018, 2726);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 2018, 2726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 2018, 2726);
            }
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 2738, 2868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2799, 2857);

                return f_692_2806_2820(f_692_2806_2815(this)) + " " + KindText + " " + ToString();
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 2738, 2868);

                System.Type
                f_692_2806_2815(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 2806, 2815);
                    return return_v;
                }


                string
                f_692_2806_2820(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 2806, 2820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 2738, 2868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 2738, 2868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string KindText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 2928, 3257);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 2964, 3066) || true) && (_token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 2964, 3066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3024, 3047);

                        return f_692_3031_3046(_token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 2964, 3066);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3086, 3208) || true) && (_nodeOrParent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 3086, 3208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3153, 3189);

                        return f_692_3160_3188(f_692_3160_3179(_nodeOrParent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 3086, 3208);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3228, 3242);

                    return "None";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(692, 2928, 3257);

                    string
                    f_692_3031_3046(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.KindText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 3031, 3046);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode
                    f_692_3160_3179(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 3160, 3179);
                        return return_v;
                    }


                    string
                    f_692_3160_3188(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.KindText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 3160, 3188);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 2880, 3268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 2880, 3268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int RawKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 3443, 3492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3446, 3492);
                    return f_692_3446_3461_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_token, 692, 3446, 3461)?.RawKind) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(692, 3446, 3492) ?? f_692_3465_3487_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_nodeOrParent, 692, 3465, 3487)?.RawKind) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(692, 3465, 3492) ?? 0)); DynAbs.Tracing.TraceSender.TraceExitMethod(692, 3443, 3492);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 3443, 3492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 3443, 3492);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 3668, 3997);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3704, 3806) || true) && (_token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 3704, 3806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3764, 3787);

                        return f_692_3771_3786(_token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 3704, 3806);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3826, 3942) || true) && (_nodeOrParent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 3826, 3942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3893, 3923);

                        return f_692_3900_3922(_nodeOrParent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 3826, 3942);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 3962, 3982);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(692, 3668, 3997);

                    string
                    f_692_3771_3786(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.Language;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 3771, 3786);
                        return return_v;
                    }


                    string
                    f_692_3900_3922(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Language;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 3900, 3922);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 3621, 4008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 3621, 4008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsMissing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 4490, 4547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 4493, 4547);
                    return f_692_4493_4510_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_token, 692, 4493, 4510)?.IsMissing) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(692, 4493, 4547) ?? f_692_4514_4538_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_nodeOrParent, 692, 4514, 4538)?.IsMissing) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(692, 4514, 4547) ?? false)); DynAbs.Tracing.TraceSender.TraceExitMethod(692, 4490, 4547);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 4490, 4547);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 4490, 4547);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxNode? Parent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 4726, 4783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 4729, 4783);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(692, 4729, 4743) || ((_token != null && DynAbs.Tracing.TraceSender.Conditional_F2(692, 4746, 4759)) || DynAbs.Tracing.TraceSender.Conditional_F3(692, 4762, 4783))) ? _nodeOrParent : f_692_4762_4783_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_nodeOrParent, 692, 4762, 4783)?.Parent); DynAbs.Tracing.TraceSender.TraceExitMethod(692, 4726, 4783);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 4726, 4783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 4726, 4783);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal GreenNode? UnderlyingNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 4831, 4864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 4834, 4864);
                    return _token ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.GreenNode?>(692, 4834, 4864) ?? f_692_4844_4864_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_nodeOrParent, 692, 4844, 4864)?.Green)); DynAbs.Tracing.TraceSender.TraceExitMethod(692, 4831, 4864);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 4831, 4864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 4831, 4864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int Position
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 4899, 4911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 4902, 4911);
                    return _position; DynAbs.Tracing.TraceSender.TraceExitMethod(692, 4899, 4911);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 4899, 4911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 4899, 4911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal GreenNode RequiredUnderlyingNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 4990, 5122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 5026, 5067);

                    f_692_5026_5066(UnderlyingNode is not null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 5085, 5107);

                    return UnderlyingNode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(692, 4990, 5122);

                    int
                    f_692_5026_5066(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 5026, 5066);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 4924, 5133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 4924, 5133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 5302, 5312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 5305, 5312);
                    return f_692_5305_5312_M(!IsNode); DynAbs.Tracing.TraceSender.TraceExitMethod(692, 5302, 5312);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 5302, 5312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 5302, 5312);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 5480, 5498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 5483, 5498);
                    return _tokenIndex < 0; DynAbs.Tracing.TraceSender.TraceExitMethod(692, 5480, 5498);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 5480, 5498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 5480, 5498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxToken AsToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 5816, 6065);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 5869, 6010) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 5869, 6010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 5921, 5995);

                    return f_692_5928_5994(_nodeOrParent, _token, this.Position, _tokenIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 5869, 6010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6026, 6054);

                return default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 5816, 6065);

                Microsoft.CodeAnalysis.SyntaxToken
                f_692_5928_5994(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent, token, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 5928, 5994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 5816, 6065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 5816, 6065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool AsToken(out SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 6077, 6325);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6146, 6255) || true) && (IsToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 6146, 6255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6191, 6210);

                    token = AsToken()!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6228, 6240);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 6146, 6255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6271, 6287);

                token = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6301, 6314);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 6077, 6325);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 6077, 6325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 6077, 6325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNode? AsNode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 6638, 6817);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6690, 6769) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 6690, 6769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6742, 6754);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 6690, 6769);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6785, 6806);

                return _nodeOrParent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 6638, 6817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 6638, 6817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 6638, 6817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool AsNode([NotNullWhen(true)] out SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 6829, 7102);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6916, 7036) || true) && (IsNode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 6916, 7036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6960, 6981);

                    node = _nodeOrParent;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 6999, 7021);

                    return node is object;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 6916, 7036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7052, 7064);

                node = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7078, 7091);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 6829, 7102);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 6829, 7102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 6829, 7102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ChildSyntaxList ChildNodesAndTokens()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 7242, 7460);
                Microsoft.CodeAnalysis.SyntaxNode? node = default(Microsoft.CodeAnalysis.SyntaxNode?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7311, 7418) || true) && (AsNode(out node
                ))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 7311, 7418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7369, 7403);

                    return f_692_7376_7402(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 7311, 7418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7434, 7449);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 7242, 7460);

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_692_7376_7402(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 7376, 7402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 7242, 7460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 7242, 7460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TextSpan Span
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 7702, 8036);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7738, 7844) || true) && (_token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 7738, 7844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7798, 7825);

                        return this.AsToken().Span;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 7738, 7844);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7864, 7976) || true) && (_nodeOrParent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 7864, 7976);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7931, 7957);

                        return f_692_7938_7956(_nodeOrParent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 7864, 7976);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 7996, 8021);

                    return default(TextSpan);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(692, 7702, 8036);

                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_692_7938_7956(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Span;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 7938, 7956);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 7657, 8047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 7657, 8047);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 8326, 8763);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 8362, 8556) || true) && (_token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 8362, 8556);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 8487, 8537);

                        return _position + f_692_8506_8536(_token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 8362, 8556);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 8576, 8693) || true) && (_nodeOrParent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 8576, 8693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 8643, 8674);

                        return f_692_8650_8673(_nodeOrParent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 8576, 8693);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 8713, 8722);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(692, 8326, 8763);

                    int
                    f_692_8506_8536(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 8506, 8536);
                        return return_v;
                    }


                    int
                    f_692_8650_8673(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SpanStart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 8650, 8673);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 8281, 8774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 8281, 8774);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 9003, 9362);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 9039, 9166) || true) && (_token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 9039, 9166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 9099, 9147);

                        return f_692_9106_9146(Position, f_692_9129_9145(_token));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 9039, 9166);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 9186, 9302) || true) && (_nodeOrParent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 9186, 9302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 9253, 9283);

                        return f_692_9260_9282(_nodeOrParent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 9186, 9302);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 9322, 9347);

                    return default(TextSpan);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(692, 9003, 9362);

                    int
                    f_692_9129_9145(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 9129, 9145);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_692_9106_9146(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 9106, 9146);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_692_9260_9282(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.FullSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 9260, 9282);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 8954, 9373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 8954, 9373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 9818, 10137);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 9876, 9968) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 9876, 9968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 9928, 9953);

                    return f_692_9935_9952(_token);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 9876, 9968);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 9984, 10090) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 9984, 10090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 10043, 10075);

                    return f_692_10050_10074(_nodeOrParent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 9984, 10090);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 10106, 10126);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 9818, 10137);

                string
                f_692_9935_9952(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 9935, 9952);
                    return return_v;
                }


                string
                f_692_10050_10074(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 10050, 10074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 9818, 10137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 9818, 10137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 10558, 10880);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 10611, 10707) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 10611, 10707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 10663, 10692);

                    return f_692_10670_10691(_token);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 10611, 10707);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 10723, 10833) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 10723, 10833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 10782, 10818);

                    return f_692_10789_10817(_nodeOrParent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 10723, 10833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 10849, 10869);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 10558, 10880);

                string
                f_692_10670_10691(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 10670, 10691);
                    return return_v;
                }


                string
                f_692_10789_10817(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 10789, 10817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 10558, 10880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 10558, 10880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void WriteTo(System.IO.TextWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 11024, 11295);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 11097, 11284) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 11097, 11284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 11149, 11172);

                    f_692_11149_11171(_token, writer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 11097, 11284);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 11097, 11284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 11238, 11269);

                    // LAFHIS
                    DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_nodeOrParent, 692, 11238, 11268)?.WriteTo(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 11252, 11268);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 11097, 11284);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 11024, 11295);

                int
                f_692_11149_11171(Microsoft.CodeAnalysis.GreenNode
                this_param, System.IO.TextWriter
                writer)
                {
                    this_param.WriteTo(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 11149, 11171);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 11024, 11295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 11024, 11295);
            }
        }

        public bool HasLeadingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 11468, 11504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 11471, 11504);
                    return this.GetLeadingTrivia().Count > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(692, 11468, 11504);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 11468, 11504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 11468, 11504);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxTriviaList GetLeadingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 11758, 12118);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 11825, 11928) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 11825, 11928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 11877, 11913);

                    return this.AsToken().LeadingTrivia;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 11825, 11928);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 11944, 12058) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 11944, 12058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 12003, 12043);

                    return f_692_12010_12042(_nodeOrParent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 11944, 12058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 12074, 12107);

                return default(SyntaxTriviaList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 11758, 12118);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_692_12010_12042(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 12010, 12042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 11758, 12118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 11758, 12118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasTrailingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 12293, 12330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 12296, 12330);
                    return this.GetTrailingTrivia().Count > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(692, 12293, 12330);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 12293, 12330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 12293, 12330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxTriviaList GetTrailingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 12583, 12946);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 12651, 12755) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 12651, 12755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 12703, 12740);

                    return this.AsToken().TrailingTrivia;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 12651, 12755);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 12771, 12886) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 12771, 12886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 12830, 12871);

                    return f_692_12837_12870(_nodeOrParent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 12771, 12886);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 12902, 12935);

                return default(SyntaxTriviaList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 12583, 12946);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_692_12837_12870(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 12837, 12870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 12583, 12946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 12583, 12946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken WithLeadingTrivia(IEnumerable<SyntaxTrivia> trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 12958, 13345);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13059, 13169) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 13059, 13169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13111, 13154);

                    return AsToken().WithLeadingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 13059, 13169);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13185, 13306) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 13185, 13306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13244, 13291);

                    return f_692_13251_13290(_nodeOrParent, trivia);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 13185, 13306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13322, 13334);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 12958, 13345);

                Microsoft.CodeAnalysis.SyntaxNode
                f_692_13251_13290(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<Microsoft.CodeAnalysis.SyntaxNode>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 13251, 13290);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 12958, 13345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 12958, 13345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken WithLeadingTrivia(params SyntaxTrivia[] trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 13357, 13525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13454, 13514);

                return WithLeadingTrivia(trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 13357, 13525);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 13357, 13525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 13357, 13525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken WithTrailingTrivia(IEnumerable<SyntaxTrivia> trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 13537, 13927);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13639, 13750) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 13639, 13750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13691, 13735);

                    return AsToken().WithTrailingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 13639, 13750);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13766, 13888) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 13766, 13888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13825, 13873);

                    return f_692_13832_13872(_nodeOrParent, trivia);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 13766, 13888);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 13904, 13916);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 13537, 13927);

                Microsoft.CodeAnalysis.SyntaxNode
                f_692_13832_13872(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                trivia)
                {
                    var return_v = node.WithTrailingTrivia<Microsoft.CodeAnalysis.SyntaxNode>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 13832, 13872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 13537, 13927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 13537, 13927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken WithTrailingTrivia(params SyntaxTrivia[] trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 13939, 14109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 14037, 14098);

                return WithTrailingTrivia(trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 13939, 14109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 13939, 14109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 13939, 14109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ContainsDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 14378, 14722);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 14414, 14527) || true) && (_token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 14414, 14527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 14474, 14508);

                        return f_692_14481_14507(_token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 14414, 14527);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 14547, 14674) || true) && (_nodeOrParent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 14547, 14674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 14614, 14655);

                        return f_692_14621_14654(_nodeOrParent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 14547, 14674);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 14694, 14707);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(692, 14378, 14722);

                    bool
                    f_692_14481_14507(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.ContainsDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 14481, 14507);
                        return return_v;
                    }


                    bool
                    f_692_14621_14654(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.ContainsDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 14621, 14654);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 14322, 14733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 14322, 14733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<Diagnostic> GetDiagnostics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 15097, 15490);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 15169, 15275) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 15169, 15275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 15221, 15260);

                    return this.AsToken().GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 15169, 15275);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 15291, 15403) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 15291, 15403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 15350, 15388);

                    return f_692_15357_15387(_nodeOrParent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 15291, 15403);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 15419, 15479);

                return f_692_15426_15478();
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 15097, 15490);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_692_15357_15387(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 15357, 15387);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_692_15426_15478()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 15426, 15478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 15097, 15490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 15097, 15490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ContainsDirectives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 15711, 16053);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 15747, 15859) || true) && (_token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 15747, 15859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 15807, 15840);

                        return f_692_15814_15839(_token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 15747, 15859);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 15879, 16005) || true) && (_nodeOrParent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 15879, 16005);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 15946, 15986);

                        return f_692_15953_15985(_nodeOrParent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 15879, 16005);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 16025, 16038);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(692, 15711, 16053);

                    bool
                    f_692_15814_15839(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.ContainsDirectives;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 15814, 15839);
                        return return_v;
                    }


                    bool
                    f_692_15953_15985(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.ContainsDirectives;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 15953, 15985);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 15656, 16064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 15656, 16064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 16311, 16655);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 16347, 16460) || true) && (_token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 16347, 16460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 16407, 16441);

                        return f_692_16414_16440(_token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 16347, 16460);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 16480, 16607) || true) && (_nodeOrParent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 16480, 16607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 16547, 16588);

                        return f_692_16554_16587(_nodeOrParent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 16480, 16607);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 16627, 16640);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(692, 16311, 16655);

                    bool
                    f_692_16414_16440(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.ContainsAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 16414, 16440);
                        return return_v;
                    }


                    bool
                    f_692_16554_16587(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.ContainsAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 16554, 16587);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 16255, 16666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 16255, 16666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 16815, 17183);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 16889, 17001) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 16889, 17001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 16941, 16986);

                    return f_692_16948_16985(_token, annotationKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 16889, 17001);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 17017, 17143) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 17017, 17143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 17076, 17128);

                    return f_692_17083_17127(_nodeOrParent, annotationKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 17017, 17143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 17159, 17172);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 16815, 17183);

                bool
                f_692_16948_16985(Microsoft.CodeAnalysis.GreenNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.HasAnnotations(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 16948, 16985);
                    return return_v;
                }


                bool
                f_692_17083_17127(Microsoft.CodeAnalysis.SyntaxNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.HasAnnotations(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 17083, 17127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 16815, 17183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 16815, 17183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotations(IEnumerable<string> annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 17332, 17716);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 17420, 17533) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 17420, 17533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 17472, 17518);

                    return f_692_17479_17517(_token, annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 17420, 17533);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 17549, 17676) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 17549, 17676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 17608, 17661);

                    return f_692_17615_17660(_nodeOrParent, annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 17549, 17676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 17692, 17705);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 17332, 17716);

                bool
                f_692_17479_17517(Microsoft.CodeAnalysis.GreenNode
                this_param, System.Collections.Generic.IEnumerable<string>
                annotationKinds)
                {
                    var return_v = this_param.HasAnnotations(annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 17479, 17517);
                    return return_v;
                }


                bool
                f_692_17615_17660(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Collections.Generic.IEnumerable<string>
                annotationKinds)
                {
                    var return_v = this_param.HasAnnotations(annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 17615, 17660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 17332, 17716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 17332, 17716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotation([NotNullWhen(true)] SyntaxAnnotation? annotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 17850, 18234);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 17950, 18057) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 17950, 18057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 18002, 18042);

                    return f_692_18009_18041(_token, annotation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 17950, 18057);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 18073, 18194) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 18073, 18194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 18132, 18179);

                    return f_692_18139_18178(_nodeOrParent, annotation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 18073, 18194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 18210, 18223);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 17850, 18234);

                bool
                f_692_18009_18041(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation?
                annotation)
                {
                    var return_v = this_param.HasAnnotation(annotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 18009, 18041);
                    return return_v;
                }


                bool
                f_692_18139_18178(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation?
                annotation)
                {
                    var return_v = this_param.HasAnnotation(annotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 18139, 18178);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 17850, 18234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 17850, 18234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 18361, 18807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 18460, 18572) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 18460, 18572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 18512, 18557);

                    return f_692_18519_18556(_token, annotationKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 18460, 18572);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 18588, 18714) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 18588, 18714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 18647, 18699);

                    return f_692_18654_18698(_nodeOrParent, annotationKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 18588, 18714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 18730, 18796);

                return f_692_18737_18795();
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 18361, 18807);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_692_18519_18556(Microsoft.CodeAnalysis.GreenNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.GetAnnotations(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 18519, 18556);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_692_18654_18698(Microsoft.CodeAnalysis.SyntaxNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.GetAnnotations(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 18654, 18698);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_692_18737_18795()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<SyntaxAnnotation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 18737, 18795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 18361, 18807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 18361, 18807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(IEnumerable<string> annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 18934, 19396);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 19047, 19160) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 19047, 19160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 19099, 19145);

                    return f_692_19106_19144(_token, annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 19047, 19160);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 19176, 19303) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 19176, 19303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 19235, 19288);

                    return f_692_19242_19287(_nodeOrParent, annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 19176, 19303);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 19319, 19385);

                return f_692_19326_19384();
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 18934, 19396);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_692_19106_19144(Microsoft.CodeAnalysis.GreenNode
                this_param, System.Collections.Generic.IEnumerable<string>
                annotationKinds)
                {
                    var return_v = this_param.GetAnnotations(annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 19106, 19144);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_692_19242_19287(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Collections.Generic.IEnumerable<string>
                annotationKinds)
                {
                    var return_v = this_param.GetAnnotations(annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 19242, 19287);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_692_19326_19384()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<SyntaxAnnotation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 19326, 19384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 18934, 19396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 18934, 19396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken WithAdditionalAnnotations(params SyntaxAnnotation[] annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 19550, 19752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 19664, 19741);

                return WithAdditionalAnnotations(annotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 19550, 19752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 19550, 19752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 19550, 19752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken WithAdditionalAnnotations(IEnumerable<SyntaxAnnotation> annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 19906, 20482);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 20024, 20149) || true) && (annotations == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 20024, 20149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 20081, 20134);

                    throw f_692_20087_20133(nameof(annotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 20024, 20149);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 20165, 20293) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 20165, 20293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 20217, 20278);

                    return this.AsToken().WithAdditionalAnnotations(annotations);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 20165, 20293);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 20309, 20443) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 20309, 20443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 20368, 20428);

                    return f_692_20375_20427(_nodeOrParent, annotations);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 20309, 20443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 20459, 20471);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 19906, 20482);

                System.ArgumentNullException
                f_692_20087_20133(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 20087, 20133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_692_20375_20427(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = node.WithAdditionalAnnotations<Microsoft.CodeAnalysis.SyntaxNode>(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 20375, 20427);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 19906, 20482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 19906, 20482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken WithoutAnnotations(params SyntaxAnnotation[] annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 20639, 20827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 20746, 20816);

                return WithoutAnnotations(annotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 20639, 20827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 20639, 20827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 20639, 20827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken WithoutAnnotations(IEnumerable<SyntaxAnnotation> annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 20984, 21539);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21095, 21220) || true) && (annotations == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 21095, 21220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21152, 21205);

                    throw f_692_21158_21204(nameof(annotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 21095, 21220);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21236, 21357) || true) && (_token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 21236, 21357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21288, 21342);

                    return this.AsToken().WithoutAnnotations(annotations);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 21236, 21357);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21373, 21500) || true) && (_nodeOrParent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 21373, 21500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21432, 21485);

                    return f_692_21439_21484(_nodeOrParent, annotations);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 21373, 21500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21516, 21528);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 20984, 21539);

                System.ArgumentNullException
                f_692_21158_21204(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 21158, 21204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_692_21439_21484(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = node.WithoutAnnotations<Microsoft.CodeAnalysis.SyntaxNode>(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 21439, 21484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 20984, 21539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 20984, 21539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken WithoutAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 21704, 22137);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21795, 21926) || true) && (annotationKind == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 21795, 21926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21855, 21911);

                    throw f_692_21861_21910(nameof(annotationKind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 21795, 21926);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 21942, 22098) || true) && (this.HasAnnotations(annotationKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 21942, 22098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 22015, 22083);

                    return this.WithoutAnnotations(this.GetAnnotations(annotationKind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 21942, 22098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 22114, 22126);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 21704, 22137);

                System.ArgumentNullException
                f_692_21861_21910(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 21861, 21910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 21704, 22137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 21704, 22137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SyntaxNodeOrToken other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 22358, 22981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 22522, 22808);

                f_692_22522_22807((_nodeOrParent == other._nodeOrParent && (DynAbs.Tracing.TraceSender.Expression_True(692, 22554, 22616) && _token == other._token) && (DynAbs.Tracing.TraceSender.Expression_True(692, 22554, 22648) && _position == other._position) && (DynAbs.Tracing.TraceSender.Expression_True(692, 22554, 22684) && _tokenIndex == other._tokenIndex)) ==
                                (_nodeOrParent == other._nodeOrParent && (DynAbs.Tracing.TraceSender.Expression_True(692, 22707, 22769) && _token == other._token) && (DynAbs.Tracing.TraceSender.Expression_True(692, 22707, 22805) && _tokenIndex == other._tokenIndex)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 22824, 22970);

                return _nodeOrParent == other._nodeOrParent && (DynAbs.Tracing.TraceSender.Expression_True(692, 22831, 22913) && _token == other._token) && (DynAbs.Tracing.TraceSender.Expression_True(692, 22831, 22969) && _tokenIndex == other._tokenIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 22358, 22981);

                int
                f_692_22522_22807(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 22522, 22807);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 22358, 22981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 22358, 22981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SyntaxNodeOrToken left, SyntaxNodeOrToken right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 23120, 23261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 23224, 23250);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 23120, 23261);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 23120, 23261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 23120, 23261);
            }
        }

        public static bool operator !=(SyntaxNodeOrToken left, SyntaxNodeOrToken right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 23402, 23544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 23506, 23533);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 23402, 23544);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 23402, 23544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 23402, 23544);
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 23743, 23874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 23808, 23863);

                return obj is SyntaxNodeOrToken token && (DynAbs.Tracing.TraceSender.Expression_True(692, 23815, 23862) && Equals(token));
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 23743, 23874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 23743, 23874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 23743, 23874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 24007, 24146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 24065, 24135);

                return f_692_24072_24134(_nodeOrParent, f_692_24100_24133(_token, _tokenIndex));
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 24007, 24146);

                int
                f_692_24100_24133(Microsoft.CodeAnalysis.GreenNode?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 24100, 24133);
                    return return_v;
                }


                int
                f_692_24072_24134(Microsoft.CodeAnalysis.SyntaxNode?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 24072, 24134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 24007, 24146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 24007, 24146);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsEquivalentTo(SyntaxNodeOrToken other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 24272, 24703);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 24348, 24441) || true) && (this.IsNode != other.IsNode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 24348, 24441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 24413, 24426);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 24348, 24441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 24457, 24498);

                var
                thisUnderlying = this.UnderlyingNode
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 24512, 24555);

                var
                otherUnderlying = other.UnderlyingNode
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 24571, 24692);

                return (thisUnderlying == otherUnderlying) || (DynAbs.Tracing.TraceSender.Expression_False(692, 24578, 24691) || (thisUnderlying != null && (DynAbs.Tracing.TraceSender.Expression_True(692, 24618, 24690) && f_692_24644_24690(thisUnderlying, otherUnderlying))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 24272, 24703);

                bool
                f_692_24644_24690(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.GreenNode?
                other)
                {
                    var return_v = this_param.IsEquivalentTo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 24644, 24690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 24272, 24703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 24272, 24703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Returns a new <see cref="SyntaxNodeOrToken"/> that wraps the supplied token.
        /// </summary>
        /// <param name="token">The input token.</param>
        /// <returns>
        /// A <see cref="SyntaxNodeOrToken"/> that wraps the supplied token.
        /// </returns>
        public static implicit operator SyntaxNodeOrToken(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 25035, 25223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 25128, 25212);

                return f_692_25135_25211(token.Parent, token.Node, token.Position, token.Index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 25035, 25223);

                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_692_25135_25211(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode?
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrToken(parent, token, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 25135, 25211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 25035, 25223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 25035, 25223);
            }
        }
        /// <summary>
        /// Returns the underlying token wrapped by the supplied <see cref="SyntaxNodeOrToken"/>.
        /// </summary>
        /// <param name="nodeOrToken">
        /// The input <see cref="SyntaxNodeOrToken"/>.
        /// </param>
        /// <returns>
        /// The underlying token wrapped by the supplied <see cref="SyntaxNodeOrToken"/>.
        /// </returns>
        public static explicit operator SyntaxToken(SyntaxNodeOrToken nodeOrToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 25637, 25776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 25736, 25765);

                return nodeOrToken.AsToken();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 25637, 25776);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 25637, 25776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 25637, 25776);
            }
        }
        /// <summary>
        /// Returns a new <see cref="SyntaxNodeOrToken"/> that wraps the supplied node.
        /// </summary>
        /// <param name="node">The input node.</param>
        /// <returns>
        /// A <see cref="SyntaxNodeOrToken"/> that wraps the supplied node.
        /// </returns>
        public static implicit operator SyntaxNodeOrToken(SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 26104, 26303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 26196, 26292);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(692, 26203, 26217) || ((node is object
                && DynAbs.Tracing.TraceSender.Conditional_F2(692, 26237, 26264)) || DynAbs.Tracing.TraceSender.Conditional_F3(692, 26284, 26291))) ? f_692_26237_26264(node) : default;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 26104, 26303);

                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_692_26237_26264(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrToken(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 26237, 26264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 26104, 26303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 26104, 26303);
            }
        }
        /// <summary>
        /// Returns the underlying node wrapped by the supplied <see cref="SyntaxNodeOrToken"/>.
        /// </summary>
        /// <param name="nodeOrToken">
        /// The input <see cref="SyntaxNodeOrToken"/>.
        /// </param>
        /// <returns>
        /// The underlying node wrapped by the supplied <see cref="SyntaxNodeOrToken"/>.
        /// </returns>
        public static explicit operator SyntaxNode?(SyntaxNodeOrToken nodeOrToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 26715, 26853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 26814, 26842);

                return nodeOrToken.AsNode();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 26715, 26853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 26715, 26853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 26715, 26853);
            }
        }
        public SyntaxTree? SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 27008, 27036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 27011, 27036);
                    return f_692_27011_27036_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_nodeOrParent, 692, 27011, 27036)?.SyntaxTree); DynAbs.Tracing.TraceSender.TraceExitMethod(692, 27008, 27036);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 27008, 27036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 27008, 27036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Location? GetLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 27149, 27369);
                Microsoft.CodeAnalysis.SyntaxToken token = default(Microsoft.CodeAnalysis.SyntaxToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 27204, 27306) || true) && (AsToken(out token
                ))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 27204, 27306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 27264, 27291);

                    return token.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 27204, 27306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 27322, 27358);

                return f_692_27329_27357_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_nodeOrParent, 692, 27329, 27357)?.GetLocation());
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 27149, 27369);

                Microsoft.CodeAnalysis.Location?
                f_692_27329_27357_I(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 27329, 27357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 27149, 27369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 27149, 27369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IList<TDirective> GetDirectives<TDirective>(Func<TDirective, bool>? filter = null)
                    where TDirective : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 27502, 27848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 27661, 27697);

                List<TDirective>?
                directives = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 27711, 27755);

                GetDirectives(this, filter, ref directives);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 27769, 27837);

                return directives ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<TDirective>?>(692, 27776, 27836) ?? f_692_27790_27836());
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 27502, 27848);

                System.Collections.Generic.IList<TDirective>
                f_692_27790_27836()
                {
                    var return_v = SpecializedCollections.EmptyList<TDirective>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 27790, 27836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 27502, 27848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 27502, 27848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetDirectives<TDirective>(in SyntaxNodeOrToken node, Func<TDirective, bool>? filter, ref List<TDirective>? directives)
                    where TDirective : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 27860, 28501);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 28066, 28490) || true) && (node._token != null && (DynAbs.Tracing.TraceSender.Expression_True(692, 28070, 28120) && node.AsToken() is var token) && (DynAbs.Tracing.TraceSender.Expression_True(692, 28070, 28148) && token.ContainsDirectives))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 28066, 28490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 28182, 28241);

                    GetDirectives(token.LeadingTrivia, filter, ref directives);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 28259, 28319);

                    GetDirectives(token.TrailingTrivia, filter, ref directives);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 28066, 28490);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 28066, 28490);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 28353, 28490) || true) && (node._nodeOrParent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 28353, 28490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 28417, 28475);

                        GetDirectives(node._nodeOrParent, filter, ref directives);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 28353, 28490);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 28066, 28490);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 27860, 28501);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 27860, 28501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 27860, 28501);
            }
        }

        private static void GetDirectives<TDirective>(SyntaxNode node, Func<TDirective, bool>? filter, ref List<TDirective>? directives)
                    where TDirective : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 28513, 28929);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 28709, 28918);
                    foreach (var trivia in f_692_28732_28811_I(f_692_28732_28811(node, node => node.ContainsDirectives, descendIntoTrivia: true)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 28709, 28918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 28845, 28903);

                        _ = GetDirectivesInTrivia(trivia, filter, ref directives);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 28709, 28918);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(692, 1, 210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(692, 1, 210);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 28513, 28929);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_692_28732_28811(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantTrivia(descendIntoChildren, descendIntoTrivia: descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 28732, 28811);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_692_28732_28811_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 28732, 28811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 28513, 28929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 28513, 28929);
            }
        }

        private static bool GetDirectivesInTrivia<TDirective>(in SyntaxTrivia trivia, Func<TDirective, bool>? filter, ref List<TDirective>? directives)
                    where TDirective : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 28941, 29643);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 29152, 29605) || true) && (trivia.IsDirective)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 29152, 29605);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 29208, 29558) || true) && (trivia.GetStructure() is TDirective directive && (DynAbs.Tracing.TraceSender.Expression_True(692, 29212, 29316) && f_692_29282_29307_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(filter, 692, 29282, 29307)?.Invoke(directive)) != false))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 29208, 29558);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 29358, 29489) || true) && (directives == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 29358, 29489);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 29430, 29466);

                            directives = f_692_29443_29465();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(692, 29358, 29489);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 29513, 29539);

                        f_692_29513_29538(
                                            directives, directive);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 29208, 29558);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 29578, 29590);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 29152, 29605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 29619, 29632);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 28941, 29643);

                bool?
                f_692_29282_29307_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 29282, 29307);
                    return return_v;
                }


                System.Collections.Generic.List<TDirective>
                f_692_29443_29465()
                {
                    var return_v = new System.Collections.Generic.List<TDirective>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 29443, 29465);
                    return return_v;
                }


                int
                f_692_29513_29538(System.Collections.Generic.List<TDirective>
                this_param, TDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 29513, 29538);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 28941, 29643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 28941, 29643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetDirectives<TDirective>(in SyntaxTriviaList trivia, Func<TDirective, bool>? filter, ref List<TDirective>? directives)
                    where TDirective : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 29655, 30146);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 29862, 30135);
                    foreach (var tr in f_692_29881_29887_I(trivia))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 29862, 30135);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 29921, 30120) || true) && (!GetDirectivesInTrivia(tr, filter, ref directives) && (DynAbs.Tracing.TraceSender.Expression_True(692, 29925, 30015) && tr.GetStructure() is SyntaxNode node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 29921, 30120);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30057, 30101);

                            GetDirectives(node, filter, ref directives);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(692, 29921, 30120);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 29862, 30135);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(692, 1, 274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(692, 1, 274);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 29655, 30146);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_692_29881_29887_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 29881, 29887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 29655, 30146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 29655, 30146);
            }
        }

        internal int Width
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 30199, 30244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30202, 30244);
                    return f_692_30202_30215_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_token, 692, 30202, 30215)?.Width) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(692, 30202, 30244) ?? f_692_30219_30239_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_nodeOrParent, 692, 30219, 30239)?.Width) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(692, 30219, 30244) ?? 0)); DynAbs.Tracing.TraceSender.TraceExitMethod(692, 30199, 30244);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 30199, 30244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 30199, 30244);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 30280, 30333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30283, 30333);
                    return f_692_30283_30300_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_token, 692, 30283, 30300)?.FullWidth) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(692, 30283, 30333) ?? f_692_30304_30328_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_nodeOrParent, 692, 30304, 30328)?.FullWidth) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(692, 30304, 30333) ?? 0)); DynAbs.Tracing.TraceSender.TraceExitMethod(692, 30280, 30333);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 30280, 30333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 30280, 30333);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int EndPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 30371, 30400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30374, 30400);
                    return _position + this.FullWidth; DynAbs.Tracing.TraceSender.TraceExitMethod(692, 30371, 30400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 30371, 30400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 30371, 30400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static int GetFirstChildIndexSpanningPosition(SyntaxNode node, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 30413, 30800);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30521, 30693) || true) && (!node.FullSpan.IntersectsWith(position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 30521, 30693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30598, 30678);

                    throw f_692_30604_30677("Must be within node's FullSpan", nameof(position));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 30521, 30693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30709, 30789);

                return GetFirstChildIndexSpanningPosition(f_692_30751_30777(node), position);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 30413, 30800);

                System.ArgumentException
                f_692_30604_30677(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 30604, 30677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_692_30751_30777(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 30751, 30777);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 30413, 30800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 30413, 30800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFirstChildIndexSpanningPosition(ChildSyntaxList list, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(692, 30812, 32004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30927, 30938);

                int
                lo = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30952, 30976);

                int
                hi = list.Count - 1
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 30990, 31940) || true) && (lo <= hi)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 30990, 31940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31039, 31069);

                        int
                        r = lo + ((hi - lo) >> 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31089, 31105);

                        var
                        m = list[r]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31123, 31925) || true) && (position < m.Position)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 31123, 31925);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31190, 31201);

                            hi = r - 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(692, 31123, 31925);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 31123, 31925);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31283, 31701) || true) && (position == m.Position)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 31283, 31701);
                                try
                                {                        // If we hit a zero width node, move left to the first such node (or the
                                                         // first one in the list)
                                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31508, 31641) || true) && (r > 0 && (DynAbs.Tracing.TraceSender.Expression_True(692, 31515, 31550) && list[r - 1].FullWidth == 0))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31552, 31555)
            , r--, DynAbs.Tracing.TraceSender.TraceExitCondition(692, 31508, 31641))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 31508, 31641);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31613, 31614);
                                        ;
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(692, 1, 134);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(692, 1, 134);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31669, 31678);

                                return r;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(692, 31283, 31701);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31725, 31873) || true) && (position >= m.EndPosition)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 31725, 31873);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31804, 31815);

                                lo = r + 1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31841, 31850);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(692, 31725, 31873);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31897, 31906);

                            return r;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(692, 31123, 31925);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 30990, 31940);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(692, 30990, 31940);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(692, 30990, 31940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 31956, 31993);

                throw f_692_31962_31992();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(692, 30812, 32004);

                System.Exception
                f_692_31962_31992()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 31962, 31992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 30812, 32004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 30812, 32004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken GetNextSibling()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 32016, 32442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32082, 32107);

                var
                parent = this.Parent
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32121, 32222) || true) && (parent == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 32121, 32222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32173, 32207);

                    return default(SyntaxNodeOrToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 32121, 32222);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32238, 32282);

                var
                siblings = f_692_32253_32281(parent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32298, 32431);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(692, 32305, 32323) || ((siblings.Count < 8
                && DynAbs.Tracing.TraceSender.Conditional_F2(692, 32343, 32376)) || DynAbs.Tracing.TraceSender.Conditional_F3(692, 32396, 32430))) ? GetNextSiblingFromStart(siblings) : GetNextSiblingWithSearch(siblings);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 32016, 32442);

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_692_32253_32281(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 32253, 32281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 32016, 32442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 32016, 32442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken GetPreviousSibling()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 32454, 33186);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32524, 33125) || true) && (this.Parent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 32524, 33125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32711, 32734);

                    var
                    returnNext = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32752, 33110);
                        foreach (var child in f_692_32774_32817_I(f_692_32774_32807(this.Parent).Reverse()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 32752, 33110);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32859, 32959) || true) && (returnNext)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 32859, 32959);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32923, 32936);

                                return child;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(692, 32859, 32959);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 32983, 33091) || true) && (child == this)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 32983, 33091);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33050, 33068);

                                returnNext = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(692, 32983, 33091);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(692, 32752, 33110);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(692, 1, 359);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(692, 1, 359);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(692, 32524, 33125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33141, 33175);

                return default(SyntaxNodeOrToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 32454, 33186);

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_692_32774_32807(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 32774, 32807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.Reversed
                f_692_32774_32817_I(Microsoft.CodeAnalysis.ChildSyntaxList.Reversed
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 32774, 32817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 32454, 33186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 32454, 33186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxNodeOrToken GetNextSiblingFromStart(ChildSyntaxList siblings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 33198, 33685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33298, 33321);

                var
                returnNext = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33335, 33624);
                    foreach (var sibling in f_692_33359_33367_I(siblings))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 33335, 33624);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33401, 33491) || true) && (returnNext)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 33401, 33491);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33457, 33472);

                            return sibling;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(692, 33401, 33491);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33511, 33609) || true) && (sibling == this)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 33511, 33609);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33572, 33590);

                            returnNext = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(692, 33511, 33609);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(692, 33335, 33624);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(692, 1, 290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(692, 1, 290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33640, 33674);

                return default(SyntaxNodeOrToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 33198, 33685);

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_692_33359_33367_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 33359, 33367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 33198, 33685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 33198, 33685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxNodeOrToken GetNextSiblingWithSearch(ChildSyntaxList siblings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(692, 33697, 34332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33798, 33871);

                var
                firstIndex = GetFirstChildIndexSpanningPosition(siblings, _position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33887, 33914);

                var
                count = siblings.Count
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33928, 33951);

                var
                returnNext = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33976, 33990);

                    for (int
        i = firstIndex
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 33967, 34271) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 34003, 34006)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(692, 33967, 34271))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 33967, 34271);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 34040, 34134) || true) && (returnNext)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 34040, 34134);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 34096, 34115);

                            return siblings[i];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(692, 34040, 34134);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 34154, 34256) || true) && (siblings[i] == this)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(692, 34154, 34256);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 34219, 34237);

                            returnNext = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(692, 34154, 34256);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(692, 1, 305);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(692, 1, 305);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(692, 34287, 34321);

                return default(SyntaxNodeOrToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(692, 33697, 34332);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(692, 33697, 34332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 33697, 34332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SyntaxNodeOrToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(692, 846, 34339);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(692, 846, 34339);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(692, 846, 34339);
        }

        static Microsoft.CodeAnalysis.GreenNode
        f_692_1845_1855(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 1845, 1855);
            return return_v;
        }


        bool
        f_692_1844_1862_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 1844, 1862);
            return return_v;
        }


        static int
        f_692_1831_1888(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 1831, 1888);
            return 0;
        }


        static int
        f_692_1915_1928(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Position;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 1915, 1928);
            return return_v;
        }


        static Microsoft.CodeAnalysis.GreenNode
        f_692_2164_2176(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 2164, 2176);
            return return_v;
        }


        static bool
        f_692_2163_2183_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 2163, 2183);
            return return_v;
        }


        static int
        f_692_2132_2211(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 2132, 2211);
            return 0;
        }


        static int
        f_692_2226_2331(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 2226, 2331);
            return 0;
        }


        static bool
        f_692_2376_2389(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.IsToken;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 2376, 2389);
            return return_v;
        }


        static int
        f_692_2346_2415(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 2346, 2415);
            return 0;
        }


        static int
        f_692_2430_2484(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 2430, 2484);
            return 0;
        }


        static int
        f_692_2499_2577(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(692, 2499, 2577);
            return 0;
        }


        int?
        f_692_3446_3461_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 3446, 3461);
            return return_v;
        }


        int?
        f_692_3465_3487_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 3465, 3487);
            return return_v;
        }


        bool?
        f_692_4493_4510_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 4493, 4510);
            return return_v;
        }


        bool?
        f_692_4514_4538_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 4514, 4538);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode?
        f_692_4762_4783_M(Microsoft.CodeAnalysis.SyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 4762, 4783);
            return return_v;
        }


        Microsoft.CodeAnalysis.GreenNode?
        f_692_4844_4864_M(Microsoft.CodeAnalysis.GreenNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 4844, 4864);
            return return_v;
        }


        bool
        f_692_5305_5312_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 5305, 5312);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree?
        f_692_27011_27036_M(Microsoft.CodeAnalysis.SyntaxTree?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 27011, 27036);
            return return_v;
        }


        int?
        f_692_30202_30215_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 30202, 30215);
            return return_v;
        }


        int?
        f_692_30219_30239_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 30219, 30239);
            return return_v;
        }


        int?
        f_692_30283_30300_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 30283, 30300);
            return return_v;
        }


        int?
        f_692_30304_30328_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(692, 30304, 30328);
            return return_v;
        }

    }
}
