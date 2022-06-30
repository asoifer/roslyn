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

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SyntaxTrivia : IEquatable<SyntaxTrivia>
    {

        internal static readonly Func<SyntaxTrivia, bool> Any;

        internal SyntaxTrivia(in SyntaxToken token, GreenNode? triviaNode, int position, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(705, 945, 1276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 1061, 1075);

                Token = token;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 1089, 1117);

                UnderlyingNode = triviaNode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 1131, 1151);

                Position = position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 1165, 1179);

                Index = index;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 1195, 1265);

                f_705_1195_1264(this.RawKind != 0 || (DynAbs.Tracing.TraceSender.Expression_False(705, 1208, 1263) || this.Equals(default(SyntaxTrivia))));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(705, 945, 1276);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 945, 1276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 945, 1276);
            }
        }

        public int RawKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 1434, 1465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 1437, 1465);
                    return f_705_1437_1460_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 1437, 1460)?.RawKind) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(705, 1437, 1465) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 1434, 1465);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 1434, 1465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 1434, 1465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 1478, 1635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 1538, 1624);

                return f_705_1545_1559(f_705_1545_1554(this)) + " " + (f_705_1569_1593_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 1569, 1593)?.KindText) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(705, 1569, 1603) ?? "None")) + " " + ToString();
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 1478, 1635);

                System.Type
                f_705_1545_1554(Microsoft.CodeAnalysis.SyntaxTrivia
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 1545, 1554);
                    return return_v;
                }


                string
                f_705_1545_1559(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 1545, 1559);
                    return return_v;
                }


                string?
                f_705_1569_1593_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 1569, 1593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 1478, 1635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 1478, 1635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 1779, 1822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 1782, 1822);
                    return f_705_1782_1806_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 1782, 1806)?.Language) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(705, 1782, 1822) ?? string.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 1779, 1822);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 1779, 1822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 1779, 1822);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxToken Token { get; }

        internal GreenNode? UnderlyingNode { get; }

        internal GreenNode RequiredUnderlyingNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 2154, 2308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 2190, 2216);

                    var
                    node = UnderlyingNode
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 2234, 2263);

                    f_705_2234_2262(node is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 2281, 2293);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(705, 2154, 2308);

                    int
                    f_705_2234_2262(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 2234, 2262);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 2088, 2319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 2088, 2319);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int Position { get; }

        internal int Index { get; }

        internal int Width
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 2736, 2765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 2739, 2765);
                    return f_705_2739_2760_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 2739, 2760)?.Width) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(705, 2739, 2765) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 2736, 2765);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 2736, 2765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 2736, 2765);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 3089, 3122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 3092, 3122);
                    return f_705_3092_3117_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 3092, 3117)?.FullWidth) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(705, 3092, 3122) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 3089, 3122);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 3089, 3122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 3089, 3122);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 3487, 3718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 3523, 3703);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(705, 3530, 3552) || ((UnderlyingNode != null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(705, 3576, 3661)) || DynAbs.Tracing.TraceSender.Conditional_F3(705, 3685, 3702))) ? f_705_3576_3661(Position + f_705_3600_3638(UnderlyingNode), f_705_3640_3660(UnderlyingNode)) : default(TextSpan);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(705, 3487, 3718);

                    int
                    f_705_3600_3638(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 3600, 3638);
                        return return_v;
                    }


                    int
                    f_705_3640_3660(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.Width;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 3640, 3660);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_705_3576_3661(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 3576, 3661);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 3442, 3729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 3442, 3729);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 4008, 4214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 4044, 4172);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(705, 4051, 4073) || ((UnderlyingNode != null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(705, 4097, 4146)) || DynAbs.Tracing.TraceSender.Conditional_F3(705, 4170, 4171))) ? Position + f_705_4108_4146(UnderlyingNode) : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(705, 4008, 4214);

                    int
                    f_705_4108_4146(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 4108, 4146);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 3963, 4225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 3963, 4225);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 4576, 4685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 4582, 4683);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(705, 4589, 4611) || ((UnderlyingNode != null && DynAbs.Tracing.TraceSender.Conditional_F2(705, 4614, 4662)) || DynAbs.Tracing.TraceSender.Conditional_F3(705, 4665, 4682))) ? f_705_4614_4662(Position, f_705_4637_4661(UnderlyingNode)) : default(TextSpan);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(705, 4576, 4685);

                    int
                    f_705_4637_4661(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 4637, 4661);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_705_4614_4662(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 4614, 4662);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 4527, 4696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 4527, 4696);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 5060, 5107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 5063, 5107);
                    return f_705_5063_5098_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 5063, 5098)?.ContainsDiagnostics) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 5063, 5107) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 5060, 5107);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 5060, 5107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 5060, 5107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasStructure
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 5260, 5306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 5263, 5306);
                    return f_705_5263_5297_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 5263, 5297)?.IsStructuredTrivia) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 5263, 5306) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 5260, 5306);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 5260, 5306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 5260, 5306);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPartOfStructuredTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 5450, 5581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 5513, 5570);

                return f_705_5520_5560_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Token.Parent, 705, 5520, 5560).IsPartOfStructuredTrivia()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 5520, 5569) ?? false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 5450, 5581);

                bool?
                f_705_5520_5560_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 5520, 5560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 5450, 5581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 5450, 5581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ContainsAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 5759, 5806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 5762, 5806);
                    return f_705_5762_5797_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 5762, 5797)?.ContainsAnnotations) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 5762, 5806) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 5759, 5806);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 5759, 5806);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 5759, 5806);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 5958, 6106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 6032, 6095);

                return f_705_6039_6085_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 6039, 6085)?.HasAnnotations(annotationKind)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 6039, 6094) ?? false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 5958, 6106);

                bool?
                f_705_6039_6085_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 6039, 6085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 5958, 6106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 5958, 6106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotations(params string[] annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 6262, 6421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 6346, 6410);

                return f_705_6353_6400_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 6353, 6400)?.HasAnnotations(annotationKinds)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 6353, 6409) ?? false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 6262, 6421);

                bool?
                f_705_6353_6400_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 6353, 6400);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 6262, 6421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 6262, 6421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotation([NotNullWhen(true)] SyntaxAnnotation? annotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 6553, 6722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 6653, 6711);

                return f_705_6660_6701_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 6660, 6701)?.HasAnnotation(annotation)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 6660, 6710) ?? false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 6553, 6722);

                bool?
                f_705_6660_6701_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 6660, 6701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 6553, 6722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 6553, 6722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 6852, 7135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 6951, 7124);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(705, 6958, 6980) || ((UnderlyingNode != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(705, 7000, 7045)) || DynAbs.Tracing.TraceSender.Conditional_F3(705, 7065, 7123))) ? f_705_7000_7045(UnderlyingNode, annotationKind) : f_705_7065_7123();
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 6852, 7135);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_705_7000_7045(Microsoft.CodeAnalysis.GreenNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.GetAnnotations(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 7000, 7045);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_705_7065_7123()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<SyntaxAnnotation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 7065, 7123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 6852, 7135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 6852, 7135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(params string[] annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 7266, 7560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 7375, 7549);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(705, 7382, 7404) || ((UnderlyingNode != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(705, 7424, 7470)) || DynAbs.Tracing.TraceSender.Conditional_F3(705, 7490, 7548))) ? f_705_7424_7470(UnderlyingNode, annotationKinds) : f_705_7490_7548();
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 7266, 7560);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_705_7424_7470(Microsoft.CodeAnalysis.GreenNode
                this_param, string[]
                annotationKinds)
                {
                    var return_v = this_param.GetAnnotations((System.Collections.Generic.IEnumerable<string>)annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 7424, 7470);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_705_7490_7548()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<SyntaxAnnotation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 7490, 7548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 7266, 7560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 7266, 7560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsDirective
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 7724, 7763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 7727, 7763);
                    return f_705_7727_7754_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 7727, 7754)?.IsDirective) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 7727, 7763) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 7724, 7763);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 7724, 7763);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 7724, 7763);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsSkippedTokensTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 7812, 7861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 7815, 7861);
                    return f_705_7815_7852_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 7815, 7852)?.IsSkippedTokensTrivia) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 7815, 7861) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 7812, 7861);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 7812, 7861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 7812, 7861);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsDocumentationCommentTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 7915, 7971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 7918, 7971);
                    return f_705_7918_7962_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 7918, 7962)?.IsDocumentationCommentTrivia) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(705, 7918, 7971) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(705, 7915, 7971);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 7915, 7971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 7915, 7971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxNode? GetStructure()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 8291, 8424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 8349, 8413);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(705, 8356, 8368) || ((HasStructure && DynAbs.Tracing.TraceSender.Conditional_F2(705, 8371, 8405)) || DynAbs.Tracing.TraceSender.Conditional_F3(705, 8408, 8412))) ? f_705_8371_8405(UnderlyingNode!, this) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 8291, 8424);

                Microsoft.CodeAnalysis.SyntaxNode
                f_705_8371_8405(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                parentTrivia)
                {
                    var return_v = this_param.GetStructure(parentTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 8371, 8405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 8291, 8424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 8291, 8424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryGetStructure([NotNullWhen(true)] out SyntaxNode? structure)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 8436, 8616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 8537, 8564);

                structure = GetStructure();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 8578, 8605);

                return structure is object;
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 8436, 8616);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 8436, 8616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 8436, 8616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 9094, 9236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 9152, 9225);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(705, 9159, 9181) || ((UnderlyingNode != null && DynAbs.Tracing.TraceSender.Conditional_F2(705, 9184, 9209)) || DynAbs.Tracing.TraceSender.Conditional_F3(705, 9212, 9224))) ? f_705_9184_9209(UnderlyingNode) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 9094, 9236);

                string
                f_705_9184_9209(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 9184, 9209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 9094, 9236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 9094, 9236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 9724, 9865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 9777, 9854);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(705, 9784, 9806) || ((UnderlyingNode != null && DynAbs.Tracing.TraceSender.Conditional_F2(705, 9809, 9838)) || DynAbs.Tracing.TraceSender.Conditional_F3(705, 9841, 9853))) ? f_705_9809_9838(UnderlyingNode) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 9724, 9865);

                string
                f_705_9809_9838(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 9809, 9838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 9724, 9865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 9724, 9865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void WriteTo(System.IO.TextWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 10002, 10118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 10075, 10107);

                // LAFHIS
                DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(UnderlyingNode, 705, 10075, 10106)?.WriteTo(writer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 10090, 10106);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 10002, 10118);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 10002, 10118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 10002, 10118);
            }
        }

        public static bool operator ==(SyntaxTrivia left, SyntaxTrivia right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(705, 10252, 10383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 10346, 10372);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(705, 10252, 10383);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 10252, 10383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 10252, 10383);
            }
        }

        public static bool operator !=(SyntaxTrivia left, SyntaxTrivia right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(705, 10519, 10651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 10613, 10640);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(705, 10519, 10651);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 10519, 10651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 10519, 10651);
            }
        }

        public bool Equals(SyntaxTrivia other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 10840, 11038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 10903, 11027);

                return Token == other.Token && (DynAbs.Tracing.TraceSender.Expression_True(705, 10910, 10972) && UnderlyingNode == other.UnderlyingNode) && (DynAbs.Tracing.TraceSender.Expression_True(705, 10910, 11002) && Position == other.Position) && (DynAbs.Tracing.TraceSender.Expression_True(705, 10910, 11026) && Index == other.Index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 10840, 11038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 10840, 11038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 10840, 11038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 11227, 11355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 11292, 11344);

                return obj is SyntaxTrivia trivia && (DynAbs.Tracing.TraceSender.Expression_True(705, 11299, 11343) && Equals(trivia));
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 11227, 11355);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 11227, 11355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 11227, 11355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 11483, 11654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 11541, 11643);

                return f_705_11548_11642(Token.GetHashCode(), f_705_11582_11641(UnderlyingNode, f_705_11611_11640(Position, Index)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 11483, 11654);

                int
                f_705_11611_11640(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 11611, 11640);
                    return return_v;
                }


                int
                f_705_11582_11641(Microsoft.CodeAnalysis.GreenNode?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 11582, 11641);
                    return return_v;
                }


                int
                f_705_11548_11642(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 11548, 11642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 11483, 11654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 11483, 11654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTrivia WithAdditionalAnnotations(params SyntaxAnnotation[] annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 11815, 12012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 11924, 12001);

                return WithAdditionalAnnotations(annotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 11815, 12012);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 11815, 12012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 11815, 12012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTrivia WithAdditionalAnnotations(IEnumerable<SyntaxAnnotation> annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 12143, 12750);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 12256, 12381) || true) && (annotations == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(705, 12256, 12381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 12313, 12366);

                    throw f_705_12319_12365(nameof(annotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(705, 12256, 12381);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 12397, 12694) || true) && (this.UnderlyingNode != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(705, 12397, 12694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 12462, 12679);

                    return f_705_12469_12678(token: default(SyntaxToken), triviaNode: f_705_12570_12633(this.UnderlyingNode, annotations), position: 0, index: 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(705, 12397, 12694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 12710, 12739);

                return default(SyntaxTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 12143, 12750);

                System.ArgumentNullException
                f_705_12319_12365(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 12319, 12365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_705_12570_12633(Microsoft.CodeAnalysis.GreenNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = node.WithAdditionalAnnotationsGreen<Microsoft.CodeAnalysis.GreenNode>(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 12570, 12633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_705_12469_12678(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode
                triviaNode, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token: token, triviaNode: triviaNode, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 12469, 12678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 12143, 12750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 12143, 12750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTrivia WithoutAnnotations(params SyntaxAnnotation[] annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 12884, 13067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 12986, 13056);

                return WithoutAnnotations(annotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 12884, 13067);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 12884, 13067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 12884, 13067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTrivia WithoutAnnotations(IEnumerable<SyntaxAnnotation> annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 13201, 13794);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 13307, 13432) || true) && (annotations == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(705, 13307, 13432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 13364, 13417);

                    throw f_705_13370_13416(nameof(annotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(705, 13307, 13432);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 13448, 13738) || true) && (this.UnderlyingNode != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(705, 13448, 13738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 13513, 13723);

                    return f_705_13520_13722(token: default(SyntaxToken), triviaNode: f_705_13621_13677(this.UnderlyingNode, annotations), position: 0, index: 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(705, 13448, 13738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 13754, 13783);

                return default(SyntaxTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 13201, 13794);

                System.ArgumentNullException
                f_705_13370_13416(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 13370, 13416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_705_13621_13677(Microsoft.CodeAnalysis.GreenNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = node.WithoutAnnotationsGreen<Microsoft.CodeAnalysis.GreenNode>(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 13621, 13677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_705_13520_13722(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode
                triviaNode, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token: token, triviaNode: triviaNode, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 13520, 13722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 13201, 13794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 13201, 13794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTrivia WithoutAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 13936, 14364);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14022, 14153) || true) && (annotationKind == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(705, 14022, 14153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14082, 14138);

                    throw f_705_14088_14137(nameof(annotationKind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(705, 14022, 14153);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14169, 14325) || true) && (this.HasAnnotations(annotationKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(705, 14169, 14325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14242, 14310);

                    return this.WithoutAnnotations(this.GetAnnotations(annotationKind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(705, 14169, 14325);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14341, 14353);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 13936, 14364);

                System.ArgumentNullException
                f_705_14088_14137(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 14088, 14137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 13936, 14364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 13936, 14364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTrivia CopyAnnotationsTo(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 14579, 15315);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14662, 14773) || true) && (trivia.UnderlyingNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(705, 14662, 14773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14729, 14758);

                    return default(SyntaxTrivia);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(705, 14662, 14773);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14789, 14883) || true) && (this.UnderlyingNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(705, 14789, 14883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14854, 14868);

                    return trivia;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(705, 14789, 14883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14899, 14954);

                var
                annotations = f_705_14917_14953(this.UnderlyingNode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 14968, 15081) || true) && (annotations == null || (DynAbs.Tracing.TraceSender.Expression_False(705, 14972, 15018) || f_705_14995_15013(annotations) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(705, 14968, 15081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 15052, 15066);

                    return trivia;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(705, 14968, 15081);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 15097, 15304);

                return f_705_15104_15303(token: default(SyntaxToken), triviaNode: f_705_15197_15262(trivia.UnderlyingNode, annotations), position: 0, index: 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 14579, 15315);

                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_705_14917_14953(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 14917, 14953);
                    return return_v;
                }


                int
                f_705_14995_15013(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 14995, 15013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_705_15197_15262(Microsoft.CodeAnalysis.GreenNode
                node, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = node.WithAdditionalAnnotationsGreen<Microsoft.CodeAnalysis.GreenNode>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>)annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 15197, 15262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_705_15104_15303(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode
                triviaNode, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token: token, triviaNode: triviaNode, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 15104, 15303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 14579, 15315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 14579, 15315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTree? SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 15509, 15584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 15545, 15569);

                    return Token.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(705, 15509, 15584);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 15455, 15595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 15455, 15595);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Location GetLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 15700, 15874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 15816, 15863);

                return f_705_15823_15862(this.SyntaxTree!, this.Span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 15700, 15874);

                Microsoft.CodeAnalysis.Location
                f_705_15823_15862(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetLocation(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 15823, 15862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 15700, 15874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 15700, 15874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<Diagnostic> GetDiagnostics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 16145, 16335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 16279, 16324);

                return f_705_16286_16323(this.SyntaxTree!, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 16145, 16335);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_705_16286_16323(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    var return_v = this_param.GetDiagnostics(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 16286, 16323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 16145, 16335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 16145, 16335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsEquivalentTo(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(705, 16472, 16771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 16544, 16760);

                return
                                (UnderlyingNode == null && (DynAbs.Tracing.TraceSender.Expression_True(705, 16569, 16624) && trivia.UnderlyingNode == null)) || (DynAbs.Tracing.TraceSender.Expression_False(705, 16568, 16759) || (UnderlyingNode != null && (DynAbs.Tracing.TraceSender.Expression_True(705, 16647, 16702) && trivia.UnderlyingNode != null) && (DynAbs.Tracing.TraceSender.Expression_True(705, 16647, 16758) && f_705_16706_16758(UnderlyingNode, trivia.UnderlyingNode))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(705, 16472, 16771);

                bool
                f_705_16706_16758(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.GreenNode
                other)
                {
                    var return_v = this_param.IsEquivalentTo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 16706, 16758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(705, 16472, 16771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 16472, 16771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SyntaxTrivia()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(705, 698, 16778);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(705, 917, 932);
            Any = t => true; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(705, 698, 16778);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(705, 698, 16778);
        }

        static int
        f_705_1195_1264(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(705, 1195, 1264);
            return 0;
        }


        int?
        f_705_1437_1460_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 1437, 1460);
            return return_v;
        }


        string?
        f_705_1782_1806_M(string?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 1782, 1806);
            return return_v;
        }


        int?
        f_705_2739_2760_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 2739, 2760);
            return return_v;
        }


        int?
        f_705_3092_3117_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 3092, 3117);
            return return_v;
        }


        bool?
        f_705_5063_5098_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 5063, 5098);
            return return_v;
        }


        bool?
        f_705_5263_5297_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 5263, 5297);
            return return_v;
        }


        bool?
        f_705_5762_5797_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 5762, 5797);
            return return_v;
        }


        bool?
        f_705_7727_7754_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 7727, 7754);
            return return_v;
        }


        bool?
        f_705_7815_7852_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 7815, 7852);
            return return_v;
        }


        bool?
        f_705_7918_7962_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(705, 7918, 7962);
            return return_v;
        }

    }
}
