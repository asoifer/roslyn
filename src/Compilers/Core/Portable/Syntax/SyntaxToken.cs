// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    [StructLayout(LayoutKind.Auto)]
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public readonly struct SyntaxToken : IEquatable<SyntaxToken>
    {

        private static readonly Func<DiagnosticInfo, Diagnostic> s_createDiagnosticWithoutLocation;

        internal static readonly Func<SyntaxToken, bool> NonZeroWidth;

        internal static readonly Func<SyntaxToken, bool> Any;

        internal SyntaxToken(SyntaxNode? parent, GreenNode? token, int position, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(697, 1354, 1756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1462, 1542);

                f_697_1462_1541(parent == null || (DynAbs.Tracing.TraceSender.Expression_False(697, 1475, 1513) || f_697_1493_1513_M(!f_697_1494_1506(parent).IsList)), "list cannot be a parent");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1556, 1626);

                f_697_1556_1625(token == null || (DynAbs.Tracing.TraceSender.Expression_False(697, 1569, 1599) || f_697_1586_1599(token)), "token must be a token");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1640, 1656);

                Parent = parent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1670, 1683);

                Node = token;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1697, 1717);

                Position = position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1731, 1745);

                Index = index;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(697, 1354, 1756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 1354, 1756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 1354, 1756);
            }
        }

        internal SyntaxToken(GreenNode? token)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(697, 1768, 1961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1853, 1923);

                f_697_1853_1922(token == null || (DynAbs.Tracing.TraceSender.Expression_False(697, 1866, 1896) || f_697_1883_1896(token)), "token must be a token");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1937, 1950);

                Node = token;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(697, 1768, 1961);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 1768, 1961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 1768, 1961);
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 1973, 2133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 2033, 2122);

                return f_697_2040_2054(f_697_2040_2049(this)) + " " + ((DynAbs.Tracing.TraceSender.Conditional_F1(697, 2064, 2076) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(697, 2079, 2092)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 2095, 2101))) ? f_697_2079_2092(Node) : "None") + " " + ToString();
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 1973, 2133);

                System.Type
                f_697_2040_2049(Microsoft.CodeAnalysis.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 2040, 2049);
                    return return_v;
                }


                string
                f_697_2040_2054(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 2040, 2054);
                    return return_v;
                }


                string
                f_697_2079_2092(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.KindText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 2079, 2092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 1973, 2133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 1973, 2133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int RawKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 2290, 2311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 2293, 2311);
                    return f_697_2293_2306_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 2293, 2306)?.RawKind) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(697, 2293, 2311) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 2290, 2311);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 2290, 2311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 2290, 2311);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 2455, 2488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 2458, 2488);
                    return f_697_2458_2472_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 2458, 2472)?.Language) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(697, 2458, 2488) ?? string.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 2455, 2488);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 2455, 2488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 2455, 2488);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int RawContextualKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 3074, 3105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 3077, 3105);
                    return f_697_3077_3100_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 3077, 3100)?.RawContextualKind) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(697, 3077, 3105) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 3074, 3105);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 3074, 3105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 3074, 3105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxNode? Parent { get; }

        internal GreenNode? Node { get; }

        internal GreenNode RequiredNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 3387, 3497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 3423, 3452);

                    f_697_3423_3451(Node is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 3470, 3482);

                    return Node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(697, 3387, 3497);

                    int
                    f_697_3423_3451(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 3423, 3451);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 3331, 3508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 3331, 3508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int Index { get; }

        internal int Position { get; }

        internal int Width
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 3765, 3784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 3768, 3784);
                    return f_697_3768_3779_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 3768, 3779)?.Width) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(697, 3768, 3784) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 3765, 3784);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 3765, 3784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 3765, 3784);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 3969, 3992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 3972, 3992);
                    return f_697_3972_3987_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 3972, 3987)?.FullWidth) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(697, 3972, 3992) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 3969, 3992);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 3969, 3992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 3969, 3992);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 4204, 4363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 4240, 4348);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 4247, 4259) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(697, 4262, 4327)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 4330, 4347))) ? f_697_4262_4327(Position + f_697_4286_4314(Node), f_697_4316_4326(Node)) : default(TextSpan);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(697, 4204, 4363);

                    int
                    f_697_4286_4314(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 4286, 4314);
                        return return_v;
                    }


                    int
                    f_697_4316_4326(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.Width;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 4316, 4326);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_697_4262_4327(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 4262, 4327);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 4159, 4374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 4159, 4374);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 4435, 4495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 4441, 4493);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 4448, 4460) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(697, 4463, 4488)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 4491, 4492))) ? Position + f_697_4474_4488(Node) : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(697, 4435, 4495);

                    int
                    f_697_4474_4488(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 4474, 4488);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 4386, 4506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 4386, 4506);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 4785, 4859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 4791, 4857);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 4798, 4810) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(697, 4813, 4852)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 4855, 4856))) ? Position + f_697_4824_4852(Node) : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(697, 4785, 4859);

                    int
                    f_697_4824_4852(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 4824, 4852);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 4740, 4870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 4740, 4870);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 5057, 5093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 5060, 5093);
                    return f_697_5060_5093(Position, FullWidth); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 5057, 5093);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 5057, 5093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 5057, 5093);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 5535, 5562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 5538, 5562);
                    return f_697_5538_5553_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 5538, 5553)?.IsMissing) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(697, 5538, 5562) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 5535, 5562);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 5535, 5562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 5535, 5562);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object? Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 5810, 5829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 5813, 5829);
                    return f_697_5813_5829_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 5813, 5829)?.GetValue()); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 5810, 5829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 5810, 5829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 5810, 5829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string ValueText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 6122, 6161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 6125, 6161);
                    return f_697_6125_6145_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 6125, 6145)?.GetValueText()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(697, 6125, 6161) ?? string.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 6122, 6161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 6122, 6161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 6122, 6161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Text
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 6193, 6206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 6196, 6206);
                    return ToString(); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 6193, 6206);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 6193, 6206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 6193, 6206);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 6595, 6717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 6653, 6706);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 6660, 6672) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(697, 6675, 6690)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 6693, 6705))) ? f_697_6675_6690(Node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 6595, 6717);

                string
                f_697_6675_6690(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 6675, 6690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 6595, 6717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 6595, 6717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 7109, 7230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 7162, 7219);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 7169, 7181) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(697, 7184, 7203)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 7206, 7218))) ? f_697_7184_7203(Node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 7109, 7230);

                string
                f_697_7184_7203(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 7184, 7203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 7109, 7230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 7109, 7230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void WriteTo(System.IO.TextWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 7381, 7487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 7454, 7476);

                // LAFHIS
                DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 7454, 7475)?.WriteTo(writer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 7459, 7475);

                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 7381, 7487);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 7381, 7487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 7381, 7487);
            }
        }

        internal void WriteTo(System.IO.TextWriter writer, bool leading, bool trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 7647, 7803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 7751, 7792);

                DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 7751, 7791)?.WriteTo(writer, leading, trailing);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 7756, 7791);

                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 7647, 7803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 7647, 7803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 7647, 7803);
            }
        }

        public bool HasLeadingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 7958, 7989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 7961, 7989);
                    return this.LeadingTrivia.Count > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(697, 7958, 7989);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 7958, 7989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 7958, 7989);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 8147, 8179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 8150, 8179);
                    return this.TrailingTrivia.Count > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(697, 8147, 8179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 8147, 8179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 8147, 8179);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int LeadingWidth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 8326, 8363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 8329, 8363);
                    return f_697_8329_8358_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 8329, 8358)?.GetLeadingTriviaWidth()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(697, 8329, 8363) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 8326, 8363);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 8326, 8363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 8326, 8363);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int TrailingWidth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 8512, 8550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 8515, 8550);
                    return f_697_8515_8545_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 8515, 8545)?.GetTrailingTriviaWidth()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(697, 8515, 8550) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 8512, 8550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 8512, 8550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 8512, 8550);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 8748, 8785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 8751, 8785);
                    return f_697_8751_8776_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 8751, 8776)?.ContainsDiagnostics) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(697, 8751, 8785) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 8748, 8785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 8748, 8785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 8748, 8785);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 8963, 8999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 8966, 8999);
                    return f_697_8966_8990_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 8966, 8990)?.ContainsDirectives) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(697, 8966, 8999) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 8963, 8999);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 8963, 8999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 8963, 8999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPartOfStructuredTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 9142, 9267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 9205, 9256);

                return f_697_9212_9246_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Parent, 697, 9212, 9246)?.IsPartOfStructuredTrivia()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(697, 9212, 9255) ?? false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 9142, 9267);

                bool?
                f_697_9212_9246_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 9212, 9246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 9142, 9267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 9142, 9267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasStructuredTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 9432, 9474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 9435, 9474);
                    return f_697_9435_9465_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 9435, 9465)?.ContainsStructuredTrivia) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(697, 9435, 9474) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 9432, 9474);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 9432, 9474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 9432, 9474);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 9664, 9701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 9667, 9701);
                    return f_697_9667_9692_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 9667, 9692)?.ContainsAnnotations) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(697, 9667, 9701) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 9664, 9701);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 9664, 9701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 9664, 9701);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 9843, 9981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 9917, 9970);

                return f_697_9924_9960_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 9924, 9960)?.HasAnnotations(annotationKind)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(697, 9924, 9969) ?? false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 9843, 9981);

                bool?
                f_697_9924_9960_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 9924, 9960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 9843, 9981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 9843, 9981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotations(params string[] annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 10123, 10272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 10207, 10261);

                return f_697_10214_10251_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 10214, 10251)?.HasAnnotations(annotationKinds)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(697, 10214, 10260) ?? false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 10123, 10272);

                bool?
                f_697_10214_10251_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 10214, 10251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 10123, 10272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 10123, 10272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotation([NotNullWhen(true)] SyntaxAnnotation? annotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 10393, 10552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 10493, 10541);

                return f_697_10500_10531_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 10500, 10531)?.HasAnnotation(annotation)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(697, 10500, 10540) ?? false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 10393, 10552);

                bool?
                f_697_10500_10531_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 10500, 10531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 10393, 10552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 10393, 10552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 10683, 10899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 10782, 10888);

                return f_697_10789_10825_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 10789, 10825)?.GetAnnotations(annotationKind)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>?>(697, 10789, 10887) ?? f_697_10829_10887());
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 10683, 10899);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>?
                f_697_10789_10825_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 10789, 10825);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_697_10829_10887()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<SyntaxAnnotation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 10829, 10887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 10683, 10899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 10683, 10899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(params string[] annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 11030, 11210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 11139, 11199);

                return GetAnnotations(annotationKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 11030, 11210);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 11030, 11210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 11030, 11210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(IEnumerable<string> annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 11341, 11572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 11454, 11561);

                return f_697_11461_11498_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Node, 697, 11461, 11498)?.GetAnnotations(annotationKinds)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>?>(697, 11461, 11560) ?? f_697_11502_11560());
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 11341, 11572);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>?
                f_697_11461_11498_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 11461, 11498);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_697_11502_11560()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<SyntaxAnnotation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 11502, 11560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 11341, 11572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 11341, 11572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithAdditionalAnnotations(params SyntaxAnnotation[] annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 11775, 11971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 11883, 11960);

                return WithAdditionalAnnotations(annotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 11775, 11971);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 11775, 11971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 11775, 11971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithAdditionalAnnotations(IEnumerable<SyntaxAnnotation> annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 12174, 12754);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 12286, 12411) || true) && (annotations == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 12286, 12411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 12343, 12396);

                    throw f_697_12349_12395(nameof(annotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 12286, 12411);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 12427, 12699) || true) && (this.Node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 12427, 12699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 12482, 12684);

                    return f_697_12489_12683(parent: null, token: f_697_12569_12617(Node, annotations), position: 0, index: 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 12427, 12699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 12715, 12743);

                return default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 12174, 12754);

                System.ArgumentNullException
                f_697_12349_12395(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 12349, 12395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_697_12569_12617(Microsoft.CodeAnalysis.GreenNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = node.WithAdditionalAnnotationsGreen<Microsoft.CodeAnalysis.GreenNode>(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 12569, 12617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_697_12489_12683(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent: parent, token: token, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 12489, 12683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 12174, 12754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 12174, 12754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithoutAnnotations(params SyntaxAnnotation[] annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 12910, 13092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 13011, 13081);

                return WithoutAnnotations(annotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 12910, 13092);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 12910, 13092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 12910, 13092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithoutAnnotations(IEnumerable<SyntaxAnnotation> annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 13248, 13814);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 13353, 13478) || true) && (annotations == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 13353, 13478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 13410, 13463);

                    throw f_697_13416_13462(nameof(annotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 13353, 13478);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 13494, 13759) || true) && (this.Node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 13494, 13759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 13549, 13744);

                    return f_697_13556_13743(parent: null, token: f_697_13636_13677(Node, annotations), position: 0, index: 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 13494, 13759);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 13775, 13803);

                return default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 13248, 13814);

                System.ArgumentNullException
                f_697_13416_13462(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 13416, 13462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_697_13636_13677(Microsoft.CodeAnalysis.GreenNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = node.WithoutAnnotationsGreen<Microsoft.CodeAnalysis.GreenNode>(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 13636, 13677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_697_13556_13743(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent: parent, token: token, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 13556, 13743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 13248, 13814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 13248, 13814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithoutAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 13978, 14405);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 14063, 14194) || true) && (annotationKind == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 14063, 14194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 14123, 14179);

                    throw f_697_14129_14178(nameof(annotationKind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 14063, 14194);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 14210, 14366) || true) && (this.HasAnnotations(annotationKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 14210, 14366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 14283, 14351);

                    return this.WithoutAnnotations(this.GetAnnotations(annotationKind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 14210, 14366);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 14382, 14394);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 13978, 14405);

                System.ArgumentNullException
                f_697_14129_14178(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 14129, 14178);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 13978, 14405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 13978, 14405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken CopyAnnotationsTo(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 14748, 15420);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 14828, 14927) || true) && (token.Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 14828, 14927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 14884, 14912);

                    return default(SyntaxToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 14828, 14927);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 14943, 15021) || true) && (Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 14943, 15021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 14993, 15006);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 14943, 15021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 15037, 15082);

                var
                annotations = f_697_15055_15081(this.Node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 15096, 15380) || true) && (f_697_15100_15119_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(annotations, 697, 15100, 15119)?.Length) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 15096, 15380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 15157, 15365);

                    return f_697_15164_15364(parent: null, token: f_697_15244_15298(token.Node, annotations), position: 0, index: 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 15096, 15380);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 15396, 15409);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 14748, 15420);

                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_697_15055_15081(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 15055, 15081);
                    return return_v;
                }


                int?
                f_697_15100_15119_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 15100, 15119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_697_15244_15298(Microsoft.CodeAnalysis.GreenNode
                node, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = node.WithAdditionalAnnotationsGreen<Microsoft.CodeAnalysis.GreenNode>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>)annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 15244, 15298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_697_15164_15364(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent: parent, token: token, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 15164, 15364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 14748, 15420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 14748, 15420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList LeadingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 15645, 15859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 15681, 15844);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 15688, 15700) || ((Node != null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(697, 15724, 15794)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 15818, 15843))) ? f_697_15724_15794(this, f_697_15751_15778(Node), this.Position) : default(SyntaxTriviaList);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(697, 15645, 15859);

                    Microsoft.CodeAnalysis.GreenNode?
                    f_697_15751_15778(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaCore();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 15751, 15778);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_697_15724_15794(Microsoft.CodeAnalysis.SyntaxToken
                    token, Microsoft.CodeAnalysis.GreenNode?
                    node, int
                    position)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node, position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 15724, 15794);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 15583, 15870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 15583, 15870);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxTriviaList TrailingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 16143, 16984);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16179, 16289) || true) && (Node == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 16179, 16289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16237, 16270);

                        return default(SyntaxTriviaList);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(697, 16179, 16289);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16309, 16351);

                    var
                    leading = f_697_16323_16350(Node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16369, 16383);

                    int
                    index = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16401, 16528) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 16401, 16528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16462, 16509);

                        index = (DynAbs.Tracing.TraceSender.Conditional_F1(697, 16470, 16484) || ((f_697_16470_16484(leading) && DynAbs.Tracing.TraceSender.Conditional_F2(697, 16487, 16504)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 16507, 16508))) ? f_697_16487_16504(leading) : 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(697, 16401, 16528);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16548, 16597);

                    var
                    trailingGreen = f_697_16568_16596(Node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16615, 16664);

                    int
                    trailingPosition = Position + this.FullWidth
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16682, 16812) || true) && (trailingGreen != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 16682, 16812);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16749, 16793);

                        trailingPosition -= f_697_16769_16792(trailingGreen);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(697, 16682, 16812);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 16832, 16969);

                    return f_697_16839_16968(this, trailingGreen, trailingPosition, index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(697, 16143, 16984);

                    Microsoft.CodeAnalysis.GreenNode?
                    f_697_16323_16350(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaCore();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 16323, 16350);
                        return return_v;
                    }


                    bool
                    f_697_16470_16484(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 16470, 16484);
                        return return_v;
                    }


                    int
                    f_697_16487_16504(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 16487, 16504);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_697_16568_16596(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTriviaCore();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 16568, 16596);
                        return return_v;
                    }


                    int
                    f_697_16769_16792(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 16769, 16792);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_697_16839_16968(Microsoft.CodeAnalysis.SyntaxToken
                    token, Microsoft.CodeAnalysis.GreenNode?
                    node, int
                    position, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node, position, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 16839, 16968);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 16080, 16995);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 16080, 16995);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxToken WithTriviaFrom(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 17166, 17346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 17243, 17335);

                return this.WithLeadingTrivia(token.LeadingTrivia).WithTrailingTrivia(token.TrailingTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 17166, 17346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 17166, 17346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 17166, 17346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithLeadingTrivia(SyntaxTriviaList trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 17489, 17651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 17575, 17640);

                return this.WithLeadingTrivia(trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 17489, 17651);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 17489, 17651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 17489, 17651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithLeadingTrivia(params SyntaxTrivia[]? trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 17795, 17964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 17887, 17953);

                return this.WithLeadingTrivia(trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 17795, 17964);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 17795, 17964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 17795, 17964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithLeadingTrivia(IEnumerable<SyntaxTrivia>? trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 18107, 18430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 18203, 18419);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 18210, 18222) || ((Node != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(697, 18242, 18378)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 18398, 18418))) ? f_697_18242_18378(null, f_697_18264_18354(Node, f_697_18287_18353(trivia, static t => t.RequiredUnderlyingNode)), position: 0, index: 0) : default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 18107, 18430);

                Microsoft.CodeAnalysis.GreenNode?
                f_697_18287_18353(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?
                enumerable, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.GreenNode>
                select)
                {
                    var return_v = GreenNode.CreateList(enumerable, select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 18287, 18353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_697_18264_18354(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.GreenNode?
                trivia)
                {
                    var return_v = this_param.WithLeadingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 18264, 18354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_697_18242_18378(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent, token, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 18242, 18378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 18107, 18430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 18107, 18430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithTrailingTrivia(SyntaxTriviaList trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 18574, 18738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 18661, 18727);

                return this.WithTrailingTrivia(trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 18574, 18738);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 18574, 18738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 18574, 18738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithTrailingTrivia(params SyntaxTrivia[]? trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 18882, 19053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 18975, 19042);

                return this.WithTrailingTrivia(trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 18882, 19053);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 18882, 19053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 18882, 19053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken WithTrailingTrivia(IEnumerable<SyntaxTrivia>? trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 19197, 19522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 19294, 19511);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 19301, 19313) || ((Node != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(697, 19333, 19470)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 19490, 19510))) ? f_697_19333_19470(null, f_697_19355_19446(Node, f_697_19379_19445(trivia, static t => t.RequiredUnderlyingNode)), position: 0, index: 0) : default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 19197, 19522);

                Microsoft.CodeAnalysis.GreenNode?
                f_697_19379_19445(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?
                enumerable, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.GreenNode>
                select)
                {
                    var return_v = GreenNode.CreateList(enumerable, select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 19379, 19445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_697_19355_19446(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.GreenNode?
                trivia)
                {
                    var return_v = this_param.WithTrailingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 19355, 19446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_697_19333_19470(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent, token, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 19333, 19470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 19197, 19522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 19197, 19522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxTrivia> GetAllTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 19668, 20208);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 19740, 20001) || true) && (this.HasLeadingTrivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 19740, 20001);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 19799, 19940) || true) && (this.HasTrailingTrivia)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 19799, 19940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 19867, 19921);

                        // LAFHIS
                        //return f_697_19874_19920(this.LeadingTrivia, this.TrailingTrivia);
                        var return_v = this.LeadingTrivia.Concat<Microsoft.CodeAnalysis.SyntaxTrivia>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>)this.TrailingTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 19874, 19920);
                        return return_v;

                        DynAbs.Tracing.TraceSender.TraceExitCondition(697, 19799, 19940);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 19960, 19986);

                    return this.LeadingTrivia;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 19740, 20001);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 20017, 20119) || true) && (this.HasTrailingTrivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 20017, 20119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 20077, 20104);

                    return this.TrailingTrivia;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 20017, 20119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 20135, 20197);

                return f_697_20142_20196();
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 19668, 20208);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_697_19874_19920(ref Microsoft.CodeAnalysis.SyntaxTriviaList
                first, Microsoft.CodeAnalysis.SyntaxTriviaList
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.SyntaxTrivia>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 19874, 19920);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_697_20142_20196()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<SyntaxTrivia>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 20142, 20196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 19668, 20208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 19668, 20208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SyntaxToken left, SyntaxToken right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(697, 20341, 20470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 20433, 20459);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(697, 20341, 20470);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 20341, 20470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 20341, 20470);
            }
        }

        public static bool operator !=(SyntaxToken left, SyntaxToken right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(697, 20605, 20735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 20697, 20724);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(697, 20605, 20735);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 20605, 20735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 20605, 20735);
            }
        }

        public bool Equals(SyntaxToken other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 20922, 21161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 20984, 21150);

                return Parent == other.Parent && (DynAbs.Tracing.TraceSender.Expression_True(697, 20991, 21055) && Node == other.Node) && (DynAbs.Tracing.TraceSender.Expression_True(697, 20991, 21105) && Position == other.Position) && (DynAbs.Tracing.TraceSender.Expression_True(697, 20991, 21149) && Index == other.Index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 20922, 21161);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 20922, 21161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 20922, 21161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 21348, 21478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 21413, 21467);

                return obj is SyntaxToken && (DynAbs.Tracing.TraceSender.Expression_True(697, 21420, 21466) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 21348, 21478);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 21348, 21478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 21348, 21478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 21605, 21753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 21663, 21742);

                return f_697_21670_21741(Parent, f_697_21691_21740(Node, f_697_21710_21739(Position, Index)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 21605, 21753);

                int
                f_697_21710_21739(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 21710, 21739);
                    return return_v;
                }


                int
                f_697_21691_21740(Microsoft.CodeAnalysis.GreenNode?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 21691, 21740);
                    return return_v;
                }


                int
                f_697_21670_21741(Microsoft.CodeAnalysis.SyntaxNode?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 21670, 21741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 21605, 21753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 21605, 21753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken GetNextToken(bool includeZeroWidth = false, bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 21970, 22415);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 22161, 22254) || true) && (Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 22161, 22254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 22211, 22239);

                    return default(SyntaxToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 22161, 22254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 22270, 22404);

                return f_697_22277_22403(SyntaxNavigator.Instance, this, includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 21970, 22415);

                Microsoft.CodeAnalysis.SyntaxToken
                f_697_22277_22403(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, bool
                includeZeroWidth, bool
                includeSkipped, bool
                includeDirectives, bool
                includeDocumentationComments)
                {
                    var return_v = this_param.GetNextToken(current, includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 22277, 22403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 21970, 22415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 21970, 22415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetNextToken(Func<SyntaxToken, bool> predicate, Func<SyntaxTrivia, bool>? stepInto = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 22848, 23176);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 22984, 23077) || true) && (Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 22984, 23077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 23034, 23062);

                    return default(SyntaxToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 22984, 23077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 23093, 23165);

                return f_697_23100_23164(SyntaxNavigator.Instance, this, predicate, stepInto);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 22848, 23176);

                Microsoft.CodeAnalysis.SyntaxToken
                f_697_23100_23164(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetNextToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 23100, 23164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 22848, 23176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 22848, 23176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken GetPreviousToken(bool includeZeroWidth = false, bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 23399, 23852);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 23594, 23687) || true) && (Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 23594, 23687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 23644, 23672);

                    return default(SyntaxToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 23594, 23687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 23703, 23841);

                return f_697_23710_23840(SyntaxNavigator.Instance, this, includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 23399, 23852);

                Microsoft.CodeAnalysis.SyntaxToken
                f_697_23710_23840(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, bool
                includeZeroWidth, bool
                includeSkipped, bool
                includeDirectives, bool
                includeDocumentationComments)
                {
                    var return_v = this_param.GetPreviousToken(current, includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 23710, 23840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 23399, 23852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 23399, 23852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetPreviousToken(Func<SyntaxToken, bool> predicate, Func<SyntaxTrivia, bool>? stepInto = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 24286, 24513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 24426, 24502);

                return f_697_24433_24501(SyntaxNavigator.Instance, this, predicate, stepInto);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 24286, 24513);

                Microsoft.CodeAnalysis.SyntaxToken
                f_697_24433_24501(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetPreviousToken(current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 24433, 24501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 24286, 24513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 24286, 24513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTree? SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 24656, 24677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 24659, 24677);
                    return f_697_24659_24677_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Parent, 697, 24659, 24677)?.SyntaxTree); DynAbs.Tracing.TraceSender.TraceExitMethod(697, 24656, 24677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 24656, 24677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 24656, 24677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Location GetLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 24784, 24982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 24838, 24860);

                var
                tree = SyntaxTree
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 24876, 24971);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 24883, 24895) || ((tree == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(697, 24915, 24928)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 24948, 24970))) ? f_697_24915_24928() : f_697_24948_24970(tree, Span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 24784, 24982);

                Microsoft.CodeAnalysis.Location
                f_697_24915_24928()
                {
                    var return_v = Location.None
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 24915, 24928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_697_24948_24970(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetLocation(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 24948, 24970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 24784, 24982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 24784, 24982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<Diagnostic> GetDiagnostics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 25275, 25895);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 25347, 25472) || true) && (Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 25347, 25472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 25397, 25457);

                    return f_697_25404_25456();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 25347, 25472);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 25488, 25510);

                var
                tree = SyntaxTree
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 25526, 25835) || true) && (tree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(697, 25526, 25835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 25576, 25616);

                    var
                    diagnostics = f_697_25594_25615(Node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 25636, 25820);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(697, 25643, 25666) || ((f_697_25643_25661(diagnostics) == 0
                    && DynAbs.Tracing.TraceSender.Conditional_F2(697, 25690, 25742)) || DynAbs.Tracing.TraceSender.Conditional_F3(697, 25766, 25819))) ? f_697_25690_25742() : f_697_25766_25819(diagnostics, s_createDiagnosticWithoutLocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(697, 25526, 25835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 25851, 25884);

                return f_697_25858_25883(tree, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 25275, 25895);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_697_25404_25456()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 25404, 25456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_697_25594_25615(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 25594, 25615);
                    return return_v;
                }


                int
                f_697_25643_25661(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 25643, 25661);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_697_25690_25742()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 25690, 25742);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_697_25766_25819(Microsoft.CodeAnalysis.DiagnosticInfo[]
                source, System.Func<Microsoft.CodeAnalysis.DiagnosticInfo, Microsoft.CodeAnalysis.Diagnostic>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.DiagnosticInfo, Microsoft.CodeAnalysis.Diagnostic>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 25766, 25819);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_697_25858_25883(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.GetDiagnostics(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 25858, 25883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 25275, 25895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 25275, 25895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsEquivalentTo(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(697, 26030, 26264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 26100, 26253);

                return
                                (Node == null && (DynAbs.Tracing.TraceSender.Expression_True(697, 26125, 26159) && token.Node == null)) || (DynAbs.Tracing.TraceSender.Expression_False(697, 26124, 26252) || (Node != null && (DynAbs.Tracing.TraceSender.Expression_True(697, 26182, 26216) && token.Node != null) && (DynAbs.Tracing.TraceSender.Expression_True(697, 26182, 26251) && f_697_26220_26251(Node, token.Node))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(697, 26030, 26264);

                bool
                f_697_26220_26251(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.GreenNode
                other)
                {
                    var return_v = this_param.IsEquivalentTo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 26220, 26251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(697, 26030, 26264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 26030, 26264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SyntaxToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(697, 896, 26271);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1120, 1173);
            s_createDiagnosticWithoutLocation = Diagnostic.Create; DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1235, 1266);
            NonZeroWidth = t => t.Width > 0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(697, 1326, 1341);
            Any = t => true; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(697, 896, 26271);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(697, 896, 26271);
        }

        static Microsoft.CodeAnalysis.GreenNode
        f_697_1494_1506(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 1494, 1506);
            return return_v;
        }


        static bool
        f_697_1493_1513_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 1493, 1513);
            return return_v;
        }


        static int
        f_697_1462_1541(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 1462, 1541);
            return 0;
        }


        static bool
        f_697_1586_1599(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.IsToken;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 1586, 1599);
            return return_v;
        }


        static int
        f_697_1556_1625(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 1556, 1625);
            return 0;
        }


        static bool
        f_697_1883_1896(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.IsToken;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 1883, 1896);
            return return_v;
        }


        static int
        f_697_1853_1922(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 1853, 1922);
            return 0;
        }


        int?
        f_697_2293_2306_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 2293, 2306);
            return return_v;
        }


        string?
        f_697_2458_2472_M(string?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 2458, 2472);
            return return_v;
        }


        int?
        f_697_3077_3100_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 3077, 3100);
            return return_v;
        }


        int?
        f_697_3768_3779_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 3768, 3779);
            return return_v;
        }


        int?
        f_697_3972_3987_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 3972, 3987);
            return return_v;
        }


        Microsoft.CodeAnalysis.Text.TextSpan
        f_697_5060_5093(int
        start, int
        length)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 5060, 5093);
            return return_v;
        }


        bool?
        f_697_5538_5553_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 5538, 5553);
            return return_v;
        }


        object?
        f_697_5813_5829_I(object?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 5813, 5829);
            return return_v;
        }


        string?
        f_697_6125_6145_I(string?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 6125, 6145);
            return return_v;
        }


        int?
        f_697_8329_8358_I(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 8329, 8358);
            return return_v;
        }


        int?
        f_697_8515_8545_I(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(697, 8515, 8545);
            return return_v;
        }


        bool?
        f_697_8751_8776_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 8751, 8776);
            return return_v;
        }


        bool?
        f_697_8966_8990_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 8966, 8990);
            return return_v;
        }


        bool?
        f_697_9435_9465_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 9435, 9465);
            return return_v;
        }


        bool?
        f_697_9667_9692_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 9667, 9692);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree?
        f_697_24659_24677_M(Microsoft.CodeAnalysis.SyntaxTree?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(697, 24659, 24677);
            return return_v;
        }

    }
}
